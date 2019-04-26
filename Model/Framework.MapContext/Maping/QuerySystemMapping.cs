

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 叫号系统 - 实体类
	/// </summary>
	public partial class QuerySystemMapping: ClassMap<QuerySystem>
	{   
		/// <summary>
		/// 叫号系统 - 实体类
		/// </summary>
		public QuerySystemMapping()
		{
			this.TableName("QUERYSYSTEM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.DepartmentName).ColumnName("DEPARTMENTNAME");
			  
			this.Column(p =>p.DoctorName).ColumnName("DOCTORNAME");
			  
			this.Column(p =>p.Comments).ColumnName("COMMENTS");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.Floor).ColumnName("FLOOR");
			  
			this.Column(p =>p.MzregId).ColumnName("MZREGID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

