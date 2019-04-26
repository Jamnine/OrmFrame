using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    public class UspInAdviceLongList
    {
        public virtual string GUID { get; set; }

        public virtual DateTime AdviceTime { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual String Code { get; set; }

        public virtual string LocationId { get; set; }

        public virtual string HospId { get; set; }

        public virtual int GroupNum { get; set; }

        public virtual string ItemId { get; set; }

        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual string FormId { get; set; }
        
        public virtual double PriceIn { get; set; }
        
        public virtual double Dosage { get; set; }

        public virtual string UnitTakeId { get; set; }
        
        public virtual string FrequencyId { get; set; }
        
        public virtual string UsageId { get; set; }

        public virtual double Totality { get; set; }
        
        public virtual double Amount { get; set; }

        public virtual string UnitInId { get; set; }
        
        public virtual Boolean IsAttach { get; set; }

        public virtual Boolean IsSelf { get; set; }

        public virtual int LsSpecialUsage { get; set; }
        
        public virtual int LsExecLoc { get; set; }

        public virtual DateTime? SkinTime { get; set; }
        
        public virtual Boolean IsSkin { get; set; }
        
        public virtual String SkinTest { get; set; }
        
        public virtual string OperID { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual Boolean IsPrinted { get; set; }
        
        public virtual Boolean IsChk { get; set; }
        
        public virtual DateTime ChkOperTime { get; set; }

        public virtual string ChkOperID { get; set; }

        public virtual Boolean IsEnd { get; set; }

        public virtual DateTime EndOperTime { get; set; }
        
        public virtual string EndOperID { get; set; }
        
        public virtual string EndDoctorID { get; set; }
        
        public virtual Boolean IsAuth { get; set; }
        
        public virtual DateTime? AuthOperTime { get; set; }
        
        public virtual string AuthOperID { get; set; }

        public virtual String Memo { get; set; }
        
        public virtual String YbType { get; set; }
        
        public virtual Boolean IsOtherFee { get; set; }

        public virtual int LsRpType { get; set; }
        
        public virtual Boolean? IsInject { get; set; }

        public virtual string SN { get; set; }
        
        public virtual int FirstDay { get; set; }
        
        public virtual int LastDay { get; set; }
        
        public virtual string ExecLocId { get; set; }
        
        public virtual string ExecDoctorId { get; set; }
        
        public virtual Boolean? IsYbxj { get; set; }
        
        public virtual String Colours { get; set; }
        
        public virtual String LimitTotalZy { get; set; }

        public virtual double DiscountAoumt { get; set; }

        public virtual double DiscountPrice { get; set; }
       
        public virtual double ChildPrice { get; set; }

        public virtual Boolean IsModify { get; set; }

        public virtual String IsNoDrug { get; set; }

        public virtual String IsRpForbid { get; set; }
    }
}
