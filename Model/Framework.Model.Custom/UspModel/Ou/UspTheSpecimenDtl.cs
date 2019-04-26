using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 标本信息
    /// </summary>
    [Serializable]
    public class UspTheSpecimenDtl : BaseModel
    {
        public UspTheSpecimenDtl()
        { }

        private string _patcode = String.Empty;
        private string _name ;
        private string _comments = String.Empty;
        private string _sourceId;
        private string _tubeTypeId;
        private string _patName;
        private string _itemName; 
        private string _tjLocationName;
        private string _sourceName;
        private string _tubeTypeName;
        private string _hosId;
        private string _specimenCode;
        private string _tjitemId;
        private string _patID;
        private int _printTagType;
        private string _cKMachineID;
        private int _samlingType = 0;
        private int _lsstatus ;
        private string _cklabID;   // 标本id

        private bool _isGroup;

        /// <summary>
        /// 行心云：是否组合
        /// </summary>
        public bool IsGroup
        {
            get { return _isGroup; }
            set { _isGroup = value; }
        }
        /// <summary>  
        /// 病人id  
        /// </summary>  
        public string PatID
        {
            get { return _patID; }
            set { _patID = value; }
        }

        /// <summary>  
        ///  标本号 
        /// </summary>  
        public string SpecimenCode
        {
            get { return this._specimenCode; }
            set { this._specimenCode = value; }
        }

        /// <summary>
        /// 就诊id
        /// </summary>
        public string HosId
        {
            get { return this._hosId; }
            set { this._hosId = value; }
        }

        /// <summary>
        /// 检验项目id
        /// </summary>
        public string TjitemId
        {
            get { return this._tjitemId; }
            set { this._tjitemId = value; }
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
        ///  项目名称 
        /// </summary>  
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>  
        ///  项目名称 
        /// </summary>  
        public string ItemName
        {
            get { return this._itemName; }
            set { this._itemName = value; }
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
        ///  备注 
        /// </summary>  
        public string Comments
        {
            get { return this._comments; }
            set { this._comments = value; }
        }

        /// <summary>  
        /// 体检科室
        /// </summary>  
        public string TjLocationName
        {
            get { return this._tjLocationName; }
            set { this._tjLocationName = value; }
        }

        /// <summary>  
        /// 标本id  
        /// </summary>  
        public string SourceId
        {
            get { return _sourceId; }
            set { _sourceId = value; }
        }

        /// <summary>  
        /// 标本名称
        /// </summary>  
        public string SourceName
        {
            get { return _sourceName; }
            set { _sourceName = value; }
        }

        /// <summary>  
        /// 容器类型id  
        /// </summary>  
        public string TubeTypeId
        {
            get { return _tubeTypeId; }
            set { _tubeTypeId = value; }
        }

        /// <summary>  
        /// 容器类型
        /// </summary>  
        public string TubeTypeName
        {
            get { return _tubeTypeName; }
            set { _tubeTypeName = value; }
        }

        private DateTime _registrationTime = DateTime.MinValue;
        /// <summary>
        /// 登记时间
        /// </summary>
        public DateTime RegistrationTime
        {
            get { return _registrationTime; }
            set { _registrationTime = value; }
        }

        private bool _isAcquisition;
        /// <summary>
        /// 是否采集
        /// </summary>
        public bool IsAcquisition
        {
            get { return _isAcquisition; }
            set { _isAcquisition = value; }
        }

        private bool _isReceive;
        /// <summary>
        /// 是否接收
        /// </summary>
        public bool IsReceive
        {
            get { return _isReceive; }
            set { _isReceive = value; }
        }

        private DateTime _receiveTime;
        /// <summary>
        /// 接收时间
        /// </summary>
        public DateTime ReceiveTime
        {
            get { return _receiveTime; }
            set { _receiveTime = value; }
        }

        private DateTime _acquisitionTime;
        /// <summary>
        /// 采集时间
        /// </summary>
        public DateTime AcquisitionTime
        {
            get { return _acquisitionTime; }
            set { _acquisitionTime = value; }
        }

        private string _sex;
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private string _age;
        /// <summary>
        /// 年龄
        /// </summary>
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// 打印采样提醒标签
        /// </summary>
        public int PrintTagType
        {
            get { return _printTagType; }
            set { _printTagType = value; }
        }

        /// <summary>
        /// 仪器ID
        /// </summary>
        public string CKMachineID
        {
            get { return this._cKMachineID; }
            set { this._cKMachineID = value; }
        }

        /// <summary>
        /// 采样方式 1-护士采 2-自采
        /// </summary>
        public int SamlingType
        {
            get { return this._samlingType; }
            set { this._samlingType = value; }
        }

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsChoose { get; set; }

        /// <summary>
        /// 医生姓名
        /// </summary>
        public string DocName { get; set; }

        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegNo { get; set; }

        /// <summary>
        /// 检验状态
        /// </summary>
        public int LsStatus
        {
            get { return this._lsstatus; }
            set { this._lsstatus = value; }
        }

        /// <summary>
        /// 标本ID
        /// </summary>
        public string CkLabID
        {
            get { return this._cklabID; }
            set { this._cklabID = value; }
        }

    }
}
