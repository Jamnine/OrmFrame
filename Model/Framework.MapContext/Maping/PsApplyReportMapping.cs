

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检查报告申请表 - 实体类
	/// </summary>
	public partial class PsApplyReportMapping: ClassMap<PsApplyReport>
	{   
		/// <summary>
		/// 检查报告申请表 - 实体类
		/// </summary>
		public PsApplyReportMapping()
		{
			this.TableName("PSAPPLYREPORT").Schema("orm");
			  
			this.Column(p =>p.ApplyNo).ColumnName("APPLYNO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.IsCancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.CancelTime).ColumnName("CANCELTIME");
			  
			this.Column(p =>p.CancelOperId).ColumnName("CANCELOPERID");
			  
			this.Column(p =>p.XType).ColumnName("XTYPE");
			  
			this.Column(p =>p.IsPre).ColumnName("ISPRE");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.IsCharged).ColumnName("ISCHARGED");
			  
			this.Column(p =>p.IsConfirm).ColumnName("ISCONFIRM");
			  
			this.Column(p =>p.ConfirmTime).ColumnName("CONFIRMTIME");
			  
			this.Column(p =>p.Equipment).ColumnName("EQUIPMENT");
			  
			this.Column(p =>p.ApplyMemo).ColumnName("APPLYMEMO");
			  
			this.Column(p =>p.ExecLocId).ColumnName("EXECLOCID");
			  
			this.Column(p =>p.CheckTime).ColumnName("CHECKTIME");
			  
			this.Column(p =>p.CheckOperId).ColumnName("CHECKOPERID");
			  
			this.Column(p =>p.ReportTime).ColumnName("REPORTTIME");
			  
			this.Column(p =>p.ReportOperId).ColumnName("REPORTOPERID");
			  
			this.Column(p =>p.AuthOperId).ColumnName("AUTHOPERID");
			  
			this.Column(p =>p.CheckBody).ColumnName("CHECKBODY");
			  
			this.Column(p =>p.CheckParm).ColumnName("CHECKPARM");
			  
			this.Column(p =>p.CheckDesc).ColumnName("CHECKDESC");
			  
			this.Column(p =>p.CheckResult).ColumnName("CHECKRESULT");
			  
			this.Column(p =>p.CheckAdvice).ColumnName("CHECKADVICE");
			  
			this.Column(p =>p.IsAbNormal).ColumnName("ISABNORMAL");
			  
			this.Column(p =>p.Summary).ColumnName("SUMMARY");
			  
			this.Column(p =>p.Diagnose).ColumnName("DIAGNOSE");
			  
			this.Column(p =>p.CheckId).ColumnName("CHECKID");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ExecuteId).ColumnName("EXECUTEID");
			  
			this.Column(p =>p.CallGroup).ColumnName("CALLGROUP");
			  
			this.Column(p =>p.LsStatus).ColumnName("LSSTATUS");
			  
			this.Column(p =>p.CompGroupId).ColumnName("COMPGROUPID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.IsExecute).ColumnName("ISEXECUTE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

