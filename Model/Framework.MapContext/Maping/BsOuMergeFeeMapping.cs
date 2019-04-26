

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class BsOuMergeFeeMapping: ClassMap<BsOuMergeFee>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public BsOuMergeFeeMapping()
		{
			this.TableName("BSOUMERGEFEE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.PatTypeId).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.ItemId1).ColumnName("ITEMID1");
			  
			this.Column(p =>p.ItemId2).ColumnName("ITEMID2");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

