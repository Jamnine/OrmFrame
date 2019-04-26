

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院透支表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InArrearAmount:BaseModel
	{   
		 
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private double _arrearAmount;  //透支上限
		
		private string _authMan;  //批准人
		
		private string _memo;  //备注
		
		private DateTime _operTime;  //交款时间
		
		private string _operID;  //操作员
		
		private DateTime _expireDate;  //透支有效日期
		
		private int _expireHours;  //透支有效时长
		
		private bool _isMax;  //透支额不限制
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InArrearAmount() { }
         
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 透支上限
		/// </summary>
		public double ArrearAmount
		{
			get { return _arrearAmount;}
			set { _arrearAmount = value;}
		}                                    
		
		/// <summary>
		/// 批准人
		/// </summary>
		public string AuthMan
		{
			get { return _authMan;}
			set { _authMan = value;}
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
		/// 交款时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 操作员
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 透支有效日期
		/// </summary>
		public DateTime ExpireDate
		{
			get { return _expireDate;}
			set { _expireDate = value;}
		}                                    
		
		/// <summary>
		/// 透支有效时长
		/// </summary>
		public int ExpireHours
		{
			get { return _expireHours;}
			set { _expireHours = value;}
		}                                    
		
		/// <summary>
		/// 透支额不限制
		/// </summary>
		public bool IsMax
		{
			get { return _isMax;}
			set { _isMax = value;}
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


