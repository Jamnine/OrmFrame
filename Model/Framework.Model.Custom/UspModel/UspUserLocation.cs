using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspUserLocation : BaseModel
    {
        public virtual String Name { get; set; }

        public virtual Int32? IsCheck { get; set; }
    }
}
