

using System;
namespace Orm.Model
{
	/// <summary>
	/// QC质控 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkQcLot : BaseModel
    {    
		private string _code;  //编码
		
		private string _sampleNum;  //质控流水号
		
		private string _machineId;  //仪器
		
		private DateTime _expiryDate;  //停止日期
		
		private string _ctrlId;  //QC标准
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 质控流水号
		/// </summary>
		public string SampleNum
		{
			get { return _sampleNum;}
			set { _sampleNum = value;}
		}                                    
		
		/// <summary>
		/// 仪器
		/// </summary>
		public string MachineId
		{
			get { return _machineId;}
			set { _machineId = value;}
		}                                    
		
		/// <summary>
		/// 停止日期
		/// </summary>
		public DateTime ExpiryDate
		{
			get { return _expiryDate;}
			set { _expiryDate = value;}
		}                                    
		
		/// <summary>
		/// QC标准
		/// </summary>
		public string CtrlId
		{
			get { return _ctrlId;}
			set { _ctrlId = value;}
		}                                    
		
                                   
		        
	}  
}           


