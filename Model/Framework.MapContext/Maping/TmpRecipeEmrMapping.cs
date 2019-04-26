

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:处方模板维护主表 - 实体类
	/// </summary>
	public partial class TmpRecipeEmrMapping: ClassMap<TmpRecipeEmr>
	{   
		/// <summary>
		/// 行心云:处方模板维护主表 - 实体类
		/// </summary>
		public TmpRecipeEmrMapping()
		{
			this.TableName("TMPRECIPEEMR").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LsRepType).ColumnName("LSREPTYPE");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.GroupMain).ColumnName("GROUPMAIN");
			  
			this.Column(p =>p.GroupSub).ColumnName("GROUPSUB");
			  
			this.Column(p =>p.Recipename).ColumnName("RECIPENAME");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.MemoOperId).ColumnName("MEMOOPERID");
			  
			this.Column(p =>p.Modificationtime).ColumnName("MODIFICATIONTIME");
			  
			this.Column(p =>p.Memoopername).ColumnName("MEMOOPERNAME");
			  
			this.Column(p =>p.Tmptype).ColumnName("TMPTYPE");
			  
			this.Column(p =>p.ItemName).ColumnName("ITEMNAME");
			  
			this.Column(p =>p.LsOpenType).ColumnName("LSOPENTYPE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");




            this.Id(t => t.GUID);
            this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

