

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:用户相片 - 实体类
	/// </summary>
	public partial class BsUserPhotoMapping: ClassMap<BsUserPhoto>
	{   
		/// <summary>
		/// 行心云:用户相片 - 实体类
		/// </summary>
		public BsUserPhotoMapping()
		{
			this.TableName("BSUSERPHOTO").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.UserId).ColumnName("USERID");
			  
			this.Column(p =>p.IntroDuce).ColumnName("INTRODUCE");
			  
			this.Column(p =>p.PictureSource).ColumnName("PICTURESOURCE");
			  
			this.Column(p =>p.Specialty).ColumnName("SPECIALTY");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

