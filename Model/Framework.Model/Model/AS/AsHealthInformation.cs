using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class AsHealthInformation : Basics
    {
        public int AssessmentId { get; set; }

        public string ApplyPurpose { get; set; }

        public string ChronicDisease { get; set; }

        public string ChronicDiseaseOther { get; set; }

        public string TreatmentCondition { get; set; }

        public string BasicJudgment { get; set; }

        public string AuxiliaryTools { get; set; }

        public string AuxiliaryToolsOthe { get; set; }

        public string Supplement { get; set; }
    }
}
