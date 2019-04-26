

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsPatTypeYbIll:BaseModel
	{   
		 
		private string _tallyTypeId;  //记帐方式
		
		private string _patTypeId;  //病人类别
		
		private string _ybCode;  //医保码
		
		private string _ybDesc;  //疾病名
		
		private string _illIds;  //哪些疾病ID，“,”分割
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 记帐方式
		/// </summary>
		public string TallyTypeId
		{
			get { return _tallyTypeId;}
			set { _tallyTypeId = value;}
		}                                    
		
		/// <summary>
		/// 病人类别
		/// </summary>
		public string PatTypeId
		{
			get { return _patTypeId;}
			set { _patTypeId = value;}
		}                                    
		
		/// <summary>
		/// 医保码
		/// </summary>
		public string YbCode
		{
			get { return _ybCode;}
			set { _ybCode = value;}
		}                                    
		
		/// <summary>
		/// 疾病名
		/// </summary>
		public string YbDesc
		{
			get { return _ybDesc;}
			set { _ybDesc = value;}
		}                                    
		
		/// <summary>
		/// 哪些疾病ID，“,”分割
		/// </summary>
		public string IllIds
		{
			get { return _illIds;}
			set { _illIds = value;}
		}                                    
		
	                                 
		        
	}  
}           


