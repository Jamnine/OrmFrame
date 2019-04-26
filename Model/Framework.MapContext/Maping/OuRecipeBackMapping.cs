

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊处方退药申请表 - 实体类
	/// </summary>
	public partial class OuRecipeBackMapping: ClassMap<OuRecipeBack>
	{   
		/// <summary>
		/// 门诊处方退药申请表 - 实体类
		/// </summary>
		public OuRecipeBackMapping()
		{
			this.TableName("OURECIPEBACK").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.ReqDtlId).ColumnName("REQDTLID");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.DetailId).ColumnName("DETAILID");
			  
			this.Column(p =>p.IsCharged).ColumnName("ISCHARGED");
			  
			this.Column(p =>p.IssueTotality).ColumnName("ISSUETOTALITY");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

