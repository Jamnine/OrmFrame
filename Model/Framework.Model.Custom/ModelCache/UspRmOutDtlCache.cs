using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Model.Custom
{
   public class UspRmOutDtlCache:BaseModel
    {
        /// <summary>
        /// 单据Id
        /// </summary>
        public string BillId
        {
            get;
            set;
        }

        /// <summary>
        /// 药房库存表Id，RmStores.id
        /// </summary>
        public string InBatchId
        {
            get;
            set;
        }

        /// <summary>
        /// 项目ID对应Bsitem.id
        /// </summary>
        public string ItemId
        {
            get;
            set;
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string UnitId
        {
            get;
            set;
        }

        /// <summary>
        /// 数量
        /// </summary>
        public double DrugNum
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
        /// 药库买入价
        /// </summary>
        public double StockPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 处方Id,OuRecipeDtl.id
        /// </summary>
        public string RecipeItemId
        {
            get;
            set;
        }

        /// <summary>
        /// 操作前库存
        /// </summary>
        public double BeforeStockNum
        {
            get;
            set;
        }

        /// <summary>
        /// 操作后库存
        /// </summary>
        public double AfterStockNum
        {
            get;
            set;
        }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>
        public bool IsAuthed
        {
            get;
            set;
        }
        
        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegId { set; get; }
    }
}
