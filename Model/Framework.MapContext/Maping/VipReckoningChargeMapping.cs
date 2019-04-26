

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class VipReckoningChargeMapping: ClassMap<VipReckoningCharge>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public VipReckoningChargeMapping()
		{
			this.TableName("VIPRECKONINGCHARGE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.VipCardId).ColumnName("VIPCARDID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.TotalCount).ColumnName("TOTALCOUNT");
			  
			this.Column(p =>p.ConsumeCount).ColumnName("CONSUMECOUNT");
			  
			this.Column(p =>p.LastChargeTime).ColumnName("LASTCHARGETIME");
			  
			this.Column(p =>p.DiscountPrice).ColumnName("DISCOUNTPRICE");
			  
			this.Column(p =>p.IsDiscount).ColumnName("ISDISCOUNT");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.Comments).ColumnName("COMMENTS");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

