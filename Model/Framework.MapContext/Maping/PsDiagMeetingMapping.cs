

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 会诊申请表 - 实体类
	/// </summary>
	public partial class PsDiagMeetingMapping: ClassMap<PsDiagMeeting>
	{   
		/// <summary>
		/// 会诊申请表 - 实体类
		/// </summary>
		public PsDiagMeetingMapping()
		{
			this.TableName("PSDIAGMEETING").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.ApplyNo).ColumnName("APPLYNO");
			  
			this.Column(p =>p.ApplyTime).ColumnName("APPLYTIME");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.Diagnose).ColumnName("DIAGNOSE");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.Clinic).ColumnName("CLINIC");
			  
			this.Column(p =>p.IsUrgent).ColumnName("ISURGENT");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.InAdviceTempId).ColumnName("INADVICETEMPID");
			  
			this.Column(p =>p.PatientName).ColumnName("PATIENTNAME");
			  
			this.Column(p =>p.InPatNo).ColumnName("INPATNO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

