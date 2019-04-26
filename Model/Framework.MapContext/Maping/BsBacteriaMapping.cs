

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 球菌库 - 实体类
	/// </summary>
	public partial class BsBacteriaMapping: ClassMap<BsBacteria>
	{   
		/// <summary>
		/// 球菌库 - 实体类
		/// </summary>
		public BsBacteriaMapping()
		{
			this.TableName("BSBACTERIA").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.TypeId).ColumnName("TYPEID");
			  
			this.Column(p =>p.GramsId).ColumnName("GRAMSID");
			  
			this.Column(p =>p.ShuId).ColumnName("SHUID");
			  
			this.Column(p =>p.StandTypeId).ColumnName("STANDTYPEID");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

