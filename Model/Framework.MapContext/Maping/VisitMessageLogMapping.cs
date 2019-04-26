

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 
	/// </summary>
	public partial class VisitMessageLogMapping : ClassMap<VisitMessageLog>
	{   
		/// <summary>
		/// 会员积分表 - 实体类
		/// </summary>
		public VisitMessageLogMapping()
		{
			this.TableName("VISITMESSAGELOG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.PatientName).ColumnName("PATIENTNAME");
			  
			this.Column(p =>p.Mobile).ColumnName("MOBILE");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.Comments).ColumnName("COMMENTS");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

