using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel.VIP
{
    [Serializable]
    public class VisitWithGetListVisitOuHosInfo
    {
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string PatientName { get; set; }
        public string CardNo { get; set; }
        public string DoctorId { get; set; }
        public string VipLevelId { get; set; }
        public string Illness { get; set; }
        public string History { get; set; }
    }
}
