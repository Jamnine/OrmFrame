

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DtpropertiesMapping : ClassMap<Dtproperties>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DtpropertiesMapping()
		{
			this.TableName("DTPROPERTIES").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.objectid).ColumnName("OBJECTID");
			  
			this.Column(p =>p.property).ColumnName("PROPERTY");
			  
			this.Column(p =>p.value).ColumnName("VALUE");
			  
			this.Column(p =>p.uvalue).ColumnName("UVALUE");
			  
			this.Column(p =>p.lvalue).ColumnName("LVALUE");
			  
			this.Column(p =>p.Version).ColumnName("VERSION");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

