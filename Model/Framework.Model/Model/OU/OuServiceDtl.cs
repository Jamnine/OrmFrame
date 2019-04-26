using System;

namespace Orm.Model
{
    /// <summary>  
    /// 服务信息 居家养老 生活服务
    /// </summary> 
    [Serializable]
    public partial class OuServiceDtl : BaseModel
    {
        private string _ouServiceId;
        /// <summary>
        /// 主表id
        /// </summary>
        public string OuServiceId
        {
            get { return _ouServiceId; }
            set { _ouServiceId = value; }
        }

        private double _priceDiag;  //门诊价格
        /// <summary>
        /// 门诊价格
        /// </summary>
        public double PriceDiag
        {
            get { return _priceDiag; }
            set { _priceDiag = value; }
        }

        private string _bsItemId;
        /// <summary>
        /// 项目id
        /// </summary>
        public string BsItemId
        {
            get { return _bsItemId; }
            set { _bsItemId = value; }
        }



        private string _bsItemName;
        /// <summary>
        /// 项目名称
        /// </summary>
        public string BsItemName
        {
            get { return _bsItemName; }
            set { _bsItemName = value; }
        }
        private string _ouHosInfoId;
        /// <summary>
        /// 门诊id
        /// </summary>
        public string OuHosInfoId
        {
            get { return _ouHosInfoId; }
            set { _ouHosInfoId = value; }
        }

    }
}

