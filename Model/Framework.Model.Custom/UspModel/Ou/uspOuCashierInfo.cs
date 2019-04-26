using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel.Ou
{
    /// <summary>
    /// 门诊收费单据(打印格式用)
    /// </summary>
    [Serializable]
    public   class uspOuCashierInfo : BaseModel
    {
        private string _serialNumber;

        private string _year;

        private string _month;

        private string _day;

        private string _patName;

        private double _medicineCost;

        private string _qian;

        private string _bai;

        private string _shi;

        private string _yuan;

        private string _jiao;

        private string _fen;

        private double _herbalMedicineCost;

        private double _checkCost;

        private double _cureCost;

        private double _otherCost;

        private string  _totalMoney;

        private string _tollCollector;

        private string _payWay;

        private double _examinationFee;

        private double _surveyorFee;

        /// <summary>
        /// 系列号
        /// </summary>
        public string SerialNumber
        {
            get { return _serialNumber; }
            set { _serialNumber = value; }
        }
        /// <summary>
        /// 支付方式
        /// </summary>
        public string PayWay
        {
            get { return _payWay; }
            set { _payWay = value; }
        }


        /// <summary>
        /// 年
        /// </summary>
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }


        /// <summary>
        /// 月
        /// </summary>
        public string Month
        {
            get { return _month; }
            set { _month = value; }
        }


        /// <summary>
        /// 日
        /// </summary>
        public string Day
        {
            get { return _day; }
            set { _day = value; }
        }
        /// <summary>
        /// 千
        /// </summary>
        public string Qian
        {
            get { return _qian; }
            set { _qian = value; }
        }


        /// <summary>
        /// 百
        /// </summary>
        public string Bai
        {
            get { return _bai; }
            set { _bai = value; }
        }


        /// <summary>
        /// 十
        /// </summary>
        public string Shi
        {
            get { return _shi; }
            set { _shi = value; }
        }


        /// <summary>
        /// 元
        /// </summary>
        public string Yuan
        {
            get { return _yuan; }
            set { _yuan = value; }
        }


        /// <summary>
        /// 角
        /// </summary>
        public string Jiao
        {
            get { return _jiao; }
            set { _jiao = value; }
        }


        /// <summary>
        /// 分
        /// </summary>
        public string Fen
        {
            get { return _fen; }
            set { _fen = value; }
        }





        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName
        {
            get { return _patName; }
            set { _patName = value; }
        }

        /// <summary>
        /// 收费员
        /// </summary>
        public string TollCollector
        {
            get { return _tollCollector; }
            set { _tollCollector = value; }
        }

        /// <summary>
        /// 西药费
        /// </summary>
        public double MedicineCost
        {
            get { return _medicineCost; }
            set { _medicineCost = value; }
        }


        /// <summary>
        /// 中草药费
        /// </summary>
        public double HerbalMedicineCost
        {
            get { return _herbalMedicineCost; }
            set { _herbalMedicineCost = value; }
        }

        /// <summary>
        ///检查费
        /// </summary>
        public double CheckCost
        {
            get { return _checkCost; }
            set { _checkCost = value; }
        }

        /// <summary>
        /// 治疗费
        /// </summary>
        public double CureCost
        {
            get { return _cureCost; }
            set { _cureCost = value; }
        }

        /// <summary>
        /// 其他费
        /// </summary>
        public double OtherCost
        {
            get { return _otherCost; }
            set { _otherCost = value; }
        }

        /// <summary>
        /// 合计人民币
        /// </summary>
        public string  TotalMoney
        {
            get { return _totalMoney; }
            set { _totalMoney = value; }
        }

        /// <summary>
        /// 诊查费
        /// </summary>
        public double ExaminationFee
        {
            get { return _examinationFee; }
            set { _examinationFee = value; }
        }

        /// <summary>
        /// 检验费
        /// </summary>
        public double SurveyorFee
        {
            get { return _surveyorFee; }
            set { _surveyorFee = value; }
        }
    }
}
