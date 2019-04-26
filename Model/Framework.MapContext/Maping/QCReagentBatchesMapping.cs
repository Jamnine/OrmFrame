

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// QC试剂批号 - 实体类
	/// </summary>
	public partial class QCReagentBatchesMapping: ClassMap<QCReagentBatches>
	{   
		/// <summary>
		/// QC试剂批号 - 实体类
		/// </summary>
		public QCReagentBatchesMapping()
		{
			this.TableName("QCREAGENTBATCHES").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.QCNum).ColumnName("QCNUM");
			  
			this.Column(p =>p.QCstandId).ColumnName("QCSTANDID");
			  
			this.Column(p =>p.CKMId).ColumnName("CKMID");
			  
			this.Column(p =>p.DueTime).ColumnName("DUETIME");
			  
			this.Column(p =>p.QCReagentlot).ColumnName("QCREAGENTLOT");
			  
			this.Column(p =>p.QCReagentName).ColumnName("QCREAGENTNAME");
			  
			this.Column(p =>p.QCqualityName).ColumnName("QCQUALITYNAME");
			  
			this.Column(p =>p.EnablingTime).ColumnName("ENABLINGTIME");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

