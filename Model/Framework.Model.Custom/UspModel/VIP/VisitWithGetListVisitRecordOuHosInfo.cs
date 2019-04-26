using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel.VIP
{
    [Serializable]
    public class VisitWithGetListVisitRecordOuHosInfo
    {
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string PatientName { get; set; }
        public string CardNo { get; set; }
        public int LsVisitType { get; set; }
        public int LsVisitStatus { get; set; }
        public string OperId { get; set; }
    }
}
