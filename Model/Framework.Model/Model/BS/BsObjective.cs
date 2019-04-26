

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 行心云：复诊目的 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class BsObjective:BaseModel
	{   
		
		private double _id;  //
		
		private string _name;  //名称
		
		private double _orderBy;  //显示顺序
		
		private bool _isActive;  //是否可用
		
		private double _parentID;  //父键疾病大类
		
		private string _infoContent;  //信息内容
		
		private string _guId;  //主键
		 

		
		/// <summary>
		/// 
		/// </summary>
		public double Id
		{
			get { return _id;}
			set { _id = value;}
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
		/// 显示顺序
		/// </summary>
		public double OrderBy
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
		public double ParentID
		{
			get { return _parentID;}
			set { _parentID = value;}
		}                                    
		
		/// <summary>
		/// 信息内容
		/// </summary>
		public string InfoContent
		{
			get { return _infoContent;}
			set { _infoContent = value;}
		}                                    
		
		/// <summary>
		/// 主键
		/// </summary>
		public string GuId
		{
			get { return _guId;}
			set { _guId = value;}
		}                                    
		        
	}  
}           


