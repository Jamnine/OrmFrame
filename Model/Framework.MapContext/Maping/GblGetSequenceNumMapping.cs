

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 记录系统每个模块下一次单据号 - 实体类
	/// </summary>
	public partial class GblGetSequenceNumMapping: ClassMap<GblGetSequenceNum>
	{   
		/// <summary>
		/// 记录系统每个模块下一次单据号 - 实体类
		/// </summary>
		public GblGetSequenceNumMapping()
		{
			this.TableName("GBLGETSEQUENCENUM").Schema("orm");

            this.Column(p => p.SequenceName).ColumnName("SEQUENCENAME");

            this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.NextSequenceNum).ColumnName("NEXTSEQUENCENUM");
			  
			this.Column(p =>p.IsDayBegin).ColumnName("ISDAYBEGIN");
			  
			this.Column(p =>p.GetdateStr).ColumnName("GETDATESTR");
			
			this.Column(p =>p.NextSequenceStr).ColumnName("NEXTSEQUENCESTR");
			
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.ResetType).ColumnName("RESETTYPE");
            
            this.Column(p => p.SequenceLen).ColumnName("SEQUENCELEN");

            this.Column(p => p.Prefix).ColumnName("PREFIX");

            this.Column(p => p.CurrentValue).ColumnName("CURRENTVALUE");
            
            this.Column(p => p.DateFormat).ColumnName("DATEFORMAT");
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

