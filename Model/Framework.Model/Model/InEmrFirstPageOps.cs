

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class InEmrFirstPageOps : BaseModel
    {   
		 
		private string _hospid;  //
		
		private string _emrFirstPageId;  //病案首页ID
		
		private DateTime _opsTime;  //手术时间
		
		private string _opsName;  //手术名称
		
		private int _opsLevel;  //手术级别
		
		private int _opsDoctor;  //手术医生
		
		private string _opsHelper1;  //助手1
		
		private string _opsHelper2;  //助手2
		
		private string _opsHelper3;  //助手3
		
		private string _incisionHeal;  //切口/愈合
		
		private string _electiveOps;  //择期手术
		
		private string _anesthesiaMode;  //麻醉方式
		
		private string _anesthesiaDoctor;  //麻醉医师
		
		private string _opsCode;  //手术及操作编码
		
		private int _HospitalID;  //

        public InEmrFirstPageOps() { }
         
		/// <summary>
		/// 
		/// </summary>
		public string Hospid
		{
			get { return _hospid;}
			set { _hospid = value;}
		}                                    
		
		/// <summary>
		/// 病案首页ID
		/// </summary>
		public string EmrFirstPageId
		{
			get { return _emrFirstPageId;}
			set { _emrFirstPageId = value;}
		}                                    
		
		/// <summary>
		/// 手术时间
		/// </summary>
		public DateTime OpsTime
		{
			get { return _opsTime;}
			set { _opsTime = value;}
		}                                    
		
		/// <summary>
		/// 手术名称
		/// </summary>
		public string OpsName
		{
			get { return _opsName;}
			set { _opsName = value;}
		}                                    
		
		/// <summary>
		/// 手术级别
		/// </summary>
		public int OpsLevel
		{
			get { return _opsLevel;}
			set { _opsLevel = value;}
		}                                    
		
		/// <summary>
		/// 手术医生
		/// </summary>
		public int OpsDoctor
		{
			get { return _opsDoctor;}
			set { _opsDoctor = value;}
		}                                    
		
		/// <summary>
		/// 助手1
		/// </summary>
		public string OpsHelper1
		{
			get { return _opsHelper1;}
			set { _opsHelper1 = value;}
		}                                    
		
		/// <summary>
		/// 助手2
		/// </summary>
		public string OpsHelper2
		{
			get { return _opsHelper2;}
			set { _opsHelper2 = value;}
		}                                    
		
		/// <summary>
		/// 助手3
		/// </summary>
		public string OpsHelper3
		{
			get { return _opsHelper3;}
			set { _opsHelper3 = value;}
		}                                    
		
		/// <summary>
		/// 切口/愈合
		/// </summary>
		public string IncisionHeal
		{
			get { return _incisionHeal;}
			set { _incisionHeal = value;}
		}                                    
		
		/// <summary>
		/// 择期手术
		/// </summary>
		public string ElectiveOps
		{
			get { return _electiveOps;}
			set { _electiveOps = value;}
		}                                    
		
		/// <summary>
		/// 麻醉方式
		/// </summary>
		public string AnesthesiaMode
		{
			get { return _anesthesiaMode;}
			set { _anesthesiaMode = value;}
		}                                    
		
		/// <summary>
		/// 麻醉医师
		/// </summary>
		public string AnesthesiaDoctor
		{
			get { return _anesthesiaDoctor;}
			set { _anesthesiaDoctor = value;}
		}                                    
		
		/// <summary>
		/// 手术及操作编码
		/// </summary>
		public string OpsCode
		{
			get { return _opsCode;}
			set { _opsCode = value;}
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


