using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class EquipmentManageWithRelation
    {
        #region Public Properties

        public EquipMent EquipMentInfo { get; set; }

        public IList<EqCheck> LstEqCheck { get; set; }

        public IList<EqRepair> LstEqRepair { get; set; }

        public IList<EqAttach> LstEqAttach { get; set; }

        public IList<BsEqmaintain> LstBsEqmaintain { get; set; }

        public IList<EqRadEnvironment> LstEqRadEnvironment { get; set; }

        public IList<EqTransfer> LstEqTransfer { get; set; }

        public IList<BsUserWord> LstBsUserWord { get; set; }


        #endregion Public Properties 
    }
}
