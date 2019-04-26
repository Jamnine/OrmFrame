

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院功能科室领药明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class InRmKsDtl : BaseModel
    {   
		 
		private string _detailId;  //记帐表的费用ID
		
		private string _billId;  //单据Id
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 记帐表的费用ID
		/// </summary>
		public string DetailId
		{
			get { return _detailId;}
			set { _detailId = value;}
		}                                    
		
		/// <summary>
		/// 单据Id
		/// </summary>
		public string BillId
		{
			get { return _billId;}
			set { _billId = value;}
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


