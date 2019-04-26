

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药库调价计划 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuAdjustPlan:BaseModel
	{   
		 
		private string _billNo;  //单据号
		
		private string _houseId;  //药库ID
		
		private DateTime _notifyDate;  //通知日期
		
		private string _dispUnit;  //发文单位
		
		private DateTime _operTime;  //调价日期
		
		private string _operId;  //操作员ID
		
		private string _memo;  //调价原因
		
		private bool _isExcute;  //是否已经执行调价
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private bool _isAdjust;  //行心云:1是表示已经调价，0未调价
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 单据号
		/// </summary>
		public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 药库ID
		/// </summary>
		public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
		}                                    
		
		/// <summary>
		/// 通知日期
		/// </summary>
		public DateTime NotifyDate
		{
			get { return _notifyDate;}
			set { _notifyDate = value;}
		}                                    
		
		/// <summary>
		/// 发文单位
		/// </summary>
		public string DispUnit
		{
			get { return _dispUnit;}
			set { _dispUnit = value;}
		}                                    
		
		/// <summary>
		/// 调价日期
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 调价原因
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 是否已经执行调价
		/// </summary>
		public bool IsExcute
		{
			get { return _isExcute;}
			set { _isExcute = value;}
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
		/// 行心云:1是表示已经调价，0未调价
		/// </summary>
		public bool IsAdjust
		{
			get { return _isAdjust;}
			set { _isAdjust = value;}
		}                                    
		                                 
		        
	}  
}           


