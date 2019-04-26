

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CkMachineqcLotMapping: ClassMap<CkMachineqcLot>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CkMachineqcLotMapping()
		{
			this.TableName("CKMACHINEQCLOT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.DictqcLotid).ColumnName("DICTQCLOTID");
			  
			this.Column(p =>p.LotNum).ColumnName("LOTNUM");
			  
			this.Column(p =>p.DictqcControlid).ColumnName("DICTQCCONTROLID");
			  
			this.Column(p =>p.QcBarcode).ColumnName("QCBARCODE");
			  
			this.Column(p =>p.ActiveDate).ColumnName("ACTIVEDATE");
			  
			this.Column(p =>p.ExpiryDate).ColumnName("EXPIRYDATE");
			  
			this.Column(p =>p.DictManufactureid).ColumnName("DICTMANUFACTUREID");
			  
			this.Column(p =>p.OperateBy).ColumnName("OPERATEBY");
			  
			this.Column(p =>p.CreateDate).ColumnName("CREATEDATE");
			  
			this.Column(p =>p.DictInstrumentID).ColumnName("DICTINSTRUMENTID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

