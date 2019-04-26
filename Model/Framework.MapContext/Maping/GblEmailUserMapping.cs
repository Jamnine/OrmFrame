

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 信息接收人 - 实体类
	/// </summary>
	public partial class GblEmailUserMapping: ClassMap<GblEmailUser>
	{   
		/// <summary>
		/// 信息接收人 - 实体类
		/// </summary>
		public GblEmailUserMapping()
		{
			this.TableName("GBLEMAILUSER").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.EmailId).ColumnName("EMAILID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsRead).ColumnName("ISREAD");
			  
			this.Column(p =>p.ReadTime).ColumnName("READTIME");
			  
			this.Column(p =>p.IsAuth).ColumnName("ISAUTH");
			  
			this.Column(p =>p.AuthOperId).ColumnName("AUTHOPERID");
			  
			this.Column(p =>p.Feedback).ColumnName("FEEDBACK");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

