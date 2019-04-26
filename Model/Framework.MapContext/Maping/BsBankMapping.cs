

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 银行终端 - 实体类
	/// </summary>
	public partial class BsBankMapping: ClassMap<BsBank>
	{   
		/// <summary>
		/// 银行终端 - 实体类
		/// </summary>
		public BsBankMapping()
		{
			this.TableName("BSBANK").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");
             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

