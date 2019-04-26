

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 输血科相关文件 - 实体类
	/// </summary>
	public partial class CkBandOfficeMapping: ClassMap<CkBandOffice>
	{   
		/// <summary>
		/// 输血科相关文件 - 实体类
		/// </summary>
		public CkBandOfficeMapping()
		{
			this.TableName("CKBANDOFFICE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.TitleName).ColumnName("TITLENAME");
			  
			this.Column(p =>p.ContentStr).ColumnName("CONTENTSTR");
			  
			this.Column(p =>p.FileSize).ColumnName("FILESIZE");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

