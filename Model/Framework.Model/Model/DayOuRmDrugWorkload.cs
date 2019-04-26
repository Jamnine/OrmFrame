

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DayOuRmDrugWorkload : BaseModel
    {    
		private DateTime _operTime;  //时间
		
		private string _locationId;  //科室ID
		
		private string _doctorId;  //医生Id
		
		private string _operId;  //发药人
		
		private int _recipeShu;  //处方数
		
		private double _amount;  //金额
		
		private string _roomId;  //药房ID
		
		private int _recipeDtlShu;  //明细数量
		
		private int _howMany;  //剂型
		
		private bool _isback;  //是否退药
		
		private bool _isDoctorInPut;  //是否医生录入
		  
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 科室ID
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 医生Id
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 发药人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 处方数
		/// </summary>
		public int RecipeShu
		{
			get { return _recipeShu;}
			set { _recipeShu = value;}
		}                                    
		
		/// <summary>
		/// 金额
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
		}                                    
		
		/// <summary>
		/// 药房ID
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
		}                                    
		
		/// <summary>
		/// 明细数量
		/// </summary>
		public int RecipeDtlShu
		{
			get { return _recipeDtlShu;}
			set { _recipeDtlShu = value;}
		}                                    
		
		/// <summary>
		/// 剂型
		/// </summary>
		public int HowMany
		{
			get { return _howMany;}
			set { _howMany = value;}
		}                                    
		
		/// <summary>
		/// 是否退药
		/// </summary>
		public bool Isback
		{
			get { return _isback;}
			set { _isback = value;}
		}                                    
		
		/// <summary>
		/// 是否医生录入
		/// </summary>
		public bool IsDoctorInPut
		{
			get { return _isDoctorInPut;}
			set { _isDoctorInPut = value;}
		}                                    
		        
	}  
}           


