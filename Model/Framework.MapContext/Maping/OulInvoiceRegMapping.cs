

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊挂号发票表 - 实体类
	/// </summary>
	public partial class OulInvoiceRegMapping: ClassMap<OulInvoiceReg>
	{   
		/// <summary>
		/// 门诊挂号发票表 - 实体类
		/// </summary>
		public OulInvoiceRegMapping()
		{
			this.TableName("OULINVOICEREG").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.InvoNo).ColumnName("INVONO");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.InvoTime).ColumnName("INVOTIME");
			  
			this.Column(p =>p.RegFee).ColumnName("REGFEE");
			  
			this.Column(p =>p.DiagnoFee).ColumnName("DIAGNOFEE");
			  
			this.Column(p =>p.TallyDiag).ColumnName("TALLYDIAG");
			  
			this.Column(p =>p.ZyFee).ColumnName("ZYFEE");
			  
			this.Column(p =>p.OtherFee1).ColumnName("OTHERFEE1");
			  
			this.Column(p =>p.OtherFee2).ColumnName("OTHERFEE2");
			  
			this.Column(p =>p.PayWayId).ColumnName("PAYWAYID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsCancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.CancelTime).ColumnName("CANCELTIME");
			  
			this.Column(p =>p.CancelOperId).ColumnName("CANCELOPERID");
			  
			this.Column(p =>p.InvoLastId).ColumnName("INVOLASTID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			  
			this.Column(p =>p.RegTypeId).ColumnName("REGTYPEID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.CheckTime).ColumnName("CHECKTIME");
			  
			this.Column(p =>p.CancelCheckTime).ColumnName("CANCELCHECKTIME");
			  
			this.Column(p =>p.DocLocId).ColumnName("DOCLOCID");
			  
			this.Column(p =>p.OrderWXID).ColumnName("ORDERWXID");
			  
			this.Column(p =>p.IsRegDoctorTemp).ColumnName("ISREGDOCTORTEMP");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.BHOSName).ColumnName("BHOSNAME");


             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

