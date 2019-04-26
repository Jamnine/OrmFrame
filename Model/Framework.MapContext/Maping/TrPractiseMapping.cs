

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class TrPractiseMapping: ClassMap<TrPractise>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public TrPractiseMapping()
		{
			this.TableName("TRPRACTISE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Hospital).ColumnName("HOSPITAL");
			  
			this.Column(p =>p.OriId).ColumnName("ORIID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.PractiseTime).ColumnName("PRACTISETIME");
			  
			this.Column(p =>p.DebugMode).ColumnName("DEBUGMODE");
			  
			this.Column(p =>p.Funtion).ColumnName("FUNTION");
			  
			this.Column(p =>p.UserName).ColumnName("USERNAME");
			  
			this.Column(p =>p.RoleName).ColumnName("ROLENAME");
			  
			this.Column(p =>p.LocationName).ColumnName("LOCATIONNAME");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

