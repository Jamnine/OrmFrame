

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class OaDocFile : BaseModel
	{   
		 
		private string _docId;  //OaDocument.Id
		
		private int _lsDocType;  //文档类型：1-内部模板；2-WORD；3-EXCEL；4-PPT；5-网页文件；6-PDF；7-TXT；8-图片；9-视频；10-压缩
		
		private byte[] _docFile;  //医生文件
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// OaDocument.Id
		/// </summary>
		public string DocId
		{
			get { return _docId;}
			set { _docId = value;}
		}                                    
		
		/// <summary>
		/// 文档类型：1-内部模板；2-WORD；3-EXCEL；4-PPT；5-网页文件；6-PDF；7-TXT；8-图片；9-视频；10-压缩
		/// </summary>
		public int LsDocType
		{
			get { return _lsDocType;}
			set { _lsDocType = value;}
		}                                    
		
		/// <summary>
		/// 医生文件
		/// </summary>
		public byte[] DocFile
		{
			get { return _docFile;}
			set { _docFile = value;}
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


