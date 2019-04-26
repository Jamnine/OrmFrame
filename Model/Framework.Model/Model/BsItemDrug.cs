

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药品项目辅助表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemDrug :BaseModel
    {   
		 
		private string _itemId;  //项目内码
		
		private string _chemName;  //化学名
		
		private bool _isRecipe;  //科室用药
		
		private bool _isPoison;  //毒麻药品
		
		private bool _isMental;  //精神药品
		
		private bool _isExpen;  //贵重药品
		
		private bool _isSelf;  //院内制剂
		
		private int _proAreaId;  //产地
		
		private int _aheadAlert;  //失效期提前提示的天数
		
		private double _underLineKc;  //库存警报下限
		
		private double _uperLineKc;  //库存警报上限
		
		private double _normalLineKc;  //采购维持库存量
		
		private string _formId;  //剂型
		
		private string _manuId;  //生产商
		
		private string _passNo;  //批准文号
		
		private string _areaKc;  //药库放置位置
		
		private int _lsImport;  //药品来源：1-进口药；2-合资药；3-国产药
		
		private bool _isInject;  //是否注射剂
		
		private bool _isSpecial;  //特殊管理标志
		
		private string _houseId;  //默认药库编号（参照PUB_HOUSE）
		
		private string _roomIdOut;  //默认药房编号（参照PUB_ROOM）
		
		private string _roomIdIn;  //住院药房
		
		private string _unitKc;  //药库单位
		
		private double _retailPriceKc;  //零售价格
		
		private double _stockPriceKc;  //买入价
		
		private bool _isBid;  //招标药品
		
		private bool _isLocDrug;  //科室基数药
		
		private string _compId;  //采购公司
		
		private bool _isBatch;  //处方药
		
		private bool _isSave;  //是否节省用药
		
		private int _iconIndex;  //图标类型
		
		private string _drugID;  //药典ID
		
		private string _buyInCode;  //暂无用
		
		private bool _isSecMental;  //二类精神药
		
		private bool _isSkin;  //是否皮试
		
		private bool _isAntiBacterial;  //是否抗菌药
		
		private bool _isHighDanger;  //高危药品
		
		private bool _isDanger;  //危险品
		
		private bool _isVaccine;  //是否疫苗
		
		private bool _isTestReport;  //检验报告
		
		private bool _isAnaes;  //是否麻醉药
		
		private bool _isMeetingUse;  //
		
		private string _regNo;  //
		
		private string _impotTestBy;  //
		
		private string _testReportNo;  //
		
		private bool _isParity;  //是否平价药
		
		private string _dDDMinValue;  //DDD最小值
		
		private string _dDDValue;  //DDD值
		
		private string _drugsTypes;  //
		
		private bool _notXZjDrug;  //非限制级药品
		
		private bool _xZjDrug;  //限制级药品
		
		private bool _tSjDrug;  //特制级药品
		
		private bool _isAz;  //是否爱滋药
		
		private bool _isJH;  //是否结核药
		
		private string _vaccine;  //疫苗批文ID
		
		private string _bwCode;  //药品本位码，医保码
		
		private int _HospitalID;  //

        private string _tallyGroupId;

        private bool _isYblimit;

        public BsItemDrug() { }
         
		/// <summary>
		/// 项目内码
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 化学名
		/// </summary>
		public string ChemName
		{
			get { return _chemName;}
			set { _chemName = value;}
		}                                    
		
		/// <summary>
		/// 科室用药
		/// </summary>
		public bool IsRecipe
		{
			get { return _isRecipe;}
			set { _isRecipe = value;}
		}                                    
		
		/// <summary>
		/// 毒麻药品
		/// </summary>
		public bool IsPoison
		{
			get { return _isPoison;}
			set { _isPoison = value;}
		}                                    
		
		/// <summary>
		/// 精神药品
		/// </summary>
		public bool IsMental
		{
			get { return _isMental;}
			set { _isMental = value;}
		}                                    
		
		/// <summary>
		/// 贵重药品
		/// </summary>
		public bool IsExpen
		{
			get { return _isExpen;}
			set { _isExpen = value;}
		}                                    
		
		/// <summary>
		/// 院内制剂
		/// </summary>
		public bool IsSelf
		{
			get { return _isSelf;}
			set { _isSelf = value;}
		}                                    
		
		/// <summary>
		/// 产地
		/// </summary>
		public int ProAreaId
		{
			get { return _proAreaId;}
			set { _proAreaId = value;}
		}                                    
		
		/// <summary>
		/// 失效期提前提示的天数
		/// </summary>
		public int AheadAlert
		{
			get { return _aheadAlert;}
			set { _aheadAlert = value;}
		}

        /// <summary>
        /// 库存警报下限 UnderlineKc
        /// </summary>
        public double UnderLineKc
		{
			get { return _underLineKc;}
			set { _underLineKc = value;}
		}

        /// <summary>
        /// 库存警报上限 UperLineKc UperlineKc
        /// </summary>
        public double UperLineKc
		{
			get { return _uperLineKc;}
			set { _uperLineKc = value;}
		}                                    
		
		/// <summary>
		/// 采购维持库存量
		/// </summary>
		public double NormalLineKc
		{
			get { return _normalLineKc;}
			set { _normalLineKc = value;}
		}                                    
		
		/// <summary>
		/// 剂型
		/// </summary>
		public string FormId
		{
			get { return _formId;}
			set { _formId = value;}
		}                                    
		
		/// <summary>
		/// 生产商
		/// </summary>
		public string ManuId
		{
			get { return _manuId;}
			set { _manuId = value;}
		}                                    
		
		/// <summary>
		/// 批准文号
		/// </summary>
		public string PassNo
		{
			get { return _passNo;}
			set { _passNo = value;}
		}                                    
		
		/// <summary>
		/// 药库放置位置
		/// </summary>
		public string AreaKc
		{
			get { return _areaKc;}
			set { _areaKc = value;}
		}                                    
		
		/// <summary>
		/// 药品来源：1-进口药；2-合资药；3-国产药
		/// </summary>
		public int LsImport
		{
			get { return _lsImport;}
			set { _lsImport = value;}
		}                                    
		
		/// <summary>
		/// 是否注射剂
		/// </summary>
		public bool IsInject
		{
			get { return _isInject;}
			set { _isInject = value;}
		}                                    
		
		/// <summary>
		/// 特殊管理标志
		/// </summary>
		public bool IsSpecial
		{
			get { return _isSpecial;}
			set { _isSpecial = value;}
		}                                    
		
		/// <summary>
		/// 默认药库编号（参照PUB_HOUSE）
		/// </summary>
		public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
		}                                    
		
		/// <summary>
		/// 默认药房编号（参照PUB_ROOM）
		/// </summary>
		public string RoomIdOut
		{
			get { return _roomIdOut;}
			set { _roomIdOut = value;}
		}                                    
		
		/// <summary>
		/// 住院药房
		/// </summary>
		public string RoomIdIn
		{
			get { return _roomIdIn;}
			set { _roomIdIn = value;}
		}                                    
		
		/// <summary>
		/// 药库单位
		/// </summary>
		public string UnitKc
		{
			get { return _unitKc;}
			set { _unitKc = value;}
		}                                    
		
		/// <summary>
		/// 零售价格
		/// </summary>
		public double RetailPriceKc
		{
			get { return _retailPriceKc;}
			set { _retailPriceKc = value;}
		}                                    
		
		/// <summary>
		/// 买入价
		/// </summary>
		public double StockPriceKc
		{
			get { return _stockPriceKc;}
			set { _stockPriceKc = value;}
		}                                    
		
		/// <summary>
		/// 招标药品
		/// </summary>
		public bool IsBid
		{
			get { return _isBid;}
			set { _isBid = value;}
		}                                    
		
		/// <summary>
		/// 科室基数药
		/// </summary>
		public bool IsLocDrug
		{
			get { return _isLocDrug;}
			set { _isLocDrug = value;}
		}                                    
		
		/// <summary>
		/// 采购公司
		/// </summary>
		public string CompId
		{
			get { return _compId;}
			set { _compId = value;}
		}                                    
		
		/// <summary>
		/// 处方药
		/// </summary>
		public bool IsBatch
		{
			get { return _isBatch;}
			set { _isBatch = value;}
		}                                    
		
		/// <summary>
		/// 是否节省用药
		/// </summary>
		public bool IsSave
		{
			get { return _isSave;}
			set { _isSave = value;}
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
		/// 药典ID
		/// </summary>
		public string DrugID
		{
			get { return _drugID;}
			set { _drugID = value;}
		}                                    
		
		/// <summary>
		/// 暂无用
		/// </summary>
		public string BuyInCode
		{
			get { return _buyInCode;}
			set { _buyInCode = value;}
		}                                    
		
		/// <summary>
		/// 二类精神药
		/// </summary>
		public bool IsSecMental
		{
			get { return _isSecMental;}
			set { _isSecMental = value;}
		}                                    
		
		/// <summary>
		/// 是否皮试
		/// </summary>
		public bool IsSkin
		{
			get { return _isSkin;}
			set { _isSkin = value;}
		}                                    
		
		/// <summary>
		/// 是否抗菌药
		/// </summary>
		public bool IsAntiBacterial
		{
			get { return _isAntiBacterial;}
			set { _isAntiBacterial = value;}
		}                                    
		
		/// <summary>
		/// 高危药品
		/// </summary>
		public bool IsHighDanger
		{
			get { return _isHighDanger;}
			set { _isHighDanger = value;}
		}                                    
		
		/// <summary>
		/// 危险品
		/// </summary>
		public bool IsDanger
		{
			get { return _isDanger;}
			set { _isDanger = value;}
		}                                    
		
		/// <summary>
		/// 是否疫苗
		/// </summary>
		public bool IsVaccine
		{
			get { return _isVaccine;}
			set { _isVaccine = value;}
		}                                    
		
		/// <summary>
		/// 检验报告
		/// </summary>
		public bool IsTestReport
		{
			get { return _isTestReport;}
			set { _isTestReport = value;}
		}                                    
		
		/// <summary>
		/// 是否麻醉药
		/// </summary>
		public bool IsAnaes
		{
			get { return _isAnaes;}
			set { _isAnaes = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsMeetingUse
		{
			get { return _isMeetingUse;}
			set { _isMeetingUse = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string RegNo
		{
			get { return _regNo;}
			set { _regNo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ImpotTestBy
		{
			get { return _impotTestBy;}
			set { _impotTestBy = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string TestReportNo
		{
			get { return _testReportNo;}
			set { _testReportNo = value;}
		}                                    
		
		/// <summary>
		/// 是否平价药
		/// </summary>
		public bool IsParity
		{
			get { return _isParity;}
			set { _isParity = value;}
		}                                    
		
		/// <summary>
		/// DDD最小值
		/// </summary>
		public string DDDMinValue
		{
			get { return _dDDMinValue;}
			set { _dDDMinValue = value;}
		}                                    
		
		/// <summary>
		/// DDD值
		/// </summary>
		public string DDDValue
		{
			get { return _dDDValue;}
			set { _dDDValue = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DrugsTypes
		{
			get { return _drugsTypes;}
			set { _drugsTypes = value;}
		}                                    
		
		/// <summary>
		/// 非限制级药品
		/// </summary>
		public bool NotXZjDrug
		{
			get { return _notXZjDrug;}
			set { _notXZjDrug = value;}
		}                                    
		
		/// <summary>
		/// 限制级药品
		/// </summary>
		public bool XZjDrug
		{
			get { return _xZjDrug;}
			set { _xZjDrug = value;}
		}                                    
		
		/// <summary>
		/// 特制级药品
		/// </summary>
		public bool TSjDrug
		{
			get { return _tSjDrug;}
			set { _tSjDrug = value;}
		}                                    
		
		/// <summary>
		/// 是否爱滋药
		/// </summary>
		public bool IsAz
		{
			get { return _isAz;}
			set { _isAz = value;}
		}                                    
		
		/// <summary>
		/// 是否结核药
		/// </summary>
		public bool IsJH
		{
			get { return _isJH;}
			set { _isJH = value;}
		}                                    
		
		/// <summary>
		/// 疫苗批文ID
		/// </summary>
		public string Vaccine
		{
			get { return _vaccine;}
			set { _vaccine = value;}
		}                                    
		
		/// <summary>
		/// 药品本位码，医保码
		/// </summary>
		public string BwCode
		{
			get { return _bwCode;}
			set { _bwCode = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}

        /// <summary>
        /// His 数据库未有
        /// </summary>
        public string TallyGroupId
        {
            get { return _tallyGroupId; }
            set { _tallyGroupId = value; }
        }

        /// <summary>
        /// His 数据库未有
        /// </summary>
        public bool IsYblimit
        {
            get { return _isYblimit; }
            set { _isYblimit = value; }
        }

    }  
}           


