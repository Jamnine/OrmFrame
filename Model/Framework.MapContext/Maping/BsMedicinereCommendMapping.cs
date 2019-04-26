

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:中药推荐的关系表 - 实体类
	/// </summary>
	public partial class BsMedicinereCommendMapping: ClassMap<BsMedicinereCommend>
	{   
		/// <summary>
		/// 行心云:中药推荐的关系表 - 实体类
		/// </summary>
		public BsMedicinereCommendMapping()
		{
			this.TableName("BSMEDICINERECOMMEND").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.IllName).ColumnName("ILLNAME");
			  
			this.Column(p =>p.PatientGroup).ColumnName("PATIENTGROUP");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.Indication).ColumnName("INDICATION");
			  
			this.Column(p =>p.References).ColumnName("REFERENCES");
			  
			this.Column(p =>p.BsManuFacturerId).ColumnName("BSMANUFACTURERID");
			  
			this.Column(p =>p.ItemName).ColumnName("ITEMNAME");
			  
			this.Column(p =>p.Spec).ColumnName("SPEC");
			  
			this.Column(p =>p.Phone).ColumnName("PHONE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

