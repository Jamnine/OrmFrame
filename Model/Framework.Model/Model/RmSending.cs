

using System;
namespace Orm.Model
{
    /// <summary>
    /// 药房单据锁定情况 - 实体类
    /// </summary>
    [Serializable]
    public partial class RmSending : BaseModel
    {

        

        private string _roomId;  //药房ID,BsRoom.Id

        private DateTime _operTime;  //操作时间

        private string _operId;  //操作员ID,BsUser.Id

        private string _hospId;  //病人hospid

        private string _operType;  //操作类型

        private string _ipAddress;  //IP地址

        private string _hostName;  //电脑名字

        private string _mzRegId;  //门诊IDOuhosinfo.Id

        private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //

        public RmSending(){}
		
		 
		/// <summary>
		/// 药房ID,BsRoom.Id
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
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
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 病人hospid
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 操作类型
		/// </summary>
		public string OperType
		{
			get { return _operType;}
			set { _operType = value;}
		}                                    
		
		/// <summary>
		/// IP地址
		/// </summary>
		public string IpAddress
		{
			get { return _ipAddress;}
			set { _ipAddress = value;}
		}                                    
		
		/// <summary>
		/// 电脑名字
		/// </summary>
		public string HostName
		{
			get { return _hostName;}
			set { _hostName = value;}
		}                                    
		
		/// <summary>
		/// 门诊IDOuhosinfo.Id
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


