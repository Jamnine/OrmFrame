

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class BsModalityStationMapping: ClassMap<BsModalityStation>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public BsModalityStationMapping()
		{
			this.TableName("BSMODALITYSTATION").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.StationName).ColumnName("STATIONNAME");
			  
			this.Column(p =>p.Modality).ColumnName("MODALITY");
			  
			this.Column(p =>p.AETitle).ColumnName("AETITLE");
			  
			this.Column(p =>p.IPAddress).ColumnName("IPADDRESS");
			  
			this.Column(p =>p.DicomPort).ColumnName("DICOMPORT");
			  
			this.Column(p =>p.ServerImagePath).ColumnName("SERVERIMAGEPATH");
			  
			this.Column(p =>p.ClientImgPath).ColumnName("CLIENTIMGPATH");
			  
			this.Column(p =>p.ClientVideoPath).ColumnName("CLIENTVIDEOPATH");
			  
			this.Column(p =>p.IsEquipment).ColumnName("ISEQUIPMENT");
			  
			this.Column(p =>p.IsGate).ColumnName("ISGATE");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

