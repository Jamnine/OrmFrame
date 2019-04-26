using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    [Serializable]
    public class uspCemberBalance ///会员卡余额报表
    {
        private string _CardNo;
        private string _guId;
        private string _patId;
        private string _patName = String.Empty;
        private string _Iphone = String.Empty;
        private string _Sex;///性别.
        private DateTime _OldRechargeTime;///最后充值时间.
        private DateTime _OldFinallyTime;///最后使用时间
        private double _Amount;///账号余额 
        public double _rechargeAmount;
        public double _consumptionAmount;
        private string _memo = String.Empty;
        private string _vipLevel = String.Empty;
        private bool _isIncome;
        
        public uspCemberBalance() { }

       
        public bool IsIncome
        {
            get
            {
                return this._isIncome;
            }
            set
            {
                this._isIncome = value;
            }
        }
        /// <summary>
        /// 门诊流水号。外键，引用OuHosInfo.GUID.
        /// </summary>
        public string CardNo
        {
            get
            {
                return this._CardNo;
            }
            set
            {
                this._CardNo = value;
            }
        }
        public string GuId
        {
            get
            {
                return this._guId;
            }
            set
            {
                this._guId = value;
            }
        }
        /// <summary>
        /// 患者ID，对应于Patient的Pat_Id.
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
        /// 患者姓名
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
        /// 电话
        /// </summary>
        public string Iphone
        {
            get
            {
                return this._Iphone;
            }
            set
            {
                this._Iphone = value;
            }
        }
        /// <summary>
        ///患者金额
        /// </summary>
        public double Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this._Amount = value;
            }
        }

        /// <summary>
        /// 充值金额
        /// </summary>
        public double RechargeAmount
        {
            get
            {
                return this._rechargeAmount;
            }
            set
            {
                this._rechargeAmount = value;
            }
        }

        /// <summary>
        ///消费金额
        /// </summary>
        public double ConsumptionAmount
        {
            get
            {
                return this._consumptionAmount;
            }
            set
            {
                this._consumptionAmount = value;
            }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get
            {
                return this._Sex;
            }
            set
            {
                this._Sex = value;
            }
        }
        /// <summary>
        /// 最后充值时间
        /// </summary>
        public DateTime OldRechargeTime
        {
            get
            {
                return this._OldRechargeTime;
            }
            set
            {
                this._OldRechargeTime = value;
            }
        }
        /// <summary>
        /// 最后充值时间
        /// </summary>
        public DateTime OldFinallyTime
        {
            get
            {
                return this._OldFinallyTime;
            }
            set
            {
                this._OldFinallyTime = value;
            }
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
        /// Vip.Level
        /// </summary>
        public string VipLevel
        {
            get
            {
                return this._vipLevel;
            }
            set
            {
                this._vipLevel = value;
            }
        }
        private bool _isHideIllness;
        /// <summary>
        /// 是否特殊患者
        /// </summary>
        public bool IsHideIllness
        {
            get { return _isHideIllness; }
            set { _isHideIllness = value; }
        }
    }
}

