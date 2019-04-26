

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 用法附带项目 - 实体类
	/// </summary>
	public partial class BsUsageItemMapping: ClassMap<BsUsageItem>
	{   
		/// <summary>
		/// 用法附带项目 - 实体类
		/// </summary>
		public BsUsageItemMapping()
		{
			this.TableName("BSUSAGEITEM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.LsUseArea).ColumnName("LSUSEAREA");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.IsBaby).ColumnName("ISBABY");
			  
			this.Column(p =>p.IsWomen).ColumnName("ISWOMEN");
			  
			this.Column(p =>p.IsMen).ColumnName("ISMEN");
			  
			this.Column(p =>p.IsOlder).ColumnName("ISOLDER");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsDrugTwoDay).ColumnName("ISDRUGTWODAY");
			  
			this.Column(p =>p.IsOnlyUseOne).ColumnName("ISONLYUSEONE");
			  
			this.Column(p =>p.IsForFrequency).ColumnName("ISFORFREQUENCY");
			  
			this.Column(p =>p.IsForDays).ColumnName("ISFORDAYS");
            this.Column(p => p.ModiOperId).ColumnName("MODIOPERID");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.SpecMemo).ColumnName("SPECMEMO");
            this.Column(p => p.ModiTime).ColumnName("MODITIME");
             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

