using System;
using System.Collections.Generic;
using System.Text;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Domain
{
    public class DbIndex
    {
        public DbIndex()
        {
            this.Columns = new List<DbColumn>();
        }

        /// <summary>
        ///  索引名称
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 是否为主键对应的索引
        /// </summary>
        public bool IsPrimaryKey
        {
            get;
            set;
        }

        /// <summary>
        ///  是否唯一索引
        /// </summary>
        public bool IsUnique
        {
            get;
            set;
        }

        /// <summary>
        ///  索引类型
        /// </summary>
        public string ConstraintType
        {
            get;
            set;
        }

        /// <summary>
        /// 对应父表
        /// </summary>
        public DbTable Table
        {
            get;
            set;
        }

        /// <summary>
        /// 索引列集合
        /// </summary>
        public IList<DbColumn> Columns
        {
            get;
            set;
        }

        #region 只读属性

        /// <summary>
        /// 获取对应索引的名称字符串 比如:UqWayBillnoIeflag  (由UQ_WAYBILL_BILLNO,IEFLAG两个Column组成)
        /// </summary>
        /// <param name="di">索引</param>
        public string ColumnsString
        {
            get
            {
                string indexColumns = "";
                foreach (DbColumn dc in this.Columns)
                {
                    indexColumns += dc.TitleCaseName;
                }
                return indexColumns;
            }
        }

        /// <summary>
        /// 获取对应索引的传入参数字符串
        /// </summary>
        /// <param name="di">索引</param>
        public string ParameterClassString
        {
            get
            {
                string parameterClass = "string";
                if (this.Columns.Count == 1)
                {
                    DbColumn dc = this.Columns[0];
                    parameterClass = dc.FieldType;
                }
                else
                {
                    parameterClass = this.Table.TitleCaseName;
                }
                return parameterClass;
            }
        }

        /// <summary>
        /// 获取对应索引的查询参数字符串
        /// </summary>
        /// <param name="di">索引</param>
        public string ColumnParmsString
        {
            get
            {
                string str = "";
                for (int i = 0; i < this.Columns.Count; i++)
                {
                    DbColumn dc = this.Columns[i];
                    if (i == 0)
                        str = dc.FieldType + " " + dc.ParamCaseName;
                    else
                        str += ", " + dc.FieldType + " " + dc.ParamCaseName;
                }
                return str;
            }
        }

        /// <summary>
        /// 获取对应索引的查询参数字符串
        /// </summary>
        /// <param name="di">索引</param>
        public string ParamsString
        {
            get
            {
                string str = "";
                for (int i = 0; i < this.Columns.Count; i++)
                {
                    DbColumn dc = this.Columns[i];
                    if (i == 0)
                        str = dc.ParamCaseName;
                    else
                        str += ", " + dc.ParamCaseName;
                }
                return str;
            }
        }

        /// <summary>
        /// 获取对应索引的查询条件传入参数字符串
        /// </summary>
        /// <param name="di">索引</param>
        public string SelectParamsString
        {
            get
            {
                string str = "";
                for (int i = 0; i < this.Columns.Count; i++)
                {
                    DbColumn dc = this.Columns[i];
                    if (i == 0)
                        str = this.Table.ParamCaseName + "." + dc.TitleCaseName;
                    else
                        str += ", " + this.Table.ParamCaseName + "." + dc.TitleCaseName; ;
                }
                return str;
            }
        }
        #endregion
    }
}
