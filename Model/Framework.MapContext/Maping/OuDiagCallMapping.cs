

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊叫号信息 - 实体类
	/// </summary>
	public partial class OuDiagCallMapping: ClassMap<OuDiagCall>
	{   
		/// <summary>
		/// 门诊叫号信息 - 实体类
		/// </summary>
		public OuDiagCallMapping()
		{
			this.TableName("OUDIAGCALL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.PatName).ColumnName("PATNAME");
			  
			this.Column(p =>p.ActType).ColumnName("ACTTYPE");
			  
			this.Column(p =>p.IsCall).ColumnName("ISCALL");
			  
			this.Column(p =>p.RoomNo).ColumnName("ROOMNO");
			  
			this.Column(p =>p.CallType).ColumnName("CALLTYPE");
			  
			this.Column(p =>p.CallCount).ColumnName("CALLCOUNT");
			  
			this.Column(p =>p.Num).ColumnName("NUM");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

