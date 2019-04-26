

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 历史每日数据质量信息 - 实体类
	/// </summary>
	public partial class HistTraceMapping: ClassMap<HistTrace>
	{   
		/// <summary>
		/// 历史每日数据质量信息 - 实体类
		/// </summary>
		public HistTraceMapping()
		{
			this.TableName("HISTTRACE").Schema("orm");
			  
			this.Column(p =>p.InSertTime).ColumnName("INSERTTIME");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
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
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

