using System;

namespace Orm.Model.Parameter
{  /// <summary>
   /// 用于一键诊疗web端的返回病人挂号信息
   /// </summary>
    [Serializable]
    public class PMTransmit
    {
        private string _patID;
        private string _cardNo = string.Empty;
        private string _ouHosinfoID;
        private string _mzRegNo = string.Empty;
        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID
        {
            get { return _patID; }
            set { _patID = value; }
        }
        /// <summary>
        /// 门诊挂号ID
        /// </summary>
        public string OuHosinfoID
        {
            get { return _ouHosinfoID; }
            set { _ouHosinfoID = value; }
        }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }
        /// <summary>
        ///门诊流水号
        /// </summary>
        public string MzRegNo
        {
            get { return _mzRegNo; }
            set { _mzRegNo = value; }
        }
        /// <summary>
        /// 单位为分钟;需提前多长时间可以取消预约
        /// </summary>
        public int HowLongCancelRegister { get; set; }

    }
}
