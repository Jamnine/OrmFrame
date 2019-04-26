

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 评估中的常见/罕见 - 实体类
	/// </summary>
	public partial class BsDiagnoseMapping: ClassMap<BsDiagnose>
	{   
		/// <summary>
		/// 评估中的常见/罕见 - 实体类
		/// </summary>
		public BsDiagnoseMapping()
		{
			this.TableName("BSDIAGNOSE").Schema("orm");
			  
			this.Column(p =>p.Diagnose).ColumnName("DIAGNOSE");
			  
			this.Column(p =>p.History).ColumnName("HISTORY");
			  
			this.Column(p =>p.IsCommon).ColumnName("ISCOMMON");
			  
			this.Column(p =>p.Examine).ColumnName("EXAMINE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.XmlId).ColumnName("XMLID"); 

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }      
	}  
}           
 

