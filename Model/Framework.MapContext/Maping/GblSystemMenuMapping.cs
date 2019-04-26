

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 系统菜单 - 实体类
	/// </summary>
	public partial class GblSystemMenuMapping: ClassMap<GblSystemMenu>
	{   
		/// <summary>
		/// 系统菜单 - 实体类
		/// </summary>
		public GblSystemMenuMapping()
		{
			this.TableName("GBLSYSTEMMENU").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.FileName).ColumnName("FILENAME");

            this.Column(p => p.ProcName).ColumnName("PROCNAME");

            this.Column(p =>p.SystemId).ColumnName("SYSTEMID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.Hint).ColumnName("HINT");
			  
			this.Column(p =>p.Shortcut).ColumnName("SHORTCUT");
			  
			this.Column(p =>p.ParentID).ColumnName("PARENTID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsMostUsed).ColumnName("ISMOSTUSED");
			  
			this.Column(p =>p.IsBeginGroup).ColumnName("ISBEGINGROUP");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.DocPath).ColumnName("DOCPATH");
			  
			this.Column(p =>p.VideoPath).ColumnName("VIDEOPATH");
			  
			this.Column(p =>p.ReportType).ColumnName("REPORTTYPE");
			  
			this.Column(p =>p.IsSelect).ColumnName("ISSELECT");
			  
			this.Column(p =>p.Url).ColumnName("URL");
			  
			this.Column(p =>p.HelpAddress).ColumnName("HELPADDRESS");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.HisType).ColumnName("HisType");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

