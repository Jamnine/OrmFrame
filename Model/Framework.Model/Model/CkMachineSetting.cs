

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class CkMachineSetting :BaseModel
	{   
		 
		private string _initLocalSettingid;  //本地参数ID，系统内码
		
		private string _cpuid;  //
		
		private string _mac;  //网卡的MAC地址
		
		private string _ip;  //IP地址
		
		private string _hostName;  //主机名
		
		private string _dictLocationid;  //科室ID，系统内码
		
		private string _labelPrinter;  //条码打印机
		
		private string _dictInstrumentid1;  //仪器ID，系统内码
		
		private string _reportPrintera5;  //A5报告打印机
		
		private string _dictInstrumentid2;  //仪器ID2，系统内码"
		
		private string _dictInstrumentid3;  //仪器ID3，系统内码
		
		private string _dictInstrumentid4;  //仪器ID4，系统内码
		
		private string _dictInstrumentid5;  //仪器ID5，系统内码
		
		private string _dictInstrumentid6;  //仪器ID6，系统内码
		
		private string _dictInstrumentid7;  //仪器ID7，系统内码
		
		private string _reportPrintera4;  //A4报告打印机
		
		private string _reportPrinterNeedle;  //针式打印机
		
		private string _specimenType;  //样本类型
		
		private string _remark;  //备注
		
		private bool _isChanged;  //
		
		private bool _isDeleted;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 本地参数ID，系统内码
		/// </summary>
		public string InitLocalSettingid
		{
			get { return _initLocalSettingid;}
			set { _initLocalSettingid = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Cpuid
		{
			get { return _cpuid;}
			set { _cpuid = value;}
		}                                    
		
		/// <summary>
		/// 网卡的MAC地址
		/// </summary>
		public string Mac
		{
			get { return _mac;}
			set { _mac = value;}
		}                                    
		
		/// <summary>
		/// IP地址
		/// </summary>
		public string Ip
		{
			get { return _ip;}
			set { _ip = value;}
		}                                    
		
		/// <summary>
		/// 主机名
		/// </summary>
		public string HostName
		{
			get { return _hostName;}
			set { _hostName = value;}
		}                                    
		
		/// <summary>
		/// 科室ID，系统内码
		/// </summary>
		public string DictLocationid
		{
			get { return _dictLocationid;}
			set { _dictLocationid = value;}
		}                                    
		
		/// <summary>
		/// 条码打印机
		/// </summary>
		public string LabelPrinter
		{
			get { return _labelPrinter;}
			set { _labelPrinter = value;}
		}                                    
		
		/// <summary>
		/// 仪器ID，系统内码
		/// </summary>
		public string DictInstrumentid1
		{
			get { return _dictInstrumentid1;}
			set { _dictInstrumentid1 = value;}
		}                                    
		
		/// <summary>
		/// A5报告打印机
		/// </summary>
		public string ReportPrintera5
		{
			get { return _reportPrintera5;}
			set { _reportPrintera5 = value;}
		}                                    
		
		/// <summary>
		/// 仪器ID2，系统内码"
		/// </summary>
		public string DictInstrumentid2
		{
			get { return _dictInstrumentid2;}
			set { _dictInstrumentid2 = value;}
		}                                    
		
		/// <summary>
		/// 仪器ID3，系统内码
		/// </summary>
		public string DictInstrumentid3
		{
			get { return _dictInstrumentid3;}
			set { _dictInstrumentid3 = value;}
		}                                    
		
		/// <summary>
		/// 仪器ID4，系统内码
		/// </summary>
		public string DictInstrumentid4
		{
			get { return _dictInstrumentid4;}
			set { _dictInstrumentid4 = value;}
		}                                    
		
		/// <summary>
		/// 仪器ID5，系统内码
		/// </summary>
		public string DictInstrumentid5
		{
			get { return _dictInstrumentid5;}
			set { _dictInstrumentid5 = value;}
		}                                    
		
		/// <summary>
		/// 仪器ID6，系统内码
		/// </summary>
		public string DictInstrumentid6
		{
			get { return _dictInstrumentid6;}
			set { _dictInstrumentid6 = value;}
		}                                    
		
		/// <summary>
		/// 仪器ID7，系统内码
		/// </summary>
		public string DictInstrumentid7
		{
			get { return _dictInstrumentid7;}
			set { _dictInstrumentid7 = value;}
		}                                    
		
		/// <summary>
		/// A4报告打印机
		/// </summary>
		public string ReportPrintera4
		{
			get { return _reportPrintera4;}
			set { _reportPrintera4 = value;}
		}                                    
		
		/// <summary>
		/// 针式打印机
		/// </summary>
		public string ReportPrinterNeedle
		{
			get { return _reportPrinterNeedle;}
			set { _reportPrinterNeedle = value;}
		}                                    
		
		/// <summary>
		/// 样本类型
		/// </summary>
		public string SpecimenType
		{
			get { return _specimenType;}
			set { _specimenType = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			get { return _remark;}
			set { _remark = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsChanged
		{
			get { return _isChanged;}
			set { _isChanged = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsDeleted
		{
			get { return _isDeleted;}
			set { _isDeleted = value;}
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


