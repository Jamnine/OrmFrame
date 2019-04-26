

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgRoad : BaseModel
    {    
		private string _code;  //
		
		private string _name;  //
		
		private int _lsOpenType;  //
		
		private string _operId;  //
		
		private DateTime _operTime;  //
		
		private string _locationId;  //
		
		private bool _isBaby;  //
		
		private bool _isWomen;  //
		
		private bool _ismen;  //
		
		private bool _isOlder;  //
		
		private string _memo;  //
		
		private bool _isActive;  //
		
		private string _zdyj;  //诊断依据
		
		private string _zlfa;  //治疗方案
		
		private string _jrljbz;  //进入路径标准
		
		private string _zyzhxgc;  //中医证候学观察
		
		private string _ryjcxm;  //入院检查项目
		
		private string _zlff;  //治疗方法
		
		private string _cybz;  //出院标准
		
		private string _bzzyr;  //标准住院日
		
		private int _bzljrbegin;  //标准路径日住院天数的范围1
		
		private int _bzljrend;  //标准路径日住院天数的范围2
		  
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int LsOpenType
		{
			get { return _lsOpenType;}
			set { _lsOpenType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsBaby
		{
			get { return _isBaby;}
			set { _isBaby = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsWomen
		{
			get { return _isWomen;}
			set { _isWomen = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool Ismen
		{
			get { return _ismen;}
			set { _ismen = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsOlder
		{
			get { return _isOlder;}
			set { _isOlder = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 诊断依据
		/// </summary>
		public string Zdyj
		{
			get { return _zdyj;}
			set { _zdyj = value;}
		}                                    
		
		/// <summary>
		/// 治疗方案
		/// </summary>
		public string Zlfa
		{
			get { return _zlfa;}
			set { _zlfa = value;}
		}                                    
		
		/// <summary>
		/// 进入路径标准
		/// </summary>
		public string Jrljbz
		{
			get { return _jrljbz;}
			set { _jrljbz = value;}
		}                                    
		
		/// <summary>
		/// 中医证候学观察
		/// </summary>
		public string Zyzhxgc
		{
			get { return _zyzhxgc;}
			set { _zyzhxgc = value;}
		}                                    
		
		/// <summary>
		/// 入院检查项目
		/// </summary>
		public string Ryjcxm
		{
			get { return _ryjcxm;}
			set { _ryjcxm = value;}
		}                                    
		
		/// <summary>
		/// 治疗方法
		/// </summary>
		public string Zlff
		{
			get { return _zlff;}
			set { _zlff = value;}
		}                                    
		
		/// <summary>
		/// 出院标准
		/// </summary>
		public string Cybz
		{
			get { return _cybz;}
			set { _cybz = value;}
		}                                    
		
		/// <summary>
		/// 标准住院日
		/// </summary>
		public string Bzzyr
		{
			get { return _bzzyr;}
			set { _bzzyr = value;}
		}                                    
		
		/// <summary>
		/// 标准路径日住院天数的范围1
		/// </summary>
		public int Bzljrbegin
		{
			get { return _bzljrbegin;}
			set { _bzljrbegin = value;}
		}                                    
		
		/// <summary>
		/// 标准路径日住院天数的范围2
		/// </summary>
		public int Bzljrend
		{
			get { return _bzljrend;}
			set { _bzljrend = value;}
		}                                    
		        
	}  
}           


