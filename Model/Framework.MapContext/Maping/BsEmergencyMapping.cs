

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 应急考虑 - 实体类
	/// </summary>
	public partial class BsEmergencyMapping: ClassMap<BsEmergency>
	{   
		/// <summary>
		/// 应急考虑 - 实体类
		/// </summary>
		public BsEmergencyMapping()
		{
			this.TableName("BSEMERGENCY").Schema("orm");
			  
			this.Column(p =>p.Title).ColumnName("TITLE");
			  
			this.Column(p =>p.Detial).ColumnName("DETIAL");
			  
			this.Column(p =>p.XmlId).ColumnName("XMLID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);

        }      
	}  
}           
 

