

using System;
namespace Orm.Model
{
	/// <summary>
	/// 电子病历左边节点 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblEMRCatalog : BaseModel
    {   
		 
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _parentID;  //父ID
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private string _infoPathFile;  //
		
		private int _lsCompareType;  //相对时间点：1-入院时间；；2-当前凌晨；3-出院日期
		
		private int _aheadHours;  //在多少小时内书写
		
		private bool _isProgressNote;  //是否病程记录
		
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
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 父ID
		/// </summary>
		public string ParentID
		{
			get { return _parentID;}
			set { _parentID = value;}
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
		public string InfoPathFile
		{
			get { return _infoPathFile;}
			set { _infoPathFile = value;}
		}                                    
		
		/// <summary>
		/// 相对时间点：1-入院时间；；2-当前凌晨；3-出院日期
		/// </summary>
		public int LsCompareType
		{
			get { return _lsCompareType;}
			set { _lsCompareType = value;}
		}                                    
		
		/// <summary>
		/// 在多少小时内书写
		/// </summary>
		public int AheadHours
		{
			get { return _aheadHours;}
			set { _aheadHours = value;}
		}                                    
		
		/// <summary>
		/// 是否病程记录
		/// </summary>
		public bool IsProgressNote
		{
			get { return _isProgressNote;}
			set { _isProgressNote = value;}
		}                                    
		                                   
		        
	}  
}           


