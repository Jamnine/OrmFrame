

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 电子病历元素互读表 - 实体类
	/// </summary>
	public partial class GblCatalogJoinMapping: ClassMap<GblCatalogJoin>
	{   
		/// <summary>
		/// 电子病历元素互读表 - 实体类
		/// </summary>
		public GblCatalogJoinMapping()
		{
			this.TableName("GBLCATALOGJOIN").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.CatalogId1).ColumnName("CATALOGID1");
			  
			this.Column(p =>p.XmlField1).ColumnName("XMLFIELD1");
			  
			this.Column(p =>p.CatalogId2).ColumnName("CATALOGID2");
			  
			this.Column(p =>p.XmlField2).ColumnName("XMLFIELD2");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

