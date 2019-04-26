

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院医保结算单据号记录 - 实体类
	/// </summary>
	[Serializable]
	public partial class YBChargeLog : BaseModel
	{    
		private string _ybReqNo;  //医保号
		
		private string _invoNo;  //发票号
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private string _mzRegId;  //门诊病人ID,Ouhosinfo.Id
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private DateTime _operTime;  //操作时间
		
		private bool _isCancel;  //是否作废
		
		private string _cancelOperId;  //作废人
		
		private DateTime _cancelOperTime;  //作废时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public YBChargeLog() { }

                                    
		
		/// <summary>
		/// 医保号
		/// </summary>
		public string YbReqNo
		{
			get { return _ybReqNo;}
			set { _ybReqNo = value;}
		}                                    
		
		/// <summary>
		/// 发票号
		/// </summary>
		public string InvoNo
		{
			get { return _invoNo;}
			set { _invoNo = value;}
		}                                    
		
		/// <summary>
		/// 住院病人对应InHosinfo.Id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 门诊病人ID,Ouhosinfo.Id
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 是否作废
		/// </summary>
		public bool IsCancel
		{
			get { return _isCancel;}
			set { _isCancel = value;}
		}                                    
		
		/// <summary>
		/// 作废人
		/// </summary>
		public string CancelOperId
		{
			get { return _cancelOperId;}
			set { _cancelOperId = value;}
		}                                    
		
		/// <summary>
		/// 作废时间
		/// </summary>
		public DateTime CancelOperTime
		{
			get { return _cancelOperTime;}
			set { _cancelOperTime = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 医院ID
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


