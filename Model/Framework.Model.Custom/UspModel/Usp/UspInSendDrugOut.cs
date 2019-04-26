using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class UspInSendDrugOut : BaseModel
    {
        public string GUID { get; set; }

        public String LocationName { get; set; }

        public string PatID { get; set; }

        public String HospNo { get; set; }

        public String PatientName { get; set; }

        public String IdCardNo { get; set; }

        public String ItemName { get; set; }

        public String Spec { get; set; }

        public double Totality { get; set; }

        public string UnitReq { get; set; }

        public double Dosage { get; set; }

        public string BedId { get; set; }

        public Boolean IsPrint { get; set; }

        public double PriceIn { get; set; }

        public double Amount { get; set; }

        public Int32 LsMarkType { get; set; }

        public string LocationId { get; set; }

        public String ItemCode { get; set; }

        public DateTime ForDate { get; set; }

        public String RequestNo { get; set; }

        public string RoomId { get; set; }

        public double Times { get; set; }

        public string HospId { get; set; }

        public DateTime OperTime { get; set; }

        public String UnitReqName { get; set; }

        public string RequestId { get; set; }

        public string ItemId { get; set; }

        public Boolean IsIssued { get; set; }

        public Int32 ListNum { get; set; }

        public string AdviceId { get; set; }

        public string UnitTake { get; set; }

        public Boolean IsConfirm { get; set; }

        public string ConfirmOperId { get; set; }

        public String ConfirmOperTime { get; set; }

        public string DetailId { get; set; }

        public string UsageId { get; set; }

        public string FrequencyId { get; set; }

        public Int32 GroupNum { get; set; }

        public string ExecuteId { get; set; }

        public String FrequencyName { get; set; }

        public Boolean GroupId { get; set; }

        public Boolean IsPoison { get; set; }

        public Boolean IsMental { get; set; }

        public Boolean IsExpen { get; set; }

        public String DoctorName { get; set; }

        public String UnitTakeName { get; set; }

        public Boolean IsAttach { get; set; }

        public String UsageName { get; set; }

        public string OperID { get; set; }

        public Int32 age { get; set; }

        public String AgeString { get; set; }

        public String BedName { get; set; }

        public string PatTypeId { get; set; }

        public String Sex { get; set; }

        public string DoctorId { get; set; }

        public String GroupName { get; set; }

        public String Memo { get; set; }

        public String GroupTitle { get; set; }

        public int OrderBy { get; set; }

        public Int32 FirstDay { get; set; }
    }
}
