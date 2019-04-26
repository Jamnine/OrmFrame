

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检申请单 - 实体类
	/// </summary>
	public partial class CkMainMapping: ClassMap<CkMain>
	{   
		/// <summary>
		/// 体检申请单 - 实体类
		/// </summary>
		public CkMainMapping()
		{
			this.TableName("CKMAIN").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.CheckNo).ColumnName("CHECKNO");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.CheckTime).ColumnName("CHECKTIME");
			  
			this.Column(p =>p.CompanyCkeckId).ColumnName("COMPANYCKECKID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsCancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.CancelOperTime).ColumnName("CANCELOPERTIME");
			  
			this.Column(p =>p.CancelOperId).ColumnName("CANCELOPERID");
			  
			this.Column(p =>p.CancelMemo).ColumnName("CANCELMEMO");
			  
			this.Column(p =>p.RecieveTime).ColumnName("RECIEVETIME");
			  
			this.Column(p =>p.RecieveOperId).ColumnName("RECIEVEOPERID");
			  
			this.Column(p =>p.ReportTime).ColumnName("REPORTTIME");
			  
			this.Column(p =>p.ReportOperId).ColumnName("REPORTOPERID");
			  
			this.Column(p =>p.LsStatus).ColumnName("LSSTATUS");
			  
			this.Column(p =>p.ReportMemo).ColumnName("REPORTMEMO");
			  
			this.Column(p =>p.TechMemo).ColumnName("TECHMEMO");
			  
			this.Column(p =>p.OtherMemo).ColumnName("OTHERMEMO");
			  
			this.Column(p =>p.CompanyId).ColumnName("COMPANYID");
			  
			this.Column(p =>p.CompanyGroupId).ColumnName("COMPANYGROUPID");
			  
			this.Column(p =>p.RptFileName).ColumnName("RPTFILENAME");
			  
			this.Column(p =>p.IsPay).ColumnName("ISPAY");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Type).ColumnName("TYPE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

