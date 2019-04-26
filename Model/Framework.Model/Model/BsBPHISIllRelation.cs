

using System;
namespace Orm.Model
{
	/// <summary>
	/// BP的诊断跟HIS诊断的对应关系表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBPHISIllRelation:BaseModel
	{   
		 
		private string _bPIllId;  //
		
		private string _hISIllId;  //

        private int _HospitalID;//医院ID
         
		/// <summary>
		/// 
		/// </summary>
		public string BPIllId
		{
			get { return _bPIllId;}
			set { _bPIllId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string HISIllId
		{
			get { return _hISIllId;}
			set { _hISIllId = value;}
		}

   
    }  
}           


