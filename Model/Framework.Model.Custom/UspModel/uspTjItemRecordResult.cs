using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 体检记录报告
    /// </summary>
    [Serializable]
    public class uspTjItemRecordResult : BaseModel
    {
        public uspTjItemRecordResult()
        {

        }

        /// <summary>
        /// 是否收费
        /// </summary>
        public bool IsCharge { get; set; }

        private string _itemCode = string.Empty;
        /// <summary>
        /// 项目编码
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }

        private string _groupItemID;
        /// <summary>
        /// 项目组合ID
        /// </summary>
        public string GroupItemID
        {
            get { return _groupItemID; }
            set { _groupItemID = value; }
        }

        private string _tjItemID;
        /// <summary>
        /// 项目明细ID
        /// </summary>
        public string TjItemID
        {
            get { return _tjItemID; }
            set { _tjItemID = value; }
        }

        private string _groupName = string.Empty;
        /// <summary>
        /// 项目组合名称
        /// </summary>
        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
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

        private int _tjResultLevel = 0;
        /// <summary>
        /// 体检结果级别
        /// </summary>
        public int TjResultLevel
        {
            get { return _tjResultLevel; }
            set { _tjResultLevel = value; }
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

        /// <summary>
        /// 科室
        /// </summary>
        public string TjLocationName { get; set; }

        /// <summary>
        /// 医生
        /// </summary>
        public string DoctorName { get; set; }

        /// <summary>
        /// 是否检验科
        /// </summary>
        public bool IsCheckLocation { get; set; }

        /// <summary>  
        ///  小结 
        /// </summary>  
        public string Summary { get; set; }

        /// <summary>  
        ///  建议 
        /// </summary>  
        public string Suggestion { get; set; }

        /// <summary>
        /// 是否小结
        /// </summary>
        public bool IsOver { get; set; }

        /// <summary>
        /// 项目医生
        /// </summary>
        public string ItemDoctorName { get; set; }

        /// <summary>
        /// 小结时间
        /// </summary>
        public DateTime SummaryOperTime { get; set; }

        /// <summary>
        /// 综合分析
        /// </summary>
        public string CAnalysis { get; set; }

        /// <summary>
        /// 健康结论
        /// </summary>
        public string Conclusion { get; set; }

        /// <summary>
        /// 干预方案
        /// </summary>
        public string Programme { get; set; }

        /// <summary>  
        ///  结果判定 
        /// </summary>  
        public string ResultDetermine
        {
            get;
            set;
        }

        /// <summary>  
        ///  结果分析 
        /// </summary>  
        public string RAnalysis
        {
            get;
            set;
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

        /// <summary>
        /// 标本类型名称
        /// </summary>
        public string SourceName { get; set; }

        private string _properties = string.Empty;
        /// <summary>
        /// 样本性状
        /// </summary>
        public string Properties
        {
            get { return _properties; }
            set { _properties = value; }
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

        private bool _isHideIllness;
        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public bool IsHideIllness
        {
            get { return _isHideIllness; }
            set { _isHideIllness = value; }
        }

        private string _cardNo = string.Empty;
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }

        private string _patName = string.Empty;
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName
        {
            get { return _patName; }
            set { _patName = value; }
        }

        private string _sex = string.Empty;
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private int _age = 0;
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _ageString = String.Empty;
        /// <summary>
        /// 年龄（字符串格式）
        /// </summary>
        public string AgeString
        {
            get { return _ageString; }
            set { _ageString = value; }
        }

        private string _mobile = string.Empty;
        /// <summary>
        /// 电话
        /// </summary>
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

        private DateTime _birthDate;
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        private string _summaryOperName = string.Empty;
        /// <summary>
        /// 审核人
        /// </summary>
        public string SummaryOperName
        {
            get { return _summaryOperName; }
            set { _summaryOperName = value; }
        }


        private string _operName = string.Empty;
        /// <summary>
        /// 批准人
        /// </summary>
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
        }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int order { get; set; }

        /// <summary>
        /// 项目类别
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// 临床表现
        /// </summary>
        public string Chiefcomplaint { get; set; }

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

        /// <summary>
        /// 门诊id
        /// </summary>
        public string mzRegID { get; set; }

        private bool _isApproval;
        /// <summary>  
        ///  批准医生查看检验报告
        /// </summary>  
        public bool IsApproval
        {
            get { return this._isApproval; }
            set { this._isApproval = value; }
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

        private string _specimenCode;
        /// <summary>  
        ///  标本号 
        /// </summary>  
        public string SpecimenCode
        {
            get { return this._specimenCode; }
            set { this._specimenCode = value; }
        }

        public string CkItemGuid { get; set; }
    }
}
