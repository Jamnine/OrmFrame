

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 医生表 - 实体类
	/// </summary>
	public partial class BsDoctorMapping: ClassMap<BsDoctor>
	{   
		/// <summary>
		/// 医生表 - 实体类
		/// </summary>
		public BsDoctorMapping()
		{
			this.TableName("BSDOCTOR").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Sex).ColumnName("SEX");
			  
			this.Column(p =>p.BirthDate).ColumnName("BIRTHDATE");
			  
			this.Column(p =>p.Address).ColumnName("ADDRESS");
			  
			this.Column(p =>p.City).ColumnName("CITY");
			  
			this.Column(p =>p.Mobile).ColumnName("MOBILE");
			  
			this.Column(p =>p.Email).ColumnName("EMAIL");
			  
			this.Column(p =>p.LevelId).ColumnName("LEVELID");
			  
			this.Column(p =>p.DocLevId).ColumnName("DOCLEVID");
			  
			this.Column(p =>p.Introduce).ColumnName("INTRODUCE");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.RegTypeId).ColumnName("REGTYPEID");
			  
			this.Column(p =>p.PicturePath).ColumnName("PICTUREPATH");
			  
			this.Column(p =>p.LsStatus).ColumnName("LSSTATUS");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.UserId).ColumnName("USERID");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.SupDoctorId).ColumnName("SUPDOCTORID");
			  
			this.Column(p =>p.DiagRoomID).ColumnName("DIAGROOMID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.IsPoisonMa).ColumnName("ISPOISONMA");
			  
			this.Column(p =>p.IsRecipe).ColumnName("ISRECIPE");
			  
			this.Column(p =>p.Grade).ColumnName("GRADE");
			  
			this.Column(p =>p.IsConsult).ColumnName("ISCONSULT");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

