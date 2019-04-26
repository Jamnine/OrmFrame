

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 短信息发送情况 - 实体类
	/// </summary>
	public partial class GblPhoneMsgMapping: ClassMap<GblPhoneMsg>
	{   
		/// <summary>
		/// 短信息发送情况 - 实体类
		/// </summary>
		public GblPhoneMsgMapping()
		{
			this.TableName("GBLPHONEMSG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.PhoneNum).ColumnName("PHONENUM");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Message).ColumnName("MESSAGE");
			  
			this.Column(p =>p.PlanTime).ColumnName("PLANTIME");
			  
			this.Column(p =>p.IsSend).ColumnName("ISSEND");
			  
			this.Column(p =>p.SendTime).ColumnName("SENDTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

