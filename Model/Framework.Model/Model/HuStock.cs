

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库入库单 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuStock:BaseModel
	{    
		private string _billNo;  //单据号
		
		private string _houseId;  //药库ID
		
		private string _compId;  //医药公司ID
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private bool _isSign;  //是否已审核：0:未审核,1:已审核

        private bool _isInterface;

        public string _interfaceBillNo;


        private DateTime _signTime;  //审核日期
		
		private string _signOperId;  //审核人ID
		
		private bool _isBack;  //是否已退
		
		private string _memo;  //方式备注
		
		private string _buyId;  //
		
		private string _buyWayId;  //
		
		private int _applicant;  //申请人
		
		private int _application;  //申请科室
		
		private string _qcMemo;  //质量说明
		
		private double _amount;  //金额
		
		private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //

        /// <summary>
        /// 单据号
        /// </summary>
        public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 药库ID
		/// </summary>
		public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
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
		/// 是否已审核：0:未审核,1:已审核
		/// </summary>
		public bool IsSign
		{
			get { return _isSign;}
			set { _isSign = value;}
		}

        /// <summary>
        /// 是否已审核：0:不是,1:是
        /// </summary>
        public bool IsInterface
        {
            get { return _isInterface; }
            set { _isInterface = value; }
        }

        /// <summary>
        /// 是否已审核：0:不是,1:是
        /// </summary>
        public string InterfaceBillNo
        {
            get { return _interfaceBillNo; }
            set { _interfaceBillNo = value; }
        }

        /// <summary>
        /// 审核日期
        /// </summary>
        public DateTime SignTime
		{
			get { return _signTime;}
			set { _signTime = value;}
		}                                    
		
		/// <summary>
		/// 审核人ID
		/// </summary>
		public string SignOperId
		{
			get { return _signOperId;}
			set { _signOperId = value;}
		}                                    
		
		/// <summary>
		/// 是否已退
		/// </summary>
		public bool IsBack
		{
			get { return _isBack;}
			set { _isBack = value;}
		}                                    
		
		/// <summary>
		/// 方式备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string BuyId
		{
			get { return _buyId;}
			set { _buyId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string BuyWayId
		{
			get { return _buyWayId;}
			set { _buyWayId = value;}
		}                                    
		
		/// <summary>
		/// 申请人
		/// </summary>
		public int Applicant
		{
			get { return _applicant;}
			set { _applicant = value;}
		}                                    
		
		/// <summary>
		/// 申请科室
		/// </summary>
		public int Application
		{
			get { return _application;}
			set { _application = value;}
		}                                    
		
		/// <summary>
		/// 质量说明
		/// </summary>
		public string QcMemo
		{
			get { return _qcMemo;}
			set { _qcMemo = value;}
		}                                    
		
		/// <summary>
		/// 金额
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}

        private string _billNo2;
        /// <summary>
        /// 序号
        /// </summary>
        public string BillNo2
        {
            get { return _billNo2; }
            set { _billNo2 = value; }
        }

        private string _billMan;
        /// <summary>
        /// 制单人.
        /// </summary>
        public string BillMan
        {
            get
            {
                return this._billMan;
            }
            set
            {
                this._billMan = value;
            }
        }


    }  
}           


