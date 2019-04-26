using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    [Serializable]
    public class uspCemberSpeReport : BaseModel
    {
        public uspCemberSpeReport()
        {

        }

        private string _patName = string.Empty;
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName
        {
            get { return _patName; }
            set { _patName = value; }
        }


        private string _vipCard = string.Empty;
        /// <summary>
        /// 会员卡号
        /// </summary>
        public string VipCard
        {
            get { return _vipCard; }
            set { _vipCard = value; }
        }

        private string _cardNo = string.Empty;
        /// <summary>
        /// 病历号
        /// </summary>
        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }


        private double _currentPay = 0;
        /// <summary>
        /// 本期消费金额
        /// </summary>
        public double CurrentPay
        {
            get { return _currentPay; }
            set { _currentPay = value; }
        }



        private double _discountAmount = 0;
        /// <summary>
        /// 本期减免优惠
        /// </summary>
        public double DiscountAmount
        {
            get { return _discountAmount; }
            set { _discountAmount = value; }
        }


        private double _shouldPay = 0;
        /// <summary>
        /// 本期应收账款
        /// </summary>
        public double ShouldPay
        {
            get { return _shouldPay; }
            set { _shouldPay = value; }
        }

        private double _ticketAount = 0;
        /// <summary>
        /// 本期使用票劵
        /// </summary>
        public double TicketAount
        {
            get { return _ticketAount; }
            set { _ticketAount = value; }
        }


        private double actuallyPay = 0;
        /// <summary>
        /// 本期使用实际收款
        /// </summary>
        public double ActuallyPay
        {
            get { return actuallyPay; }
            set { actuallyPay = value; }
        }

        private double _vipAmount = 0;
        /// <summary>
        /// 本期会员卡金额
        /// </summary>
        public double VipAmount
        {
            get { return _vipAmount; }
            set { _vipAmount = value; }
        }

        private DateTime _operTime = DateTime.MinValue;
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        public bool IsHideIllness { get; set; }

        /// <summary>
        /// 收费单ID
        /// </summary>
        public string InvoceId { get; set; }

    }
}
