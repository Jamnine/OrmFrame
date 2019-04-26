

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 用户 - 实体类
	/// </summary>
	public partial class BsUserMapping: ClassMap<BsUser>
	{   
		/// <summary>
		/// 用户 - 实体类
		/// </summary>
		public BsUserMapping()
		{
			this.TableName("BSUSER").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
            this.Column(p => p.RoleId).ColumnName("RoleId");			  
			this.Column(p =>p.Password).ColumnName("PASSWORD");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");

            this.Column(p => p.Reason).ColumnName("REASON");

            this.Column(p => p.LsInputWay).ColumnName("LSINPUTWAY");

            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");

            this.Column(p => p.IsUserInputWB).ColumnName("ISUSERINPUTWB");

            this.Column(p => p.IsUserInputPY).ColumnName("ISUSERINPUTPY");

            this.Column(p => p.IsUserInputCode).ColumnName("ISUSERINPUTCODE");

            this.Column(p => p.IsUserInputName).ColumnName("ISUSERINPUTNAME");

            this.Column(p => p.IsUserInputStrokeCode).ColumnName("ISUSERINPUTSTROKECODE");

            this.Column(p => p.IsUserInputEngDesc).ColumnName("ISUSERINPUTENGDESC");

            //this.Column(p => p.Introduce).ColumnName("INTRODUCE");

            this.Column(p => p.PicturePath).ColumnName("PICTUREPATH");
            this.Column(p => p.IsItAnExpert).ColumnName("ISITANEXPERT");

            this.Column(p => p.Address).ColumnName("ADDRESS");

            this.Column(p => p.Mobile).ColumnName("MOBILE");

            this.Column(p => p.LevelId).ColumnName("LEVELID");

            this.Column(p => p.DocLevId).ColumnName("DOCLEVID");

            this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			  
			this.Column(p =>p.CareGroupId).ColumnName("CAREGROUPID");
			  
			this.Column(p =>p.CareGroupId1).ColumnName("CAREGROUPID1");
			  
			this.Column(p =>p.CertIdNo).ColumnName("CERTIDNO");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.IsUserInputF1).ColumnName("ISUSERINPUTF1");
			  
			this.Column(p =>p.IsUserInputList).ColumnName("ISUSERINPUTLIST");
			  
			this.Column(p =>p.IsUserWordPad).ColumnName("ISUSERWORDPAD");
			  
			this.Column(p =>p.IsUserSelectOnly).ColumnName("ISUSERSELECTONLY");

			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");

            this.Column(p => p.IsGivereDenvelopes).ColumnName("IsGivereDenvelopes");

            this.Column(p => p.Remark).ColumnName("REMARK");

            this.Column(p => p.DepartmentId).ColumnName("DEPARTMENTID");

            this.Column(p => p.IsInternalStaff).ColumnName("ISINTERNALSTAFF");

            this.Column(p => p.Deduct).ColumnName("DEDUCT");


            this.Column(p => p.LsStatus).ColumnName("LSSTATUS");

            this.Column(p => p.Email).ColumnName("EMAIL");

            this.Column(p => p.BirthDate).ColumnName("BIRTHDATE");

            this.Column(p => p.Sex).ColumnName("SEX");

            this.Column(p => p.ModiOperId).ColumnName("MODIOPERID");

            this.Column(p => p.ModiTime).ColumnName("MODITIME");

            this.Column(p => p.OperTime).ColumnName("OPERTIME");//

            this.Column(p => p.IsIntegralStaff).ColumnName("ISINTEGRALSTAFF"); 
            this.Column(p => p.IsCancancel).ColumnName("ISCANCANCEL");

            this.Column(p => p.IsVolunteer).ColumnName("ISVOLUNTEER");
            this.Column(p => p.DiagRoomId).ColumnName("DIAGROOMID");
            this.Column(p => p.IsRecipe).ColumnName("IsRecipe");

            this.Column(p => p.RuleId).ColumnName("RULEID");
            this.Ignore(p => p.PictureSource);

          
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }      
	}  
}           
 

