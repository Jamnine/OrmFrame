using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel.In
{
    public class InitPatientData
    {
        public List<SelectHisItem> lstSelectRecip { set; get; }
        public List<UspOuRecipeDtlForOuInvoiceDtl> lstUspOuRecipeDtlForOuInvoiceDtlRemove { set; get; }
        public List<UspOuInvoiceDtl> lstUspOuInvoiceDtl { set; get; }
        public IList<OuRecipeDtl> lstHasRecipeDtl { set; get; }
        public IList<OuRecipeDtl> lstSamePatientName { set; get; }
        public List<UspOuRecipeDtlForOuInvoiceDtl> lstUspOuRecipeDtlCheck { set; get; }
        public IList<UspOuRecipeDtlForOuInvoiceDtl> lstUspOuRecipeDtlCure { set; get; }
        public IList<UspOuRecipeDtlForOuInvoiceDtl> lstUspOuRecipeDtlOPS { set; get; }
        public IList<UspOuRecipeDtlForOuInvoiceDtl> lstUspOuRecipeDtlTest { set; get; }
        public IList<BsLabSourceItem> lstSourceItem { set; get; }
        public IList<UspOuInvoiceDtlPatientToday> lstUspOuInvoiceDtlPatientToday { set; get; }
        public UspOuInvoiceDtl infoUspOuInvoiceDtl { set; get; }
        public OuInvoice infoOuInvoice { set; get; }
        public IList<SelectHisItem> lstSelectItem { set; get; }
        public IList<UspOuRecipeDtl> lstUspChineseRecipeDtl { set; get; }
        public IList<OuRecipe> lstChineseRecipe { set; get; }
        public List<UspOuInvoiceDtl> lstSelfDrug { set; get; }
        public string itemId { set; get; }
        public string patTypeId { set; get; }
        public string diagnDept { set; get; }
        public string ouChinRoomId { set; get; }
        public string locationId { set; get; }
        public int hospitalId { set; get; }
        public string hisOuHosInfo1Id { set; get; }
        public int centerHospitalId { set; get; }
        public string ubsExecLocId { set; get; }
        public bool isDoctorInput { set; get; }
        public bool isTj { set; get; }
        public string doctorId { set; get; }
        public string mzRegId { set; get; }
        public string patientName { set; get; }
        public string regTypeId { set; get; }
        public bool isInPatient { set; get; }
        public bool isJm { set; get; }
        public bool isOuChargeRegFee { set; get; }
        public bool isOuChargeDiagFee { set; get; }
        public string lastGroupUsageId { set; get; }
        public int age { set; get; }
        public string sex { set; get; }
        public string medicareNo { set; get; }
        public string patId { set; get; }
        public string checkCompany { set; get; }
        public string tallyNo { set; get; }
        public string tallyGroupId { set; get; }
        public int limitTop { set; get; }
        public bool isYb { set; get; }
        public bool isUpYb { set; get; }
        public int inTintNumber { set; get; }
        public bool isInTintType { set; get; }
        public bool isGf { set; get; }
        public bool isCharge { set; get; }
        public int ouInvoiceId { set; get; }
    }
}
