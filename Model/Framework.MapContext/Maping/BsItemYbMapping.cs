

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 项目对应医保码 - 实体类
	/// </summary>
	public partial class BsItemYbMapping: ClassMap<BsItemYb>
	{   
		/// <summary>
		/// 项目对应医保码 - 实体类
		/// </summary>
		public BsItemYbMapping()
		{
			this.TableName("BSITEMYB").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.TallyGroupId).ColumnName("TALLYGROUPID");
			  
			this.Column(p =>p.YbCode).ColumnName("YBCODE");
			  
			this.Column(p =>p.YbDesc).ColumnName("YBDESC");
			  
			this.Column(p =>p.LsYbType).ColumnName("LSYBTYPE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.LsAuthstatus).ColumnName("LSAUTHSTATUS");
			  
			this.Column(p =>p.DrugCode).ColumnName("DRUGCODE");
			  
			this.Column(p =>p.YblimitCue).ColumnName("YBLIMITCUE");
			  
			this.Column(p =>p.IsYblimit).ColumnName("ISYBLIMIT");
			  
			this.Column(p =>p.UpCode).ColumnName("UPCODE");
			  
			this.Column(p =>p.ModioperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

