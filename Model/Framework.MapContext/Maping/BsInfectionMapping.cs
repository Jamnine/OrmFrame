

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 传染病报告卡 - 实体类
	/// </summary>
	public partial class BsInfectionMapping: ClassMap<BsInfection>
	{   
		/// <summary>
		/// 传染病报告卡 - 实体类
		/// </summary>
		public BsInfectionMapping()
		{
			this.TableName("BSINFECTION").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Type).ColumnName("TYPE");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.Orderby).ColumnName("ORDERBY");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

