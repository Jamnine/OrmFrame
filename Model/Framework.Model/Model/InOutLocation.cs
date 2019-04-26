

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院转科记录表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InOutLocation : BaseModel
    {   
		 
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _bedId;  //床位
		
		private string _outLocId;  //转出科室
		
		private DateTime _outOperTime;  //入科时间
		
		private string _outOperId;  //安排人
		
		private bool _isReceived;  //是否已经接收
		
		private string _inLocId;  //转入科室
		
		private DateTime _inOperTime;  //安排日期
		
		private string _inOperId;  //安排人
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 床位
		/// </summary>
		public string BedId
		{
			get { return _bedId;}
			set { _bedId = value;}
		}                                    
		
		/// <summary>
		/// 转出科室
		/// </summary>
		public string OutLocId
		{
			get { return _outLocId;}
			set { _outLocId = value;}
		}                                    
		
		/// <summary>
		/// 入科时间
		/// </summary>
		public DateTime OutOperTime
		{
			get { return _outOperTime;}
			set { _outOperTime = value;}
		}                                    
		
		/// <summary>
		/// 安排人
		/// </summary>
		public string OutOperId
		{
			get { return _outOperId;}
			set { _outOperId = value;}
		}                                    
		
		/// <summary>
		/// 是否已经接收
		/// </summary>
		public bool isReceived
		{
			get { return _isReceived;}
			set { _isReceived = value;}
		}                                    
		
		/// <summary>
		/// 转入科室
		/// </summary>
		public string InLocId
		{
			get { return _inLocId;}
			set { _inLocId = value;}
		}                                    
		
		/// <summary>
		/// 安排日期
		/// </summary>
		public DateTime InOperTime
		{
			get { return _inOperTime;}
			set { _inOperTime = value;}
		}                                    
		
		/// <summary>
		/// 安排人
		/// </summary>
		public string InOperId
		{
			get { return _inOperId;}
			set { _inOperId = value;}
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


