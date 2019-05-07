using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Common
{
    public interface IEntity
    {
        T DeepCloneAs<T>(Type type);

        T DeepClone<T>();
    }
}
