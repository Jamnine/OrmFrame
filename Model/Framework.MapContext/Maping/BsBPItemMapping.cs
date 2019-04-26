

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// BP的基础项目表 - 实体类
	/// </summary>
	public partial class BsBPItemMapping: ClassMap<BsBPItem>
	{   
		/// <summary>
		/// BP的基础项目表 - 实体类
		/// </summary>
		public BsBPItemMapping()
		{
			this.TableName("BSBPITEM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.LsRpType).ColumnName("LSRPTYPE");
			  
			this.Column(p =>p.YbCode).ColumnName("YBCODE");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

