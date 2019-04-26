

using System;
namespace Orm.Model
{
	/// <summary>
	/// 项目搜索表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsitemSelect : BaseModel
	{   
		 
		private string _itemId;  //项目ID对应Bsitem.id
		
		private string _code;  //编码
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private string _strokeCode;  //助记码
		
		private bool _isActive;  //是否有效标识
		
		private string _otherCode;  //其它码
		
		private string _longDesc;  //全称
		
		private string _engDesc;  //英文名
		
		private string _spec;  //规格
		
		private string _name;  //名称
		
		private string _unitInName;  //住院单位
		
		private string _unitDiagName;  //门诊单位
		
		private int _lsGfType;  //是否公费
		
		private double _stockPriceKc;  //药库买入价
		
		private bool _isRpForbid;  //禁止临床开药
		
		private int _lsRpType;  //处方项目：1-中成药；2-西药；3-中药；4-检验；5-检查；6-手术；7-治疗；8-床位；9-其他；10-物资
		
		private string _unitKcName;  //药库单位
		
		private double _priceIn;  //住院项目单价
		
		private double _priceDiag;  //门诊价格
		
		private string _memo;  //备注
		
		private int _orderBy;  //排序
		
		private string _execLocation;  //执行科室
		
		private string _provinceCode;  //省码
		
		private string _indexs;  //搜索字段
		
		private string _basalDrugType;  //是否基药

        public BsitemSelect() { }
         
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
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
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 助记码
		/// </summary>
		public string StrokeCode
		{
			get { return _strokeCode;}
			set { _strokeCode = value;}
		}                                    
		
		/// <summary>
		/// 是否有效标识
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 其它码
		/// </summary>
		public string OtherCode
		{
			get { return _otherCode;}
			set { _otherCode = value;}
		}                                    
		
		/// <summary>
		/// 全称
		/// </summary>
		public string LongDesc
		{
			get { return _longDesc;}
			set { _longDesc = value;}
		}                                    
		
		/// <summary>
		/// 英文名
		/// </summary>
		public string EngDesc
		{
			get { return _engDesc;}
			set { _engDesc = value;}
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
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 住院单位
		/// </summary>
		public string UnitInName
		{
			get { return _unitInName;}
			set { _unitInName = value;}
		}                                    
		
		/// <summary>
		/// 门诊单位
		/// </summary>
		public string UnitDiagName
		{
			get { return _unitDiagName;}
			set { _unitDiagName = value;}
		}                                    
		
		/// <summary>
		/// 是否公费
		/// </summary>
		public int LsGfType
		{
			get { return _lsGfType;}
			set { _lsGfType = value;}
		}                                    
		
		/// <summary>
		/// 药库买入价
		/// </summary>
		public double StockPriceKc
		{
			get { return _stockPriceKc;}
			set { _stockPriceKc = value;}
		}                                    
		
		/// <summary>
		/// 禁止临床开药
		/// </summary>
		public bool IsRpForbid
		{
			get { return _isRpForbid;}
			set { _isRpForbid = value;}
		}                                    
		
		/// <summary>
		/// 处方项目：1-中成药；2-西药；3-中药；4-检验；5-检查；6-手术；7-治疗；8-床位；9-其他；10-物资
		/// </summary>
		public int LsRpType
		{
			get { return _lsRpType;}
			set { _lsRpType = value;}
		}                                    
		
		/// <summary>
		/// 药库单位
		/// </summary>
		public string UnitKcName
		{
			get { return _unitKcName;}
			set { _unitKcName = value;}
		}                                    
		
		/// <summary>
		/// 住院项目单价
		/// </summary>
		public double PriceIn
		{
			get { return _priceIn;}
			set { _priceIn = value;}
		}                                    
		
		/// <summary>
		/// 门诊价格
		/// </summary>
		public double PriceDiag
		{
			get { return _priceDiag;}
			set { _priceDiag = value;}
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
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 执行科室
		/// </summary>
		public string ExecLocation
		{
			get { return _execLocation;}
			set { _execLocation = value;}
		}                                    
		
		/// <summary>
		/// 省码
		/// </summary>
		public string ProvinceCode
		{
			get { return _provinceCode;}
			set { _provinceCode = value;}
		}                                    
		
		/// <summary>
		/// 搜索字段
		/// </summary>
		public string Indexs
		{
			get { return _indexs;}
			set { _indexs = value;}
		}                                    
		
		/// <summary>
		/// 是否基药
		/// </summary>
		public string BasalDrugType
		{
			get { return _basalDrugType;}
			set { _basalDrugType = value;}
		}                                    
		        
	}  
}           


