using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 门诊挂号缓存信息
    /// </summary>
    [Serializable]
    public class OuHosInfoCache : BaseModel
    {
        private string _mzRegNo = "";
        private string _patId = "";
        private string _cardNo = "";
        private string _patName = "";
        private DateTime _regTime = DateTime.MinValue;
        private string _sex = "O";
        private string _regAge = "";
        private string _bookingTel = "";
        private string _doctorId = "";
        private string _pyCode = "";
        private string _wbCode = "";
        /// <summary>
        /// 诊所id
        /// </summary>
        public int LocationId { get; set; }
        /// <summary>
        /// 门诊号
        /// </summary>
        public string MzRegNo
        {
            get { return this._mzRegNo; }
            set { this._mzRegNo = value; }
        }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatId
        {
            get { return this._patId; }
            set { this._patId = value; }
        }

        /// <summary>
        /// 档案号
        /// </summary>
        public string CardNo
        {
            get { return this._cardNo; }
            set { this._cardNo = value; }
        }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName
        {
            get { return this._patName; }
            set { this._patName = value; }
        }

        /// <summary>
        /// 就诊日期
        /// </summary>
        public DateTime RegTime
        {
            get { return this._regTime; }
            set { this._regTime = value; }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return this._sex; }
            set { this._sex = value; }
        }

        /// <summary>
        /// 就诊年龄
        /// </summary>
        public string RegAge
        {
            get { return this._regAge; }
            set { this._regAge = value; }
        }

        /// <summary>
        /// 预约电话
        /// </summary>
        public string BookingTel
        {
            get { return this._bookingTel; }
            set { this._bookingTel = value; }
        }

        /// <summary>
        /// 挂号医生ID
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        /// <summary>
        /// 拼音码
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        /// <summary>
        /// 五笔码
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        } 
    }
}
