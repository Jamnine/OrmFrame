using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class AsBasicInformation : Basics
    {
        public int AssessmentId { get; set; }

        public int SurveyAddressId { get; set; }

        public string Location { get; set; }

        public short LivingConditions { get; set; }

        public short HousingSituation { get; set; }

        public bool IsAssessed { get; set; }

        public DateTime AssessedTime { get; set; }

        public short AssessedGrade { get; set; }

        public string CurrentCareIds { get; set; }

        public string CurrentCare { get; set; }

        public string CareProviderIds { get; set; }

        public string CareProvider { get; set; }

        public short HedicalInsurance { get; set; }

        public string HedicalInsuranceOther { get; set; }

        public short EndowmentInsurance { get; set; }

        public string CareDemandIds { get; set; }

        public string CareDemand { get; set; }

        public string MemberFamilyMember1 { get; set; }

        public string Relation1 { get; set; }

        public string Phone1 { get; set; }

        public string MemberFamilyMember2 { get; set; }

        public string Relation2 { get; set; }

        public string Phone2 { get; set; }

        public string SurveyAddress { get; set; }
    }
}
