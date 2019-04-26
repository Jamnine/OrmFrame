

using System;
namespace Orm.Model
{
	/// <summary>
	/// 供应商 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsCompany : BaseModel
    {   
		
		private string _code;  //医药公司编码
		
		private string _name;  //医药公司名称
		
		private string _compAddre = string.Empty;  //地址
		
		private string _compCorpo;  //法人代表
		
		private string _compPhone;  //电话
		
		private string _bank;  //开户银行
		
		private string _bankAccount;  //银行帐户
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _iconIndex;  //图标类型
		
		private int _lsType;  //供应商分类。0:公用。1、西药库。2、中药库。3、材料库。4、物资库。5、其它仓库
		
		private string _licenceCode;  //供货单位许可证编号
		
		private int _compType;  //行心云: 
		
		private string _upCode;  //行心云:上报码
		
		private string _yBCode;  //行心云:医保码
		
		private string _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private string _houseId;  //行心云:F4专用仓库ID
		
		private int _HospitalID;  //



        /// <summary>
        /// 医药公司编码
        /// </summary>
         [Collumn(HeaderName = "医药公司编码", RelatedTableType = null, Length = 6)]
        public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 供应商
        /// </summary>
        [Collumn(HeaderName = "供应商", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}

        /// <summary>
        /// 地址
        /// </summary>
        [Collumn(HeaderName = "地址", RelatedTableType = null)]
        public string CompAddre
		{
			get
            {
                if(_compAddre=="")
                {
                    return "无";
                }
                return _compAddre;
            }
			set { _compAddre = value;}
		}

        /// <summary>
        /// 法人代表
        /// </summary>
        [Collumn(HeaderName = "法人代表", RelatedTableType = null)]
        public string CompCorpo
		{
			get
            {
                if(_compCorpo == "")
                {
                    return "无";
                }
                return _compCorpo;
            }
			set { _compCorpo = value;}
		}

        /// <summary>
        /// 电话
        /// </summary>
        [Collumn(HeaderName = "电话", RelatedTableType = null, Length = 15)]
        public string CompPhone
		{
			get
            {
                if(_compPhone == "")
                {
                    return "无";
                }
                return _compPhone;
            }
			set { _compPhone = value;}
		}

        /// <summary>
        /// 开户银行
        /// </summary>
        [Collumn(HeaderName = "开户银行", RelatedTableType = null, Length = 60)]
        public string Bank
		{
			get
            {
                if(_bank =="")
                {
                    return "无";
                }
                return _bank;
            }
			set { _bank = value;}
		}

        /// <summary>
        /// 银行帐户
        /// </summary>
        [Collumn(HeaderName = "银行账户", RelatedTableType = null, Length = 16)]
        public string BankAccount
		{
			get
            {
                if(_bankAccount == "")
                {
                    return "无";
                }
                return _bankAccount;
            }
			set { _bankAccount = value;}
		}

        /// <summary>
        /// 显示顺序
        /// </summary>
        [Collumn(HeaderName = "显示顺序", RelatedTableType = null)]
        public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}

        /// <summary>
        /// 有效标志
        /// </summary>
        [Collumn(HeaderName = "有效标志", RelatedTableType = null)]
        public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}

        /// <summary>
        /// 拼音码
        /// </summary>
        [Collumn(HeaderName = "拼音码", RelatedTableType = null)]
        public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}

        /// <summary>
        /// 五笔码
        /// </summary>
        [Collumn(HeaderName = "五笔码", RelatedTableType = null)]
        public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}

        /// <summary>
        /// 图标类型
        /// </summary>
        [Collumn(HeaderName = "图标", IsShow = false, RelatedTableType = null)]
        public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 供应商分类。0:公用。1、西药库。2、中药库。3、材料库。4、物资库。5、其它仓库
		/// </summary>
		public int LsType
		{
			get { return _lsType;}
			set { _lsType = value;}
		}                                    
		
		/// <summary>
		/// 供货单位许可证编号
		/// </summary>
		public string LicenceCode
		{
			get { return _licenceCode;}
			set { _licenceCode = value;}
		}

        /// <summary>
        /// 行心云: 
        /// </summary>
        [Collumn(HeaderName = "公司类型", RelatedTableType = null, LstType = "1:加工单公司|2:医药公司")]
        public int CompType
		{
			get { return _compType;}
			set { _compType = value;}
		}

        /// <summary>
        /// 行心云:上报码
        /// </summary>
        [Collumn(HeaderName = "上报码", RelatedTableType = null)]
        public string UpCode
		{
			get { return _upCode;}
			set { _upCode = value;}
		}

        /// <summary>
        /// 行心云:医保码
        /// </summary>
        [Collumn(HeaderName = "医保码", RelatedTableType = null)]
        public string YBCode
		{
			get { return _yBCode;}
			set { _yBCode = value;}
		}

        /// <summary>
        /// 行心云:最后修改人
        /// </summary>
        [Collumn(HeaderName = "最后修改人", RelatedTableType = typeof(BsUser))]
        public string ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}

        /// <summary>
        /// 行心云:最后修改时间
        /// </summary>
        [Collumn(HeaderName = "最后修改时间", RelatedTableType = null)]
        public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}

        /// <summary>
        /// 行心云:F4专用仓库ID
        /// </summary>
        [Collumn(HeaderName = "专用仓库", RelatedTableType = typeof(BsHouse),IsShow = true)]
        public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
		}                                    
		
	                                    
		        
	}  
}           


