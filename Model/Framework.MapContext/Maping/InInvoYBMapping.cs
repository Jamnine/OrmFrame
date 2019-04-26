

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院发票医保信息表 - 实体类
	/// </summary>
	public partial class InInvoYBMapping: ClassMap<InInvoYB>
	{   
		/// <summary>
		/// 住院发票医保信息表 - 实体类
		/// </summary>
		public InInvoYBMapping()
		{
			this.TableName("ININVOYB").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.InvoId).ColumnName("INVOID");
			  
			this.Column(p =>p.FactYP).ColumnName("FACTYP");
			  
			this.Column(p =>p.FactJZ).ColumnName("FACTJZ");
			  
			this.Column(p =>p.AllFactYP).ColumnName("ALLFACTYP");
			  
			this.Column(p =>p.AllFactJZ).ColumnName("ALLFACTJZ");
			  
			this.Column(p =>p.OtherFact).ColumnName("OTHERFACT");
			  
			this.Column(p =>p.YBDisc).ColumnName("YBDISC");
			  
			this.Column(p =>p.Insurance).ColumnName("INSURANCE");
			  
			this.Column(p =>p.UnderLine).ColumnName("UNDERLINE");
			  
			this.Column(p =>p.InsuranceB1).ColumnName("INSURANCEB1");
			  
			this.Column(p =>p.InsuranceB2).ColumnName("INSURANCEB2");
			  
			this.Column(p =>p.InsuranceB3).ColumnName("INSURANCEB3");
			  
			this.Column(p =>p.PaySelf).ColumnName("PAYSELF");
			  
			this.Column(p =>p.SelfPayDisc).ColumnName("SELFPAYDISC");
			  
			this.Column(p =>p.SelfPayB1).ColumnName("SELFPAYB1");
			  
			this.Column(p =>p.SelfPayB2).ColumnName("SELFPAYB2");
			  
			this.Column(p =>p.SelfPayB3).ColumnName("SELFPAYB3");
			  
			this.Column(p =>p.OutTopSelfFee).ColumnName("OUTTOPSELFFEE");
			  
			this.Column(p =>p.SelfFee).ColumnName("SELFFEE");
			  
			this.Column(p =>p.BchzylbxAmount).ColumnName("BCHZYLBXAMOUNT");
			  
			this.Column(p =>p.AccountAttribute).ColumnName("ACCOUNTATTRIBUTE");
			  
			this.Column(p =>p.BcProportion).ColumnName("BCPROPORTION");
			  
			this.Column(p =>p.FdAmount).ColumnName("FDAMOUNT");
			  
			this.Column(p =>p.MedicalNo).ColumnName("MEDICALNO");
			  
			this.Column(p =>p.NdybcAmount).ColumnName("NDYBCAMOUNT");
			  
			this.Column(p =>p.TgProportion).ColumnName("TGPROPORTION");
			  
			this.Column(p =>p.WbhProportion).ColumnName("WBHPROPORTION");
			  
			this.Column(p =>p.ZyyProportion).ColumnName("ZYYPROPORTION");
			  
			this.Column(p =>p.ZzProportion).ColumnName("ZZPROPORTION");
			  
			this.Column(p =>p.KbcAmount).ColumnName("KBCAMOUNT");
			  
			this.Column(p =>p.KbcA1).ColumnName("KBCA1");
			  
			this.Column(p =>p.KbcA2).ColumnName("KBCA2");
			  
			this.Column(p =>p.KbcA3).ColumnName("KBCA3");
			  
			this.Column(p =>p.KbcA4).ColumnName("KBCA4");
			  
			this.Column(p =>p.KbcA5).ColumnName("KBCA5");
			  
			this.Column(p =>p.KbcA6).ColumnName("KBCA6");
			  
			this.Column(p =>p.KbcA12).ColumnName("KBCA12");
			  
			this.Column(p =>p.KbcA13).ColumnName("KBCA13");
			  
			this.Column(p =>p.KbcA16).ColumnName("KBCA16");
			  
			this.Column(p =>p.KbcA17).ColumnName("KBCA17");
			  
			this.Column(p =>p.KbcA18).ColumnName("KBCA18");
			  
			this.Column(p =>p.KbcA19).ColumnName("KBCA19");
			  
			this.Column(p =>p.KbcA20).ColumnName("KBCA20");
			  
			this.Column(p =>p.SjbcA1).ColumnName("SJBCA1");
			  
			this.Column(p =>p.SjbcA2).ColumnName("SJBCA2");
			  
			this.Column(p =>p.SjbcA3).ColumnName("SJBCA3");
			  
			this.Column(p =>p.SjbcA4).ColumnName("SJBCA4");
			  
			this.Column(p =>p.SjbcA5).ColumnName("SJBCA5");
			  
			this.Column(p =>p.SjbcA6).ColumnName("SJBCA6");
			  
			this.Column(p =>p.SjbcA12).ColumnName("SJBCA12");
			  
			this.Column(p =>p.SjbcA13).ColumnName("SJBCA13");
			  
			this.Column(p =>p.SjbcA16).ColumnName("SJBCA16");
			  
			this.Column(p =>p.SjbcA17).ColumnName("SJBCA17");
			  
			this.Column(p =>p.SjbcA18).ColumnName("SJBCA18");
			  
			this.Column(p =>p.SjbcA19).ColumnName("SJBCA19");
			  
			this.Column(p =>p.SjbcA20).ColumnName("SJBCA20");
			  
			this.Column(p =>p.OriginalAmount).ColumnName("ORIGINALAMOUNT");
			  
			this.Column(p =>p.OriginalA1).ColumnName("ORIGINALA1");
			  
			this.Column(p =>p.OriginalA2).ColumnName("ORIGINALA2");
			  
			this.Column(p =>p.OriginalA3).ColumnName("ORIGINALA3");
			  
			this.Column(p =>p.OriginalA4).ColumnName("ORIGINALA4");
			  
			this.Column(p =>p.OriginalA5).ColumnName("ORIGINALA5");
			  
			this.Column(p =>p.OriginalA6).ColumnName("ORIGINALA6");
			  
			this.Column(p =>p.OriginalA12).ColumnName("ORIGINALA12");
			  
			this.Column(p =>p.OriginalA13).ColumnName("ORIGINALA13");
			  
			this.Column(p =>p.OriginalA16).ColumnName("ORIGINALA16");
			  
			this.Column(p =>p.OriginalA17).ColumnName("ORIGINALA17");
			  
			this.Column(p =>p.OriginalA18).ColumnName("ORIGINALA18");
			  
			this.Column(p =>p.OriginalA19).ColumnName("ORIGINALA19");
			  
			this.Column(p =>p.OriginalA20).ColumnName("ORIGINALA20");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.InvoYBTime).ColumnName("INVOYBTIME");
			  
			this.Column(p =>p.YbPatType).ColumnName("YBPATTYPE");
			  
			this.Column(p =>p.NTime).ColumnName("NTIME");
			  
			this.Column(p =>p.BalaNo).ColumnName("BALANO");
			  
			this.Column(p =>p.InsuranceType).ColumnName("INSURANCETYPE");
			  
			this.Column(p =>p.Remark).ColumnName("REMARK");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalID).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

