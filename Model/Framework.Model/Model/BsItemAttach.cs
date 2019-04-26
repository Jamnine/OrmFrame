

using System;
namespace Orm.Model
{
	/// <summary>
	/// 控制面版套餐 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemAttach : BaseModel
    {   
		 
		private string _itemId1;  //项目1
		
		private string _itemId2;  //项目2
		
		private int _iconIndex;  //图标类型
		
		private double _totality;  //一个主项目需要多少个附加项目？
		
		private int _lsUseArea;  //特定用途：1-门诊；2-住院；3-所有
		
		private string _locationId;  //专用科室
		
		private double _amount;  //金额，明细单价*数量
		
		private int _lsChageType;  //1.一天收一次,2.一次申请收一次,3.第2次开始收一次
		
		private string _itemId3;  //如果>0则按3id收
		
		private double _discountAoumt;  //折扣金额
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 项目1
		/// </summary>
		public string ItemId1
		{
			get { return _itemId1;}
			set { _itemId1 = value;}
		}                                    
		
		/// <summary>
		/// 项目2
		/// </summary>
		public string ItemId2
		{
			get { return _itemId2;}
			set { _itemId2 = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 一个主项目需要多少个附加项目？
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 特定用途：1-门诊；2-住院；3-所有
		/// </summary>
		public int LsUseArea
		{
			get { return _lsUseArea;}
			set { _lsUseArea = value;}
		}                                    
		
		/// <summary>
		/// 专用科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 金额，明细单价*数量
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
		}                                    
		
		/// <summary>
		/// 1.一天收一次,2.一次申请收一次,3.第2次开始收一次
		/// </summary>
		public int LsChageType
		{
			get { return _lsChageType;}
			set { _lsChageType = value;}
		}                                    
		
		/// <summary>
		/// 如果>0则按3id收
		/// </summary>
		public string ItemId3
		{
			get { return _itemId3;}
			set { _itemId3 = value;}
		}                                    
		
		/// <summary>
		/// 折扣金额
		/// </summary>
		public double DiscountAoumt
		{
			get { return _discountAoumt;}
			set { _discountAoumt = value;}
		}                                    
		                                  
		        
	}  
}           


