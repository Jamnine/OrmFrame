

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class PsDrugAction : BaseModel
	{   
		
		private string _applyNo;  //申请单号
		
		private DateTime _operTime;  //申请时间
		
		private string _operId;  //申请人
		
		private string _locationId;  //申请科室
		
		private string _doctorId;  //申请医生
		
		private string _patId;  //病人ID,对应BsPatient.Id
		
		private string _mzRegId;  //门诊流水号
		
		private string _hospId;  //住院流水号
		
		private bool _isCancel;  //作废申请
		
		private DateTime _cancelTime;  //作废时间
		
		private string _cancelOperId;  //作废人
		
		private string _itemId;  //药品
		
		private DateTime _reactTime;  //反应时间
		
		private int _lsTransType;  //输血反应类型：1-发热、2-过敏、3-荨麻疹、4-溶血反应、5-非溶血性发热、6-心功能衰竭、7-循环负荷过重、8-肺部并发症
		
		private string _clincHandle;  //临床处理
		
		private string _memo;  //备注
		
		private bool _isAuthed;  //已经封存，不可改删
		
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
		/// 病人ID,对应BsPatient.Id
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
		/// 药品
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 反应时间
		/// </summary>
		public DateTime ReactTime
		{
			get { return _reactTime;}
			set { _reactTime = value;}
		}                                    
		
		/// <summary>
		/// 输血反应类型：1-发热、2-过敏、3-荨麻疹、4-溶血反应、5-非溶血性发热、6-心功能衰竭、7-循环负荷过重、8-肺部并发症
		/// </summary>
		public int LsTransType
		{
			get { return _lsTransType;}
			set { _lsTransType = value;}
		}                                    
		
		/// <summary>
		/// 临床处理
		/// </summary>
		public string ClincHandle
		{
			get { return _clincHandle;}
			set { _clincHandle = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		                                  
		        
	}  
}           


