

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检检查申请表 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkPsApply  :BaseModel
	{   
		 
		private string _applyId;  //申请单ID
		
		private string _checkId;  //体检ID,CkMain.Id
		
		private string _itemId;  //检查项目
		
		private string _checkBody;  //部位
		
		private int _xType;  //申请类别：1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA；12-普放；13-病理；14-其它
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 申请单ID
		/// </summary>
		public string ApplyId
		{
			get { return _applyId;}
			set { _applyId = value;}
		}                                    
		
		/// <summary>
		/// 体检ID,CkMain.Id
		/// </summary>
		public string CheckId
		{
			get { return _checkId;}
			set { _checkId = value;}
		}                                    
		
		/// <summary>
		/// 检查项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 部位
		/// </summary>
		public string CheckBody
		{
			get { return _checkBody;}
			set { _checkBody = value;}
		}                                    
		
		/// <summary>
		/// 申请类别：1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA；12-普放；13-病理；14-其它
		/// </summary>
		public int XType
		{
			get { return _xType;}
			set { _xType = value;}
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


