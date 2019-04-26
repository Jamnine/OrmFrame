

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院发票分类 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsInvInItem : BaseModel
    {   
		
		private string _code;  //发票项目ID
		
		private string _name;  //发票项目
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private string _groupName;  //分组名称
		
		private int _iconIndex;  //图标类型
		
		private int _groupOrderBy;  //组显示顺序
		
		private bool _isAlone;  //是否单独分组
		
		private int _HospitalID;  //
		 
		/// <summary>
		/// 发票项目ID
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 发票项目
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
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
		/// 分组名称
		/// </summary>
		public string GroupName
		{
			get { return _groupName;}
			set { _groupName = value;}
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
		/// 组显示顺序
		/// </summary>
		public int GroupOrderBy
		{
			get { return _groupOrderBy;}
			set { _groupOrderBy = value;}
		}                                    
		
		/// <summary>
		/// 是否单独分组
		/// </summary>
		public bool IsAlone
		{
			get { return _isAlone;}
			set { _isAlone = value;}
		}                                    
		
	

        private int _hisType;
        /// <summary>
        /// 产品类型
        /// </summary>
        public int HisType
        {
            get
            {
                return _hisType;
            }

            set
            {
                _hisType = value;
            }
        }
        private DateTime _insertTime;
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InsertTime
        {
            get
            {
                return _insertTime;
            }

            set
            {
                _insertTime = value;
            }
        }

    }  
}           


