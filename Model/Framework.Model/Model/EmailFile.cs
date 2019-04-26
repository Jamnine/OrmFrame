

using System;
namespace Orm.Model
{
	/// <summary>
	/// 保存文件 - 实体类
	/// </summary>
	[Serializable]
	public partial class EmailFile : BaseModel
    {    
		private byte[] _fileContent;  //文件内容
		
		private string _emailId;  //GblEmail表的ID
		
		private string _fileName;  //文件名
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public EmailFile() { }
         
		/// <summary>
		/// 文件内容
		/// </summary>
		public byte[] FileContent
		{
			get { return _fileContent;}
			set { _fileContent = value;}
		}                                    
		
		/// <summary>
		/// GblEmail表的ID
		/// </summary>
		public string EmailId
		{
			get { return _emailId;}
			set { _emailId = value;}
		}                                    
		
		/// <summary>
		/// 文件名
		/// </summary>
		public string FileName
		{
			get { return _fileName;}
			set { _fileName = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
                                  
		        
	}  
}           


