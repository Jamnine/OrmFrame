

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云：复诊目的 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsObjective:BaseModel
	{   
		 
		private string _name;  //名称
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //是否可用
		
		private string _parentID;  //父键疾病大类
		
		private string _infoContent;  //信息内容


        /// <summary>
        /// 名称
        /// </summary>
        [Collumn(HeaderName = "名称", RelatedTableType = null, Length = 25)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
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
        /// 父键疾病大类
        /// </summary>
        [Collumn(HeaderName = "疾病大类", Where = "ParentID=@0", WhereArgs = new object[] { 0 })]//, RelatedTableType = typeof(Model.ToothCaseHistoryType)
        public string ParentID
		{
			get { return _parentID;}
			set { _parentID = value;}
		}

        /// <summary>
        /// 信息内容
        /// </summary>
        [Collumn(HeaderName = "信息内容", RelatedTableType = null, Length = 800)]
        public string InfoContent
		{
			get { return _infoContent;}
			set { _infoContent = value;}
		}                                    
		   
	}  
}           


