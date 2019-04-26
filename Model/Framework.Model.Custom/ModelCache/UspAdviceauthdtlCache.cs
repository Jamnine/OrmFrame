using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 
    /// </summary>
    public class UspAdviceauthdtlCache : BaseModel
    {
        ///<summary>
        ///
        ///</summary>
        public DateTime InsertTime { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Patname { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Agestr { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Inpatno { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Sex { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int LsMarkType { set; get; }


        ///<summary>
        ///
        ///</summary>
        public DateTime AdviceTime { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string IsType { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int GroupNum { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double PriceIn { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double Totality { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double ToTalityAll { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double Amount { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsAttach { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsSelf { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int LsSpecialUsage { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int LsExecLoc { set; get; }


        ///<summary>
        ///
        ///</summary>
        public DateTime SkinTime { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsSkin { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string SkinTest { set; get; }


        ///<summary>
        ///
        ///</summary>
        public DateTime OperTime { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsPrinted { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsChk { set; get; }


        ///<summary>
        ///
        ///</summary>
        public DateTime ChkOperTime { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsEnd { set; get; }


        ///<summary>
        ///
        ///</summary>
        public DateTime EndOperTime { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsAuth { set; get; }


        ///<summary>
        ///
        ///</summary>
        public DateTime AuthOperTime { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Memo { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsOtherFee { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsBeforeops { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int LsRpType { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsInject { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Sn { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int FirstDay { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int LastDay { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int InfeeCheck { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int Adcolor { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsManual { set; get; }



        ///<summary>
        ///
        ///</summary>
        public bool IsTodayIn { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string DrugReqId1 { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string DrugReqId2 { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string DetailId1 { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string DetailId2 { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string AdviceName { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Name { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Code { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Spec { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string ExecuteId2 { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double Dosage { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsYbxj { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsAutoMatic { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string YbType { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsPriority { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string TempStr { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Colours { set; get; }



        ///<summary>
        ///
        ///</summary>
        public double ChildPrice { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double DiscountPrice { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool IsAuthed { set; get; }

        ///<summary>
        ///
        ///</summary>
        public string ExecLocId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string OriAdviceId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string ExecuteId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string ExecDoctorId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string UsageItemId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int id { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string UsageId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string FrequencyId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string UnitTakeId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string FormId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string HospId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string LocationId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string AdviceId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string DoctorId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string ItemId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string UnitInId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string OperId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string ChkOperId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string EndOperId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string EndDoctorId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string AuthOperId { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Requestno { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Requestno2 { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Hospital { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Usage { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Frequency { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Locname { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Unittake { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Formname { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Docname { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Unitin { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Oper { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Chkoper { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Endoper { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Enddoc { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Authoper { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Execloc { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Execdoc { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public double ArrearAmount { get; set; }
    }
}
