

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CkMachineRawDataMapping: ClassMap<CkMachineRawData>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CkMachineRawDataMapping()
		{
			this.TableName("CKMACHINERAWDATA").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.InstrumentRawDataID).ColumnName("INSTRUMENTRAWDATAID");
			  
			this.Column(p =>p.DictInstrumentID).ColumnName("DICTINSTRUMENTID");
			  
			this.Column(p =>p.RawData1).ColumnName("RAWDATA1");
			  
			this.Column(p =>p.RawData2).ColumnName("RAWDATA2");
			  
			this.Column(p =>p.RawData3).ColumnName("RAWDATA3");
			  
			this.Column(p =>p.CreateDate).ColumnName("CREATEDATE");
			  
			this.Column(p =>p.Status).ColumnName("STATUS");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

