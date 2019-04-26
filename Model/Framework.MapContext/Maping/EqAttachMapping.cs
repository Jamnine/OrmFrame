

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 设备文件表 - 实体类
	/// </summary>
	public partial class EqAttachMapping: ClassMap<EqAttach>
	{   
		/// <summary>
		/// 设备文件表 - 实体类
		/// </summary>
		public EqAttachMapping()
		{
			this.TableName("EQATTACH").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.EquipmentId).ColumnName("EQUIPMENTID");
			  
			this.Column(p =>p.FileName).ColumnName("FILENAME");
			  
			this.Column(p =>p.LsFileType).ColumnName("LSFILETYPE");
			  
			this.Column(p =>p.AttachFile).ColumnName("ATTACHFILE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.ExpirationDate).ColumnName("EXPIRATIONDATE");

            this.Column(p => p.UploadDate).ColumnName("UPLOADDATE");

            this.Column(p => p.Memo).ColumnName("MEMO");


            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

