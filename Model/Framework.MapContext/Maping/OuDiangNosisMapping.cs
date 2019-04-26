

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:诊断意见表 - 实体类
	/// </summary>
	public partial class OuDiangNosisMapping: ClassMap<OuDiangNosis>
	{   
		/// <summary>
		/// 行心云:诊断意见表 - 实体类
		/// </summary>
		public OuDiangNosisMapping()
		{
			this.TableName("OUDIAGNOSIS").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Medicalrecordid).ColumnName("MEDICALRECORDID");
			  
			this.Column(p =>p.Tjsuggestionid).ColumnName("TJSUGGESTIONID");
			  
			this.Column(p =>p.Diseasename).ColumnName("DISEASENAME");
			  
			this.Column(p =>p.Diseasecode).ColumnName("DISEASECODE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

