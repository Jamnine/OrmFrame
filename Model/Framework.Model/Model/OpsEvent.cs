

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class OpsEvent : BaseModel
    {    
		private string _applyId;  //申请IdOpsApply.Id
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private double _dosage;  //每次服用量
		
		private string _unitTakeId;  //服用单位
		
		private DateTime _eventTime;  //活动时间
		
		private string _memo;  //备注
		
		private string _operID;  //操作员ID,BsUser.Id
		
		private DateTime _operTime;  //操作时间
		
		private string _usageId;  //用法对应BsUsage.Id
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 申请IdOpsApply.Id
		/// </summary>
		public string ApplyId
		{
			get { return _applyId;}
			set { _applyId = value;}
		}                                    
		
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 每次服用量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 服用单位
		/// </summary>
		public string UnitTakeId
		{
			get { return _unitTakeId;}
			set { _unitTakeId = value;}
		}                                    
		
		/// <summary>
		/// 活动时间
		/// </summary>
		public DateTime EventTime
		{
			get { return _eventTime;}
			set { _eventTime = value;}
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
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
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
		/// 用法对应BsUsage.Id
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
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


