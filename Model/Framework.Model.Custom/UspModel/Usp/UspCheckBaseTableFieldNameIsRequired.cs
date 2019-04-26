using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspCheckBaseTableFieldNameIsRequired : BaseModel
    {
        public virtual Int32 ID { get; set; }

        public virtual String BaseTableName { get; set; }

        public virtual string fkeyId { get; set; }

        public virtual String columnName { get; set; }

        public virtual Boolean? IsRequired { get; set; }
    }
}
