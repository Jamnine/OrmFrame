

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 
	/// </summary>
	public partial class VisitRecordUserMapping : ClassMap<VisitRecordUser>
	{   
		/// <summary>
		/// 会员积分表 - 实体类
		/// </summary>
		public VisitRecordUserMapping()
		{
			this.TableName("VISITRECORDUSER").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.UserId).ColumnName("USERID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.LsUserRole).ColumnName("LSUSERROLE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

