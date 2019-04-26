using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel.With
{
    [Serializable]
    public class LoginWithUserLocation
    {
        public IList<LoginWithLocation> LstLocation { get; set; }
        public BsUser BsUser { set; get; }
    }
}
