

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:通讯记录(通话，短信，微信推送) - 实体类
	/// </summary>
	public partial class OuCommunicateLogMapping: ClassMap<OuCommunicateLog>
	{   
		/// <summary>
		/// 行心云:通讯记录(通话，短信，微信推送) - 实体类
		/// </summary>
		public OuCommunicateLogMapping()
		{
			this.TableName("OUCOMMUNICATELOG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Phone).ColumnName("PHONE");
			  
			this.Column(p =>p.Comments).ColumnName("COMMENTS");
			  
			this.Column(p =>p.Type).ColumnName("TYPE");
			  
			this.Column(p =>p.Notifytype).ColumnName("NOTIFYTYPE");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.Servicetime).ColumnName("SERVICETIME");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

