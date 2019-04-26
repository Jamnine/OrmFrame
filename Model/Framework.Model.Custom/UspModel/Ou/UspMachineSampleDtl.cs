using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 仪器匹配信息
    /// </summary>
    [Serializable]
    public class UspMachineSampleDtl : BaseModel
    {
        private string _tjitemId;
        private int _sampleNum;
        private DateTime _matchDate;
        private bool _sendStatus;
        private string _machineID;
        private string _userID;
        private string _patcode;
        private string _patName;
        private bool _isMatching;
        private string _cKMId;
        private string _hosId;
        public UspMachineSampleDtl()
        {
        }

        /// <summary>  
        /// 仪器流水号id
        /// </summary>  
        public string UMSId
        {
            get { return _tjitemId; }
            set { _tjitemId = value; }
        }

        /// <summary>  
        ///  病人卡号 
        /// </summary>  
        public string PatCode
        {
            get { return this._patcode; }
            set { this._patcode = value; }
        }

        /// <summary>
        /// 门诊id
        /// </summary>
        public string HosId
        {
            get { return _hosId; }
            set { _hosId = value; }
        }

        /// <summary>  
        ///  病人姓名
        /// </summary>  
        public string PatName
        {
            get { return this._patName; }
            set { this._patName = value; }
        }

        /// <summary>  
        /// 检验项目id
        /// </summary>  
        public string TjitemId
        {
            get { return _tjitemId; }
            set { _tjitemId = value; }
        }

        /// <summary>  
        /// 仪器流水号 
        /// </summary>  
        public int SampleNum
        {
            get { return _sampleNum; }
            set { _sampleNum = value; }
        }

        /// <summary>  
        /// 匹配时间  
        /// </summary>  
        public DateTime MatchDate
        {
            get { return _matchDate; }
            set { _matchDate = value; }
        }

        /// <summary>  
        /// 是否传回
        /// </summary>  
        public bool SendStatus
        {
            get { return _sendStatus; }
            set { _sendStatus = value; }
        }
        
        /// <summary>  
        /// 仪器id
        /// </summary>  
        public string MachineID
        {
            get { return _machineID; }
            set { _machineID = value; }
        }

        /// <summary>  
        /// 操作人id  
        /// </summary>  
        public string UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        private string _userName;
        /// <summary>  
        /// 操作人  
        /// </summary>  
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _specimenCode;
        /// <summary>  
        ///  标本号 
        /// </summary>  
        public string SpecimenCode
        {
            get { return this._specimenCode; }
            set { this._specimenCode = value; }
        }

        private string _jYName;
        /// <summary>  
        ///  项目名称 
        /// </summary>  
        public string JYName
        {
            get { return this._jYName; }
            set { this._jYName = value; }
        }

        /// <summary>  
        /// 是否匹配
        /// </summary>  
        public bool IsMatching
        {
            get { return _isMatching; }
            set { _isMatching = value; }
        }

        private string _machineName;
        /// <summary>  
        ///  仪器名称 
        /// </summary>  
        public string MachineName
        {
            get { return this._machineName; }
            set { this._machineName = value; }
        }

        /// <summary>  
        /// 仪器流水号id
        /// </summary>  
        public string CKMId
        {
            get { return _cKMId; }
            set { _cKMId = value; }
        }
    }
}
