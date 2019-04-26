

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房调拨单明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmMoveDtl : BaseModel
	{    
		private string _billId;  //单据Id
		
		private string _inBatchId;  //药房库存表Id，RmStores.id
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private string _unitId;  //单位
		
		private double _drugNum;  //数量
		
		private double _retailPrice;  //零售价
		
		private double _stockPrice;  //药库买入价
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public RmMoveDtl() { }

                            
		
		/// <summary>
		/// 单据Id
		/// </summary>
		public string BillId
		{
			get { return _billId;}
			set { _billId = value;}
		}                                    
		
		/// <summary>
		/// 药房库存表Id，RmStores.id
		/// </summary>
		public string InBatchId
		{
			get { return _inBatchId;}
			set { _inBatchId = value;}
		}                                    
		
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 数量
		/// </summary>
		public double DrugNum
		{
			get { return _drugNum;}
			set { _drugNum = value;}
		}                                    
		
		/// <summary>
		/// 零售价
		/// </summary>
		public double RetailPrice
		{
			get { return _retailPrice;}
			set { _retailPrice = value;}
		}                                    
		
		/// <summary>
		/// 药库买入价
		/// </summary>
		public double StockPrice
		{
			get { return _stockPrice;}
			set { _stockPrice = value;}
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
		/// 医院ID
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


