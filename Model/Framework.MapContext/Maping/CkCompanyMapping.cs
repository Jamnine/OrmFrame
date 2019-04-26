

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检单位 - 实体类
	/// </summary>
	public partial class CkCompanyMapping: ClassMap<CkCompany>
	{   
		/// <summary>
		/// 体检单位 - 实体类
		/// </summary>
		public CkCompanyMapping()
		{
			this.TableName("CKCOMPANY").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Phone).ColumnName("PHONE");
			  
			this.Column(p =>p.Fax).ColumnName("FAX");
			  
			this.Column(p =>p.Address).ColumnName("ADDRESS");
			  
			this.Column(p =>p.PostCode).ColumnName("POSTCODE");
			  
			this.Column(p =>p.PayWayId).ColumnName("PAYWAYID");
			  
			this.Column(p =>p.Discount).ColumnName("DISCOUNT");
			  
			this.Column(p =>p.ResponMan).ColumnName("RESPONMAN");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");


             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

