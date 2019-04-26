

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class GblCatalogExceptMapping: ClassMap<GblCatalogExcept>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public GblCatalogExceptMapping()
		{
			this.TableName("GBLCATALOGEXCEPT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.CatalogId).ColumnName("CATALOGID");
			  
			this.Column(p =>p.XmlField).ColumnName("XMLFIELD");
			  
			this.Column(p =>p.IsHide).ColumnName("ISHIDE");
			  
			this.Column(p =>p.DefaultValue).ColumnName("DEFAULTVALUE");
			  
			this.Column(p =>p.IsBaby).ColumnName("ISBABY");
			  
			this.Column(p =>p.IsWomen).ColumnName("ISWOMEN");
			  
			this.Column(p =>p.IsMen).ColumnName("ISMEN");
			  
			this.Column(p =>p.IsOlder).ColumnName("ISOLDER");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

