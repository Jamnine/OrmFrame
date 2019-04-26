

using System;
namespace Orm.Model
{
	/// <summary>
	/// 最后自动收费时间 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblLatDayRunTime : BaseModel
    {    
		private DateTime _lastTime;  //最后收费时间
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 最后收费时间
		/// </summary>
		public DateTime LastTime
		{
			get { return _lastTime;}
			set { _lastTime = value;}
		}                                    
		                                   
		        
	}  
}           


