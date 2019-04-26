

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 会员等级 - 实体类
	/// </summary>
	public partial class BsVipLevelMapping: ClassMap<BsVipLevel>
	{   
		/// <summary>
		/// 会员等级 - 实体类
		/// </summary>
		public BsVipLevelMapping()
		{
			this.TableName("BSVIPLEVEL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.VipTypeId).ColumnName("VIPTYPEID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Discount).ColumnName("DISCOUNT");
			  
			this.Column(p =>p.DefaultBalance).ColumnName("DEFAULTBALANCE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.InValidDays).ColumnName("INVALIDDAYS");
			  
			this.Column(p =>p.IsVipPrice).ColumnName("ISVIPPRICE");
			  
			this.Column(p =>p.IsStoredCard).ColumnName("ISSTOREDCARD");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.SincePay).ColumnName("SINCEPAY");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

