

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 锁信息 - 实体类
	/// </summary>
	public partial class GblKeyLockSettingMapping: ClassMap<GblKeyLockSetting>
	{   
		/// <summary>
		/// 锁信息 - 实体类
		/// </summary>
		public GblKeyLockSettingMapping()
		{
			this.TableName("GBLKEYLOCKSETTING").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.KeyTypeId).ColumnName("KEYTYPEID");
			  
			this.Column(p =>p.KeyValue).ColumnName("KEYVALUE");
			  
			this.Column(p =>p.WorkStationName).ColumnName("WORKSTATIONNAME");
			  
			this.Column(p =>p.UserId).ColumnName("USERID");
			  
			this.Column(p =>p.UserName).ColumnName("USERNAME");
			  
			this.Column(p =>p.LockIp).ColumnName("LOCKIP");
			  
			this.Column(p =>p.LockTime).ColumnName("LOCKTIME");
			  
			this.Column(p =>p.SpID).ColumnName("SPID");
			  
			this.Column(p =>p.LoginTime).ColumnName("LOGINTIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

