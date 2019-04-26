

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class VipCardDiscount:BaseModel
	{   
		
		
		
		private string _vipCardID;  //会员卡Id,VipCard.id
		
		private string _feeID;  //门诊基础收费分类BsMzFeety的ID
		
		private double _discount;  //折扣
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 

		
		                     
		
		/// <summary>
		/// 会员卡Id,VipCard.id
		/// </summary>
		public string VipCardID
		{
			get { return _vipCardID;}
			set { _vipCardID = value;}
		}                                    
		
		/// <summary>
		/// 门诊基础收费分类BsMzFeety的ID
		/// </summary>
		public string FeeID
		{
			get { return _feeID;}
			set { _feeID = value;}
		}                                    
		
		/// <summary>
		/// 折扣
		/// </summary>
		public double Discount
		{
			get { return _discount;}
			set { _discount = value;}
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


