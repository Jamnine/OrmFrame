

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 功能权限修改记录 - 实体类
	/// </summary>
	public partial class GblFunTraceMapping: ClassMap<GblFunTrace>
	{   
		/// <summary>
		/// 功能权限修改记录 - 实体类
		/// </summary>
		public GblFunTraceMapping()
		{
			this.TableName("GBLFUNTRACE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.DebugMode).ColumnName("DEBUGMODE");
			  
			this.Column(p =>p.FuntionId).ColumnName("FUNTIONID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.UserID).ColumnName("USERID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.MenuId).ColumnName("MENUID");
			  
			this.Column(p =>p.Title).ColumnName("TITLE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

