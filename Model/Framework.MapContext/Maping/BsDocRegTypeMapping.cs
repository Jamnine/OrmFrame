

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 周排班 - 实体类
	/// </summary>
	public partial class BsDocRegTypeMapping: ClassMap<BsDocRegType>
	{   
		/// <summary>
		/// 周排班 - 实体类
		/// </summary>
		public BsDocRegTypeMapping()
		{
			this.TableName("BSDOCREGTYPE").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.RegTypeId).ColumnName("REGTYPEID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.LimitNum).ColumnName("LIMITNUM");
			  
			this.Column(p =>p.LastLimitDate).ColumnName("LASTLIMITDATE");
			  
			this.Column(p =>p.LastLimitNum).ColumnName("LASTLIMITNUM");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.WeekDay).ColumnName("WEEKDAY");
			  
			this.Column(p =>p.TimeSpanId).ColumnName("TIMESPANID");
			  
			this.Column(p =>p.RoomNo).ColumnName("ROOMNO");
			  
			this.Column(p =>p.DiagRoomId).ColumnName("DIAGROOMID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");



            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

