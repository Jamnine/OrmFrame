

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:生命指标记录表 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuVitalSigns : BaseModel
	{   
		
		
		private string _patId;  //客人ID
		
		private string _mzRegId;  //门诊ID
		
		private double _temperature;  //
		
		private int _pulse;  //脉搏
		
		private int _systolic;  //收缩压
		
		private int _diastolic;  //舒张压
		
		private double _bloodGlucose;  //血糖
		
		private double _height;  //身高
		
		private double _weight;  //体重
		
		private string _comments;  //其他异常生化指标
		
		private string _operId;  //登记人
		
		private DateTime _operTime;  //登记时间
		
		private string _modifiedOperId;  //修改人
		
		private DateTime _modifiedTime;  //修改时间
		
		private int _HospitalID;  //
		 

                                    
		
		/// <summary>
		/// 客人ID
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 门诊ID
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double Temperature
		{
			get { return _temperature;}
			set { _temperature = value;}
		}                                    
		
		/// <summary>
		/// 脉搏
		/// </summary>
		public int Pulse
		{
			get { return _pulse;}
			set { _pulse = value;}
		}                                    
		
		/// <summary>
		/// 收缩压
		/// </summary>
		public int Systolic
		{
			get { return _systolic;}
			set { _systolic = value;}
		}                                    
		
		/// <summary>
		/// 舒张压
		/// </summary>
		public int Diastolic
		{
			get { return _diastolic;}
			set { _diastolic = value;}
		}                                    
		
		/// <summary>
		/// 血糖
		/// </summary>
		public double BloodGlucose
		{
			get { return _bloodGlucose;}
			set { _bloodGlucose = value;}
		}                                    
		
		/// <summary>
		/// 身高
		/// </summary>
		public double Height
		{
			get { return _height;}
			set { _height = value;}
		}                                    
		
		/// <summary>
		/// 体重
		/// </summary>
		public double Weight
		{
			get { return _weight;}
			set { _weight = value;}
		}                                    
		
		/// <summary>
		/// 其他异常生化指标
		/// </summary>
		public string Comments
		{
			get { return _comments;}
			set { _comments = value;}
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
		/// 修改人
		/// </summary>
		public string ModifiedOperId
		{
			get { return _modifiedOperId;}
			set { _modifiedOperId = value;}
		}                                    
		
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime ModifiedTime
		{
			get { return _modifiedTime;}
			set { _modifiedTime = value;}
		}                                    
		

        public double BMI { get; set; }
    }  
}           


