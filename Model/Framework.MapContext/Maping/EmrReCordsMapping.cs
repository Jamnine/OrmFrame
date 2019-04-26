

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 电子病历修改记录 - 实体类
	/// </summary>
	public partial class EmrReCordsMapping: ClassMap<EmrReCords>
	{   
		/// <summary>
		/// 电子病历修改记录 - 实体类
		/// </summary>
		public EmrReCordsMapping()
		{
			this.TableName("EMRRECORDS").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.InTime).ColumnName("INTIME");
			  
			this.Column(p =>p.OutTime).ColumnName("OUTTIME");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.ModifyTime).ColumnName("MODIFYTIME");
			  
			this.Column(p =>p.RecContent).ColumnName("RECCONTENT");
			  
			this.Column(p =>p.FirstReTime).ColumnName("FIRSTRETIME");
			  
			this.Column(p =>p.InEmrId).ColumnName("INEMRID");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IsModify).ColumnName("ISMODIFY");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.PatientName).ColumnName("PATIENTNAME");
			  
			this.Column(p =>p.InPatNo).ColumnName("INPATNO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.NoteTime).ColumnName("NOTETIME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

