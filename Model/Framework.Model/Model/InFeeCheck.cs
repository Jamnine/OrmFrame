

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院费用审核 - 实体类
	/// </summary>
	[Serializable]
	public partial class InFeeCheck : BaseModel
    {   
		 
		private string _detailId;  //记帐表的费用ID
		
		private string _adviceId;  //医嘱id号
		
		private int _lsMarkType;  //费用来源：1-长期；2-临时；3-其他；4-床位；5-出院带药；6-医技；7-每天的执行项目记账；8-手术插帐；9-麻醉插帐；10-检验；11-中药
		
		private DateTime _operTime;  //登记日期时间
		
		private string _operId;  //申请人
		
		private bool _isSign;  //是否审核
		
		private string _userCode;  //用户编码
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InFeeCheck() { }
         
		/// <summary>
		/// 记帐表的费用ID
		/// </summary>
		public string DetailId
		{
			get { return _detailId;}
			set { _detailId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱id号
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
		}                                    
		
		/// <summary>
		/// 费用来源：1-长期；2-临时；3-其他；4-床位；5-出院带药；6-医技；7-每天的执行项目记账；8-手术插帐；9-麻醉插帐；10-检验；11-中药
		/// </summary>
		public int LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
		}                                    
		
		/// <summary>
		/// 登记日期时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 申请人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 是否审核
		/// </summary>
		public bool IsSign
		{
			get { return _isSign;}
			set { _isSign = value;}
		}                                    
		
		/// <summary>
		/// 用户编码
		/// </summary>
		public string UserCode
		{
			get { return _userCode;}
			set { _userCode = value;}
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


