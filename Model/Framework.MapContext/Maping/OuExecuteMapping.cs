

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊执行单(注射) - 实体类
	/// </summary>
	public partial class OuExecuteMapping: ClassMap<OuExecute>
	{   
		/// <summary>
		/// 门诊执行单(注射) - 实体类
		/// </summary>
		public OuExecuteMapping()
		{
			this.TableName("OUEXECUTE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.LsRepType).ColumnName("LSREPTYPE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.RecipeId).ColumnName("RECIPEID");
			  
			this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.NDay).ColumnName("NDAY");
			  
			this.Column(p =>p.NTime).ColumnName("NTIME");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.IsExecuted).ColumnName("ISEXECUTED");
			  
			this.Column(p =>p.ExecuteDate).ColumnName("EXECUTEDATE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            
                this.Column(p => p.RecipeDtlId).ColumnName("RECIPEDTLID");
            this.Column(p => p.ExecuteUserId).ColumnName("EXECUTEUSERID");





            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

