

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 自动发药机明细 - 实体类
	/// </summary>
	public partial class OutMedTableHisMapping: ClassMap<OutMedTableHis>
	{   
		/// <summary>
		/// 自动发药机明细 - 实体类
		/// </summary>
		public OutMedTableHisMapping()
		{
			this.TableName("OUTMEDTABLEHIS").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.PresNO).ColumnName("PRESNO");
			  
			this.Column(p =>p.MedID).ColumnName("MEDID");
			  
			this.Column(p =>p.MedOnlyCode).ColumnName("MEDONLYCODE");
			  
			this.Column(p =>p.MedAMT).ColumnName("MEDAMT");
			  
			this.Column(p =>p.MedPack).ColumnName("MEDPACK");
			  
			this.Column(p =>p.MedUnitPack).ColumnName("MEDUNITPACK");
			  
			this.Column(p =>p.MedUnit).ColumnName("MEDUNIT");
			  
			this.Column(p =>p.MedOutTime).ColumnName("MEDOUTTIME");
			  
			this.Column(p =>p.PresType).ColumnName("PRESTYPE");
			  
			this.Column(p =>p.WindowNO).ColumnName("WINDOWNO");
			  
			this.Column(p =>p.PatientID).ColumnName("PATIENTID");
			  
			this.Column(p =>p.PatientName).ColumnName("PATIENTNAME");
			  
			this.Column(p =>p.PatientSex).ColumnName("PATIENTSEX");
			  
			this.Column(p =>p.PatientAge).ColumnName("PATIENTAGE");
			  
			this.Column(p =>p.PatientBirth).ColumnName("PATIENTBIRTH");
			  
			this.Column(p =>p.Diagnosis).ColumnName("DIAGNOSIS");
			  
			this.Column(p =>p.WardNO).ColumnName("WARDNO");
			  
			this.Column(p =>p.WardName).ColumnName("WARDNAME");
			  
			this.Column(p =>p.MedPerdos).ColumnName("MEDPERDOS");
			  
			this.Column(p =>p.MedUsage).ColumnName("MEDUSAGE");
			  
			this.Column(p =>p.MedPerday).ColumnName("MEDPERDAY");
			  
			this.Column(p =>p.DoctorName).ColumnName("DOCTORNAME");
			  
			this.Column(p =>p.SEndflag).ColumnName("SENDFLAG");
			  
			this.Column(p =>p.MedUnitPrice).ColumnName("MEDUNITPRICE");
			  
			this.Column(p =>p.MedTotalPrice).ColumnName("MEDTOTALPRICE");
			  
			this.Column(p =>p.MedType).ColumnName("MEDTYPE");
			  
			this.Column(p =>p.MedConvercof).ColumnName("MEDCONVERCOF");
			  
			this.Column(p =>p.Remark).ColumnName("REMARK");
			  
			this.Column(p =>p.YFCode).ColumnName("YFCODE");
			  
			this.Column(p =>p.Endflag).ColumnName("ENDFLAG");
			  
			this.Column(p =>p.YfFinish).ColumnName("YFFINISH");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

