

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Orm.Framework.Services;
using Orm.Framework.Services.ServiceDBBase;
using Orm.Model;
using Orm.Redis;

namespace Orm.Framework.Services
{
    public partial class DBClientBase
    {

        /// <summary>
        /// 得到查询的sql语句
        /// </summary>
        /// <param name="epression">筛选条件</param>
        /// <returns></returns>
        public string Query<T>(Expression<Func<T, bool>> epression) where T : BaseModel, new()
        {
            string s = "person => person.Age >= 18";
            //获取输入参数
            ParameterExpression param = epression.Parameters[0];
            BinaryExpression body = (BinaryExpression)epression.Body;
            //获取lambda表达式主体部分
            body = (BinaryExpression)epression.Body;
            //解析 person.Age
            Expression left = body.Left;
            string name = (left as MemberExpression).Member.Name;
            //获取主体的右部分
            ConstantExpression right = (ConstantExpression)body.Right;
            //获取运算符
            ExpressionType nodeType = body.NodeType;
            StringBuilder sb = new StringBuilder();
            //使用反射获取实体所有属性，拼接在sql语句中
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            sb.Append("select ");
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo property = properties[i];
                if (i == properties.Length - 1)
                {
                    sb.Append(property.Name + " ");
                }
                else
                {
                    sb.Append(property.Name + " ,");
                }
            }
            sb.Append("from ");
            sb.Append(type.Name);
            sb.Append(" where ");
            sb.Append(name);
            if (nodeType == ExpressionType.GreaterThanOrEqual)
            {
                sb.Append(">=");
            }
            sb.Append(right);
            return sb.ToString();
        }

        /// <summary>
        /// 用于处理Delete<T>(string lambdaExpression, params string[] ns) eg Delete</BsUser>("t=>t.GUID=='fadsd322sdas'", "Orm.Model");
        /// </summary>
        public string DeleteByExpress<T>(Expression<Func<T, bool>> expression) where T : class, new()
        {
            T t = new T();
            string deleteSQL = "";
            string whereSQL = t.Where<T>(expression);
            deleteSQL = string.Format("delete {0} where {1};", typeof(T).Name, whereSQL);
            return deleteSQL;
        }

        /// <summary>
        /// 用于处理Update<Model.BsUser>(new { name = "测试" }, m => m.Name == "scott");或者Update<Model.BsUser>(new { name = "测试" }, m => m.Name == bsUser.Name);
        /// </summary>
        public string UpdateByExpress<T>(object updateObj, Expression<Func<T, bool>> expression) where T : class, new()
        {
            string updateBodyStr = updateObj.ToString();//形如{ CardNo = 1804270501487, Name = 苗水风, Sex = F }
            updateBodyStr = updateBodyStr.ToString().Substring(1, updateBodyStr.Length - 1);//形如 CardNo = 1804270501487, Name = 苗水风, Sex = F }
            updateBodyStr = updateBodyStr.Substring(0, updateBodyStr.Length - 1).Trim();//形如CardNo = 1804270501487, Name = 苗水风, Sex = F 
            string[] paramsArray = updateBodyStr.Split(',');
            updateBodyStr = "";
            foreach (string param in paramsArray)
            {
                int equalIndex = param.IndexOf("=");
                updateBodyStr += param.Substring(0, equalIndex + 1) + " ";
                updateBodyStr += "'" + param.Substring(equalIndex + 1).TrimStart() + "',";
            }
            updateBodyStr = updateBodyStr.Substring(0, updateBodyStr.Length - 1);//形如CardNo = '1804270501487', Name = '苗水风', Sex = 'F'

            T t = new T();
            string whereSQL = t.Where<T>(expression);
            string updateSQL = string.Format("update {0} set {1} where {2};", typeof(T).Name, updateBodyStr.Trim(), whereSQL);
            return updateSQL;
        }


        /// <summary>
        /// 根据主键guid删除某条记录
        /// </summary>
        /// <param name="tableName">要删除的表名</param>
        /// <param name="guid">主键guid</param>
        /// <returns>原生的sql删除语句</returns>
        public string DeleteModelByGuidSQL(string tableName, string guid)
        {
            string deleteSQL = string.Format("delete {0} where guid = '{1}';", tableName, guid);
            return deleteSQL;
        }

        /// <summary>
        /// 根据主键id删除某条记录
        /// </summary>
        /// <param name="tableName">要删除的表名</param>
        /// <param name="id">主键id</param>
        /// <returns>原生的sql删除语句</returns>
        public string DeleteModelByIdSQL(string tableName, int id)
        {
            string deleteSQL = string.Format("delete {0} where ID = {1};", tableName, id);
            return deleteSQL;
        }

        /// <summary>
        /// 将新增一个实体的操作转化成原生的sql语句
        /// </summary>
        /// <param name="entity">要新增的实体</param>
        /// <returns>原生的sql插入语句</returns>
        public string InsertSQL<T>(T entity) where T : BaseModel, new()
        {
            string insertSQL = "";
            Tuple<string, string[]> insertTuple = CreateInsertArguments(entity);
            insertSQL = string.Format(insertTuple.Item1, insertTuple.Item2);
            return insertSQL;
        }

        /// <summary>
        /// 将修改一个实体的操作转化成原生的sql语句
        /// </summary>
        /// <param name="entity">要修改的实体</param>
        /// <returns>原生的sql修改语句</returns>
        public string UpdateEntitySQL(object entity)
        {
            string updateSQL = "";
            Tuple<string, string[]> updateTuple = CreateUpdateArguments(entity);
            updateSQL = string.Format(updateTuple.Item1, updateTuple.Item2);
            return updateSQL;
        }

        /// <summary>
        /// 将删除一个实体的操作转化成原生的sql语句
        /// </summary>
        /// <param name="entity">要删除的实体</param>
        /// <returns>原生的sql删除语句</returns>
        public string DeleteEntitySQL(object entity)
        {
            string deleteSQL = "";
            string entityTypeStr = entity.GetType().ToString();
            int lastDotIndex = entityTypeStr.LastIndexOf(".");
            string tableName = entityTypeStr.Substring(lastDotIndex + 1);
            if (IsHospitalTable(tableName))
            {
                object primaryKeyValue = entity.GetType().GetProperty("ID").GetValue(entity, null);
                deleteSQL = string.Format("delete {0} where ID = {1};", tableName, primaryKeyValue);
            }
            else
            {
                object primaryKeyValue = entity.GetType().GetProperty("GUID").GetValue(entity, null);
                deleteSQL = string.Format("delete {0} where GUID = '{1}';", tableName, primaryKeyValue);
            }
            return deleteSQL;
        }

        ///
        /// 建立update sql语句 
        ///
        Tuple<string, string[]> CreateUpdateArguments(object entity)
        {
            if (entity == null)
                throw new ArgumentException("The database entity can not be null.");

            ELinq.Mapping.IMemberMapping[] mappingMemberArray = GetMappingMembers(entity);

            StringBuilder fieldbuilder = new StringBuilder();

            string entityTypeStr = entity.GetType().ToString();
            int lastDotIndex = entityTypeStr.LastIndexOf(".");
            string tableName = entityTypeStr.Substring(lastDotIndex + 1);
            fieldbuilder.Append("update " + tableName + " set ");
            string[] arguments = new string[mappingMemberArray.Length];//存放字段的值
            int argumentIndex = 0;
            foreach (ELinq.Mapping.IMemberMapping mappingMember in mappingMemberArray)
            {
                if (tableName.ToUpper() != "BSHOSPITAL" && mappingMember.Member.Name == "GUID")
                    continue;
                if (tableName.ToUpper() == "BSHOSPITAL" && mappingMember.Member.Name == "ID")
                    continue;
                object value = entity.GetType().GetProperty(mappingMember.Member.Name).GetValue(entity, null);
                if (value != null)
                {
                    if (argumentIndex != 0)
                    {
                        fieldbuilder.Append(", ");
                    }
                    fieldbuilder.Append(mappingMember.ColumnName + "=");
                    if (mappingMember.MemberType.Name == "String" || mappingMember.MemberType.Name == "DateTime")
                    {
                        if (mappingMember.MemberType.Name == "DateTime")
                            fieldbuilder.Append("to_date('{" + argumentIndex + "}','YYYY-MM-DD HH24:MI:SS')");
                        else
                            fieldbuilder.Append("'{" + argumentIndex + "}'");
                    }
                    else
                    {
                        fieldbuilder.Append("{" + argumentIndex + "}");
                    }
                    if (mappingMember.MemberType.Name == "String")
                        value = value.ToString().Replace("'", "char(39)");
                    if (value.ToString().ToLower() == "false")
                        value = 0;
                    if (value.ToString().ToLower() == "true")
                        value = 1;
                    arguments[argumentIndex] = value.ToString();
                    argumentIndex++;
                }
            }
            if (tableName.ToUpper() != "BSHOSPITAL")
            {
                var entityGuid = entity.GetType().GetProperty("GUID").GetValue(entity, null);
                if (null != entityGuid)
                    fieldbuilder.Append(" where GUID = '" + entityGuid.ToString() + "';");
                else
                    fieldbuilder.Append(" where GUID = '" + " " + "';");

            }
            else
            {
                string entityId = entity.GetType().GetProperty("ID").GetValue(entity, null).ToString();
                fieldbuilder.Append(" where ID = " + entityId + ";");
            }
            return new Tuple<string, string[]>(fieldbuilder.ToString(), arguments);
        }

        ///
        /// 建立insert sql语句 
        ///
        Tuple<string, string[]> CreateInsertArguments<T>(T entity) where T : BaseModel, new()
        {
            if (entity == null)
                throw new ArgumentException("The database entity can not be null.");

            ELinq.Mapping.IMemberMapping[] mappingMemberArray = GetMappingMembers(entity);

            StringBuilder fieldbuilder = new StringBuilder();
            StringBuilder valuebuilder = new StringBuilder();

            string entityTypeStr = entity.GetType().ToString();
            int lastDotIndex = entityTypeStr.LastIndexOf(".");
            string tableName = entityTypeStr.Substring(lastDotIndex + 1);
            fieldbuilder.Append("INSERT INTO " + tableName + " (");
            string[] arguments = new string[mappingMemberArray.Length];//存放字段的值
            int argumentIndex = 0;
            foreach (ELinq.Mapping.IMemberMapping mappingMember in mappingMemberArray)
            {
                object value = entity.GetType().GetProperty(mappingMember.Member.Name).GetValue(entity, null);
                if (value != null)
                {
                    if (argumentIndex != 0)
                    {
                        fieldbuilder.Append(", ");
                        valuebuilder.Append(", ");
                    }
                    fieldbuilder.Append(mappingMember.ColumnName);
                    if (mappingMember.MemberType.Name == "String" || mappingMember.MemberType.Name == "DateTime")
                        valuebuilder.Append("'{" + argumentIndex + "}'");
                    else
                        valuebuilder.Append("{" + argumentIndex + "}");
                    if (mappingMember.MemberType.Name == "String")
                        value = value.ToString().Replace("'", "char(39)");
                    if (value.ToString().ToLower() == "false")
                        value = 0;
                    if (value.ToString().ToLower() == "true")
                        value = 1;
                    if (mappingMember.MemberType.Name == "Byte[]")
                    {
                        string binaryStr = GetBinaryStrFromByteArr((Byte[])value);
                        arguments[argumentIndex] = string.Format("to_blob('{0}')", binaryStr);
                    }
                    else
                    {
                        arguments[argumentIndex] = value.ToString();
                    }
                    argumentIndex++;
                }
            }

            fieldbuilder.Append(") Values (");
            fieldbuilder.Append(valuebuilder.ToString());
            fieldbuilder.Append(");");
            return new Tuple<string, string[]>(fieldbuilder.ToString(), arguments);
        }

        public String GetBinaryStrFromByteArr(byte[] bArr)
        {
            String result = "";
            foreach (byte b in bArr)
            {
                result += GetBinaryStrFromByte(b);
            }
            return result;
        }

        public String GetBinaryStrFromByte(byte b)
        {
            String result = "";
            byte a = b; ;
            for (int i = 0; i < 8; i++)
            {
                byte c = a;
                a = (byte)(a >> 1);//每移一位如同将10进制数除以2并去掉余数。 
                a = (byte)(a << 1);
                if (a == c)
                {
                    result = "0" + result;
                }
                else
                {
                    result = "1" + result;
                }
                a = (byte)(a >> 1);
            }
            return result;
        }

        /// <summary>  
        /// List集合转DataTable  
        /// </summary>  
        /// <typeparam name="T">实体类型</typeparam>  
        /// <param name="list">传入集合</param>  
        /// <returns>返回datatable结果</returns>  
        public DataTable ListToTable<T>(List<T> list) where T : BaseModel, new()
        {
            T entity = list[0];
            Type tp = typeof(T);
            PropertyInfo[] proInfos = tp.GetProperties();
            DataTable dt = new DataTable();
            ELinq.Mapping.IMemberMapping[] mappingMemberArray = GetMappingMembers(entity);
            foreach (ELinq.Mapping.IMemberMapping mappingMember in mappingMemberArray)
            {
                if (mappingMember.MemberType.FullName == "System.Boolean")
                    dt.Columns.Add(mappingMember.ColumnName, typeof(System.Int32));//添加列名及对应类型 
                else
                    dt.Columns.Add(mappingMember.ColumnName, mappingMember.MemberType);//添加列名及对应类型  
            }
            foreach (var item in list)
            {
                DataRow dr = dt.NewRow();
                foreach (ELinq.Mapping.IMemberMapping mappingMember in mappingMemberArray)
                {
                    object value = item.GetType().GetProperty(mappingMember.Member.Name).GetValue(item, null);
                    if (mappingMember.ColumnName == "ID")
                    {
                        value = Guid.NewGuid().ToString("N");
                    }
                    if (value != null)
                    {
                        if (value.ToString().ToLower() == "false")
                            value = 0;
                        if (value.ToString().ToLower() == "true")
                            value = 1;
                        dr[mappingMember.ColumnName] = value;
                    }
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public ELinq.Mapping.IMemberMapping[] GetMappingMembers(object entity)
        {
            return DataRepository().GetMappingMembers(entity);
        }

        /// <summary>
        /// 是否是BSHOSPITAL表
        /// </summary>
        /// <param name="tableName">表名</param>
        public bool IsHospitalTable(string tableName)
        {
            bool returnBoolValue = true;
            if (tableName.ToUpper() != "BSHOSPITAL")
                returnBoolValue = false;
            return returnBoolValue;
        }

        /// <summary>
        /// 获取redis查询的pattern，eg:"\"Name\":\"公里\""
        /// </summary>
        /// <param name="where">eg：Name=@0 and CardNo = @1 and IsActive</param>
        /// <param name="modelTypeStr">hash中的key,用于在redis获取查询字段, eg:BsHouse</param>
        /// <param name="arr">查询参数的值集合</param>
        /// <returns></returns>
        internal string GetPattern<T>(string where, string modelTypeStr, params object[] arr) where T : class, new()
        {
            string pattern = "";
            string where_lower = where.ToLower();
            if (where_lower.Contains("or") || where_lower.Contains("||") || where_lower.Contains("&&"))
                return "";

            #region 暂时不用
            /*
             * 获取redis中的表的查询字段，eg:HospitalID,Name,CareGroupId,DocLevId,LevelId,IsActive;其中HospitalID,Name,IsActive是很多基础表都有的字段,
             * 很多表的查询是基于这三个字段进行查询，中间的那几个字段是一些外键，在二级联动、三级联动中可能会用到。
             */
            //string redisSearchConditionStr = null;//RedisReadExHelper.GetHashKeyValue(AppSettings.RedisDefaultKey, modelTypeStr);
            //if (redisSearchConditionStr != null)
            //{//在redis中有记录查询条件
            //    string[] redisSearchConditionKeys = redisSearchConditionStr.Split(',');
            //    string redisSearchConditionStr_lower = redisSearchConditionStr.ToLower();
            //    string keys = "RedisConditionValus";//pattern中的key
            //    string values = "";//pattern中的value
            //    //通过正则表达式分析where语句
            //    Regex rege = new Regex(@"[A-Za-z0-9]+(\s)?=(\s)?@[0-9]");
            //    MatchCollection Matches = rege.Matches(where);//Name=@0  CardNo = @1
            //    bool isAllContain = true;//Name,CardNo,IsActive是否都包含在redisSearchConditionStr中,默认为true
            //    bool isBaseComBox = true;
            //    foreach (Match NextMatch in Matches)
            //    {
            //        isBaseComBox = false;
            //        string str = NextMatch.Groups[0].Value;
            //        int k = str.IndexOf("=");
            //        string file = str.Substring(0, k).Trim();
            //        if (!redisSearchConditionStr_lower.Contains(file.ToLower()))
            //        {
            //            isAllContain = false;
            //            break;
            //        }
            //    }
            //    if (!isAllContain)
            //    {
            //        if (where_lower.Contains("isactive") && arr == null)
            //            isAllContain = true;//只有IsActive一个查询条件的情况
            //    }
            //    if (isBaseComBox)
            //    {
            //        GeneratePattern<T>(where, ref pattern, where_lower, redisSearchConditionKeys, keys, ref values, isBaseComBox);
            //    }
            //    else
            //    {
            //        //下面将结合where和redisSearchConditionKeys构建pattern
            //        GeneratePattern<T>(where, arr, ref pattern, where_lower, redisSearchConditionKeys, keys, ref values, isAllContain);
            //    }

            //}
            #endregion
            //else
            //{//在redis中没有记录查询条件
            if (arr.Length == 1)
                {
                    int k = where.IndexOf("=");
                    string key = where.Substring(0, k).Trim();
                    if (key.EndsWith("!"))
                        key = key.Substring(0, key.Length - 1);
                    PropertyInfo propertyInfo = typeof(T).GetProperty(key, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                    if (propertyInfo != null)
                    {
                        if (propertyInfo.PropertyType.Name == "String")
                            pattern = "\"" + key + "\":\"" + arr[0].ToString() + "\"";
                        else
                            pattern = "\"" + key + "\":" + arr[0].ToString() + "";
                    }
                }
                else
                {
                    string[] strArray = where.Split('=');
                    if(strArray.Length>1 && strArray.Length < 3)
                    {
                        PropertyInfo propertyInfo = typeof(T).GetProperty(strArray[0], BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                        if (propertyInfo.PropertyType.Name == "String")
                            pattern = "\"" + strArray[0] + "\":\"" + strArray[1].ToString() + "\"";
                        else
                            pattern = "\"" + strArray[0] + "\":" + strArray[1].ToString() + "";

                    }
                }
            //}
            return pattern;
        }

        /// <summary>
        /// 结合where和redisSearchConditionKeys构建pattern
        /// </summary>
        private void GeneratePattern<T>(string where, object[] arr, ref string pattern, string where_lower, string[] redisSearchConditionKeys, string keys, ref string values, bool isAllContain) where T : class, new()
        {
            int j = 0;
            if (isAllContain)
            {
                foreach (string s in redisSearchConditionKeys)
                {
                    if (where_lower.Contains(s.ToLower()))
                    {
                        if (s != "IsActive")
                        {
                            values += arr[j] + ",";
                            j++;
                        }
                        else
                        {
                            values += "true";
                        }
                    }
                    else
                    {//不包含的查询条件用*代替,表示可以是任何内容 eg:5037,*,true(可匹配查询条件为HospitalID,Name,【外键】,IsActive的情况)
                        if (!values.Contains("*,"))
                            values += "*,";
                    }
                }
                if (values.EndsWith(","))
                    values = values.Substring(0, values.Length - 1);
                pattern = "\"" + keys + "\":\"" + values + "\"";
            }
            else
            {
                if (arr.Length == 1)
                {
                    int k = where.IndexOf("=");
                    string key = where.Substring(0, k).Trim();
                    if (key.EndsWith("!")) //有些条件是以fild!=@0形式出现的
                        key = key.Substring(0, key.Length - 1);
                    PropertyInfo propertyInfo = typeof(T).GetProperty(key, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                    if (propertyInfo != null)
                    {
                        if (propertyInfo.PropertyType.Name == "String")
                            pattern = "\"" + key + "\":\"" + arr[0].ToString() + "\"";
                        else
                            pattern = "\"" + key + "\":" + arr[0].ToString() + "";
                    }
                }
            }
        }


        /// <summary>
        /// 下拉框条件构建Pattern
        /// </summary>
        private void GeneratePattern<T>(string where, ref string pattern, string where_lower, string[] redisSearchConditionKeys, string keys, ref string values, bool isBaseCombox) where T : class, new()
        {
            int j = 0;
            int k = where.IndexOf("=");
            string value = where.Substring(k + 1);

            if (isBaseCombox)
            {
                foreach (string s in redisSearchConditionKeys)
                {
                    if (where_lower.Contains(s.ToLower()))
                    {
                        if (s != "IsActive")
                        {
                            values += value + ",";
                            j++;
                        }
                        else
                        {
                            values += "true";
                        }
                    }
                    else
                    {//不包含的查询条件用*代替,表示可以是任何内容 eg:5037,*,true(可匹配查询条件为HospitalID,Name,【外键】,IsActive的情况)
                        if (!values.Contains("*,"))
                            values += "*,";
                    }
                }
                if (values.EndsWith(","))
                    values = values.Substring(0, values.Length - 1);
                pattern = "\"" + keys + "\":\"" + values + "\"";
            }
           
        }

        string[] _expTypes = new string[] { "||", "!", "Contains", "GreaterThan", ">", "GreaterThanOrEqual", ">=", "LessThan", "<", "LessThanOrEqual", "<=", "NotEqual", "<>", "Or" };
        internal string GetExpPattern<T>(string where, string modelTypeStr) where T : class, new()
        {
            string pattern = "";
            foreach (string expType in _expTypes)
            {
                if (where.Contains(expType))
                    return "";
            }
            where = where.Substring(3, where.Length - 3);
            /*
             * 获取redis中的表的查询字段，eg:HospitalID,Name,CareGroupId,DocLevId,LevelId,IsActive;其中HospitalID,Name,IsActive是很多基础表都有的字段,
             * 很多表的查询是基于这三个字段进行查询，中间的那几个字段是一些外键，在二级联动、三级联动中可能会用到。
             */
            string redisSearchConditionStr = RedisReadExHelper.GetHashKeyValue(AppSettings.RedisDefaultKey, modelTypeStr);
            string[] fileArr = new string[10];
            string[] valueArr = new string[10];
            if (redisSearchConditionStr != null)
            {//在redis中有记录查询条件
                string[] redisSearchConditionKeys = redisSearchConditionStr.Split(',');
                string keys = "RedisConditionValus";//pattern中的key
                string values = "";//pattern中的value
                //通过正则表达式分析where语句
                Regex rege = new Regex(@"[A-Za-z].[A-Za-z0-9]+(\s)?=(\s)?(\S)+");
                MatchCollection Matches = rege.Matches(where);//t.Name = "张三"  t.ClassName= "四(2)班"
                bool isAllContain = true;//Name,ClassName是否都包含在redisSearchConditionStr中,默认为true
                int i = 0;
                foreach (Match NextMatch in Matches)
                {
                    string str = NextMatch.Groups[0].Value;
                    int k = str.IndexOf("=");
                    string file = str.Substring(0, k).Trim().Substring(2);//去掉空格和t. eg:Name
                    string fileValue = str.Substring(k + 1).Trim();//eg:\"张三\"
                    fileValue = fileValue.Trim(new char[] { '\"' });//eg:张三
                    valueArr[i] = fileValue;
                    fileArr[i] = file;
                    i++;
                    if (!redisSearchConditionStr.Contains(file))
                    {
                        isAllContain = false;
                        break;
                    }
                }
                if (!isAllContain)
                {
                    if (where.Contains("IsActive") && where.Length < 14)
                        isAllContain = true;//只有IsActive一个查询条件的情况
                }
                //下面将结合where和redisSearchConditionKeys构建pattern
                GenerateExpPattern<T>(where, fileArr, valueArr, ref pattern, redisSearchConditionKeys, keys, ref values, isAllContain);
            }
            else
            {//在redis中没有记录查询条件
                if (valueArr.Length == 1)
                {
                    if (where.Contains("IsActive")) //eg:"t => t.IsActive AndAlso t.ClassName = \"四(2)班\""
                        return "";
                    //下面处理形如："t => t.IsActive AndAlso t.ClassName = \"四(2)班\""
                    string key = fileArr[0];
                    PropertyInfo propertyInfo = typeof(T).GetProperty(key, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                    if (propertyInfo != null)
                    {
                        if (propertyInfo.PropertyType.Name == "String")
                            pattern = "\"" + key + "\":\"" + valueArr[0].ToString() + "\"";
                        else
                            pattern = "\"" + key + "\":" + valueArr[0].ToString() + "";
                    }
                }
            }
            return pattern;
        }


        /// <summary>
        /// 结合where和redisSearchConditionKeys构建pattern
        /// </summary>
        private void GenerateExpPattern<T>(string where, string[] fileArr, string[] valueArr, ref string pattern, string[] redisSearchConditionKeys, string keys, ref string values, bool isAllContain) where T : class, new()
        {
            int j = 0;
            if (isAllContain)
            {
                foreach (string s in redisSearchConditionKeys)
                {
                    if (where.Contains(s))
                    {
                        if (s != "IsActive")
                        {
                            values += valueArr[j] + ",";
                            j++;
                        }
                        else
                        {
                            values += "true";
                        }
                    }
                    else
                    {//不包含的查询条件用*代替,表示可以是任何内容 eg:5037,*,true(可匹配查询条件为HospitalID,Name,【外键】,IsActive的情况)
                        if (!values.Contains("*,"))
                            values += "*,";
                    }
                }
                if (values.EndsWith(","))
                    values = values.Substring(0, values.Length - 1);
                pattern = "\"" + keys + "\":\"" + values + "\"";
            }
            else
            {
                if (valueArr.Length == 1)
                {
                    if (where.Contains("IsActive")) //eg:"t => t.IsActive AndAlso t.ClassName = \"四(2)班\""
                    {
                        pattern = "";
                        return;
                    }
                    //下面处理形如："t => t.IsActive AndAlso t.ClassName = \"四(2)班\""
                    string key = fileArr[0];
                    PropertyInfo propertyInfo = typeof(T).GetProperty(key, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                    if (propertyInfo != null)
                    {
                        if (propertyInfo.PropertyType.Name == "String")
                            pattern = "\"" + key + "\":\"" + valueArr[0].ToString() + "\"";
                        else
                            pattern = "\"" + key + "\":" + valueArr[0].ToString() + "";
                    }
                }
            }
        }
    }
}
