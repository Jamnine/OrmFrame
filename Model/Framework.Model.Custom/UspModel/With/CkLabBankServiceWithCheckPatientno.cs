using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model.Custom.UspModel.Usp;

namespace Orm.Model.Custom.UspModel.With
{
    [Serializable]
    public class CkLabBankServiceWithCheckPatientno
    {
        public Action<string> InitBankData { set; get; }
        public IList<UspCkLabByOpertimeAndLsStatus4> LstUnfinishW { set; get; }
    }
}
