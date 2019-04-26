

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 
	/// </summary>
	public partial class VipReChargeMapping : ClassMap<VipReCharge>
	{   
		/// <summary>
		/// 会员积分表 - 实体类
		/// </summary>
		public VipReChargeMapping()
		{
			this.TableName("VIPRECHARGE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.VipCardID).ColumnName("VIPCARDID");
			  
			this.Column(p =>p.PatID).ColumnName("PATID");
			  
			this.Column(p =>p.CardNo).ColumnName("CARDNO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.InCome).ColumnName("INCOME");
			  
			this.Column(p =>p.PayOut).ColumnName("PAYOUT");

            this.Column(p => p.Balance).ColumnName("BALANCE");

            this.Column(p => p.PayWay).ColumnName("PAYWAY");

            this.Column(p => p.OperType).ColumnName("OPERTYPE");

            this.Column(p => p.Comments).ColumnName("COMMENTS");

            this.Column(p => p.VipTypeID).ColumnName("VIPTYPEID");

            this.Column(p => p.LsVipChaFromType).ColumnName("LSVIPCHAFROMTYPE");

            this.Column(p => p.InvoId).ColumnName("INVOID");

            this.Column(p => p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

