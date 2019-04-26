

using System;
namespace Orm.Model
{
	/// <summary>
	/// 电子病历模版路径 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblEMRBranch : BaseModel
    {   
		  
		private string _branchId;  //医学专业
		
		private string _catalogId;  //病案类别
		
		private string _xSDFile;  //模板名称
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 医学专业
		/// </summary>
		public string BranchId
		{
			get { return _branchId;}
			set { _branchId = value;}
		}                                    
		
		/// <summary>
		/// 病案类别
		/// </summary>
		public string CatalogId
		{
			get { return _catalogId;}
			set { _catalogId = value;}
		}                                    
		
		/// <summary>
		/// 模板名称
		/// </summary>
		public string XSDFile
		{
			get { return _xSDFile;}
			set { _xSDFile = value;}
		}                                    
		
                                   
		        
	}  
}           


