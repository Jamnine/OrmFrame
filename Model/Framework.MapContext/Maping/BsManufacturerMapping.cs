

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 生产厂商 - 实体类
	/// </summary>
	public partial class BsManufacturerMapping: ClassMap<BsManufacturer>
	{   
		/// <summary>
		/// 生产厂商 - 实体类
		/// </summary>
		public BsManufacturerMapping()
		{
			this.TableName("BSMANUFACTURER").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.LsKind).ColumnName("LSKIND");
			  
			this.Column(p =>p.AreaCode).ColumnName("AREACODE");
			  
			this.Column(p =>p.Address).ColumnName("ADDRESS");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.LsType).ColumnName("LSTYPE");
			  
			this.Column(p =>p.LicenceCode).ColumnName("LICENCECODE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.Moditime).ColumnName("MODITIME");

            this.Column(p => p.ModioperId).ColumnName("MODIOPERID");

            this.Column(p => p.HouseId).ColumnName("HouseId");
          
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

