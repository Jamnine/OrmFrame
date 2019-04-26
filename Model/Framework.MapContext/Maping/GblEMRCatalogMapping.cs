

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 电子病历左边节点 - 实体类
	/// </summary>
	public partial class GblEMRCatalogMapping: ClassMap<GblEMRCatalog>
	{   
		/// <summary>
		/// 电子病历左边节点 - 实体类
		/// </summary>
		public GblEMRCatalogMapping()
		{
			this.TableName("GBLEMRCATALOG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.ParentID).ColumnName("PARENTID");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.InfoPathFile).ColumnName("INFOPATHFILE");
			  
			this.Column(p =>p.LsCompareType).ColumnName("LSCOMPARETYPE");
			  
			this.Column(p =>p.AheadHours).ColumnName("AHEADHOURS");
			  
			this.Column(p =>p.IsProgressNote).ColumnName("ISPROGRESSNOTE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

