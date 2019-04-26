

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DayOuRecipeWorkloadMapping: ClassMap<DayOuRecipeWorkload>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DayOuRecipeWorkloadMapping()
		{
			this.TableName("DAYOURECIPEWORKLOAD").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.ClincRc).ColumnName("CLINCRC");
			  
			this.Column(p =>p.RecipeDtlShu).ColumnName("RECIPEDTLSHU");
			  
			this.Column(p =>p.LsRepType).ColumnName("LSREPTYPE");
			  
			this.Column(p =>p.IsDoctorInPut).ColumnName("ISDOCTORINPUT");
			  
			this.Column(p =>p.IsBp).ColumnName("ISBP");
			  
			this.Column(p =>p.OuEmrRc).ColumnName("OUEMRRC");
			  
			this.Column(p =>p.IsXY).ColumnName("ISXY");
			  
			this.Column(p =>p.Iszy).ColumnName("ISZY");
			  
			this.Column(p =>p.Iszcy).ColumnName("ISZCY");
			  
			this.Column(p =>p.Isylzj).ColumnName("ISYLZJ");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

