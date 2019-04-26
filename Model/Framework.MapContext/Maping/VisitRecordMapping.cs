

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 
	/// </summary>
	public partial class VisitRecordMapping : ClassMap<VisitRecord>
	{   
		/// <summary>
		/// 会员积分表 - 实体类
		/// </summary>
		public VisitRecordMapping()
		{
			this.TableName("VISITRECORD").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.VisitTime).ColumnName("VISITTIME");
			  
			this.Column(p =>p.VisitType).ColumnName("VISITTYPE");
			  
			this.Column(p =>p.VisitContent).ColumnName("VISITCONTENT");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.PatID).ColumnName("PATID");
			  
			this.Column(p =>p.MzRegID).ColumnName("MZREGID");

            this.Column(p => p.BackContent).ColumnName("BACKCONTENT");

            this.Column(p => p.VisitStatus).ColumnName("VISITSTATUS");

            this.Column(p => p.AppraiseType).ColumnName("APPRAISETYPE");

            this.Column(p => p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

