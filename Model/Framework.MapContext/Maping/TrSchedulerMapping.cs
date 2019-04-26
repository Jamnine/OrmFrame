

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class TrSchedulerMapping: ClassMap<TrScheduler>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public TrSchedulerMapping()
		{
			this.TableName("TRSCHEDULER").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.UserId).ColumnName("USERID");
			  
			this.Column(p =>p.LineId).ColumnName("LINEID");
			  
			this.Column(p =>p.ScheTime).ColumnName("SCHETIME");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

