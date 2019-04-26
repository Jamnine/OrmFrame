

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 挂号信息用于微信接口 - 实体类
	/// </summary>
	public partial class OuGetSchInfoMapping: ClassMap<OuGetSchInfo>
	{   
		/// <summary>
		/// 挂号信息用于微信接口 - 实体类
		/// </summary>
		public OuGetSchInfoMapping()
		{
			this.TableName("OUGETSCHINFO").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.Doctorid).ColumnName("DOCTORID");
			  
			this.Column(p =>p.Locationid).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.ShiftId).ColumnName("SHIFTID");
			  
			this.Column(p =>p.ShiftType).ColumnName("SHIFTTYPE");
			  
			this.Column(p =>p.SchDate).ColumnName("SCHDATE");
			  
			this.Column(p =>p.SchRegTypeId).ColumnName("SCHREGTYPEID");
			  
			this.Column(p =>p.SchFee).ColumnName("SCHFEE");
			  
			this.Column(p =>p.SchRegfee).ColumnName("SCHREGFEE");
			  
			this.Column(p =>p.SchTreatfee).ColumnName("SCHTREATFEE");
			  
			this.Column(p =>p.SchBegintime).ColumnName("SCHBEGINTIME");
			  
			this.Column(p =>p.SchEndtime).ColumnName("SCHENDTIME");
			  
			this.Column(p =>p.SchRegMax).ColumnName("SCHREGMAX");
			  
			this.Column(p =>p.SchRegCount).ColumnName("SCHREGCOUNT");
			  
			this.Column(p =>p.SchLimited).ColumnName("SCHLIMITED");
			  
			this.Column(p =>p.schSegmented).ColumnName("SCHSEGMENTED");
			  
			this.Column(p =>p.Iscancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.DiagRoom).ColumnName("DIAGROOM");
			  
			this.Column(p =>p.SpecialtyRoom).ColumnName("SPECIALTYROOM");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

