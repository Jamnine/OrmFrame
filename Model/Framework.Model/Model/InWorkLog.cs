

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院工作日志表(病区日志) - 实体类
	/// </summary>
	[Serializable]
	public partial class InWorkLog : BaseModel
    {    
		private string _locationId;  //申请科室Req_Loc
		
		private double _bedSum;  //床位数
		
		private int _overBedSum;  //期末床位数
		
		private string _standard;  //统标
		
		private DateTime _operTime;  //登记日期时间
		
		private string _operId;  //申请人
		
		private int _lastNum;  //原人数
		
		private int _startNum;  //期初人数
		
		private int _inHospital;  //入院人数
		
		private int _inLocation;  //他科转入
		
		private int _outLocation;  //转往他科
		
		private int _outHospital;  //出院人数
		
		private int _dead;  //死亡人数
		
		private int _nowNum;  //现有人数
		
		private int _overNum;  //期末人数
		
		private int _companyNum;  //陪人数
		
		private string _memo;  //备注
		
		private int _days;  //住院总天数
		
		private int _danger;  //病危人次
		
		private int _heavy;  //病重人次
		
		private int _acute;  //病急人次
		
		private int _second;  //二级护理
		
		private int _ops;  //手术人次
		
		private int _childBirth;  //分娩
		
		private int _firstNurse;  //一级护理
		
		private int _third;  //三级护理
		
		private int _diff;  //差异
		
		private int _other;  //其它人数
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 申请科室Req_Loc
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 床位数
		/// </summary>
		public double BedSum
		{
			get { return _bedSum;}
			set { _bedSum = value;}
		}                                    
		
		/// <summary>
		/// 期末床位数
		/// </summary>
		public int OverBedSum
		{
			get { return _overBedSum;}
			set { _overBedSum = value;}
		}                                    
		
		/// <summary>
		/// 统标
		/// </summary>
		public string Standard
		{
			get { return _standard;}
			set { _standard = value;}
		}                                    
		
		/// <summary>
		/// 登记日期时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 申请人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 原人数
		/// </summary>
		public int LastNum
		{
			get { return _lastNum;}
			set { _lastNum = value;}
		}                                    
		
		/// <summary>
		/// 期初人数
		/// </summary>
		public int StartNum
		{
			get { return _startNum;}
			set { _startNum = value;}
		}                                    
		
		/// <summary>
		/// 入院人数
		/// </summary>
		public int InHospital
		{
			get { return _inHospital;}
			set { _inHospital = value;}
		}                                    
		
		/// <summary>
		/// 他科转入
		/// </summary>
		public int InLocation
		{
			get { return _inLocation;}
			set { _inLocation = value;}
		}                                    
		
		/// <summary>
		/// 转往他科
		/// </summary>
		public int OutLocation
		{
			get { return _outLocation;}
			set { _outLocation = value;}
		}                                    
		
		/// <summary>
		/// 出院人数
		/// </summary>
		public int OutHospital
		{
			get { return _outHospital;}
			set { _outHospital = value;}
		}                                    
		
		/// <summary>
		/// 死亡人数
		/// </summary>
		public int Dead
		{
			get { return _dead;}
			set { _dead = value;}
		}                                    
		
		/// <summary>
		/// 现有人数
		/// </summary>
		public int NowNum
		{
			get { return _nowNum;}
			set { _nowNum = value;}
		}                                    
		
		/// <summary>
		/// 期末人数
		/// </summary>
		public int OverNum
		{
			get { return _overNum;}
			set { _overNum = value;}
		}                                    
		
		/// <summary>
		/// 陪人数
		/// </summary>
		public int CompanyNum
		{
			get { return _companyNum;}
			set { _companyNum = value;}
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
		/// 住院总天数
		/// </summary>
		public int Days
		{
			get { return _days;}
			set { _days = value;}
		}                                    
		
		/// <summary>
		/// 病危人次
		/// </summary>
		public int Danger
		{
			get { return _danger;}
			set { _danger = value;}
		}                                    
		
		/// <summary>
		/// 病重人次
		/// </summary>
		public int Heavy
		{
			get { return _heavy;}
			set { _heavy = value;}
		}                                    
		
		/// <summary>
		/// 病急人次
		/// </summary>
		public int Acute
		{
			get { return _acute;}
			set { _acute = value;}
		}                                    
		
		/// <summary>
		/// 二级护理
		/// </summary>
		public int Second
		{
			get { return _second;}
			set { _second = value;}
		}                                    
		
		/// <summary>
		/// 手术人次
		/// </summary>
		public int Ops
		{
			get { return _ops;}
			set { _ops = value;}
		}                                    
		
		/// <summary>
		/// 分娩
		/// </summary>
		public int ChildBirth
		{
			get { return _childBirth;}
			set { _childBirth = value;}
		}                                    
		
		/// <summary>
		/// 一级护理
		/// </summary>
		public int FirstNurse
		{
			get { return _firstNurse;}
			set { _firstNurse = value;}
		}                                    
		
		/// <summary>
		/// 三级护理
		/// </summary>
		public int Third
		{
			get { return _third;}
			set { _third = value;}
		}                                    
		
		/// <summary>
		/// 差异
		/// </summary>
		public int Diff
		{
			get { return _diff;}
			set { _diff = value;}
		}                                    
		
		/// <summary>
		/// 其它人数
		/// </summary>
		public int Other
		{
			get { return _other;}
			set { _other = value;}
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


