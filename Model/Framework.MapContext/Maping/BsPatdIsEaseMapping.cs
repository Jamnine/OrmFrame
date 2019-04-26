

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:病人既往史记录表 - 实体类
	/// </summary>
	public partial class BsPatDiseaseMapping : ClassMap<BsPatDisease>
	{   
		/// <summary>
		/// 行心云:病人既往史记录表 - 实体类
		/// </summary>
		public BsPatDiseaseMapping()
		{
			this.TableName("BSPATDISEASE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.DhID).ColumnName("DHID");
			  
			this.Column(p =>p.DhName).ColumnName("DHNAME");
			  
			this.Column(p =>p.Dhdate).ColumnName("DHDATE");
			  
			this.Column(p =>p.DhType).ColumnName("DHTYPE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.Patid).ColumnName("Patid");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

