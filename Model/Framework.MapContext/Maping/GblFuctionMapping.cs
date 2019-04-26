

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 菜单功能表 - 实体类
	/// </summary>
	public partial class GblFuctionMapping: ClassMap<GblFuction>
	{   
		/// <summary>
		/// 菜单功能表 - 实体类
		/// </summary>
		public GblFuctionMapping()
		{
			this.TableName("GBLFUCTION").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.MenuId).ColumnName("MENUID");
			  
			this.Column(p =>p.Title).ColumnName("TITLE");
			  
			this.Column(p =>p.Content).ColumnName("CONTENT");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsTest).ColumnName("ISTEST");
			  
			this.Column(p =>p.LsClass).ColumnName("LSCLASS");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

