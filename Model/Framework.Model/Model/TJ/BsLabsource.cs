using System;

namespace Orm.Model
{
    /// <summary>  
    /// 标本 
    /// </summary> 
    [Serializable]

    public partial class BsLabsource : BaseModel
    {
        protected string _code = String.Empty;
        protected string _name = String.Empty;
        protected string _pYCode = String.Empty;
        protected string _wBCode = String.Empty;
        protected int _orderBy;
        protected bool _isActive;
     
        /// <summary>  
        /// 卡号  
        /// </summary>  
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>  
        /// 名称  
        /// </summary>  
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>  
        /// 拼音码  
        /// </summary>  
        public string PYCode
        {
            get { return _pYCode; }
            set { _pYCode = value; }
        }

        /// <summary>  
        /// 五笔码  
        /// </summary>  
        public string WBCode
        {
            get { return _wBCode; }
            set { _wBCode = value; }
        }

        /// <summary>  
        /// OrderBy  
        /// </summary>  
        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        /// <summary>  
        /// 是否可用  
        /// </summary>  
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
    }
}
