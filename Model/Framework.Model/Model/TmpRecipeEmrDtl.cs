

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:处方模板维护表明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class TmpRecipeEmrDtl:BaseModel
	{   
		
	 
		
		private string _name;  //项目名称
		
		private string _itemID;  //项目ID
		
		private int  _groupNum;  //组号
		
		private double _dosage;  //单次用量
		
		private string _frequencyID;  //频次
		
		private string _memo;  //备注
		
		private string _spec;  //规格
		
		private string _usageID;  //用法
		
		private string _unitTakeID;  //用量单位
		
		private string _cookType;  //煎药方式
		
		private string _tmpRecipeEmrID;  //处方模板表ID
		
		private double _priceDiag;  //单价
		
		private double _totality;  //数量
		
		private int _days;  //天数
		
		private string _unitDiagID;  //单位ID
		
		private int _HospitalID;  //
		 

	                         
		
		/// <summary>
		/// 项目名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 项目ID
		/// </summary>
		public string ItemID
		{
			get { return _itemID;}
			set { _itemID = value;}
		}                                    
		
		/// <summary>
		/// 组号
		/// </summary>
		public int  GroupNum
		{
			get { return _groupNum;}
			set { _groupNum = value;}
		}                                    
		
		/// <summary>
		/// 单次用量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 频次
		/// </summary>
		public string FrequencyID
		{
			get { return _frequencyID;}
			set { _frequencyID = value;}
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
		/// 规格
		/// </summary>
		public string Spec
		{
			get { return _spec;}
			set { _spec = value;}
		}                                    
		
		/// <summary>
		/// 用法
		/// </summary>
		public string UsageID
		{
			get { return _usageID;}
			set { _usageID = value;}
		}

        /// <summary>
        /// 用量单位
        /// </summary>
        public string UnitTakeID
		{
			get { return _unitTakeID;}
			set { _unitTakeID = value;}
		}                                    
		
		/// <summary>
		/// 煎药方式
		/// </summary>
		public string CookType
		{
			get { return _cookType;}
			set { _cookType = value;}
		}                                    
		
		/// <summary>
		/// 处方模板表ID
		/// </summary>
		public string TmpRecipeEmrID
		{
			get { return _tmpRecipeEmrID;}
			set { _tmpRecipeEmrID = value;}
		}                                    
		
		/// <summary>
		/// 单价
		/// </summary>
		public double PriceDiag
		{
			get { return _priceDiag;}
			set { _priceDiag = value;}
		}                                    
		
		/// <summary>
		/// 数量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 天数
		/// </summary>
		public int Days
		{
			get { return _days;}
			set { _days = value;}
		}                                    
		
		/// <summary>
		/// 单位ID
		/// </summary>
		public string UnitDiagID
		{
			get { return _unitDiagID;}
			set { _unitDiagID = value;}
		}                                    
		                                  
		        
	}  
}           


