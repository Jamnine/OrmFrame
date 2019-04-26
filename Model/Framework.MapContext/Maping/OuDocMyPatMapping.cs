

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊医生病人库 - 实体类
	/// </summary>
	public partial class OuDocMyPatMapping: ClassMap<OuDocMyPat>
	{   
		/// <summary>
		/// 门诊医生病人库 - 实体类
		/// </summary>
		public OuDocMyPatMapping()
		{
			this.TableName("OUDOCMYPAT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsAlert).ColumnName("ISALERT");
			  
			this.Column(p =>p.Days).ColumnName("DAYS");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

