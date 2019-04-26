

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
    public partial class CkMachineRawData : BaseModel
	{    
		private string _instrumentRawDataID;  //仪器原始结果ID，系统内码
		
		private string _dictInstrumentID;  //仪器ID，系统内码
		
		private string _rawData1;  //原始结果1
		
		private string _rawData2;  //原始结果2
		
		private string _rawData3;  //原始结果3
		
		private DateTime _createDate;  //用户生成日期
		
		private int _status;  //仪器数据处理状态
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 仪器原始结果ID，系统内码
		/// </summary>
		public string InstrumentRawDataID
		{
			get { return _instrumentRawDataID;}
			set { _instrumentRawDataID = value;}
		}                                    
		
		/// <summary>
		/// 仪器ID，系统内码
		/// </summary>
		public string DictInstrumentID
		{
			get { return _dictInstrumentID;}
			set { _dictInstrumentID = value;}
		}                                    
		
		/// <summary>
		/// 原始结果1
		/// </summary>
		public string RawData1
		{
			get { return _rawData1;}
			set { _rawData1 = value;}
		}                                    
		
		/// <summary>
		/// 原始结果2
		/// </summary>
		public string RawData2
		{
			get { return _rawData2;}
			set { _rawData2 = value;}
		}                                    
		
		/// <summary>
		/// 原始结果3
		/// </summary>
		public string RawData3
		{
			get { return _rawData3;}
			set { _rawData3 = value;}
		}                                    
		
		/// <summary>
		/// 用户生成日期
		/// </summary>
		public DateTime CreateDate
		{
			get { return _createDate;}
			set { _createDate = value;}
		}                                    
		
		/// <summary>
		/// 仪器数据处理状态
		/// </summary>
		public int Status
		{
			get { return _status;}
			set { _status = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		                                 
		        
	}  
}           


