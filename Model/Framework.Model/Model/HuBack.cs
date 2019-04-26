

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库退库表 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuBack : BaseModel
    {   
		 
		private string _billNo;  //单据号
		
		private string _houseId;  //药库ID
		
		private string _compId;  //医药公司ID
		
		private DateTime _operTime;  //退货日期
		
		private string _operId;  //制表人
		
		private bool _isSign;  //是否已审核：0:未审核,1:已审核
		
		private DateTime _signTime;  //审核日期
		
		private string _signOperId;  //审核人
		
		private string _rkBillNo;  //入库单号
		
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
		/// 医药公司ID
		/// </summary>
		public string CompId
		{
			get { return _compId;}
			set { _compId = value;}
		}                                    
		
		/// <summary>
		/// 退货日期
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
		/// 入库单号
		/// </summary>
		public string RkBillNo
		{
			get { return _rkBillNo;}
			set { _rkBillNo = value;}
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


