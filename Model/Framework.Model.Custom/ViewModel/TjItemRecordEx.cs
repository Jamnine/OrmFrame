using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 体检项目相关数据
    /// </summary>
    [Serializable]
    public class TjItemRecordEx
    {
        public TjItemRecordEx()
        {

        }

        private string _Guid;

        private string _itemCode = "";

        private string _groupItemCode = "";

        private string _itemName = "";

        private string _tjResult = "未检";

        private string _lastTjResult = "";

        private string _dataType = "C";

        private string _referRange = "";

        private string _itemUnit = "";

        private string _abnormalTips = "";

        private bool _isAbnormal = false;

        private bool _isGroup = false;

        private string _doctorID;

        private string _tjLocationID;

        private DateTime _operTime;

        private bool _isCharge = false;

        private bool _isOver = false;

        private string _ouRecipeDtlID = "";

        /// <summary>  
        ///   收费项目ID
        /// </summary>  
        public string ItemId { get; set; }

        private string _itemInterface = String.Empty;
        /// <summary>  
        /// 项目对应仪器接口
        /// </summary>  
        public string ItemInterface
        {
            get { return _itemInterface; }
            set { _itemInterface = value; }
        }

        private string _commentary = string.Empty;

        /// <summary>
        /// 评论
        /// </summary>
        public string Commentary
        {
            get { return _commentary; }
            set { _commentary = value; }
        }

        private string _sourceId = "";
        /// <summary>
        /// 标本类型
        /// </summary>
        public string SourceId
        {
            get { return _sourceId; }
            set { _sourceId = value; }
        }
        private string _properties = string.Empty;

        /// <summary>
        /// 样本性状
        /// </summary>
        public string Properties
        {
            get { return _properties; }
            set { _properties = value; }
        }

        private int _sampleNum;
        /// <summary>  
        /// 仪器流水号 
        /// </summary>  
        public int SampleNum
        {
            get { return _sampleNum; }
            set { _sampleNum = value; }
        }
        /// <summary>
        /// 检测说明
        /// </summary>
        public string TestIllustration
        {
            get;
            set;
        }
        /// <summary>  
        ///  常见问题 
        /// </summary>  
        public string CommonProblem
        {
            get;
            set;
        }

        private double _referLowerLimit;
        private double _referTopLimit;
        private double _veryLowLimit;
        private double _veryTopLimit;

        /// <summary>  
        /// 参考下限  
        /// </summary>  
        public double LimitLow
        {
            get { return _referLowerLimit; }
            set { _referLowerLimit = value; }
        }

        /// <summary>  
        /// 参考上限  
        /// </summary>  
        public double LimitHigh
        {
            get { return _referTopLimit; }
            set { _referTopLimit = value; }
        }


        /// <summary>  
        /// 极低危值  
        /// </summary>  
        public double VeryLowLimit
        {
            get { return _veryLowLimit; }
            set { _veryLowLimit = value; }
        }

        /// <summary>  
        /// 极高危值  
        /// </summary>  
        public double VeryTopLimit
        {
            get { return _veryTopLimit; }
            set { _veryTopLimit = value; }
        }

        private bool _sendStatus;
        /// <summary>  
        /// 是否传回 
        /// </summary>  
        public bool SendStatus
        {
            get { return _sendStatus; }
            set { _sendStatus = value; }
        }

        private string _itemInterfaceChannel = String.Empty;
        /// <summary>  
        /// 项目对应仪器通道
        /// </summary>  
        public string ItemInterfaceChannel
        {
            get { return _itemInterfaceChannel; }
            set { _itemInterfaceChannel = value; }
        }

        /// <summary>
        /// 标本类型名称
        /// </summary>
        public string SourceName { get; set; }

        private string _operId;
        /// <summary>
        /// 操作人
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        private string _qCstandId;
        /// <summary>  
        /// 标本样品id 
        /// </summary>  
        public string QCstandId
        {
            get { return _qCstandId; }
            set { _qCstandId = value; }
        }

        private string _cKMId = "";
        /// <summary>  
        /// 仪器id
        /// </summary>  
        public string CKMId
        {
            get { return _cKMId; }
            set { _cKMId = value; }
        }

        private string _qCReagentlot;
        /// <summary>  
        /// QC试剂批号
        /// </summary>  
        public string QCReagentlot
        {
            get { return _qCReagentlot; }
            set { _qCReagentlot = value; }
        }


        private int _decimalDigits;
        /// <summary>
        /// 保留小数位数
        /// </summary>
        public int DecimalDigits
        {
            get { return _decimalDigits; }
            set { _decimalDigits = value; }
        }

        private string _tjResultCopy;
        /// <summary>  
        /// 保存失控结果
        /// </summary>  
        public string TjResultCopy
        {
            get { return _tjResultCopy; }
            set { this._tjResultCopy = value; }
        }


        private bool _isApproval;
        /// <summary>  
        ///  批准
        /// </summary>  
        public bool IsApproval
        {
            get { return this._isApproval; }
            set { this._isApproval = value; }
        }

        public string GUID
        {
            get { return this._Guid; }
            set { this._Guid = value; }
        }
        public string ItemCode
        {
            get { return this._itemCode; }
            set { this._itemCode = value; }
        }
        public string GroupItemCode
        {
            get { return this._groupItemCode; }
            set { this._groupItemCode = value; }
        }
        public string ItemName
        {
            get { return this._itemName; }
            set { this._itemName = value; }
        }
        public string TjResult
        {
            get { return this._tjResult; }
            set { this._tjResult = value; }
        }
        public string LastTjResult
        {
            get { return this._lastTjResult; }
            set { this._lastTjResult = value; }
        }
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }
        public string ReferRange
        {
            get { return this._referRange; }
            set { this._referRange = value; }
        }
        public string ItemUnit
        {
            get { return this._itemUnit; }
            set { this._itemUnit = value; }
        }
        public string AbnormalTips
        {
            get { return this._abnormalTips; }
            set { this._abnormalTips = value; }
        }
        public bool IsAbnormal
        {
            get { return this._isAbnormal; }
            set { this._isAbnormal = value; }
        }
        public bool IsGroup
        {
            get { return this._isGroup; }
            set { this._isGroup = value; }
        }
        public string DoctorID
        {
            get { return this._doctorID; }
            set { this._doctorID = value; }
        }
        public string TjLocationID
        {
            get { return this._tjLocationID; }
            set { this._tjLocationID = value; }
        }
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }
        public bool IsCharge
        {
            get { return this._isCharge; }
            set { this._isCharge = value; }
        }
        public bool IsOver
        {
            get { return this._isOver; }
            set { this._isOver = value; }
        }
        public string RecipeDtlId
        {
            get { return this._ouRecipeDtlID; }
            set { this._ouRecipeDtlID = value; }
        }
 

        private int _HospitalID;
        /// <summary>  
        /// 医院ID
        /// </summary>  
        public int HospitalID
        {
            get { return this._HospitalID; }
            set { this._HospitalID = value; }
        }

        private string _testid;
        /// <summary>  
        ///  检验项目ID,对应CkItem.Id
        /// </summary>  
        public string Testid
        {
            get { return this._testid; }
            set { this._testid = value; }
        }
    
        public int LsrefFlag { get; set; }

        public DateTime AuthDocTime { get; set; }

        private double _lowvalue;
        /// <summary>  
        /// 正常低值
        /// </summary>  
        public double LowValue
        {
            get { return this._lowvalue; }
            set { this._lowvalue = value; }
        }
        private double _highvalue;
        /// <summary>  
        /// 正常高值
        /// </summary>  
        public double HighValue
        {
            get { return this._highvalue; }
            set { this._highvalue = value; }
        }

       
        private string _lastResult;
        /// <summary>  
        /// 上次检查结果 失控结果
        /// </summary>  
        public string LastResult
        {
            get { return this._lastResult; }
            set { this._lastResult = value; }
        }
        private string _unit;
        /// <summary>  
        /// 单位
        /// </summary>  
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        private string _memo;
        /// <summary>  
        /// 报告备注
        /// </summary>  
        public string Memo
        {
            get { return this._memo; }
            set { this._memo = value; }
        }


        private string _labid;
        /// <summary>  
        /// 体检指引单号
        /// </summary>  
        public string Labid
        {
            get { return _labid; }
            set { _labid = value; }
        }
    }
}
