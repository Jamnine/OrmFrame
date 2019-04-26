using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    /// <summary>
    /// 门诊发票明细
    /// </summary>
    [Serializable]
    public partial class UspOuInvoiceDtl
    {
        /// <summary>
        /// 
        /// </summary>
        public UspOuInvoiceDtl() { }
        public virtual string GUID { get; set; }
        
        public virtual Int32 LsGroupType { get; set; }
        
        public virtual String Code { get; set; }
        
        public virtual String Name { get; set; }
        
        public virtual String Spec { get; set; }
        
        public virtual Int32 LsGfType { get; set; }
        
        public virtual double LimitTotalMz { get; set; }
        
        public virtual string TypeGFXEId { get; set; }
        
        public virtual string InvoId { get; set; }
        
        public virtual string ItemId { get; set; }
        
        public virtual double Totality { get; set; }
        
        public virtual string UnitId { get; set; }
        
        public virtual double Price { get; set; }
        
        public virtual double DiscDiag { get; set; }
        
        public virtual Boolean IsModiDisc { get; set; }
        
        public virtual double DiscSelf { get; set; }
        
        public virtual double Amount { get; set; }
        
        public virtual double AmountFact { get; set; }
        
        public virtual double AmountSelf { get; set; }
        
        public virtual double AmountPay { get; set; }
        
        public virtual double AmountTally { get; set; }
        
        public virtual Int32 LsPerform { get; set; }
        
        public virtual string LimitGroupId { get; set; }
        
        public virtual double LimitFee { get; set; }
        
        public virtual string ExecLocId { get; set; }
        
        public virtual string DoctorId { get; set; }
        
        public virtual string InvItemId { get; set; }
        
        public virtual string FeeId { get; set; }
        
        public virtual string FeeHsId { get; set; }
        
        public virtual string XDRpId { get; set; }
        
        public virtual Int32 LsReportType { get; set; }
        
        public virtual String Memo { get; set; }
        
        public virtual string RecipeItemId { get; set; }
        
        public virtual DateTime InvoTime { get; set; }
        
        public virtual string RecipeGroupId { get; set; }
        
        public virtual String UnitDiagName { get; set; }
        
        public virtual String FeeName { get; set; }
        
        public virtual String InvMzItemName { get; set; }
        
        public virtual String FeeHsMzName { get; set; }
        
        public virtual String DoctorName { get; set; }
        
        public virtual String LocationName { get; set; }
        
        public virtual Int32 LsAdviceType { get; set; }
        
        public virtual Int32 LsRpType { get; set; }
        
        public virtual Boolean IsDoctorInput { get; set; }
        
        public virtual Boolean IsBack { get; set; }
        
        public virtual Boolean IsToBack { get; set; }
        
        public virtual Boolean IsOtherFee { get; set; }
        
        public virtual string DocLevId { get; set; }
        
        public virtual Boolean IsAutoCharged { get; set; }
        
        public virtual string UsageId { get; set; }
        
        public virtual String Usagememo { get; set; }
        
        public virtual string Formid { get; set; }
        
        public virtual string FrequencyId { get; set; }
        
        public virtual string LocationId { get; set; }
        
        public virtual string recipeid { get; set; }
        
        public virtual double DiscountAoumt { get; set; }
        
        public virtual double ChildPrice { get; set; }
        
        public virtual double? DiscountPrice { get; set; }
        public virtual string TempInt { get; set; }
        public virtual string TempStr { get; set; }
        public virtual string TempStr2 { get; set; }
    }
}
