

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class VipBinding:BaseModel
	{   
		
		
		
		private string _patId;  //病人id
		
		private string _vipCardId;  //会员卡id关联vipcard的id
		
		private bool _isCardHolder;  //是否持卡人
		
		private bool _isActive;  //是否可用
		
		private string _operId;  //登记人
		
		private DateTime _operTime;  //登记时间
		
		private string _modifiedOperId;  //最后修改人
		
		private DateTime _modifiedOperTime;  //最后修改时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 

	                      
		
		/// <summary>
		/// 病人id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 会员卡id关联vipcard的id
		/// </summary>
		public string VipCardId
		{
			get { return _vipCardId;}
			set { _vipCardId = value;}
		}                                    
		
		/// <summary>
		/// 是否持卡人
		/// </summary>
		public bool IsCardHolder
		{
			get { return _isCardHolder;}
			set { _isCardHolder = value;}
		}                                    
		
		/// <summary>
		/// 是否可用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 登记人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 登记时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 最后修改人
		/// </summary>
		public string ModifiedOperId
		{
			get { return _modifiedOperId;}
			set { _modifiedOperId = value;}
		}                                    
		
		/// <summary>
		/// 最后修改时间
		/// </summary>
		public DateTime ModifiedOperTime
		{
			get { return _modifiedOperTime;}
			set { _modifiedOperTime = value;}
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


