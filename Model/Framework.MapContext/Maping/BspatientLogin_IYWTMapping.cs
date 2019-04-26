

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 医务通登录 - 实体类
	/// </summary>
	public partial class BspatientLogin_IYWTMapping : ClassMap<BspatientLogin_IYWT>
	{
        /// <summary>
        /// 医务通登录 - 实体类
        /// </summary>
        public BspatientLogin_IYWTMapping()
		{
			this.TableName("BSPATIENTLOGIN_IYWT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
            this.Column(p => p.Login_id).ColumnName("LOGIN_ID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Password).ColumnName("PASSWORD");
            this.Column(p => p.Patient).ColumnName("PATIENT");
            this.Column(p => p.Social_no).ColumnName("SOCIAL_NO");
            this.Column(p => p.Telephone).ColumnName("TELEPHONE");
            this.Column(p => p.Ic_card).ColumnName("IC_CARD");
            this.Column(p => p.Sex).ColumnName("SEX");
            this.Column(p => p.Birthday).ColumnName("BIRTHDAY");
            this.Column(p => p.Country_code).ColumnName("COUNTRY_CODE");
            this.Column(p => p.Nation_code).ColumnName("NATION_CODE");
            this.Column(p => p.Birth_place).ColumnName("BIRTH_PLACE");
            this.Column(p => p.Home_district).ColumnName("HOME_DISTRICT");
            this.Column(p => p.Home_street).ColumnName("HOME_STREET");
            this.Column(p => p.Home_zipcode).ColumnName("HOME_ZIPCODE");
            this.Column(p => p.Email).ColumnName("EMAIL");
            this.Column(p => p.Response_type).ColumnName("RESPONSE_TYPE");
            this.Column(p => p.Charge_type).ColumnName("CHARGE_TYPE");
            this.Column(p => p.Unit_code).ColumnName("UNIT_CODE");
            this.Column(p => p.Unit_name).ColumnName("UNIT_NAME");
            this.Column(p => p.Hic_no).ColumnName("HIC_NO");
            this.Column(p => p.Marry_code).ColumnName("MARRY_CODE");
            this.Column(p => p.Relation_name).ColumnName("RELATION_NAME");
            this.Column(p => p.Relation_code).ColumnName("RELATION_CODE");
            this.Column(p => p.Relation_tel).ColumnName("RELATION_TEL");
            this.Column(p => p.Occupation_type).ColumnName("OCCUPATION_TYPE");
            this.Column(p => p.Introducer).ColumnName("INTRODUCER");
            this.Column(p =>p.HospitalId).ColumnName("HOSPITALID");	 
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

