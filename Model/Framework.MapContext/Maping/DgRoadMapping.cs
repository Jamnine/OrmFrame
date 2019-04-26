

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgRoadMapping: ClassMap<DgRoad>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgRoadMapping()
		{
			this.TableName("DGROAD").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.LsOpenType).ColumnName("LSOPENTYPE");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.IsBaby).ColumnName("ISBABY");
			  
			this.Column(p =>p.IsWomen).ColumnName("ISWOMEN");
			  
			this.Column(p =>p.Ismen).ColumnName("ISMEN");
			  
			this.Column(p =>p.IsOlder).ColumnName("ISOLDER");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.Zdyj).ColumnName("ZDYJ");
			  
			this.Column(p =>p.Zlfa).ColumnName("ZLFA");
			  
			this.Column(p =>p.Jrljbz).ColumnName("JRLJBZ");
			  
			this.Column(p =>p.Zyzhxgc).ColumnName("ZYZHXGC");
			  
			this.Column(p =>p.Ryjcxm).ColumnName("RYJCXM");
			  
			this.Column(p =>p.Zlff).ColumnName("ZLFF");
			  
			this.Column(p =>p.Cybz).ColumnName("CYBZ");
			  
			this.Column(p =>p.Bzzyr).ColumnName("BZZYR");
			  
			this.Column(p =>p.Bzljrbegin).ColumnName("BZLJRBEGIN");
			  
			this.Column(p =>p.Bzljrend).ColumnName("BZLJREND");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

