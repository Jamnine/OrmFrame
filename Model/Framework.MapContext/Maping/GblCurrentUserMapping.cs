

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 客户端信息 - 实体类
	/// </summary>
	public partial class GblCurrentUserMapping: ClassMap<GblCurrentUser>
	{   
		/// <summary>
		/// 客户端信息 - 实体类
		/// </summary>
		public GblCurrentUserMapping()
		{
			this.TableName("GBLCURRENTUSER").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.HouseId).ColumnName("HOUSEID");
			  
			this.Column(p =>p.RoomId).ColumnName("ROOMID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.Hostname).ColumnName("HOSTNAME");
			  
			this.Column(p =>p.SpecialityId).ColumnName("SPECIALITYID");
			  
			this.Column(p =>p.BeginTime).ColumnName("BEGINTIME");
			  
			this.Column(p =>p.EndTime).ColumnName("ENDTIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

