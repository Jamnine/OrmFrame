

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 旧在院日志 - 实体类
	/// </summary>
	public partial class InLogStatusInOldMapping: ClassMap<InLogStatusInOld>
	{   
		/// <summary>
		/// 旧在院日志 - 实体类
		/// </summary>
		public InLogStatusInOldMapping()
		{
			this.TableName("INLOGSTATUSINOLD").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.LocationID).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LsInIllness).ColumnName("LSINILLNESS");
			  
			this.Column(p =>p.lsinstatus).ColumnName("LSINSTATUS");
			  
			this.Column(p =>p.bedName).ColumnName("BEDNAME");
			  
			this.Column(p =>p.bedid).ColumnName("BEDID");
			  
			this.Column(p =>p.Isbaby).ColumnName("ISBABY");
			  
			this.Column(p =>p.IsSum).ColumnName("ISSUM");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

