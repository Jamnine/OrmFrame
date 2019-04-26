

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院中药处方单明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class InChinRicipeDtl:BaseModel
	{   
		 
		private string _recipeId;  //处方号
		
		private string _itemId;  //处方项目，对应Pub_Med_Item表
		
		private double _dosage;  //数量
		
		private string _unitTakeId;  //服用单位
		
		private int _lsDecoctWay;  //煎药方法：1-无；2-先煎；3-后下；4-锔服；5-另熔；6-冲服；7-另服
		
		private string _memo;  //备注
		
		private string _operId;  //录入人
		
		private DateTime _operTime;  //录入时间
		
		private string _detailId;  //记帐表的费用ID
		
		private double _price;  //单价
		
		private double _discountAoumt;  //折扣金额
		
		private double _childPrice;  //儿童价格
		
		private double _discountPrice;  //折扣价格
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InChinRicipeDtl() { }
         
		/// <summary>
		/// 处方号
		/// </summary>
		public string RecipeId
		{
			get { return _recipeId;}
			set { _recipeId = value;}
		}                                    
		
		/// <summary>
		/// 处方项目，对应Pub_Med_Item表
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 数量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 服用单位
		/// </summary>
		public string UnitTakeId
		{
			get { return _unitTakeId;}
			set { _unitTakeId = value;}
		}                                    
		
		/// <summary>
		/// 煎药方法：1-无；2-先煎；3-后下；4-锔服；5-另熔；6-冲服；7-另服
		/// </summary>
		public int LsDecoctWay
		{
			get { return _lsDecoctWay;}
			set { _lsDecoctWay = value;}
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
		/// 录入人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 录入时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 记帐表的费用ID
		/// </summary>
		public string DetailId
		{
			get { return _detailId;}
			set { _detailId = value;}
		}                                    
		
		/// <summary>
		/// 单价
		/// </summary>
		public double Price
		{
			get { return _price;}
			set { _price = value;}
		}                                    
		
		/// <summary>
		/// 折扣金额
		/// </summary>
		public double DiscountAoumt
		{
			get { return _discountAoumt;}
			set { _discountAoumt = value;}
		}                                    
		
		/// <summary>
		/// 儿童价格
		/// </summary>
		public double ChildPrice
		{
			get { return _childPrice;}
			set { _childPrice = value;}
		}                                    
		
		/// <summary>
		/// 折扣价格
		/// </summary>
		public double DiscountPrice
		{
			get { return _discountPrice;}
			set { _discountPrice = value;}
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


