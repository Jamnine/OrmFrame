

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 假设诊断明细 - 实体类
	/// </summary>
	public partial class BsDiagnoseDtlMapping: ClassMap<BsDiagnoseDtl>
	{   
		/// <summary>
		/// 假设诊断明细 - 实体类
		/// </summary>
		public BsDiagnoseDtlMapping()
		{
			this.TableName("BSDIAGNOSEDTL").Schema("orm");
			  
			this.Column(p =>p.DiagnoseId).ColumnName("DIAGNOSEID");
			  
			this.Column(p =>p.Relust).ColumnName("RELUST");
			  
			this.Column(p =>p.CommonName).ColumnName("COMMONNAME");
			  
			this.Column(p =>p.CheckType).ColumnName("CHECKTYPE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");

            this.Id(t => t.GUID); this.Ignore(p => p.IsModify);
        }      
	}  
}           
 

