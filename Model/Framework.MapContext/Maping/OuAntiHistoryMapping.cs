

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:预防接种史 - 实体类
	/// </summary>
	public partial class OuAntiHistoryMapping: ClassMap<OuAntiHistory>
	{   
		/// <summary>
		/// 行心云:预防接种史 - 实体类
		/// </summary>
		public OuAntiHistoryMapping()
		{
			this.TableName("OUANTIHISTORY").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Healthcheckuseid).ColumnName("HEALTHCHECKUSEID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Antihistorydate).ColumnName("ANTIHISTORYDATE");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

