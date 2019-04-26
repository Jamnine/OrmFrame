

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 报表打印机设置 - 实体类
	/// </summary>
	public partial class GblPrinterMapping: ClassMap<GblPrinter>
	{   
		/// <summary>
		/// 报表打印机设置 - 实体类
		/// </summary>
		public GblPrinterMapping()
		{
			this.TableName("GBLPRINTER").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Hostname).ColumnName("HOSTNAME");
			  
			this.Column(p =>p.ReportName).ColumnName("REPORTNAME");
			  
			this.Column(p =>p.PrinterName).ColumnName("PRINTERNAME");
			  
			this.Column(p =>p.Spec).ColumnName("SPEC");
			  
			this.Column(p =>p.TopMargin).ColumnName("TOPMARGIN");
			  
			this.Column(p =>p.LeftMargin).ColumnName("LEFTMARGIN");
			  
			this.Column(p =>p.Orientation).ColumnName("ORIENTATION");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.IsTwoSided).ColumnName("ISTWOSIDED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

