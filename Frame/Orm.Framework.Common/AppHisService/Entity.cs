using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Orm.Framework.Common
{
    public abstract class Entity
    {
        protected T DeepClone<T>(Type type)
        {
            var members = FormatterServices.GetSerializableMembers(type);
            var data = FormatterServices.GetObjectData(this, members);
            var cloned = FormatterServices.GetSafeUninitializedObject(type);

            FormatterServices.PopulateObjectMembers(cloned, members, data);

            return (T)cloned;
        }

        public virtual T DeepCloneAs<T>(Type type)
        {
            return (T)this.DeepClone<T>(type);
        }

        public virtual T DeepClone<T>()
        {
            var type = GetType();

            return (T)this.DeepClone<T>(type);
        }
    }
}
