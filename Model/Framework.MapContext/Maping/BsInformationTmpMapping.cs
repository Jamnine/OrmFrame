

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:信息模板表(短信，微信) - 实体类
	/// </summary>
	public partial class BsInformationTmpMapping: ClassMap<BsInformationTmp>
	{   
		/// <summary>
		/// 行心云:信息模板表(短信，微信) - 实体类
		/// </summary>
		public BsInformationTmpMapping()
		{
			this.TableName("BSINFORMATIONTMP").Schema("orm");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Content).ColumnName("CONTENT");
			  
			this.Column(p =>p.Type).ColumnName("TYPE");
			  
			this.Column(p =>p.ParentId).ColumnName("PARENTID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.IsDefault).ColumnName("ISDEFAULT");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

