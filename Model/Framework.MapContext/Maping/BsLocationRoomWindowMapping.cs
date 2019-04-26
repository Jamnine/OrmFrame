

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 药房窗口 - 实体类
	/// </summary>
	public partial class BsLocationRoomWindowMapping: ClassMap<BsLocationRoomWindow>
	{   
		/// <summary>
		/// 药房窗口 - 实体类
		/// </summary>
		public BsLocationRoomWindowMapping()
		{
			this.TableName("BSLOCATIONROOMWINDOW").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.RoomWindowName).ColumnName("ROOMWINDOWNAME");
			  
			this.Column(p =>p.PrinterName).ColumnName("PRINTERNAME");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

