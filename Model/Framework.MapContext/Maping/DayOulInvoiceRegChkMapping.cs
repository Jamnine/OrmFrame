

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DayOulInvoiceRegChkMapping: ClassMap<DayOulInvoiceRegChk>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DayOulInvoiceRegChkMapping()
		{
			this.TableName("DAYOULINVOICEREGCHK").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.RegFee).ColumnName("REGFEE");
			  
			this.Column(p =>p.DiagnoFee).ColumnName("DIAGNOFEE");
			  
			this.Column(p =>p.TallyDiag).ColumnName("TALLYDIAG");
			  
			this.Column(p =>p.ZyFee).ColumnName("ZYFEE");
			  
			this.Column(p =>p.OtherFee1).ColumnName("OTHERFEE1");
			  
			this.Column(p =>p.OtherFee2).ColumnName("OTHERFEE2");
			  
			this.Column(p =>p.OtherFee3).ColumnName("OTHERFEE3");
			  
			this.Column(p =>p.IsRegDoctorTemp).ColumnName("ISREGDOCTORTEMP");
			  
			this.Column(p =>p.BHosName).ColumnName("BHOSNAME");
			  
			this.Column(p =>p.PayWayId).ColumnName("PAYWAYID");
			  
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.RegTypeId).ColumnName("REGTYPEID");
			  
			this.Column(p =>p.InvoS).ColumnName("INVOS");
			  
			this.Column(p =>p.Rc).ColumnName("RC");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

