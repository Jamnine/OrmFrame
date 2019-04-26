

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:专家管理 - 实体类
	/// </summary>
	public partial class BsSpecialistMapping: ClassMap<BsSpecialist>
	{   
		/// <summary>
		/// 行心云:专家管理 - 实体类
		/// </summary>
		public BsSpecialistMapping()
		{
			this.TableName("BSSPECIALIST").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Sex).ColumnName("SEX");
			  
			this.Column(p =>p.ProvinceId).ColumnName("PROVINCEID");
			  
			this.Column(p =>p.RegionId).ColumnName("REGIONID");
			  
			this.Column(p =>p.AreaId).ColumnName("AREAID");
			  
			this.Column(p =>p.AddRess).ColumnName("ADDRESS");
			  
			this.Column(p =>p.DocLevId).ColumnName("DOCLEVID");
			  
			this.Column(p =>p.Phone).ColumnName("PHONE");
			  
			this.Column(p =>p.Email).ColumnName("EMAIL");
			  
			this.Column(p =>p.ClinicId).ColumnName("CLINICID");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsAudit).ColumnName("ISAUDIT");
			  
			this.Column(p =>p.BirthDate).ColumnName("BIRTHDATE");
			  
			this.Column(p =>p.Hospital).ColumnName("HOSPITAL");
			  
			this.Column(p =>p.Department).ColumnName("DEPARTMENT");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			  
			this.Column(p =>p.DepartmentId).ColumnName("DEPARTMENTID");
			  
			this.Column(p =>p.HospitalUnionId).ColumnName("HOSPITALUNIONID");
			  
			this.Column(p =>p.OccupationCertificate).ColumnName("OCCUPATIONCERTIFICATE");
			  
			this.Column(p =>p.HireCertificate).ColumnName("HIRECERTIFICATE");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

