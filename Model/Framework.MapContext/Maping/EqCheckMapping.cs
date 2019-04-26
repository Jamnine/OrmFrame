

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class EqCheckMapping: ClassMap<EqCheck>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public EqCheckMapping()
		{
			this.TableName("EQCHECK").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.EquipmentId).ColumnName("EQUIPMENTID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.CheckTime).ColumnName("CHECKTIME");
			  
			this.Column(p =>p.CheckMan).ColumnName("CHECKMAN");
			  
			this.Column(p =>p.Result).ColumnName("RESULT");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

