

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class EqTransferMapping: ClassMap<EqTransfer>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public EqTransferMapping()
		{
			this.TableName("EQTRANSFER").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.EquipmentId).ColumnName("EQUIPMENTID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.ChangeTime).ColumnName("CHANGETIME");
			  
			this.Column(p =>p.Reason).ColumnName("REASON");
			  
			this.Column(p =>p.FromLocId).ColumnName("FROMLOCID");
			  
			this.Column(p =>p.ToLocId).ColumnName("TOLOCID");
			  
			this.Column(p =>p.ToPlace).ColumnName("TOPLACE");
			  
			this.Column(p =>p.RecieveMan).ColumnName("RECIEVEMAN");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

