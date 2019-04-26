

using System;
namespace Orm.Model
{
	/// <summary>
	/// 打印模板设置 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsReportTemplate:BaseModel
	{   
		
		private string _name;  //对用户显示的报表名称或描述
		
		private string _fileName;  //RDLC报表文件名
		
		private bool _isActive;  //是否启用
		
		private int _templateType;  //模板类型：1-收据
		
		private DateTime _insertTime;  //
		 
		 
		/// <summary>
		/// 对用户显示的报表名称或描述
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// RDLC报表文件名
		/// </summary>
		public string FileName
		{
			get { return _fileName;}
			set { _fileName = value;}
		}                                    
		
		/// <summary>
		/// 是否启用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 模板类型：1-收据
		/// </summary>
		public int TemplateType
		{
			get { return _templateType;}
			set { _templateType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime InsertTime
		{
			get { return _insertTime;}
			set { _insertTime = value;}
		}                                    
		        
	}  
}           


