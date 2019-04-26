

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class InDrugReqdtlSkinBack : BaseModel
    {    
		
		private string _reqDtlId;  //发票明细ID
		
		private double _totality;  //领药申请ID
		
		private string _unitId;  //单位
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private string _detailId;  //费用ID
		
		private bool _isCharged;  //收费确认
		
		private string _adviceId;  //医嘱ID
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InDrugReqdtlSkinBack() { }
		 
		/// <summary>
		/// 发票明细ID
		/// </summary>
		public string ReqDtlId
		{
			get { return _reqDtlId;}
			set { _reqDtlId = value;}
		}                                    
		
		/// <summary>
		/// 领药申请ID
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 费用ID
		/// </summary>
		public string DetailId
		{
			get { return _detailId;}
			set { _detailId = value;}
		}                                    
		
		/// <summary>
		/// 收费确认
		/// </summary>
		public bool IsCharged
		{
			get { return _isCharged;}
			set { _isCharged = value;}
		}                                    
		
		/// <summary>
		/// 医嘱ID
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
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
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


