

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DayOuRecipeWorkload : BaseModel
    {   
		 
		private DateTime _operTime;  //时间
		
		private string _locationId;  //科室
		
		private string _doctorId;  //医生
		
		private int _clincRc;  //就诊人次
		
		private int _recipeDtlShu;  //处方人次
		
		private int _lsRepType;  //处方类别，1西药，2中药，3检查检验
		
		private bool _isDoctorInPut;  //是否医生录入
		
		private bool _isBp;  //是否BP
		
		private int _ouEmrRc;  //电子病历人次
		
		private bool _isXY;  //是否含有西药
		
		private bool _iszy;  //是否含有中草药
		
		private bool _iszcy;  //是否含有中成药
		
		private bool _isylzj;  //是否含有院内制剂
		  
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 就诊人次
		/// </summary>
		public int ClincRc
		{
			get { return _clincRc;}
			set { _clincRc = value;}
		}                                    
		
		/// <summary>
		/// 处方人次
		/// </summary>
		public int RecipeDtlShu
		{
			get { return _recipeDtlShu;}
			set { _recipeDtlShu = value;}
		}                                    
		
		/// <summary>
		/// 处方类别，1西药，2中药，3检查检验
		/// </summary>
		public int LsRepType
		{
			get { return _lsRepType;}
			set { _lsRepType = value;}
		}                                    
		
		/// <summary>
		/// 是否医生录入
		/// </summary>
		public bool IsDoctorInPut
		{
			get { return _isDoctorInPut;}
			set { _isDoctorInPut = value;}
		}                                    
		
		/// <summary>
		/// 是否BP
		/// </summary>
		public bool IsBp
		{
			get { return _isBp;}
			set { _isBp = value;}
		}                                    
		
		/// <summary>
		/// 电子病历人次
		/// </summary>
		public int OuEmrRc
		{
			get { return _ouEmrRc;}
			set { _ouEmrRc = value;}
		}                                    
		
		/// <summary>
		/// 是否含有西药
		/// </summary>
		public bool IsXY
		{
			get { return _isXY;}
			set { _isXY = value;}
		}                                    
		
		/// <summary>
		/// 是否含有中草药
		/// </summary>
		public bool Iszy
		{
			get { return _iszy;}
			set { _iszy = value;}
		}                                    
		
		/// <summary>
		/// 是否含有中成药
		/// </summary>
		public bool Iszcy
		{
			get { return _iszcy;}
			set { _iszcy = value;}
		}                                    
		
		/// <summary>
		/// 是否含有院内制剂
		/// </summary>
		public bool Isylzj
		{
			get { return _isylzj;}
			set { _isylzj = value;}
		}                                    
		        
	}  
}           


