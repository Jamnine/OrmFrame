

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CsLogisticServeMapping: ClassMap<CsLogisticServe>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CsLogisticServeMapping()
		{
			this.TableName("CSLOGISTICSERVE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Unit).ColumnName("UNIT");
			  
			this.Column(p =>p.UnitPrice).ColumnName("UNITPRICE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

