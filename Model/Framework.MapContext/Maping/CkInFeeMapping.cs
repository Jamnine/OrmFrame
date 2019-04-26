

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检对应费用 - 实体类
	/// </summary>
	public partial class CkInFeeMapping: ClassMap<CkInFee>
	{   
		/// <summary>
		/// 体检对应费用 - 实体类
		/// </summary>
		public CkInFeeMapping()
		{
			this.TableName("CKINFEE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.LabId).ColumnName("LABID");
			  
			this.Column(p =>p.DetailId).ColumnName("DETAILID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

