

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class HustoresDaysMapping: ClassMap<HustoresDays>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public HustoresDaysMapping()
		{
			this.TableName("HUSTORESDAYS").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.StockTime).ColumnName("STOCKTIME");
			  
			this.Column(p =>p.StockID).ColumnName("STOCKID");
			  
			this.Column(p =>p.HouseId).ColumnName("HOUSEID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.unitid).ColumnName("UNITID");
			  
			this.Column(p =>p.CompId).ColumnName("COMPID");
			  
			this.Column(p =>p.StockPrice).ColumnName("STOCKPRICE");
			  
			this.Column(p =>p.RetailPrice).ColumnName("RETAILPRICE");
			  
			this.Column(p =>p.StockNum).ColumnName("STOCKNUM");
			  
			this.Column(p =>p.IsBid).ColumnName("ISBID");
			  
			this.Column(p =>p.IsInject).ColumnName("ISINJECT");
			  
			this.Column(p =>p.OptionPrice).ColumnName("OPTIONPRICE");
			  
			this.Column(p =>p.IsSpecSum).ColumnName("ISSPECSUM");
			  
			this.Column(p =>p.IsAntiBacterial).ColumnName("ISANTIBACTERIAL");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

