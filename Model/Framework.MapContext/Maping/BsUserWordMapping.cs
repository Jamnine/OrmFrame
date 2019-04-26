

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 用户常用词汇 - 实体类
	/// </summary>
	public partial class BsUserWordMapping: ClassMap<BsUserWord>
	{   
		/// <summary>
		/// 用户常用词汇 - 实体类
		/// </summary>
		public BsUserWordMapping()
		{
			this.TableName("BSUSERWORD").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.KeyType).ColumnName("KEYTYPE");
			  
			this.Column(p =>p.Content).ColumnName("CONTENT");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.pycode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

