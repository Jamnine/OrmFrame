using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 病人收费情况列表信息
    /// </summary>
    [Serializable]
    public class uspChargeStatistics
    {
        private string _hasArrears = String.Empty;
        private string _invoNo = String.Empty;
        private string _invoId;
        private string _mzRegId;
        private string _patId;
        private string _patName = String.Empty;
        private double _preArrears;
        private double _amountPay;
        private double _shouldPay;
        private double _actuallyPay;
        private double _nowArrears;
        private string _payWayAmount;
        private string _payWayId;
        private string _payWayName = String.Empty;
        private string _operId;
        private string _operMan = String.Empty;
        private string _doctorId;
        private string _doctorName = String.Empty;
        private string _locationId;
        private string _locationName = String.Empty;
        private DateTime _operTime;
        private string _memo = String.Empty;
        private string _discount = String.Empty;
        private string _payWay = String.Empty;
        private string _doctorPhone = string.Empty;

        /// <summary>
        /// 病人收费情况列表信息
        /// </summary>
        public uspChargeStatistics()
        {

        }

        /// <summary>
        /// 是否欠费
        /// </summary>
        public string HasArrears
        {
            get { return _hasArrears; }
            set { _hasArrears = value; }
        }

        /// <summary>
        /// 发票号码
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
        /// 发票ID。外键，引用OuInvoice.GUID.
        /// </summary>
        public string InvoId
        {
            get
            {
                return this._invoId;
            }
            set
            {
                this._invoId = value;
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
        /// 打折.
        /// </summary>
        public string Discount
        {
            get
            {
                return this._discount;
            }
            set
            {
                this._discount = value;
            }
        }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName
        {
            get
            {
                return this._patName;
            }
            set
            {
                this._patName = value;
            }
        }

        /// <summary>
        /// 上次欠费
        /// </summary>
        public double PreArrears
        {
            get
            {
                return this._preArrears;
            }
            set
            {
                this._preArrears = value;
            }
        }

        /// <summary>
        /// 折后价
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
        /// 应收
        /// </summary>
        public double ShouldPay
        {
            get
            {
                return this._shouldPay;
            }
            set
            {
                this._shouldPay = value;
            }
        }

        /// <summary>
        /// 实收
        /// </summary>
        public double ActuallyPay
        {
            get
            {
                return this._actuallyPay;
            }
            set
            {
                this._actuallyPay = value;
            }
        }

        /// <summary>
        /// 本次欠费
        /// </summary>
        public double NowArrears
        {
            get
            {
                return this._nowArrears;
            }
            set
            {
                this._nowArrears = value;
            }
        }

        /// <summary>
        /// 不同支付方式对应的金额
        /// </summary>
        public string PayWayAmount
        {
            get { return this._payWayAmount; }
            set
            {
                this._payWayAmount = value;
            }
        }

        /// <summary>
        /// 支付方式ID
        /// </summary>
        public string PayWayId
        {
            get
            {
                return this._payWayId;
            }
            set
            {
                this._payWayId = value;
            }
        }

        /// <summary>
        /// 支付方式
        /// </summary>
        public string PayWayName
        {
            get
            {
                return this._payWayName;
            }
            set
            {
                this._payWayName = value;
            }
        }

        public string PayWay
        {
            get
            {
                return this._payWay;
            }
            set{
                this._payWay = value;
            }
        }

        /// <summary>
        /// 收费人ID
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
        /// 收费人
        /// </summary>
        public string OperMan
        {
            get
            {
                return this._operMan;
            }
            set
            {
                this._operMan = value;
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
        /// 医生
        /// </summary>
        public string DoctoeNmae
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
        /// 科室ID
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
        /// 科室名称
        /// </summary>
        public string LocationName
        {
            get
            {
                return this._locationName;
            }
            set
            {
                this._locationName = value;
            }
        }

        /// <summary>
        /// 收费时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get
            {
                return this._memo;
            }
            set
            {
                this._memo = value;
            }
        }

        /// <summary>
        /// 档案号
        /// </summary>
        public string CardNo { get; set; }

        private bool _isHideIllness;
        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public bool IsHideIllness
        {
            get { return _isHideIllness; }
            set { _isHideIllness = value; }
        }

        /// <summary>
        /// 医生手机号码
        /// </summary>
        public string DoctorPhone
        {
            get
            {
                return _doctorPhone;
            }

            set
            {
                _doctorPhone = value;
            }
        }
    }
}
