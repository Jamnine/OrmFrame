

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:加工单紧急程度 - 实体类
	/// </summary>
	public partial class BsEmergencyTypeMapping: ClassMap<BsEmergencyType>
	{   
		/// <summary>
		/// 行心云:加工单紧急程度 - 实体类
		/// </summary>
		public BsEmergencyTypeMapping()
		{
			this.TableName("BSEMERGENCYTYPE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.PYCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WBCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

