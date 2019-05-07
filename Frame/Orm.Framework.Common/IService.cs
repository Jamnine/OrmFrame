using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Common
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        DateTime GetCurrentDateTime();

    }
}
