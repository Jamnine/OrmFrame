

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class InEmrFirstPageCost : BaseModel
    {   
		 
		private string _hospid;  //
		
		private string _emrFirstPageId;  //病案首页IDInEmrFirstPage.Id
		
		private string _firstPageTypeId;  //病案费用类别IDBsItemFirstPageType.Id
		
		private double _amount;  //金额
		
		private int _HospitalID;  //

        public InEmrFirstPageCost() { }
                                       
		
		/// <summary>
		/// 
		/// </summary>
		public string Hospid
		{
			get { return _hospid;}
			set { _hospid = value;}
		}                                    
		
		/// <summary>
		/// 病案首页IDInEmrFirstPage.Id
		/// </summary>
		public string EmrFirstPageId
		{
			get { return _emrFirstPageId;}
			set { _emrFirstPageId = value;}
		}                                    
		
		/// <summary>
		/// 病案费用类别IDBsItemFirstPageType.Id
		/// </summary>
		public string FirstPageTypeId
		{
			get { return _firstPageTypeId;}
			set { _firstPageTypeId = value;}
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
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


