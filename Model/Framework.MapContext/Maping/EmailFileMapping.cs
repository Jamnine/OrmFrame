

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 保存文件 - 实体类
	/// </summary>
	public partial class EmailFileMapping: ClassMap<EmailFile>
	{   
		/// <summary>
		/// 保存文件 - 实体类
		/// </summary>
		public EmailFileMapping()
		{
			this.TableName("EMAILFILE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.FileContent).ColumnName("FILECONTENT");
			  
			this.Column(p =>p.EmailId).ColumnName("EMAILID");
			  
			this.Column(p =>p.FileName).ColumnName("FILENAME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

