

using System;
namespace Orm.Model
{
	/// <summary>
	/// 输血科相关文件 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkBandOffice : BaseModel
    {    
		private string _titleName;  //标题
		
		private byte[] _contentStr;  //内容
		
		private string _fileSize;  //文件大小
		
		private DateTime _operTime;  //操作时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public CkBandOffice() { }
         
		/// <summary>
		/// 标题
		/// </summary>
		public string TitleName
		{
			get { return _titleName;}
			set { _titleName = value;}
		}                                    
		
		/// <summary>
		/// 内容
		/// </summary>
		public byte[] ContentStr
		{
			get { return _contentStr;}
			set { _contentStr = value;}
		}                                    
		
		/// <summary>
		/// 文件大小
		/// </summary>
		public string FileSize
		{
			get { return _fileSize;}
			set { _fileSize = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
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


