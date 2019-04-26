

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 记录手术病人情况 - 实体类
	/// </summary>
	public partial class InHosOpsMapping: ClassMap<InHosOps>
	{   
		/// <summary>
		/// 记录手术病人情况 - 实体类
		/// </summary>
		public InHosOpsMapping()
		{
			this.TableName("INHOSOPS").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.OpsTimes).ColumnName("OPSTIMES");
			  
			this.Column(p =>p.OpsTime).ColumnName("OPSTIME");
			  
			this.Column(p =>p.OpsId).ColumnName("OPSID");
			  
			this.Column(p =>p.LsCut).ColumnName("LSCUT");
			  
			this.Column(p =>p.LsRecove).ColumnName("LSRECOVE");
			  
			this.Column(p =>p.OpsDoctorId).ColumnName("OPSDOCTORID");
			  
			this.Column(p =>p.AnaesId).ColumnName("ANAESID");
			  
			this.Column(p =>p.AssistantOperId1).ColumnName("ASSISTANTOPERID1");
			  
			this.Column(p =>p.AssistantOperId2).ColumnName("ASSISTANTOPERID2");
			  
			this.Column(p =>p.AnaesDoctorId).ColumnName("ANAESDOCTORID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalID).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

