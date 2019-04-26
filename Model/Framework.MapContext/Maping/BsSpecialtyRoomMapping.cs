

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 专业科室 - 实体类
	/// </summary>
	public partial class BsSpecialtyRoomMapping: ClassMap<BsSpecialtyRoom>
	{   
		/// <summary>
		/// 专业科室 - 实体类
		/// </summary>
		public BsSpecialtyRoomMapping()
		{
			this.TableName("BSSPECIALTYROOM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");

            this.Column(p => p.Code).ColumnName("CODE");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.HospitalID).ColumnName("HospitalID"); 
            this.Column(p => p.WBCode).ColumnName("WBCODE");
            this.Column(p => p.PYCode).ColumnName("PYCODE");
            this.Column(p => p.OrderBY).ColumnName("ORDERBY"); 
            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");
            this.Column(p => p.HospitalID).ColumnName("HospitalID"); 


             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

