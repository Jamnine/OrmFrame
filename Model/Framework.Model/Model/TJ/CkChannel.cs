using System;

namespace Orm.Model
{
    /// <summary>  
    /// 标本  数据库不存在此表
    /// </summary>  
    [Serializable]

    public partial class CkChannel : BaseModel
    {
        protected string _ckitemCode ;
        protected string _itemInterface = String.Empty;
        protected string _cKMId = String.Empty;

        /// <summary>  
        /// 卡号  
        /// </summary>  
        public string CkitemCode
        {
            get { return _ckitemCode; }
            set { _ckitemCode = value; }
        }

        /// <summary>  
        /// 仪器通道
        /// </summary>  
        public string ItemInterface
        {
            get { return _itemInterface; }
            set { _itemInterface = value; }
        }

        /// <summary>  
        /// 仪器id 
        /// </summary>  
        public string CKMId
        {
            get { return _cKMId; }
            set { _cKMId = value; }
        }

    }
}
