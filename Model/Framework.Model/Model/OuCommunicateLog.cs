

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:通讯记录(通话，短信，微信推送) - 实体类
	/// </summary>
	[Serializable]
	public partial class OuCommunicateLog:BaseModel
	{   
		 
		private string _patId;  //病人ID
		
		private string _name;  //姓名
		
		private string _phone="";  //电话号码
		
		private string _comments="";  //备注（通话备注，短信内容，微信推送内容）
		
		private int _type;  //通讯类型：0 其他 1 回访 2 预约 3 生日祝福
		
		private double _notifytype;  //推送方式(0 微信 1 短信 2电话 )：
		
		private string _operId;  //操作员ID
		
		private DateTime _operTime;  //操作时间
		
		private string _servicetime;  //通话时长
		
		private bool _isActive;  //是否启用
		
		private int _HospitalID;  //
        private DateTime _sendTime;//发送日期

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 姓名
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 电话号码
		/// </summary>
		public string Phone
		{
			get { return _phone;}
			set { _phone = value;}
		}                                    
		
		/// <summary>
		/// 备注（通话备注，短信内容，微信推送内容）
		/// </summary>
		public string Comments
		{
			get { return _comments;}
			set { _comments = value;}
		}                                    
		
		/// <summary>
		/// 通讯类型：0 其他 1 回访 2 预约 3 生日祝福
		/// </summary>
		public int Type
		{
			get { return _type;}
			set { _type = value;}
		}                                    
		
		/// <summary>
		/// 推送方式(0 微信 1 短信 2电话 )：
		/// </summary>
		public double Notifytype
		{
			get { return _notifytype;}
			set { _notifytype = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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
		/// 通话时长
		/// </summary>
		public string Servicetime
		{
			get { return _servicetime;}
			set { _servicetime = value;}
		}                                    
		
		/// <summary>
		/// 是否启用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}    
        /// <summary>
        /// 发送时间
        /// </summary>
		public DateTime SendTime
        {
            get { return _sendTime; }
            set
            {
                _sendTime = value;
            }
        }


    }  
}           


