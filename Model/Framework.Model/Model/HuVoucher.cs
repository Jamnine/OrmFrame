

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库回填发票表 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuVoucher:BaseModel
	{   
		
		
		
		private string _voucherNo;  //发票号
		
		private string _houseId;  //药库Id,BsHouse.Id
		
		private string _compId;  //医药公司ID
		
		private string _operId;  //制表人ID
		
		private DateTime _operTime;  //操作时间
		
		private string _memo;  //备注
		
		private double _amount;  //已付金额
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public HuVoucher() { }
         
		/// <summary>
		/// 发票号
		/// </summary>
		public string VoucherNo
		{
			get { return _voucherNo;}
			set { _voucherNo = value;}
		}                                    
		
		/// <summary>
		/// 药库Id,BsHouse.Id
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
		/// 制表人ID
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 已付金额
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
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


