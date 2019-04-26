

using System;
namespace Orm.Model
{
	/// <summary>
	/// BP的患者分组表(二级) - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBPPatientGroup:BaseModel
	{   
		
		private string _patientGroup;  //病人分组
		
		private string _bPIllId;  //
		
		private int _orderBy;  //排序

        private int _HospitalID;//医院ID

		
		/// <summary>
		/// 病人分组
		/// </summary>
		public string PatientGroup
		{
			get { return _patientGroup;}
			set { _patientGroup = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string BPIllId
		{
			get { return _bPIllId;}
			set { _bPIllId = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}
  
    }  
}           


