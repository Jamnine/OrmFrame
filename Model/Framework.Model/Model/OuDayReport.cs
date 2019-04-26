

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊交款报表费用分类 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuDayReport : BaseModel
    {   
		 
		private string _rtpNo;  //发票号码
		
		private DateTime _operTime;  //登记时间
		
		private string _operId;  //登记人
		
		private string _remark;  //退款备注
		
		private double _beprice;  //应收金额（总金额）
		
		private double _factGet;  //实交金额
		
		private double _inArrear;  //欠款金额
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 发票号码
		/// </summary>
		public string RtpNo
		{
			get { return _rtpNo;}
			set { _rtpNo = value;}
		}                                    
		
		/// <summary>
		/// 登记时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 登记人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 退款备注
		/// </summary>
		public string Remark
		{
			get { return _remark;}
			set { _remark = value;}
		}                                    
		
		/// <summary>
		/// 应收金额（总金额）
		/// </summary>
		public double Beprice
		{
			get { return _beprice;}
			set { _beprice = value;}
		}                                    
		
		/// <summary>
		/// 实交金额
		/// </summary>
		public double FactGet
		{
			get { return _factGet;}
			set { _factGet = value;}
		}                                    
		
		/// <summary>
		/// 欠款金额
		/// </summary>
		public double InArrear
		{
			get { return _inArrear;}
			set { _inArrear = value;}
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


