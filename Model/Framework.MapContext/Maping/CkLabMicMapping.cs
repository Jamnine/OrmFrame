

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验细菌主表 - 实体类
	/// </summary>
	public partial class CkLabMicMapping: ClassMap<CkLabMic>
	{   
		/// <summary>
		/// 检验细菌主表 - 实体类
		/// </summary>
		public CkLabMicMapping()
		{
			this.TableName("CKLABMIC").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LabId).ColumnName("LABID");
			  
			this.Column(p =>p.BacteriaId).ColumnName("BACTERIAID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsPrint).ColumnName("ISPRINT");
			  
			this.Column(p =>p.PrintTime).ColumnName("PRINTTIME");
			  
			this.Column(p =>p.PrintOperId).ColumnName("PRINTOPERID");
			  
			this.Column(p =>p.LabIdStr).ColumnName("LABIDSTR");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

