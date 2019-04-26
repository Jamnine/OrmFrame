

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 短信息发送情况 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblPhoneMsg : BaseModel
    {   
		
		
		
		private string _phoneNum;  //电话号码
		
		private string _name;  //对方姓名
		
		private string _message;  //信息内容
		
		private DateTime _planTime;  //计划发送时间
		
		private bool _isSend;  //是否已发送
		
		private DateTime _sendTime;  //已发送时间
		
		private int _operId;  //登记人
		
		private DateTime _operTime;  //登记时间
		
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
		/// 电话号码
		/// </summary>
		public string PhoneNum
		{
			get { return _phoneNum;}
			set { _phoneNum = value;}
		}                                    
		
		/// <summary>
		/// 对方姓名
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 信息内容
		/// </summary>
		public string Message
		{
			get { return _message;}
			set { _message = value;}
		}                                    
		
		/// <summary>
		/// 计划发送时间
		/// </summary>
		public DateTime PlanTime
		{
			get { return _planTime;}
			set { _planTime = value;}
		}                                    
		
		/// <summary>
		/// 是否已发送
		/// </summary>
		public bool IsSend
		{
			get { return _isSend;}
			set { _isSend = value;}
		}                                    
		
		/// <summary>
		/// 已发送时间
		/// </summary>
		public DateTime SendTime
		{
			get { return _sendTime;}
			set { _sendTime = value;}
		}                                    
		
		/// <summary>
		/// 登记人
		/// </summary>
		public int OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 登记时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
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


