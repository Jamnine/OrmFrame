

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:既往史表 - 实体类
	/// </summary>
	public partial class BsDiseaseHistoryMapping: ClassMap<BsDiseaseHistory>
	{   
		/// <summary>
		/// 行心云:既往史表 - 实体类
		/// </summary>
		public BsDiseaseHistoryMapping()
		{
			this.TableName("BSDISEASEHISTORY").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.Isdisease).ColumnName("ISDISEASE");
			  
			this.Column(p =>p.Isfamily).ColumnName("ISFAMILY");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperDate).ColumnName("OPERDATE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

