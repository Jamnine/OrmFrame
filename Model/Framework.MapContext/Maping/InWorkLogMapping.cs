

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院工作日志表(病区日志) - 实体类
	/// </summary>
	public partial class InWorkLogMapping: ClassMap<InWorkLog>
	{   
		/// <summary>
		/// 住院工作日志表(病区日志) - 实体类
		/// </summary>
		public InWorkLogMapping()
		{
			this.TableName("INWORKLOG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.BedSum).ColumnName("BEDSUM");
			  
			this.Column(p =>p.OverBedSum).ColumnName("OVERBEDSUM");
			  
			this.Column(p =>p.Standard).ColumnName("STANDARD");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.LastNum).ColumnName("LASTNUM");
			  
			this.Column(p =>p.StartNum).ColumnName("STARTNUM");
			  
			this.Column(p =>p.InHospital).ColumnName("INHOSPITAL");
			  
			this.Column(p =>p.InLocation).ColumnName("INLOCATION");
			  
			this.Column(p =>p.OutLocation).ColumnName("OUTLOCATION");
			  
			this.Column(p =>p.OutHospital).ColumnName("OUTHOSPITAL");
			  
			this.Column(p =>p.Dead).ColumnName("DEAD");
			  
			this.Column(p =>p.NowNum).ColumnName("NOWNUM");
			  
			this.Column(p =>p.OverNum).ColumnName("OVERNUM");
			  
			this.Column(p =>p.CompanyNum).ColumnName("COMPANYNUM");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.Days).ColumnName("DAYS");
			  
			this.Column(p =>p.Danger).ColumnName("DANGER");
			  
			this.Column(p =>p.Heavy).ColumnName("HEAVY");
			  
			this.Column(p =>p.Acute).ColumnName("ACUTE");
			  
			this.Column(p =>p.Second).ColumnName("SECOND");
			  
			this.Column(p =>p.Ops).ColumnName("OPS");
			  
			this.Column(p =>p.ChildBirth).ColumnName("CHILDBIRTH");
			  
			this.Column(p =>p.FirstNurse).ColumnName("FIRSTNURSE");
			  
			this.Column(p =>p.Third).ColumnName("THIRD");
			  
			this.Column(p =>p.Diff).ColumnName("DIFF");
			  
			this.Column(p =>p.Other).ColumnName("OTHER");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

