

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class InPatLogBedMapping: ClassMap<InPatLogBed>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public InPatLogBedMapping()
		{
			this.TableName("INPATLOGBED").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.lsInstatus).ColumnName("LSINSTATUS");
			  
			this.Column(p =>p.IsSum).ColumnName("ISSUM");
			  
			this.Column(p =>p.BedId).ColumnName("BEDID");
			  
			this.Column(p =>p.BedName).ColumnName("BEDNAME");
			  
			this.Column(p =>p.IsBaby).ColumnName("ISBABY");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

