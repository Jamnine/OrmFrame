

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class PsDrugActionMapping: ClassMap<PsDrugAction>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public PsDrugActionMapping()
		{
			this.TableName("PSDRUGACTION").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.ApplyNo).ColumnName("APPLYNO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.IsCancel).ColumnName("ISCANCEL");
			  
			this.Column(p =>p.CancelTime).ColumnName("CANCELTIME");
			  
			this.Column(p =>p.CancelOperId).ColumnName("CANCELOPERID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.ReactTime).ColumnName("REACTTIME");
			  
			this.Column(p =>p.LsTransType).ColumnName("LSTRANSTYPE");
			  
			this.Column(p =>p.ClincHandle).ColumnName("CLINCHANDLE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

