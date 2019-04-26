using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class BsIllnessWithCheckBsIlByIdandByName
    {
        public string FileName { set; get; }
        public int RowHandle { set; get; }
        public string ValueID { set; get; }
        public string ValueName { set; get; }
        public List<DgRoadIll> LstDgRoadIll { set; get; }
    }
}
