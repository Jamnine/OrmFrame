

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DayOuGhRcMapping: ClassMap<DayOuGhRc>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DayOuGhRcMapping()
		{
			this.TableName("DAYOUGHRC").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.GhRc).ColumnName("GHRC");
			  
			this.Column(p =>p.IsRegistration).ColumnName("ISREGISTRATION");
			  
			this.Column(p =>p.FzRc).ColumnName("FZRC");
			  
			this.Column(p =>p.IsPreReg).ColumnName("ISPREREG");
			  
			this.Column(p =>p.YuYueType).ColumnName("YUYUETYPE");
			  
			this.Column(p =>p.JxFzRc).ColumnName("JXFZRC");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

