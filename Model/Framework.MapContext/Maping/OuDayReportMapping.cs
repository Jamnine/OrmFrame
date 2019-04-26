

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊交款报表费用分类 - 实体类
	/// </summary>
	public partial class OuDayReportMapping: ClassMap<OuDayReport>
	{   
		/// <summary>
		/// 门诊交款报表费用分类 - 实体类
		/// </summary>
		public OuDayReportMapping()
		{
			this.TableName("OUDAYREPORT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RtpNo).ColumnName("RTPNO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.Remark).ColumnName("REMARK");
			  
			this.Column(p =>p.Beprice).ColumnName("BEPRICE");
			  
			this.Column(p =>p.FactGet).ColumnName("FACTGET");
			  
			this.Column(p =>p.InArrear).ColumnName("INARREAR");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

