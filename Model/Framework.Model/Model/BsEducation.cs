

using System;
namespace Orm.Model
{
	/// <summary>
	/// 疾病维护 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsEducation: BaseModel	{   
		
		
		
		private string _code;  //编码
		
		private string _name;  //标题
		
		private string _groupMain;  //一级分组
		
		private string _groupSub;  //二级分组
		
		private string _content;  //内容
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型

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
		/// 标题
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 一级分组
		/// </summary>
		public string GroupMain
		{
			get { return _groupMain;}
			set { _groupMain = value;}
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
		/// 内容
		/// </summary>
		public string Content
		{
			get { return _content;}
			set { _content = value;}
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
        /// 
        /// </summary>
        public int HospitalID
        {
            get { return _HospitalID; }
            set { _HospitalID = value; }
        }

    }  
}           


