

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 亲属关系 - 实体类
	/// </summary>
	public partial class Bsrelation_IYWTMapping : ClassMap<Bsrelation_IYWT>
	{
        /// <summary>
        /// 亲属关系 - 实体类
        /// </summary>
        public Bsrelation_IYWTMapping()
		{
			this.TableName("Bsrelation_IYWT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
            this.Column(p => p.LoginId).ColumnName("LOGINID");
            this.Column(p => p.Name).ColumnName("NAME");
            this.Column(p => p.Sex).ColumnName("SEX");
            this.Column(p => p.Birthday).ColumnName("BIRTHDAY");
            this.Column(p => p.Country).ColumnName("COUNTRY");
            this.Column(p => p.Nation).ColumnName("NATION");
            this.Column(p => p.Telephone).ColumnName("TELEPHONE");
            this.Column(p => p.Social).ColumnName("SOCIAL");
            this.Column(p => p.Address).ColumnName("ADDRESS");
            this.Column(p => p.Relation).ColumnName("RELATION");
            this.Column(p =>p.HospitalId).ColumnName("HOSPITALID");	 
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

