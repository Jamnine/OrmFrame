

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class OaDocumentMapping: ClassMap<OaDocument>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public OaDocumentMapping()
		{
			this.TableName("OADOCUMENT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.GroupMainId).ColumnName("GROUPMAINID");
			  
			this.Column(p =>p.GroupSubId).ColumnName("GROUPSUBID");
			  
			this.Column(p =>p.LsOpenType).ColumnName("LSOPENTYPE");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.InActiveReason).ColumnName("INACTIVEREASON");
			  
			this.Column(p =>p.InActiveTime).ColumnName("INACTIVETIME");
			  
			this.Column(p =>p.InActiveOperID).ColumnName("INACTIVEOPERID");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.Security).ColumnName("SECURITY");
			  
			this.Column(p =>p.Password).ColumnName("PASSWORD");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

