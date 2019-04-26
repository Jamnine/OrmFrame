using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class AsOldFool : Basics
    {
        public int AssessmentId { get; set; }

        public int OperId { get; set; }

        public DateTime OperTime { get; set; }

        public int ObstacleId { get; set; }

        public int CognitionId { get; set; }
    }
}
