

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 执行科室指引 - 实体类
	/// </summary>
	public partial class BsExecLocationMapping: ClassMap<BsExecLocation>
	{   
		/// <summary>
		/// 执行科室指引 - 实体类
		/// </summary>
		public BsExecLocationMapping()
		{
			this.TableName("BSEXECLOCATION").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.TimeBegin).ColumnName("TIMEBEGIN");
			  
			this.Column(p =>p.TimeEnd).ColumnName("TIMEEND");
			  
			this.Column(p =>p.ExecPoint).ColumnName("EXECPOINT");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.InvInItemName).ColumnName("INVINITEMNAME");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

