

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:病人日常事务表 - 实体类
	/// </summary>
	public partial class OuScheduleMapping: ClassMap<OuSchedule>
	{   
		/// <summary>
		/// 行心云:病人日常事务表 - 实体类
		/// </summary>
		public OuScheduleMapping()
		{
			this.TableName("OUSCHEDULE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.PatID).ColumnName("PATID");
			  
			this.Column(p =>p.MzRegID).ColumnName("MZREGID");
			  
			this.Column(p =>p.ItemID).ColumnName("ITEMID");
			  
			this.Column(p =>p.RecipeDtlID).ColumnName("RECIPEDTLID");
			  
			this.Column(p =>p.StartTime).ColumnName("STARTTIME");
			  
			this.Column(p =>p.EndTime).ColumnName("ENDTIME");
			  
			this.Column(p =>p.Affairs).ColumnName("AFFAIRS");
			  
			this.Column(p =>p.IsAttach).ColumnName("ISATTACH");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

			this.Column(p =>p.OperTime).ColumnName("OperTime");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

