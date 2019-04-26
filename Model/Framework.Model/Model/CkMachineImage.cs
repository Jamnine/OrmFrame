

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
    public partial class CkMachineImage : BaseModel
	{   
		 
		private string _labID;  //
		
		private string _sampleNum;  //
		
		private string _machineID;  //
		
		private byte[] _labImage;  //
		
		private string _imageType;  //
		
		private bool _isDisplay;  //
		
		private int _orderBy;  //
		
		private string _instrmentSeqID;  //
		
		private int _displayOrder;  //
		
		private bool _isReport;  //
		
		private DateTime _createDate;  //
		
		private byte[] _imageBin;  //
		
		private string _imageId;  //
		
		private string _seq;  //
		
		private string _imageDotValue;  //
		
		private string _filepath;  //
		
		private string _instrumentSeqID;  //
		
		private string _batchNo;  //
		
		private string _barcode;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 
		/// </summary>
		public string LabID
		{
			get { return _labID;}
			set { _labID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string SampleNum
		{
			get { return _sampleNum;}
			set { _sampleNum = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string MachineID
		{
			get { return _machineID;}
			set { _machineID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public byte[] LabImage
		{
			get { return _labImage;}
			set { _labImage = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ImageType
		{
			get { return _imageType;}
			set { _imageType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsDisplay
		{
			get { return _isDisplay;}
			set { _isDisplay = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string InstrmentSeqID
		{
			get { return _instrmentSeqID;}
			set { _instrmentSeqID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int DisplayOrder
		{
			get { return _displayOrder;}
			set { _displayOrder = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsReport
		{
			get { return _isReport;}
			set { _isReport = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate
		{
			get { return _createDate;}
			set { _createDate = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public byte[] ImageBin
		{
			get { return _imageBin;}
			set { _imageBin = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ImageId
		{
			get { return _imageId;}
			set { _imageId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Seq
		{
			get { return _seq;}
			set { _seq = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ImageDotValue
		{
			get { return _imageDotValue;}
			set { _imageDotValue = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Filepath
		{
			get { return _filepath;}
			set { _filepath = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string InstrumentSeqID
		{
			get { return _instrumentSeqID;}
			set { _instrumentSeqID = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string BatchNo
		{
			get { return _batchNo;}
			set { _batchNo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Barcode
		{
			get { return _barcode;}
			set { _barcode = value;}
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


