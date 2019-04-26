

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgDayGroupPatMapping: ClassMap<DgDayGroupPat>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgDayGroupPatMapping()
		{
			this.TableName("DGDAYGROUPPAT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RoadPatId).ColumnName("ROADPATID");
			  
			this.Column(p =>p.DayGroupId).ColumnName("DAYGROUPID");
			  
			this.Column(p =>p.LsChangeType).ColumnName("LSCHANGETYPE");
			  
			this.Column(p =>p.ChangeReason).ColumnName("CHANGEREASON");
			  
			this.Column(p =>p.ChangeContent).ColumnName("CHANGECONTENT");
			  
			this.Column(p =>p.SignNurseUsertId).ColumnName("SIGNNURSEUSERTID");
			  
			this.Column(p =>p.SignDoctorId).ColumnName("SIGNDOCTORID");
			  
			this.Column(p =>p.SignOperTime).ColumnName("SIGNOPERTIME");
			  
			this.Column(p =>p.DayGroupCode).ColumnName("DAYGROUPCODE");
			  
			this.Column(p =>p.DayGroupName).ColumnName("DAYGROUPNAME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

