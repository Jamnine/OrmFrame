

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class InRecFirstPageMapping: ClassMap<InRecFirstPage>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public InRecFirstPageMapping()
		{
			this.TableName("INRECFIRSTPAGE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RecNo).ColumnName("RECNO");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.ModifyOperTime).ColumnName("MODIFYOPERTIME");
			  
			this.Column(p =>p.ModifyOperID).ColumnName("MODIFYOPERID");
			  
			this.Column(p =>p.IsAuth).ColumnName("ISAUTH");
			  
			this.Column(p =>p.AuthOperTime).ColumnName("AUTHOPERTIME");
			  
			this.Column(p =>p.AuthOperId).ColumnName("AUTHOPERID");
			  
			this.Column(p =>p.ConfirmIllDate).ColumnName("CONFIRMILLDATE");
			  
			this.Column(p =>p.IsOPS).ColumnName("ISOPS");
			  
			this.Column(p =>p.IsBabyCard).ColumnName("ISBABYCARD");
			  
			this.Column(p =>p.IsMutiIll).ColumnName("ISMUTIILL");
			  
			this.Column(p =>p.InfectTimes).ColumnName("INFECTTIMES");
			  
			this.Column(p =>p.IsSalvage).ColumnName("ISSALVAGE");
			  
			this.Column(p =>p.SalvageTimes).ColumnName("SALVAGETIMES");
			  
			this.Column(p =>p.IsSalvSucess).ColumnName("ISSALVSUCESS");
			  
			this.Column(p =>p.SalvSucessTimes).ColumnName("SALVSUCESSTIMES");
			  
			this.Column(p =>p.IsFollow).ColumnName("ISFOLLOW");
			  
			this.Column(p =>p.FollowEndDate).ColumnName("FOLLOWENDDATE");
			  
			this.Column(p =>p.IsDeadBodyCheck).ColumnName("ISDEADBODYCHECK");
			  
			this.Column(p =>p.IsStudyCase).ColumnName("ISSTUDYCASE");
			  
			this.Column(p =>p.LsQuality).ColumnName("LSQUALITY");
			  
			this.Column(p =>p.ZrDoctorId).ColumnName("ZRDOCTORID");
			  
			this.Column(p =>p.ZzDoctorId).ColumnName("ZZDOCTORID");
			  
			this.Column(p =>p.ZyDoctorId).ColumnName("ZYDOCTORID");
			  
			this.Column(p =>p.SxDoctorId).ColumnName("SXDOCTORID");
			  
			this.Column(p =>p.JxDoctorId).ColumnName("JXDOCTORID");
			  
			this.Column(p =>p.YjsDoctorId).ColumnName("YJSDOCTORID");
			  
			this.Column(p =>p.ZkDoctorId).ColumnName("ZKDOCTORID");
			  
			this.Column(p =>p.LsAccMzIll).ColumnName("LSACCMZILL");
			  
			this.Column(p =>p.LsAccZyIll).ColumnName("LSACCZYILL");
			  
			this.Column(p =>p.LsAccOPSIll1).ColumnName("LSACCOPSILL1");
			  
			this.Column(p =>p.LsAccOPSIll2).ColumnName("LSACCOPSILL2");
			  
			this.Column(p =>p.LsAccOPSIll3).ColumnName("LSACCOPSILL3");
			  
			this.Column(p =>p.LsAccOPSIll4).ColumnName("LSACCOPSILL4");
			  
			this.Column(p =>p.IsTjIll).ColumnName("ISTJILL");
			  
			this.Column(p =>p.IsConfirm3D).ColumnName("ISCONFIRM3D");
			  
			this.Column(p =>p.BabyNum).ColumnName("BABYNUM");
			  
			this.Column(p =>p.IsTranNeact).ColumnName("ISTRANNEACT");
			  
			this.Column(p =>p.IsOxygenNeact).ColumnName("ISOXYGENNEACT");
			  
			this.Column(p =>p.IsMidFireBurn).ColumnName("ISMIDFIREBURN");
			  
			this.Column(p =>p.IsSingleIll).ColumnName("ISSINGLEILL");
			  
			this.Column(p =>p.IsHbsAg).ColumnName("ISHBSAG");
			  
			this.Column(p =>p.IsHCVAb).ColumnName("ISHCVAB");
			  
			this.Column(p =>p.IsHIVAb).ColumnName("ISHIVAB");
			  
			this.Column(p =>p.IsHbsAg3).ColumnName("ISHBSAG3");
			  
			this.Column(p =>p.HeadOperId).ColumnName("HEADOPERID");
			  
			this.Column(p =>p.ZkOperId).ColumnName("ZKOPERID");
			  
			this.Column(p =>p.ZkDate).ColumnName("ZKDATE");
			  
			this.Column(p =>p.IsRH).ColumnName("ISRH");
			  
			this.Column(p =>p.IsOpsFirst).ColumnName("ISOPSFIRST");
			  
			this.Column(p =>p.IsCureFirst).ColumnName("ISCUREFIRST");
			  
			this.Column(p =>p.IsCheckFirst).ColumnName("ISCHECKFIRST");
			  
			this.Column(p =>p.IsDiagFirst).ColumnName("ISDIAGFIRST");
			  
			this.Column(p =>p.RedCellNum).ColumnName("REDCELLNUM");
			  
			this.Column(p =>p.PlaqueNum).ColumnName("PLAQUENUM");
			  
			this.Column(p =>p.SerousNum).ColumnName("SEROUSNUM");
			  
			this.Column(p =>p.AllBloodNum).ColumnName("ALLBLOODNUM");
			  
			this.Column(p =>p.OtherBloodNum).ColumnName("OTHERBLOODNUM");
			  
			this.Column(p =>p.ConsultHosputal).ColumnName("CONSULTHOSPUTAL");
			  
			this.Column(p =>p.ConsultRemote).ColumnName("CONSULTREMOTE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

