using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel.With
{
    [Serializable]
    public class LoginWithLocation
    {
        public int Index { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
