using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Domain
{
    public class DbTable
    {
        public DbTable()
        {
            this.Columns = new List<DbColumn>();
            this.Indexes = new List<DbIndex>();
            this.ChildRelations = new List<DbRelation>();
            this.ParentRelations = new List<DbRelation>();
        }
        /// <summary>
        ///  是否生成
        /// </summary>
        public bool IsCreate
        {
            get;
            set;
        }

        /// <summary>
        ///  表名
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        private string _comments;

        /// <summary>
        /// 表注释
        /// </summary>
        public string Comments
        {
            get { return (this._comments == null || this._comments == "") ? this.TitleCaseName : this._comments; }
            set { this._comments = value; }
        }

        /// <summary>
        /// 表的列集合
        /// </summary>
        public IList<DbColumn> Columns
        {
            get;
            set;
        }

        /// <summary>
        /// 表的索引集合
        /// </summary>
        public IList<DbIndex> Indexes
        {
            get;
            set;
        }

        /// <summary>
        /// 主键
        /// </summary>
        public DbIndex PrimaryKey
        {
            get;
            set;
        }

        /// <summary>
        /// 主表关系集合
        /// </summary>
        public IList<DbRelation> ChildRelations
        {
            get;
            set;
        }

        /// <summary>
        /// 从表关系集合
        /// </summary>
        public IList<DbRelation> ParentRelations
        {
            get;
            set;
        }

        #region 只读属性
        /// <summary>
        ///  表名转换为类名
        /// </summary>
        public string TitleCaseName
        {
            get
            {
                string titlecasetablename = WordHelper.MakeTitleCaseName(this.Name, BaseParams.TablePrefix, BaseParams.TablePrefixSpilt, false);
                return titlecasetablename;
            }
        }

        /// <summary>
        ///  列名转换参数名
        /// </summary>
        public string ParamCaseName
        {
            get
            {
                return TitleCaseName.Substring(0, 1).ToLower() + TitleCaseName.Substring(1);
            }
        }

        /// <summary>
        ///  列名转换参数名
        /// </summary>
        public string FieldCaseName
        {
            get
            {
                return "_" + ParamCaseName;
            }
        }

        public string MarkName
        {
            get
            {
                return this.Name.ToUpper();
            }
        }

        /// <summary>
        /// 构造函数的参数字符串
        /// </summary>
        public string ConstractParams
        {
            get
            {
                string param = "";
                for (int i = 0; i < this.Columns.Count; i++)
                {
                    if (this.Columns[i].IsGenerateField == true)
                    {
                        DbColumn dc = this.Columns[i];
                        param += ", " + dc.FieldType + " " + dc.ParamCaseName;
                    }
                }
                return StringHelper.TrimStart(param, ", ");
            }
        }
        #endregion
    }
}
