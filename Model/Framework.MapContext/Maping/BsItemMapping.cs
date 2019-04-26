

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 收费项目表 - 实体类
	/// </summary>
	public partial class BsItemMapping: ClassMap<BsItem>
	{   
		/// <summary>
		/// 收费项目表 - 实体类
		/// </summary>
		public BsItemMapping()
		{
			this.TableName("BSITEM").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LsGroupType).ColumnName("LSGROUPTYPE");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.StrokeCode).ColumnName("STROKECODE");
			  
			this.Column(p =>p.OtherCode).ColumnName("OTHERCODE");
			  
			this.Column(p =>p.GroupMainId).ColumnName("GROUPMAINID");
			  
			this.Column(p =>p.GroupSubId).ColumnName("GROUPSUBID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.LongDesc).ColumnName("LONGDESC");
			  
			this.Column(p =>p.EngDesc).ColumnName("ENGDESC");
			  
			this.Column(p =>p.Spec).ColumnName("SPEC");
			  
			this.Column(p =>p.UnitInId).ColumnName("UNITINID");
			  
			this.Column(p =>p.PriceIn).ColumnName("PRICEIN");
			  
			this.Column(p =>p.UnitDiagId).ColumnName("UNITDIAGID");
			  
			this.Column(p =>p.PriceDiag).ColumnName("PRICEDIAG");
			  
			this.Column(p =>p.AddPercent).ColumnName("ADDPERCENT");
			  
			this.Column(p =>p.LsRpType).ColumnName("LSRPTYPE");
			  
			this.Column(p =>p.Dosage).ColumnName("DOSAGE");
			  
			this.Column(p =>p.UnitTakeId).ColumnName("UNITTAKEID");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.FeeMzId).ColumnName("FEEMZID");
			  
			this.Column(p =>p.FeeZyId).ColumnName("FEEZYID");
			  
			this.Column(p =>p.LsGfType).ColumnName("LSGFTYPE");
			  
			this.Column(p =>p.GfFixDisc).ColumnName("GFFIXDISC");
			  
			this.Column(p =>p.OptionPrice).ColumnName("OPTIONPRICE");
			  
			this.Column(p =>p.LimitTotalMz).ColumnName("LIMITTOTALMZ");
			  
			this.Column(p =>p.LimitTotalZy).ColumnName("LIMITTOTALZY");
			  
			this.Column(p =>p.TypeGFXEId).ColumnName("TYPEGFXEID");
			  
			this.Column(p =>p.IsSpecSum).ColumnName("ISSPECSUM");
			  
			this.Column(p =>p.IsNew).ColumnName("ISNEW");
			  
			this.Column(p =>p.IsOnlyForSys).ColumnName("ISONLYFORSYS");
			  
			this.Column(p =>p.IsRpForbid).ColumnName("ISRPFORBID");
			  
			this.Column(p =>p.IsChildAdd).ColumnName("ISCHILDADD");
			  
			this.Column(p =>p.IsBedFee).ColumnName("ISBEDFEE");
			  
			this.Column(p =>p.IsOpsAdd).ColumnName("ISOPSADD");
			  
			this.Column(p =>p.LsfeeTurn).ColumnName("LSFEETURN");
			  
			this.Column(p =>p.LsAdviceType).ColumnName("LSADVICETYPE");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.LISCode).ColumnName("LISCODE");
			  
			this.Column(p =>p.CoverPicture).ColumnName("COVERPICTURE");
			  
			this.Column(p =>p.MemoPicture).ColumnName("MEMOPICTURE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.IsInoculate).ColumnName("ISINOCULATE");
			  
			this.Column(p =>p.PriceHighLine).ColumnName("PRICEHIGHLINE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.GroupSubId2).ColumnName("GROUPSUBID2");
			  
			this.Column(p =>p.LastTime).ColumnName("LASTTIME");
			  
			this.Column(p =>p.PriceSub).ColumnName("PRICESUB");
			  
			this.Column(p =>p.CheckId).ColumnName("CHECKID");
			  
			this.Column(p =>p.NurseId).ColumnName("NURSEID");
			  
			this.Column(p =>p.CureId).ColumnName("CUREID");
			  
			this.Column(p =>p.DrugID).ColumnName("DRUGID");
			  
			this.Column(p =>p.CopyId).ColumnName("COPYID");
			  
			this.Column(p =>p.MzUnitTotal).ColumnName("MZUNITTOTAL");
			  
			this.Column(p =>p.ZyUnitTotal).ColumnName("ZYUNITTOTAL");
			  
			this.Column(p =>p.IsMtDrug).ColumnName("ISMTDRUG");
			  
			this.Column(p =>p.PackageSpec).ColumnName("PACKAGESPEC");
			  
			this.Column(p =>p.IsCitySum).ColumnName("ISCITYSUM");
			  
			this.Column(p =>p.YBAvgPrice).ColumnName("YBAVGPRICE");
			  
			this.Column(p =>p.ProvinceCode).ColumnName("PROVINCECODE");
			  
			this.Column(p =>p.OperName).ColumnName("OPERNAME");
			  
			this.Column(p =>p.IsFirstRecommend).ColumnName("ISFIRSTRECOMMEND");
			  
			this.Column(p =>p.DrugEfficacy).ColumnName("DRUGEFFICACY");
			  
			this.Column(p =>p.DrugInstruction).ColumnName("DRUGINSTRUCTION");
			  
			this.Column(p =>p.DrugTaboos).ColumnName("DRUGTABOOS");
			  
			this.Column(p =>p.CommonNameId).ColumnName("COMMONNAMEID");
			  
			this.Column(p =>p.CommonName).ColumnName("COMMONNAME");
			  
			this.Column(p =>p.Duration).ColumnName("DURATION");
			  
			this.Column(p =>p.VipPrice).ColumnName("VIPPRICE");
			  
			this.Column(p =>p.TermYear).ColumnName("TERMYEAR");
			  
			this.Column(p =>p.TermMonth).ColumnName("TERMMONTH");
			  
			this.Column(p =>p.IsDiscounts).ColumnName("ISDISCOUNTS");
			  
			this.Column(p =>p.TjLocationId).ColumnName("TJLOCATIONID");
			  
			this.Column(p =>p.IsPrintName).ColumnName("IsPrintName");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.SamlingType).ColumnName("SAMLINGTYPE");
            this.Column(p => p.ManuId).ColumnName("MANUID");
            this.Column(p => p.InsertTime).ColumnName("INSERTTIME");
            this.Column(p => p.HisType).ColumnName("HISTYPE");

            this.Column(p => p.FeeMzIdCode).ColumnName("FEEMZIDCODE");
            this.Column(p => p.BusinessCity).ColumnName("BSBUSINESSCITYTYPEID");
            this.Column(p => p.OperId).ColumnName("OperId");
            this.Column(p => p.AKA185).ColumnName("AKA185");
            this.Column(p => p.IsReimbursement).ColumnName("ISREIMBURSEMENT");
            this.Column(p => p.CkItemType).ColumnName("CKITEMTYPE");                                                                  
            this.Column(p => p.IsYBItems).ColumnName("ISYBITEMS");
            this.Column(p => p.IsIndustries).ColumnName("ISINDUSTRIES");
            //this.Id(T => T.GUID).DbGenerated();  
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

