

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:系统登录日志 - 实体类
	/// </summary>
	public partial class LoginLogMapping: ClassMap<LoginLog>
	{   
		/// <summary>
		/// 行心云:系统登录日志 - 实体类
		/// </summary>
		public LoginLogMapping()
		{
			this.TableName("LOGINLOG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HostName).ColumnName("HOSTNAME");
			  
			this.Column(p =>p.HostGuId).ColumnName("HOSTGUID");
			  
			this.Column(p =>p.LoginUserId).ColumnName("LOGINUSERID");
			  
			this.Column(p =>p.LoginUserName).ColumnName("LOGINUSERNAME");
			  
			this.Column(p =>p.LoginLocationId).ColumnName("LOGINLOCATIONID");
			  
			this.Column(p =>p.LoginLocationName).ColumnName("LOGINLOCATIONNAME");
			  
			this.Column(p =>p.LoginDate).ColumnName("LOGINDATE");
			  
			this.Column(p =>p.QuitDate).ColumnName("QUITDATE");
			  
			this.Column(p =>p.ServiceVersIonnum).ColumnName("SERVICEVERSIONNUM");
			  
			this.Column(p =>p.ClientVersIonnum).ColumnName("CLIENTVERSIONNUM");
			  
			this.Column(p =>p.CustomerdbVersIonnum).ColumnName("CUSTOMERDBVERSIONNUM");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperLastDate).ColumnName("OPERLASTDATE");
			  
			this.Column(p =>p.Ex1).ColumnName("EX1");
			  
			this.Column(p =>p.Ex2).ColumnName("EX2");
			  
			this.Column(p =>p.Ex3).ColumnName("EX3");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

