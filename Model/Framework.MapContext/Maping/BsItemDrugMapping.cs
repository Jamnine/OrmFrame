

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 药品项目辅助表 - 实体类
	/// </summary>
	public partial class BsItemDrugMapping: ClassMap<BsItemDrug>
	{   
		/// <summary>
		/// 药品项目辅助表 - 实体类
		/// </summary>
		public BsItemDrugMapping()
		{
			this.TableName("BSITEMDRUG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.ChemName).ColumnName("CHEMNAME");
			  
			this.Column(p =>p.IsRecipe).ColumnName("ISRECIPE");
			  
			this.Column(p =>p.IsPoison).ColumnName("ISPOISON");
			  
			this.Column(p =>p.IsMental).ColumnName("ISMENTAL");
			  
			this.Column(p =>p.IsExpen).ColumnName("ISEXPEN");
			  
			this.Column(p =>p.IsSelf).ColumnName("ISSELF");
			  
			this.Column(p =>p.ProAreaId).ColumnName("PROAREAID");
			  
			this.Column(p =>p.AheadAlert).ColumnName("AHEADALERT");
			  
			this.Column(p =>p.UnderLineKc).ColumnName("UNDERLINEKC");
			  
			this.Column(p =>p.UperLineKc).ColumnName("UPERLINEKC");
			  
			this.Column(p =>p.NormalLineKc).ColumnName("NORMALLINEKC");
			  
			this.Column(p =>p.FormId).ColumnName("FORMID");
			  
			this.Column(p =>p.ManuId).ColumnName("MANUID");
			  
			this.Column(p =>p.PassNo).ColumnName("PASSNO");
			  
			this.Column(p =>p.AreaKc).ColumnName("AREAKC");
			  
			this.Column(p =>p.LsImport).ColumnName("LSIMPORT");
			  
			this.Column(p =>p.IsInject).ColumnName("ISINJECT");
			  
			this.Column(p =>p.IsSpecial).ColumnName("ISSPECIAL");
			  
			this.Column(p =>p.HouseId).ColumnName("HOUSEID");
			  
			this.Column(p =>p.RoomIdOut).ColumnName("ROOMIDOUT");
			  
			this.Column(p =>p.RoomIdIn).ColumnName("ROOMIDIN");
			  
			this.Column(p =>p.UnitKc).ColumnName("UNITKC");
			  
			this.Column(p =>p.RetailPriceKc).ColumnName("RETAILPRICEKC");
			  
			this.Column(p =>p.StockPriceKc).ColumnName("STOCKPRICEKC");
			  
			this.Column(p =>p.IsBid).ColumnName("ISBID");
			  
			this.Column(p =>p.IsLocDrug).ColumnName("ISLOCDRUG");
			  
			this.Column(p =>p.CompId).ColumnName("COMPID");
			  
			this.Column(p =>p.IsBatch).ColumnName("ISBATCH");
			  
			this.Column(p =>p.IsSave).ColumnName("ISSAVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.DrugID).ColumnName("DRUGID");
			  
			this.Column(p =>p.BuyInCode).ColumnName("BUYINCODE");
			  
			this.Column(p =>p.IsSecMental).ColumnName("ISSECMENTAL");
			  
			this.Column(p =>p.IsSkin).ColumnName("ISSKIN");
			  
			this.Column(p =>p.IsAntiBacterial).ColumnName("ISANTIBACTERIAL");
			  
			this.Column(p =>p.IsHighDanger).ColumnName("ISHIGHDANGER");
			  
			this.Column(p =>p.IsDanger).ColumnName("ISDANGER");
			  
			this.Column(p =>p.IsVaccine).ColumnName("ISVACCINE");
			  
			this.Column(p =>p.IsTestReport).ColumnName("ISTESTREPORT");
			  
			this.Column(p =>p.IsAnaes).ColumnName("ISANAES");
			  
			this.Column(p =>p.IsMeetingUse).ColumnName("ISMEETINGUSE");
			  
			this.Column(p =>p.RegNo).ColumnName("REGNO");
			  
			this.Column(p =>p.ImpotTestBy).ColumnName("IMPOTTESTBY");
			  
			this.Column(p =>p.TestReportNo).ColumnName("TESTREPORTNO");
			  
			this.Column(p =>p.IsParity).ColumnName("ISPARITY");
			  
			this.Column(p =>p.DDDMinValue).ColumnName("DDDMINVALUE");
			  
			this.Column(p =>p.DDDValue).ColumnName("DDDVALUE");
			  
			this.Column(p =>p.DrugsTypes).ColumnName("DRUGSTYPES");
			  
			this.Column(p =>p.NotXZjDrug).ColumnName("NOTXZJDRUG");
			  
			this.Column(p =>p.XZjDrug).ColumnName("XZJDRUG");
			  
			this.Column(p =>p.TSjDrug).ColumnName("TSJDRUG");
			  
			this.Column(p =>p.IsAz).ColumnName("ISAZ");
			  
			this.Column(p =>p.IsJH).ColumnName("ISJH");
			  
			this.Column(p =>p.Vaccine).ColumnName("VACCINE");
			  
			this.Column(p =>p.BwCode).ColumnName("BWCODE");
			  
			this.Column(p =>p.HospitalID).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

