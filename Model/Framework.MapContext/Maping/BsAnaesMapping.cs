

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 麻醉方法表 - 实体类
	/// </summary>
	public partial class BsAnaesMapping: ClassMap<BsAnaes>
	{   
		/// <summary>
		/// 麻醉方法表 - 实体类
		/// </summary>
		public BsAnaesMapping()
		{
			this.TableName("BSANAES").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.FunctionM).ColumnName("FUNCTIONM");
			  
			this.Column(p =>p.Effect).ColumnName("EFFECT");
			  
			this.Column(p =>p.Tabu).ColumnName("TABU");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.Memo).ColumnName("MEMO");



            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

