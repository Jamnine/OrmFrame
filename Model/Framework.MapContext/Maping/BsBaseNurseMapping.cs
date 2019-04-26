

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 临床路径护理 - 实体类
	/// </summary>
	public partial class BsBaseNurseMapping: ClassMap<BsBaseNurse>
	{   
		/// <summary>
		/// 临床路径护理 - 实体类
		/// </summary>
		public BsBaseNurseMapping()
		{
			this.TableName("BSBASENURSE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.GroupMainId).ColumnName("GROUPMAINID");
			  
			this.Column(p =>p.GroupSubId).ColumnName("GROUPSUBID");
			  
			this.Column(p =>p.GroupSubId2).ColumnName("GROUPSUBID2");
			  
			this.Column(p =>p.EngDesc).ColumnName("ENGDESC");
			  
			this.Column(p =>p.LsYbType).ColumnName("LSYBTYPE");
			  
			this.Column(p =>p.YbMemo).ColumnName("YBMEMO");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");
             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

