

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 历史住院医嘱执行 - 实体类
	/// </summary>
	public partial class HistInExecuteMapping: ClassMap<HistInExecute>
	{   
		/// <summary>
		/// 历史住院医嘱执行 - 实体类
		/// </summary>
		public HistInExecuteMapping()
		{
			this.TableName("HISTINEXECUTE").Schema("orm");
			  
			this.Column(p =>p.InSertTime).ColumnName("INSERTTIME");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.AdviceId).ColumnName("ADVICEID");
			  
			this.Column(p =>p.LsMarkType).ColumnName("LSMARKTYPE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsPrint).ColumnName("ISPRINT");
			  
			this.Column(p =>p.PrintOperTime).ColumnName("PRINTOPERTIME");
			  
			this.Column(p =>p.PrintOperId).ColumnName("PRINTOPERID");
			  
			this.Column(p =>p.AdviceTime).ColumnName("ADVICETIME");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.Dosage).ColumnName("DOSAGE");
			  
			this.Column(p =>p.UnitTakeId).ColumnName("UNITTAKEID");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.PriceIn).ColumnName("PRICEIN");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.UnitInId).ColumnName("UNITINID");
			  
			this.Column(p =>p.IsUrgent).ColumnName("ISURGENT");
			  
			this.Column(p =>p.IsAttach).ColumnName("ISATTACH");
			  
			this.Column(p =>p.IsSelf).ColumnName("ISSELF");
			  
			this.Column(p =>p.LsSpecialUsage).ColumnName("LSSPECIALUSAGE");
			  
			this.Column(p =>p.LsExecLoc).ColumnName("LSEXECLOC");
			  
			this.Column(p =>p.IsSkin).ColumnName("ISSKIN");
			  
			this.Column(p =>p.SkinTime).ColumnName("SKINTIME");
			  
			this.Column(p =>p.SkinTest).ColumnName("SKINTEST");
			  
			this.Column(p =>p.DetailId).ColumnName("DETAILID");
			  
			this.Column(p =>p.ExecLocId).ColumnName("EXECLOCID");
			  
			this.Column(p =>p.IsExecuted).ColumnName("ISEXECUTED");
			  
			this.Column(p =>p.ExecutedTime).ColumnName("EXECUTEDTIME");
			  
			this.Column(p =>p.ExecutedOperId).ColumnName("EXECUTEDOPERID");
			  
			this.Column(p =>p.IsMinus).ColumnName("ISMINUS");
			  
			this.Column(p =>p.NurseMemo).ColumnName("NURSEMEMO");
			  
			this.Column(p =>p.MemoTime).ColumnName("MEMOTIME");
			  
			this.Column(p =>p.MemoOperId).ColumnName("MEMOOPERID");
			  
			this.Column(p =>p.FirstDay).ColumnName("FIRSTDAY");
			  
			this.Column(p =>p.LastDay).ColumnName("LASTDAY");
			  
			this.Column(p =>p.IsLastLong).ColumnName("ISLASTLONG");
			  
			this.Column(p =>p.IsArrearage).ColumnName("ISARREARAGE");
			  
			this.Column(p =>p.YBType).ColumnName("YBTYPE");
			  
			this.Column(p =>p.IsPriority).ColumnName("ISPRIORITY");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

