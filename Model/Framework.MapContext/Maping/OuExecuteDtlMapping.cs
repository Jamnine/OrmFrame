﻿

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊执行单明细(注射) - 实体类
	/// </summary>
	public partial class OuExecuteDtlMapping: ClassMap<OuExecuteDtl>
	{   
		/// <summary>
		/// 门诊执行单明细(注射) - 实体类
		/// </summary>
		public OuExecuteDtlMapping()
		{
			this.TableName("OUEXECUTEDTL").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.ExecuteId).ColumnName("EXECUTEID");
			  
			this.Column(p =>p.RecipeDtlId).ColumnName("RECIPEDTLID");
			  
			this.Column(p =>p.ListNum).ColumnName("LISTNUM");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.Dosage).ColumnName("DOSAGE");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.Days).ColumnName("DAYS");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.UnitDiagId).ColumnName("UNITDIAGID");
			  
			this.Column(p =>p.IssueTime).ColumnName("ISSUETIME");
			  
			this.Column(p =>p.BackTime).ColumnName("BACKTIME");
			  
			this.Column(p =>p.IsExecuted).ColumnName("ISEXECUTED");
			  
			this.Column(p =>p.ExecutedTime).ColumnName("EXECUTEDTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.STMemo).ColumnName("STMEMO");
			  
			this.Column(p =>p.UsageName).ColumnName("USAGENAME");
			  
			this.Column(p =>p.PrepareTime).ColumnName("PREPARETIME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.IsSkinTest).ColumnName("ISSKINTEST");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

