

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 挂号信息用于微信接口 - 实体类
	/// </summary>
	public partial class OuGetRegInfoMapping: ClassMap<OuGetRegInfo>
	{   
		/// <summary>
		/// 挂号信息用于微信接口 - 实体类
		/// </summary>
		public OuGetRegInfoMapping()
		{
			this.TableName("OUGETREGINFO").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.DoctorID).ColumnName("DOCTORID");
			  
			this.Column(p =>p.DoctorName).ColumnName("DOCTORNAME");
			  
			this.Column(p =>p.DoctorTitle).ColumnName("DOCTORTITLE");
			  
			this.Column(p =>p.TimeRegInfoList).ColumnName("TIMEREGINFOLIST");
			  
			this.Column(p =>p.RegDate).ColumnName("REGDATE");
			  
			this.Column(p =>p.RegWeekDay).ColumnName("REGWEEKDAY");
			  
			this.Column(p =>p.RegTotalCount).ColumnName("REGTOTALCOUNT");
			  
			this.Column(p =>p.RegleaveCount).ColumnName("REGLEAVECOUNT");
			  
			this.Column(p =>p.Totalfee).ColumnName("TOTALFEE");
			  
			this.Column(p =>p.Regfee).ColumnName("REGFEE");
			  
			this.Column(p =>p.Treatfee).ColumnName("TREATFEE");
			  
			this.Column(p =>p.IsTimeReg).ColumnName("ISTIMEREG");
			  
			this.Column(p =>p.ShiftType).ColumnName("SHIFTTYPE");
			  
			this.Column(p =>p.TimeRegInfo).ColumnName("TIMEREGINFO");
			  
			this.Column(p =>p.StartTime).ColumnName("STARTTIME");
			  
			this.Column(p =>p.TimeEnd).ColumnName("TIMEEND");
			  
			this.Column(p =>p.RegTotalCount1).ColumnName("REGTOTALCOUNT1");
			  
			this.Column(p =>p.RegleaveCount1).ColumnName("REGLEAVECOUNT1");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.OnlyId).ColumnName("ONLYID");
			  
			this.Column(p =>p.RoomName).ColumnName("ROOMNAME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

