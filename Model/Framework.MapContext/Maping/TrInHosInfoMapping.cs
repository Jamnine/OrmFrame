

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 病人屏蔽表 - 实体类
	/// </summary>
	public partial class TrInHosInfoMapping: ClassMap<TrInHosInfo>
	{   
		/// <summary>
		/// 病人屏蔽表 - 实体类
		/// </summary>
		public TrInHosInfoMapping()
		{
			this.TableName("TRINHOSINFO").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.InPatNo).ColumnName("INPATNO");
			  
			this.Column(p =>p.CardNo).ColumnName("CARDNO");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.Sex).ColumnName("SEX");
			  
			this.Column(p =>p.InTime).ColumnName("INTIME");
			  
			this.Column(p =>p.OutTime).ColumnName("OUTTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.BedId).ColumnName("BEDID");
			  
			this.Column(p =>p.LsInStatus).ColumnName("LSINSTATUS");
			  
			this.Column(p =>p.LocIn).ColumnName("LOCIN");
			  
			this.Column(p =>p.Residence).ColumnName("RESIDENCE");
			  
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.IdCardNo).ColumnName("IDCARDNO");
			  
			this.Column(p =>p.LsMarriage).ColumnName("LSMARRIAGE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

