

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 限额 - 实体类
	/// </summary>
	public partial class BsLimitGroupMapping: ClassMap<BsLimitGroup>
	{   
		/// <summary>
		/// 限额 - 实体类
		/// </summary>
		public BsLimitGroupMapping()
		{
			this.TableName("BSLIMITGROUP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.TypeGFXEId).ColumnName("TYPEGFXEID");
			  
			this.Column(p =>p.LimitFeeMz).ColumnName("LIMITFEEMZ");
			  
			this.Column(p =>p.LimitFeeZy).ColumnName("LIMITFEEZY");
			  
			this.Column(p =>p.LsLimitType).ColumnName("LSLIMITTYPE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.DocLevelId).ColumnName("DOCLEVELID");


            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

