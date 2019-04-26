

using System;
namespace Orm.Model
{
	/// <summary>
	/// 血液类型 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkBloodType :BaseModel
	{   
		
		private string _code;  //编码
		
		private string _name;  //名称
		
		private double _priceIn;  //进价
		
		private double _priceOut;  //出价
		
		private int _limitDays;  //有效天数
		
		private string _unitId;  //单位
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private double _underLineKc;  //库存警报下限
		
		private string _groupMian;  //一级分组
		
		private string _groupSub;  //二级分组
		
		private string _processingItemId;  //加工费项目ID
		
		private string _withBloodItemId;  //配血费项目ID
		
		private string _reviewItem;  //复查费项目Id
		
		private string _storageItem;  //存储费项目ID

        private int _HospitalID;  //


        /// <summary>
        /// 编码
        /// </summary>
        public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 进价
		/// </summary>
		public double PriceIn
		{
			get { return _priceIn;}
			set { _priceIn = value;}
		}                                    
		
		/// <summary>
		/// 出价
		/// </summary>
		public double PriceOut
		{
			get { return _priceOut;}
			set { _priceOut = value;}
		}                                    
		
		/// <summary>
		/// 有效天数
		/// </summary>
		public int LimitDays
		{
			get { return _limitDays;}
			set { _limitDays = value;}
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
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 显示顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 有效标志
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
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
		/// 库存警报下限
		/// </summary>
		public double UnderLineKc
		{
			get { return _underLineKc;}
			set { _underLineKc = value;}
		}                                    
		
		/// <summary>
		/// 一级分组
		/// </summary>
		public string GroupMian
		{
			get { return _groupMian;}
			set { _groupMian = value;}
		}                                    
		
		/// <summary>
		/// 二级分组
		/// </summary>
		public string GroupSub
		{
			get { return _groupSub;}
			set { _groupSub = value;}
		}                                    
		
		/// <summary>
		/// 加工费项目ID
		/// </summary>
		public string ProcessingItemId
		{
			get { return _processingItemId;}
			set { _processingItemId = value;}
		}                                    
		
		/// <summary>
		/// 配血费项目ID
		/// </summary>
		public string WithBloodItemId
		{
			get { return _withBloodItemId;}
			set { _withBloodItemId = value;}
		}                                    
		
		/// <summary>
		/// 复查费项目Id
		/// </summary>
		public string ReviewItem
		{
			get { return _reviewItem;}
			set { _reviewItem = value;}
		}                                    
		
		/// <summary>
		/// 存储费项目ID
		/// </summary>
		public string StorageItem
		{
			get { return _storageItem;}
			set { _storageItem = value;}
		}



    }  
}           


