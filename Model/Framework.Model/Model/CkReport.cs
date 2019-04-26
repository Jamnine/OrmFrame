

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检单报告 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkReport : BaseModel
    {     
		private string _checkId;  //体检ID,CkMain.Id
		
		private string _testGroupId;  //体检分类ID
		
		private DateTime _operTime;  //检查时间
		
		private string _operId;  //检查人
		
		private byte[] _content;  //病历内容
		
		private string _xMLFile;  //XML内容
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 体检ID,CkMain.Id
		/// </summary>
		public string CheckId
		{
			get { return _checkId;}
			set { _checkId = value;}
		}                                    
		
		/// <summary>
		/// 体检分类ID
		/// </summary>
		public string TestGroupId
		{
			get { return _testGroupId;}
			set { _testGroupId = value;}
		}                                    
		
		/// <summary>
		/// 检查时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 检查人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 病历内容
		/// </summary>
		public byte[] Content
		{
			get { return _content;}
			set { _content = value;}
		}                                    
		
		/// <summary>
		/// XML内容
		/// </summary>
		public string XMLFile
		{
			get { return _xMLFile;}
			set { _xMLFile = value;}
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


