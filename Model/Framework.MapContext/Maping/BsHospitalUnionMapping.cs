

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:医联体管理 - 实体类
	/// </summary>
	public partial class BsHospitalUnionMapping: ClassMap<BsHospitalUnion>
	{   
		/// <summary>
		/// 行心云:医联体管理 - 实体类
		/// </summary>
		public BsHospitalUnionMapping()
		{
			this.TableName("BSHOSPITALUNION").Schema("orm");
			  
			this.Column(p =>p.ProvinceId).ColumnName("PROVINCEID");
			  
			this.Column(p =>p.RegionId).ColumnName("REGIONID");
			  
			this.Column(p =>p.AreaId).ColumnName("AREAID");
			  
			this.Column(p =>p.Address).ColumnName("ADDRESS");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.AdminId).ColumnName("ADMINID");
			  
			this.Column(p =>p.IsParent).ColumnName("ISPARENT");
			  
			this.Column(p =>p.ParentId).ColumnName("PARENTID");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperLastDate).ColumnName("OPERLASTDATE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

