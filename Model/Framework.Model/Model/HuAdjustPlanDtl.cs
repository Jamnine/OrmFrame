

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药库调价计划明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuAdjustPlanDtl:BaseModel
	{    
		private string _billId;  //单据号
		
		private string _itemId;  //项目ID
		
		private double _newPrice;  //门诊新价格
		
		private double _oldPrice;  //旧价格
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 

		                          
		
		/// <summary>
		/// 单据号
		/// </summary>
		public string BillId
		{
			get { return _billId;}
			set { _billId = value;}
		}                                    
		
		/// <summary>
		/// 项目ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 门诊新价格
		/// </summary>
		public double NewPrice
		{
			get { return _newPrice;}
			set { _newPrice = value;}
		}                                    
		
		/// <summary>
		/// 旧价格
		/// </summary>
		public double OldPrice
		{
			get { return _oldPrice;}
			set { _oldPrice = value;}
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


