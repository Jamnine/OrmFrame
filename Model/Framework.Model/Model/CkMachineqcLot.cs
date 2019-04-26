

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
    public partial class CkMachineqcLot : BaseModel
	{    
		private string _dictqcLotid;  //批号ID，系统内码
		
		private string _lotNum;  //批号
		
		private string _dictqcControlid;  //质控水平ID，系统内码
		
		private string _qcBarcode;  //QC条码号
		
		private DateTime _activeDate;  //生效日期
		
		private DateTime _expiryDate;  //失效日期
		
		private string _dictManufactureid;  //QC试剂厂商ID
		
		private int _operateBy;  //操作者
		
		private DateTime _createDate;  //用户生成日期
		
		private string _dictInstrumentID;  //仪器ID，系统内码
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 批号ID，系统内码
		/// </summary>
		public string DictqcLotid
		{
			get { return _dictqcLotid;}
			set { _dictqcLotid = value;}
		}                                    
		
		/// <summary>
		/// 批号
		/// </summary>
		public string LotNum
		{
			get { return _lotNum;}
			set { _lotNum = value;}
		}                                    
		
		/// <summary>
		/// 质控水平ID，系统内码
		/// </summary>
		public string DictqcControlid
		{
			get { return _dictqcControlid;}
			set { _dictqcControlid = value;}
		}                                    
		
		/// <summary>
		/// QC条码号
		/// </summary>
		public string QcBarcode
		{
			get { return _qcBarcode;}
			set { _qcBarcode = value;}
		}                                    
		
		/// <summary>
		/// 生效日期
		/// </summary>
		public DateTime ActiveDate
		{
			get { return _activeDate;}
			set { _activeDate = value;}
		}                                    
		
		/// <summary>
		/// 失效日期
		/// </summary>
		public DateTime ExpiryDate
		{
			get { return _expiryDate;}
			set { _expiryDate = value;}
		}                                    
		
		/// <summary>
		/// QC试剂厂商ID
		/// </summary>
		public string DictManufactureid
		{
			get { return _dictManufactureid;}
			set { _dictManufactureid = value;}
		}                                    
		
		/// <summary>
		/// 操作者
		/// </summary>
		public int OperateBy
		{
			get { return _operateBy;}
			set { _operateBy = value;}
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
		/// 仪器ID，系统内码
		/// </summary>
		public string DictInstrumentID
		{
			get { return _dictInstrumentID;}
			set { _dictInstrumentID = value;}
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


