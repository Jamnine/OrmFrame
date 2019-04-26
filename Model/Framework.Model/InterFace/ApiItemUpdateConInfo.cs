using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.InterFace
{
    public class ApiItemUpdateConInfo
    {
        public double goods_id;

        /// <summary>
        /// , 商品货号，也就是编码
        /// </summary>
        public string code;

        /// <summary>
        /// 商品名称
        /// </summary>
        public string name;

        /// <summary>
        /// ,商品规格
        /// </summary>
        public string spec;

        /// <summary>
        /// 产地
        /// </summary>
        public string yieldly;

        /// <summary>
        /// 厂家
        /// </summary>
        public string manufacturer;

        /// <summary>
        /// 条码
        /// </summary>
        public string barcode;

        /// <summary>
        /// 批准文号
        /// </summary>
        public string approval_number;

        /// <summary>
        /// 是否特殊药品
        /// </summary>
        public string is_special;

        /// <summary>
        /// 是否处方
        /// </summary>
        public string is_recipel;

        /// <summary>
        /// 商品单位
        /// </summary>
        public string unit_name;

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public string lastupdate_date;

    }
}
