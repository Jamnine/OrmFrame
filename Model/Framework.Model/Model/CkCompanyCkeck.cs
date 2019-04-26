

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检单位预约时间 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkCompanyCkeck : BaseModel
	{   
		
		private string _companyId;  //体验单位,CkCompany.Id
		
		private DateTime _ckeckDate;  //预约时间
		
		private string _ckeckNo;  //单号
		
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
		/// 预约时间
		/// </summary>
		public DateTime CkeckDate
		{
			get { return _ckeckDate;}
			set { _ckeckDate = value;}
		}                                    
		
		/// <summary>
		/// 单号
		/// </summary>
		public string CkeckNo
		{
			get { return _ckeckNo;}
			set { _ckeckNo = value;}
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


