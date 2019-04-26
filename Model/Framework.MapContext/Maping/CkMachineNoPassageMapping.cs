

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CkMachineNoPassageMapping: ClassMap<CkMachineNoPassage>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CkMachineNoPassageMapping()
		{
			this.TableName("CKMACHINENOPASSAGE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.MachineID).ColumnName("MACHINEID");
			  
			this.Column(p =>p.PassAgeNum).ColumnName("PASSAGENUM");
			  
			this.Column(p =>p.TestResuslt).ColumnName("TESTRESUSLT");
			  
			this.Column(p =>p.ResultDate).ColumnName("RESULTDATE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

