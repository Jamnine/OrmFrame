

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 实时报表DI信息 - 实体类
	/// </summary>
	public partial class GblMrkMapping: ClassMap<GblMrk>
	{   
		/// <summary>
		/// 实时报表DI信息 - 实体类
		/// </summary>
		public GblMrkMapping()
		{
			this.TableName("GBLMRK").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.MrkFile).ColumnName("MRKFILE");
			  
			this.Column(p =>p.MrkContent).ColumnName("MRKCONTENT");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

