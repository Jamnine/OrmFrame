

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 仓库药库入库单 - 实体类
	/// </summary>
	public partial class HuStockMapping: ClassMap<HuStock>
	{   
		/// <summary>
		/// 仓库药库入库单 - 实体类
		/// </summary>
		public HuStockMapping()
		{
			this.TableName("HUSTOCK").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillNo).ColumnName("BILLNO");
			  
			this.Column(p =>p.HouseId).ColumnName("HOUSEID");
			  
			this.Column(p =>p.CompId).ColumnName("COMPID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsSign).ColumnName("ISSIGN");
			  
			this.Column(p =>p.SignTime).ColumnName("SIGNTIME");
			  
			this.Column(p =>p.SignOperId).ColumnName("SIGNOPERID");
			  
			this.Column(p =>p.IsBack).ColumnName("ISBACK");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.BuyId).ColumnName("BUYID");
			  
			this.Column(p =>p.BuyWayId).ColumnName("BUYWAYID");
			  
			this.Column(p =>p.Applicant).ColumnName("APPLICANT");
			  
			this.Column(p =>p.Application).ColumnName("APPLICATION");
			  
			this.Column(p =>p.QcMemo).ColumnName("QCMEMO");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.BillMan).ColumnName("BILLMAN");

            this.Column(p => p.IsInterface).ColumnName("ISINTERFACE");

            this.Column(p => p.InterfaceBillNo).ColumnName("INTERFACEBILLNO");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");


            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

