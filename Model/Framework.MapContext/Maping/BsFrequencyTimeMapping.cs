

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 频率时间表 - 实体类
	/// </summary>
	public partial class BsFrequencyTimeMapping: ClassMap<BsFrequencyTime>
	{   
		/// <summary>
		/// 频率时间表 - 实体类
		/// </summary>
		public BsFrequencyTimeMapping()
		{
			this.TableName("BSFREQUENCYTIME").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.ExecTime).ColumnName("EXECTIME");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.IsHour).ColumnName("ISHOUR");
			  
			this.Column(p =>p.UseTime).ColumnName("USETIME");
			  
			this.Column(p =>p.UpCode).ColumnName("UPCODE");
			  
			this.Column(p =>p.YBCode).ColumnName("YBCODE");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

