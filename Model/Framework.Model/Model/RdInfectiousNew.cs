using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    public class RdInfectiousNew : BaseModel
    {
        public RdInfectiousNew() { }
        public string GUID { get; set; }

        public string AfpId { get; set; }

        public int AgeType { get; set; }

        public string ApplyId { get; set; }

        public int Areas { get; set; }

        public DateTime AttackDate { get; set; }

        public string Authopt { get; set; }

        public DateTime BirthDate { get; set; }

        public string CancelOperId { get; set; }

        public DateTime CancelOperTime { get; set; }

        public string CardNo { get; set; }

        public int CardType { get; set; }

        public string ChkOperId { get; set; }

        public DateTime ChkOperTime { get; set; }

        public string City { get; set; }

        public string CklisproId { get; set; }

        public string Code { get; set; }

        public string Company { get; set; }

        public string ContractPhone { get; set; }

        public string Countryside { get; set; }

        public string County { get; set; }

        public DateTime DeathDate { get; set; }

        public string DoorNo { get; set; }

        public int Firstdiseases { get; set; }

        public string HospId { get; set; }

        public string IllnameId { get; set; }

        public int IllnessType1 { get; set; }

        public int IllnessType2 { get; set; }

        public DateTime InhosmzillDate { get; set; }

        public int Isactive { get; set; }

        public int Isauthed { get; set; }

        public int IsbackWrite { get; set; }

        public int IsWrite { get; set; }

        public string LocId { get; set; }

        public string Mobile { get; set; }

        public string MzregId { get; set; }

        public string Note { get; set; }

        public int OccupationType { get; set; }

        public string OperId { get; set; }

        public DateTime OperTime { get; set; }

        public string ParentName { get; set; }

        public string PatId { get; set; }

        public int PrnumberStart { get; set; }

        public string Province { get; set; }

        public string PspacsproId { get; set; }

        public string Qillness { get; set; }

        public string ReciOperId { get; set; }

        public DateTime RemindingOperTime { get; set; }

        public string Reporting { get; set; }

        public string RevisedName { get; set; }

        public int SeconddiSeases { get; set; }

        public string Statutory { get; set; }

        public string Strage { get; set; }

        public int ThirddiSeases { get; set; }

        public string Village { get; set; }

        public string WithDrawal { get; set; }
    }
}
