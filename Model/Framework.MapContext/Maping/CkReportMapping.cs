

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检单报告 - 实体类
	/// </summary>
	public partial class CkReportMapping: ClassMap<CkReport>
	{   
		/// <summary>
		/// 体检单报告 - 实体类
		/// </summary>
		public CkReportMapping()
		{
			this.TableName("CKREPORT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.CheckId).ColumnName("CHECKID");
			  
			this.Column(p =>p.TestGroupId).ColumnName("TESTGROUPID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.Content).ColumnName("CONTENT");
			  
			this.Column(p =>p.XMLFile).ColumnName("XMLFILE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

