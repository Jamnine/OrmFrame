using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.InterFace
{
    public class ApiItemUpdateInfo
    {
        /// <summary>
        /// 药房编码
        /// </summary>
        public string shop_code { get; set; }

        /// <summary>
        /// 1 表示中西药，2表示生鲜。因为这2种不同的店可能会有相同的门店编码
        /// </summary>
        public string shop_type { get; set; }

        /// <summary>
        /// 药品编码-价格
        /// </summary>
        public List<ItemUpdateDetail> hisgoods_prices { get; set; }

    }

    public class ItemUpdateDetail
    {

        /// <summary>
        /// 药品编码
        /// </summary>
        public string goods_code { get; set; }

        /// <summary>
        /// 药品门诊价格
        /// </summary>
        public double member_price { get; set; }

        /// <summary>
        /// 药品住院价
        /// </summary>
        public double retail_price { get; set; }
    }
}
