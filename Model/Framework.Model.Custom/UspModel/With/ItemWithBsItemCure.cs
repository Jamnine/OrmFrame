using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class ItemWithBsItemCure : BaseModel
    {
        public virtual IList<BsItemPacs> lstBsItemPacs { get; set; }

        public virtual IList<BsItemDrug> LstBsItemDrug { get; set; }

        public virtual IList<BsItemYb> LstBsItemYb { get; set; } 

        public virtual IList<BsItemFrequency> LstBsItemFrequencyInfo { get; set; }

        public virtual IList<BsItemLocation> LstBsItemLocationInfo { get; set; }

        public virtual IList<BsItemUnit> LstBsItemUnitInfo { get; set; }

        public virtual IList<BsItemUsage> LstBsItemUsageInfo { get; set; }

        public virtual IList<BsItemAttach> LstBsItemAttachInfo { get; set; }

        public virtual IList<BsItemPatType> LstBsItemPatTypeInfo { get; set; }

        public virtual IList<BsUnitRatio> LstBsUnitRatioInfo { get; set; }

        public virtual IList<BsItemItem> LstBsItemItem { get; set; }

        public virtual IList<BsExecLocation> LstBsExecLocation { get; set; }
    }
}
