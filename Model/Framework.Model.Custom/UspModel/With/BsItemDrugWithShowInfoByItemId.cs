using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class BsItemDrugWithShowInfoByItemId
    {
        public string ManuId { set; get; }
        public string CompId { set; get; }
        public string FormId { set; get; }
        public string Spec { set; get; }
        public string Name { set; get; }
        public string LongDesc { set; get; }
        public string EngDesc { set; get; }
        public BsItemDrug InfoBsItemDrug { set; get; }
        public BsItemEquipment InfoBsItemEquipment { set; get; }
    }
}
