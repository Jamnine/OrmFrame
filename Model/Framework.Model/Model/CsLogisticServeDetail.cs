

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class CsLogisticServeDetail : BaseModel
    {   
		 
		private DateTime _serveDate;  //服务时间
		
		private string _abstract;  //摘要
		
		private string _logisticServeId;  //
		
		private string _benefitLocId;  //受益科室
		
		private string _serveLocId;  //服务科室
		
		private double _totality;  //数量
		
		private double _equivalent;  //当量
		
		private string _serveNo;  //服务单号
		
		private string _operId;  //
		
		private bool _isAcctMark;  //月结标志
		
		private bool _isAuthed;  //是否封存
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 服务时间
		/// </summary>
		public DateTime ServeDate
		{
			get { return _serveDate;}
			set { _serveDate = value;}
		}                                    
		
		/// <summary>
		/// 摘要
		/// </summary>
		public string Abstract
		{
			get { return _abstract;}
			set { _abstract = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string LogisticServeId
		{
			get { return _logisticServeId;}
			set { _logisticServeId = value;}
		}                                    
		
		/// <summary>
		/// 受益科室
		/// </summary>
		public string BenefitLocId
		{
			get { return _benefitLocId;}
			set { _benefitLocId = value;}
		}                                    
		
		/// <summary>
		/// 服务科室
		/// </summary>
		public string ServeLocId
		{
			get { return _serveLocId;}
			set { _serveLocId = value;}
		}                                    
		
		/// <summary>
		/// 数量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 当量
		/// </summary>
		public double Equivalent
		{
			get { return _equivalent;}
			set { _equivalent = value;}
		}                                    
		
		/// <summary>
		/// 服务单号
		/// </summary>
		public string ServeNo
		{
			get { return _serveNo;}
			set { _serveNo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 月结标志
		/// </summary>
		public bool IsAcctMark
		{
			get { return _isAcctMark;}
			set { _isAcctMark = value;}
		}                                    
		
		/// <summary>
		/// 是否封存
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
	                                  
		        
	}  
}           


