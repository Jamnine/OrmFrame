

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext 
{
	/// <summary>
	/// 出院日志表 - 实体类
	/// </summary>
	public partial class InLogOutHospitalMapping: ClassMap<InLogOutHospital>
	{   
		/// <summary>
		/// 出院日志表 - 实体类 
		/// </summary>
		public InLogOutHospitalMapping()
		{
			this.TableName("INLOGOUTHOSPITAL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.LocationID).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.IsSum).ColumnName("ISSUM");
			  
			this.Column(p =>p.Days).ColumnName("DAYS");
			  
			this.Column(p =>p.HospitalID).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

