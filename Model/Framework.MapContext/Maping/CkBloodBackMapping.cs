

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 病人退血 - 实体类
	/// </summary>
	public partial class CkBloodBackMapping: ClassMap<CkBloodBack>
	{   
		/// <summary>
		/// 病人退血 - 实体类
		/// </summary>
		public CkBloodBackMapping()
		{
			this.TableName("CKBLOODBACK").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.RecNo).ColumnName("RECNO");
			  
			this.Column(p =>p.LabId).ColumnName("LABID");
			  
			this.Column(p =>p.BloodId).ColumnName("BLOODID");
			  
			this.Column(p =>p.BackTime).ColumnName("BACKTIME");
			  
			this.Column(p =>p.BackOperId).ColumnName("BACKOPERID");
			  
			this.Column(p =>p.BackReason).ColumnName("BACKREASON");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

