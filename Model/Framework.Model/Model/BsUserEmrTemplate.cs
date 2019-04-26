

using System;
namespace Orm.Model
{
	/// <summary>
	/// 用户对应电子病历 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUserEmrTemplate:BaseModel
	{    
		 
		private string _operId;  //用户名
		
		private string _catalogId;  //病案类别
		
		private string _name;  //工种
		
		private string _templateFile;  //InfoPath模板名
		
		private bool _isDefault;  //是否默认使用
		
		private int _orderBy;  //排序
		
		private int _iconIndex;  //图标类型
		
		private int _lsOpenType;  //使用权：1-个人；2-科室；3-公共
		
		private DateTime _operTime;  //操作时间
		
		private string _locationId;  //所属科室
		
		private bool _isActive;  //是否有效标识
		
		private string _templateName;  //模板名

                                     
		
		/// <summary>
		/// 用户名
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}

        /// <summary>
        /// 病案类别
        /// </summary>
        [Collumn(HeaderName = "病案类别", RelatedTableType = typeof( GblEMRCatalog))]
        public string CatalogId
		{
			get { return _catalogId;}
			set { _catalogId = value;}
		}                                    
		
		/// <summary>
		/// 工种
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}

        /// <summary>
        /// InfoPath模板名
        /// </summary>
        [Collumn(HeaderName = "infoPath模板名", RelatedTableType = null, Length = 100)]
        public string TemplateFile
		{
			get { return _templateFile;}
			set { _templateFile = value;}
		}                                    
		
		/// <summary>
		/// 是否默认使用
		/// </summary>
		public bool IsDefault
		{
			get { return _isDefault;}
			set { _isDefault = value;}
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
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}

        /// <summary>
        /// 使用权：1-个人；2-科室；3-公共
        /// </summary>
        [Collumn(HeaderName = "使用权", RelatedTableType = null, LstType = "1:个人|2:科室|3:公共")]    
		public int LsOpenType
		{
			get { return _lsOpenType;}
			set { _lsOpenType = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}

        /// <summary>
        /// 所属科室
        /// </summary>
        [Collumn(HeaderName = "所属科室", RelatedTableType = typeof(BsLocation))]
        public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
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
        /// 模板名
        /// </summary>
        [Collumn(HeaderName = "模板名", RelatedTableType = null, Length = 50)]
        public string TemplateName
		{
			get { return _templateName;}
			set { _templateName = value;}
		}




    }  
}           


