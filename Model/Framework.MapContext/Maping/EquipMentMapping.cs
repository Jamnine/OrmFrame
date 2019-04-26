

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 设备表 - 实体类
	/// </summary>
	public partial class EquipMentMapping: ClassMap<EquipMent>
	{   
		/// <summary>
		/// 设备表 - 实体类
		/// </summary>
		public EquipMentMapping()
		{
			this.TableName("EQUIPMENT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.Spec).ColumnName("SPEC");
			  
			this.Column(p =>p.EqType).ColumnName("EQTYPE");
			  
			this.Column(p =>p.SeriesNo).ColumnName("SERIESNO");
			  
			this.Column(p =>p.Brand).ColumnName("BRAND");
			  
			this.Column(p =>p.CountryId).ColumnName("COUNTRYID");
			  
			this.Column(p =>p.ManuId).ColumnName("MANUID");
			  
			this.Column(p =>p.CompId).ColumnName("COMPID");
			  
			this.Column(p =>p.RepairBy).ColumnName("REPAIRBY");
			  
			this.Column(p =>p.BuyDate).ColumnName("BUYDATE");
			  
			this.Column(p =>p.StartDate).ColumnName("STARTDATE");
			  
			this.Column(p =>p.LimitYears).ColumnName("LIMITYEARS");
			  
			this.Column(p =>p.LsQuaClass).ColumnName("LSQUACLASS");
			  
			this.Column(p =>p.LsEqClass).ColumnName("LSEQCLASS");
			  
			this.Column(p =>p.LotNo).ColumnName("LOTNO");
			  
			this.Column(p =>p.StoreIn).ColumnName("STOREIN");
			  
			this.Column(p =>p.LsEqStatus).ColumnName("LSEQSTATUS");
			  
			this.Column(p =>p.MonthDisc).ColumnName("MONTHDISC");
			  
			this.Column(p =>p.LsMoneyFrom).ColumnName("LSMONEYFROM");
			  
			this.Column(p =>p.MoneyGiven).ColumnName("MONEYGIVEN");
			  
			this.Column(p =>p.MoneySelf).ColumnName("MONEYSELF");
			  
			this.Column(p =>p.UnderLine).ColumnName("UNDERLINE");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.CostPercent).ColumnName("COSTPERCENT");
			  
			this.Column(p =>p.AlarmLine).ColumnName("ALARMLINE");
			  
			this.Column(p =>p.IsCalProfit).ColumnName("ISCALPROFIT");
			  
			this.Column(p =>p.Attachment).ColumnName("ATTACHMENT");
			  
			this.Column(p =>p.UseArea).ColumnName("USEAREA");
			  
			this.Column(p =>p.UseMemo).ColumnName("USEMEMO");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.LsEqType).ColumnName("LSEQTYPE");
			  
			this.Column(p =>p.GroupSubId).ColumnName("GROUPSUBID");
			  
			this.Column(p =>p.CopyId).ColumnName("COPYID");
			  
			this.Column(p =>p.VoucherNo).ColumnName("VOUCHERNO");
			  
			this.Column(p =>p.ProduceArea).ColumnName("PRODUCEAREA");
			  
			this.Column(p =>p.InBatchNo).ColumnName("INBATCHNO");
			  
			this.Column(p =>p.MnrgLocId).ColumnName("MNRGLOCID");
			  
			this.Column(p =>p.UseLocId).ColumnName("USELOCID");
			  
			this.Column(p =>p.InActiveTime).ColumnName("INACTIVETIME");
			  
			this.Column(p =>p.InActiveReason).ColumnName("INACTIVEREASON");
			  
			this.Column(p =>p.InActiveOperId).ColumnName("INACTIVEOPERID");
			  
			this.Column(p =>p.Manger).ColumnName("MANGER");
			  
			this.Column(p =>p.Price).ColumnName("PRICE");
			  
			this.Column(p =>p.HowMany).ColumnName("HOWMANY");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");

            this.Column(p=>p.Code).ColumnName("CODE");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

