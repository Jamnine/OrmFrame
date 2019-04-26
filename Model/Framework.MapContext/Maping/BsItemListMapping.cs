

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class BsItemListMapping: ClassMap<BsItemList>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public BsItemListMapping()
		{
			this.TableName("BSITEMLIST").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.IllId).ColumnName("ILLID");
			  
			this.Column(p =>p.IllName).ColumnName("ILLNAME");
			  
			this.Column(p =>p.GroupId).ColumnName("GROUPID");
			  
			this.Column(p =>p.PatientGroup).ColumnName("PATIENTGROUP");
			  
			this.Column(p =>p.UnDrugId).ColumnName("UNDRUGID");
			  
			this.Column(p =>p.UnDrugName).ColumnName("UNDRUGNAME");
			  
			this.Column(p =>p.TypeCode).ColumnName("TYPECODE");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.ItemName).ColumnName("ITEMNAME");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.UnitName).ColumnName("UNITNAME");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.UsageName).ColumnName("USAGENAME");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.FrequencyName).ColumnName("FREQUENCYNAME");
			  
			this.Column(p =>p.Quantity).ColumnName("QUANTITY");
			  
			this.Column(p =>p.RelationCode).ColumnName("RELATIONCODE");
			  
			this.Column(p =>p.WayCode).ColumnName("WAYCODE");
			  
			this.Column(p =>p.Remark).ColumnName("REMARK");
			  
			this.Column(p =>p.ImpTime).ColumnName("IMPTIME");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

