

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class GblEMRQcItemMapping: ClassMap<GblEMRQcItem>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public GblEMRQcItemMapping()
		{
			this.TableName("GBLEMRQCITEM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.GroupID).ColumnName("GROUPID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Standard).ColumnName("STANDARD");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.FullPoint).ColumnName("FULLPOINT");
			  
			this.Column(p =>p.FailPoint).ColumnName("FAILPOINT");
			  
			this.Column(p =>p.LsImportant).ColumnName("LSIMPORTANT");
			  
			this.Column(p =>p.IsLock).ColumnName("ISLOCK");
			  
			this.Column(p =>p.TipInfo).ColumnName("TIPINFO");
			  
			this.Column(p =>p.CatalogId).ColumnName("CATALOGID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

