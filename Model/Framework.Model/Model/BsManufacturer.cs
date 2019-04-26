using System;
namespace Orm.Model
{
	/// <summary>
	/// 生产厂商 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsManufacturer:BaseModel
	{   
		private string _code;  //生产商编码
		
		private string _name;  //生产商名称
		
		private int _lsKind;  //药品来源：1-进口；2-国产；3-合资；4-外资
		
		private string _areaCode;  //邮编
		
		private string _address;  //地址
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private bool _isActive;  //有效标志
		
		private int _orderBy;  //显示顺序
		
		private int _iconIndex;  //图标类型
		
		private int _lsType;  //供应商分类。0:公用。1、西药库。2、中药库。3、材料库。4、物资库。5、其它仓库
		
		private string _licenceCode;  //生产企业许可证编号 

        private DateTime _moditime;  //最后修改时间

        private string _modioperId;  //最后修改人

        private int _HospitalID;//医院ID

        private string _houseId;//所属仓库



        /// <summary>
        /// 生产商编码
        /// </summary>
        public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 生产商名称
        /// </summary>
        [Collumn(HeaderName = "生产厂家", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}

        /// <summary>
        /// 药品来源：1-进口；2-国产；3-合资；4-外资
        /// </summary>
        [Collumn(HeaderName = "药品来源", RelatedTableType = null, LstType = "1:进口|2:国产|3:合资|4:外资")]
        public int LsKind
		{
			get { return _lsKind;}
			set { _lsKind = value;}
		}

        /// <summary>
        /// 邮编
        /// </summary>
        [Collumn(HeaderName = "邮编", RelatedTableType = null)]
        public string AreaCode
		{
			get { return _areaCode;}
			set { _areaCode = value;}
		}

        /// <summary>
        /// 地址
        /// </summary>
        [Collumn(HeaderName = "地址", RelatedTableType = null)]
        public string Address
		{
			get { return _address;}
			set { _address = value;}
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
		/// 有效标志
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
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
		/// 图标类型
		/// </summary>
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
		/// 生产企业许可证编号
		/// </summary>
		public string LicenceCode
		{
			get { return _licenceCode;}
			set { _licenceCode = value;}
		}

     




        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime Moditime
        {
            get { return _moditime; }
            set { _moditime = value; }
        }

        /// <summary>
        /// 最后修改人
        /// </summary>
        public string ModioperId
        {
            get { return _modioperId; }
            set { _modioperId = value; }
        }


        /// <summary>
        /// 所属仓库
        /// </summary>
        [Collumn(HeaderName = "专用仓库", RelatedTableType = typeof(BsHouse),IsShow = true)]
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }
        
    }  
}           


