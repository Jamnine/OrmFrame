

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库回填发票明细表 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuVoucherDtl:BaseModel
	{    
		private string _voucherId;  //发票号
		
		private string _billId;  //进货单据
		
		private double _amount;  //入库单金额
		
		private double _hasPay;  //已付金额
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public HuVoucherDtl() { }
                                      
		
		/// <summary>
		/// 发票号
		/// </summary>
		public string VoucherId
		{
			get { return _voucherId;}
			set { _voucherId = value;}
		}                                    
		
		/// <summary>
		/// 进货单据
		/// </summary>
		public string BillId
		{
			get { return _billId;}
			set { _billId = value;}
		}                                    
		
		/// <summary>
		/// 入库单金额
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
		}                                    
		
		/// <summary>
		/// 已付金额
		/// </summary>
		public double HasPay
		{
			get { return _hasPay;}
			set { _hasPay = value;}
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


