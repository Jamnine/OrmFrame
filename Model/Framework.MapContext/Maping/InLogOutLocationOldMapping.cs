

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 旧转科日志 - 实体类
	/// </summary>
	public partial class InLogOutLocationOldMapping: ClassMap<InLogOutLocationOld>
	{   
		/// <summary>
		/// 旧转科日志 - 实体类
		/// </summary>
		public InLogOutLocationOldMapping()
		{
			this.TableName("INLOGOUTLOCATIONOLD").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.LocationID).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.InLocId).ColumnName("INLOCID");
			  
			this.Column(p =>p.LsType).ColumnName("LSTYPE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsSum).ColumnName("ISSUM");
			  
			this.Column(p =>p.HospitalID).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

