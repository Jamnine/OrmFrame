

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库采购申请单 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuStockReq:BaseModel
	{   
		
		private string _billNo;  //单据流水号
		
		private string _houseId;  //药库Id,BsHouse.Id
		
		private DateTime _applyTime;  //申请时间
		
		private DateTime _valideTime;  //有效期至
		
		private string _applyIdea;  //申请意见
		
		private string _applyHander;  //
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private DateTime _operTime;  //操作时间
		
		private string _compId;  //医药公司ID
		
		private int _isAuthed;  //已经封存，不可改删
		
		private DateTime _logoperTime;  //行心云:物流确认时间
		
		private string _logoperId;  //行心云:物流确认人
		
		private int  _status;  //行心云:计划状态
		
		private string _patId;  //行心云:客人ID
		
		private string _mzregId;  //行心云:门诊ID
		
		private int _pageNumber;  //行心云:F1单据页数
		
		private int _HospitalID;  //

        public HuStockReq() { }
                                     
		
		/// <summary>
		/// 单据流水号
		/// </summary>
		public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 药库Id,BsHouse.Id
		/// </summary>
		public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
		}                                    
		
		/// <summary>
		/// 申请时间
		/// </summary>
		public DateTime ApplyTime
		{
			get { return _applyTime;}
			set { _applyTime = value;}
		}                                    
		
		/// <summary>
		/// 有效期至
		/// </summary>
		public DateTime ValideTime
		{
			get { return _valideTime;}
			set { _valideTime = value;}
		}                                    
		
		/// <summary>
		/// 申请意见
		/// </summary>
		public string ApplyIdea
		{
			get { return _applyIdea;}
			set { _applyIdea = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ApplyHander
		{
			get { return _applyHander;}
			set { _applyHander = value;}
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
		/// 医药公司ID
		/// </summary>
		public string CompId
		{
			get { return _compId;}
			set { _compId = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public int IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 行心云:物流确认时间
		/// </summary>
		public DateTime LogoperTime
		{
			get { return _logoperTime;}
			set { _logoperTime = value;}
		}                                    
		
		/// <summary>
		/// 行心云:物流确认人
		/// </summary>
		public string LogoperId
		{
			get { return _logoperId;}
			set { _logoperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:计划状态
		/// </summary>
		public int   Status
		{
			get { return _status;}
			set { _status = value;}
		}                                    
		
		/// <summary>
		/// 行心云:客人ID
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:门诊ID
		/// </summary>
		public string MzregId
		{
			get { return _mzregId;}
			set { _mzregId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:F1单据页数
		/// </summary>
		public int PageNumber
		{
			get { return _pageNumber;}
			set { _pageNumber = value;}
		}                                    
		

        private string _mzRegNo;
        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegNo
        {
            get { return _mzRegNo; }
            set { _mzRegNo = value; }
        }

    }  
}           


