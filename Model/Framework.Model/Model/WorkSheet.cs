

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云 ：加工单 - 实体类
	/// </summary>
	[Serializable]
	public partial class WorkSheet:BaseModel
	{   
		
	 
		
		private string _toothPosition;  //牙位
		
		private string _processingFactory;  //加工厂
		
		private string _salesMan;  //业务员
		
		private string _orderType;  //订单类型
		
		private string _restoration;  //修复体
		
		private string  _colorimetric;  //比色 id 
		
		private double _amount;  //金额
		
		private int _repairType;  //保修期
		
		private string _billNo;  //单号
		
		private string _doctorId;  //医生Id
		
		private double _priceIn;  //价格
		
		private DateTime _sendTime;  //送件日期
		
		private string _emergencyType;  //紧急程度
		
		private DateTime _finishTime;  //完成时间
		
		private DateTime _tryoutTime;  //试代日期
		
		private string _memo;  //备注
		
		private int _attachment;  //附件
		
		private string _patId;  //病人ID
		
		private DateTime _operTime;  //下单日期
		
		private string _operId;  //下单人
		
		private DateTime _modiOperTime;  //修改时间
		
		private string _modiOperId;  //修改人
      
        private DateTime _takeOutime;

        private DateTime _wearTime; // 试戴时间

        private DateTime _getOutime;  // 已取件时间

        private string _workTypeId; //工种ID

        private DateTime _noDoTime;

        private DateTime _returnTime; // 返工时间

        private double _totality;
        private int _HospitalID;//诊所id


        /// <summary>
        /// 牙位
        /// </summary>
        public string ToothPosition
		{
			get { return _toothPosition;}
			set { _toothPosition = value;}
		}                                    
		
		/// <summary>
		/// 加工厂 id 
		/// </summary>
		public string ProcessingFactory
		{
			get { return _processingFactory;}
			set { _processingFactory = value;}
		}                                    
		
		/// <summary>
		/// 业务员 id
		/// </summary>
		public string SalesMan
		{
			get { return _salesMan;}
			set { _salesMan = value;}
		}                                    
		
		/// <summary>
		/// 订单类型
		/// </summary>
		public string OrderType
		{
			get { return _orderType;}
			set { _orderType = value;}
		}                                    
		
		/// <summary>
		/// 修复体 ID 
		/// </summary>
		public string Restoration
		{
			get { return _restoration;}
			set { _restoration = value;}
		}                                    
		
		/// <summary>
		/// 比色   id 
		/// </summary>
		public string  Colorimetric
		{
			get { return _colorimetric;}
			set { _colorimetric = value;}
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
		/// 保修期
		/// </summary>
		public int RepairType
		{
			get { return _repairType;}
			set { _repairType = value;}
		}                                    
		
		/// <summary>
		/// 单号
		/// </summary>
		public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 医生Id
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 价格
		/// </summary>
		public double PriceIn
		{
			get { return _priceIn;}
			set { _priceIn = value;}
		}                                    
		
		/// <summary>
		/// 送件日期
		/// </summary>
		public DateTime SendTime
		{
			get { return _sendTime;}
			set { _sendTime = value;}
		}                                    
		
		/// <summary>
		/// 紧急程度
		/// </summary>
		public string EmergencyType
		{
			get { return _emergencyType;}
			set { _emergencyType = value;}
		}                                    
		
		/// <summary>
		/// 完成时间
		/// </summary>
		public DateTime FinishTime
		{
			get { return _finishTime;}
			set { _finishTime = value;}
		}                                    
		
		/// <summary>
		/// 试代日期
		/// </summary>
		public DateTime TryoutTime
		{
			get { return _tryoutTime;}
			set { _tryoutTime = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 附件
		/// </summary>
		public int Attachment
		{
			get { return _attachment;}
			set { _attachment = value;}
		}                                    
		
		/// <summary>
		/// 病人ID
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 下单日期
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 下单人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime ModiOperTime
		{
			get { return _modiOperTime;}
			set { _modiOperTime = value;}
		}                                    
		
		/// <summary>
		/// 修改人
		/// </summary>
		public string ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}

        /// <summary>
        /// 已戴走
        /// </summary>
        public DateTime TakeOutime
        {
            get { return this._takeOutime; }
            set { this._takeOutime = value; }
        }

        private double _price = 0.0;
        /// <summary>
        /// 单价
        /// </summary>
        public double Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        private DateTime _doneTime;

        /// <summary>
        /// 已完工
        /// </summary>
        public DateTime DoneTime
        {
            get { return this._doneTime; }
            set { this._doneTime = value; }
        }

        /// <summary>
        /// 试戴
        /// </summary>
        public DateTime WearTime
        {
            get { return this._wearTime; }
            set { this._wearTime = value; }
        }

        /// <summary>
        /// 未完工
        /// </summary>
        public DateTime NoDoTime
        {
            get { return _noDoTime; }
            set { this._noDoTime = value; }
        }
       

        /// <summary>
        /// 工种ID
        /// </summary>
        public string WorkTypeId
        {
            get { return this._workTypeId; }
            set { this._workTypeId = value; }
        }

        public string  _mzRegId;
        /// <summary>
        /// 挂号类别ID
        /// </summary>
        public string  MzRegId
        {
            get { return this._mzRegId; }
            set { this._mzRegId = value; }
        }

        /// <summary>
        /// 已取件
        /// </summary>
        public DateTime GetOutime
        {
            get { return this._getOutime; }
            set { this._getOutime = value; }
        }

        /// <summary>
        /// 返工
        /// </summary>
        public DateTime ReturnTime
        {
            get { return this._returnTime; }
            set { this._returnTime = value; }
        }

        /// <summary>
        /// 数量
        /// </summary>
        public double Totality
        {
            get
            {
                return _totality;
            }

            set
            {
                _totality = value;
            }
        }

   
    }
}           


