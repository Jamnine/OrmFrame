

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:患者划价表 - 实体类
	/// </summary>
	public partial class PatPricereCordsMapping: ClassMap<PatPricereCords>
	{   
		/// <summary>
		/// 行心云:患者划价表 - 实体类
		/// </summary>
		public PatPricereCordsMapping()
		{
			this.TableName("PATPRICERECORDS").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.HouId).ColumnName("HOUID");
			  
			this.Column(p =>p.Price).ColumnName("PRICE");
			  
			this.Column(p =>p.Remarks).ColumnName("REMARKS");
			  
			this.Column(p =>p.CordDate).ColumnName("CORDDATE");
			  
			this.Column(p =>p.DoctorID).ColumnName("DOCTORID");
			  
			this.Column(p =>p.IsCharge).ColumnName("ISCHARGE");
			  
			this.Column(p =>p.OuinvoiceID).ColumnName("OUINVOICEID");
			  
			this.Column(p =>p.NurseID).ColumnName("NURSEID");
			  
			this.Column(p =>p.ConsultID).ColumnName("CONSULTID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

