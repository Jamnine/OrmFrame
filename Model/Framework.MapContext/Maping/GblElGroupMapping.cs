

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 健康档案分组 - 实体类
	/// </summary>
	public partial class GblElGroupMapping: ClassMap<GblElGroup>
	{   
		/// <summary>
		/// 健康档案分组 - 实体类
		/// </summary>
		public GblElGroupMapping()
		{
			this.TableName("GBLELGROUP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LsType).ColumnName("LSTYPE");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.HisType).ColumnName("HISTYPE");

            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");




            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

