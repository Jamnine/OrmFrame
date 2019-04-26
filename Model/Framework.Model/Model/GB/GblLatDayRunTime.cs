

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 最后自动收费时间 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblLatDayRunTime : BaseModel
    {   
		
		
		
		private DateTime _lastTime;  //最后收费时间
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 唯一标识
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 最后收费时间
		/// </summary>
		public DateTime LastTime
		{
			get { return _lastTime;}
			set { _lastTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


