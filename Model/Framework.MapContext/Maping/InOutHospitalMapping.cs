

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 病人转诊表 - 实体类
	/// </summary>
	public partial class InOutHospitalMapping: ClassMap<InOutHospital>
	{   
		/// <summary>
		/// 病人转诊表 - 实体类
		/// </summary>
		public InOutHospitalMapping()
		{
			this.TableName("INOUTHOSPITAL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.MzregId).ColumnName("MZREGID");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.OutHospitalID).ColumnName("OUTHospitalID");
			  
			this.Column(p =>p.OutoperTime).ColumnName("OUTOPERTIME");
			  
			this.Column(p =>p.OutoperId).ColumnName("OUTOPERID");
			  
			this.Column(p =>p.OutDoctorId).ColumnName("OUTDOCTORID");
			  
			this.Column(p =>p.IsOutSign).ColumnName("ISOUTSIGN");
			  
			this.Column(p =>p.OutSignOperId).ColumnName("OUTSIGNOPERID");
			  
			this.Column(p =>p.OutSignTime).ColumnName("OUTSIGNTIME");
			  
			this.Column(p =>p.OutSignMemo).ColumnName("OUTSIGNMEMO");
			  
			this.Column(p =>p.InHospitalID).ColumnName("INHospitalID");
			  
			this.Column(p =>p.InOperTime).ColumnName("INOPERTIME");
			  
			this.Column(p =>p.InOperId).ColumnName("INOPERID");
			  
			this.Column(p =>p.InDoctorId).ColumnName("INDOCTORID");
			  
			this.Column(p =>p.IsInsign).ColumnName("IsInsign");
			  
			this.Column(p =>p.InSignOperId).ColumnName("INSIGNOPERID");
			  
			this.Column(p =>p.InSignTime).ColumnName("INSIGNTIME");
			  
			this.Column(p =>p.InSignMemo).ColumnName("INSIGNMEMO");
			  
			this.Column(p =>p.RefNo).ColumnName("REFNO");
			  
			this.Column(p =>p.TreatmentPro).ColumnName("TREATMENTPRO");
			  
			this.Column(p =>p.DiagGoal).ColumnName("DIAGGOAL");
			  
			this.Column(p =>p.LsEmergency).ColumnName("LSEMERGENCY");
			  
			this.Column(p =>p.Inlocationid).ColumnName("INLOCATIONID");

            this.Column(p => p.ReferralSource).ColumnName("REFERRALSOURCE");

            this.Column(p => p.OutHospitalName).ColumnName("OUTHOSPITALNAME");
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

