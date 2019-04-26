

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 用血报销 - 实体类
	/// </summary>
	public partial class CkBldReimbMapping: ClassMap<CkBldReimb>
	{   
		/// <summary>
		/// 用血报销 - 实体类
		/// </summary>
		public CkBldReimbMapping()
		{
			this.TableName("CKBLDREIMB").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.BloodGroup).ColumnName("BLOODGROUP");
			  
			this.Column(p =>p.BloodTypeId).ColumnName("BLOODTYPEID");

            this.Column(p => p.RHD).ColumnName("RHD");

            this.Column(p =>p.Vollume).ColumnName("VOLLUME");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

