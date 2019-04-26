

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 单位体检项目 - 实体类
	/// </summary>
	public partial class CkCompGroupPsApplyMapping: ClassMap<CkCompGroupPsApply>
	{   
		/// <summary>
		/// 单位体检项目 - 实体类
		/// </summary>
		public CkCompGroupPsApplyMapping()
		{
			this.TableName("CKCOMPGROUPPSAPPLY").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.XType).ColumnName("XTYPE");
			  
			this.Column(p =>p.IsPre).ColumnName("ISPRE");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.ApplyMemo).ColumnName("APPLYMEMO");
			  
			this.Column(p =>p.Summary).ColumnName("SUMMARY");
			  
			this.Column(p =>p.Diagnose).ColumnName("DIAGNOSE");
			  
			this.Column(p =>p.CompGroupId).ColumnName("COMPGROUPID");
			  
			this.Column(p =>p.CheckBody).ColumnName("CHECKBODY");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

