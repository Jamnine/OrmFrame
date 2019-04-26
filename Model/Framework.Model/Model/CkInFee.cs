

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检对应费用 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkInFee : BaseModel
	{   
		 
		private string _labId;  //标本ID,CkLab.Id
		
		private string _detailId;  //记帐表的费用ID
		
		private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //

                                   
		
		/// <summary>
		/// 标本ID,CkLab.Id
		/// </summary>
		public string LabId
		{
			get { return _labId;}
			set { _labId = value;}
		}                                    
		
		/// <summary>
		/// 记帐表的费用ID
		/// </summary>
		public string DetailId
		{
			get { return _detailId;}
			set { _detailId = value;}
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


