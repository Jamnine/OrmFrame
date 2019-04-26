

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:会员充值表 - 实体类
	/// </summary>
	public partial class OuRechargeMapping: ClassMap<OuRecharge>
	{   
		/// <summary>
		/// 行心云:会员充值表 - 实体类
		/// </summary>
		public OuRechargeMapping()
		{
			this.TableName("OURECHARGE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.PatID).ColumnName("PATID");
			  
			this.Column(p =>p.CardNo).ColumnName("CARDNO");
			  
			this.Column(p =>p.Income).ColumnName("INCOME");
			  
			this.Column(p =>p.PayOut).ColumnName("PAYOUT");
			  
			this.Column(p =>p.Balance).ColumnName("BALANCE");
			  
			this.Column(p =>p.PayWayId).ColumnName("PAYWAYID");
			  
			this.Column(p =>p.OperType).ColumnName("OPERTYPE");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.Comments).ColumnName("COMMENTS");
			  
			this.Column(p =>p.VipTypeID).ColumnName("VIPTYPEID");
			  
			this.Column(p =>p.VipCardID).ColumnName("VIPCARDID");
			  
			this.Column(p =>p.IndividualPay).ColumnName("INDIVIDUALPAY");
			  
			this.Column(p =>p.Givenamount).ColumnName("GIVENAMOUNT");
			  
			this.Column(p =>p.Givenamounthis).ColumnName("GIVENAMOUNTHIS");
			  
			this.Column(p =>p.IndividualPayhis).ColumnName("INDIVIDUALPAYHIS");
			  
			this.Column(p =>p.InvoID).ColumnName("INVOID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.SerialNumber).ColumnName("SERIALNUMBER");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

