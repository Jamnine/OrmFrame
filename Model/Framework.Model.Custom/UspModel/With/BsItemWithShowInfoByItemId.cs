using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class BsItemWithShowInfoByItemId
    {
        public string ManuId { set; get; }
        public string CompId { set; get; }
        public string FormId { set; get; }
        public string Spec { set; get; }
        public string EngDesc { set; get; }
        public string LongDesc { set; get; }
        public string Name { set; get; }
        public string PacsId { set; get; }
        public short XType { get; set; }
        public string Equipment { get; set; }
        public string CheckBody { get; set; }
        public string InitCode { get; set; }
        public BsItemDrug InfoBsItemDrug { get; set; }
        public BsItemPacs InfoBsItemPacs { get; set; }
    }
}
