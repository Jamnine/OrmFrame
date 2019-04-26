using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    [Serializable]
    public class UspInInvoiceDtlChkByHospId : BaseModel
    {
        public virtual Int32 id { get; set; }

        public virtual string hospid { get; set; }


        //[DataMember(Order = 3, IsRequired = false)]
        public virtual string itemid { get; set; }

        public virtual DateTime regopertime { get; set; }

        public virtual string regoperid { get; set; }

        public virtual string locationid { get; set; }

        public virtual string adviceid { get; set; }

        public virtual Int32 lsmarktype { get; set; }


        //[DataMember(Order = 9, IsRequired = false)]
        public virtual double totality { get; set; }


        //[DataMember(Order = 10, IsRequired = false)]
        public virtual double pricein { get; set; }

        //[DataMember(Order = 10, IsRequired = false)]



        public virtual Int32 unitid { get; set; }

        public virtual Boolean ispay { get; set; }


        //[DataMember(Order = 13, IsRequired = false)]
        public virtual double discin { get; set; }


        //[DataMember(Order = 14, IsRequired = false)]
        public virtual double discself { get; set; }


        //[DataMember(Order = 15, IsRequired = false)]
        public virtual double amount { get; set; }



        public virtual double amountfact { get; set; }


        //[DataMember(Order = 17, IsRequired = false)]

        //[DataMember(Order = 18, IsRequired = false)]
        public virtual double amounttally { get; set; }



        //[DataMember(Order = 19, IsRequired = false)]
        public virtual double amountpay { get; set; }



        public virtual string invoid { get; set; }

        public virtual Int32 lsperform { get; set; }


        //[DataMember(Order = 22, IsRequired = false)]
        public virtual Boolean ismodidisc { get; set; }



        public virtual string limitgroupid { get; set; }


        //[DataMember(Order = 24, IsRequired = false)]
        public virtual double limitfee { get; set; }


        public virtual string doctorid { get; set; }

        public virtual string execoperid { get; set; }

        public virtual string execlocid { get; set; }

        public virtual string invitemid { get; set; }

        public virtual string feeid { get; set; }

        public virtual string feehsid { get; set; }

        public virtual Int32 lsreporttype { get; set; }

        public virtual String memo { get; set; }

        public virtual DateTime opertime { get; set; }

        public virtual string operid { get; set; }

        public virtual Boolean iscancel { get; set; }

        public virtual string cancelid { get; set; }

        public virtual Boolean ismanual { get; set; }

        public virtual String UsageMemo { get; set; }

        public virtual string UsageId { get; set; }

        public virtual string FormId { get; set; }

        public virtual string FrequencyId { get; set; }

        public virtual String hostname { get; set; }

        public virtual string executeid { get; set; }

        public virtual String regdate { get; set; }

        public virtual string groupitemid { get; set; }

        public virtual string xdrpid { get; set; }

        public virtual String advicename { get; set; }

        public virtual Int32 maindoctorid { get; set; }

        public virtual String ybcode { get; set; }

        public virtual Int32 lsinout { get; set; }

        public virtual string inouinvoicedtlid { get; set; }

        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual String Code { get; set; }

        public virtual Boolean IsBedFee { get; set; }

        public virtual DateTime regOperDate { get; set; }

        public virtual Int32 LsGfType { get; set; }

        public virtual String BsInvInItemName { get; set; }
        
        public virtual String BsZyFeetyName { get; set; }

        public virtual String IsYbCharged { get; set; }

        public virtual String NotAuthMemo { get; set; }

        public virtual String BackMemo { get; set; }

        public virtual string Ouinvoid { get; set; }

        public virtual Int32 IsCheck { get; set; }
    }
}
