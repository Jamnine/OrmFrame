

using System;
using System.Collections.Generic;

namespace Orm.Model
{
	/// <summary>
	/// 检查报告申请表 - 实体类
	/// </summary>
	[Serializable]
	public partial class PsApplyReport : BaseModel
	{
        public PsApplyReport() { }

        private string _applyNo;  //申请单号
		
		private DateTime _operTime;  //申请时间
		
		private string _operId;  //申请人
		
		private string _locationId;  //申请科室
		
		private string _doctorId;  //申请医生
		
		private string _patId;  //病人ID
		
		private string _mzRegId;  //门诊流水号
		
		private string _hospId;  //住院流水号
		
		private bool _isCancel;  //作废申请
		
		private DateTime _cancelTime;  //作废时间
		
		private string _cancelOperId;  //作废人
		
		private int _xType;  //申请类别：1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA；12-普放；13-病理；14-其它
		
		private bool _isPre;  //是否预约
		
		private string _itemId;  //检查项目
		
		private bool _isCharged;  //已经收费
		
		private bool _isConfirm;  //影像科确认
		
		private DateTime _confirmTime;  //确认时间
		
		private string _equipment;  //检查设备
		
		private string _applyMemo;  //申请备注
		
		private string _execLocId;  //执行科室
		
		private DateTime _checkTime;  //检查时间
		
		private string _checkOperId;  //检查人
		
		private DateTime _reportTime;  //报告时间
		
		private string _reportOperId;  //报告人
		
		private string _authOperId;  //审核人
		
		private string _checkBody;  //部位
		
		private string _checkParm;  //检查参数
		
		private string _checkDesc;  //检查描述
		
		private string _checkResult;  //检查结果
		
		private string _checkAdvice;  //检查建议
		
		private bool _isAbNormal;  //是否阳性
		
		private string _summary;  //总结
		
		private string _diagnose;  //诊断
		
		private string _checkId;  //体检ID,CkMain.Id
		
		
		
		private string _executeId;  //执行ID
		
		private string _callGroup;  //叫号分组
		
		private int _lsStatus;  //0未读取1已取消(HIS写入,HIS在PACS未读取之前已经取消)2PACS已经读取3已取消PACS写入,进入此状态后HIS才能再做取消4已预约排期,PACS写入5已读取预约排期HIS写入
		
		private string _compGroupId;  //单位体检组ID
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private bool _isExecute;  //是否执行
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 申请单号
		/// </summary>
		public string ApplyNo
		{
			get { return _applyNo;}
			set { _applyNo = value;}
		}                                    
		
		/// <summary>
		/// 申请时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 申请人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 申请科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 申请医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 病人ID
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 门诊流水号
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 住院流水号
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 作废申请
		/// </summary>
		public bool IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
		}                                    
		
		/// <summary>
		/// 作废时间
		/// </summary>
		public DateTime CancelTime
		{
			get { return _cancelTime;}
			set { _cancelTime = value;}
		}                                    
		
		/// <summary>
		/// 作废人
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 申请类别：1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA；12-普放；13-病理；14-其它
		/// </summary>
		public int XType
		{
			get { return _xType;}
			set { _xType = value;}
		}                                    
		
		/// <summary>
		/// 是否预约
		/// </summary>
		public bool IsPre
		{
			get { return _isPre;}
			set { _isPre = value;}
		}                                    
		
		/// <summary>
		/// 检查项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 已经收费
		/// </summary>
		public bool IsCharged
		{
			get { return _isCharged;}
			set { _isCharged = value;}
		}                                    
		
		/// <summary>
		/// 影像科确认
		/// </summary>
		public bool IsConfirm
		{
			get { return _isConfirm;}
			set { _isConfirm = value;}
		}                                    
		
		/// <summary>
		/// 确认时间
		/// </summary>
		public DateTime ConfirmTime
		{
			get { return _confirmTime;}
			set { _confirmTime = value;}
		}                                    
		
		/// <summary>
		/// 检查设备
		/// </summary>
		public string Equipment
		{
			get { return _equipment;}
			set { _equipment = value;}
		}                                    
		
		/// <summary>
		/// 申请备注
		/// </summary>
		public string ApplyMemo
		{
			get { return _applyMemo;}
			set { _applyMemo = value;}
		}                                    
		
		/// <summary>
		/// 执行科室
		/// </summary>
		public string ExecLocId
		{
			get { return _execLocId;}
			set { _execLocId = value;}
		}                                    
		
		/// <summary>
		/// 检查时间
		/// </summary>
		public DateTime CheckTime
		{
			get { return _checkTime;}
			set { _checkTime = value;}
		}                                    
		
		/// <summary>
		/// 检查人
		/// </summary>
		public string CheckOperId
		{
			get { return _checkOperId;}
			set { _checkOperId = value;}
		}                                    
		
		/// <summary>
		/// 报告时间
		/// </summary>
		public DateTime ReportTime
		{
			get { return _reportTime;}
			set { _reportTime = value;}
		}                                    
		
		/// <summary>
		/// 报告人
		/// </summary>
		public string ReportOperId
		{
			get { return _reportOperId;}
			set { _reportOperId = value;}
		}                                    
		
		/// <summary>
		/// 审核人
		/// </summary>
		public string AuthOperId
		{
			get { return _authOperId;}
			set { _authOperId = value;}
		}                                    
		
		/// <summary>
		/// 部位
		/// </summary>
		public string CheckBody
		{
			get { return _checkBody;}
			set { _checkBody = value;}
		}                                    
		
		/// <summary>
		/// 检查参数
		/// </summary>
		public string CheckParm
		{
			get { return _checkParm;}
			set { _checkParm = value;}
		}                                    
		
		/// <summary>
		/// 检查描述
		/// </summary>
		public string CheckDesc
		{
			get { return _checkDesc;}
			set { _checkDesc = value;}
		}                                    
		
		/// <summary>
		/// 检查结果
		/// </summary>
		public string CheckResult
		{
			get { return _checkResult;}
			set { _checkResult = value;}
		}                                    
		
		/// <summary>
		/// 检查建议
		/// </summary>
		public string CheckAdvice
		{
			get { return _checkAdvice;}
			set { _checkAdvice = value;}
		}                                    
		
		/// <summary>
		/// 是否阳性
		/// </summary>
		public bool IsAbNormal
		{
			get { return _isAbNormal;}
			set { _isAbNormal = value;}
		}                                    
		
		/// <summary>
		/// 总结
		/// </summary>
		public string Summary
		{
			get { return _summary;}
			set { _summary = value;}
		}                                    
		
		/// <summary>
		/// 诊断
		/// </summary>
		public string Diagnose
		{
			get { return _diagnose;}
			set { _diagnose = value;}
		}                                    
		
		/// <summary>
		/// 体检ID,CkMain.Id
		/// </summary>
		public string CheckId
		{
			get { return _checkId;}
			set { _checkId = value;}
		}                                    
		
		                          
		
		/// <summary>
		/// 执行ID
		/// </summary>
		public string ExecuteId
		{
			get { return _executeId;}
			set { _executeId = value;}
		}                                    
		
		/// <summary>
		/// 叫号分组
		/// </summary>
		public string CallGroup
		{
			get { return _callGroup;}
			set { _callGroup = value;}
		}                                    
		
		/// <summary>
		/// 0未读取1已取消(HIS写入,HIS在PACS未读取之前已经取消)2PACS已经读取3已取消PACS写入,进入此状态后HIS才能再做取消4已预约排期,PACS写入5已读取预约排期HIS写入
		/// </summary>
		public int LsStatus
		{
			get { return _lsStatus;}
			set { _lsStatus = value;}
		}                                    
		
		/// <summary>
		/// 单位体检组ID
		/// </summary>
		public string CompGroupId
		{
			get { return _compGroupId;}
			set { _compGroupId = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 是否执行
		/// </summary>
		public bool IsExecute
		{
			get { return _isExecute;}
			set { _isExecute = value;}
		}                                    
		                                
		        
	}
    //public partial class PsApplyReportImage : BaseModel
    //{
    //    #region 构造函数
    //    /// <summary>
    //    ///  构造函数
    //    /// </summary>
    //    public PsApplyReportImage()
    //    {
    //    }
    //    #endregion

    //    #region 字段  Applyid, FileName, GUID, IsChecked, RptImage
    //    /// <summary>
    //    /// 
    //    /// </summary>	
     
    //    public virtual string Applyid { get; set; }

    //    /// <summary>
    //    /// 
    //    /// </summary>	
      
    //    public virtual string FileName { get; set; }

    //    /// <summary>
    //    ///  标识列 DbGenerated
    //    /// </summary>	
      
    //    public virtual string GUID { get; set; }

    //    /// <summary>
    //    /// 
    //    /// </summary>	
        
    //    public virtual Boolean? IsChecked { get; set; }

    //    /// <summary>
    //    /// 
    //    /// </summary>	
        
    //    public virtual Byte?[] RptImage { get; set; }

    //    #endregion
    //}


    //public partial class PSApplyItem : BaseModel
    //{
    //    #region 构造函数
    //    /// <summary>
    //    ///  构造函数
    //    /// </summary>
    //    public PSApplyItem()
    //    {
    //    }
    //    #endregion

    //    #region 字段  CancelOperId, CancelTime, CheckBody-部位, IsCancel, ItemId-检查项目, OperTime-申请时间, PsApplyId-检查报告申请表GUID

       
    //    public virtual string GUID { get; set; }

    //    /// <summary>
    //    /// 
    //    /// </summary>	

    //    public virtual string CancelOperId { get; set; }

    //    /// <summary>
    //    /// 
    //    /// </summary>	

    //    public virtual DateTime? CancelTime { get; set; }

    //    /// <summary>
    //    /// 部位
    //    /// </summary>	

    //    public virtual string CheckBody { get; set; }

    //    /// <summary>
    //    /// 
    //    /// </summary>	

    //    public virtual Boolean? IsCancel { get; set; }

    //    /// <summary>
    //    /// 检查项目
    //    /// </summary>	

    //    public virtual string ItemId { get; set; }

    //    /// <summary>
    //    /// 申请时间
    //    /// </summary>	

    //    public virtual DateTime? OperTime { get; set; }

    //    /// <summary>
    //    /// 检查报告申请表GUID
    //    /// </summary>	

    //    public virtual string PsApplyId { get; set; }

    //    #endregion
    //}
}           


