

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 
	/// </summary>
	public partial class YbDtlDayUpMapping : ClassMap<YbDtlDayUp>
	{   
		/// <summary>
		/// 会员积分表 - 实体类
		/// </summary>
		public YbDtlDayUpMapping()
		{
			this.TableName("YBDTLDAYUP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.DtlId).ColumnName("DTLID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.UpdateTime).ColumnName("UPDATETIME");
			  
			this.Column(p =>p.YbNo).ColumnName("YBNO");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

