

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 会诊医嘱执行表 - 实体类
	/// </summary>
	public partial class PsExecuteMapping: ClassMap<PsExecute>
	{   
		/// <summary>
		/// 会诊医嘱执行表 - 实体类
		/// </summary>
		public PsExecuteMapping()
		{
			this.TableName("PSEXECUTE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.ApplyId).ColumnName("APPLYID");
			  
			this.Column(p =>p.RecipeId).ColumnName("RECIPEID");
			  
			this.Column(p =>p.IsExecuted).ColumnName("ISEXECUTED");
			  
			this.Column(p =>p.ExecutedTime).ColumnName("EXECUTEDTIME");
			  
			this.Column(p =>p.ExecutedOperId).ColumnName("EXECUTEDOPERID");
			  
			this.Column(p =>p.ExecLocId).ColumnName("EXECLOCID");
			  
			this.Column(p =>p.Source).ColumnName("SOURCE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

