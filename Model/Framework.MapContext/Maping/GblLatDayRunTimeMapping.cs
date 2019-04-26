

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 最后自动收费时间 - 实体类
	/// </summary>
	public partial class GblLatDayRunTimeMapping: ClassMap<GblLatDayRunTime>
	{   
		/// <summary>
		/// 最后自动收费时间 - 实体类
		/// </summary>
		public GblLatDayRunTimeMapping()
		{
			this.TableName("GBLLATDAYRUNTIME").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LastTime).ColumnName("LASTTIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

