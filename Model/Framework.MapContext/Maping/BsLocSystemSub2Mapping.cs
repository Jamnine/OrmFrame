

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 多媒体——科室分类表3 - 实体类
	/// </summary>
	public partial class BsLocSystemSub2Mapping: ClassMap<BsLocSystemSub2>
	{   
		/// <summary>
		/// 多媒体——科室分类表3 - 实体类
		/// </summary>
		public BsLocSystemSub2Mapping()
		{
			this.TableName("BSLOCSYSTEMSUB2").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.SubId).ColumnName("SUBID");
			  
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
 

