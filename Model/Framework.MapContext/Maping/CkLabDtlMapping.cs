

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验项目明细 - 实体类
	/// </summary>
	public partial class CkLabDtlMapping: ClassMap<CkLabDtl>
	{   
		/// <summary>
		/// 检验项目明细 - 实体类
		/// </summary>
		public CkLabDtlMapping()
		{
			this.TableName("CKLABDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LabId).ColumnName("LABID");
			  
			this.Column(p =>p.TestId).ColumnName("TESTID");
			  
			this.Column(p =>p.SourceId).ColumnName("SOURCEID");
			  
			this.Column(p =>p.TubeTypeId).ColumnName("TUBETYPEID");
			  
			this.Column(p =>p.IsDownLoad).ColumnName("ISDOWNLOAD");
			  
			this.Column(p =>p.IsPrint).ColumnName("ISPRINT");
			  
			this.Column(p =>p.PrintTime).ColumnName("PRINTTIME");
			  
			this.Column(p =>p.PrintOperId).ColumnName("PRINTOPERID");
			  
			this.Column(p =>p.IsBilled).ColumnName("ISBILLED");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.ParentID).ColumnName("PARENTID");
			  
			this.Column(p =>p.RecipeDtlId).ColumnName("RECIPEDTLID");
			  
			this.Column(p =>p.DetailId).ColumnName("DETAILID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.TestTypeId).ColumnName("TESTTYPEID");
			  
			this.Column(p =>p.LsMarkType).ColumnName("LSMARKTYPE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

