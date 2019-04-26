

using System;
using Orm.Model.EnumDefine;

namespace Orm.Model
{
	/// <summary>
	/// 系统菜单 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblSystemMenu : BaseModel
    {   
		
		private string _systemId;  //菜单GblSystem.id
		
		private string _code;  //FormName
		
		private string _name;  //标题（即Caption）
		
		private int _iconIndex;  //图标
		
		private string _hint;  //提示
		
		private string _shortcut;  //快捷键，用“+”分割多个，例如：Control+Shift+N
		
		private string _parentID;  //所属系统
		
		private int _orderBy;  //显示次序
		
		private bool _isMostUsed;  //常用的（不常用的会在菜单中卷起隐藏）
		
		private bool _isBeginGroup;  //开头有横线
		
		private bool _isActive;  //有效或隐藏菜单
		
		private string _docPath;  //帮助文档路径
		
		private string _videoPath;  //帮助视频路径
		
		private string _reportType;  //报表类别
		
		private bool _isSelect;  //1、忙时不许查询
		
		private string _url;  //url
		
		private string _helpAddress;  //行心云:操作说明书网址
		
		private string _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private int _HospitalID;  //



        private string _fileName;

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private string _procName;

        public string ProcName
        {
            get { return _procName; }
            set { _procName = value; }
        }


        /// <summary>
        /// 菜单GblSystem.id
        /// </summary>
        public string SystemId
		{
			get { return _systemId;}
			set { _systemId = value;}
		}                                    
		
		/// <summary>
		/// FormName
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 标题（即Caption）
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 图标
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 提示
		/// </summary>
		public string Hint
		{
			get { return _hint;}
			set { _hint = value;}
		}                                    
		
		/// <summary>
		/// 快捷键，用“+”分割多个，例如：Control+Shift+N
		/// </summary>
		public string Shortcut
		{
			get { return _shortcut;}
			set { _shortcut = value;}
		}                                    
		
		/// <summary>
		/// 所属系统
		/// </summary>
		public string ParentID
		{
			get { return _parentID;}
			set { _parentID = value;}
		}                                    
		
		/// <summary>
		/// 显示次序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 常用的（不常用的会在菜单中卷起隐藏）
		/// </summary>
		public bool IsMostUsed
		{
			get { return _isMostUsed;}
			set { _isMostUsed = value;}
		}                                    
		
		/// <summary>
		/// 开头有横线
		/// </summary>
		public bool IsBeginGroup
		{
			get { return _isBeginGroup;}
			set { _isBeginGroup = value;}
		}                                    
		
		/// <summary>
		/// 有效或隐藏菜单
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 帮助文档路径
		/// </summary>
		public string DocPath
		{
			get { return _docPath;}
			set { _docPath = value;}
		}                                    
		
		/// <summary>
		/// 帮助视频路径
		/// </summary>
		public string VideoPath
		{
			get { return _videoPath;}
			set { _videoPath = value;}
		}                                    
		
		/// <summary>
		/// 报表类别
		/// </summary>
		public string ReportType
		{
			get { return _reportType;}
			set { _reportType = value;}
		}                                    
		
		/// <summary>
		/// 1、忙时不许查询
		/// </summary>
		public bool IsSelect
		{
			get { return _isSelect;}
			set { _isSelect = value;}
		}                                    
		
		/// <summary>
		/// url
		/// </summary>
		public string Url
		{
			get { return _url;}
			set { _url = value;}
		}                                    
		
		/// <summary>
		/// 行心云:操作说明书网址
		/// </summary>
		public string HelpAddress
		{
			get { return _helpAddress;}
			set { _helpAddress = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}


        private int _hisType;
        /// <summary>
        /// 系统产品类型 0 公共，1 his， 2 行心云
        /// </summary>
        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }
        private bool _isOrmType = false;
        public bool u_IsOrmType
        {
            get
            {
                if (HisType == (int)EnumSystemProductType.OrmType)
                {
                    _isOrmType = true;
                }
                else
                {
                    _isOrmType = false;
                }
                return _isOrmType;
            }
            set { _isOrmType = value; }
        }
    }  
}           


