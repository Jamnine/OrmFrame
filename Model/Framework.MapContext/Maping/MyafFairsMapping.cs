

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:医生日常事务表 - 实体类
	/// </summary>
	public partial class MyafFairsMapping: ClassMap<MyafFairs>
	{   
		/// <summary>
		/// 行心云:医生日常事务表 - 实体类
		/// </summary>
		public MyafFairsMapping()
		{
			this.TableName("MYAFFAIRS").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.Content).ColumnName("CONTENT");
			  
			this.Column(p =>p.AffairTime).ColumnName("AFFAIRTIME");
			  
			this.Column(p =>p.LastUpdateTime).ColumnName("LASTUPDATETIME");
			  
			this.Column(p =>p.RemindUserId).ColumnName("REMINDUSERID");
			  
			this.Column(p =>p.RemindUserName).ColumnName("REMINDUSERNAME");
			  
			this.Column(p =>p.LsState).ColumnName("LSSTATE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

