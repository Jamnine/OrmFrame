

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:病人相片 - 实体类
	/// </summary>
	public partial class BsPatientPhotoMapping: ClassMap<BsPatientPhoto>
	{   
		/// <summary>
		/// 行心云:病人相片 - 实体类
		/// </summary>
		public BsPatientPhotoMapping()
		{
			this.TableName("BSPATIENTPHOTO").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.PatientId).ColumnName("PATIENTID");
			  
			this.Column(p =>p.Photo).ColumnName("PHOTO");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

