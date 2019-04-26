

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院功能科室领药明细 - 实体类
	/// </summary>
	public partial class InRmKsDtlMapping: ClassMap<InRmKsDtl>
	{   
		/// <summary>
		/// 住院功能科室领药明细 - 实体类
		/// </summary>
		public InRmKsDtlMapping()
		{
			this.TableName("INRMKSDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.DetailId).ColumnName("DETAILID");
			  
			this.Column(p =>p.BillId).ColumnName("BILLID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

