

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检组 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkGroup : BaseModel
	{    
		private string _code;  //协定处方ID
		
		private string _name;  //协定处方名称
		
		private bool _isActive;  //是否可用
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private string _operId;  //创建人
		
		private DateTime _operTime;  //创建时间
		
		private int _iconIndex;  //图标类型
		
		private bool _isNewGroup;  //新增组

        private int _HospitalID;
         
		/// <summary>
		/// 协定处方ID
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 协定处方名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
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
		/// 创建人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
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
		/// 新增组
		/// </summary>
		public bool IsNewGroup
		{
			get { return _isNewGroup;}
			set { _isNewGroup = value;}
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


