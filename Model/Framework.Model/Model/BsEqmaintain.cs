

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsEqmaintain : BaseModel
    {   
		
		
		private string _equipmentId;  //
		
		private string _companyId;  //
		
		private DateTime _maintainTime;  //
		
		private string _memo;  //
		
		private string _maintainOperId;  //
		
		private string _operId;  //
		
		private DateTime _operTime;  //
		
		private int _sum;  //

        private int _HospitalID;  //



		
		/// <summary>
		/// 
		/// </summary>
		public string EquipmentId
		{
			get { return _equipmentId;}
			set { _equipmentId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string CompanyId
		{
			get { return _companyId;}
			set { _companyId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime MaintainTime
		{
			get { return _maintainTime;}
			set { _maintainTime = value;}
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
		public string MaintainOperId
		{
			get { return _maintainOperId;}
			set { _maintainOperId = value;}
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
		public int Sum
		{
			get { return _sum;}
			set { _sum = value;}
		}



    }  
}           


