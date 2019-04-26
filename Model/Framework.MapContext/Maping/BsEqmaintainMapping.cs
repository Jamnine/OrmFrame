

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class BsEqmaintainMapping: ClassMap<BsEqmaintain>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public BsEqmaintainMapping()
		{
			this.TableName("BSEQMAINTAIN").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.EquipmentId).ColumnName("EQUIPMENTID");
			  
			this.Column(p =>p.CompanyId).ColumnName("COMPANYID");
			  
			this.Column(p =>p.MaintainTime).ColumnName("MAINTAINTIME");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.MaintainOperId).ColumnName("MAINTAINOPERID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.Sum).ColumnName("SUM");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");


             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

