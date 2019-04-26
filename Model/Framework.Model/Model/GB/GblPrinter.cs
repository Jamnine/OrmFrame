

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 报表打印机设置 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblPrinter : BaseModel
    {   
		
		
		
		private string _hostname;  //机器名
		
		private string _reportName;  //打印机名
		
		private string _printerName;  //打印机名
		
		private string _spec;  //F1纸张规格
		
		private int _topMargin;  //F2上边距
		
		private int _leftMargin;  //F3左边距
		
		private int _orientation;  //F4横向纵向
		
		private int _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private double _isTwoSided;  //行心云:是否双面打印
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 唯一标识
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 机器名
		/// </summary>
		public string Hostname
		{
			get { return _hostname;}
			set { _hostname = value;}
		}                                    
		
		/// <summary>
		/// 打印机名
		/// </summary>
		public string ReportName
		{
			get { return _reportName;}
			set { _reportName = value;}
		}                                    
		
		/// <summary>
		/// 打印机名
		/// </summary>
		public string PrinterName
		{
			get { return _printerName;}
			set { _printerName = value;}
		}                                    
		
		/// <summary>
		/// F1纸张规格
		/// </summary>
		public string Spec
		{
			get { return _spec;}
			set { _spec = value;}
		}                                    
		
		/// <summary>
		/// F2上边距
		/// </summary>
		public int TopMargin
		{
			get { return _topMargin;}
			set { _topMargin = value;}
		}                                    
		
		/// <summary>
		/// F3左边距
		/// </summary>
		public int LeftMargin
		{
			get { return _leftMargin;}
			set { _leftMargin = value;}
		}                                    
		
		/// <summary>
		/// F4横向纵向
		/// </summary>
		public int Orientation
		{
			get { return _orientation;}
			set { _orientation = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public int ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		
		/// <summary>
		/// 行心云:是否双面打印
		/// </summary>
		public double IsTwoSided
		{
			get { return _isTwoSided;}
			set { _isTwoSided = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


