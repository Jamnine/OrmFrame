

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CkMachineFluidMapping: ClassMap<CkMachineFluid>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CkMachineFluidMapping()
		{
			this.TableName("CKMACHINEFLUID").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.MachineID).ColumnName("MACHINEID");
			  
			this.Column(p =>p.BodyFluidId).ColumnName("BODYFLUIDID");
			  
			this.Column(p =>p.MachineFluidCode).ColumnName("MACHINEFLUIDCODE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

