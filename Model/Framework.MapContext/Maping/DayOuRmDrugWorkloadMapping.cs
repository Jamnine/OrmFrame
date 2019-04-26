

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DayOuRmDrugWorkloadMapping: ClassMap<DayOuRmDrugWorkload>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DayOuRmDrugWorkloadMapping()
		{
			this.TableName("DAYOURMDRUGWORKLOAD").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.RecipeShu).ColumnName("RECIPESHU");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.RoomId).ColumnName("ROOMID");
			  
			this.Column(p =>p.RecipeDtlShu).ColumnName("RECIPEDTLSHU");
			  
			this.Column(p =>p.HowMany).ColumnName("HOWMANY");
			  
			this.Column(p =>p.Isback).ColumnName("ISBACK");
			  
			this.Column(p =>p.IsDoctorInPut).ColumnName("ISDOCTORINPUT");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

