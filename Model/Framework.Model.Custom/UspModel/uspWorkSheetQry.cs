using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 加工单信息
    /// </summary>
    [Serializable]
    public class uspWorkSheetQry : BaseModel
    {

        private string _toothPosition;
        private string _processingFactory;
        private string _salesMan;
        private string _orderType;
        private string _restoration;
        private string  _colorimetric;
        private double _amount = 1;
        private int _repairType;
        private string _billNo = string.Empty;
        private string _doctorId;
        private double _priceIn;
        private DateTime _sendTime = DateTime.Now;
        private string _emergencyType;
        private DateTime _finishTime = DateTime.Now;
        private DateTime _tryoutTime = DateTime.Now;
        private string _memo;
        private int _attachment;
        private string _patId;
        private DateTime _operTime;
        private string _operId;
        private DateTime _modiOperTime;
        private string _modiOperId;
        private string  _workTypeId ;
        private double _price;
        private DateTime _noDoTime;
        private DateTime _doneTime;
        private DateTime _getOutime;
        private DateTime _wearTime;
        private DateTime _takeOutime;
        private DateTime _returnTime;

        private double _totality;


        /// <summary>
        /// 加工厂名
        /// </summary>
        public string ProcessingFactoryName { get; set; }
        /// <summary>
        /// 修复体名
        /// </summary>
        public string RestorationName { get; set; }
        /// <summary>
        /// 业务员名
        /// </summary>
        public string TmpEmrName { get; set; }
        /// <summary>
        /// 比色名
        /// </summary>
        public string ColorimetricName { get; set; }

        /// <summary>
        /// 紧急程度名
        /// </summary>
        public string EmergencyTypeName { get; set; }
        /// <summary>
        /// 订单类型名
        /// </summary>
        public string OrderTypeName { get; set; }


        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public uspWorkSheetQry()
        {
        }


        [Collumn(HeaderName = "下单日期", RelatedTableType = null)]
        /// <summary>
        /// 下单日期
        /// </summary>
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }

        [Collumn(HeaderName = "下单人", RelatedTableType = typeof(BsUser))]
        /// <summary>
        /// 下单人
        /// </summary>
        public string OperId
        {
            get { return this._operId; }
            set { this._operId = value; }
        }


        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModiOperTime
        {
            get { return this._modiOperTime; }
            set { this._modiOperTime = value; }
        }


        /// <summary>
        /// 下单人
        /// </summary>
        public string ModiOperId
        {
            get { return this._modiOperId; }
            set { this._modiOperId = value; }
        }
        /// <summary>
        /// 工种ID
        /// </summary>
        public string  WorkTypeId
        {
            get { return this._workTypeId; }
            set { this._workTypeId = value; }
        }

        [Collumn(HeaderName = "牙位", RelatedTableType = null)]
        /// <summary>
        /// 牙位.
        /// </summary>
        public string ToothPosition
        {
            get { return this._toothPosition; }
            set { this._toothPosition = value; }
        }
        [Collumn(HeaderName = "加工厂", RelatedTableType = typeof(BsCompany))]
        /// <summary>
        /// 加工厂.
        /// </summary>
        public string ProcessingFactory
        {
            get { return this._processingFactory; }
            set { this._processingFactory = value; }
        }
        [Collumn(HeaderName = "业务员", RelatedTableType = typeof(TmpEmr))]
        /// <summary>
        /// 业务员.
        /// </summary>
        public string SalesMan
        {
            get { return this._salesMan; }
            set { this._salesMan = value; }
        }
        [Collumn(HeaderName = "订单类型", RelatedTableType = typeof(BsOrderType))]
        /// <summary>
        /// 订单类型. id
        /// </summary>
        public string OrderType
        {
            get { return this._orderType; }
            set { this._orderType = value; }
        }
        [Collumn(HeaderName = "修复体", RelatedTableType = typeof(BsRestoration))]
        /// <summary>
        /// 修复体.
        /// </summary>
        public string Restoration
        {
            get { return this._restoration; }
            set { this._restoration = value; }
        }
        [Collumn(HeaderName = "比色", RelatedTableType = null)]
        /// <summary>
        /// 比色.
        /// </summary>
        public string  Colorimetric
        {
            get { return this._colorimetric; }
            set { this._colorimetric = value; }
        }
        [Collumn(HeaderName = "费用", RelatedTableType = null)]
        /// <summary>
        /// 费用.
        /// </summary>
        public double Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }
        [Collumn(HeaderName = "保修期", RelatedTableType = null)]
        /// <summary>
        /// 保修期.
        /// </summary>
        public int RepairType
        {
            get { return this._repairType; }
            set { this._repairType = value; }
        }
        [Collumn(HeaderName = "附件", RelatedTableType = null, LstType = "1:旧牙|2:咬合蜡|3:原摸|4:照片|5:数据")]
        /// <summary>
        /// 附件 1:旧牙|2:咬合蜡|3:原摸|4:照片|5:数据
        /// </summary>
        public int Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }
        [Collumn(HeaderName = "单号", RelatedTableType = null)]
        /// <summary>
        /// 单号.
        /// </summary>
        public string BillNo
        {
            get { return this._billNo; }
            set { this._billNo = value; }
        }
        [Collumn(HeaderName = "医生", RelatedTableType = typeof(BsUser))]
        /// <summary>
        /// 医生Id.
        /// </summary>
        public string DoctorId
        {
            get { return this._doctorId; }
            set { this._doctorId = value; }
        }

        [Collumn(HeaderName = "加工单价", RelatedTableType = null)]
        /// <summary>
        /// 加工单价
        /// </summary>
        public double Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        [Collumn(HeaderName = " 价格", RelatedTableType = null)]
        /// <summary>
        /// 价格.
        /// </summary>
        public double PriceIn
        {
            get { return this._priceIn; }
            set { this._priceIn = value; }
        }
        [Collumn(HeaderName = "送件日期", RelatedTableType = null)]
        /// <summary>
        /// 送件日期.
        /// </summary>
        public DateTime SendTime
        {
            get { return this._sendTime; }
            set { this._sendTime = value; }
        }
        [Collumn(HeaderName = "紧急程度", RelatedTableType = null, LstType = "1:急件|2:5天件|3:7天件")]
        /// <summary>
        /// 紧急程度.1:急件|2:5天件|3:7天件
        /// </summary>
        public string EmergencyType
        {
            get { return this._emergencyType; }
            set { this._emergencyType = value; }
        }

        [Collumn(HeaderName = "完成时间", RelatedTableType = null)]
        /// <summary>
        /// 完成时间.
        /// </summary>
        public DateTime FinishTime
        {
            get { return this._finishTime; }
            set { this._finishTime = value; }
        }
        [Collumn(HeaderName = "试代日期", RelatedTableType = null)]
        /// <summary>
        /// 试代日期.
        /// </summary>
        public DateTime TryoutTime
        {
            get { return this._tryoutTime; }
            set { this._tryoutTime = value; }
        }
        [Collumn(HeaderName = "备注", IsShow = false, RelatedTableType = null)]
        /// <summary>
        /// 备注.
        /// </summary>
        public string Memo
        {
            get { return this._memo; }
            set { this._memo = value; }
        }

        [Collumn(HeaderName = "患者", RelatedTableType = typeof(BsPatient))]
        /// <summary>
        /// 患者id.
        /// </summary>
        public string PatId
        {
            get { return this._patId; }
            set { this._patId = value; }
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
        /// 已完工
        /// </summary>
        public DateTime DoneTime
        {
            get { return this._doneTime; }
            set { this._doneTime = value; }
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
        /// 试戴
        /// </summary>
        public DateTime WearTime
        {
            get { return this._wearTime; }
            set { this._wearTime = value; }
        }

        /// <summary>
        /// 已戴走
        /// </summary>
        public DateTime TakeOutime
        {
            get { return this._takeOutime; }
            set { this._takeOutime = value; }
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
        /// 医生名称
        /// </summary>
        public string DoctorName { get; set; }


        [Collumn(HeaderName = " 数量", RelatedTableType = null)]
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

        public string _mzRegId;
        /// <summary>
        /// 挂号类别ID
        /// </summary>
        public string MzRegId
        {
            get { return this._mzRegId; }
            set { this._mzRegId = value; }
        }


        public static implicit operator DateTime(uspWorkSheetQry v)
        {
            throw new NotImplementedException();
        }
    }
}
