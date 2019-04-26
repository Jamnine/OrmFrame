

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 病人用血 - 实体类
	/// </summary>
	public partial class CkBldReactionMapping: ClassMap<CkBldReaction>
	{   
		/// <summary>
		/// 病人用血 - 实体类
		/// </summary>
		public CkBldReactionMapping()
		{
			this.TableName("CKBLDREACTION").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RecNo).ColumnName("RECNO");
			  
			this.Column(p =>p.LabId).ColumnName("LABID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.BloodId).ColumnName("BLOODID");
			  
			this.Column(p =>p.TransTime).ColumnName("TRANSTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.TransType).ColumnName("TRANSTYPE");
			  
			this.Column(p =>p.TotalVollume).ColumnName("TOTALVOLLUME");
			  
			this.Column(p =>p.ReactTime).ColumnName("REACTTIME");
			  
			this.Column(p =>p.LsTransType).ColumnName("LSTRANSTYPE");
			  
			this.Column(p =>p.ClincHandle).ColumnName("CLINCHANDLE");
			  
			this.Column(p =>p.TransHandle).ColumnName("TRANSHANDLE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

