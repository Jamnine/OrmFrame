

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:求助历史记录表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsAppealHistory : BaseModel
    {   
		
		private string _userId;  //发送者id
		
		private string _specialiStId;  //求助专家id
		
		private string _messAge;  //消息
		
		private DateTime _sendTime;  //发送时间
		
		private int _hoSpitalId;  //

        public BsAppealHistory() { }

        
		/// <summary>
		/// 发送者id
		/// </summary>
		public string UserId
		{
			get { return _userId;}
			set { _userId = value;}
		}                                    
		
		/// <summary>
		/// 求助专家id
		/// </summary>
		public string SpecialiStId
		{
			get { return _specialiStId;}
			set { _specialiStId = value;}
		}                                    
		
		/// <summary>
		/// 消息
		/// </summary>
		public string MessAge
		{
			get { return _messAge;}
			set { _messAge = value;}
		}                                    
		
		/// <summary>
		/// 发送时间
		/// </summary>
		public DateTime SendTime
		{
			get { return _sendTime;}
			set { _sendTime = value;}
		}                                    
		                              
		        
	}  
}           


