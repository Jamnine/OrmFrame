

using System;
namespace Orm.Model
{
	/// <summary>
	/// 记录手术病人情况 - 实体类
	/// </summary>
	[Serializable]
	public partial class InHosOps : BaseModel
    {    
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private int _opsTimes;  //顺序号
		
		private DateTime _opsTime;  //修改时间
		
		private string _opsId;  //手术码
		
		private int _lsCut;  //切口：1-I类；2-II类；3-III类；4-未知
		
		private int _lsRecove;  //愈合：1-甲；2-乙；3-丙；4-未知
		
		private string _opsDoctorId;  //手术医生
		
		private string _anaesId;  //麻醉方式
		
		private string _assistantOperId1;  //I助
		
		private string _assistantOperId2;  //II助
		
		private string _anaesDoctorId;  //麻醉医生
		
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
		/// 顺序号
		/// </summary>
		public int OpsTimes
		{
			get { return _opsTimes;}
			set { _opsTimes = value;}
		}                                    
		
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime OpsTime
		{
			get { return _opsTime;}
			set { _opsTime = value;}
		}                                    
		
		/// <summary>
		/// 手术码
		/// </summary>
		public string OpsId
		{
			get { return _opsId;}
			set { _opsId = value;}
		}                                    
		
		/// <summary>
		/// 切口：1-I类；2-II类；3-III类；4-未知
		/// </summary>
		public int LsCut
		{
			get { return _lsCut;}
			set { _lsCut = value;}
		}                                    
		
		/// <summary>
		/// 愈合：1-甲；2-乙；3-丙；4-未知
		/// </summary>
		public int LsRecove
		{
			get { return _lsRecove;}
			set { _lsRecove = value;}
		}                                    
		
		/// <summary>
		/// 手术医生
		/// </summary>
		public string OpsDoctorId
		{
			get { return _opsDoctorId;}
			set { _opsDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 麻醉方式
		/// </summary>
		public string AnaesId
		{
			get { return _anaesId;}
			set { _anaesId = value;}
		}                                    
		
		/// <summary>
		/// I助
		/// </summary>
		public string AssistantOperId1
		{
			get { return _assistantOperId1;}
			set { _assistantOperId1 = value;}
		}                                    
		
		/// <summary>
		/// II助
		/// </summary>
		public string AssistantOperId2
		{
			get { return _assistantOperId2;}
			set { _assistantOperId2 = value;}
		}                                    
		
		/// <summary>
		/// 麻醉医生
		/// </summary>
		public string AnaesDoctorId
		{
			get { return _anaesDoctorId;}
			set { _anaesDoctorId = value;}
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


