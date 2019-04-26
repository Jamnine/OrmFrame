using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    public interface IKeyCreater
    {
        string GetNextID(string code);
    }
}
