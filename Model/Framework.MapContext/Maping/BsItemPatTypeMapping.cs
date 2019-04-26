

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 项目对应病人类别 - 实体类
	/// </summary>
	public partial class BsItemPatTypeMapping: ClassMap<BsItemPatType>
	{   
		/// <summary>
		/// 项目对应病人类别 - 实体类
		/// </summary>
		public BsItemPatTypeMapping()
		{
			this.TableName("BSITEMPATTYPE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.DiscDiag).ColumnName("DISCDIAG");
			  
			this.Column(p =>p.DiscIn).ColumnName("DISCIN");
			  
			this.Column(p =>p.InvMzItemId).ColumnName("INVMZITEMID");
			  
			this.Column(p =>p.InvInItemId).ColumnName("INVINITEMID");
			  
			this.Column(p =>p.LimitGroupId).ColumnName("LIMITGROUPID");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.UpCode).ColumnName("UPCODE");
			  
			this.Column(p =>p.YbCode).ColumnName("YBCODE");
			  
			this.Column(p =>p.ModioperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

