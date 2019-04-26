

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 发血表 - 实体类
	/// </summary>
	public partial class CkBloodSendMapping: ClassMap<CkBloodSend>
	{   
		/// <summary>
		/// 发血表 - 实体类
		/// </summary>
		public CkBloodSendMapping()
		{
			this.TableName("CKBLOODSEND").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.RecNo).ColumnName("RECNO");
			  
			this.Column(p =>p.LabId).ColumnName("LABID");
			  
			this.Column(p =>p.BloodId).ColumnName("BLOODID");
			  
			this.Column(p =>p.NoteTime).ColumnName("NOTETIME");
			  
			this.Column(p =>p.NoteOperId).ColumnName("NOTEOPERID");
			  
			this.Column(p =>p.IsSend).ColumnName("ISSEND");
			  
			this.Column(p =>p.SendTime).ColumnName("SENDTIME");
			  
			this.Column(p =>p.SendOperId).ColumnName("SENDOPERID");
			  
			this.Column(p =>p.TakeMan).ColumnName("TAKEMAN");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

