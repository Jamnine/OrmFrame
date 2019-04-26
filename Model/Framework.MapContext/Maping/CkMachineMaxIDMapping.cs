

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 存取表的主键的当前最大值 - 实体类
	/// </summary>
	public partial class CkMachineMaxIDMapping: ClassMap<CkMachineMaxID>
	{   
		/// <summary>
		/// 存取表的主键的当前最大值 - 实体类
		/// </summary>
		public CkMachineMaxIDMapping()
		{
			this.TableName("CKMACHINEMAXID").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.TableName).ColumnName("TABLENAME");
			  
			this.Column(p =>p.IDValue).ColumnName("IDVALUE");
			  
			this.Column(p =>p.Remark).ColumnName("REMARK");
			  
			this.Column(p =>p.LastUpdate).ColumnName("LASTUPDATE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

