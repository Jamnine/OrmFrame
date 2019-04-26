

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 控制面版治疗项目明细 - 实体类
	/// </summary>
	public partial class BsXdGroupDtlMapping: ClassMap<BsXdGroupDtl>
	{   
		/// <summary>
		/// 控制面版治疗项目明细 - 实体类
		/// </summary>
		public BsXdGroupDtlMapping()
		{
			this.TableName("BSXDGROUPDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.GroupId).ColumnName("GROUPID");
			  
			this.Column(p =>p.XdRpId).ColumnName("XDRPID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.LsOpenType).ColumnName("LSOPENTYPE");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

