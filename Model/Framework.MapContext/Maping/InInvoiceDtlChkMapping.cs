

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院费用审核表 - 实体类
	/// </summary>
	public partial class InInvoiceDtlChkMapping: ClassMap<InInvoiceDtlChk>
	{   
		/// <summary>
		/// 住院费用审核表 - 实体类
		/// </summary>
		public InInvoiceDtlChkMapping()
		{
			this.TableName("ININVOICEDTLCHK").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.RegOperTime).ColumnName("REGOPERTIME");
			  
			this.Column(p =>p.RegOperId).ColumnName("REGOPERID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.AdviceId).ColumnName("ADVICEID");
			  
			this.Column(p =>p.LsMarkType).ColumnName("LSMARKTYPE");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.PriceIn).ColumnName("PRICEIN");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.IsPay).ColumnName("ISPAY");
			  
			this.Column(p =>p.DiscIn).ColumnName("DISCIN");
			  
			this.Column(p =>p.DiscSelf).ColumnName("DISCSELF");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.AmountFact).ColumnName("AMOUNTFACT");
			  
			this.Column(p =>p.AmountSelf).ColumnName("AMOUNTSELF");
			  
			this.Column(p =>p.AmountTally).ColumnName("AMOUNTTALLY");
			  
			this.Column(p =>p.AmountPay).ColumnName("AMOUNTPAY");
			  
			this.Column(p =>p.InvoId).ColumnName("INVOID");
			  
			this.Column(p =>p.LsPerform).ColumnName("LSPERFORM");
			  
			this.Column(p =>p.IsModiDisc).ColumnName("ISMODIDISC");
			  
			this.Column(p =>p.LimitGroupId).ColumnName("LIMITGROUPID");
			  
			this.Column(p =>p.LimitFee).ColumnName("LIMITFEE");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.ExecOperId).ColumnName("EXECOPERID");
			  
			this.Column(p =>p.ExecLocId).ColumnName("EXECLOCID");
			  
			this.Column(p =>p.InvItemId).ColumnName("INVITEMID");
			  
			this.Column(p =>p.FeeId).ColumnName("FEEID");
			  
			this.Column(p =>p.FeeHsId).ColumnName("FEEHSID");
			  
			this.Column(p =>p.LsReportType).ColumnName("LSREPORTTYPE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsCancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.CancelId).ColumnName("CANCELID");
			  
			this.Column(p =>p.IsManual).ColumnName("ISMANUAL");
			  
			this.Column(p =>p.HostName).ColumnName("HOSTNAME");
			  
			this.Column(p =>p.ExecuteId).ColumnName("EXECUTEID");
			  
			this.Column(p =>p.RegDate).ColumnName("REGDATE");
			  
			this.Column(p =>p.GroupItemId).ColumnName("GROUPITEMID");
			  
			this.Column(p =>p.XDRpId).ColumnName("XDRPID");
			  
			this.Column(p =>p.AdviceName).ColumnName("ADVICENAME");
			  
			this.Column(p =>p.MainDoctorId).ColumnName("MAINDOCTORID");
			  
			this.Column(p =>p.YbCode).ColumnName("YBCODE");
			  
			this.Column(p =>p.LsInOut).ColumnName("LSINOUT");
			  
			this.Column(p =>p.InOuInvoiceDtlId).ColumnName("INOUINVOICEDTLID");
			  
			this.Column(p =>p.UsageMemo).ColumnName("USAGEMEMO");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.FormId).ColumnName("FORMID");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.IsAutoCharged).ColumnName("ISAUTOCHARGED");
			  
			this.Column(p =>p.DiscountAoumt).ColumnName("DISCOUNTAOUMT");
			  
			this.Column(p =>p.ChildPrice).ColumnName("CHILDPRICE");
			  
			this.Column(p =>p.DiscountPrice).ColumnName("DISCOUNTPRICE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalID).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

