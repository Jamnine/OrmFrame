

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 病人类别一级分组 - 实体类
	/// </summary>
	public partial class BsTallyGroupMapping: ClassMap<BsTallyGroup>
	{   
		/// <summary>
		/// 病人类别一级分组 - 实体类
		/// </summary>
		public BsTallyGroupMapping()
		{
			this.TableName("BSTALLYGROUP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");

            this.Column(p => p.Code).ColumnName("CODE");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.IsGf).ColumnName("ISGF");
            this.Column(p => p.IsYb).ColumnName("ISYB");
            this.Column(p => p.YbHospNo).ColumnName("YBHOSPNO");
            this.Column(p => p.PyCode).ColumnName("PYCODE");
            this.Column(p => p.WbCode).ColumnName("WBCODE");
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.IconIndex).ColumnName("ICONINDEX"); 
            this.Column(p => p.ModiTime).ColumnName("MODITIME");
            this.Column(p => p.ModiOperId).ColumnName("MODIOPERID");
             

            this.Column(p =>p.ZyClassName).ColumnName("ZYCLASSNAME");
			  
			this.Column(p =>p.MzClassName).ColumnName("MZCLASSNAME");
			  
			this.Column(p =>p.Lsinout).ColumnName("LSINOUT");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

