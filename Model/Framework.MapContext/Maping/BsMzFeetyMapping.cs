

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊基础分类 - 实体类
	/// </summary>
	public partial class BsMzFeetyMapping: ClassMap<BsMzFeety>
	{   
		/// <summary>
		/// 门诊基础分类 - 实体类
		/// </summary>
		public BsMzFeetyMapping()
		{
			this.TableName("BSMZFEETY").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.InvItemId).ColumnName("INVITEMID");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.CheckType).ColumnName("CHECKTYPE");
			  
			this.Column(p =>p.CheckOrderby).ColumnName("CHECKORDERBY");
			  
			this.Column(p =>p.CheckGroup).ColumnName("CHECKGROUP");

            this.Column(p => p.Moditime).ColumnName("MODITIME");

            this.Column(p => p.ModioperId).ColumnName("MODIOPERID");
            this.Column(p => p.YbCode).ColumnName("YBCode");

            this.Column(p => p.UpCode).ColumnName("UPCODE");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            



            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

