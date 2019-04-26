

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 手术申请 - 实体类
	/// </summary>
	public partial class OpsApplyMapping: ClassMap<OpsApply>
	{   
		/// <summary>
		/// 手术申请 - 实体类
		/// </summary>
		public OpsApplyMapping()
		{
			this.TableName("OPSAPPLY").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ApplyNo).ColumnName("APPLYNO");
			  
			this.Column(p =>p.ApplyTime).ColumnName("APPLYTIME");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.OpsId).ColumnName("OPSID");
			  
			this.Column(p =>p.OpsOtherId).ColumnName("OPSOTHERID");
			  
			this.Column(p =>p.AnaeId).ColumnName("ANAEID");
			  
			this.Column(p =>p.Assistant).ColumnName("ASSISTANT");
			  
			this.Column(p =>p.Diagnose).ColumnName("DIAGNOSE");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.BedNo).ColumnName("BEDNO");
			  
			this.Column(p =>p.Lshbsag).ColumnName("LSHBSAG");
			  
			this.Column(p =>p.LsAsepsis).ColumnName("LSASEPSIS");
			  
			this.Column(p =>p.BloodGroup).ColumnName("BLOODGROUP");
			  
			this.Column(p =>p.Blood).ColumnName("BLOOD");
			  
			this.Column(p =>p.OpsBody).ColumnName("OPSBODY");
			  
			this.Column(p =>p.OpsPos).ColumnName("OPSPOS");
			  
			this.Column(p =>p.OtherTools).ColumnName("OTHERTOOLS");
			  
			this.Column(p =>p.IsUrgent).ColumnName("ISURGENT");
			  
			this.Column(p =>p.IsCalled).ColumnName("ISCALLED");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.PlanOperId).ColumnName("PLANOPERID");
			  
			this.Column(p =>p.PlanTime).ColumnName("PLANTIME");
			  
			this.Column(p =>p.PlanMemo).ColumnName("PLANMEMO");
			  
			this.Column(p =>p.IsFinish).ColumnName("ISFINISH");
			  
			this.Column(p =>p.FinishTime).ColumnName("FINISHTIME");
			  
			this.Column(p =>p.FinishOperId).ColumnName("FINISHOPERID");
			  
			this.Column(p =>p.FinishMemo).ColumnName("FINISHMEMO");
			  
			this.Column(p =>p.BeginTime).ColumnName("BEGINTIME");
			  
			this.Column(p =>p.EndTime).ColumnName("ENDTIME");
			  
			this.Column(p =>p.BloodSum).ColumnName("BLOODSUM");
			  
			this.Column(p =>p.LsCutClass).ColumnName("LSCUTCLASS");
			  
			this.Column(p =>p.LsCure).ColumnName("LSCURE");
			  
			this.Column(p =>p.BloodRpt).ColumnName("BLOODRPT");
			  
			this.Column(p =>p.Sensitive).ColumnName("SENSITIVE");
			  
			this.Column(p =>p.OpsRoomId).ColumnName("OPSROOMID");
			  
			this.Column(p =>p.SeqNum).ColumnName("SEQNUM");
			  
			this.Column(p =>p.PatientName).ColumnName("PATIENTNAME");
			  
			this.Column(p =>p.BsOpsName).ColumnName("BSOPSNAME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

