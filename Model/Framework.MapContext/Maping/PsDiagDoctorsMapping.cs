

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 会诊答复表 - 实体类
	/// </summary>
	public partial class PsDiagDoctorsMapping: ClassMap<PsDiagDoctors>
	{   
		/// <summary>
		/// 会诊答复表 - 实体类
		/// </summary>
		public PsDiagDoctorsMapping()
		{
			this.TableName("PSDIAGDOCTORS").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ApplyId).ColumnName("APPLYID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.IsConfirm).ColumnName("ISCONFIRM");
			  
			this.Column(p =>p.ConfirmTime).ColumnName("CONFIRMTIME");
			  
			this.Column(p =>p.Answer).ColumnName("ANSWER");
			  
			this.Column(p =>p.ItemDetail).ColumnName("ITEMDETAIL");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

