using System;

namespace Orm.Model.Custom
{
    /// <summary>
    ///收费单据组合
    /// </summary>
    [Serializable]
   
    public partial class uspOuInvoiceQry : BaseModel
    {


        private string _invoNo;
        private string _mzRegId;
        private string _patId;
        private DateTime _invoTime;
        private double _beprice;
        private double _factGet;
        private double _insurance;
        private double _paySelf;
        private double _amountPay;
        private double _addFee;
        private string _tallyNo;
        private string _remark;
        private DateTime _operTime;
        private string _operId;
        private bool _isCancel;
        private DateTime _cancelOperTime;
        private string _cancelOperId;
        private string _cancelMemo;
        private string _invoLastId;
        private int _reAmount;
        private string _feeSubId;
        private string _reAmountMemo;
        private string _feeMainId;
        private string _patTypeId;
        private DateTime _reAmountDate;
        private DateTime _tallyTime;
        private DateTime _cancelTallyTime;
        private string _hospitalId;
        private string _ybIllId;
        private string _locationId;
        private string _doctorId;
        private DateTime _checkTime;
        private DateTime _cancelCheckTime;
        private string _hOSTName;
        private string _tallyOperId;
        private string _tallyCancelOperId;
        private string _yBRegNO;
        private string _arrearsTypeId;
        private string _doctorName = String.Empty;
        private string _patientName = String.Empty;
        private double _accountAmount;


        public string LocationName { get; set; }

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public uspOuInvoiceQry()
        {
        }

        /// <summary>
        /// 收款方式（可能多个）
        /// </summary>
        public string PayWays { get; set; }
      
        /// <summary>
        /// 收款人姓名
        /// </summary>
        public string OperName { get; set; }
     
        /// <summary>
        /// 护士姓名
        /// </summary>
        public string NurseName { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 发票号码.
        /// </summary>
        public string InvoNo
        {
            get
            {
                return this._invoNo;
            }
            set
            {
                this._invoNo = value;
            }
        }

        /// <summary>
        /// 门诊流水号。外键，引用OuHosInfo.GUID.
        /// </summary>
        public string MzRegId
        {
            get
            {
                return this._mzRegId;
            }
            set
            {
                this._mzRegId = value;
            }
        }

        /// <summary>
        /// 病人ID，对应于Patient的Pat_Id.
        /// </summary>
        public string PatId
        {
            get
            {
                return this._patId;
            }
            set
            {
                this._patId = value;
            }
        }

        /// <summary>
        /// 发票时间。外键，引用Bspatient.GUID.
        /// </summary>
        public DateTime InvoTime
        {
            get
            {
                return this._invoTime;
            }
            set
            {
                this._invoTime = value;
            }
        }

        /// <summary>
        /// 应结算金额（总金额）.
        /// </summary>
        public double Beprice
        {
            get
            {
                return this._beprice;
            }
            set
            {
                this._beprice = value;
            }
        }

        /// <summary>
        /// 自付金额（乘以DiscSelf前的金额）.
        /// </summary>
        public double FactGet
        {
            get
            {
                return this._factGet;
            }
            set
            {
                this._factGet = value;
            }
        }

        /// <summary>
        /// 医保/公医记帐金额.
        /// </summary>
        public double Insurance
        {
            get
            {
                return this._insurance;
            }
            set
            {
                this._insurance = value;
            }
        }

        /// <summary>
        /// 个人缴费金额.
        /// </summary>
        public double PaySelf
        {
            get
            {
                return this._paySelf;
            }
            set
            {
                this._paySelf = value;
            }
        }

        /// <summary>
        /// 应交金额（乘以DiscSelf后的金额）.
        /// </summary>
        public double AmountPay
        {
            get
            {
                return this._amountPay;
            }
            set
            {
                this._amountPay = value;
            }
        }

        /// <summary>
        /// 凑整费.
        /// </summary>
        public double AddFee
        {
            get
            {
                return this._addFee;
            }
            set
            {
                this._addFee = value;
            }
        }

        /// <summary>
        /// 公费记帐单号.
        /// </summary>
        public string TallyNo
        {
            get
            {
                return this._tallyNo;
            }
            set
            {
                this._tallyNo = value;
            }
        }

        /// <summary>
        /// 退款备注.
        /// </summary>
        public string Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                this._remark = value;
            }
        }

        /// <summary>
        /// 登记时间.
        /// </summary>
        public DateTime OperTime
        {
            get
            {
                return this._operTime;
            }
            set
            {
                this._operTime = value;
            }
        }

        /// <summary>
        /// 登记人.
        /// </summary>
        public string OperId
        {
            get
            {
                return this._operId;
            }
            set
            {
                this._operId = value;
            }
        }

        /// <summary>
        /// 是否注销.
        /// </summary>
        public bool IsCancel
        {
            get
            {
                return this._isCancel;
            }
            set
            {
                this._isCancel = value;
            }
        }

        /// <summary>
        /// 注销日期.
        /// </summary>
        public DateTime CancelOperTime
        {
            get
            {
                return this._cancelOperTime;
            }
            set
            {
                this._cancelOperTime = value;
            }
        }

        /// <summary>
        /// 收费操作员.
        /// </summary>
        public string CancelOperId
        {
            get
            {
                return this._cancelOperId;
            }
            set
            {
                this._cancelOperId = value;
            }
        }

        /// <summary>
        /// 退款备注.
        /// </summary>
        public string CancelMemo
        {
            get
            {
                return this._cancelMemo;
            }
            set
            {
                this._cancelMemo = value;
            }
        }

        /// <summary>
        /// 退费的原发票。外键，引用OuInvoice.GUID.
        /// </summary>
        public string InvoLastId
        {
            get
            {
                return this._invoLastId;
            }
            set
            {
                this._invoLastId = value;
            }
        }


       

      
      

        
      

        /// <summary>
        /// 分院ID.
        /// </summary>
        public string HospitalId
        {
            get
            {
                return this._hospitalId;
            }
            set
            {
                this._hospitalId = value;
            }
        }

        /// <summary>
        /// 特殊病种ID.
        /// </summary>
        public string YbIllId
        {
            get
            {
                return this._ybIllId;
            }
            set
            {
                this._ybIllId = value;
            }
        }

        /// <summary>
        /// 诊所id
        /// </summary>
        public string LocationId
        {
            get
            {
                return this._locationId;
            }
            set
            {
                this._locationId = value;
            }
        }

        /// <summary>
        /// 医生ID
        /// </summary>
        public string DoctorId
        {
            get
            {
                return this._doctorId;
            }
            set
            {
                this._doctorId = value;
            }
        }

        /// <summary>
        /// 结账时间.
        /// </summary>
        public DateTime CheckTime
        {
            get
            {
                return this._checkTime;
            }
            set
            {
                this._checkTime = value;
            }
        }

        /// <summary>
        /// 作废时间.
        /// </summary>
        public DateTime CancelCheckTime
        {
            get
            {
                return this._cancelCheckTime;
            }
            set
            {
                this._cancelCheckTime = value;
            }
        }

        /// <summary>
        /// F1上传工作站.
        /// </summary>
        public string HOSTName
        {
            get
            {
                return this._hOSTName;
            }
            set
            {
                this._hOSTName = value;
            }
        }

        /// <summary>
        /// 记账人.
        /// </summary>
        public string TallyOperId
        {
            get
            {
                return this._tallyOperId;
            }
            set
            {
                this._tallyOperId = value;
            }
        }

        /// <summary>
        /// 取消记账人.
        /// </summary>
        public string TallyCancelOperId
        {
            get
            {
                return this._tallyCancelOperId;
            }
            set
            {
                this._tallyCancelOperId = value;
            }
        }

        /// <summary>
        /// F7医保流水号.
        /// </summary>
        public string YBRegNO
        {
            get
            {
                return this._yBRegNO;
            }
            set
            {
                this._yBRegNO = value;
            }
        }
        /// <summary>
        /// 用于记录是中药房发药还是西药房发药
        /// </summary>
        public string IsRecord { get; set; }

        /// <summary>
        /// 优惠活动
        /// </summary>
        public string ScaleID { get; set; }
        /// <summary>
        /// 整单折扣
        /// </summary>
        public double DiscountNum { get; set; }
        /// <summary>
        /// 本次欠款
        /// </summary>
        public double CurrentArrears { get; set; }

        /// <summary>
        /// 是否打印
        /// </summary>
        public bool IsPrintInvoice { get; set; }

        /// <summary>
        /// 医生
        /// </summary>
        public string DoctorName
        {
            get
            {
                return this._doctorName;
            }
            set
            {
                this._doctorName = value;
            }
        }

        /// <summary>
        /// 病人名称
        /// </summary>
        public string PatientName
        {
            get
            {
                return this._patientName;
            }
            set
            {
                this._patientName = value;
            }
        }
        /// <summary>
        /// 退费分类
        /// </summary>
        public string ArrearsTypeId 
        {
            get
            {
                return this._arrearsTypeId;
            }
            set
            {
                this._arrearsTypeId = value;
            }
        }
        /// <summary>
        /// 记账金额
        /// </summary>
        public double AccountAmount
        {
            get
            {
                return this._accountAmount;
            }
            set
            {
                this._accountAmount = value;
            }
        }

        /// <summary>
        /// 本次费用
        /// </summary>
        public double CurrentPay { get; set; }
        /// <summary>
        /// 上次欠款
        /// </summary>
        public double PreviousArrears { get; set; }

        public bool  IsHideIllness { get; set; }
        /// <summary>
        /// 是否记账
        /// </summary>
        public bool IsTally { get; set; }
        /// <summary>
        /// 是否已审查
        /// </summary>
        public bool IsVerify { get; set; }
        /// <summary>
        /// 是否收费
        /// </summary>
        public bool IsCharge { get; set; }
        /// <summary>
        /// 行总数
        /// </summary>
        public int RowCount { get; set; }
        
    }
}



