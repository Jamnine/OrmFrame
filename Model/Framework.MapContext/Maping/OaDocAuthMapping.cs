

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class OaDocAuthMapping: ClassMap<OaDocAuth>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public OaDocAuthMapping()
		{
			this.TableName("OADOCAUTH").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.DocId).ColumnName("DOCID");
			  
			this.Column(p =>p.AuthOperId).ColumnName("AUTHOPERID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsAuth).ColumnName("ISAUTH");
			  
			this.Column(p =>p.AuthOperTime).ColumnName("AUTHOPERTIME");
			  
			this.Column(p =>p.IsReject).ColumnName("ISREJECT");
			  
			this.Column(p =>p.RejectReason).ColumnName("REJECTREASON");
			  
			this.Column(p =>p.LsReadClass).ColumnName("LSREADCLASS");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

