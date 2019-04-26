

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 排班班次表 - 实体类
	/// </summary>
	public partial class BsRegTimeSpanMapping: ClassMap<BsRegTimeSpan>
	{   
		/// <summary>
		/// 排班班次表 - 实体类
		/// </summary>
		public BsRegTimeSpanMapping()
		{
			this.TableName("BSREGTIMESPAN").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.TimeBegin).ColumnName("TIMEBEGIN");
			  
			this.Column(p =>p.TimeEnd).ColumnName("TIMEEND");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.IsNotlimit).ColumnName("ISNOTLIMIT");
			  
			this.Column(p =>p.ModioperID).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.Moditime).ColumnName("MODITIME");
			  
			this.Column(p =>p.Isspanday).ColumnName("ISSPANDAY");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

