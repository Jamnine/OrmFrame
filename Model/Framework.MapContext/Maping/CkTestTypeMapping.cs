

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验分类 - 实体类
	/// </summary>
	public partial class CkTestTypeMapping: ClassMap<CkTestType>
	{   
		/// <summary>
		/// 检验分类 - 实体类
		/// </summary>
		public CkTestTypeMapping()
		{
			this.TableName("CKTESTTYPE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.TestGroupId).ColumnName("TESTGROUPID");
			  
			this.Column(p =>p.IsLab).ColumnName("ISLAB");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.GroupMain).ColumnName("GROUPMAIN");
			  
			this.Column(p =>p.GroupSub).ColumnName("GROUPSUB");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            //this.Column(p => p.ModioperId).ColumnName("MODIOPERID");

            //this.Column(p => p.Moditime).ColumnName("MODITEM");

            //this.Column(p => p.IsAutomaticSummary).ColumnName("ISAUTOMATICSUMMARY");



            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

