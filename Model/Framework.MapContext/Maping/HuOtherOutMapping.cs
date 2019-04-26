

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 仓库药库其他出库单 - 实体类
	/// </summary>
	public partial class HuOtherOutMapping: ClassMap<HuOtherOut>
	{   
		/// <summary>
		/// 仓库药库其他出库单 - 实体类
		/// </summary>
		public HuOtherOutMapping()
		{
			this.TableName("HUOTHEROUT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillNo).ColumnName("BILLNO");
			  
			this.Column(p =>p.HouseId).ColumnName("HOUSEID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsSign).ColumnName("ISSIGN");
			  
			this.Column(p =>p.SignTime).ColumnName("SIGNTIME");
			  
			this.Column(p =>p.SignOperId).ColumnName("SIGNOPERID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.PageNumber).ColumnName("PAGENUMBER");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

