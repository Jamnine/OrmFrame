

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// pacs近线影像文件 - 实体类
	/// </summary>
	public partial class PsNearAreaFileMapping: ClassMap<PsNearAreaFile>
	{   
		/// <summary>
		/// pacs近线影像文件 - 实体类
		/// </summary>
		public PsNearAreaFileMapping()
		{
			this.TableName("PSNEARAREAFILE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.FileName).ColumnName("FILENAME");
			  
			this.Column(p =>p.Location).ColumnName("LOCATION");
			  
			this.Column(p =>p.StudyInstanceUID).ColumnName("STUDYINSTANCEUID");
			  
			this.Column(p =>p.SeriesUID).ColumnName("SERIESUID");
			  
			this.Column(p =>p.SeriesDesc).ColumnName("SERIESDESC");
			  
			this.Column(p =>p.InstanceNumber).ColumnName("INSTANCENUMBER");
			  
			this.Column(p =>p.IsImage).ColumnName("ISIMAGE");
			  
			this.Column(p =>p.Labels).ColumnName("LABELS");
			  
			this.Column(p =>p.ApplyNo).ColumnName("APPLYNO");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

