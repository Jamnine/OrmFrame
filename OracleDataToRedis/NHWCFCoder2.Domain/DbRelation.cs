using System;
using System.Collections.Generic;
using System.Text;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Domain
{
    public class DbRelation
    {
        public DbRelation()
        {
            this.ChildColumns = new List<DbColumn>();
            this.ParentColumns = new List<DbColumn>();
        }

        /// <summary>
        /// 关系外键名(通过此键名找主表)
        /// </summary>
        public string ParentConstraintName
        {
            get;
            set;
        }

        /// <summary>
        /// 关系外键引用名(通过此键名找从表)
        /// </summary>
        public string ChildConstraintName
        {
            get;
            set;
        }

        /// <summary>
        /// 主表名
        /// </summary>
        public DbTable ParentTable
        {
            get;
            set;
        }

        /// <summary>
        /// 主表名
        /// </summary>
        public string ParentTableName
        {
            get;
            set;
        }

        /// <summary>
        ///  表名转换为类名
        /// </summary>
        public string ParentTitleCaseName
        {
            get
            {
                string titlecasetablename = WordHelper.MakeTitleCaseName(this.ParentTable.Name, BaseParams.TablePrefix, BaseParams.TablePrefixSpilt, false);
                if (this.ParentColumns[0].IsPrimaryKey == true && this.ChildColumns[0].IsPrimaryKey == true)
                {

                }
                if (this.IncrementalValue > 1)
                    titlecasetablename = titlecasetablename + this.IncrementalValue;
                return titlecasetablename;
            }
        }

        /// <summary>
        ///  列名转换参数名
        /// </summary>
        public string ParentParamCaseName
        {
            get
            {
                return ParentTitleCaseName.Substring(0, 1).ToLower() + ParentTitleCaseName.Substring(1);
            }
        }

        /// <summary>
        ///  列名转换参数名
        /// </summary>
        public string ParentFieldCaseName
        {
            get
            {
                return "_" + ParentParamCaseName;
            }
        }

        /// <summary>
        /// 从表表名
        /// </summary>
        public DbTable ChildTable
        {
            get;
            set;
        }

        /// <summary>
        /// 主关系列集合
        /// </summary>
        public IList<DbColumn> ParentColumns
        {
            get;
            set;
        }

        /// <summary>
        /// 从关系列集合
        /// </summary>
        public IList<DbColumn> ChildColumns
        {
            get;
            set;
        }

        /// <summary>
        ///  表名转换为类名
        /// </summary>
        public string ChildTitleCaseName
        {
            get
            {
                bool isMarkPrue = !(this.ParentColumns[0].IsPrimaryKey == true && this.ChildColumns[0].IsPrimaryKey == true);
                string titlecasetablename = WordHelper.MakeTitleCaseName(this.ChildTable.Name, BaseParams.TablePrefix, BaseParams.TablePrefixSpilt, isMarkPrue);
                if (this.IncrementalValue > 1)
                    titlecasetablename = titlecasetablename + this.IncrementalValue;
                return titlecasetablename;
            }
        }

        /// <summary>
        ///  列名转换参数名
        /// </summary>
        public string ChildParamCaseName
        {
            get
            {
                return ChildTitleCaseName.Substring(0, 1).ToLower() + ChildTitleCaseName.Substring(1);
            }
        }

        /// <summary>
        ///  列名转换参数名
        /// </summary>
        public string ChildFieldCaseName
        {
            get
            {
                return "_" + ChildParamCaseName;
            }
        }

        /// <summary>
        /// 相同表关系数量
        /// </summary>
        public int IncrementalValue
        {
            get;
            set;
        }
    }
}
