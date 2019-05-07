using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Common
{
    public interface IServiceFactorySelector
    {
        IService GetService(string serviceName);
    }
}
