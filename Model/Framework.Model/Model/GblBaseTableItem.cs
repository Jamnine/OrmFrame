

using System;
namespace Orm.Model
{
	/// <summary>
	/// 系统基本表维护配置 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblBaseTableItem:BaseModel
	{   
		 
		private string _parentID;  //父ID
		
		private string _baseTable;  //基本表名
		
		private string _name;  //基本表中文名
		
		private string _bLLClassName;  //Ｂｌｌ层的类名
		
		private string _modelClassName;  //Model层的类名
		
		private string _configType;  //网格配制
		
		private bool _isTable;  //是否是一个基本表
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //是否可用
		
		private string _roleId;  //专门开放使用的角色
		
		private string _orderField;  //排序字段
		
		private bool _isToWmr;  //是否用于病历词汇
		
		private string _servieName;  //服务的名称
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private int _HospitalID;  //

        public GblBaseTableItem() { }
         
		/// <summary>
		/// 父ID
		/// </summary>
		public string ParentID
		{
			get { return _parentID;}
			set { _parentID = value;}
		}                                    
		
		/// <summary>
		/// 基本表名
		/// </summary>
		public string BaseTable
		{
			get { return _baseTable;}
			set { _baseTable = value;}
		}                                    
		
		/// <summary>
		/// 基本表中文名
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// Ｂｌｌ层的类名
		/// </summary>
		public string BLLClassName
		{
			get { return _bLLClassName;}
			set { _bLLClassName = value;}
		}                                    
		
		/// <summary>
		/// Model层的类名
		/// </summary>
		public string ModelClassName
		{
			get { return _modelClassName;}
			set { _modelClassName = value;}
		}                                    
		
		/// <summary>
		/// 网格配制
		/// </summary>
		public string ConfigType
		{
			get { return _configType;}
			set { _configType = value;}
		}                                    
		
		/// <summary>
		/// 是否是一个基本表
		/// </summary>
		public bool IsTable
		{
			get { return _isTable;}
			set { _isTable = value;}
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
		/// 是否可用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 专门开放使用的角色
		/// </summary>
		public string RoleId
		{
			get { return _roleId;}
			set { _roleId = value;}
		}                                    
		
		/// <summary>
		/// 排序字段
		/// </summary>
		public string OrderField
		{
			get { return _orderField;}
			set { _orderField = value;}
		}                                    
		
		/// <summary>
		/// 是否用于病历词汇
		/// </summary>
		public bool IsToWmr
		{
			get { return _isToWmr;}
			set { _isToWmr = value;}
		}                                    
		
		/// <summary>
		/// 服务的名称
		/// </summary>
		public string ServieName
		{
			get { return _servieName;}
			set { _servieName = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		


        private int _hisType;

        /// <summary>
        /// 产品类型:0共享,1 his 2 行心云
        /// </summary>
        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }


    }  
}           


