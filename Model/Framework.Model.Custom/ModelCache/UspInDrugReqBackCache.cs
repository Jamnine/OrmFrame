using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model.EnumDefine;

namespace Orm.Model.Custom
{
    public class UspInDrugReqBackCache : BaseModel
    {
        public string GUID { get; set; }

        public String RoomName { get; set; }

        public string DoctorId { get; set; }

        public String DoctorName { get; set; }

        public String PatientName { get; set; }

        public String InPatNo { get; set; }

        public String BedName { get; set; }

        public String ItemName { get; set; }

        public string AdviceId { get; set; }

        public int GroupNum { get; set; }

        public int LsMarkType { get; set; }

        public string ReqLocationId { get; set; }

        public String ReqLocationName { get; set; }

        public String RequestNo { get; set; }

        public string ReqOperId { get; set; }

        public String ItemCode { get; set; }

        public String Spec { get; set; }

        public double PriceIn { get; set; }

        public double Amount { get; set; }

        public String FrequencyName { get; set; }

        public String UsageName { get; set; }

        public double Dosage { get; set; }

        public double Totality { get; set; }

        public String UnitInName { get; set; }

        public Boolean IsSelectd { get; set; }

        public String LocationName { get; set; }

        public string ReqBackId { get; set; }

        public string RoomId { get; set; }

        public string ItemId { get; set; }

        public string UnitReq { get; set; }

        public double ReqBackTotality { get; set; }

        public Boolean IsBackReq { get; set; }

        public string HospId { get; set; }

        public string LocationId { get; set; }

        public string DetailId { get; set; }

        public DateTime ConfirmOperTime { get; set; }

        public Boolean IsBack { get; set; }

        public DateTime BackTime { get; set; }

        public String ConfirmOperName { get; set; }

        public String ReqBackOperName { get; set; }

        public String BackMemo { get; set; }

        public String ReqMemo { get; set; }

        public string ExecuteId { get; set; }

        public string ConfirmBackOperName { get; set; }

        private bool _isBackMemoNull = false;
        public bool u_IsBackMemoNull
        {
            get
            {
                if (string.IsNullOrWhiteSpace(DetailId))
                {
                    _isBackMemoNull = true;
                }
                else
                {
                    _isBackMemoNull = false;
                }
                return _isBackMemoNull;
            }
            set { _isBackMemoNull = value; }
        }
        private bool _isNurseAdviceNull = false;
        public bool u_IsNurseAdviceNull
        {
            get
            {
                if (LsMarkType == (int)EnumLsRmAdvType.NurseAdvice)
                {
                    _isNurseAdviceNull = true;
                }
                else
                {
                    _isNurseAdviceNull = false;
                }
                return _isNurseAdviceNull;
            }
            set { _isNurseAdviceNull = value; }
        }

    }
}
