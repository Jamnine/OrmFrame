using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class BsDoctorWithCheckLocationIdCellValueChanging
    {
        public List<BsDoctor> LstBsDoctor { set; get; }
        public string BsDoctorId { set; get; }
    }
}
