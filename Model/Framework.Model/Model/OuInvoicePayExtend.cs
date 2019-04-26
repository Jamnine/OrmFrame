

using System;
namespace Orm.Model
{
    /// <summary>
    /// 门诊收费方式 - 实体类
    /// </summary>
    public partial class OuInvoicePay : BaseModel
    {

        private string _code;
        private string _payWayName;

        /// <summary>
        /// 编码
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 支付名字
        /// </summary>
        public string PayWayName
        {
            get { return _payWayName; }
            set { _payWayName = value; }
        }

    }
}


