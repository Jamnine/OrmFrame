

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检结果影像 - 实体类
	/// </summary>
	public partial class CkResultImageMapping: ClassMap<CkResultImage>
	{   
		/// <summary>
		/// 体检结果影像 - 实体类
		/// </summary>
		public CkResultImageMapping()
		{
			this.TableName("CKRESULTIMAGE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.PatID).ColumnName("PATID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.TjLocationID).ColumnName("TJLOCATIONID");
			  
			this.Column(p =>p.ImageTypePath).ColumnName("IMAGETYPEPATH");
			  
			this.Column(p =>p.Image).ColumnName("IMAGE");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.RecipeDtlId).ColumnName("RecipeDtlId");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

