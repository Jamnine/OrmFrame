

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院操作日志表 - 实体类
	/// </summary>
	public partial class TrInActionlogMapping: ClassMap<TrInActionlog>
	{   
		/// <summary>
		/// 住院操作日志表 - 实体类
		/// </summary>
		public TrInActionlogMapping()
		{
			this.TableName("TRINACTIONLOG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Button).ColumnName("BUTTON");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.HostName).ColumnName("HOSTNAME");
			  
			this.Column(p =>p.Error).ColumnName("ERROR");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.TableName).ColumnName("TABLENAME");
			  
			this.Column(p =>p.PkId).ColumnName("PKID");
			  
			this.Column(p =>p.ActionDesc).ColumnName("ACTIONDESC");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

