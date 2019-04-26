

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云：电子病历主表信息 - 实体类
	/// </summary>
	public partial class ToothEmrMapping: ClassMap<ToothEmr>
	{   
		/// <summary>
		/// 行心云：电子病历主表信息 - 实体类
		/// </summary>
		public ToothEmrMapping()
		{
			this.TableName("TOOTHEMR").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.MainInform).ColumnName("MAININFORM");
			  
			this.Column(p =>p.SickHist).ColumnName("SICKHIST");
			  
			this.Column(p =>p.AdviceNotice).ColumnName("ADVICENOTICE");
			  
			this.Column(p =>p.Mome).ColumnName("MOME");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.RecordNumber).ColumnName("RECORDNUMBER");
			  
			this.Column(p =>p.DoctorAssistant).ColumnName("DOCTORASSISTANT");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.PatID).ColumnName("PATID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

