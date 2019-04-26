using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 
    /// </summary>
   public class UspIninvoicedtlCache:BaseModel
    {
        ///<summary>
        ///
        ///</summary>
        public string Patname { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Inpatno { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Agestr { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Sex { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string HISTYPE { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string INSERTTIME { set; get; }


        ///<summary>
        ///
        ///</summary>
        public DateTime REGOPERTIME { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string LSMARKTYPE { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double TOTALITY { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double PRICEIN { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool ISPAY { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double DISCIN { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double DISCSELF { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double AMOUNT { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double AMOUNTFACT { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double AMOUNTSELF { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double AMOUNTTALLY { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double AMOUNTPAY { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string LSPERFORM { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool ISMODIDISC { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double LIMITFEE { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int LSREPORTTYPE { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string MEMO { set; get; }


        ///<summary>
        ///
        ///</summary>
        public DateTime OPERTIME { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool ISCANCEL { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool ISMANUAL { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string HOSTNAME { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string REGDATE { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string ADVICENAME { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string URGENT { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string RESERVEDFIELD { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string RESERVEDFIELD2 { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double PRICEIN1 { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double PRICEIN2 { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int LSPRICESTATE { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool ISYBXJ { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string USAGEMEMO { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool ISAUTOCHARGED { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool ISYBCHARGED { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string NOTAUTHMEMO { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string BACKMEMO { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string FREQUENCYID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string FORMID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string FEEHSID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string FEEID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string INVITEMID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string EXECLOCID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string LIMITGROUPID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string INVOID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string UNITID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int USAGEID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string HOSPID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string ITEMID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string REGOPERID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string LOCATIONID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string ADVICEID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string DOCTORID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string EXECOPERID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string OPERID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string CANCELID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string EXECUTEID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string GROUPITEMID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string XDRPID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string MAINDOCTORID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string OUINVOID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string DOCLOCID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string EXECDOCTORID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double CHILDPRICE { set; get; }


        ///<summary>
        ///
        ///</summary>
        public double DISCOUNTPRICE { set; get; }


        ///<summary>
        ///
        ///</summary>
        public bool ISAUTHED { set; get; }


        ///<summary>
        ///
        ///</summary>
        public int HOSPITALID { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Hospital { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Frequency { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Drugform { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string HSname { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Feety { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Invitem { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Execeloc { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Limitgroup { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Invono { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string unit { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Iusage { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Itemcode { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Itemname { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Regoper { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Locname { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Docname { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Opername { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Execoper { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Maindoc { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Ouvono { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Docloc { set; get; }


        ///<summary>
        ///
        ///</summary>
        public string Execdoc { set; get; }
    }
}
