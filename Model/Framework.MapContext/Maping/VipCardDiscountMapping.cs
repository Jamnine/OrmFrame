

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class VipCardDiscountMapping: ClassMap<VipCardDiscount>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public VipCardDiscountMapping()
		{
			this.TableName("VIPCARDDISCOUNT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.VipCardID).ColumnName("VIPCARDID");
			  
			this.Column(p =>p.FeeID).ColumnName("FEEID");
			  
			this.Column(p =>p.Discount).ColumnName("DISCOUNT");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

