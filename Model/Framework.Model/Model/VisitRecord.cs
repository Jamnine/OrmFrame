

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class VisitRecord : BaseModel 
	{   
		private DateTime _visitTime;  //访问时间
		
		private string _operID;  //操作员ID,BsUser.Id
		
		private DateTime _operTime;  //操作时间
		
		private int _visitType;  //访问类型
		
		private string _visitContent;  //访问内容
		
		private string _patID;  //病人ID,对应BsPatient.Id
		
		private string _mzRegID;  //门诊病人ID,Ouhosinfo.Id
		
		private string _backContent;  //回访内容
		
		private int _visitStatus;  //访问状态
		
		private int _appraiseType;  //评价类型
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public VisitRecord() { }

                               
		
		/// <summary>
		/// 访问时间
		/// </summary>
		public DateTime VisitTime
		{
			get { return _visitTime;}
			set { _visitTime = value;}
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
		/// 访问类型
		/// </summary>
		public int VisitType
		{
			get { return _visitType;}
			set { _visitType = value;}
		}                                    
		
		/// <summary>
		/// 访问内容
		/// </summary>
		public string VisitContent
		{
			get { return _visitContent;}
			set { _visitContent = value;}
		}                                    
		
		/// <summary>
		/// 病人ID,对应BsPatient.Id
		/// </summary>
		public string PatID
		{
			get { return _patID;}
			set { _patID = value;}
		}                                    
		
		/// <summary>
		/// 门诊病人ID,Ouhosinfo.Id
		/// </summary>
		public string MzRegID
		{
			get { return _mzRegID;}
			set { _mzRegID = value;}
		}                                    
		
		/// <summary>
		/// 回访内容
		/// </summary>
		public string BackContent
		{
			get { return _backContent;}
			set { _backContent = value;}
		}                                    
		
		/// <summary>
		/// 访问状态
		/// </summary>
		public int VisitStatus
		{
			get { return _visitStatus;}
			set { _visitStatus = value;}
		}                                    
		
		/// <summary>
		/// 评价类型
		/// </summary>
		public int AppraiseType
		{
			get { return _appraiseType;}
			set { _appraiseType = value;}
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


