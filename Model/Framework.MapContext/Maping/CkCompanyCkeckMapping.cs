

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检单位预约时间 - 实体类
	/// </summary>
	public partial class CkCompanyCkeckMapping: ClassMap<CkCompanyCkeck>
	{   
		/// <summary>
		/// 体检单位预约时间 - 实体类
		/// </summary>
		public CkCompanyCkeckMapping()
		{
			this.TableName("CKCOMPANYCKECK").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.CompanyId).ColumnName("COMPANYID");
			  
			this.Column(p =>p.CkeckDate).ColumnName("CKECKDATE");
			  
			this.Column(p =>p.CkeckNo).ColumnName("CKECKNO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");


             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

