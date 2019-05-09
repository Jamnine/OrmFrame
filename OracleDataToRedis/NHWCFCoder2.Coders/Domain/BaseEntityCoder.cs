using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.Domain
{
    public class BaseEntityCoder
    {
        public static void Write()
        {
            string path = BaseParams.DomainPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(path, "BaseEntity.cs");

            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Runtime.Serialization;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.DomainNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    [Serializable]");
            sw.WriteLine("    [DataContract(IsReference = true)]");
            sw.WriteLine("    public class BaseEntity");
            sw.WriteLine("    {");
            sw.WriteLine("");
            sw.WriteLine("        #region 私有变量");
            sw.WriteLine("        [DataMember]");
            sw.WriteLine("        protected bool _isChanged;");
            sw.WriteLine("        [DataMember]");
            sw.WriteLine("        protected bool _isDeleted;");
            sw.WriteLine("        protected int _dataVersion;");
            sw.WriteLine("        protected DateTime? _dataCreateTime;");
            sw.WriteLine("        protected DateTime? _dataUpdateTime;");
            sw.WriteLine("        #endregion");
            sw.WriteLine("");
            sw.WriteLine("        #region 公共属性");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 获取对象的主键.");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public virtual object EntityID");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return new Object(); }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 表示实例是否已经发生改变.");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public virtual bool IsChanged");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return _isChanged; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 表示实例是否已经被删除.");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public virtual bool IsDeleted");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return _isDeleted; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 数据版本");
            sw.WriteLine("        /// </summary>  ");
            sw.WriteLine("        [DataMember]");
            sw.WriteLine("        public virtual int DataVersion");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._dataVersion; }");
            sw.WriteLine("            set { this._dataVersion = value; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 数据创建时间");
            sw.WriteLine("        /// </summary> ");
            sw.WriteLine("        [DataMember]");
            sw.WriteLine("        public virtual DateTime? DataUpdateTime");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._dataUpdateTime; }");
            sw.WriteLine("            set { this._dataUpdateTime = value; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 数据创建时间");
            sw.WriteLine("        /// </summary> ");
            sw.WriteLine("        [DataMember]");
            sw.WriteLine("        public virtual DateTime? DataCreateTime");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._dataCreateTime; }");
            sw.WriteLine("            set { this._dataCreateTime = value; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        #endregion");
            sw.WriteLine("");
            sw.WriteLine("        #region 公共方法");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 设置已被删除.");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public virtual void Delete()");
            sw.WriteLine("        {");
            sw.WriteLine("            _isDeleted = true;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 设置为已被改动.");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public virtual void Modify()");
            sw.WriteLine("        {");
            sw.WriteLine("            _isChanged = true;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 返回初始状态,仅撤销变化的状态, ");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public virtual void Reject()");
            sw.WriteLine("        {");
            sw.WriteLine("            _isDeleted = false;");
            sw.WriteLine("            _isChanged = false;");
            sw.WriteLine("        }");
            sw.WriteLine("        #endregion");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
            file.Close();
        }
    }
}
