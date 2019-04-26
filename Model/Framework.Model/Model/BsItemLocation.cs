

using System;
namespace Orm.Model
{
	/// <summary>
	/// 项目对应科室 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemLocation : BaseModel
    {    
		private string _locationId;  //科室
		
		private string _itemId;  //项目
		
		private string _feeHsMzId;  //门诊核算收据类别
		
		private string _feeHsZyId;  //住院核算收据类别
		
		private double _dosage;  //科室定义的用量
		
		private string _unitTake;  //科室定义的单位
		
		private string _frequencyId;  //科室定义的频率
		
		private string _usageId;  //科室定义的用法
		
		private bool _isLocDrug;  //是否科室基数药
		
		private int _orderBy;  //科室代码显示排序
		
		private int _iconIndex;  //图标类型
		
		private string _execLocId;  //执行科室
		
		private bool _isLocUse;  //禁用标识

        public BsItemLocation() { }
         
		/// <summary>
		/// 科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 门诊核算收据类别
		/// </summary>
		public string FeeHsMzId
		{
			get { return _feeHsMzId;}
			set { _feeHsMzId = value;}
		}                                    
		
		/// <summary>
		/// 住院核算收据类别
		/// </summary>
		public string FeeHsZyId
		{
			get { return _feeHsZyId;}
			set { _feeHsZyId = value;}
		}                                    
		
		/// <summary>
		/// 科室定义的用量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 科室定义的单位
		/// </summary>
		public string UnitTake
		{
			get { return _unitTake;}
			set { _unitTake = value;}
		}                                    
		
		/// <summary>
		/// 科室定义的频率
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 科室定义的用法
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 是否科室基数药
		/// </summary>
		public bool IsLocDrug
		{
			get { return _isLocDrug;}
			set { _isLocDrug = value;}
		}                                    
		
		/// <summary>
		/// 科室代码显示排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
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
		/// 执行科室
		/// </summary>
		public string ExecLocId
		{
			get { return _execLocId;}
			set { _execLocId = value;}
		}                                    
		
		/// <summary>
		/// 禁用标识
		/// </summary>
		public bool IsLocUse
		{
			get { return _isLocUse;}
			set { _isLocUse = value;}
		}                                    
		        
	}  
}           


