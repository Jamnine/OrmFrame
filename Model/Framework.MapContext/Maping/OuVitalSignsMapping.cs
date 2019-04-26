

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:生命指标记录表 - 实体类
	/// </summary>
	public partial class OuVitalSignsMapping: ClassMap<OuVitalSigns>
	{   
		/// <summary>
		/// 行心云:生命指标记录表 - 实体类
		/// </summary>
		public OuVitalSignsMapping()
		{
			this.TableName("OUVITALSIGNS").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.Temperature).ColumnName("TEMPERATURE");
			  
			this.Column(p =>p.Pulse).ColumnName("PULSE");
			  
			this.Column(p =>p.Systolic).ColumnName("SYSTOLIC");
			  
			this.Column(p =>p.Diastolic).ColumnName("DIASTOLIC");
			  
			this.Column(p =>p.BloodGlucose).ColumnName("BLOODGLUCOSE");
			  
			this.Column(p =>p.Height).ColumnName("HEIGHT");
			  
			this.Column(p =>p.Weight).ColumnName("WEIGHT");
			  
			this.Column(p =>p.Comments).ColumnName("COMMENTS");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.ModifiedOperId).ColumnName("MODIFIEDOPERID");
			  
			this.Column(p =>p.ModifiedTime).ColumnName("MODIFIEDTIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

