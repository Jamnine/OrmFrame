

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class BsLimitDocLevMapping: ClassMap<BsLimitDocLev>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public BsLimitDocLevMapping()
		{
			this.TableName("BSLIMITDOCLEV").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LimitGroupId).ColumnName("LIMITGROUPID");
			  
			this.Column(p =>p.DocLevId).ColumnName("DOCLEVID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.TypeGFXEId).ColumnName("TYPEGFXEID");
			  
			this.Column(p =>p.LimitFeeMz).ColumnName("LIMITFEEMZ");
			  
			this.Column(p =>p.LimitFeeZy).ColumnName("LIMITFEEZY");
			  
			this.Column(p =>p.LsLimitType).ColumnName("LSLIMITTYPE");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

