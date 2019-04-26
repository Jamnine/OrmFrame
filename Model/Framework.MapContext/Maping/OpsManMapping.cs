

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 手术人员表（护士、医生） - 实体类
	/// </summary>
	public partial class OpsManMapping: ClassMap<OpsMan>
	{   
		/// <summary>
		/// 手术人员表（护士、医生） - 实体类
		/// </summary>
		public OpsManMapping()
		{
			this.TableName("OPSMAN").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ApplyId).ColumnName("APPLYID");
			  
			this.Column(p =>p.UserId).ColumnName("USERID");
			  
			this.Column(p =>p.LsRole).ColumnName("LSROLE");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DocLevId).ColumnName("DOCLEVID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

