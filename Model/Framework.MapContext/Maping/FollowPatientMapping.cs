

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:患者回访表 - 实体类
	/// </summary>
	public partial class FollowPatientMapping: ClassMap<FollowPatient>
	{   
		/// <summary>
		/// 行心云:患者回访表 - 实体类
		/// </summary>
		public FollowPatientMapping()
		{
			this.TableName("FOLLOWPATIENT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.FollowTime).ColumnName("FOLLOWTIME");
			  
			this.Column(p =>p.TimeQuantum).ColumnName("TIMEQUANTUM");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.FollowType).ColumnName("FOLLOWTYPE");
			  
			this.Column(p =>p.FollowContent).ColumnName("FOLLOWCONTENT");
			  
			this.Column(p =>p.IsFeedBack).ColumnName("ISFEEDBACK");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.FeedBackContent).ColumnName("FEEDBACKCONTENT");
			  
			this.Column(p =>p.ToothCaseId).ColumnName("TOOTHCASEID");
			  
			this.Column(p =>p.IsAutoCreate).ColumnName("ISAUTOCREATE");
			  
			this.Column(p =>p.FollowStatus).ColumnName("FOLLOWSTATUS");
			  
			this.Column(p =>p.FollowWay).ColumnName("FOLLOWWAY");
			  
			this.Column(p =>p.PatientName).ColumnName("PATIENTNAME");
			  
			this.Column(p =>p.AppRaiseType).ColumnName("APPRAISETYPE");
			  
			this.Column(p =>p.IsDeleted).ColumnName("ISDELETED");
			  
			this.Column(p =>p.ModifyerOpenId).ColumnName("MODIFYEROPENID");
			  
			this.Column(p =>p.ReturnContent).ColumnName("RETURNCONTENT");
			  
			this.Column(p =>p.ReturnCycle).ColumnName("RETURNCYCLE");
			  
			this.Column(p =>p.SickTypeId).ColumnName("SICKTYPEID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.PatId).ColumnName("PATID");

            //this.Column(p => p.AppraiseType).ColumnName("AppraiseType");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

