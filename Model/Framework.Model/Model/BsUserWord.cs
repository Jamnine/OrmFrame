

using System;
namespace Orm.Model
{
	/// <summary>
	/// 用户常用词汇 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUserWord : BaseModel
    {   
		 
		private string _operId;  //用户名
		
		private string _keyType;  //词汇类别
		
		private string _content;  //词汇
		
		private int _iconIndex;  //图标类型
		
		private string _pycode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _HospitalID;  //

        public BsUserWord() { }
                               
		
		/// <summary>
		/// 用户名
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 词汇类别
		/// </summary>
		public string KeyType
		{
			get { return _keyType;}
			set { _keyType = value;}
		}                                    
		
		/// <summary>
		/// 词汇
		/// </summary>
		public string Content
		{
			get { return _content;}
			set { _content = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
		public string pycode
		{
			get { return _pycode;}
			set { _pycode = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
	                                   
		        
	}  
}           


