

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 诊断模板 - 实体类
	/// </summary>
	public partial class TmpEmrMapping: ClassMap<TmpEmr>
	{   
		/// <summary>
		/// 诊断模板 - 实体类
		/// </summary>
		public TmpEmrMapping()
		{
			this.TableName("TMPEMR").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.UseType).ColumnName("USETYPE");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Description).ColumnName("DESCRIPTION");
			  
			this.Column(p =>p.LsOpenType).ColumnName("LSOPENTYPE");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.ParentID).ColumnName("PARENTID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.IcdId).ColumnName("ICDID");
			  
			this.Column(p =>p.ComboType).ColumnName("COMBOTYPE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

