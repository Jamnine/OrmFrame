

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 电子病历模版路径 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblEMRBranch : BaseModel
    {   
		
		
		
		private int _branchId;  //医学专业
		
		private int _catalogId;  //病案类别
		
		private string _xSDFile;  //模板名称
		
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
		/// 医学专业
		/// </summary>
		public int BranchId
		{
			get { return _branchId;}
			set { _branchId = value;}
		}                                    
		
		/// <summary>
		/// 病案类别
		/// </summary>
		public int CatalogId
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


