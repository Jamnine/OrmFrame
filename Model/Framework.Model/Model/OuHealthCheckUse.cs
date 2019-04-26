

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:病人档案?? - 实体类
	/// </summary>
	[Serializable]
	public partial class OuHealthCheckUse : BaseModel  
	{    

		private string _patId;  //
		
		private string _locationId;  //
		
		private string _mzRegId;  //
		
		private string _operid;  //
		
		private DateTime _operLastDate;  //
		
		private double _healthEvaluate;  //
		
		private string _error1;  //
		
		private string _error2;  //
		
		private string _error3;  //
		
		private bool _isHealthManage;  //
		
		private bool _isReview;  //
		
		private bool _isReferral;  //
		
		private bool _isQuitSmok;  //
		
		private bool _isQuitDrink;  //
		
		private bool _isHealthFood;  //
		
		private bool _isSports;  //
		
		private bool _isReduceWeight;  //
		
		private bool _isVaccine;  //
		
		private int _HospitalID;  //
		 
 
		/// <summary>
		/// 
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
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
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Operid
		{
			get { return _operid;}
			set { _operid = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperLastDate
		{
			get { return _operLastDate;}
			set { _operLastDate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double HealthEvaluate
		{
			get { return _healthEvaluate;}
			set { _healthEvaluate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Error1
		{
			get { return _error1;}
			set { _error1 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Error2
		{
			get { return _error2;}
			set { _error2 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Error3
		{
			get { return _error3;}
			set { _error3 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsHealthManage
		{
			get { return _isHealthManage;}
			set { _isHealthManage = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsReview
		{
			get { return _isReview;}
			set { _isReview = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsReferral
		{
			get { return _isReferral;}
			set { _isReferral = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsQuitSmok
		{
			get { return _isQuitSmok;}
			set { _isQuitSmok = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsQuitDrink
		{
			get { return _isQuitDrink;}
			set { _isQuitDrink = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsHealthFood
		{
			get { return _isHealthFood;}
			set { _isHealthFood = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsSports
		{
			get { return _isSports;}
			set { _isSports = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsReduceWeight
		{
			get { return _isReduceWeight;}
			set { _isReduceWeight = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool isVaccine
		{
			get { return _isVaccine;}
			set { _isVaccine = value;}
		}                                    
		                                  
		        
	}  
}           


