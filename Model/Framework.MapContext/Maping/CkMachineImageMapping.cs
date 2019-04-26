

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CkMachineImageMapping: ClassMap<CkMachineImage>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CkMachineImageMapping()
		{
			this.TableName("CKMACHINEIMAGE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LabID).ColumnName("LABID");
			  
			this.Column(p =>p.SampleNum).ColumnName("SAMPLENUM");
			  
			this.Column(p =>p.MachineID).ColumnName("MACHINEID");
			  
			this.Column(p =>p.LabImage).ColumnName("LABIMAGE");
			  
			this.Column(p =>p.ImageType).ColumnName("IMAGETYPE");
			  
			this.Column(p =>p.IsDisplay).ColumnName("ISDISPLAY");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.InstrmentSeqID).ColumnName("INSTRMENTSEQID");
			  
			this.Column(p =>p.DisplayOrder).ColumnName("DISPLAYORDER");
			  
			this.Column(p =>p.IsReport).ColumnName("ISREPORT");
			  
			this.Column(p =>p.CreateDate).ColumnName("CREATEDATE");
			  
			this.Column(p =>p.ImageBin).ColumnName("IMAGEBIN");
			  
			this.Column(p =>p.ImageId).ColumnName("IMAGEID");
			  
			this.Column(p =>p.Seq).ColumnName("SEQ");
			  
			this.Column(p =>p.ImageDotValue).ColumnName("IMAGEDOTVALUE");
			  
			this.Column(p =>p.Filepath).ColumnName("FILEPATH");
			  
			this.Column(p =>p.InstrumentSeqID).ColumnName("INSTRUMENTSEQID");
			  
			this.Column(p =>p.BatchNo).ColumnName("BATCHNO");
			  
			this.Column(p =>p.Barcode).ColumnName("BARCODE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

