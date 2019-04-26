

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房窗口 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsLocationRoomWindow:BaseModel
	{   
		 
		private string _locationId;  //科室
		
		private string _roomWindowName;  //窗口名
		
		private string _printerName;  //打印机名
        private int _HospitalID;//医院ID
         
		/// <summary>
		/// 科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 窗口名
		/// </summary>
		public string RoomWindowName
		{
			get { return _roomWindowName;}
			set { _roomWindowName = value;}
		}                                    
		
		/// <summary>
		/// 打印机名
		/// </summary>
		public string PrinterName
		{
			get { return _printerName;}
			set { _printerName = value;}
		}

    }  
}           


