

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊叫号信息 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuDiagCall : BaseModel
    {   
		 
		private string _mzRegId;  //门诊流水号
		
		private string _doctorId;  //关联到DOCTOR表
		
		private string _memo;  //备注
		
		private DateTime _operTime;  //登记时间
		
		private string _operId;  //登记人
		
		private string _patName;  //姓名
		
		private string _actType;  //叫号类别
		
		private bool _isCall;  //已叫号
		
		private string _roomNo;  //诊室号
		
		private string _callType;  //1等待就诊，2呼叫就诊，3挂起
		
		private int _callCount;  //呼叫次数
		
		private string _num;  //叫号顺序号
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 门诊流水号
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 关联到DOCTOR表
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
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
		/// 登记时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
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
		/// 姓名
		/// </summary>
		public string PatName
		{
			get { return _patName;}
			set { _patName = value;}
		}                                    
		
		/// <summary>
		/// 叫号类别
		/// </summary>
		public string ActType
		{
			get { return _actType;}
			set { _actType = value;}
		}                                    
		
		/// <summary>
		/// 已叫号
		/// </summary>
		public bool IsCall
		{
			get { return _isCall;}
			set { _isCall = value;}
		}                                    
		
		/// <summary>
		/// 诊室号
		/// </summary>
		public string RoomNo
		{
			get { return _roomNo;}
			set { _roomNo = value;}
		}                                    
		
		/// <summary>
		/// 1等待就诊，2呼叫就诊，3挂起
		/// </summary>
		public string CallType
		{
			get { return _callType;}
			set { _callType = value;}
		}                                    
		
		/// <summary>
		/// 呼叫次数
		/// </summary>
		public int CallCount
		{
			get { return _callCount;}
			set { _callCount = value;}
		}                                    
		
		/// <summary>
		/// 叫号顺序号
		/// </summary>
		public string Num
		{
			get { return _num;}
			set { _num = value;}
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


