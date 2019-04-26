

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊退药执行 - 实体类
	/// </summary>
	public partial class OuExecuteBackMapping: ClassMap<OuExecuteBack>
	{   
		/// <summary>
		/// 门诊退药执行 - 实体类
		/// </summary>
		public OuExecuteBackMapping()
		{
			this.TableName("OUEXECUTEBACK").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.ExecuteId).ColumnName("EXECUTEID");
			  
			this.Column(p =>p.ExecuteDtlId).ColumnName("EXECUTEDTLID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsBack).ColumnName("ISBACK");
			  
			this.Column(p =>p.KsBackBillId).ColumnName("KSBACKBILLID");
			  
			this.Column(p =>p.BackTime).ColumnName("BACKTIME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

