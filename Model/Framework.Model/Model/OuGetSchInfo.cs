

using System;
namespace Orm.Model
{
	/// <summary>
	/// 挂号信息用于微信接口 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuGetSchInfo : BaseModel  
	{   
		
		private string _doctorid;  //医生Id,BsDoctor.Id
		
		private string _locationid;  //科室ID,BsLocation.Id
		
		private string _shiftId;  //
		
		private int _shiftType;  //
		
		private DateTime _schDate;  //
		
		private string _schRegTypeId;  //
		
		private double _schFee;  //
		
		private double _schRegfee;  //
		
		private double _schTreatfee;  //
		
		private string _schBegintime;  //
		
		private string _schEndtime;  //
		
		private int _schRegMax;  //
		
		private int _schRegCount;  //
		
		private int _schLimited;  //
		
		private int _schSegmented;  //
		
		private int _iscancel;  //是否作废
		
		private string _diagRoom;  //
		
		private string _specialtyRoom;  //
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 医生Id,BsDoctor.Id
		/// </summary>
		public string Doctorid
		{
			get { return _doctorid;}
			set { _doctorid = value;}
		}                                    
		
		/// <summary>
		/// 科室ID,BsLocation.Id
		/// </summary>
		public string Locationid
		{
			get { return _locationid;}
			set { _locationid = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ShiftId
		{
			get { return _shiftId;}
			set { _shiftId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int ShiftType
		{
			get { return _shiftType;}
			set { _shiftType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime SchDate
		{
			get { return _schDate;}
			set { _schDate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string SchRegTypeId
		{
			get { return _schRegTypeId;}
			set { _schRegTypeId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SchFee
		{
			get { return _schFee;}
			set { _schFee = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SchRegfee
		{
			get { return _schRegfee;}
			set { _schRegfee = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double SchTreatfee
		{
			get { return _schTreatfee;}
			set { _schTreatfee = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string SchBegintime
		{
			get { return _schBegintime;}
			set { _schBegintime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string SchEndtime
		{
			get { return _schEndtime;}
			set { _schEndtime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int SchRegMax
		{
			get { return _schRegMax;}
			set { _schRegMax = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int SchRegCount
		{
			get { return _schRegCount;}
			set { _schRegCount = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int SchLimited
		{
			get { return _schLimited;}
			set { _schLimited = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int schSegmented
		{
			get { return _schSegmented;}
			set { _schSegmented = value;}
		}                                    
		
		/// <summary>
		/// 是否作废
		/// </summary>
		public int Iscancel
		{
			get { return _iscancel;}
			set { _iscancel = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DiagRoom
		{
			get { return _diagRoom;}
			set { _diagRoom = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string SpecialtyRoom
		{
			get { return _specialtyRoom;}
			set { _specialtyRoom = value;}
		}                                    
		                                
		        
	}  
}           


