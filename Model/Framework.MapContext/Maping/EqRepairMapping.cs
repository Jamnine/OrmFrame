

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class EqRepairMapping: ClassMap<EqRepair>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public EqRepairMapping()
		{
			this.TableName("EQREPAIR").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.EquipmentId).ColumnName("EQUIPMENTID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.RepairTime).ColumnName("REPAIRTIME");
			  
			this.Column(p =>p.Reason).ColumnName("REASON");
			  
			this.Column(p =>p.RepairWay).ColumnName("REPAIRWAY");
			  
			this.Column(p =>p.RepairUnit).ColumnName("REPAIRUNIT");
			  
			this.Column(p =>p.RepairMan).ColumnName("REPAIRMAN");
			  
			this.Column(p =>p.RepairFee).ColumnName("REPAIRFEE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

