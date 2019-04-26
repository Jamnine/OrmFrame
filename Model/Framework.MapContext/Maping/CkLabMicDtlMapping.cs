

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验细菌明细表 - 实体类
	/// </summary>
	public partial class CkLabMicDtlMapping: ClassMap<CkLabMicDtl>
	{   
		/// <summary>
		/// 检验细菌明细表 - 实体类
		/// </summary>
		public CkLabMicDtlMapping()
		{
			this.TableName("CKLABMICDTL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.MicId).ColumnName("MICID");
			  
			this.Column(p =>p.DrugId).ColumnName("DRUGID");
			  
			this.Column(p =>p.Result).ColumnName("RESULT");
			  
			this.Column(p =>p.LsMic).ColumnName("LSMIC");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.LabIdStr).ColumnName("LABIDSTR");
			  
			this.Column(p =>p.LabIdStrDtl).ColumnName("LABIDSTRDTL");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

