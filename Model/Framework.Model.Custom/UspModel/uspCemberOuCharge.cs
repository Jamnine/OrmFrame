using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    [Serializable]
    public class uspCemberOuCharge///会员操作情况报表
    {
        public uspCemberOuCharge() { }

        private string _patID;
        private string _cardNo;
        private string _cardLevel;
        private string _name;
        private string _sex;
        private string _discDiag;
        private string _phone;
        private int _operType;
        private string _operTypeName;
        private DateTime _operTime;
        private double _amount;
        private double _balance;
        private double _deduct;
        private bool _isInternalStaff;
        private string _isInternalName;
        private string _internalIntroduceID;
        private string _internalIntroduce;
        private string _payWay;

        public string PatID
        {
            get { return this._patID; }
            set { this._patID = value; }
        }
        public string CardNo
        {
            get { return this._cardNo; }
            set { this._cardNo = value; }
        }

        public string CardLevel
        {
            get { return this._cardLevel; }
            set { this._cardLevel = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Sex
        {
            get { return this._sex; }
            set { this._sex = value; }
        }
        public string DiscDiag
        {
            get { return this._discDiag; }
            set { this._discDiag = value; }
        }
        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }
        public int OperType
        {
            get { return this._operType; }
            set { this._operType = value; }
        }
        public string OperTypeName
        {
            get { return this._operTypeName; }
            set { this._operTypeName = value; }
        }
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }
        public double Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }
        public double Balance
        {
            get { return this._balance; }
            set { this._balance = value; }
        }
        public double Deduct
        {
            get { return this._deduct; }
            set { this._deduct = value; }
        }
        public bool IsInternalStaff
        {
            get { return this._isInternalStaff; }
            set { this._isInternalStaff = value; }
        }
        public string IsInternalName
        {
            get { return this._isInternalName; }
            set { this._isInternalName = value; }
        }
        public string InternalIntroduceID
        {
            get { return this._internalIntroduceID; }
            set { this._internalIntroduceID = value; }
        }
        public string InternalIntroduce
        {
            get { return this._internalIntroduce; }
            set { this._internalIntroduce = value; }
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
        /// <summary>
        /// 支付方式
        /// </summary>
        public string PayWay
        {
            get { return _payWay; }
            set { _payWay = value; }
        }
    }
}
