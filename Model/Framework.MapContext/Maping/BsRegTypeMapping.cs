

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 挂号类别 - 实体类
	/// </summary>
	public partial class BsRegTypeMapping: ClassMap<BsRegType>
	{   
		/// <summary>
		/// 挂号类别 - 实体类
		/// </summary>
		public BsRegTypeMapping()
		{
			this.TableName("BSREGTYPE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.SpecdiagfeeitemID).ColumnName("SPECDIAGFEEITEMID");
			  
			this.Column(p =>p.Price).ColumnName("PRICE");
			  
			this.Column(p =>p.Isupdateinchrage).ColumnName("ISUPDATEINCHRAGE");
			  
			this.Column(p =>p.ModioperID).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.Moditime).ColumnName("MODITIME");
			  
			this.Column(p =>p.Isdefault).ColumnName("ISDEFAULT");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

