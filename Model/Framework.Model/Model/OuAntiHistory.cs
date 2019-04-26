

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:预防接种史 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuAntiHistory : BaseModel
    {    
		private string _healthcheckuseid;  //省ID
		
		private string _name;  //名称
		
		private DateTime _antihistorydate;  //时间
		
		private string _locationId;  //机构
		
		private int _HospitalID;  //
		 
                                   
		
		/// <summary>
		/// 省ID
		/// </summary>
		public string Healthcheckuseid
		{
			get { return _healthcheckuseid;}
			set { _healthcheckuseid = value;}
		}                                    
		
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime Antihistorydate
		{
			get { return _antihistorydate;}
			set { _antihistorydate = value;}
		}                                    
		
		/// <summary>
		/// 机构
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		                                 
		        
	}  
}           


