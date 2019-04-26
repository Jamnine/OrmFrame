using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel.With
{
    [Serializable]
    public class ItemWithPriceAdjust
    {
        public bool IsEnterprice { set; get; }
        public BsItem BsItem { set; get; }
        public BsItemDrug BsItemDrug { set; get; }
        public HuAdjust HuAdjust { set; get; }
        public RmAdjust RmAdjust { set; get; }
        public double OldPrice { set; get; }
        public double NewPrice { set; get; }

        public double StockPrice { set; get; }
    }
}
