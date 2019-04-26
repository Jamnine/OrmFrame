

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库报损表 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuLose : BaseModel
    {    
		private string _billNo;  //单据号
		
		private string _houseId;  //药库ID
		
		private DateTime _operTime;  //报损日期
		
		private string _operId;  //制表人
		
		private string _memo;  //报损原因
		
		private bool _isSign;  //是否已审核：0:未审核,1:已审核
		
		private DateTime _signTime;  //审核日期
		
		private string _signOperId;  //审核人
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _pageNumber;  //行心云:F1单据页数
		
		private int _HospitalID;  //
		 
                                      
		
		/// <summary>
		/// 单据号
		/// </summary>
		public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 药库ID
		/// </summary>
		public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
		}                                    
		
		/// <summary>
		/// 报损日期
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 制表人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 报损原因
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 是否已审核：0:未审核,1:已审核
		/// </summary>
		public bool IsSign
		{
			get { return _isSign;}
			set { _isSign = value;}
		}                                    
		
		/// <summary>
		/// 审核日期
		/// </summary>
		public DateTime SignTime
		{
			get { return _signTime;}
			set { _signTime = value;}
		}                                    
		
		/// <summary>
		/// 审核人
		/// </summary>
		public string SignOperId
		{
			get { return _signOperId;}
			set { _signOperId = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 行心云:F1单据页数
		/// </summary>
		public int PageNumber
		{
			get { return _pageNumber;}
			set { _pageNumber = value;}
		}                                    
		
                                  
		        
	}  
}           


