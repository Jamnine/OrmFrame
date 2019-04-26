

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 血液类型 - 实体类
	/// </summary>
	public partial class CkBloodTypeMapping: ClassMap<CkBloodType>
	{   
		/// <summary>
		/// 血液类型 - 实体类
		/// </summary>
		public CkBloodTypeMapping()
		{
			this.TableName("CKBLOODTYPE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.PriceIn).ColumnName("PRICEIN");
			  
			this.Column(p =>p.PriceOut).ColumnName("PRICEOUT");
			  
			this.Column(p =>p.LimitDays).ColumnName("LIMITDAYS");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.UnderLineKc).ColumnName("UNDERLINEKC");
			  
			this.Column(p =>p.GroupMian).ColumnName("GROUPMIAN");
			  
			this.Column(p =>p.GroupSub).ColumnName("GROUPSUB");
			  
			this.Column(p =>p.ProcessingItemId).ColumnName("PROCESSINGITEMID");
			  
			this.Column(p =>p.WithBloodItemId).ColumnName("WITHBLOODITEMID");
			  
			this.Column(p =>p.ReviewItem).ColumnName("REVIEWITEM");
			  
			this.Column(p =>p.StorageItem).ColumnName("STORAGEITEM");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

