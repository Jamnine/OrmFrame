

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房领药申请明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmAppDrugDtl : BaseModel
    {   
		
		
		
		private string _billId;  //单据Id
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private double _drugNum;  //数量
		
		private string _unitId;  //单位
		
		private double _huStockNum;  //药库数量
		
		private int _unitKc;  //药库单位ID
		
		private string _pno;  //批号
		
		private DateTime _limitDate;  //过期日期
		
		private string _memo;  //备注
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
        public RmAppDrugDtl() { }

                                     
		
		/// <summary>
		/// 单据Id
		/// </summary>
		public string BillId
		{
			get { return _billId;}
			set { _billId = value;}
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
		/// 数量
		/// </summary>
		public double DrugNum
		{
			get { return _drugNum;}
			set { _drugNum = value;}
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
		/// 药库数量
		/// </summary>
		public double HuStockNum
		{
			get { return _huStockNum;}
			set { _huStockNum = value;}
		}                                    
		
		/// <summary>
		/// 药库单位ID
		/// </summary>
		public int UnitKc
		{
			get { return _unitKc;}
			set { _unitKc = value;}
		}                                    
		
		/// <summary>
		/// 批号
		/// </summary>
		public string Pno
		{
			get { return _pno;}
			set { _pno = value;}
		}                                    
		
		/// <summary>
		/// 过期日期
		/// </summary>
		public DateTime LimitDate
		{
			get { return _limitDate;}
			set { _limitDate = value;}
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
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		                                 
		        
	}  
}           


