using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Domain
{
    public class DbColumn
    {
        /// <summary>
        ///  列序号
        /// </summary>
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        ///  列名称
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        ///  列长度
        /// </summary>
        public int Length
        {
            get;
            set;
        }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType
        {
            get;
            set;
        }

        /// <summary>
        /// 是否可以为空
        /// </summary>
        public bool Nullable
        {
            get;
            set;
        }

        /// <summary>
        /// 是否外键
        /// </summary>
        public bool IsForeignKey
        {
            get;
            set;
        }


        /// <summary>
        /// 是否主键
        /// </summary>
        public bool IsPrimaryKey
        {
            get;
            set;
        }

        /// <summary>
        /// 是否需要生成字段
        /// </summary>
        public bool IsGenerateField
        {
            get;
            set;
        }

        private string _comments;

        /// <summary>
        /// 列注释
        /// </summary>
        public string Comments
        {
            get { return (this._comments == null || this._comments == "") ? this.TitleCaseName : this._comments; }
            set { this._comments = value; }
        }

        /// <summary>
        /// 表对象
        /// </summary>
        public DbTable Table
        {
            get;
            set;
        }

        #region 只读属性
        /// <summary>
        ///  列名转换为属性名 比如:OrgCode
        /// </summary>
        public string TitleCaseName
        {
            get
            {
                string titlecasename = WordHelper.MakeTitleCaseName(this.Name);
                return titlecasename;
            }
        }

        /// <summary>
        ///  列名转换参数名 比如:orgCode
        /// </summary>
        public string ParamCaseName
        {
            get
            {
                return TitleCaseName.Substring(0, 1).ToLower() + TitleCaseName.Substring(1);
            }
        }

        /// <summary>
        ///  列名转换参数名 比如:_orgCode
        /// </summary>
        public string FieldCaseName
        {
            get
            {
                return "_" + ParamCaseName;
            }
        }

        /// <summary>
        ///  通过数据库类型返回,程序语言类型
        /// </summary>
        public string FieldType
        {
            get
            {
                return FieldTypeHelper.ChangeToFieldType(this.DataType);
            }
        }

        public string MarkName
        {
            get
            {
                return this.Name.ToUpper();
            }
        }
        #endregion
    }
}