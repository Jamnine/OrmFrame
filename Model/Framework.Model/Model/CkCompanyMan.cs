

using System;
namespace Orm.Model
{
	/// <summary>
	/// 单位体检人员名单 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkCompanyMan : BaseModel
	{   
		
		
		private string _companyGroupId;  //对应表CkCompanyGroup.Id
		
		private string _patId;  //病人ID，对应于Patient的Pat_Id
		
		private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //


                                 
		
		/// <summary>
		/// 对应表CkCompanyGroup.Id
		/// </summary>
		public string CompanyGroupId
		{
			get { return _companyGroupId;}
			set { _companyGroupId = value;}
		}                                    
		
		/// <summary>
		/// 病人ID，对应于Patient的Pat_Id
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}


    }
}           


