using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspRmAppDrugDtl
    {
        //[DataMember(Order = 10)]
        public virtual string GUID { get; set; }

        //[DataMember(Order = 11)]
        public virtual string ItemId { get; set; }

        //[DataMember(Order = 12)]
        public virtual double DrugNum { get; set; }

        //[DataMember(Order = 13)]
        public virtual string UnitId { get; set; }

        //[DataMember(Order = 14)]
        public virtual string BillId { get; set; }

        //[DataMember(Order = 15)]
        public virtual string BillNo { get; set; }

        //[DataMember(Order = 16)]
        public virtual string HouseId { get; set; }

        //[DataMember(Order = 17)]
        public virtual string RoomId { get; set; }

        //[DataMember(Order = 18)]
        public virtual DateTime OperTime { get; set; }

        //[DataMember(Order = 19)]
        public virtual string OperId { get; set; }

        //[DataMember(Order = 20)]
        public virtual bool IsAffirm { get; set; }

        //[DataMember(Order = 21)]
        public virtual DateTime AffirmTime { get; set; }

        //[DataMember(Order = 22)]
        public virtual string AffirmOperid { get; set; }

        //[DataMember(Order = 23)]
        public virtual string ItemCode { get; set; }

        //[DataMember(Order = 24)]
        public virtual string ItemName { get; set; }

        //[DataMember(Order = 25)]
        public virtual string Spec { get; set; }

        //[DataMember(Order = 26)]
        public virtual string ManufactureryName { get; set; }

        //[DataMember(Order = 27)]
        public virtual double RetailPrice { get; set; }

        //[DataMember(Order = 28)]
        public virtual double TotalRetail { get; set; }

        //[DataMember(Order = 29)]
        public virtual string UnitName { get; set; }

        //[DataMember(Order = 30)]
        public virtual string HuTotalSum { get; set; }

        //[DataMember(Order = 31)]
        public virtual string RmTotalSum { get; set; }

        //[DataMember(Order = 32)]
        public virtual string BatchNo { get; set; }

        //[DataMember(Order = 33)]
        public virtual string LimitDate { get; set; }

        //[DataMember(Order = 34)]
        public virtual string Memo { get; set; }
    }
}
