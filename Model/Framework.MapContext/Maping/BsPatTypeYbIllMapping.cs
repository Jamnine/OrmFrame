

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class BsPatTypeYbIllMapping: ClassMap<BsPatTypeYbIll>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public BsPatTypeYbIllMapping()
		{
			this.TableName("BSPATTYPEYBILL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.TallyTypeId).ColumnName("TALLYTYPEID");
			  
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.YbCode).ColumnName("YBCODE");
			  
			this.Column(p =>p.YbDesc).ColumnName("YBDESC");
			  
			this.Column(p =>p.IllIds).ColumnName("ILLIDS");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

