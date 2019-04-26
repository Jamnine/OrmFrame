

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验分组 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkTestGroup : BaseModel
    {    
		private string _code;  //检查分类ID
		
		private string _name;  //页分类名称
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private bool _isPrint;  //是否打印总检
		
		private int _lsXType;  //报告类别：1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA；12-普放；13-病理；14-其它
		
		private bool _isGroupPrint;  //是否分组打印：0-打标签1-分组打标签

        private int _hisType;//产品类型：0.共享 1.His 2.行心云
		 
                                   
		
		/// <summary>
		/// 检查分类ID
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 页分类名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
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
		/// 是否打印总检
		/// </summary>
		public bool IsPrint
		{
			get { return _isPrint;}
			set { _isPrint = value;}
		}                                    
		
		/// <summary>
		/// 报告类别：1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA；12-普放；13-病理；14-其它
		/// </summary>
		public int LsXType
		{
			get { return _lsXType;}
			set { _lsXType = value;}
		}                                    
		
		/// <summary>
		/// 是否分组打印：0-打标签1-分组打标签
		/// </summary>
		public bool IsGroupPrint
		{
			get { return _isGroupPrint;}
			set { _isGroupPrint = value;}
		}                                    
		


        /// <summary>
        /// 产品类型 0.共享 1. HIS 2.行心云
        /// </summary>
        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; } }

    }  
}           


