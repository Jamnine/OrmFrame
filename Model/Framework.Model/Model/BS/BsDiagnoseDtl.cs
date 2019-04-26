using System;
using System.Collections.Generic;

namespace Orm.Model
{
    /// <summary>
    /// 诊断明细
    /// </summary>
    [Serializable]
   
    public partial class BsDiagnoseDtl : BaseModel
    {
        string _diagnoseDtl;
        string _checkType;
        string _commonName;
        string _relust;
        string _diagnoseId;
        string _commonNameId;

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public BsDiagnoseDtl()
        {
            LstItem = new List<BsItem>();
        }
        private int _orderBy;

        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        /// <summary>
        /// 项目列表
        /// </summary>
        public List<BsItem> LstItem { get; set; }

        /// <summary>
        /// 项目
        /// </summary>
        public BsItem Item { get; set; }

        /// <summary>
        /// 通用名id
        /// </summary>
        public string CommonNameId
        {
            get
            {
                return _commonNameId;
            }
            set
            {
                _commonNameId = value;
            }
        }

        /// <summary>
        /// 对应假设诊断主表id
        /// </summary>
        public string DiagnoseId
        {
            get
            {
                return _diagnoseId;
            }
            set
            {
                _diagnoseId = value;
            }
        }

        /// <summary>
        /// 结果
        /// </summary>
        public string Relust
        {
            get
            {
                return _relust;
            }
            set
            {
                _relust = value;
            }
        }

        /// <summary>
        /// 通用名称
        /// </summary>
        public string CommonName
        {
            get
            {
                return _commonName;
            }
            set
            {
                _commonName = value;
            }
        }

        /// <summary>
        /// 检查类别
        /// </summary>
        public string CheckType
        {
            get
            {
                return _checkType;
            }
            set
            {
                _checkType = value;
            }
        }

        /// <summary>
        /// 假设诊断 详细
        /// </summary>
        public string DiagnoseDtl
        {
            get
            {
                return _diagnoseDtl;
            }
            set
            {
                _diagnoseDtl = value;
            }
        }

    }
}



