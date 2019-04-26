

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgIllCureMapping: ClassMap<DgIllCure>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgIllCureMapping()
		{
			this.TableName("DGILLCURE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.IllId).ColumnName("ILLID");
			  
			this.Column(p =>p.IllGroupId).ColumnName("ILLGROUPID");
			  
			this.Column(p =>p.CureId).ColumnName("CUREID");
			  
			this.Column(p =>p.DrugId).ColumnName("DRUGID");
			  
			this.Column(p =>p.CheckId).ColumnName("CHECKID");
			  
			this.Column(p =>p.NurseId).ColumnName("NURSEID");
			  
			this.Column(p =>p.LsAdvType).ColumnName("LSADVTYPE");
			  
			this.Column(p =>p.LsCureType).ColumnName("LSCURETYPE");
			  
			this.Column(p =>p.IsBaby).ColumnName("ISBABY");
			  
			this.Column(p =>p.IsWomen).ColumnName("ISWOMEN");
			  
			this.Column(p =>p.IsMen).ColumnName("ISMEN");
			  
			this.Column(p =>p.IsOlder).ColumnName("ISOLDER");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.DosAge).ColumnName("DOSAGE");
			  
			this.Column(p =>p.UnitTakeId).ColumnName("UNITTAKEID");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.Days).ColumnName("DAYS");
			  
			this.Column(p =>p.FeeTotality).ColumnName("FEETOTALITY");
			  
			this.Column(p =>p.UnitId).ColumnName("UNITID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

