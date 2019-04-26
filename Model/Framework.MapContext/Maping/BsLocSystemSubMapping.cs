

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 多媒体——科室分类表2 - 实体类
	/// </summary>
	public partial class BsLocSystemSubMapping: ClassMap<BsLocSystemSub>
	{   
		/// <summary>
		/// 多媒体——科室分类表2 - 实体类
		/// </summary>
		public BsLocSystemSubMapping()
		{
			this.TableName("BSLOCSYSTEMSUB").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.MainId).ColumnName("MAINID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

