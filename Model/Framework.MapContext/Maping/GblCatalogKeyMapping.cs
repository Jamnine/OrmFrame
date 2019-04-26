

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 关键元素快捷录入 - 实体类
	/// </summary>
	public partial class GblCatalogKeyMapping: ClassMap<GblCatalogKey>
	{   
		/// <summary>
		/// 关键元素快捷录入 - 实体类
		/// </summary>
		public GblCatalogKeyMapping()
		{
			this.TableName("GBLCATALOGKEY").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.CatalogId).ColumnName("CATALOGID");
			  
			this.Column(p =>p.XmlField).ColumnName("XMLFIELD");
			  
			this.Column(p =>p.KeyFile).ColumnName("KEYFILE");
			  
			this.Column(p =>p.TmpWord).ColumnName("TMPWORD");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

