

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 每日数据质量信息 - 实体类
	/// </summary>
	public partial class GblTraceMapping: ClassMap<GblTrace>
	{   
		/// <summary>
		/// 每日数据质量信息 - 实体类
		/// </summary>
		public GblTraceMapping()
		{
			this.TableName("GBLTRACE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.SqlString).ColumnName("SQLSTRING");
			  
			this.Column(p =>p.WhereCondition).ColumnName("WHERECONDITION");
			  
			this.Column(p =>p.OrderByExpression).ColumnName("ORDERBYEXPRESSION");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

