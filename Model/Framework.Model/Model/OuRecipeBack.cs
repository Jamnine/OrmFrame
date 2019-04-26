

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊处方退药申请表 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuRecipeBack : BaseModel
	{   
		
		private string _reqDtlId;  //处方明细ID
		
		private double _totality;  //退药数量
		
		private string _unitId;  //单位
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private string _detailId;  //费用ID
		
		private bool _isCharged;  //收费确认
		
		private double _issueTotality;  //发药数量
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 

		/// <summary>
		/// 处方明细ID
		/// </summary>
		public string ReqDtlId
		{
			get { return _reqDtlId;}
			set { _reqDtlId = value;}
		}                                    
		
		/// <summary>
		/// 退药数量
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
		/// 发药数量
		/// </summary>
		public double IssueTotality
		{
			get { return _issueTotality;}
			set { _issueTotality = value;}
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


