using System;

namespace Orm.Model
{
    /// <summary>
    /// 电子病历XML
    /// </summary>
    [Serializable]
    public partial class InEMRXml : BaseModel
    {
        private string _hosId;
        private string _locationID;
        private string _catalogId;
        private DateTime _operTime;
        private string  _xMLFleld;
        private string  _xMLValue;
        private string _inEmrId;
            
        public InEMRXml()
        {
        }

        /// <summary>  
        /// 门诊ID,用户不可见  
        /// </summary>  
        public string HosId
        {
            get { return this._hosId; }
            set { this._hosId = value; }
        }

        /// <summary>
        /// 病历id
        /// </summary>
        public string InEmrId
        {
            get { return this._inEmrId; }
            set { this._inEmrId = value; }
        }

        /// <summary>  
        /// 分院ID
        /// </summary>  
        public string LocationID
        {
            get { return this._locationID; }
            set { this._locationID = value; }
        }

        /// <summary>  
        /// 病案类别
        /// </summary>  
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        /// <summary>  
        /// 创建时间  
        /// </summary>  
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }

        /// <summary>  
        /// 病案类别  Fleld
        /// </summary>  
        public string  XMLFleld
        {
            get { return this._xMLFleld; }
            set { this._xMLFleld = value; }
        }

        /// <summary>  
        /// 病案类别  
        /// </summary>  
        public string XMLValue
        {
            get { return this._xMLValue; }
            set { this._xMLValue = value; }
        }
    }
}
