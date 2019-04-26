

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CsLocServiceMapping: ClassMap<CsLocService>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CsLocServiceMapping()
		{
			this.TableName("CSLOCSERVICE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LocId).ColumnName("LOCID");
			  
			this.Column(p =>p.LogisticServeId).ColumnName("LOGISTICSERVEID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

