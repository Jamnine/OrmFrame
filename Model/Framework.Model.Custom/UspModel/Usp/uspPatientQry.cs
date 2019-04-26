using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 病人个人信息
    /// </summary>
    [Serializable]
    public class uspPatientQry : BaseModel
    {
        public uspPatientQry() { }

        private string _cardNo = string.Empty;
        /// <summary>
        /// 档案编号
        /// </summary>
        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }

        private string _patName = string.Empty;
        /// <summary>
        /// 病人名称
        /// </summary>
        public string PatName
        {
            get { return _patName; }
            set { _patName = value; }
        }

        private string _sex = string.Empty;
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private int _age = 0;
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _mobile = string.Empty;
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

        private string _vipCardNo = string.Empty;
        /// <summary>
        /// 会员卡号
        /// </summary>
        public string VIPCardNo
        {
            get { return _vipCardNo; }
            set { _vipCardNo = value; }
        }

        private string _vipLevel = string.Empty;
        /// <summary>
        /// 会员等级
        /// </summary>
        public string VIPLevel
        {
            get { return _vipLevel; }
            set { _vipLevel = value; }
        }

        private double _discount = 0;
        /// <summary>
        /// 折扣
        /// </summary>
        public double Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        private double _balance = 0;
        /// <summary>
        /// 余额
        /// </summary>
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        private double _inteGral = 0;
        /// <summary>
        /// 总积分
        /// </summary>
        public double InteGral
        {
            get { return _inteGral; }
            set { _inteGral = value; }
        }

        private DateTime _vipOperTime = DateTime.MinValue;
        /// <summary>
        /// 开卡时间
        /// </summary>
        public DateTime VIPOperTime
        {
            get { return _vipOperTime; }
            set { _vipOperTime = value; }
        }

        private DateTime _operTime = DateTime.MinValue;
        /// <summary>
        /// 建档时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        private bool _isHideIllness = false;
        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public bool IsHideIllness
        {
            get { return this._isHideIllness; }
            set { this._isHideIllness = value; }
        }
        private bool _isMobile = false;
        public bool u_IsMobile
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Mobile))
                {
                    _isMobile = true;
                }
                else
                {
                    _isMobile = false;
                }
                return _isMobile;
            }
            set { _isMobile = value; }
        }
        private bool _isMobileNull = false;
        public bool u_IsMobileNull
        {
            get
            {
                if (Mobile == null)
                {
                    _isMobileNull = true;
                }
                else
                {
                    _isMobileNull = false;
                }
                return _isMobileNull;
            }
            set { _isMobileNull = value; }
        }
    }
}
