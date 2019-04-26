

using System;
namespace Orm.Model
{
	/// <summary>
	/// 单位体检组 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkCompanyGroup : BaseModel
	{   
		 
		private string _companyId;  //体验单位,CkCompany.Id
		
		private string _groupId;  //体验组CkGroup.Id
		
		private string _groupDepartmentId;  //部门ID
		
		private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //



		/// <summary>
		/// 体验单位,CkCompany.Id
		/// </summary>
		public string CompanyId
		{
			get { return _companyId;}
			set { _companyId = value;}
		}                                    
		
		/// <summary>
		/// 体验组CkGroup.Id
		/// </summary>
		public string GroupId
		{
			get { return _groupId;}
			set { _groupId = value;}
		}                                    
		
		/// <summary>
		/// 部门ID
		/// </summary>
		public string GroupDepartmentId
		{
			get { return _groupDepartmentId;}
			set { _groupDepartmentId = value;}
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


