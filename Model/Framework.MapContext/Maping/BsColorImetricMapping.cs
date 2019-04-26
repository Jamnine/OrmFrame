

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:比色 - 实体类
	/// </summary>
	public partial class BsColorImetricMapping: ClassMap<BsColorImetric>
	{   
		/// <summary>
		/// 行心云:比色 - 实体类
		/// </summary>
		public BsColorImetricMapping()
		{
			this.TableName("BSCOLORIMETRIC").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.Moditime).ColumnName("MODITIME");
			  
			this.Column(p =>p.ModioperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

