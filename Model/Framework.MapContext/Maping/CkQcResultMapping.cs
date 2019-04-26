

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// QC结果 - 实体类
	/// </summary>
	public partial class CkQcResultMapping: ClassMap<CkQcResult>
	{   
		/// <summary>
		/// QC结果 - 实体类
		/// </summary>
		public CkQcResultMapping()
		{
			this.TableName("CKQCRESULT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ResultDate).ColumnName("RESULTDATE");
			  
			this.Column(p =>p.Result).ColumnName("RESULT");
			  
			this.Column(p =>p.ResultComment).ColumnName("RESULTCOMMENT");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.ResultStatus).ColumnName("RESULTSTATUS");
			  
			this.Column(p =>p.LotId).ColumnName("LOTID");
			  
			this.Column(p =>p.TestId).ColumnName("TESTID");
			  
			this.Column(p =>p.CtrlId).ColumnName("CTRLID");
			  
			this.Column(p =>p.IsShowQc).ColumnName("ISSHOWQC");
			  
			this.Column(p =>p.RejectMemo).ColumnName("REJECTMEMO");
			  
			this.Column(p =>p.LsQcState).ColumnName("LSQCSTATE");
			  
			this.Column(p =>p.Dev3).ColumnName("DEV3");
			  
			this.Column(p =>p.DevM3).ColumnName("DEVM3");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

