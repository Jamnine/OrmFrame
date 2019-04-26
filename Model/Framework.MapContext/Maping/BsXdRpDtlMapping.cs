

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 减号套餐明细表 - 实体类
	/// </summary>
	public partial class BsXdRpDtlMapping: ClassMap<BsXdRpDtl>
	{   
		/// <summary>
		/// 减号套餐明细表 - 实体类
		/// </summary>
		public BsXdRpDtlMapping()
		{
			this.TableName("BSXDRPDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");

            this.Column(p => p.XdRpId).ColumnName("XDRPID");
            this.Column(p => p.TmpRecipeEmrID).ColumnName("TMPRECIPEEMRID");

            this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.Dosage).ColumnName("DOSAGE");
			  
			this.Column(p =>p.UnitTakeId).ColumnName("UNITTAKEID");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.Days).ColumnName("DAYS");
			  
			this.Column(p =>p.ExecLocId).ColumnName("EXECLOCID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.FeeTotality).ColumnName("FEETOTALITY");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.DiscountAoumt).ColumnName("DISCOUNTAOUMT");
			  
			this.Column(p =>p.ModioperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.ListNum).ColumnName("LISTNUM");
			  
			this.Column(p =>p.LimittoTalzy).ColumnName("LIMITTOTALZY");
			  
			this.Column(p =>p.GrouptIp).ColumnName("GROUPTIP");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			this.Column(p =>p.CookType).ColumnName("CookType");




            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

