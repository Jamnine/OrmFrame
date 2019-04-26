

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 挂号信息用于微信接口 - 实体类
	/// </summary>
	public partial class OuGetAllRegInfoMapping: ClassMap<OuGetAllRegInfo>
	{   
		/// <summary>
		/// 挂号信息用于微信接口 - 实体类
		/// </summary>
		public OuGetAllRegInfoMapping()
		{
			this.TableName("OUGETALLREGINFO").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.DoctorName).ColumnName("DOCTORNAME");
			  
			this.Column(p =>p.DoctorTitle).ColumnName("DOCTORTITLE");
			  
			this.Column(p =>p.TimeRegInfoList).ColumnName("TIMEREGINFOLIST");
			  
			this.Column(p =>p.RegDate).ColumnName("REGDATE");
			  
			this.Column(p =>p.RegweekDay).ColumnName("REGWEEKDAY");
			  
			this.Column(p =>p.RegLeaveCount).ColumnName("REGLEAVECOUNT");
			  
			this.Column(p =>p.Totalfee).ColumnName("TOTALFEE");
			  
			this.Column(p =>p.RegFee).ColumnName("REGFEE");
			  
			this.Column(p =>p.RegStatus).ColumnName("REGSTATUS");
			  
			this.Column(p =>p.TimeReginfo).ColumnName("TIMEREGINFO");
			  
			this.Column(p =>p.StartTime).ColumnName("STARTTIME");
			  
			this.Column(p =>p.TimeEnd).ColumnName("TIMEEND");
			  
			this.Column(p =>p.RegTotalCount1).ColumnName("REGTOTALCOUNT1");
			  
			this.Column(p =>p.RegLeaveCount1).ColumnName("REGLEAVECOUNT1");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.IsCancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.RoomName).ColumnName("ROOMNAME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

