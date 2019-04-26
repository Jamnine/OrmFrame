

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 仓库药库其他入库 - 实体类
	/// </summary>
	public partial class HuOtherInMapping: ClassMap<HuOtherIn>
	{   
		/// <summary>
		/// 仓库药库其他入库 - 实体类
		/// </summary>
		public HuOtherInMapping()
		{
			this.TableName("HUOTHERIN").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillNo).ColumnName("BILLNO");
			  
			this.Column(p =>p.HouseId).ColumnName("HOUSEID");
			  
			this.Column(p =>p.Reason).ColumnName("REASON");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsSign).ColumnName("ISSIGN");
			  
			this.Column(p =>p.SignTime).ColumnName("SIGNTIME");
			  
			this.Column(p =>p.SignOperId).ColumnName("SIGNOPERID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.PageNumber).ColumnName("PAGENUMBER");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

