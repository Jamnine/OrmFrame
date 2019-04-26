

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:病史表 - 实体类
	/// </summary>
	public partial class MediCalhiStoryMapping: ClassMap<MediCalhiStory>
	{   
		/// <summary>
		/// 行心云:病史表 - 实体类
		/// </summary>
		public MediCalhiStoryMapping()
		{
			this.TableName("MEDICALHISTORY").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.MedicalTime).ColumnName("MEDICALTIME");
			  
			this.Column(p =>p.MedicalName).ColumnName("MEDICALNAME");
			  
			this.Column(p =>p.OpenTime).ColumnName("OPENTIME");
			  
			this.Column(p =>p.OpenId).ColumnName("OPENID");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

