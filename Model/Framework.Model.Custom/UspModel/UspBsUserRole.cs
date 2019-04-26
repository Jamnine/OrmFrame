using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspBsUserRole
    {
        public virtual String ID { get; set; }

        public virtual String Name { get; set; }

        public virtual String ParentID { get; set; }

        public virtual Int32? OrderBy { get; set; }
    }
}
