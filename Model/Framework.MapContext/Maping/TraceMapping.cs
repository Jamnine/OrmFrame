

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 病人重要数据更改记录 - 实体类
	/// </summary>
	public partial class TraceMapping: ClassMap<Trace>
	{   
		/// <summary>
		/// 病人重要数据更改记录 - 实体类
		/// </summary>
		public TraceMapping()
		{
			this.TableName("TRACE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");

            this.Column(p => p.Ip).ColumnName("IP");

            this.Column(p =>p.CreateDate).ColumnName("CREATEDATE");
			  
			this.Column(p =>p.UserID).ColumnName("USERID");
			  
			this.Column(p =>p.Messages).ColumnName("MESSAGES");
			  
			this.Column(p =>p.Type).ColumnName("TYPE");
			  
			this.Column(p =>p.OperateType).ColumnName("OPERATETYPE");
			  
			this.Column(p =>p.RecordId).ColumnName("RECORDID");
			  
			this.Column(p =>p.OuInNo).ColumnName("OUINNO");
			  
			this.Column(p =>p.PatientName).ColumnName("PATIENTNAME");
			  
			this.Column(p =>p.WorkFlow).ColumnName("WORKFLOW");
			  
			this.Column(p =>p.LocationName).ColumnName("LOCATIONNAME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.Ip).ColumnName("IP");



             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

