using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspFrmEquipMentList
    {
        public virtual String UGID { get; set; }

        public virtual String CODE { get; set; }

        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual Int32 LsQuaClass { get; set; }

        public virtual Int32 LsEqClass { get; set; }

        public virtual String LotNo { get; set; }

        public virtual Int32 LsEqStatus { get; set; }

        public virtual Int16 LsEqType { get; set; }

        public virtual string MnrgLocId { get; set; }

        public virtual string UseLocId { get; set; }

        public virtual double Price { get; set; }

        public virtual String UseLocName { get; set; }

        public virtual String Code { get; set; }
    }
}
