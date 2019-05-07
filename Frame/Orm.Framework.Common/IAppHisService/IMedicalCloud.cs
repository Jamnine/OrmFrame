using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Common
{
    public interface IMedicalCloud
    {
        String DbName { get; }

        String ApiName { get; }
    }
}
