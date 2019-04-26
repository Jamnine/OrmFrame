

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 提示信息发送信息表 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblEmail : BaseModel
    {   
		
		
		
		private string _title;  //标题
		
		private string _content;  //内容
		
		private string _fileName;  //附件文件名
		
		private DateTime _operTime;  //操作时间
		
		private int _operId;  //操作员ID
		
		private bool _isSign;  //是否已审核：0:未审核,1:已审核
		
		private bool _isPriority;  //是否紧急
		
		private bool _isFeedback;  //是否要求反馈意见
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 唯一标识
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 标题
		/// </summary>
		public string Title
		{
			get { return _title;}
			set { _title = value;}
		}                                    
		
		/// <summary>
		/// 内容
		/// </summary>
		public string Content
		{
			get { return _content;}
			set { _content = value;}
		}                                    
		
		/// <summary>
		/// 附件文件名
		/// </summary>
		public string FileName
		{
			get { return _fileName;}
			set { _fileName = value;}
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
		/// 操作员ID
		/// </summary>
		public int OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 是否已审核：0:未审核,1:已审核
		/// </summary>
		public bool IsSign
		{
			get { return _isSign;}
			set { _isSign = value;}
		}                                    
		
		/// <summary>
		/// 是否紧急
		/// </summary>
		public bool IsPriority
		{
			get { return _isPriority;}
			set { _isPriority = value;}
		}                                    
		
		/// <summary>
		/// 是否要求反馈意见
		/// </summary>
		public bool IsFeedback
		{
			get { return _isFeedback;}
			set { _isFeedback = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


