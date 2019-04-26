

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class BsMessageTemplateMapping: ClassMap<BsMessageTemplate>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public BsMessageTemplateMapping()
		{
			this.TableName("BSMESSAGETEMPLATE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Contents).ColumnName("CONTENTS");
			  
			this.Column(p =>p.ParentID).ColumnName("PARENTID");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.IsDefault).ColumnName("ISDEFAULT");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

