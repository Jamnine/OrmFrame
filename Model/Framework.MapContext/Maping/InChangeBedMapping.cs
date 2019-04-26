

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 换床记录 - 实体类
	/// </summary>
	public partial class InChangeBedMapping: ClassMap<InChangeBed>
	{   
		/// <summary>
		/// 换床记录 - 实体类
		/// </summary>
		public InChangeBedMapping()
		{
			this.TableName("INCHANGEBED").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.LsLocal).ColumnName("LSLOCAL");
			  
			this.Column(p =>p.ChgTime).ColumnName("CHGTIME");
			  
			this.Column(p =>p.PreBed).ColumnName("PREBED");
			  
			this.Column(p =>p.PostBed).ColumnName("POSTBED");
			  
			this.Column(p =>p.Reason).ColumnName("REASON");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

