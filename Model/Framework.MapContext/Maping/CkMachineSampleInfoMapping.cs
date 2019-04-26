

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 标本异常信息汇总 - 实体类
	/// </summary>
	public partial class CkMachineSampleInfoMapping: ClassMap<CkMachineSampleInfo>
	{   
		/// <summary>
		/// 标本异常信息汇总 - 实体类
		/// </summary>
		public CkMachineSampleInfoMapping()
		{
			this.TableName("CKMACHINESAMPLEINFO").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.InstrumentSeqInfoID).ColumnName("INSTRUMENTSEQINFOID");
			  
			this.Column(p =>p.InstrumentSeqID).ColumnName("INSTRUMENTSEQID");
			  
			this.Column(p =>p.ExceptionItemCount).ColumnName("EXCEPTIONITEMCOUNT");
			  
			this.Column(p =>p.AlarmItemCount).ColumnName("ALARMITEMCOUNT");
			  
			this.Column(p =>p.EmptyResultItemCount).ColumnName("EMPTYRESULTITEMCOUNT");
			  
			this.Column(p =>p.SpecimenTypeName).ColumnName("SPECIMENTYPENAME");
			  
			this.Column(p =>p.CreateDate).ColumnName("CREATEDATE");
			  
			this.Column(p =>p.ItemCount).ColumnName("ITEMCOUNT");
			  
			this.Column(p =>p.CalculateCount).ColumnName("CALCULATECOUNT");
			  
			this.Column(p =>p.warringMsg).ColumnName("WARRINGMSG");
			  
			this.Column(p =>p.AlertMsg).ColumnName("ALERTMSG");
			  
			this.Column(p =>p.LastUpdate).ColumnName("LASTUPDATE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

