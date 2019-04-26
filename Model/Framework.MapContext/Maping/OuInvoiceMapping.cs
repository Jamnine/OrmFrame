

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊收费发票 - 实体类
	/// </summary>
	public partial class OuInvoiceMapping: ClassMap<OuInvoice>
	{   
		/// <summary>
		/// 门诊收费发票 - 实体类
		/// </summary>
		public OuInvoiceMapping()
		{
			this.TableName("OUINVOICE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.InvoNo).ColumnName("INVONO");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.InvoTime).ColumnName("INVOTIME");
			  
			this.Column(p =>p.Beprice).ColumnName("BEPRICE");
			  
			this.Column(p =>p.FactGet).ColumnName("FACTGET");
			  
			this.Column(p =>p.Insurance).ColumnName("INSURANCE");
			  
			this.Column(p =>p.PaySelf).ColumnName("PAYSELF");
			  
			this.Column(p =>p.AmountPay).ColumnName("AMOUNTPAY");
			  
			this.Column(p =>p.AddFee).ColumnName("ADDFEE");
			  
			this.Column(p =>p.TallyNo).ColumnName("TALLYNO");
			  
			this.Column(p =>p.Remark).ColumnName("REMARK");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsCancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.CancelOperTime).ColumnName("CANCELOPERTIME");
			  
			this.Column(p =>p.CancelOperId).ColumnName("CANCELOPERID");
			  
			this.Column(p =>p.CancelMemo).ColumnName("CANCELMEMO");
			  
			this.Column(p =>p.InvoLastId).ColumnName("INVOLASTID");
			  
			this.Column(p =>p.TallyTime).ColumnName("TALLYTIME");
			  
			this.Column(p =>p.CancelTallyTime).ColumnName("CANCELTALLYTIME");
			  
			this.Column(p =>p.ReAmount).ColumnName("REAMOUNT");
			  
			this.Column(p =>p.ReAmountDate).ColumnName("REAMOUNTDATE");
			  
			this.Column(p =>p.ReAmountMemo).ColumnName("REAMOUNTMEMO");
			  
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.CheckTime).ColumnName("CHECKTIME");
			  
			this.Column(p =>p.CancelCheckTime).ColumnName("CANCELCHECKTIME");
			  
			this.Column(p =>p.DocLocId).ColumnName("DOCLOCID");
			  
			this.Column(p =>p.CancelHospital).ColumnName("CANCELHOSPITAL");
			  
			this.Column(p =>p.YbSeqNo).ColumnName("YBSEQNO");
			  
			this.Column(p =>p.ReReprintOperId).ColumnName("REREPRINTOPERID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.PackaDiscount).ColumnName("PACKADISCOUNT");
			  
			this.Column(p =>p.FixedDiscount).ColumnName("FIXEDDISCOUNT");
			  
			this.Column(p =>p.FixedSubsidy).ColumnName("FIXEDSUBSIDY");
			  
			this.Column(p =>p.VipCardID).ColumnName("VIPCARDID");
			  
			this.Column(p =>p.ArrearsTypeId).ColumnName("ARREARSTYPEID");
			  
			this.Column(p =>p.HideOperTime).ColumnName("HIDEOPERTIME");
			  
			this.Column(p =>p.HideOperID).ColumnName("HIDEOPERID");
			  
			this.Column(p =>p.IsHide).ColumnName("ISHIDE");
			  
			this.Column(p =>p.PreviousArrears).ColumnName("PREVIOUSARREARS");
			  
			this.Column(p =>p.CurrentPay).ColumnName("CURRENTPAY");
			  
			this.Column(p =>p.CurrentArrears).ColumnName("CURRENTARREARS");
			  
			this.Column(p =>p.TallyCancelOperId).ColumnName("TALLYCANCELOPERID");
			  
			this.Column(p =>p.LsRepType).ColumnName("LSREPTYPE");
			 
			this.Column(p =>p.AccountAmount).ColumnName("ACCOUNTAMOUNT");

			this.Column(p =>p.IsTally).ColumnName("ISTALLY");

            this.Column(p => p.IsVerify).ColumnName("IsVerify");


            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

