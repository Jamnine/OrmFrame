

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊收费发票医保信息 - 实体类
	/// </summary>
	public partial class OuInvoYbMapping: ClassMap<OuInvoYb>
	{   
		/// <summary>
		/// 门诊收费发票医保信息 - 实体类
		/// </summary>
		public OuInvoYbMapping()
		{
			this.TableName("OUINVOYB").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.invoid).ColumnName("INVOID");
			  
			this.Column(p =>p.Factyp).ColumnName("FACTYP");
			  
			this.Column(p =>p.Factjz).ColumnName("FACTJZ");
			  
			this.Column(p =>p.AllFactyp).ColumnName("ALLFACTYP");
			  
			this.Column(p =>p.Allfactjz).ColumnName("ALLFACTJZ");
			  
			this.Column(p =>p.OtherFact).ColumnName("OTHERFACT");
			  
			this.Column(p =>p.ybdisc).ColumnName("YBDISC");
			  
			this.Column(p =>p.Insurance).ColumnName("INSURANCE");
			  
			this.Column(p =>p.Underline).ColumnName("UNDERLINE");
			  
			this.Column(p =>p.Insuranceb1).ColumnName("INSURANCEB1");
			  
			this.Column(p =>p.Insuranceb2).ColumnName("INSURANCEB2");
			  
			this.Column(p =>p.Insuranceb3).ColumnName("INSURANCEB3");
			  
			this.Column(p =>p.payself).ColumnName("PAYSELF");
			  
			this.Column(p =>p.selfpaydisc).ColumnName("SELFPAYDISC");
			  
			this.Column(p =>p.Selfpayb1).ColumnName("SELFPAYB1");
			  
			this.Column(p =>p.Selfpayb2).ColumnName("SELFPAYB2");
			  
			this.Column(p =>p.Selfpayb3).ColumnName("SELFPAYB3");
			  
			this.Column(p =>p.Outtopselffee).ColumnName("OUTTOPSELFFEE");
			  
			this.Column(p =>p.Selffee).ColumnName("SELFFEE");
			  
			this.Column(p =>p.AccountAttribute).ColumnName("ACCOUNTATTRIBUTE");
			  
			this.Column(p =>p.BchzylbxAmount).ColumnName("BCHZYLBXAMOUNT");
			  
			this.Column(p =>p.bcproportion).ColumnName("BCPROPORTION");
			  
			this.Column(p =>p.Fdamount).ColumnName("FDAMOUNT");
			  
			this.Column(p =>p.Kbca1).ColumnName("KBCA1");
			  
			this.Column(p =>p.Kbca12).ColumnName("KBCA12");
			  
			this.Column(p =>p.Kbca13).ColumnName("KBCA13");
			  
			this.Column(p =>p.Kbca16).ColumnName("KBCA16");
			  
			this.Column(p =>p.Kbca17).ColumnName("KBCA17");
			  
			this.Column(p =>p.Kbca18).ColumnName("KBCA18");
			  
			this.Column(p =>p.Kbca19).ColumnName("KBCA19");
			  
			this.Column(p =>p.Kbca2).ColumnName("KBCA2");
			  
			this.Column(p =>p.Kbca20).ColumnName("KBCA20");
			  
			this.Column(p =>p.Kbca3).ColumnName("KBCA3");
			  
			this.Column(p =>p.Kbca4).ColumnName("KBCA4");
			  
			this.Column(p =>p.Kbca5).ColumnName("KBCA5");
			  
			this.Column(p =>p.Kbca6).ColumnName("KBCA6");
			  
			this.Column(p =>p.Kbcamount).ColumnName("KBCAMOUNT");
			  
			this.Column(p =>p.MedicalNo).ColumnName("MEDICALNO");
			  
			this.Column(p =>p.ndybcamount).ColumnName("NDYBCAMOUNT");
			  
			this.Column(p =>p.OrigiNala1).ColumnName("ORIGINALA1");
			  
			this.Column(p =>p.OrigiNala12).ColumnName("ORIGINALA12");
			  
			this.Column(p =>p.Originala13).ColumnName("ORIGINALA13");
			  
			this.Column(p =>p.Originala16).ColumnName("ORIGINALA16");
			  
			this.Column(p =>p.Originala17).ColumnName("ORIGINALA17");
			  
			this.Column(p =>p.OrigiNala18).ColumnName("ORIGINALA18");
			  
			this.Column(p =>p.Originala19).ColumnName("ORIGINALA19");
			  
			this.Column(p =>p.OrigiNala2).ColumnName("ORIGINALA2");
			  
			this.Column(p =>p.OrigiNala20).ColumnName("ORIGINALA20");
			  
			this.Column(p =>p.Originala3).ColumnName("ORIGINALA3");
			  
			this.Column(p =>p.OrigiNala4).ColumnName("ORIGINALA4");
			  
			this.Column(p =>p.Originala5).ColumnName("ORIGINALA5");
			  
			this.Column(p =>p.Originala6).ColumnName("ORIGINALA6");
			  
			this.Column(p =>p.Originalamount).ColumnName("ORIGINALAMOUNT");
			  
			this.Column(p =>p.Sjbca1).ColumnName("SJBCA1");
			  
			this.Column(p =>p.Sjbca12).ColumnName("SJBCA12");
			  
			this.Column(p =>p.Sjbca13).ColumnName("SJBCA13");
			  
			this.Column(p =>p.Sjbca16).ColumnName("SJBCA16");
			  
			this.Column(p =>p.Sjbca17).ColumnName("SJBCA17");
			  
			this.Column(p =>p.Sjbca18).ColumnName("SJBCA18");
			  
			this.Column(p =>p.sjbca19).ColumnName("SJBCA19");
			  
			this.Column(p =>p.Sjbca2).ColumnName("SJBCA2");
			  
			this.Column(p =>p.Sjbca20).ColumnName("SJBCA20");
			  
			this.Column(p =>p.Sjbca3).ColumnName("SJBCA3");
			  
			this.Column(p =>p.Sjbca4).ColumnName("SJBCA4");
			  
			this.Column(p =>p.Sjbca5).ColumnName("SJBCA5");
			  
			this.Column(p =>p.Sjbca6).ColumnName("SJBCA6");
			  
			this.Column(p =>p.Tgproportion).ColumnName("TGPROPORTION");
			  
			this.Column(p =>p.Wbhproportion).ColumnName("WBHPROPORTION");
			  
			this.Column(p =>p.Zyyproportion).ColumnName("ZYYPROPORTION");
			  
			this.Column(p =>p.ZzproPortion).ColumnName("ZZPROPORTION");
			  
			this.Column(p =>p.MzRegID).ColumnName("MZREGID");
			  
			this.Column(p =>p.YbPatType).ColumnName("YBPATTYPE");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.NTime).ColumnName("NTIME");
			  
			this.Column(p =>p.BalaNo).ColumnName("BALANO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

