

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊发票分类 - 实体类
	/// </summary>
	public partial class BsInvMzItemMapping: ClassMap<BsInvMzItem>
	{   
		/// <summary>
		/// 门诊发票分类 - 实体类
		/// </summary>
		public BsInvMzItemMapping()
		{
			this.TableName("BSINVMZITEM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.GroupName).ColumnName("GROUPNAME");
			  
			this.Column(p =>p.GroupOrderBy).ColumnName("GROUPORDERBY");
			  
			this.Column(p =>p.IsAlone).ColumnName("ISALONE");
			  
			this.Column(p =>p.AmountorName).ColumnName("AMOUNTORNAME");
			  
			this.Column(p =>p.UpCode).ColumnName("UPCODE");
			  
			this.Column(p =>p.YBCode).ColumnName("YBCODE");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.OtherName).ColumnName("OTHERNAME");
			  
			this.Column(p =>p.ISPrintALONE).ColumnName("ISPRINTALONE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

