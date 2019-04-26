

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
    /// <summary>
    /// 门诊处方明细 - 实体类
    /// </summary>
    public partial class OuRecipeDtlMapping : ClassMap<OuRecipeDtl>
    {
        /// <summary>
        /// 门诊处方明细 - 实体类
        /// </summary>
        public OuRecipeDtlMapping()
        {
            this.TableName("OURECIPEDTL").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.RecipeId).ColumnName("RECIPEID");

            this.Column(p => p.ListNum).ColumnName("LISTNUM");

            this.Column(p => p.ItemID).ColumnName("ITEMID");

            this.Column(p => p.GroupNum).ColumnName("GROUPNUM");

            this.Column(p => p.Dosage).ColumnName("DOSAGE");

            this.Column(p => p.UnitTakeId).ColumnName("UNITTAKEID");

            this.Column(p => p.FrequencyId).ColumnName("FREQUENCYID");

            this.Column(p => p.UsageId).ColumnName("USAGEID");

            this.Column(p => p.Days).ColumnName("DAYS");

            this.Column(p => p.Totality).ColumnName("TOTALITY");

            this.Column(p => p.UnitDiagId).ColumnName("UNITDIAGID");

            this.Column(p => p.IsAttach).ColumnName("ISATTACH");

            this.Column(p => p.IsOtherFee).ColumnName("ISOTHERFEE");

            this.Column(p => p.XDRpId).ColumnName("XDRPID");

            this.Column(p => p.Memo).ColumnName("MEMO");

            this.Column(p => p.IsCharged).ColumnName("ISCHARGED");

            this.Column(p => p.IsCancel).ColumnName("ISCANCEL");

            this.Column(p => p.CancelTime).ColumnName("CANCELTIME");

            this.Column(p => p.CancelOperId).ColumnName("CANCELOPERID");

            this.Column(p => p.IsPrint).ColumnName("ISPRINT");

            this.Column(p => p.PrintTime).ColumnName("PRINTTIME");

            this.Column(p => p.PrintOperId).ColumnName("PRINTOPERID");

            this.Column(p => p.IsPrepared).ColumnName("ISPREPARED");

            this.Column(p => p.PrepareTime).ColumnName("PREPARETIME");

            this.Column(p => p.PrepareOperId).ColumnName("PREPAREOPERID");

            this.Column(p => p.IsIssue).ColumnName("ISISSUE");

            this.Column(p => p.IssueTime).ColumnName("ISSUETIME");

            this.Column(p => p.IssueOperId).ColumnName("ISSUEOPERID");

            this.Column(p => p.IsToBack).ColumnName("ISTOBACK");

            this.Column(p => p.IsBack).ColumnName("ISBACK");

            this.Column(p => p.IsDoctorInput).ColumnName("ISDOCTORINPUT");

            this.Column(p => p.RecNum).ColumnName("RECNUM");

            this.Column(p => p.RecipeTime).ColumnName("RECIPETIME");

            this.Column(p => p.LocationId).ColumnName("LOCATIONID");

            this.Column(p => p.DoctorId).ColumnName("DOCTORID");

            this.Column(p => p.AllPageNo).ColumnName("ALLPAGENO");

            this.Column(p => p.PageNo).ColumnName("PAGENO");

            this.Column(p => p.CureDtlId).ColumnName("CUREDTLID");

            this.Column(p => p.IsBP).ColumnName("ISBP");

            this.Column(p => p.BPReason).ColumnName("BPREASON");

            this.Column(p => p.YbType).ColumnName("YBTYPE");

            this.Column(p => p.InvoNo).ColumnName("INVONO");

            this.Column(p => p.IsAutoCharged).ColumnName("ISAUTOCHARGED");

            this.Column(p => p.IsForCharge).ColumnName("ISFORCHARGE");

            this.Column(p => p.ApplyId).ColumnName("APPLYID");

            this.Column(p => p.Price).ColumnName("PRICE");

            this.Column(p => p.TempStr).ColumnName("TEMPSTR");

            this.Column(p => p.DiscountAoumt).ColumnName("DISCOUNTAOUMT");

            this.Column(p => p.ChildPrice).ColumnName("CHILDPRICE");

            this.Column(p => p.DiscountPrice).ColumnName("DISCOUNTPRICE");

            this.Column(p => p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.OldDiscDiag).ColumnName("OLDDISCDIAG");

            this.Column(p => p.IsOper).ColumnName("ISOPER");

            this.Column(p => p.AddMemo).ColumnName("ADDMEMO");

            this.Column(p => p.DripRates).ColumnName("DRIPRATES");

            this.Column(p => p.SkinTestCondition).ColumnName("SKINTESTCONDITION");

            this.Column(p => p.PlanExecuteTime).ColumnName("PLANEXECUTETIME");

            this.Column(p => p.CompleteTime).ColumnName("COMPLETETIME");

            this.Column(p => p.ItemName).ColumnName("ITEMNAME");

            this.Column(p => p.DiscDiag).ColumnName("DISCDIAG");

            this.Column(p => p.PatTypeName).ColumnName("PATTYPENAME");

            this.Column(p => p.SamlingType).ColumnName("SAMLINGTYPE");

            this.Column(p => p.ExecOperID).ColumnName("EXECOPERID");

            this.Column(p => p.IsShow).ColumnName("ISSHOW");

            this.Column(p => p.IsVipDeduction).ColumnName("ISVIPDEDUCTION");

            this.Column(p => p.IsUsageItem).ColumnName("ISUSAGEITEM");

            this.Column(p => p.IsPatExecute).ColumnName("ISPATEXECUTE");

            this.Column(p => p.ChargeDtime).ColumnName("CHARGEDTIME");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.LabId).ColumnName("LabId");

            this.Column(p => p.OperId).ColumnName("OPERID");

            this.Column(p => p.BackCancelOperId).ColumnName("BACKCANCELOPERID");

            this.Column(p => p.BackCancelTime).ColumnName("BACKCANCELTIME");

            this.Column(p => p.CookType).ColumnName("COOKTYPE");

            this.Column(p => p.RecipeNum).ColumnName("RecipeNum");

            this.Column(p => p.JoinExecOperID).ColumnName("joinexecoperid");

            this.Column(p => p.P1).ColumnName("P1");

            this.Column(p => p.P2).ColumnName("P2");

            this.Column(p => p.P3).ColumnName("P3");

            this.Column(p => p.P4).ColumnName("P4");

            this.Column(p => p.CkItemType).ColumnName("CKITEMTYPE");

            this.Column(p => p.ChargeCount).ColumnName("ChargeCount");

            this.Column(p => p.IsYbItems).ColumnName("ISYBITEMS");

            this.Column(p => p.AKA185).ColumnName("AKA185");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}


