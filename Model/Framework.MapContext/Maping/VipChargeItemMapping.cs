

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 会员金额对应项目表 - 实体类
	/// </summary>
	public partial class VipChargeItemMapping: ClassMap<VipChargeItem>
	{   
		/// <summary>
		/// 会员金额对应项目表 - 实体类
		/// </summary>
		public VipChargeItemMapping()
		{
			this.TableName("VIPCHARGEITEM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.VccId).ColumnName("VCCID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.TotalCount).ColumnName("TOTALCOUNT");
			  
			this.Column(p =>p.DiscountPrice).ColumnName("DISCOUNTPRICE");
			  
			this.Column(p =>p.IsDisCount).ColumnName("ISDISCOUNT");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.VipLevelId).ColumnName("VIPLEVELID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

