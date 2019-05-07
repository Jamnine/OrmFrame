using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Orm.Framework.Common
{
    public interface IGenericEntity<TId> : IEntity
    {
        [DataMember]
        TId GUID { get; set; }

        bool IsTransient();
    }
}
