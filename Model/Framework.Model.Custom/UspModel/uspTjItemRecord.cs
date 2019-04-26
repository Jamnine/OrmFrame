using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 体检项目记录信息
    /// </summary>
    [Serializable]
    public class uspTjItemRecord : BaseModel
    {
        public uspTjItemRecord()
        {

        }

        private string _itemCode = string.Empty;
        /// <summary>
        /// 项目编码
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }

        private string _groupItemCode = string.Empty;
        /// <summary>
        /// 项目组编码
        /// </summary>
        public string GroupItemCode
        {
            get { return _groupItemCode; }
            set { _groupItemCode = value; }
        }

        private string _itemName = string.Empty;
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        private string _tjResult = "未检";
        /// <summary>
        /// 体检结果
        /// </summary>
        public string TjResult
        {
            get { return _tjResult; }
            set { _tjResult = value; }
        }
        private string _lastTjResult = string.Empty;
        /// <summary>
        /// 上次体检结果
        /// </summary>
        public string LastTjResult
        {
            get { return _lastTjResult; }
            set { _lastTjResult = value; }
        }

        private string _dataType = "C";
        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType
        {
            get { return _dataType; }
            set { _dataType = value; }
        }

        private string _referRange = string.Empty;
        /// <summary>
        /// 参考范围
        /// </summary>
        public string ReferRange
        {
            get { return _referRange; }
            set { _referRange = value; }
        }

        private string _itemUnit = string.Empty;
        /// <summary>
        /// 单位
        /// </summary>
        public string ItemUnit
        {
            get { return _itemUnit; }
            set { _itemUnit = value; }
        }

        private string _abnormalTips = string.Empty;
        /// <summary>
        /// 异常提示
        /// </summary>
        public string AbnormalTips
        {
            get { return _abnormalTips; }
            set { _abnormalTips = value; }
        }


        private bool _isAbnormal = false;
        /// <summary>
        /// 是否异常
        /// </summary>
        public bool IsAbnormal
        {
            get { return _isAbnormal; }
            set { _isAbnormal = value; }
        }

        private bool _isGroup = false;
        /// <summary>
        /// 是否组合
        /// </summary>
        public bool IsGroup
        {
            get { return _isGroup; }
            set { _isGroup = value; }
        }

        private string _doctorID;
        /// <summary>
        /// 医生
        /// </summary>
        public string DoctorID
        {
            get { return _doctorID; }
            set { _doctorID = value; }
        }

        private string _tjLocationID;
        /// <summary>
        /// 体检科室
        /// </summary>
        public string TjLocationID
        {
            get { return _tjLocationID; }
            set { _tjLocationID = value; }
        }

        private DateTime _operTime;
        /// <summary>
        /// 检查日期
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }
        private string _operId;
        /// <summary>
        /// 操作人
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }


        private string _classID;
        /// <summary>
        /// 大类ID
        /// </summary>
        public string ClassID
        {
            get { return _classID; }
            set { _classID = value; }
        }
        private bool _isCharge = false;
        /// <summary>
        /// 是否收费
        /// </summary>
        public bool IsCharge
        {
            get { return _isCharge; }
            set { _isCharge = value; }
        }

        private bool _isOver = false;
        /// <summary>
        /// 是否小结
        /// </summary>
        public bool IsOver
        {
            get { return _isOver; }
            set { _isOver = value; }
        }

        private string _ouRecipeDtlID;
        /// <summary>
        /// 收费明细ID
        /// </summary>
        public string RecipeDtlId
        {
            get { return _ouRecipeDtlID; }
            set { _ouRecipeDtlID = value; }
        }
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

        private string _sourceId;
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

        private string _qCstandId;
        /// <summary>  
        /// 标本样品id 
        /// </summary>  
        public string QCstandId
        {
            get { return _qCstandId; }
            set { _qCstandId = value; }
        }

        private double _referLowerLimit;
        /// <summary>  
        /// 参考下限  
        /// </summary>  
        public double LimitLow
        {
            get { return _referLowerLimit; }
            set { _referLowerLimit = value; }
        }

        private double _referTopLimit;
        /// <summary>  
        /// 参考上限  
        /// </summary>  
        public double LimitHigh
        {
            get { return _referTopLimit; }
            set { _referTopLimit = value; }
        }

        private double _veryLowLimit;
        /// <summary>  
        /// 极低危值  
        /// </summary>  
        public double VeryLowLimit
        {
            get { return _veryLowLimit; }
            set { _veryLowLimit = value; }
        }

        private double _veryTopLimit;
        /// <summary>  
        /// 极高危值  
        /// </summary>  
        public double VeryTopLimit
        {
            get { return _veryTopLimit; }
            set { _veryTopLimit = value; }
        }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int order { get; set; }

        private string _cKMId;
        /// <summary>  
        /// 仪器id
        /// </summary>  
        public string CKMId
        {
            get { return _cKMId; }
            set { _cKMId = value; }
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

        private string _qCReagentlot;
        /// <summary>  
        /// QC试剂批号
        /// </summary>  
        public string QCReagentlot
        {
            get { return _qCReagentlot; }
            set { _qCReagentlot = value; }
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
        ///批准
        public bool IsApproval
        {
            get { return _isApproval; }
            set { this._isApproval = value; }
        }

        private string _commentary;
        /// <summary>  
        /// 评论
        /// </summary>  
        public string Commentary
        {
            get { return _commentary; }
            set { this._commentary = value; }
        }


        private string _labNum;
        public object OuRecipeDtlID;

        /// <summary>
        /// 标本号
        /// </summary>
        public string LabNum
        {
            get { return _labNum; }
            set { _labNum = value; }
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
        public string CommonProblem { get; set; }
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

        private string _testIllustration;
        /// <summary>
        /// 行心云：检测说明
        /// </summary>
        public string TestIllustration
        {
            get { return _testIllustration; }
            set { _testIllustration = value; }
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

        public string CkItemId { get; set; }
    }
}
