// ===================================================================   
// Model  
// ===================================================================   
// File: TjItemRecord.cs  
//   
// Copyright   
// History:  
// 2015/12/18 17:06:13: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    /// 体检记录  数据库不存在此表
    /// </summary>  
    [Serializable] 
    public partial class TjItemRecord : BaseModel
    {  
        private string _mzRegId;  
        private string _tjItemCode = String.Empty;
        private string _groupItemCode = String.Empty;  
        private string _tjResult = String.Empty;
        private string _describe = String.Empty;
        private bool _isAbNormal;  
        private string _abnormalTips = String.Empty;  
        private bool _isGroup;  
        private string _doctorId;  
        private string _tjLocationID;  
        private bool _isCharge;  
        private bool _isOver;  
        private string _operId;  
        private DateTime _operTime;
        private int _itemInterface;
        private string _commentary=string.Empty;
        private string _sourceId;
        private string _properties = string.Empty;
        private int _sampleNum = 0;
        private string _qCstandId;
        private string _testIllustration = String.Empty;
        private string _commonProblem = String.Empty;
        private string _cKMId;
        private bool _sendStatus;
        private string _qCReagentlot;
        private string _testTypeId;

        public TjItemRecord()  
        {  
        }

        /// <summary>  
        /// 标准样品id 
        /// </summary>  
        public string QCstandId
        {
            get { return _qCstandId; }
            set { _qCstandId = value; }
        }

        /// <summary>  
        /// 就诊id
        /// </summary>  
        public string MzRegId  
        {  
            get { return this._mzRegId; }  
            set { this._mzRegId = value; }  
        }

        /// <summary>
        /// 数据类型 N 数值型 C字符型  
        /// </summary>
        public string DataType { get; set; }
  
        /// <summary>  
        ///  体检项目编码 
        /// </summary>  
        public string TjItemCode  
        {  
            get { return this._tjItemCode; }  
            set { this._tjItemCode = value; }  
        }  
  
        /// <summary>  
        /// 组合项目编码  
        /// </summary>  
        public string GroupItemCode  
        {
            get { return this._groupItemCode; }
            set { this._groupItemCode = value; }  
        }  
  
        /// <summary>  
        /// 项目结果  
        /// </summary>  
        public string TjResult  
        {  
            get { return this._tjResult; }  
            set { this._tjResult = value; }  
        }

        /// <summary>  
        ///  类别ID 
        /// </summary>  
        public string TestTypeId
        {
            get { return this._testTypeId; }
            set { this._testTypeId = value; }
        }


        /// <summary>  
        /// 是否异常  
        /// </summary>  
        public bool IsAbNormal  
        {  
            get { return this._isAbNormal; }  
            set { this._isAbNormal = value; }  
        }

        /// <summary>  
        /// 描述
        /// </summary>  
        public string Describe
        {
            get { return this._describe; }
            set { this._describe = value; }
        }
        /// <summary>  
        /// 异常提示  
        /// </summary>  
        public string AbnormalTips  
        {  
            get { return this._abnormalTips; }  
            set { this._abnormalTips = value; }  
        }  
  
        /// <summary>  
        ///  是否组合 
        /// </summary>  
        public bool IsGroup  
        {  
            get { return this._isGroup; }  
            set { this._isGroup = value; }  
        }  
  
        /// <summary>  
        /// 检查医生  
        /// </summary>  
        public string DoctorId  
        {  
            get { return this._doctorId; }  
            set { this._doctorId = value; }  
        }  
  
        /// <summary>  
        ///  体检科室
        /// </summary>  
        public string TjLocationID  
        {  
            get { return this._tjLocationID; }  
            set { this._tjLocationID = value; }  
        }  
  
        /// <summary>  
        /// 是否收费  
        /// </summary>  
        public bool IsCharge  
        {  
            get { return this._isCharge; }  
            set { this._isCharge = value; }  
        }  
  
        /// <summary>  
        ///  是否小结 
        /// </summary>  
        public bool IsOver  
        {  
            get { return this._isOver; }  
            set { this._isOver = value; }  
        }  
  
        /// <summary>  
        ///   操作人id
        /// </summary>  
        public string OperId  
        {  
            get { return this._operId; }  
            set { this._operId = value; }  
        }  
  
        /// <summary>  
        ///   操作人名称
        /// </summary>  
        public DateTime OperTime  
        {  
            get { return this._operTime; }  
            set { this._operTime = value; }  
        }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID { get; set; }

        /// <summary>
        /// 费用明细ID
        /// </summary>
        public string RecipeDtlId { get; set; }

        /// <summary>  
        ///   收费项目ID
        /// </summary>  
        public string ItemId { get; set; }


        /// <summary>
        ///  检验项目ID
        /// </summary>
        public string CKItemGUID { get; set; }

        /// <summary>  
        /// 项目对应仪器接口
        /// </summary>  
        public int ItemInterface
        {
            get { return _itemInterface; }
            set { _itemInterface = value; }
        }

        /// <summary>
        /// 评论
        /// </summary>
        public string Commentary
        {
            get { return _commentary; }
            set { _commentary = value; }
        }

        /// <summary>
        /// 检测说明
        /// </summary>
        public string TestIllustration
        {
            get { return _testIllustration; }
            set { _testIllustration = value; }
        }

        /// <summary>  
        ///  常见问题 
        /// </summary>  
        public string CommonProblem
        {
            get { return _commonProblem; }
            set { _commonProblem = value; }
        }

        /// <summary>
        /// 标本类型
        /// </summary>
        public string SourceId
        {
            get { return _sourceId; }
            set { _sourceId = value; }
        }

        /// <summary>
        /// 样本性状
        /// </summary>
        public string Properties
        {
            get { return _properties; }
            set { _properties = value; }
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
        /// 仪器id
        /// </summary>  
        public string CKMId
        {
            get { return _cKMId; }
            set { _cKMId = value; }
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
        /// QC试剂批号
        /// </summary>  
        public string QCReagentlot
        {
            get { return _qCReagentlot; }
            set { _qCReagentlot = value; }
        }

        private bool _isApproval;
        /// <summary>  
        ///  批准医生查看检验报告
        /// </summary>  
        public bool IsApproval
        {
            get { return this._isApproval; }
            set { this._isApproval = value; }
        }

        private bool _isSelected;
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelected
        {
            get { return _isSelected; }
            set { this._isSelected = value; }
        }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName
        {
            get;
            set;
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

        private DateTime _approvalTime;
        /// <summary>  
        ///  批准时间
        /// </summary>  
        public DateTime ApprovalTime
        {
            get { return this._approvalTime; }
            set { this._approvalTime = value; }
        }

        private string _itemName;
        /// <summary>  
        /// 项目名称
        /// </summary>  
        public string ItemName
        {
            get { return this._itemName; }
            set { this._itemName = value; }
        }

        /// <summary>
        ///项目单位
        /// </summary>
        public string ItemUnit { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 参考范围上限
        /// </summary>
        public double ReferTop { get; set; }

        /// <summary>
        /// 参考范围下限
        /// </summary>
        public double ReferLow { get; set; }

        /// <summary>
        ///  极高危值
        /// </summary>
        public double VeryTop { get; set; }

        /// <summary>
        /// 极低危值 
        /// </summary>
        public double VeryLow { get; set; }

        /// <summary>
        /// 偏高提示 
        /// </summary>
        public string ReferTopT { get; set; }

        /// <summary>
        ///  偏低提示 
        /// </summary>
        public string ReferLowT { get; set; }

        /// <summary>
        /// 极高危提示  
        /// </summary>
        public string VeryTopT { get; set; }

        /// <summary>
        /// 极低危提示  
        /// </summary>
        public string VeryLowT { get; set; }

        /// <summary>
        ///引用类型
        /// </summary>
        public string ReferType { get; set; }


        private int _orderBy;
        /// <summary>  
        ///   显示顺序
        /// </summary>  
        public int OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }
    }
}  

