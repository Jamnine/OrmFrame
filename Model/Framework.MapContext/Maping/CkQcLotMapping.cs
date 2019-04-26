

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// QC质控 - 实体类
	/// </summary>
	public partial class CkQcLotMapping: ClassMap<CkQcLot>
	{   
		/// <summary>
		/// QC质控 - 实体类
		/// </summary>
		public CkQcLotMapping()
		{
			this.TableName("CKQCLOT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.SampleNum).ColumnName("SAMPLENUM");
			  
			this.Column(p =>p.MachineId).ColumnName("MACHINEID");
			  
			this.Column(p =>p.ExpiryDate).ColumnName("EXPIRYDATE");
			  
			this.Column(p =>p.CtrlId).ColumnName("CTRLID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

