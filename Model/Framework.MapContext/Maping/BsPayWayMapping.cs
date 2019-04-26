

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 支付方式表 - 实体类
	/// </summary>
	public partial class BsPayWayMapping: ClassMap<BsPayWay>
	{   
		/// <summary>
		/// 支付方式表 - 实体类
		/// </summary>
		public BsPayWayMapping()
		{
			this.TableName("BSPAYWAY").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.GroupType).ColumnName("GROUPTYPE");
			  
			this.Column(p =>p.IsShowAmount).ColumnName("ISSHOWAMOUNT");
			  
			this.Column(p =>p.IsBackByCash).ColumnName("ISBACKBYCASH");
			  
			this.Column(p =>p.IsnotModified).ColumnName("ISNOTMODIFIED");
			  
			this.Column(p =>p.ModioPerId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsShowinInvoice).ColumnName("ISSHOWININVOICE");
			  
			this.Column(p =>p.IsBackCash).ColumnName("ISBACKCASH");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

