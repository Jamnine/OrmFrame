using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class PublicBsItemRelation
    {
        public virtual IList<BsUnitRatio> LstBsUnitRatio { get; set; }

        public virtual IList<BsItemAttach> LstBsItemAttach { get; set; }

        public virtual IList<BsItemFrequency> LstBsItemFrequency { get; set; }

        public virtual IList<BsItemLocation> LstBsItemLocation { get; set; }

        public virtual IList<BsItemPatType> LstBsItemPatType { get; set; }

        public virtual IList<BsItemTally> LstBsItemTally { get; set; }

        public virtual IList<BsItemUnit> LstBsItemUnit { get; set; }

        public virtual IList<BsItemUsage> LstBsItemUsage { get; set; }

        public virtual IList<BsItemYb> LstBsItemYb { get; set; }

        public virtual IList<BsItemItem> LstBsItemItem { get; set; }

        public virtual BsItem BsItem { get; set; }
        public virtual BsItemDrug BsItemDrug { get; set; }

        public PublicBsItemRelation() { }
        public PublicBsItemRelation(IList<BsUnitRatio> lstBsUnitRatio, IList<BsItemAttach> lstBsItemAttach, IList<BsItemFrequency> lstBsItemFrequency,
            IList<BsItemLocation> lstBsItemLocation, IList<BsItemPatType> lstBsItemPatType, IList<BsItemTally> lstBsItemTally, IList<BsItemUnit> lstBsItemUnit,
           IList<BsItemUsage> lstBsItemUsage, IList<BsItemYb> lstBsItemYb, IList<BsItemItem> lstBsItemItem)
        {
            this.LstBsUnitRatio = lstBsUnitRatio;
            this.LstBsItemAttach = lstBsItemAttach;
            this.LstBsItemFrequency = lstBsItemFrequency;
            this.LstBsItemLocation = lstBsItemLocation;
            this.LstBsItemPatType = lstBsItemPatType;
            this.LstBsItemTally = lstBsItemTally;
            this.LstBsItemUnit = lstBsItemUnit;
            this.LstBsItemUsage = lstBsItemUsage;
            this.LstBsItemYb = lstBsItemYb;
            this.LstBsItemItem = lstBsItemItem;
        }
    }
}
