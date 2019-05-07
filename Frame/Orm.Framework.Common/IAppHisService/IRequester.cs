using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Framework.Common
{
    public interface IRequester
    {
        void HttpRequest(RequestModel requestModel, string tbName);

        T HttpRequest<T>(RequestModel requestModel, string tbName, string childName);

        string RequestService<T>(RequestModel requestModel, string tbName, string childName);

        string RequestService<T>(RequestModel requestModel, List<String> lstTbName);
    }
}
