

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 镇、街道办事处 - 实体类
	/// </summary>
	public partial class BsAreaPoliceStationMapping: ClassMap<BsAreaPoliceStation>
	{   
		/// <summary>
		/// 镇、街道办事处 - 实体类
		/// </summary>
		public BsAreaPoliceStationMapping()
		{
			this.TableName("BSAREAPOLICESTATION").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.AreaId).ColumnName("AREAID");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.UpCode).ColumnName("UPCODE");
			  
			this.Column(p =>p.YbCode).ColumnName("YBCODE");
			  
			this.Column(p =>p.MoDioperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

