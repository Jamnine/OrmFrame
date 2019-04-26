

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 用户相片 - 实体类
	/// </summary>
	public partial class BsUserImageMapping: ClassMap<BsUserImage>
	{   
		/// <summary>
		/// 用户相片 - 实体类
		/// </summary>
		public BsUserImageMapping()
		{
			this.TableName("BSUSERIMAGE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.UserId).ColumnName("USERID");
			  
			this.Column(p =>p.UserImage).ColumnName("USERIMAGE");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");


             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

