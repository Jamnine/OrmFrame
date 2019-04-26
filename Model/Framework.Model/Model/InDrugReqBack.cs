

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院退药申请明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class InDrugReqBack : BaseModel
    {    
		
		private string _reqDtlId;  //对应的领药申请明细ID
		
		private int _listNum;  //序号
		
		private double _totality;  //退药数量
		
		private string _unitId;  //单位
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private bool _isBack;  //药房是否已经确认退药
		
		private string _detailId;  //记帐表的费用ID
		
		private DateTime _backTime;  //退药日期
		
		private string _adviceId;  //医嘱号，对应医嘱表
		
		private int _lsMarkType;  //医嘱类别：1-长期；2-临时；3-其他
		
		private bool _isPrint;  //是否打印
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private string _requestId;  //申请单Id,InDrugReq.id
		
		private string _memo;  //备注
		
		private string _backOperId;  //退药人对应BsUser.Id
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InDrugReqBack() { }
         
		/// <summary>
		/// 对应的领药申请明细ID
		/// </summary>
		public string ReqDtlId
		{
			get { return _reqDtlId;}
			set { _reqDtlId = value;}
		}                                    
		
		/// <summary>
		/// 序号
		/// </summary>
		public int ListNum
		{
			get { return _listNum;}
			set { _listNum = value;}
		}                                    
		
		/// <summary>
		/// 退药数量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
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
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 药房是否已经确认退药
		/// </summary>
		public bool IsBack
		{
			get { return _isBack;}
			set { _isBack = value;}
		}                                    
		
		/// <summary>
		/// 记帐表的费用ID
		/// </summary>
		public string DetailId
		{
			get { return _detailId;}
			set { _detailId = value;}
		}                                    
		
		/// <summary>
		/// 退药日期
		/// </summary>
		public DateTime BackTime
		{
			get { return _backTime;}
			set { _backTime = value;}
		}                                    
		
		/// <summary>
		/// 医嘱号，对应医嘱表
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱类别：1-长期；2-临时；3-其他
		/// </summary>
		public int LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
		}                                    
		
		/// <summary>
		/// 是否打印
		/// </summary>
		public bool IsPrint
		{
			get { return _isPrint;}
			set { _isPrint = value;}
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
		/// 申请单Id,InDrugReq.id
		/// </summary>
		public string RequestId
		{
			get { return _requestId;}
			set { _requestId = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 退药人对应BsUser.Id
		/// </summary>
		public string BackOperId
		{
			get { return _backOperId;}
			set { _backOperId = value;}
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
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


