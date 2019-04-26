

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CkMachineSettingMapping: ClassMap<CkMachineSetting>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CkMachineSettingMapping()
		{
			this.TableName("CKMACHINESETTING").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.InitLocalSettingid).ColumnName("INITLOCALSETTINGID");
			  
			this.Column(p =>p.Cpuid).ColumnName("CPUID");
			  
			this.Column(p =>p.Mac).ColumnName("MAC");
			  
			this.Column(p =>p.Ip).ColumnName("IP");
			  
			this.Column(p =>p.HostName).ColumnName("HOSTNAME");
			  
			this.Column(p =>p.DictLocationid).ColumnName("DICTLOCATIONID");
			  
			this.Column(p =>p.LabelPrinter).ColumnName("LABELPRINTER");
			  
			this.Column(p =>p.DictInstrumentid1).ColumnName("DICTINSTRUMENTID1");
			  
			this.Column(p =>p.ReportPrintera5).ColumnName("REPORTPRINTERA5");
			  
			this.Column(p =>p.DictInstrumentid2).ColumnName("DICTINSTRUMENTID2");
			  
			this.Column(p =>p.DictInstrumentid3).ColumnName("DICTINSTRUMENTID3");
			  
			this.Column(p =>p.DictInstrumentid4).ColumnName("DICTINSTRUMENTID4");
			  
			this.Column(p =>p.DictInstrumentid5).ColumnName("DICTINSTRUMENTID5");
			  
			this.Column(p =>p.DictInstrumentid6).ColumnName("DICTINSTRUMENTID6");
			  
			this.Column(p =>p.DictInstrumentid7).ColumnName("DICTINSTRUMENTID7");
			  
			this.Column(p =>p.ReportPrintera4).ColumnName("REPORTPRINTERA4");
			  
			this.Column(p =>p.ReportPrinterNeedle).ColumnName("REPORTPRINTERNEEDLE");
			  
			this.Column(p =>p.SpecimenType).ColumnName("SPECIMENTYPE");
			  
			this.Column(p =>p.Remark).ColumnName("REMARK");
			  
			this.Column(p =>p.IsChanged).ColumnName("ISCHANGED");
			  
			this.Column(p =>p.IsDeleted).ColumnName("ISDELETED");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

