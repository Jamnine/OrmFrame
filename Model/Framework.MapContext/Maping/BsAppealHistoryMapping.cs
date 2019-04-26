

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:求助历史记录表 - 实体类
	/// </summary>
	public partial class BsAppealHistoryMapping: ClassMap<BsAppealHistory>
	{   
		/// <summary>
		/// 行心云:求助历史记录表 - 实体类
		/// </summary>
		public BsAppealHistoryMapping()
		{
			this.TableName("BSAPPEALHISTORY").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.UserId).ColumnName("USERID");
			  
			this.Column(p =>p.SpecialiStId).ColumnName("SPECIALISTID");
			  
			this.Column(p =>p.MessAge).ColumnName("MESSAGE");
			  
			this.Column(p =>p.SendTime).ColumnName("SENDTIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

