

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验报表格式表 - 实体类
	/// </summary>
	[Serializable]
	public partial class CKReportDefine : BaseModel
    {   
		 
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _testTypeID;  //体检分类,CkTestType.Id
		
		private byte[] _reportContent;  //
		
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
		/// 体检分类,CkTestType.Id
		/// </summary>
		public string TestTypeID
		{
			get { return _testTypeID;}
			set { _testTypeID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public byte[] ReportContent
		{
			get { return _reportContent;}
			set { _reportContent = value;}
		}                                    
		
	                                 
		        
	}  
}           


