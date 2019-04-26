using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 单据查询组合条件类
    /// </summary>
    [Serializable]
    public class BillSearchDetailInfo : BaseModel
    {
        /// <summary>
        /// 单据ID
        /// </summary>
        public string BillId { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public string BillNo { get; set; } 
     
        /// <summary>
        /// 项目ID
        /// </summary>
        public string ItemId { get; set; }
       /// <summary>
       /// 项目名称
       /// </summary>
        public string ItemName {get;set;}
        /// <summary>
        /// 物品编号
        /// </summary>
        public string ItemCode { get;set;}
        /// <summary>
       /// 批号
       /// </summary>
        public string PNo { get;set;}
        /// <summary>
        /// 总价
        /// </summary>
        public double TotalPrice {get;set;}

        /// <summary>
        /// 总零售价
        /// </summary>
        public double TotalRetail {get;set;}

        /// <summary>
        /// 数量
        /// </summary>
        public double DrugNum
        {
            get;
            set;
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string UnitName
        {
            get;
            set;
        }
        /// <summary>
        /// 规格
        /// </summary>
        public string Spec
        {
            get;
            set;
        }
        /// <summary>
        /// 买入价
        /// </summary>
        public double StockPrice
        {
            get;
            set;
        }
        /// <summary>
        /// 零售价
        /// </summary>
        public double RetailPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 失效日期
        /// </summary>
        public DateTime LimitDate
        {
            get;
            set;
        }
        /// <summary>
        /// 生产商名称
        /// </summary>
        public string ManufactureryName
        {
            get;
            set;
        }
    }
}
