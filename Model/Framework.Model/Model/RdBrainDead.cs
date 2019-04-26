using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    public class RdBrainDead : BaseModel
    {
        #region Public Constructor 
        public RdBrainDead()
        {
        }

        #endregion
        #region Public Properties 
        public string GUID { get; set; }

        public string PatId { get; set; }

        public DateTime OperTime { get; set; }

        public string OperID { get; set; }

        public string Code { get; set; }

        public string ICDId { get; set; }

        public short LsCardType { get; set; }

        public short LsCensus { get; set; }

        public string IllId { get; set; }

        public DateTime DiagDate { get; set; }

        public short LsIllBase { get; set; }

        public string LsIllType { get; set; }

        public DateTime IllDate { get; set; }

        public DateTime LsLastTime { get; set; }

        public int IllTimes { get; set; }

        public DateTime DeadDate { get; set; }

        public string ImmediacyDead { get; set; }

        public string ElseIllness { get; set; }

        public string FormerlyIllness { get; set; }

        public DateTime YDiagDate { get; set; }

        public string DeadCause { get; set; }

        public string LocId { get; set; }

        public int DeadICD { get; set; }

        public int ElseIllnessICD { get; set; }

        public int F1 { get; set; }

        public int F2 { get; set; }

        public int F3 { get; set; }

        public int F4 { get; set; }

        public string MzRegId { get; set; }

        public string ReciOperId { get; set; }
        public string ReportUnit { get; set; }

        public DateTime ReportDate { get; set; }

        public bool IsAuthed { get; set; }
        #endregion


    }
}
