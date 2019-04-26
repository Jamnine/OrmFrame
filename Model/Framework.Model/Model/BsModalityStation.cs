

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsModalityStation:BaseModel
	{   
		 
		private string _stationName;  //
		
		private string _modality;  //
		
		private string _aETitle;  //
		
		private string _iPAddress;  //
		
		private string _dicomPort;  //
		
		private string _serverImagePath;  //
		
		private string _clientImgPath;  //客户端图像路径
		
		private string _clientVideoPath;  //客户端视频路径
		
		private bool _isEquipment;  //是否设备
		
		private bool _isGate;  //是否是网关
		
		private string _locationId;  //是否是网关

        private int _HospitalID;//医院ID
         
		/// <summary>
		/// 
		/// </summary>
		public string StationName
		{
			get { return _stationName;}
			set { _stationName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Modality
		{
			get { return _modality;}
			set { _modality = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string AETitle
		{
			get { return _aETitle;}
			set { _aETitle = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string IPAddress
		{
			get { return _iPAddress;}
			set { _iPAddress = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DicomPort
		{
			get { return _dicomPort;}
			set { _dicomPort = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ServerImagePath
		{
			get { return _serverImagePath;}
			set { _serverImagePath = value;}
		}                                    
		
		/// <summary>
		/// 客户端图像路径
		/// </summary>
		public string ClientImgPath
		{
			get { return _clientImgPath;}
			set { _clientImgPath = value;}
		}                                    
		
		/// <summary>
		/// 客户端视频路径
		/// </summary>
		public string ClientVideoPath
		{
			get { return _clientVideoPath;}
			set { _clientVideoPath = value;}
		}                                    
		
		/// <summary>
		/// 是否设备
		/// </summary>
		public bool IsEquipment
		{
			get { return _isEquipment;}
			set { _isEquipment = value;}
		}                                    
		
		/// <summary>
		/// 是否是网关
		/// </summary>
		public bool IsGate
		{
			get { return _isGate;}
			set { _isGate = value;}
		}                                    
		
		/// <summary>
		/// 是否是网关
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}
 
    }  
}           


