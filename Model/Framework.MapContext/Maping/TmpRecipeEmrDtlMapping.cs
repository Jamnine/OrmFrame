

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:处方模板维护表明细 - 实体类
	/// </summary>
	public partial class TmpRecipeEmrDtlMapping: ClassMap<TmpRecipeEmrDtl>
	{   
		/// <summary>
		/// 行心云:处方模板维护表明细 - 实体类
		/// </summary>
		public TmpRecipeEmrDtlMapping()
		{
			this.TableName("TMPRECIPEEMRDTL").Schema("orm");

            this.Column(p =>p.GUID).ColumnName("GUID");

            this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.ItemID).ColumnName("ITEMID");
			  
			this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.Dosage).ColumnName("DOSAGE");
			  
			this.Column(p =>p.FrequencyID).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.Spec).ColumnName("SPEC");
			  
			this.Column(p =>p.UsageID).ColumnName("USAGEID");
			  
			this.Column(p =>p.UnitTakeID).ColumnName("UNITTAKEID");
			  
			this.Column(p =>p.CookType).ColumnName("COOKTYPE");
			  
			this.Column(p =>p.TmpRecipeEmrID).ColumnName("TMPRECIPEEMRID");
			  
			this.Column(p =>p.PriceDiag).ColumnName("PRICEDIAG");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.Days).ColumnName("DAYS");
			  
			this.Column(p =>p.UnitDiagID).ColumnName("UNITDIAGID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");


            this.Id(t => t.GUID);
            this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

