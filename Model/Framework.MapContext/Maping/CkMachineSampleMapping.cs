

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验仪器流水号匹配 - 实体类
	/// </summary>
	public partial class CkMachineSampleMapping: ClassMap<CkMachineSample>
	{   
		/// <summary>
		/// 检验仪器流水号匹配 - 实体类
		/// </summary>
		public CkMachineSampleMapping()
		{
			this.TableName("CKMACHINESAMPLE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LabID).ColumnName("LABID");
			  
			this.Column(p =>p.SampleNum).ColumnName("SAMPLENUM");
			  
			this.Column(p =>p.MatchDate).ColumnName("MATCHDATE");
			  
			this.Column(p =>p.SendStatus).ColumnName("SENDSTATUS");
			  
			this.Column(p =>p.MachineID).ColumnName("MACHINEID");
			  
			this.Column(p =>p.UserID).ColumnName("USERID");
			  
			this.Column(p =>p.Status).ColumnName("STATUS");
			  
			this.Column(p =>p.Labdeptid).ColumnName("LABDEPTID");
			  
			this.Column(p =>p.MatchBy).ColumnName("MATCHBY");
			  
			this.Column(p =>p.IsMic).ColumnName("ISMIC");
			  
			this.Column(p =>p.SpecimenHeadID).ColumnName("SPECIMENHEADID");
			  
			this.Column(p =>p.PreSeq).ColumnName("PRESEQ");
			  
			this.Column(p =>p.Barcode).ColumnName("BARCODE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

