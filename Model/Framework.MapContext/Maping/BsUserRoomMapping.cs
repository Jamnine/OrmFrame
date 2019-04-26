

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 药房人员 - 实体类
	/// </summary>
	public partial class BsUserRoomMapping: ClassMap<BsUserRoom>
	{   
		/// <summary>
		/// 药房人员 - 实体类
		/// </summary>
		public BsUserRoomMapping()
		{
			this.TableName("BSUSERROOM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.RoomId).ColumnName("ROOMID");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

