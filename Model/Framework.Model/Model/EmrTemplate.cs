

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:EMR文件列表 - 实体类
	/// </summary>
	[Serializable]
	public partial class EmrTemplate:BaseModel
	{    
		private string _fileName;  //
		
		private string _code;  //
		
		private bool _isActive;  //
		
		private string _parentId;  //父级节点
		
		private int _HospitalID;  //父级节点
		private int _hisType;  //父级节点

        public EmrTemplate() { }
         
		/// <summary>
		/// 
		/// </summary>
		public string FileName
		{
			get { return _fileName;}
			set { _fileName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 父级节点
		/// </summary>
		public string ParentId
		{
			get { return _parentId;}
			set { _parentId = value;}
		}                                    
		
	                        
		
		/// <summary>
		/// 父级节点
		/// </summary>
		public int HisType
        {
			get { return _hisType; }
			set { _hisType = value;}
		}

        public int Number { get; set; }
        public string Path { get; set; }
    }  
}           


