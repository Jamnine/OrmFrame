// ===================================================================   
// Model  
// ===================================================================   
// File: BsTjLocation.cs  
//   
// Copyright   
// History:  
// 2015/12/18 17:04:02: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    ///  体检科室
    /// </summary> 
    [Serializable]
    public partial class BsTjLocation : BaseModel
    {
        private string _name = String.Empty;
        private string _pyCode = String.Empty;
        private string _wbCode = String.Empty;
        private DateTime _modiTime;
        private string _modiOperId;
        private int _orderBy;
        private bool _isActive;
        private string _isTrueOrFalse = "是";

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public BsTjLocation()
        {
        }


        /// <summary>  
        ///  科室名称
        /// </summary>  
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>  
        /// 拼音码
        /// </summary>  
        public string PyCode
        {
            get { return this._pyCode; }
            set { this._pyCode = value; }
        }

        /// <summary>  
        /// 五笔码
        /// </summary>  
        public string WbCode
        {
            get { return this._wbCode; }
            set { this._wbCode = value; }
        }

        /// <summary>  
        /// 最后修改时间
        /// </summary>  
        public DateTime ModiTime
        {
            get { return this._modiTime; }
            set { this._modiTime = value; }
        }

        /// <summary>  
        /// 最后修改人ID
        /// </summary>  
        public string ModiOperId
        {
            get { return this._modiOperId; }
            set { this._modiOperId = value; }
        }

        /// <summary>  
        ///   排序
        /// </summary>  
        public int OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        /// <summary>  
        ///   是否启用
        /// </summary>  
        public bool IsActive
        {
            get { return this._isActive; }
            set { this._isActive = value; }
        }

        /// <summary>
        /// 1 检查 2检验 3功能
        /// </summary>
        public int LocationType
        {
            get;
            set;
        }

        /// <summary>
        /// 是否自动小结
        /// </summary>
        public bool IsAutoSummary
        {
            get;
            set;
        }

        /// <summary>
        /// 指引提示
        /// </summary>
        public string GuideTips
        {
            get;
            set;
        }

        public string IsTrueOrFalse
        {
            get { return this._isTrueOrFalse; }
            set { this._isTrueOrFalse = value; }
        }
    }
}

