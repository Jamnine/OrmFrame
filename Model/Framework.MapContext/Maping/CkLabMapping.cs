

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验标本登记 - 实体类
	/// </summary>
	public partial class CkLabMapping: ClassMap<CkLab>
	{   
		/// <summary>
		/// 检验标本登记 - 实体类
		/// </summary>
		public CkLabMapping()
		{
			this.TableName("CKLAB").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LabNum).ColumnName("LABNUM");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.LsSource).ColumnName("LSSOURCE");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.RefLocation).ColumnName("REFLOCATION");
			  
			this.Column(p =>p.IllHistory).ColumnName("ILLHISTORY");
			  
			this.Column(p =>p.Diagnose).ColumnName("DIAGNOSE");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsPriority).ColumnName("ISPRIORITY");
			  
			this.Column(p =>p.CollectTime).ColumnName("COLLECTTIME");
			  
			this.Column(p =>p.CollectOperId).ColumnName("COLLECTOPERID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsCancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.CancelTime).ColumnName("CANCELTIME");
			  
			this.Column(p =>p.CancelOperId).ColumnName("CANCELOPERID");
			  
			this.Column(p =>p.IsPass).ColumnName("ISPASS");
			  
			this.Column(p =>p.ReportMemo).ColumnName("REPORTMEMO");
			  
			this.Column(p =>p.TechMemo).ColumnName("TECHMEMO");
			  
			this.Column(p =>p.OtherMemo).ColumnName("OTHERMEMO");
			  
			this.Column(p =>p.RecieveTime).ColumnName("RECIEVETIME");
			  
			this.Column(p =>p.RecieveOperId).ColumnName("RECIEVEOPERID");
			  
			this.Column(p =>p.ResultTime).ColumnName("RESULTTIME");
			  
			this.Column(p =>p.ResultOperId).ColumnName("RESULTOPERID");
			  
			this.Column(p =>p.AuthTime).ColumnName("AUTHTIME");
			  
			this.Column(p =>p.AuthOperId).ColumnName("AUTHOPERID");
			  
			this.Column(p =>p.ReportTime).ColumnName("REPORTTIME");
			  
			this.Column(p =>p.ReportOperId).ColumnName("REPORTOPERID");
			  
			this.Column(p =>p.LsStatus).ColumnName("LSSTATUS");
			  
			this.Column(p =>p.TestTypeId).ColumnName("TESTTYPEID");
			  
			this.Column(p =>p.CollectLocId).ColumnName("COLLECTLOCID");
			  
			this.Column(p =>p.TogetherNum).ColumnName("TOGETHERNUM");
			  
			this.Column(p =>p.SJOperId).ColumnName("SJOPERID");
			  
			this.Column(p =>p.SJOperTime).ColumnName("SJOPERTIME");
			  
			this.Column(p =>p.PatientName).ColumnName("PATIENTNAME");
			  
			this.Column(p =>p.IsHandInput).ColumnName("ISHANDINPUT");
			  
			this.Column(p =>p.ReportColName).ColumnName("REPORTCOLNAME");
			  
			this.Column(p =>p.SJName).ColumnName("SJNAME");
			  
			this.Column(p =>p.ServiceOpertime).ColumnName("SERVICEOPERTIME");
			  
			this.Column(p =>p.IsPrint).ColumnName("ISPRINT");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.CheckId).ColumnName("CHECKID");

            this.Column(p => p.IsOver).ColumnName("ISOVER");

            this.Column(p => p.IsCharge).ColumnName("ISCHARGE");

            this.Column(p => p.Properties).ColumnName("PROPERTIES");

            this.Column(p => p.QCstandId).ColumnName("QCSTANDID");

            this.Column(p => p.QCReagentlot).ColumnName("QCREAGENTLOT");

            this.Column(p => p.OuRecipeDtlID).ColumnName("OuRecipeDtlID");

            this.Column(p => p.TestTypeId).ColumnName("TESTTYPEID");


            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

