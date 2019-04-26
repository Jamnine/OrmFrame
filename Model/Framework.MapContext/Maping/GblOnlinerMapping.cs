

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 客户端在线列表 - 实体类
	/// </summary>
	public partial class GblOnlinerMapping: ClassMap<GblOnliner>
	{   
		/// <summary>
		/// 客户端在线列表 - 实体类
		/// </summary>
		public GblOnlinerMapping()
		{
			this.TableName("GBLONLINER").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.UserId).ColumnName("USERID");
			  
			this.Column(p =>p.WorkStationName).ColumnName("WORKSTATIONNAME");
			  
			this.Column(p =>p.LockIp).ColumnName("LOCKIP");
			  
			this.Column(p =>p.LoginTime).ColumnName("LOGINTIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

