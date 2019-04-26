
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model.Custom;
using Orm.Model;
using Orm.Model.EnumDefine;
using Orm.Model.Custom.UspModel;
using System.Collections;
using static Orm.Model.EnumDefine.EumConvertor;

namespace Orm.Model.Custom
{
    [Serializable]
    public class HuRmCommonServiceWithDeteleHuOutAndHuOutDtl : BaseModel
    {
        public HuOut HuOut { get; set; }
        public IList<HuOutDtl> LstHuOutDtl { get; set; }
        public bool IsIsAffirm { get; set; }
        
        public HuRmBillTypeCodeEnum BillTypeCode { get; set; }
        public string HouseRoomId { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithSaveHuOutAndHuOutDtl : BaseModel
    {
        public HuOut HuOut { get; set; }
        public IList<HuOutDtl> LstHuOutDtl { get; set; }
        public bool IsIsAffirm { get; set; }
        
        public HuRmBillTypeCodeEnum BillTypeCode { get; set; }
        public string HouseRoomId { get; set; }
    }
    [Serializable]
    public class HuRmCommonServiceWithDeleteRmKsOutAndRmKsOutDtl : BaseModel
    {
        public RmKsOut RmKsOut { get; set; }
        public IList<RmKOutDtl> LstRmKOutDtl { get; set; }
        
        public HuRmBillTypeCodeEnum BillTypeCode { get; set; }
        public string HouseRoomId { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithDeleteInRmKsDtlAndRmKsOut : BaseModel
    {
        public RmKsOut RmKsOut { get; set; }
        public IList<RmKOutDtl> LstRmKOutDtl { get; set; }
        
        public HuRmBillTypeCodeEnum BillTypeCode { get; set; }
        public string HouseRoomId { get; set; }
    }

    [Serializable]
    public class RecipeExecuteServiceWithPrintLabel : BaseModel
    {
        public IList<UspInExecuteBillPrint> LstInExecuteBillPrint { get; set; }
        public bool IsPrintAll { get; set; }
        public bool CheckTodayAdvice { get; set; }
        public DateTime DTDate { get; set; }
        public bool IsPush { get; set; }
        public bool IsLabelPrintMergeLongTemp { get; set; }
        public string ExecuteTimeId { get; set; }
        public bool IsPrintLabelEnglishUnitName { get; set; }
        public int GroupTemp { get; set; }
        public string AloneTotalityItemId { get; set; }
    }

    [Serializable]
    public class BalanceServiceWithCountFee : BaseModel
    {
        public List<UspInPatientNotEnough> LstUspInPatientNotEnough { get; set; }
        public string HospId { get; set; }
    }


    [Serializable]
    public class MedicalRecordServiceWithGetOuClincDiag : BaseModel
    {
        public OuHosInfo OuHosInfo { get; set; }
        public BsPatient BsPatient { get; set; }
        public List<OuClincDiag> LstOuClincDiag { get; set; }
        public string Diagnosis { get; set; }
    }


    [Serializable]
    public class PatientServiceWithSaveInHosMzIllAndHisba4 : BaseModel
    {
        public InHosInfo InHosInfo { get; set; }
        public List<InHosMzIll> LstInHosMzIll { get; set; }
        public List<HISBA4> LstHisba4 { get; set; }
        public string HospId { get; set; }
        public string HostName { get; set; }
        public string InHosMzIllHospId { get; set; }
        public string UserId { get; set; }
    }

    [Serializable]
    public class PatientServiceWithInHosMzIllAndHisba4 : BaseModel
    {
        public IList<InHosMzIll> LstInHosMzIll { get; set; }
        public IList<HISBA4> LstHisba4 { get; set; }
    }


    [Serializable]
    public class TraceServiceWithAddCustTraceNew : BaseModel
    {
        public string OperateType { get; set; }
        public string Messages { get; set; }
        public string Title { get; set; }
        public string RecordId { get; set; }
        public string StrInpatno { get; set; }
        public string StrName { get; set; }
        public string StrMessage { get; set; }
        public string UserId { get; set; }
        public string IP { get; set; }
        public string InHosMzIllId { get; set; }
        public string HospId { get; set; }
        public string InPatNo { get; set; }
        public int NTime { get; set; }
    }


    [Serializable]
    public class CommentServiceWithLockKeyAndUnLockKey : BaseModel
    {
        public string LockId { get; set; }
        public string KeyValue { get; set; }
        public string KeyTypeId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public EnumLockType LockType { get; set; }
        public string UserId { get; set; }

    }


    [Serializable]
    public class CommentServiceWithGetLockKey : BaseModel
    {
        public string KeyTypeId { get; set; }
        public string KeyValue { get; set; }
        public string UserId { get; set; }
        public string LockIp { get; set; }
        public string LockId { get; set; }
        public string LockedId { get; set; }
        public string LockHost { get; set; }
        public GblKeyLockSetting GblKeyLockSetting { get; set; }
        public string MsgStr { get; set; }
        public string Name { get; set; }
    }


    [Serializable]
    public class LockKeyWithCheckLocked : BaseModel
    {
        public string Message { get; set; }
        public CommentServiceWithGetLockKey GblKeyLockSetting { get; set; }
    }

    [Serializable]
    public class PacsServiceWithSavePsApplyReport : BaseModel
    {
        public UspCheckCall InfoCheckCall { get; set; }
        public string BoxNum { get; set; }
        public bool IsBaby { get; set; }
    }


    [Serializable]
    public class HuRmCommonServiceWithGetCalStoresData : BaseModel
    {
        public IList<HuStores> LstHuStore { get; set; }
        public IList<Rmstores> LstRmstore { get; set; }
        public string LstHuStoreName { get; set; }
        public string LstRmstoreName { get; set; }

    }

    [Serializable]
    public class HuRmCommonServiceWithSaveChinRecipeDtl : BaseModel
    {
        public UspOuDrugIssue OuDrugIssue { get; set; }
        public IList<UspOuChinRecipePrint> LstOuChinRecipePrint { get; set; }
        public string UserId { get; set; }
        public string TempId { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithBackOuDrug : BaseModel
    {
        public Rmstores Rmstore { get; set; }
        public Rmstores LastRmStore { get; set; }
        public IList<UspOuDrugIssueDtl> LstOuDrugIssueDtl { get; set; }
        public UspOuDrugIssue OuDrugIssue { get; set; }
        public bool IsOuDrugIssueByInvoice { get; set; }
        public bool IsBackDrugChinRecipeDtl { get; set; }
        public string UserId { get; set; }
        public string RoomId { get; set; }
        public EnumRmActType RmActType { get; set; }
        public bool IsSaveStockNumToDtl { get; set; }
        public bool IsOut { get; set; }
        public string InOuPatId { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithCancelOuBackDrug : BaseModel
    {
        public IList<UspOuDrugIssueDtl> LstOuDrugIssueDtl { get; set; }
        public IList<UspOuDrugIssueDtl> RLstOuDrugIssueDtl { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithSendInDrug : BaseModel
    {
        public bool IsInSendDrugGetFee { get; set; }
        public UspInDrugIssue InDrugIssue { get; set; }
        public List<UspInSendDrugClassPrint> LstInSendDrugClassPrint { get; set; }
        public List<UspInSendDrugCache> LstInSendDrugClassPrints { get; set; }
        public string UserId { get; set; }
        public EnumLocationInOut LocationInOut { get; set; }
        public InDrugReqdtl InDrugReqdtl { get; set; }
        public IList<InDrugReqdtl> LstInDrugReqdtl { get; set; }
        public IList<InDrugReqdtl> LstDrugReqDtl { get; set; }
        public RmZyOut RmZyOut { get; set; }
        public List<RmZyOutDtl> LstRmZyOutDtl { get; set; }
        public EnumRmActType RmActType { get; set; }
        public bool IsSaveStockNumToDtl { get; set; }
        public bool IsOut { get; set; }
        public string LocationId { get; set; }
        public string InOuPatId { get; set; }
        public IList<Rmstores> LstRmstoreUpdate { get; set; }
        public IList<Rmstores> LstRmstoreLocation { get; set; }
        public InDrugReq InDrugReq { get; set; }
        public List<InDrugReqdtl> LstDrugReqDtlFee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RequestId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int LsSendStatus { get; set; }

        private bool _isNotRequestIdNull = false;
        public bool u_IsNotRequestIdNull
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(GUID))
                {
                    _isNotRequestIdNull = true;
                }
                else
                {
                    _isNotRequestIdNull = false;
                }
                return _isNotRequestIdNull;
            }
            set { _isNotRequestIdNull = value; }
        }


    }


    [Serializable]
    public class ClinicalPathwayServiceWithSavePrescription : BaseModel
    {
        public DgRoad DgRoad { get; set; }
        public List<DgRoadIll> LstDgRoadIll { get; set; }
        public List<DgRoadGroup> LstDgRoadGroupAll { get; set; }
        public List<DgRoadLoc> LstDgRoadLoc { get; set; }
        public List<DgRoadDtl> LstDgRoadDtl { get; set; }
        public List<DgRoadDtl> LstDgRoadDtlAll { get; set; }
        public List<DgDayGroup> LstDgDayGroup { get; set; }
        public List<DgRoadVariation> LstDgRoadVariation1 { get; set; }
        public List<DgRoadVariation> LstDgRoadVariation2 { get; set; }
        public List<DgRoadGroup> LstDgRoadGroupDel { get; set; }
        public List<DgRoadDtl> LstDgRoadDtlDel { get; set; }
        public List<DgRoadChinRicipeDtl> LstDgRoadChinRicipeDtl { get; set; }
        public List<DgDayGroup> LstDgDayGroupDel { get; set; }
        public List<DgRoadIll> LstDgRoadIllDel { get; set; }
    }


    [Serializable]
    public class HuRmCommonServiceWithSendOuDrug : BaseModel
    {
        public RmOut RmOut { get; set; }
        public List<RmOutDtl> LstRmOutDtl { get; set; }
        public bool IsSaveOuBalanceToSendDrug { get; set; }
        public IList<UspInSendDrugClassPrint> LstInDrugIssueDtl { get; set; }
        public EnumRmActType RmActType { get; set; }
        public bool IsSaveStockNumToDtl { get; set; }
        public bool IsOut { get; set; }

        public string LocationId { get; set; }
        public string InOuPatId { get; set; }
        public IList<Rmstores> LstRmstoreUpdate { get; set; }
        public IList<OuRecipeDtl> LstOuRecipeDtl { get; set; }
        public IList<OuRecipeTemp> LstRecipeTemp { get; set; }
        public UspOuDrugIssue OuDrugIssue { get; set; }
        public string RoomId { get; set; }
        public bool IsOuSendAndDosageSameMan { get; set; }
        public string DosageOperId { get; set; }
        public string HostName { get; set; }
        public string FormName { get; set; }
        public string UserId { get; set; }
        public string LocalIP { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithBackInDrugReqBack : BaseModel
    {
        public int Index { get; set; }
        public string RoomId { get; set; }
        public string UserId { get; set; }
        public IList<UspRmInDrugBack> LstRmInDrugBack { get; set; }
        public IList<UspRmInDrugBackDtl> LstRmInDrugBackDtl { get; set; }
        public IList<UspInSendDrugClassPrint> LstInDrugIssueDtl { get; set; }
        public EnumRmActType RmActType { get; set; }
        public bool IsSaveStockNumToDtl { get; set; }
        public bool IsOut { get; set; }
        public string LocationId { get; set; }
        public string InOuPatId { get; set; }
    }


    [Serializable]
    public class HuRmCommonServiceWithInsertLog<TMain, TDetail> : BaseModel
    {
        public TMain InfoMain { get; set; }
        public IList<TDetail> LstDetail { get; set; }
        public IList<UspInSendDrugClassPrint> LstInDrugIssueDtl { get; set; }
        public EnumRmActType RmActType { get; set; }
        public bool IsSaveStockNumToDtl { get; set; }
        public bool IsOut { get; set; }
        public string LocationId { get; set; }
        public string InOuPatId { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithSaveRmKsOutAndRmKsOutDtl : BaseModel

    {
        public RmKsOut RmKsOut { get; set; }
        public List<RmKOutDtl> LstRmKOutDtl { get; set; }
        public bool IsOut { get; set; }
        public List<UspInInvoiceDtlToRmKOutDtl> LstUspInInvoiceDtlToRmKOutDtl { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithSaveOuExecuteDtlAndInRmKsDtl : BaseModel
    {
        public RmKsOut RmKsOut { get; set; }
        public List<RmKOutDtl> LstRmKOutDtl { get; set; }
        public bool IsOut { get; set; }
        public List<UspInInvoiceDtlToRmKOutDtl> LstInInvoiceDtlToRmKOutDtl { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithSaveHuOutAndRmAppDrug : BaseModel
    {
        public HuStock HuStock { get; set; }
        public HuOut HuOut { get; set; }
        public List<HuOutDtl> LstHuOutDtl { get; set; }
        public List<HuStores> LstHuStore { get; set; }
        public string HouseId { get; set; }
        public string LocationName { get; set; }
        public bool IsAffirm { get; set; }
        public string RoomId { get; set; }
    }

    [Serializable]
    public class ClinicalPathwayServiceWithAddPsApplyReport : BaseModel
    {
        public InAdviceTemp InAdviceTemp { get; set; }
        public string UserId { get; set; }
        public string DoctorId { get; set; }
        public string PatId { get; set; }
        public string HospId { get; set; }
    }

    [Serializable]
    public class ItemCkServiceWithSaveCkLabResultAndCkLabDtl : BaseModel
    {
        public UspCkPatientInfo CkPatientInfo { get; set; }
        public IList<CkLabResult> LstCkLabResult { get; set; }
        public IList<CkItem> LstCkItem { get; set; }
        public List<string> LstStr { get; set; }
        public string SourceId { get; set; }
        public string LabId { get; set; }
        public EnumStatus Status { get; set; }
        public bool IsBack { get; set; }
        public string UserId { get; set; }
        public string AuthOperId { get; set; }
        public DateTime NowDate { get; set; }
        public bool IsTestResultAutoAuthorize { get; set; }
    }


    [Serializable]
    public class HuRmCommonServiceWithGetRminAndOutForItem : BaseModel
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string RoomId { get; set; }
        public int LsActType { get; set; }
        public string BillNo { get; set; }
        public string ItemId { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithGetRmInAndOutWz : BaseModel
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string RoomId { get; set; }
        public string HouseId { get; set; }
        public string BillNo { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithSaveHuBackDtl : BaseModel
    {
        public IList<HuBack> LstHuBack { get; set; }
        public IList<UspHuBackDtl> LstHuBackDtl { get; set; }
        public IList<HuStock> LstHuStock { get; set; }
        public IList<UspHuStockDtl> LstHuStockDtl { get; set; }
        public string VoucherNo { get; set; }
        public string HouseId { get; set; }
        public string UserId { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithGetListHuVoucher : BaseModel
    {
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string CompId { get; set; }
        public string VoucherNo { get; set; }
        public string HouseId { get; set; }
        public int HasInvo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private bool _isNotBeginTime = false;
        /// <summary>
        /// 
        /// </summary>
        public bool u_IsNotBeginTime
        {
            get
            {
                if (BeginTime != DateTime.MinValue)
                {
                    _isNotBeginTime = true;
                }
                return _isNotBeginTime;
            }
            set { _isNotBeginTime = value; }
        }
        private bool _isEndTime = false;
        /// <summary>
        /// 
        /// </summary>
        public bool u_IsEndTime
        {
            get
            {
                if (EndTime != DateTime.MinValue)
                {
                    _isEndTime = true;
                }
                return _isEndTime;
            }
            set { _isEndTime = value; }
        }
        private bool _isNotVoucherNo = false;
        /// <summary>
        /// 
        /// </summary>
        public bool u_IsNotVoucherNo
        {
            get
            {
                if (VoucherNo != string.Empty)
                {
                    _isNotVoucherNo = true;
                }
                return _isNotVoucherNo;
            }
            set { _isNotVoucherNo = value; }
        }
    }

    [Serializable]
    public class HuRmCommonServiceWithGetListHuStock : BaseModel
    {
        public List<HuStock> LstHuStock { get; set; }
        public List<HuBack> LstHuBack { get; set; }
        public List<HuStockDtl> LstHuStockDtl { get; set; }
        public List<HuBackDtl> LstHuBackDtl { get; set; }
        public HuVoucher HuVoucher { get; set; }
        public string CommId { get; set; }
        public string HouseId { get; set; }
        public string HuVoHuBackHouseId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private bool _isLstHuStock = false;
        /// <summary>
        /// 
        /// </summary>
        public bool u_IsLstHuStock
        {
            get
            {
                if (LstHuStock == null || !LstHuStock.Any())
                {
                    _isLstHuStock = true;
                }
                return _isLstHuStock;
            }
            set { _isLstHuStock = value; }
        }
    }

    [Serializable]
    public class HuRmCommonServiceWithSearchConditions : BaseModel
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string HouseId { get; set; }
        public int LsActType { get; set; }
        public string BillNo { get; set; }
        public string ItemId { get; set; }
        public int HasInvo { get; set; }
        public string LocName { get; set; }
        public string Name { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithSaveHuOtherOut : BaseModel
    {
        public RmApplback HuOutInfo { get; set; }
        public List<RmApplbackDtl> HuOutDtlList { get; set; }
        public string WzWsclHouseId { get; set; }
        public string UserId { get; set; }
        public string HouseId { get; set; }
        public string WzGysHouseId { get; set; }
    }

    [Serializable]
    public class BsLabSourceItemWithAdviceAuthDtl : BaseModel
    {
        public IList<BsLabSourceItem> lstSourceItem { get; set; }

        public AdviceAuthDtl adviceAuthDtl { get; set; }

        public string sourceMemo { get; set; }

        public string sourceIds { get; set; }

        public string testTypeIds { get; set; }

        public string tubeTypeIds { get; set; }
    }

    [Serializable]
    public class ItemWithBsItemRelationCure : BaseModel
    {
        ////////////[DataMember(Order = 10)]
        public virtual BsItem BsItem { get; set; }

        ////////////[DataMember(Order = 11)]
        public virtual IList<BsItemAttach> LstBsItemAttach { get; set; }

        ////////////[DataMember(Order = 12)]
        public virtual IList<BsItemFrequency> LstBsItemFrequency { get; set; }

        ////////////[DataMember(Order = 13)]
        public virtual BsItemLocation BsItemLocation { get; set; }

        ////////////[DataMember(Order = 14)]
        public virtual IList<BsItemPatType> LstBsItemPatType { get; set; }

        ////////////[DataMember(Order = 15)]
        public virtual IList<BsItemTally> LstBsItemTally { get; set; }

        ////////////[DataMember(Order = 16)]
        public virtual IList<BsItemUnit> LstBsItemUnit { get; set; }

        ////////////[DataMember(Order = 17)]
        public virtual IList<BsItemUsage> LstBsItemUsage { get; set; }

        ////////////[DataMember(Order = 18)]
        public virtual IList<BsItemYb> LstBsItemYb { get; set; }

        ////////////[DataMember(Order = 19)]
        public virtual IList<BsItemIllType> LstBsItemIllType { get; set; }

        ////////////[DataMember(Order = 20)]
        public virtual IList<BsItemPacs> LstBsItemPacs { get; set; }

        ////////////[DataMember(Order = 21)]
        public virtual IList<BsUnitRatio> LstBsUnitRatio { get; set; }

        ////////////[DataMember(Order = 22)]
        public virtual IList<BsItemLocation> LstBsItemLocation { get; set; }
        ////////////[DataMember(Order = 23)]
        public virtual IList<BsItemItem> LstBsItemItem { get; set; }

        ////////////[DataMember(Order = 24)]
        public virtual bool IsPacs { get; set; }

        ////////////[DataMember(Order = 25)]
        public virtual string PacsId { get; set; }

    }

    [Serializable]
    public class ItemWithBsItemDrug : BaseModel
    {
        ////////////[DataMember(Order = 10)]
        public virtual IList<BsItemPacs> lstBsItemPacs { get; set; }

        ////////////[DataMember(Order = 11)]
        public virtual IList<BsItemDrug> LstBsItemDrug { get; set; }

        ////////////[DataMember(Order = 12)]
        public virtual IList<BsItemYb> LstBsItemYb { get; set; }

        ////////////[DataMember(Order = 13)]
        public virtual IList<BsItemFrequency> LstBsItemFrequencyInfo { get; set; }

        ////////////[DataMember(Order = 14)]
        public virtual IList<BsItemLocation> LstBsItemLocationInfo { get; set; }

        ////////////[DataMember(Order = 15)]
        public virtual IList<BsItemUnit> LstBsItemUnitInfo { get; set; }

        ////////////[DataMember(Order = 16)]
        public virtual IList<BsItemUsage> LstBsItemUsageInfo { get; set; }

        ////////////[DataMember(Order = 17)]
        public virtual IList<BsItemAttach> LstBsItemAttachInfo { get; set; }

        ////////////[DataMember(Order = 18)]
        public virtual IList<BsItemPatType> LstBsItemPatTypeInfo { get; set; }

        ////////////[DataMember(Order = 19)]
        public virtual IList<BsUnitRatio> LstBsUnitRatioInfo { get; set; }

        ////////////[DataMember(Order = 20)]
        public virtual IList<BsItemItem> LstBsItemItem { get; set; }

        ////////////[DataMember(Order = 21)]
        public virtual IList<BsExecLocation> LstBsExecLocation { get; set; }
    }


    /// <summary>
    /// 退记账管理费用
    /// </summary>
    [Serializable]
    public class AccountingWithUspInInvoiceDtlBack : BaseModel
    {
        ////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String Name { get; set; }

        ////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String Spec { get; set; }

        ////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String Code { get; set; }

        ////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual string HospId { get; set; }

        ////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual string ItemId { get; set; }

        ////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual DateTime RegOperTime { get; set; }

        ////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual string RegOperId { get; set; }

        ////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual string LocationId { get; set; }

        ////////////[DataMember(Order = 10, IsRequired = true)]
        public virtual string AdviceId { get; set; }

        ////////////[DataMember(Order = 11, IsRequired = true)]
        public virtual double Totality { get; set; }

        ////////////[DataMember(Order = 12, IsRequired = true)]
        public virtual Int16 LsMarkType { get; set; }

        ////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual double PriceIn { get; set; }

        ////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual string UnitId { get; set; }

        ////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual Boolean IsPay { get; set; }

        ////////////[DataMember(Order = 16, IsRequired = true)]
        public virtual double DiscSelf { get; set; }

        ////////////[DataMember(Order = 17, IsRequired = true)]
        public virtual double DiscIn { get; set; }

        ////////////[DataMember(Order = 18, IsRequired = false)]
        public virtual double? Amount { get; set; }

        ////////////[DataMember(Order = 19, IsRequired = true)]
        public virtual double AmountFact { get; set; }

        ////////////[DataMember(Order = 20, IsRequired = true)]
        public virtual double AmountSelf { get; set; }

        ////////////[DataMember(Order = 21, IsRequired = true)]
        public virtual double AmountTally { get; set; }

        ////////////[DataMember(Order = 22, IsRequired = true)]
        public virtual double AmountPay { get; set; }

        ////////////[DataMember(Order = 23, IsRequired = false)]
        public virtual string InvoId { get; set; }

        ////////////[DataMember(Order = 24, IsRequired = true)]
        public virtual Int16 LsPerform { get; set; }

        ////////////[DataMember(Order = 25, IsRequired = true)]
        public virtual Boolean IsModiDisc { get; set; }

        ////////////[DataMember(Order = 26, IsRequired = false)]
        public virtual string LimitGroupId { get; set; }

        ////////////[DataMember(Order = 27, IsRequired = false)]
        public virtual double? LimitFee { get; set; }

        ////////////[DataMember(Order = 28, IsRequired = true)]
        public virtual string DoctorId { get; set; }

        ////////////[DataMember(Order = 29, IsRequired = true)]
        public virtual string ExecOperId { get; set; }

        ////////////[DataMember(Order = 30, IsRequired = true)]
        public virtual string ExecLocId { get; set; }

        ////////////[DataMember(Order = 31, IsRequired = true)]
        public virtual string InvItemId { get; set; }

        ////////////[DataMember(Order = 32, IsRequired = true)]
        public virtual string FeeId { get; set; }

        ////////////[DataMember(Order = 33, IsRequired = false)]
        public virtual string FeeHsId { get; set; }

        ////////////[DataMember(Order = 34, IsRequired = true)]
        public virtual Boolean IsCancel { get; set; }

        ////////////[DataMember(Order = 35, IsRequired = true)]
        public virtual Boolean IsManual { get; set; }

        ////////////[DataMember(Order = 36, IsRequired = false)]
        public virtual string CancelId { get; set; }

        ////////////[DataMember(Order = 37, IsRequired = false)]
        public virtual Int16? LsReportType { get; set; }

        ////////////[DataMember(Order = 38, IsRequired = true)]
        public virtual String Memo { get; set; }

        ////////////[DataMember(Order = 39, IsRequired = true)]
        public virtual DateTime OperTime { get; set; }

        ////////////[DataMember(Order = 40, IsRequired = true)]
        public virtual string OperId { get; set; }

        ////////////[DataMember(Order = 41, IsRequired = true)]
        public virtual String AdviceName { get; set; }

        ////////////[DataMember(Order = 42, IsRequired = true)]
        public virtual String RegOperDate { get; set; }

        ////////////[DataMember(Order = 43, IsRequired = true)]
        public virtual String HostName { get; set; }

        ////////////[DataMember(Order = 44, IsRequired = false)]
        public virtual string GroupItemId { get; set; }

        ////////////[DataMember(Order = 45, IsRequired = false)]
        public virtual string XDRpId { get; set; }

        ////////////[DataMember(Order = 46, IsRequired = true)]
        public virtual String AdviceName1 { get; set; }

        ////////////[DataMember(Order = 47, IsRequired = false)]
        public virtual String ReservedField { get; set; }

        ////////////[DataMember(Order = 48, IsRequired = false)]
        public virtual Boolean IsAutoCharged { get; set; }

        ////////////[DataMember(Order = 49, IsRequired = false)]
        public virtual double BackTootality { get; set; }
    }


    [Serializable]
    public class UspInCheckHasPayedLongAdvice : BaseModel
    {
        // [DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }
    }


    [Serializable]
    public class UspInCheckLongAppliedDrug : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }
    }
    [Serializable]
    public class BloodTransfusionWithBdBank : BaseModel
    {
        ////////////[DataMember(Order = 1)]
        public virtual DateTime BackDate { get; set; }
        ////////////[DataMember(Order = 2)]
        public virtual DateTime CollectDate { get; set; }

        ////////////[DataMember(Order = 3)]
        public virtual DateTime ExpireDate { get; set; }

        ////////////[DataMember(Order = 4)]
        public virtual DateTime RecieveDate { get; set; }

        ////////////[DataMember(Order = 5)]
        public virtual string OfferMan { get; set; }

        ////////////[DataMember(Order = 6)]
        public virtual double Price { get; set; }

        ////////////[DataMember(Order = 7)]
        public virtual string SerialNo { get; set; }

        ////////////[DataMember(Order = 8)]
        public virtual string BackOperId { get; set; }

        ////////////[DataMember(Order = 9)]
        public virtual string RecieveOperId { get; set; }

        ////////////[DataMember(Order = 10)]
        public virtual string BloodTypeId { get; set; }

        ////////////[DataMember(Order = 11)]
        public virtual int LsSource { get; set; }

        ////////////[DataMember(Order = 12)]
        public virtual int LsStatus { get; set; }

    }

    [Serializable]
    public class BloodTransfusionWithCkLabSampleResult : BaseModel
    {
        public BsPatient BsPatient { get; set; }
        public CkLab CkLab { get; set; }
        public CkMachineResult CKMachineResult { get; set; }
        public CKMachineSample CKMachineSample { get; set; }

    }

    [Serializable]
    public class BloodTransfusionWithSendBank : BaseModel
    {
        public virtual CkBldApply CkBldApply { get; set; }
        public virtual IList<CkBdBank> LstCkBdBank { get; set; }
        public virtual IList<CkBldApplyBank> LstCkBldApplyBank { get; set; }
        public virtual IList<SendBankFee> LstSendBankFee { get; set; }
        public virtual string UserID { get; set; }
        public virtual bool IsOps { get; set; }

    }

    [Serializable]
    public class BloodTransfusionWithSendBankLab : BaseModel
    {
        public UspCkLabByOpertimeAndLsStatus2 CkLabByOpertimeAndLsStatus;

        public string GUID;

        public string HospId;

        public string LocationId;

        public string LabNum;
        public bool IsBack { get; set; }

    }


    [Serializable]
    public class BloodTransfusionWithDonateApply : BaseModel
    {
        ////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string HospId { get; set; }
        ////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual double DonateVollume { get; set; }
        ////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual double UseVollume { get; set; }

    }



    [Serializable]
    public class BloodTransfusionWithDonate : BaseModel
    {
        ////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string HospId { get; set; }
        ////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual string LocationId { get; set; }
        ////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual DateTime BeginTime { get; set; }
        ////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual DateTime EndTime { get; set; }
    }


    [Serializable]
    public class BloodTransfusionWithFree : BaseModel
    {
        ////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string HospId { get; set; }
        ////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual string LocationId { get; set; }
        ////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual DateTime BeginTime { get; set; }
        ////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual DateTime EndTime { get; set; }
    }


    [Serializable]
    public class BloodTransfusionWithReimb : BaseModel
    {
        ////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string LocationId { get; set; }
        ////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual string InPatNo { get; set; }
        ////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual DateTime BeginTime { get; set; }
        ////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual DateTime EndTime { get; set; }
    }



    [Serializable]
    public class PacsWithInCheckRecipe : BaseModel
    {
        ////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string LocationId { get; set; }

        ////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual string RecipeId { get; set; }

        ////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual bool IsExecuted { get; set; }

        ////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual DateTime BeginTime { get; set; }

        ////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual DateTime EndTime { get; set; }
    }

    [Serializable]
    public class PacsWithXType : BaseModel
    {
        ////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual int HospitalId { get; set; }

        ////////////[DataMember(Order = 2, IsRequired = false)]
        public virtual string LocationId { get; set; }

        ////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual int XType { get; set; }

        ////////////[DataMember(Order = 4, IsRequired = false)]
        public virtual DateTime BeginTime { get; set; }

        ////////////[DataMember(Order = 5, IsRequired = false)]
        public virtual DateTime EndTime { get; set; }

        ////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual Boolean IsExecute { get; set; }

        ////////////[DataMember(Order = 7, IsRequired = false)]
        public virtual int BeginStatus { get; set; }

        ////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual int EndStatus { get; set; }

    }



    [Serializable]
    public class PacsWithMeeting : BaseModel
    {
        public virtual int LsMarkType { get; set; }
        public virtual string AdviceId { get; set; }
        public virtual Boolean IsConfirm { get; set; }
        public virtual string LocationId { get; set; }
        public virtual string DoctorId { get; set; }
        public virtual string HospId { get; set; }
    }

    [Serializable]
    public class FinanceWithBalance : BaseModel
    {
        public string OperId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int HospitalId { get; set; }
        public int LsOutIn { get; set; }
        public string BillId { get; set; }
        public bool IsSign { get; set; }

    }


    [Serializable]
    public class RecipeWithCheckItemActive : BaseModel
    {
        public List<AdviceAuthDtl> lstUspInAdviceLong { get; set; }
        public List<AdviceAuthDtl> lstItemActive { get; set; }
        public string namesShow { get; set; }
        public String patientName { get; set; }
        public String strConfirmMessage { get; set; }
        public Boolean isAllConfirm { get; set; }
        public int hospitalId { get; set; }
        public string locationId { get; set; }
    }


    [Serializable]
    public class RecipeWithSetFrequencyTimes : BaseModel
    {
        public InDrugReqdtlSkinBack infoReqdtlSkinBack { get; set; }
        public InExecute infoInExecute { get; set; }
    }

    [Serializable]
    public class RecipWithCreateDrugReq : BaseModel
    {
        public IList<InDrugReqdtl> lstInDrugReqdtlIn { get; set; }
        public Boolean IsSelect { get; set; }
    }


    [Serializable]
    public class PacsWithApplyAnswer : BaseModel
    {
        public HisInPatientQry Value { get; set; }
        public string LocationId { get; set; }
        public string DoctorId { get; set; }
        public string UserId { get; set; }
        public PsDiagMeeting PsDiagMeeting { get; set; }
        public IList<PsDiagDoctors> lstPsDiagDoctors { get; set; }
    }


    [Serializable]
    public class RecipeWithConfirm : BaseModel
    {
        public List<AdviceAuthDtl> lstCurrenAdvice { get; set; }
        public List<AdviceAuthDtl> lstItemActive { get; set; }
        public List<AdviceAuthDtl> lstAdviceAuthDtlAttach { get; set; }
        public List<HisInPatientQry> lstNoConfirm { get; set; }
        public List<InAdviceWeekDay> lstInAdviceWeekDayAll { get; set; }
        public List<InAdviceWeekDay> lstInAdviceWeekDay { get; set; }
        public List<AdviceAuthDtl> lstAdviceAuthDtlIsArrearage { get; set; }
        public DateTime dtBeginTime { get; set; }
        public HisInPatientQry infoCurrHosInfo { get; set; }
        public InDrugReqdtlSkinBack infoReqdtlSkinBack { get; set; }
        //  public InExecute inExecute { get; set; }
        public string namesShow { get; set; }
        public string patientName { get; set; }
        public bool isAllConfirm { get; set; }
        public string strConfirmMessage { get; set; }
        public string locationId { get; set; }
        public bool isArrearageAll { get; set; }
        public int hospitalId { get; set; }
        public string userId { get; set; }
        public string doctorId { get; set; }
        public bool isSelect { get; set; }
        public int selectCount { get; set; }
    }


    [Serializable]
    public class InAdviceDrugWithInAdviceReqBack : BaseModel
    {
        public string HospId { get; set; }
        public string DoctorId { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string SpecialityId { get; set; }
        public int LsMarkType { get; set; }
        public bool IsOutLocation { get; set; }
        public bool IsOutHospital { get; set; }
        public int DrugSatuts { get; set; }
    }


    [Serializable]
    public class RecipeWithGetListDoctorInExecute : BaseModel
    {
        public string hospId { get; set; }
        public DateTime beginTime { get; set; }
        public DateTime execTime { get; set; }
        public Int32 inExecuted { get; set; }
        public short adviceType { get; set; }
        public Boolean isPrintDrug { get; set; }
        public string usageId { get; set; }
        public String bedGroup { get; set; }
        public Int32 lsDateForSearch { get; set; }
        public string locationId { get; set; }
        public Boolean isPrint { get; set; }
        public Boolean isPrintLabel { get; set; }
        public Boolean isPrintReject { get; set; }
        public Boolean isPrintRejSkin { get; set; }
        public Boolean isPrintPush { get; set; }
        public Boolean isPrintNurse { get; set; }
        public Boolean isPrintDietetic { get; set; }
        public Boolean isPrintAtomization { get; set; }
        public Boolean isPrintBlood { get; set; }
        public Boolean isPrintCure { get; set; }
        public Boolean isPoison { get; set; }
        public Boolean isPrintExternal { get; set; }
        public Boolean isPrintAst { get; set; }
        public string specialityId { get; set; }
        public Int32 isLastLong { get; set; }
    }


    [Serializable]
    public class DocotrWithVsisitDoctor : BaseModel
    {
        public bool IsOuRegPlan { get; set; }
        public bool IsPreReg { get; set; }
        public DateTime RegTime { get; set; }
        public int WeekDay { get; set; }
        public string TimeSpanId { get; set; }
        public string RegDept { get; set; }
        public string RegTypeId { get; set; }
    }









    [Serializable]
    public class PhysicalExaminationWithGetCkResultGroupByMainId : BaseModel
    {
        public IList<CkResultGroup> lstCkResultGroup { get; set; }
        public string reportMemo { get; set; }
        public bool returnNull { get; set; }//中途返回，未给数据则为true
    }



    [Serializable]
    public class PatientWithModifyPatient : BaseModel
    {
        public BsPatient BsPatient { get; set; }
        public bool ChkisWorkMaster { get; set; }
        public OuLeadReg OuLeadReg { get; set; }
        public string UserId { get; set; }
        public IList<OuLeadReg> LstOuLeadReg { get; set; }
    }


    [Serializable]
    public class PatientWithTrySaveNew : BaseModel
    {
        public OulInvoiceReg OulInvoiceReg { get; set; }
        public IList<OulInvoiceRegPay> LstOulInvoiceRegPay { get; set; }
        public OuLeadReg OuLeadReg { get; set; }
        public OuHosInfo OuHosInfo { get; set; }
        public BsPatient BsPatient { get; set; }
        public bool IsEnabledVIP { set; get; }
        public VipCard VipCard { set; get; }
        
        public double Amount { set; get; }
        public string InvoNo { set; get; }

        public IList<OuInvoicePay> LstOuInvoicePay { set; get; }
    }


    [Serializable]
    public class PatientWithSaveOuHosInfo : BaseModel
    {
        public OuHosInfo InfoOuHosInfo { get; set; }
        public string GUID { get; set; }
        public string DoctorId { get; set; }
        public string LocationId { get; set; }
        public bool IsOuRegConfirmRegFee { get; set; }
        public bool IsOutWorkTime { get; set; }
        public string OutTimeRegTypeId { get; set; }
        public bool Check { get; set; }
        public string RegTypeId { get; set; }
        public IList<OuClincDiag> LstOuClincDiag { get; set; }
    }


    [Serializable]
    public class PatientWithUspyyOuDoctorPlan : BaseModel
    {
        public bool IsOuRegPlan { get; set; }
        public DateTime RegTime { get; set; }
        public string DoctorId { get; set; }
        public string TimeSpanId { get; set; }
        public string TimeSpanSubId { get; set; }
    }


    [Serializable]
    public class PatientWithShowHasDiagnoseNum : BaseModel
    {
        public string DoctorId { get; set; }
        public DateTime RegTime { get; set; }
        public string UbsTimeSpanId { get; set; }
        public bool IsOuRegPlan { get; set; }
        public string UbsTimeSpanSubId { get; set; }
        public bool ChkIsPreReg { get; set; }
        public string TimeSpanId { get; set; }
        public string TimeSpanSubId { get; set; }
    }


    [Serializable]
    public class PatientWithClearPatientBed : BaseModel
    {
        public UspBed InfoUspBed { get; set; }
        public string UserId { get; set; }
        public string InLocId { get; set; }
        public EnumInStatus InStatus { get; set; }
        public string LocationId { get; set; }
    }

    [Serializable]
    public class PatientWithSaveNewBabyInfo : BaseModel
    {
        public BsPatient BsPatient { get; set; }
        public BsBed BsBed { get; set; }
        public InHosInfo InHosInfo { get; set; }
        public RdNewBirth RdNewBirth { get; set; }
        public string BabyBedFeeItemId { get; set; }
    }



    [Serializable]
    public class InventoryWithGetInDrugReqdtlRoomId : BaseModel
    {
        public IList<InDrugReqdtl> LstInDrugReqdtl { get; set; }
        public string RoomId { get; set; }
        public string LocationId { get; set; }
        public bool IsChinRoomBehindWest { get; set; }
        public int HospitalId { get; set; }
        public bool IsChinDrugRoomIssueCPMedicine { get; set; }
    }


    [Serializable]
    public class InventoryWithGetRmInDrugBackDtlSum : BaseModel
    {
        public string RoomId { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string LocationId { get; set; }
        public bool IsBack { get; set; }
    }


    [Serializable]
    public class InventoryWithGetInDrugIssueConfirm : BaseModel
    {
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string RoomId { get; set; }
        public string LocationId { get; set; }
        public int HospitalId { get; set; }
        public EnumLsRmAdvType AdviceType { get; set; }
        public string HospId { get; set; }
    }


    [Serializable]
    public class InventoryWithGetInDrugIssueNotConfirm : BaseModel
    {
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string RoomId { get; set; }
        public string LocationId { get; set; }
        public int HospitalId { get; set; }
        public bool IsUrgent { get; set; }
        public EnumLsRmAdvType AdviceType { get; set; }
        public string HospId { get; set; }
    }


    [Serializable]
    public class InventoryWithGetInDrugIssueAll : BaseModel
    {
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string RoomId { get; set; }
        public string LocationId { get; set; }
        public int HospitalId { get; set; }
        public bool IsUrgent { get; set; }
    }


    [Serializable]
    public class InventoryWithGetOuDrugIssueDtl : BaseModel
    {
        public string RoomId { get; set; }
        public string RecipeId { get; set; }
        public bool IsCharged { get; set; }
        public bool IsIssued { get; set; }
        public bool IsBack { get; set; }
        public bool IsNoReject { get; set; }
    }


    [Serializable]
    public class InventoryWithGetOuDrugIssueTemp : BaseModel
    {
        public string RoomId { get; set; }
        public int HospitalId { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsCharged { get; set; }
        public bool IsIssued { get; set; }
        public bool IsBack { get; set; }
        public string RoomWindowName1 { get; set; }
        public string RoomWindowName2 { get; set; }
        public bool IsNoReject { get; set; }
        public bool IsDosage { get; set; }
    }


    [Serializable]
    public class InventoryWithGetOuDrugIssue : BaseModel
    {
        public string RoomId { get; set; }
        public int HospitalId { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsCharged { get; set; }
        public bool IsIssued { get; set; }
        public bool IsBack { get; set; }
        public bool IsNoReject { get; set; }
        public bool IsDosage { get; set; }
        public string RoomWindowName { get; set; }
    }


    [Serializable]
    public class InventoryWithGetInSendDrugLocationTotal : BaseModel
    {
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string RoomId { get; set; }
        public bool IsConfirm { get; set; }
        public string LocationId { get; set; }
    }


    [Serializable]
    public class InventoryWithSaveAddNewHuInventories : BaseModel
    {
        public DateTime LastCheckDate { get; set; }
        public DateTime CurrentCheckDate { get; set; }
        public string HouseId { get; set; }
        public string BillNo { get; set; }
        public bool IsDefaultCount { get; set; }
        public string GroupMainId { get; set; }
        public bool IsWzHouse { get; set; }
        public bool IsHuWzCheckGroupMainId { get; set; }
    }


    [Serializable]
    public class HuRmCommonWithGetInSendDrugClassPrint : BaseModel
    {
        public string RequestId { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsPrintLabel { get; set; }
        public EnumLsRmAdvType AdviceType { get; set; }
        public string HospId { get; set; }
        public bool IsUrgent { get; set; }
    }

    [Serializable]
    public class HuRmCommonWithGetInSendDrugClassPrintAll : BaseModel
    {
        public string RequestId { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsPrintLabel { get; set; }
        public EnumLsRmAdvType AdviceType { get; set; }
        public string HospId { get; set; }
    }



    [Serializable]
    public class HuRmCommonWithGetDrugReqdtl : BaseModel
    {
        public bool isConfirm { get; set; }

        public IList<UspInSendDrugClassPrint> LstvInRmRecipeDtl { get; set; }
    }



    [Serializable]
    public class HuRmCommonWithDrugReqdtl : BaseModel
    {
        public string mainId { get; set; }
        public string inPatValueId { get; set; }
        public string IssueStatus { get; set; }
        public int EmergencyAll { get; set; }
        public string AdviceType { get; set; }
        public DateTime BeginTime { get; set; }
        
        public IList<UspInSendDrugClassPrint> LstvInRmRecipeDtl { get; set; }
        private bool _isIssue = false;
        public bool u_IsIssue
        {
            get
            {
                if (IssueStatus == ((int)EnumIssueStatus.Issue).ToString())
                {
                    _isIssue = true;
                }
                return _isIssue;
            }
            set { _isIssue = value; }
        }
        private bool _isNoIssue = false;
        public bool u_IsNoIssue
        {
            get
            {
                if (IssueStatus == ((int)EnumIssueStatus.NoIssue).ToString())
                {
                    _isNoIssue = true;
                }
                return _isNoIssue;
            }
            set { _isNoIssue = value; }
        }
        private bool _isEmergency = false;
        public bool u_IsEmergency
        {
            get
            {
                if (EmergencyAll == (int)EnumEmergencyAll.Emergency)
                {
                    _isEmergency = true;
                }
                return _isEmergency;
            }
            set { _isEmergency = value; }
        }
    }



    [Serializable]
    public class HuRmCommonWithGetRmInDrugBack : BaseModel
    {
        public string RoomId { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string LocationId { get; set; }
        public bool IsBack { get; set; }
        public string HospId { get; set; }
    }


    [Serializable]
    public class HuRmCommonWithHuAuthorizeBill<Tmain, Tdetail> : BaseModel
    {
        public Tmain MainInfo { get; set; }
        public IList<Tdetail> DetailList { get; set; }
        
        public HuRmBillTypeCodeEnum BillTypeCode { get; set; }
        public EnumHuActType HuActType { get; set; }
        public bool IsOutHu { get; set; }
        public string Memo { get; set; }
        public bool IsSaveStockNumToDtl { get; set; }
    }


    [Serializable]
    public class HuRmCommonWithRmAuthorizeBill<Tmain, Tdetail> : BaseModel
    {
        public Tmain MainInfo { get; set; }
        public IList<Tdetail> DetailList { get; set; }
        
        public HuRmBillTypeCodeEnum BillTypeCode { get; set; }
        public EnumRmActType RmActType { get; set; }
        public bool IsOutRm { get; set; }
        public string Memo { get; set; }
        public bool IsSaveStockNumToDtl { get; set; }
    }


    [Serializable]
    public class HuRmCommonWithSaveBill<Tmain, Tdetail> : BaseModel
    {
        public Tmain MainInfo { get; set; }
        public List<Tdetail> DetailList { get; set; }
        
        public HuRmBillTypeCodeEnum BillTypeCode { get; set; }
        public string HouseRoomId { get; set; }
    }


    [Serializable]
    public class HuRmCommonWithModifyBill<Tmain, Tdetail> : BaseModel
    {
        public Tmain MainInfo { get; set; }
        public List<Tdetail> DetailList { get; set; }
        
        public HuRmBillTypeCodeEnum BillTypeCode { get; set; }
        public string HouseRoomId { get; set; }
    }


    [Serializable]
    public class HuRmCommonWithRemoveBill<Tmain, Tdetail> : BaseModel
    {
        public Tmain MainInfo { get; set; }
        public IList<Tdetail> DetailList { get; set; }
        
        public HuRmBillTypeCodeEnum BillTypeCode { get; set; }
    }


    [Serializable]
    public class HuRmCommonWithBuildNewBillNo : BaseModel
    {
        
        public HuRmBillTypeCodeEnum BillTypeCode { get; set; }
        public EnumBillSpecialType BillSpecicalType { get; set; }
        public EnumBillFiledName FieldName { get; set; }
        public string HouseRoomId { get; set; }
        public string BillId { get; set; }
    }


    [Serializable]
    public class RecipeWithGetUsageBabyItem : BaseModel
    {
        public IList<AdviceAuthDtl> LstOtherFeeQry { get; set; }
        public IList<AdviceAuthDtl> LstInitAdvice { get; set; }
        public IList<AdviceAuthDtl> LstCurrenAdvice { get; set; }
        public IList<InAdviceGroup> LstInAdviceGroup { get; set; }
        public HisInPatientQry InfoCurrHosInfo { get; set; }
        public string UserId { get; set; }
        public string LocationId { get; set; }
        public string PatTypeId { get; set; }
        public bool IsBaby { get; set; }
        public bool IsDiscountAoumt { get; set; }
    }


    [Serializable]
    public class RecipeWithGetBottleDosingCost : BaseModel
    {
        public IList<AdviceAuthDtl> LstOtherFeeQry { get; set; }
        public IList<InAdviceGroup> LstInAdviceGroup { get; set; }
        public HisInPatientQry HisInPatientQry { get; set; }
        public AdviceAuthDtl InfoRecipeDtl { get; set; }
        public string UserId { get; set; }
        public string LocationId { get; set; }
        public string PatTypeId { get; set; }
        public double ContinueTimes { get; set; }
        public bool IsDiscountAoumt { get; set; }
    }


    [Serializable]
    public class RecipeWithGetAddItemAttach : BaseModel
    {
        public IList<BsItemAttach> LstAttach { get; set; }
        public IList<AdviceAuthDtl> LstAdviceAuthDtl { get; set; }
        public AdviceAuthDtl InfoRecipeDtl { get; set; }
        public HisInPatientQry InfoCurrHosInfo { get; set; }
        public string ItemId { get; set; }
        public string UserId { get; set; }
        public string LocationId { get; set; }
        public string PatTypeId { get; set; }
        public double Times { get; set; }
        public bool IsDiscountAoumt { get; set; }
        public bool IsLoadBsItem { get; set; }
    }


    [Serializable]
    public class RecipeWithCheckIsArrearageFee : BaseModel
    {
        public List<AdviceAuthDtl> LstAdviceAuthDtlIsArrearage { get; set; }
        public List<AdviceAuthDtl> LstCurrenAdvice { get; set; }
        public List<InAdviceWeekDay> LstInAdviceWeekDayAll { get; set; }
        public AdviceAuthDtl InfoUspInAdviceLong { get; set; }
        public bool IsArrearage { get; set; }
    }


    [Serializable]
    public class RecipeWithGetInChinDrugIssue : BaseModel
    {
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsAuth { get; set; }
        public string SpecialityId { get; set; }
        public string LocationId { get; set; }
        public string AdviceLocationId { get; set; }
        public int LsOuDrugRecipeIssueStatus { get; set; }
        public int HospitalId { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsBack { get; set; }
    }


    [Serializable]
    public class RecipeWithSaveCheckOneAdvice : BaseModel
    {
        public List<UspInAdviceLongList> LstUspInAdviceLongList { get; set; }
        public List<UspInAdviceTempList> LstUspInAdviceTempList { get; set; }
        public string TabPageName { get; set; }
        public string HospId { get; set; }

        public string UserId { get; set; }

        public string DoctorId { get; set; }
        
        public UspInAdviceLongList UspInAdviceLongList { get; set; }
        public UspInAdviceTempList UspInAdviceTempList { get; set; }
    }


    [Serializable]
    public class RecipeWithGetLabSourceItem : BaseModel
    {
        public List<BsLabSourceItem> LstBsLabSourceItem { get; set; }
        public List<AdviceAuthDtl> LstAdviceAuthDtl { get; set; }
        public List<BsLabSourceItem> LstSourceItem { get; set; }
        public AdviceAuthDtl InfoRecipeDtl { get; set; }
        public bool IsLoadBsItem { get; set; }
        public string SourceMemo { get; set; }
        public string SourceIds { get; set; }
        public string TestTypeIds { get; set; }
        public string TubeTypeIds { get; set; }
        public string UserId { get; set; }
        public string LocationId { get; set; }
        public string PatTypeId { get; set; }
        public bool IsDiscountAoumt { get; set; }
    }


    [Serializable]
    public class RegisteredInvoiceNoWithSaveCheckGblInvReg : BaseModel
    {
        public IList<GblInvReg> LstGblInvReg { get; set; }
        public string UserId { get; set; }
        public string MenuId { get; set; }
        public byte DebugMode { get; set; }
        public string EnumType { get; set; }
    }


    [Serializable]
    public class PhysicalExaminationWithSaveCkMainRecieve : BaseModel
    {
        public IList<CkMain> LstCkMainInfo { get; set; }
        public string UserId { get; set; }
        public bool IsPhoneMessage { get; set; }
        public string LocationId { get; set; }
        public bool IsCkUseOtherPACS { get; set; }
    }


    [Serializable]
    public class PhysicalExaminationWithGetCkMainByOpertimeAndLsStatus : BaseModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int LsStatus { get; set; }
        public string PatientName { get; set; }
        public string TestGroupId { get; set; }
        public string CardNo { get; set; }
        public string CheckNo { get; set; }
        public string CkMainId { get; set; }
    }


    [Serializable]
    public class PhysicalExaminationWithSaveImportCompany : BaseModel
    {
        public IList<PhysicalExaminationWithImportCompany> LstAggregate { get; set; }
        public string CompanyId { get; set; }
        public string UserId { get; set; }
        public string ParametercompanyName { get; set; }
        public string ThisCompanyCkeckId { get; set; }
        public DateTime ControlCheckTime { get; set; }
    }


    [Serializable]
    public class PhysicalExaminationWithSaveToCkMainAndCkResult : BaseModel
    {
        public IList<CkResult> LstCkResult { get; set; }
        public OuHosInfo InfoOuHos { get; set; }
        public CkMain InfoCkMain { get; set; }
        public string PatiendId { get; set; }
        public string UserId { get; set; }
        public string LocationID { get; set; }
        public string DoctorId { get; set; }
    }


    [Serializable]
    public class UserWithCreatOuInvoiceReg : BaseModel
    {
        public OulInvoiceReg OulInvoiceReg { get; set; }
        public OuHosInfo OuHosInfo { get; set; }
        public string DoctorId1 { get; set; }
        public string UserId { get; set; }
        public string CurrInvoNo { get; set; }
        public string DoctorId2 { get; set; }
        public bool IsOuRegPrintInvoiceZero { get; set; }
        public string InvoLastId { get; set; }
        public int HospitalId { get; set; }
    }


    [Serializable]
    public class UserWithGetOuDocRegTypeList : BaseModel
    {
        public DateTime Week { get; set; }
        public string DoctorId { get; set; }
        public string LocationId { get; set; }
        public bool FuctionAccessPublic { get; set; }
        public bool FuctionAccessLocation { get; set; }
        public string SystemLocationId { get; set; }
        public string SystemDoctorId { get; set; }
    }


    [Serializable]
    public class UserWithSaveBsUserRelation : BaseModel
    {
        public BsUser BsUser { get; set; }
        public BsDoctor BsDoctor { get; set; }
        public IList<BsUserRole> LstBsUserRole { get; set; }
        public IList<BsUserRoom> LstBsUserRoom { get; set; }
        public IList<BsUserLocation> LstBsUserLocation { get; set; }
        public IList<BsUserHouse> LstBsUserHouse { get; set; }
        public byte[] BuffByte { get; set; }
        public bool IsDoctor { get; set; }
    }


    [Serializable]
    public class ItemWithCheckInAdviceNotBackDrugForm : BaseModel
    {
        public AdviceAuthDtl InfoUspInAdviceLong { get; set; }
        public IList<InDrugReqdtl> LstInDrugReqdtl { get; set; }
        public IList<InDrugReqBack> LstInDrugReqBack { get; set; }
        public string UserId { get; set; }
        public int HospitalId { get; set; }
    }

    [Serializable]
    public class TestSystemWithAuthCkLab : BaseModel
    {
        public string LabId { set; get; }

        public short LsStatus { set; get; }

        public string UserId { set; get; }

        public string AuthOperId { get; set; }

        public string CancelMemo { get; set; }

        public bool IsBack { set; get; }

        public UspCkPatientInfo UspCkPatientInfo { set; get; }
    }

    [Serializable]
    public class TestSystemWithSaveTestResultByBlood : BaseModel
    {
        public TestSystemWithAuthCkLab MyObject { get; set; }
        public IList<UspCkResultDtl> LstCkResultDtl { get; set; }
        public IList<UspLabResult> LstLabResult { get; set; }
        public string SourceId { get; set; }
        public string LabId { get; set; }
        public string UserId { get; set; }
        public string[] TogetherLabId { get; set; }
    }


    [Serializable]
    public class TestSystemWithGetCkLabByOpertimeAndLsStatus : BaseModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int LsStatus { get; set; }
        public string TestTypeId { get; set; }
        public string MachineId { get; set; }
        public int LsInOut { get; set; }
        public string LocationId { get; set; }
    }


    [Serializable]
    public class TestSystemWithGetCkLabByOpertimeAndLsStatusByLab : BaseModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int LsStatus { get; set; }
        public string TestTypeId { get; set; }
        public string MachineId { get; set; }
    }


    [Serializable]
    public class BloodTransfusionWithGetBloodBackPatient : BaseModel
    {
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string LabNum { get; set; }
        public string SerialNo { get; set; }
        public string PatName { get; set; }
    }




    [Serializable]
    public class BloodTransfusionWithGetBloodSend : BaseModel
    {
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string BloodType { get; set; }
        public string RegNo { get; set; }
        public string SerialNo { get; set; }
    }


    [Serializable]
    public class RecipWithIsNotDrugSend : BaseModel
    {
        public UspBed PatInfo { get; set; }
        public IList<InDrugReqdtl> LstAllInDrugReqdtl { get; set; }
        public bool IsAllowOutPatientDrugNotSend { get; set; }
        public bool IsLeaveHospitalNow { get; set; }
        public string UserId { get; set; }
    }


    [Serializable]
    public class RecipWithGetWestOuRecipeDtl : BaseModel
    {
        public IList<UspOuRecipeDtlInfo> LstUspOuRecipeDtl { get; set; }
        public IList<OuRecipeDtl> LstOuRecipeDtl { get; set; }
        public string OuRecipeId { get; set; }
        public string LocationId { get; set; }
        public string DoctorId { get; set; }
    }


    [Serializable]
    public class RecipWithCheckChineseRecipe : BaseModel
    {
        public IList<UspOuRecipeDtl> LstUspOuRecipeDtl { get; set; }
        public string FrequencyId { get; set; }
        public string LsCookSelfId { get; set; }
        public string UsageId { get; set; }
        public int CoctByHospital { get; set; }
        public int DecoctNum { get; set; }
        public double HowMany { get; set; }
    }


    [Serializable]
    public class RecipWithCheckOuRecipeWriteGoodRecipe : BaseModel
    {
        public IList<OuClincDiag> LstOuClincDiag { get; set; }
        public bool IsOuRecipeWriteGoodRecipe { get; set; }
        public string Content { get; set; }
        public bool IsOuRecipeWriteGoodRecipeForIllNess { get; set; }
    }


    [Serializable]
    public class RecipWithDelete : BaseModel
    {
        public List<UspOuRecipeDtl> LstUspOuRecipeDtl { get; set; }
        public OuRecipe OuRecipe { get; set; }
        public OuRecipeChin OuRecipeChin { get; set; }
        public int WestMedicine { get; set; }
        public int ChinaMedicine { get; set; }
        public int CheckCure { get; set; }
    }


    [Serializable]
    public class RecipWithTemporary : BaseModel
    {
        //WestRecip
        public int PagNo { get; set; }
        public int NextPage { get; set; }
        public int PrintRecipePageCount { get; set; }
        public string Order { get; set; }
        public Hashtable HtAllPageWestCount { get; set; }
        public Hashtable HtPageWestCount { get; set; }
        public string OuHosInfoId { get; set; }
        public IList<OuRecipeDtl> LstOuRecipeDtl { get; set; }
        public IList<OuRecipeDtl> LstWestRecipeDtl { get; set; }
        public IList<OuRecipeDtl> LstChineseRecipeDtl { get; set; }
        public IList<OuRecipeDtl> LstCheckRecipeDtl { get; set; }
        public IList<UspOuRecipeDtlInfo> LstUspOuRecipeDtl { get; set; }
        public OuRecipe OuRecipe { get; set; }
        public OuRecipe WestRecip { get; set; }
        public OuRecipe ChineseRecipe { get; set; }
        public OuRecipe CheckRecip { get; set; }
        public string LocationId { get; set; }
        public string DoctorId { get; set; }
        public string PatId { get; set; }
        public short LsRepType { get; set; }
        public string Where { get; set; }
        public short LsCookSelf { get; set; }
        public string OuRecipeId { get; set; }
        public int HospitalId { get; set; }
        public bool IsForCharge { get; set; }
        public short CookMinute { get; set; }
        public short DecoctNum { get; set; }
        public string FrequencyId { get; set; }
        public short LsFire { get; set; }
        public string UsageId { get; set; }
        public short WesternMedicine { get; set; }
        public string OuChinRoomId { get; set; }
        public string UserId { get; set; }
        public string Diagnose { get; set; }
        public OuClinicFirst InfoOuClinicFirst { get; set; }
        public short EnumRpTypeTest { get; set; }
        public short EnumRpTypeCheck { get; set; }
        public short EnumRpTypeOther { get; set; }
        public List<OuClincDiag> LstOuClincDiag { get; set; }
        public short ForPersonal { get; set; }
        public bool IsOuRegConfirmRegFee { get; set; }
        public bool IsOutWorkTime { get; set; }
        public string OutTimeRegTypeId { get; set; }
        public string RegTypeId { get; set; }
        public bool IsEmergency { get; set; }
        public BsPatient BsPatient { get; set; }
        public string Sensitive { get; set; }
        public string Weight { get; set; }
        public OuClinicFirst OuClinicFirst { get; set; }
        public OuClinicFirst PathFormOuClinicFirst { get; set; }

    }


    [Serializable]
    public class BodyHeatWithSaveInHosInfoAndInBabyBodyHeat : BaseModel
    {
        public InBabyBodyHeat InfoBabyBodyHeat { get; set; }
        public DateTime DtOperTime { get; set; }
        public string LocationId { get; set; }
        public bool IsChkHumanFeed { get; set; }
        public bool IsChkMotherFeed { get; set; }
        public int UbsStool { get; set; }
        public int UmbiliCal { get; set; }
        public string TimeQuantum { get; set; }
        public string UmbilicalExplain { get; set; }
        public string FecesExplain { get; set; }
        public bool IsInsert { get; set; }
    }


    [Serializable]
    public class RecipeExecuteWithGetOuRecipeDtlExecuteItems : BaseModel
    {
        public UspHisOuPatient HisOuPatient { get; set; }
        public List<UspOuExecutePrint> LstOuExecute { get; set; }
        public string MzRegId { get; set; }
        public string HisOuHosInfoId { get; set; }
        public string UserId { get; set; }
    }




    [Serializable]
    public class RdInfectiouWithGetRdInfectiousAuth : BaseModel
    {
        public int LsCancelType { get; set; }
        public int LsCardType { get; set; }
        public string LocationId { get; set; }
        public int AuthName { get; set; }
        public int LsWrite { get; set; }
        public int Write { get; set; }
        public string OperId { get; set; }
        public string Illnameid { get; set; }
        public bool IsPrintStart { get; set; }
        public string MzRegNo { get; set; }
        public string PatientName { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }

    }


    [Serializable]
    public class MedicalRecordWithRealeaseAll : BaseModel
    {
        public GblEMRCatalog InfoGblEMRCatalog { get; set; }
        public Dictionary<string, string> XmlNode { get; set; }
        public InEMR InfoInEMR { get; set; }
        public string HisInPatientText1Id { get; set; }
        public bool GetUndowithNeedOperatedField { get; set; }
        public string UserId { get; set; }
        public string CurrentCatalogId { get; set; }
        public string InEmrId { get; set; }
    }


    [Serializable]
    public class MedicalRecordWithSaveNew : BaseModel
    {
        public Dictionary<string, string> XmlNode { get; set; }
        public IList<InEMR> LstInEmr { get; set; }
        public InEMR InfoInEMR { get; set; }
        public string CurrentCatalogId { get; set; }
        public string HisInPatientText1Id { get; set; }
        public int FileNo { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string PatientName { get; set; }
        public string NodeName { get; set; }
        public bool IsProgressNote { get; set; }
    }


    [Serializable]
    public class MedicalRecordWithSaveTemp : BaseModel
    {
        public byte[] Temps { get; set; }
        public string UserId { get; set; }
        public string CurrentCatalogId { get; set; }
        public string UserCode { get; set; }
        public string Name { get; set; }
        public short EditValue { get; set; }
        public string LocationId { get; set; }
        public string IPAddress { get; set; }
        public string FileSize { get; set; }
    }


    [Serializable]
    public class DoctorWithGetListDocRegType : BaseModel
    {
        public string LocationId { get; set; }
        public string TimeSpanId { get; set; }
        public string RegTypeId { get; set; }
        public string DoctorId { get; set; }
        public int WeekDay { get; set; }

    }


    [Serializable]
    public class MedicalRecordWithOuHosInfoAndBsPatient : BaseModel
    {
        public BsPatient BsPatient { get; set; }
        public OuHosInfo OuHosInfo { get; set; }

    }


    [Serializable]
    public class AccountingWithCheckExecuted : BaseModel
    {
        public UspBed PatInfo { get; set; }
        public List<InDrugReqdtl> LstAllInDrugReqdtl { get; set; }
        public bool IsOut { get; set; }
        public string LocationId { get; set; }
        public int HospitalId { get; set; }
        public string UserCode { get; set; }
    }


    [Serializable]
    public class AccountingWithCheckLeaveHospitalNotDrug : BaseModel
    {
        public IList<InExecute> LstInExecuteNotDrug { get; set; }
        public UspBed PatInfo { get; set; }
        public string UserId { get; set; }
        public bool IsAllowOutPatientDrugNotSend { get; set; }
        public bool IsLeaveHospitalNow { get; set; }
    }


    [Serializable]
    public class AccountingWithGetInInvoiceDtlAuth : BaseModel
    {
        public string HospId { get; set; }
        public string LocationId { get; set; }
        public string ExecLocId { get; set; }
        public int LsMarkType { get; set; }
        public string DoctorId { get; set; }
        public string InvItemId { get; set; }
        public string ItemId { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string AdviceId { get; set; }
        public string Code { get; set; }
    }


    [Serializable]
    public class AccountingWithGetListCompanyOuInInvoice : BaseModel
    {
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public string InlocationId { get; set; }
        public string PatientName { get; set; }
        public string Company { get; set; }
        public string HosNo { get; set; }
        public string CardNo { get; set; }
        public int RadSelectIndex { get; set; }
        public int RadSelectAmountIndex { get; set; }
    }



    [Serializable]
    public class MedicalRecordWithGetInEmrSearch : BaseModel
    {
        public DateTime DtBegin { get; set; }
        public DateTime DtEnd { get; set; }
        public string LocationId { get; set; }
        public string OperId { get; set; }
        public string CatalogId { get; set; }
        public string XmlField { get; set; }
        public string XmlValue { get; set; }
        public bool IsAuth { get; set; }
        public string HospId { get; set; }
    }

    [Serializable]
    public class MedicalRecordWithGetEmrQualityControl : BaseModel
    {
        public string DoctorId { get; set; }
        public string LocationId { get; set; }
        public string InPatNoId { get; set; }
        public string BsEmrItemId { get; set; }
        public string ItemId { get; set; }
        public int RadLsOpenType { get; set; }
        public int UddStatus { get; set; }
        public string BsEmrItemText { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }


    [Serializable]
    public class InAdviceDrugWithSendInChinDrug : BaseModel
    {
        public IList<UspInChinDrugIssueDtl> LstUspInChinDrugIssueDtl { get; set; }
        public IList<BsLocation> LstBsLocation { get; set; }
        public InChinRicipe InChinRicipe { get; set; }
        public RmZyOut InfoRmZyOut { get; set; }
        public string RecipeId { get; set; }
        public string RoomId { get; set; }
        public string LocationId { get; set; }
        public string UserId { get; set; }
        public string[] SelectedRicipeId { get; set; }

    }


    [Serializable]
    public class InAdviceDrugWithBackInChinDrug : BaseModel
    {
        public IList<UspInChinDrugIssueDtl> LstUspInChinDrugIssueDtl { get; set; }
        public string RoomId { get; set; }
        public string UserId { get; set; }
        public string LocationId { get; set; }
        public string CancelMemo { get; set; }


    }




    [Serializable]
    public class PatientWithSaveUsgOutFromLocationNotRecieve : BaseModel
    {
        public string DragFromGrid { get; set; }
        public UspOutFromLocationNotRecieve UspOutFromLocationNotRecieve { get; set; }
        public bool GetToLocation { get; set; }
        public bool IsBedInModifyInTime { get; set; }
        public string UserId { get; set; }
        public string LeaveName { get; set; }
        public UspBed UspBed { get; set; }
    }

    [Serializable]
    public class BedModelList : BaseModel
    {
        public IList<InHosInfo> LstWaitForHospital { get; set; }
        public IList<InHosInfo> LstLeaveHospital { get; set; }
        public IList<InHosInfo> LstLeave { get; set; }
        public IList<UspOutFromLocationNotRecieve> LstUspOutFromLocationNotRecieve { get; set; }
        public IList<UspOutToLocationNotRecieve> LstUspOutToLocationNotRecieve { get; set; }
    }

    [Serializable]
    public class PatientWithSaveUsgOutToLocationNotRecieve : BaseModel
    {
        public UspOutToLocationNotRecieve UspOutToLocationNotRecieveQry { get; set; }
        public bool CheckEndAdviceLong { get; set; }
        public bool GetToLocation { get; set; }
        public string UserId { get; set; }
        public UspBed UspBed { get; set; }
        public string DragFromGrid { get; set; }
        public bool IsBedInModifyInTime { get; set; }
        public string LeaveName { get; set; }
    }


    [Serializable]
    public class PatientWithSaveUsgLeaveHospital : BaseModel
    {
        public bool IsCanAccessThisModule { get; set; }
        public InHosInfo InHosInfo { get; set; }
        public bool IsNurseCancelOutDoubleCheck { get; set; }
        public UspBed CurrentUspBed { get; set; }
        public string DragFromGrid { get; set; }
        public string UserId { get; set; }
        public string LeaveName { get; set; }
        public bool IsBedInModifyInTime { get; set; }
        public string ToLocationId { get; set; }
    }


    [Serializable]
    public class PatientWithSaveUsgLeave : BaseModel
    {
        public InHosInfo InHosInfo { get; set; }
        public UspBed CurrentUspBed { get; set; }
        public string LeaveName { get; set; }
        public string DragFromGrid { get; set; }
        public string ToLocationId { get; set; }
        public bool IsBedInModifyInTime { get; set; }
        public string UserId { get; set; }
    }


    [Serializable]
    public class PatientWithSaveUsgWaitForHospital : BaseModel
    {
        public InHosInfo InHosInfo { get; set; }
        public bool Islock { get; set; }
        public bool GetToLocation { get; set; }
        public string ToLocationId { get; set; }
        public bool IsBedInModifyInTime { get; set; }
        public string UserId { get; set; }
        public string LeaveName { get; set; }
        public string DragFromGrid { get; set; }
        public UspBed CurrentUspBed { get; set; }
    }


    [Serializable]
    public class PatientWithSaveGctBed : BaseModel
    {
        public UspBed UspBed { get; set; }
        public UspBed CurrentUspBed { get; set; }
        public bool IsChkAllowChage { get; set; }
        public bool IsClearBed { get; set; }
        public string DragFromGrid { get; set; }
        public string ToLocationId { get; set; }
        public bool IsBedInModifyInTime { get; set; }
        public string UserId { get; set; }
        public string LeaveName { get; set; }
        public int KeyState { get; set; }
    }



    [Serializable]
    public class MedicalRecordWithGetPatientEMRCatalogForNurse : BaseModel
    {
        public string GUID { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public int OrderBy { get; set; }
    }

    [Serializable]
    public class MedicalRecordWithDeleteItem : BaseModel
    {
        public InEMR InfoInEMR { get; set; }
        public bool IsProgressNote { get; set; }
        public string CurrentCatalogId { get; set; }
        public string HisInPatientText1Id { get; set; }
        public string CurrentId { get; set; }
        public byte[] Content { get; set; }
        public string Binary { get; set; }
    }


    [Serializable]
    public class MedicalRecordWithSaveCheckConfirm : BaseModel
    {
        public InEMR InfoInEmr { get; set; }
        public GblEMRCatalog GblEMRCatalog { get; set; }
        public string UserId { get; set; }
        public string CatalogId { get; set; }
        public string HospId { get; set; }
        public byte[] Binry { get; set; }
        public bool IsFindField { get; set; }
        public bool IsFindFieldTwo { get; set; }
        public bool IsFindFieldThr { get; set; }
    }


    [Serializable]
    public class PacsServiceWithSaveCkCompGroupPsApplyAndPsApplyReport : BaseModel
    {
        public PsApplyReport PsApplyReport { get; set; }
        public string CompanyGroupId { get; set; }
        public string MzRegId { get; set; }
        public string HosId { get; set; }
        public string HospId { get; set; }
        public string UserId { get; set; }
    }


    [Serializable]
    public class PacsServiceWithDeleteAndSavePsApplyReport : BaseModel
    {
        public PsApplyReport PsApplyReport { get; set; }
        public string CompanyGroupId { get; set; }
        public string MzRegId { get; set; }
        public string HosId { get; set; }
        public string HospId { get; set; }
        public string UserId { get; set; }
    }


    [Serializable]
    public class AccountingServiceWithInsertAccountItem : BaseModel
    {
        public string HospId { get; set; }
        public string AdviceId { get; set; }
        public string ItemId { get; set; }
        public double Totality { get; set; }
        public short LsPerform { get; set; }
        public string CancelId { get; set; }
        public string DoctorId { get; set; }
        public string LocationId { get; set; }
        public string ExecLocationid { get; set; }
        public double PriceIn { get; set; }
        public string ReqOperId { get; set; }
        public string OperId { get; set; }
        public short LsMarkType { get; set; }
        public string ExecOperId { get; set; }
        public DateTime RegOperTime { get; set; }
        public string RegDate { get; set; }
        public bool IsAutoCharged { get; set; }
    }


    [Serializable]
    public class VipWithOuHosVisitDynamic : BaseModel
    {
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public String PatientName { get; set; }
        public String CardNo { get; set; }
        public string DoctorId { get; set; }
        public string VipLevelId { get; set; }
        public String Illness { get; set; }
        public String History { get; set; }

    }


    [Serializable]
    public class VipWithOuHosVisitRecord : BaseModel
    {
        public DateTime FromTime { get; set; }

        public DateTime ToTime { get; set; }

        public String PatientName { get; set; }

        public String CardNo { get; set; }

        public string DoctorId { get; set; }

        public string VipLevelId { get; set; }

        public string OperId { get; set; }

        public int VisitType { get; set; }

        public int VisitStatus { get; set; }

    }


    [Serializable]
    public class SystemWithDynamicCondition : BaseModel
    {
        public string GUID { get; set; }
        public int LsGroupType { get; set; }
        public int LsRpType { get; set; }
        public bool IsActive { get; set; }
        public bool IsOnlyForSys { get; set; }
        public bool IsRpForbid { get; set; }
        public bool IsChildAdd { get; set; }
        public string UserName { get; set; }
        public string HouseId { get; set; }
    }



    //public class VisitWithGetListVisitOuHosInfo
    //{
    //    public DateTime BeginTime { get; set; }
    //    public DateTime EndTime { get; set; }
    //    public string PatientName { get; set; }
    //    public string CardNo { get; set; }
    //    public string DoctorId { get; set; }
    //    public string VipLevelId { get; set; }
    //    public string Illness { get; set; }
    //    public string History { get; set; }
    //}



    //public class VisitWithGetListVisitRecordOuHosInfo
    //{
    //    public DateTime BeginTime { get; set; }
    //    public DateTime EndTime { get; set; }
    //    public string PatientName { get; set; }
    //    public string CardNo { get; set; }
    //    public int LsVisitType { get; set; }
    //    public int LsVisitStatus { get; set; }
    //    public string OperId { get; set; }
    //}


    [Serializable]
    public class RecipeWithSaveSendOtherItemToRoom : BaseModel
    {
        public UspOuDrugIssue UspOuDrugIssue { get; set; }
        public string RecipeId { get; set; }
        public string RoomId { get; set; }
        public string PatId { get; set; }
        public string PatTypeId { get; set; }
        public string Printer { get; set; }
        public string CurrentBalanceNo { get; set; }
        public bool IsDosage { get; set; }
        public string UserId { get; set; }
        public string RecipePrinter { get; set; }
    }


    [Serializable]
    public class AccountingWithReturnSaveOuInvoiceDtlAndOuInvoicePay : BaseModel
    {
        public OuHosInfo InfoOuHosInfo { get; set; }
        public BsLocation InfoBsLocation { get; set; }
        public IList<OuInvoicePay> LstOuInvoicePay { get; set; }
        public IList<OuInvoiceDtl> LstOuInvoiceDtl { get; set; }

    }


    [Serializable]
    public class AccountingWithSaveOuInvoiceDtlAndOuInvoicePay : BaseModel
    {
        public IList<OuInvoicePay> LstOuInvoicePay { get; set; }

        public IList<OuInvoiceDtl> LstOuInvoiceDtl { get; set; }

        public OuHosInfo InfoOuHosInfo { get; set; }

        public OuInvoice InfoOuInvoice { get; set; }

        public string DoctorId { get; set; }

        public string UserId { get; set; }

        public string PatientName { get; set; }


        public IList<RmOutDtl> LstRmOutDtl { get; set; }
        public RmOut InfoRmOut { get; set; }
        public IList<Rmstores> LstRmStoreUpdate { get; set; }
    }

    [Serializable]
    public class PacsWithGetPsApplyReportSelectDynamic : BaseModel
    {
        public DateTime BeginTiem { get; set; }

        public DateTime EndTiem { get; set; }

        public string Equipment { get; set; }

        public int XType { get; set; }

        public string ApplyNo { get; set; }

        public string PatientName { get; set; }

        public string ReportOperName { get; set; }


    }



    [Serializable]
    public class ReportCardWithGetRdChronicInfo : BaseModel
    {
        public DateTime BeginTiem { get; set; }

        public DateTime EndTiem { get; set; }

        public string LocationId { get; set; }

        public string OperId { get; set; }

        public string LsChronicType { get; set; }

        public string PatientName { get; set; }

    }

    [Serializable]
    public class ReportCardWithGetSelectRdHurt : BaseModel
    {
        public DateTime BegInTime { get; set; }
        public DateTime EndTime { get; set; }
        public string LocationId { get; set; }
        public string OperId { get; set; }
        public string PatName { get; set; }
    }



    [Serializable]
    public class ReportCardWithGetRdReportPat : BaseModel
    {
        public DateTime BegInTime { get; set; }
        public DateTime EndTime { get; set; }
        public string LocationId { get; set; }
        public string OperId { get; set; }
        public int LsDiseaseType { get; set; }
        public string PatientName { get; set; }

    }

    [Serializable]
    public class ClinicalPathwayWithSaveDg : BaseModel
    {
        public string TypeName { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string IcdId { get; set; }
        public bool IsBaby { get; set; }
        public bool IsMen { get; set; }
        public bool IsOlder { get; set; }
        public bool IsWomen { get; set; }
        public string Memo { get; set; }
        public bool ChkIsBaby { get; set; }
        public bool ChkIsWomen { get; set; }
        public bool ChkIsMen { get; set; }
        public bool ChkIsOlder { get; set; }
        public string BsnessIll2 { get; set; }
        public string BsXdRp { get; set; }
    }

    [Serializable]
    public class RecipeWithGetFeeByUsage : BaseModel
    {
        public List<AdviceAuthDtl> LstOtherFeeQry { get; set; }
        public List<InAdviceGroup> LstInAdviceGroup { get; set; }
        public List<AdviceAuthDtl> LstCurrenAdvice { get; set; }
        public AdviceAuthDtl InfoRecipeDtl { get; set; }
        public HisInPatientQry InfoCurrHosInfo { get; set; }
        public double Times { get; set; }
        public string UserId { get; set; }
        public string LocationId { get; set; }
        public string PatTypeId { get; set; }
        public bool IsDiscountAoumt { get; set; }
    }


    [Serializable]
    public class AccountingWithCheckArrearAmount : BaseModel
    {
        public HisInPatientQry InPatientInfo { get; set; }
        public double ArrearAmount { get; set; }
        public double ArrearAmountLine { get; set; }
        public double AmountPay { get; set; }
        public double Remain { get; set; }
        public string LocationId { get; set; }
        public string PatTypeId { get; set; }
        public string SelfPatTypeId { get; set; }
    }


    [Serializable]
    public class RecipeWithDepartAdiveD : BaseModel
    {
        public IList<AdviceAuthDtl> LstAdviceRoll { get; set; }
        public IList<AdviceAuthDtl> LstAdviceNormal { get; set; }
    }


    [Serializable]
    public class RecipeWithGetUsageItem : BaseModel
    {
        public HisInPatientQry InfoCurrHosInfo { get; set; }

        public IList<AdviceAuthDtl> LstInitAdvice { get; set; }
        public HisInPatientQry HisInPatientQry { get; set; }
        public AdviceAuthDtl InfoRecipeDtl { get; set; }
        public double ContinueTimes { get; set; }
        public IList<BsItemAttach> LstAttach { get; set; }
        public List<AdviceAuthDtl> LstAdviceAuthDtl { get; set; }
        public List<BsLabSourceItem> LstBsLabSourceItem { get; set; }
        public List<BsLabSourceItem> LstSourceItem { get; set; }
        public IList<AdviceAuthDtl> LstCurrenAdvice { get; set; }
        public IList<AdviceAuthDtl> LstOtherFeeQry { get; set; }
        public IList<InAdviceGroup> LstInAdviceGroup { get; set; }
        public string InjectUsageRollFee { get; set; }
        public string InjectUsageRollFeeLocationIds { get; set; }
        public string LocationId { get; set; }
        public int HospitalID { get; set; }
        public string UserId { get; set; }
        public DateTime dtBeginTime { get; set; }
        public bool IsDiscountAoumt { get; set; }
        public string PatTypeId { get; set; }
        public bool IsBaby { get; set; }
        public string ItemId { get; set; }
        public double Times { get; set; }
        public bool IsLoadBsItem { get; set; }
        public string SourceMemo { get; set; }
        public string SourceIds { get; set; }
        public string TestTypeIds { get; set; }
        public string TubeTypeIds { get; set; }
    }


    [Serializable]
    public class RecipeWithReturnGetUsageItem : BaseModel
    {
        public AdviceAuthDtl NewInInvoiceDtlQry { get; set; }
        public IList<AdviceAuthDtl> LstAdviceRoll { get; set; }
        public IList<AdviceAuthDtl> LstAdviceNormal { get; set; }
        public IList<BsItemAttach> LstBsItemAttach { get; set; }
        public virtual string ItemId { get; set; }


        public IList<BsLabSourceItem> LstSourceItem { get; set; }

        public AdviceAuthDtl AdviceAuthDtl { get; set; }

        public string SourceMemo { get; set; }

        public string SourceIds { get; set; }

        public string TestTypeIds { get; set; }

        public string TubeTypeIds { get; set; }
    }

    [Serializable]
    public class RecipeWithDeleteGroup : BaseModel
    {
        public IList<AdviceAuthDtl> LstCurrenAdvice { get; set; }
        public IList<AdviceAuthDtl> LstDeleteAdviceAuthDtl { get; set; }
    }




    [Serializable]
    public class LoginWithUser : BaseModel
    {
        
        public BsUser BsUser { get; set; }
        public string HuItemName { get; set; }
        public IList<BsLocation> LstLocation { get; set; }
    }





    [Serializable]
    public class RecipeWithReturnCancelConfirm : BaseModel
    {
        public string HospId { get; set; }
        public int SelectCount { get; set; }
        public string NamesShow { get; set; }
        public IList<AdviceAuthDtl> LstAdviceAuthDtl { get; set; }

    }

    [Serializable]
    public class AccountWithCreateOulInvoiceReg : BaseModel
    {
        public string CardNo { get; set; }
        public string RegTypeId { get; set; }
        

    }


    [Serializable]
    public class PatientWithGetHisOuPatientDynamic : BaseModel
    {
        public int RegDept { get; set; }
        public string SpecialityId { get; set; }
        public string RegTypeId { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string DoctorId { get; set; }
        public string CommonDoctorId { get; set; }
        public int HospitalId { get; set; }
        public string MzRegId { get; set; }
        public string CardNo { get; set; }
    }

    [Serializable]
    public class ChargeReportWithType : BaseModel
    {
        public int Type { get; set; }
        public string Name { get; set; }
        public short LsOutOrIn { get; set; }
        public short OrderBy { get; set; }
        public string ReportId { get; set; }

    }


    [Serializable]
    public class TestSystemWithToAuto : BaseModel
    {
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string TestTypeId { get; set; }
        public string MzRegId { get; set; }
        public string HospId { get; set; }
        public string TestId { get; set; }
        public string SpecialityId { get; set; }
        public string DoctorId { get; set; }
        public int LsStatus { get; set; }
        public int LsSource { get; set; }
        public string LabNum { get; set; }
        public string CardNo { get; set; }
        public string PatientName { get; set; }
        public int LsCancel { get; set; }
        public string MzRegNo { get; set; }

    }



    [Serializable]
    public class PatienWithSaveBsPatientAndOuHos : BaseModel
    {
        public BsPatient BsPatient { get; set; }
        public OuHosInfo OuHos { get; set; }
    }



    [Serializable]
    public class PatienWithSaveInHosMzIllAndHisba4 : BaseModel
    {
        public IList<InHosMzIll> LstInHosMzIll { get; set; }
        public IList<HISBA4> LstHISBA4 { get; set; }
    }



    [Serializable]
    public class PatientWithYbMt : BaseModel
    {
        public string InPatNo { get; set; }
        public string LocationID { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Name { get; set; }
        public bool IsHide { get; set; }
    }



    [Serializable]
    public class BalanceWithReturnSaveInInvoiceInvItemSumAndInInvoice : BaseModel
    {
        public IList<InInvoiceInvItemSum> LstInInvoiceInvItemSum2 { get; set; }

        public InInvoice InfoInInvoice2 { get; set; }
    }


    [Serializable]
    public class BalanceWithSaveInInvoiceInvItemSumAndInInvoice : BaseModel
    {
        public IList<InInvoiceInvItemSum> LstInInvoiceInvItemSum2 { get; set; }
        public int HospitalId { get; set; }
        public string UserId { get; set; }
        public string PatTypeId { get; set; }
        public string PatientId { get; set; }
        public double Beprice { get; set; }
        public double Insurance { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string InvoNo { get; set; }
        public short LsPayType { get; set; }
        public int Article { get; set; }
        public string CancelOperID { get; set; }
    }


    [Serializable]
    public class InHosWithIntroducer : BaseModel
    {
        public DateTime beginTime { get; set; }
        public DateTime endTime { get; set; }
        public string LocIn { get; set; }
        public int LsInStatus { get; set; }
        public string PatTypeId { get; set; }
        public string InPatNo { get; set; }
        public string LinkmanArea { get; set; }
    }


    [Serializable]
    public class PatientWithTopOneCall : BaseModel
    {
        public string GUID { get; set; }
        public string PatName { get; set; }
        public string Address { get; set; }
    }


    [Serializable]
    public class BPItemWithGetItemName : BaseModel
    {
        public string GUID { get; set; }
        public string ItemName { get; set; }
        public string PY { get; set; }
        public string WB { get; set; }
    }


    [Serializable]
    public class InFirstPageWithSaveRecFirstPage : BaseModel
    {
        public InRecFirstPage InRecFirstPage { get; set; }
        public InHosInfo InHosInfo { get; set; }
        public IList<InHosOps> LstInHosOps { get; set; }
        public IList<InHosMzIll> LstInHosMzIll { get; set; }
        public BsPatient BsPatient { get; set; }
    }

    [Serializable]
    public class RecipeAgreementWithGetBsXdRp : BaseModel
    {
        public bool IsOut { get; set; }
        public string SearchCode { get; set; }
        public string Name { get; set; }
        public string LsRpType { get; set; }
        
        public bool IsForCharge { get; set; }
    }

    [Serializable]
    public class BalanceWithSaveMergeBabyFee : BaseModel
    {
        public IList<InHosInfo> lstInHosInfo { get; set; }
        public bool isOut { get; set; }
        public string HospId { get; set; }
        public string userId { get; set; }
        public string adminRoleId { get; set; }
        public string paramLocationId { get; set; }
        public string paramHospId { get; set; }
        public string operId { get; set; }
        
    }


    [Serializable]
    public class PatientWithInHosEditInPatNo : BaseModel
    {
        public InHosInfo InfoInHosInfo { get; set; }
        public string ToInPatNo { get; set; }
        public IList<InHosInfo> LstSameInPatNoInHosInfo { get; set; }
        public IList<BsPatient> LstPatient { get; set; }
        public UspInHosInfo InfoUspInHos { get; set; }
        public string InitPatId { get; set; }
    }

    [Serializable]
    public class BalanceWithSaveInBalance : BaseModel
    {
        public IList<InInvoiceDtl> LstInInvoiceDtl { get; set; }
        public IList<InInvoiceDtlChk> LstInInvoiceDtlChk { get; set; }
        public IList<UspInvoiceFeetyGoupSum> LstuspInvoiceFeetyGoupSumQry { get; set; }
        public IList<UspInInvoiceInvItemGoupSum> LstuspInInvoiceInvItemGoupSumQry { get; set; }
        public IList<InDeposit> LstInDeposit { get; set; }
        public InInvoice InInvoice { get; set; }
        public YbPatSeq YbPatSeq { get; set; }
        
        public string PatId { get; set; }
        public string PatTypeId { get; set; }
        public string HospLastId { get; set; }
        public string InvoLastId { get; set; }
        public string ZyClassName { get; set; }
        public InInvoYB InInvoYb { get; set; }
        public bool IsOut { get; set; }

        public bool IsYb { get; set; }
    }


    [Serializable]
    public class BalanceWithGetIninvoicedtlUmp : BaseModel
    {
        public string Hospid { get; set; }
        public string Locationid { get; set; }
        public string Invitemid { get; set; }
        public string Itemid { get; set; }
        public string Doctorid { get; set; }
        public string Execlocid { get; set; }
        public int Lsmarktype { get; set; }
        public string Adviceid { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Code { get; set; }
        public int LsStatus { get; set; }

    }


    [Serializable]
    public class InAdviceDrugWithGetUspInPatientNotEnough : BaseModel
    {

        public string SpecialityId { get; set; }
        public string LocationId { get; set; }
        public string PatTypeId { get; set; }
        public int LsInStatus { get; set; }
        public string HospId { get; set; }
        public string BedId { get; set; }
    }

    [Serializable]
    public class RegisteredInvoiceNoWithGetOuInvoiceInfomation : BaseModel
    {
        public List<UspOuInvoiceInvItemGoupSum> LstUspOuInvoiceInvItemGoupSum { get; set; }
        public List<UspOuInvoiceFeetyGoupSum> LstOuInvoiceFeetyGoupSum { get; set; }
        public List<UspOuInvoiceDtl> LstOuInvoiceDtl { get; set; }
        public string AllOuRoomId { get; set; }
    }


    [Serializable]
    public class RecipeAgreementWithRollBack : BaseModel
    {
        public string Text { get; set; }
        public string ReportSeq { get; set; }
        public string OperatorId { get; set; }
        public int HospitalId { get; set; }
        public DateTime EndDate { get; set; }
    }

    [Serializable]
    public class BsItemWithGetBsItemMini : BaseModel
    {
        public string LsRpType { get; set; }
        public int LsInOut { get; set; }
        public bool IsStore { get; set; }
        public string RoomId { get; set; }
        public string HouseId { get; set; }
        public bool IsShowCtrF { get; set; }
        public bool IsActive { get; set; }
        public bool IsRpForbid { get; set; }

        /// <summary>
        /// 0--非毒麻药品 1--毒麻药品 2--全部
        /// </summary>
        public int LsPoison { get; set; }
    }


    [Serializable]
    public class BsItemWithGetUspBsItemSelect : BaseModel
    {
        public string InputCode { get; set; }
        public string PatTypeID { get; set; }
        public string LocationID { get; set; }
        public string lsRpType { get; set; }
        public bool IsStore { get; set; }
        public int LsInOut { get; set; }
        public bool IsActive { get; set; }
        public bool IsRpForbid { get; set; }
        public string GUID { get; set; }
        public bool IsUserInputWB { get; set; }
        public bool IsUserInputPY { get; set; }
        public bool IsUserInputCode { get; set; }
        public bool IsUserInputName { get; set; }
        public bool IsUserInputStrokeCode { get; set; }
        public bool IsUserInputEngDesc { get; set; }
        public bool IsUserInputF1 { get; set; }
        public string RoomId { get; set; }
        public string HouseId { get; set; }
        public bool IsInPutNB { get; set; }

        /// <summary>
        /// 0--非毒麻药品 1--毒麻药品 2--全部
        /// </summary>
        public int LsPoison { get; set; }
    }


    [Serializable]
    public class PatientWithGetHisInPatientInfo : BaseModel
    {
        
        public string HospId { get; set; }
        public string DoctorId { get; set; }
        public int[] LocationCode { get; set; }
        public string InputCardNo { get; set; }
        public string SearchFiled { get; set; }
        public bool IsEmrUse { get; set; }
        public bool IsLimitHasBed { get; set; }
        public bool IsFilterBase { get; set; }
        public bool CheckIsBaby { get; set; }
        public bool CheckIsMom { get; set; }
        public bool IsUseMiniCard { get; set; }
        public EnumInStatus[] IsInstatus { get; set; }

    }


    [Serializable]
    public class PatientWithHisInPatient : BaseModel
    {
        public IList<VwInHosInfoSelectDynamic> LstVwInHosInfoSelectDynamic { get; set; }
        public string LocationArraystring { get; set; }

    }


    [Serializable]
    public class ClinicalPathwayWithGetDgRoadPat : BaseModel
    {
        public DgRoadPat DgRoadPat { set; get; }
        public string Dgroadmessage { set; get; }
    }


    [Serializable]
    public class AccountingWithSavePatientOuHosInfo : BaseModel
    {
        public UserWithCreatOuInvoiceReg CreatOuInvoiceReg { set; get; }
        public string CaiWuCancelOperId { set; get; }
        public string MenuId { set; get; }
        public string MzRegId { set; get; }
        public bool IsCheck { set; get; }
        public bool IsCanRoleLocation { set; get; }
        public double LastFactGet { set; get; }
        public BsPatient BsPatient { set; get; }
        

        public bool ChkCallOrderChecked { set; get; }
    }


    [Serializable]
    public class AccountingWithSaveRegisterInfo : BaseModel
    {
        public string MenuId { set; get; }
        public string InvLastId { set; get; }
        //public string MzRegId { set; get; }
        public bool IsCheck { set; get; }
        public OuLeadReg InfoOuLeadReg { set; get; }
        public OuHosInfo OuHosInfo { set; get; }
        public BsPatient BsPatient { set; get; }
        

        public BsPatient bsPatientInfo { set; get; }
        public bool chkCallOrderChecked { set; get; }
    }



    [Serializable]
    public class BusinessWithGetBsItemPatTypeAndInInvoiceDtlChkByHospId : BaseModel
    {
        public OuInvoice InfoOuInvoice { set; get; }
        public IList<OuInvoiceDtl> LstOuInvoiceDtl { set; get; }
        public IList<BsItemPatType> LstBsItemPatType { set; get; }
        public IList<InInvoiceDtl> LstInInvoiceDtl { set; get; }
        public IList<UspInInvoiceDtlChkByHospId> LstInInvoiceDtlChkByHospId { set; get; }
        public string PatTypeId { set; get; }
        public string PatientId { set; get; }
    }

    [Serializable]
    public class SystemWithCheckInStockNumIsEnough : BaseModel
    {
        public double AdviceNum { set; get; }
        public int RoomType { set; get; }
        public int InOut { set; get; }
        public string ItemId { set; get; }
        public int HospitalId { set; get; }
        public string Name { set; get; }
    }


    [Serializable]
    public class AdviceLongWithInAdviceLongAndRecipe : BaseModel
    {
        public IList<InAdviceLong> lstInAdviceLong { set; get; }

        public IList<InAdviceTemp> lstInAdviceTemp { set; get; }
    }


    [Serializable]
    public class AccountingWithSaveOuBalance : BaseModel
    {
        public string MzRegId { set; get; }
        public string DoctorId { set; get; }
        public string DiagnDept { set; get; }
        public string LocationId { set; get; }
        public string PatId { set; get; }
        public string CheckId { set; get; }
        public string PatTypeId { set; get; }
        public string MzRegLastId { set; get; }
        public string MenuId { set; get; }
        public string InvoLastId { set; get; }
        public string IntegraPayWayId { set; get; }
        public string vipCardPayWayId { set; get; }
        public string InvoNo { set; get; }
        //public double IntegralRate { set; get; }
        public double amount { set; get; }
        public double dblDrugNum { set; get; }
        public double ReAmount { set; get; }
        public bool IsEnabledVIP { set; get; }
        public bool IsUseYB { set; get; }
        public bool IsCharge { set; get; }
        public string ReAmountMemo { set; get; }
        public OuInvoice OuInvoice { set; get; }
        
        public VipCard VipCard { set; get; }
        public UspHisOuPatient uspHisOuPatient { set; get; }
        public IList<UspOuInvoiceDtl> LstUspOuInvoiceDtl { set; get; }
        public IList<UspOuInvoiceFeetyGoupSum> LstUspOuInvoiceFeetyGoupSumQry { set; get; }
        public IList<OuInvoiceInvItemSum> LstInvItemSum { set; get; }
        public IList<OuInvoicePay> LstOuInvoicePay { set; get; }
        public IList<UspOuRecipeDtlForOuInvoiceDtl> LstUspOuRecipeDtlForOuInvoiceDtl { set; get; }
        public IList<UspOuInvoiceDtl> TempSendDrugDtl { set; get; }
        public IList<ComputeSummary> LstSendRoom { set; get; }
        public List<OuRecipeDtl> LstCheckRecipeDtl { set; get; }
        public IList<ComputeSummary> LstOuCkeckItem { get; set; }

    }

    [Serializable]
    public class RecipeWithSaveReicipeDtl : BaseModel
    {
        public UspHisOuPatient Value { set; get; }

        /// <summary>
        /// true表示收费保存,false表示挂起保存
        /// </summary>
        public bool IsCharge { set; get; }

        /// <summary>
        /// 附加项目集合
        /// </summary>
        public IList<UspOuInvoiceDtl> LstHasAttach { set; get; }

        /// <summary>
        /// FormBase.MenuId  -- Key
        /// </summary>
        public string MenuId { set; get; }

        

        /// <summary>
        /// 检查/治疗
        /// </summary>
        public List<OuRecipeDtl> LstCheckRecipeDtl { get; set; }

        public OuInvoice InfoOuInvoiceDto { get; set; }

        public IList<UspOuInvoiceDtl> LstUspOuInvoiceDtl { get; set; }

        /// <summary>
        /// 西药
        /// </summary>
        public List<OuRecipeDtl> LstWestRecipeDtl { get; set; }

        /// <summary>
        /// 中药
        /// </summary>
        public IList<OuRecipeDtl> LstChineseRecipeDtl { get; set; }

        public IList<UspOuRecipeDtl> LstUspChineseRecipeDtl { get; set; }

        public bool IsDoubleCharged { get; set; }
        /// <summary>
        /// “凑整费”的ItemId
        /// </summary>
        public string IntegralItemId { get; set; }

        public IList<OuRecipe> LstChineseRecipe { get; set; }

        public IList<UspOuInvoiceDtl> LstSelfDrug { get; set; }
    }

    [Serializable]
    public class AccountingWithSaveOuBalanceOut : BaseModel
    {
        public string InvoLastId { set; get; }
        public string MasterId { set; get; }
        public List<OuInvoicePay> LstOuInvoicePay { set; get; }
        public OuHosInfo InfoOuHosInfo { set; get; }
        public RecipeWithSaveReicipeDtl recipeWithSaveReicipeDtl { set; get; }
    }

    [Serializable]
    public class BalanceWithCalculateInvoiceAmount : BaseModel
    {
        public double Beprice { set; get; }
        public double FactGet { set; get; }
        public double PaySelf { set; get; }
        public double amountPay { set; get; }
        public double YbTally { set; get; }

        public string InHosId { set; get; }
        public string PatTypeId { set; get; }

    }

    [Serializable]
    public class SystemWithSavePacsInterface : BaseModel
    {
        public IList<BsItemPacs> lstBsItemPacs { set; get; }
        public IList<PsApplyReport> lstPsApplyReport { set; get; }
        public BsLocation bsLocation { set; get; }
        public BsPatient bsPatient { set; get; }
    }

    [Serializable]
    public class BalanceWithInvoiceAmount : BaseModel
    {
        public InInvoice inInvoice { set; get; }
        public InHosInfo inHosInfo { set; get; }
        public double amountPay { set; get; }
    }



    public class HuRmCommonServiceWithRecipeBack : BaseModel
    {
        public RmBack RmBack { set; get; }
        public IList<Rmstores> lstRmstore { set; get; }
        public OuRecipe OuRecipe { set; get; }
    }


    public class PatientWithSaveRoadPat : BaseModel
    {
        public string HosId { set; get; }
        public string RoadId { set; get; }
        
        public DateTime dtCh { set; get; }
        public List<DgRoadPatDtl> LstDgRoadPatDtl { set; get; }
        public List<DgDayGroupPat> LstDgDayGroupPat { set; get; }
    }

    public class SystemWithSaveEmailUser : BaseModel
    {
        public IList<GblEmailUser> lstGblEmailUser { set; get; }
        public string emailId { set; get; }
    }



    public class PatientWithAddLastLeadMzIllOut : BaseModel
    {
        public UspInHosInfo InfoUspInHos { set; get; }
        public List<InHosMzIll> LstInHosMzIll { set; get; }
    }


    public class HuRmCommonServiceWithGetBillNoDetails : BaseModel
    {
        public IList<UspHuOutDtl> LstHuOutDtl { get; set; }
        public IList<UspRmApplbackDtl> LstRmApplbackDtl { get; set; }
    }



    public class ClinicalPathwayServiceWithSavaAdvice : BaseModel
    {
        public string HospId { get; set; }
        public string PatId { get; set; }
        public string DayGroupID { get; set; }
        public string TodayTag { get; set; }
        
        public InDgRoadMemo InfoMemo { get; set; }
        public IList<UspDgRoadPageDtl> LstVUspDgRoadPageDtl { get; set; }
        public IList<InDgRoadMemo> LstInDgRoadMemo { get; set; }
    }


    public class InAdviceDrugWithUYbCodeFor : BaseModel
    {
        public List<UspInInvoiceDtlChkByHospId> LstUspInInvoiceDtlChkByHospId { get; set; }
        public List<BsItemIllType> LstBsItemIllType { get; set; }
        public string PatTypeId { get; set; }
        public string TallyGroupId { get; set; }
    }




    public class RecipeWithGetInPatientLstFroServe : BaseModel
    {
        public List<VwInHosInfoSelectDynamic> LstNoConfirm { get; set; }
        public List<VwInHosInfoSelectDynamic> LstConfirm { get; set; }
    }





    public class RegisteredInvoiceNoWithGetInvoiceInfoOut : BaseModel
    {
        public IList<UspInBalanceDtlQry> LstUspInBalanceDtl { get; set; }
        public IList<UspInBalanceDtlQry> LstOutUspInBalanceDtl { get; set; }
        public IList<InInvoiceDtlChk> LstInInvoiceDtlChkInfo { get; set; }
        public IList<UspInvoiceFeetyGoupSum> LstuspInvoiceFeetyGoupSumQry { get; set; }
        public IList<UspInInvoiceInvItemGoupSum> LstuspInInvoiceInvItemGoupSumQry { get; set; }
        public IList<InDeposit> LstInDeposit { get; set; }
        public IList<InPay> LstInPay { get; set; }

    }




    public class RecipeExecuteWithSaveSkinResult : BaseModel
    {
        public IList<UspOuExecutePrint> LstOuExecute { get; set; }
        public int RowIndex { get; set; }
        public OuExecuteDtl InfoOuExecuteDtl { get; set; }
        public string FrmShowMemo { get; set; }
        public string DoctorId { get; set; }
        public string MzRegNo { get; set; }
        public string PatientName { get; set; }
        public string StrReuslt { get; set; }

    }



    public class CallOuServiceWithSaveOuDiagCall : BaseModel
    {
        public OuDiagCall InfoOuDiagCall { get; set; }
        public string DocCallAddress { get; set; }

    }


    public class MedicalRecordServiceWithSaveMedicalRecord : BaseModel
    {
        public string NodeName { get; set; }
        public InEMR InfoInEMR { get; set; }
        public string PatientName { get; set; }
        public string StrType { get; set; }
        public string StrTitle { get; set; }
        
    }




    public class AccountingWithSaveOuInvoice : BaseModel
    {
        public IList<OuInvoicePay> LstOuInvoicePay { get; set; }
        public string UserId { get; set; }
        public string PatName { get; set; }
        public string DoctorId { get; set; }
        public IList<OuInvoiceDtl> LstOuInvoiceDtl { get; set; }
        public OuHosInfo OuHosInfo { get; set; }

        
    }


    public class BandedWithBandedGridViewMain : BaseModel
    {
        public RdNewBirth InfoRdNewBirth { get; set; }
        public BsPatient InfoBsPatientByMom { get; set; }
        public BsBed InfoBedByMom { get; set; }
        public InHosInfo InfoInHosInfoByBaBy { get; set; }
        public BsBed InfoBedByBaby { get; set; }
        public InHosInfo InfoInHosInfoByMom { get; set; }
        public UspInHosInfoDynamic2 InfoUspInHosInfoQry { get; set; }

        public string menuId { get; set; }
        public string title { get; set; }
        public string userId { get; set; }
        public byte debugMode { get; set; }
    }



    public class BusinessCommonWithLocationFilter : BaseModel
    {
        public List<string> FilterId { get; set; }
        public string LocationId { get; set; }
        public bool IsOutWorkTime { get; set; }

    }


    public class PacsWithListPsApplyReportInfoQryData : BaseModel
    {
        public IList<UspPsApplyReport> LstUspPsApplyReportInfoQry { get; set; }
        public IList<UspPsApplyReport> LstReportedData { get; set; }
        public IList<UspPsApplyReport> LstAuditData { set; get; }
    }



    public class PacsWithListPsNearAreaFile : BaseModel
    {
        public IList<PsNearAreaFile> LstPsNearAreaFile { get; set; }
        public BsModalityStation InfoBsModalityStation { get; set; }
    }



    public class PsApplyReportWithBsPatientPSApplyItem : BaseModel
    {
        public PsApplyReport InfoPsApplyReport { get; set; }
        public BsPatient InfoBsPatient { get; set; }
        public IList<PSApplyItem> LstPSApplyItem { set; get; }
        public IList<PsApplyReport> LstPsApplyReportHistory { set; get; }
    }

    public class PsApplyReportWithPsApplyReportAndPSApplyItem : BaseModel
    {
        public PsApplyReport InfoPsApplyReportHistory { get; set; }
        public IList<PSApplyItem> LstPSApplyItemHistory { get; set; }
    }



    public class PatientWithListRecFirstPateAndInOutLocation : BaseModel
    {
        public InRecFirstPage LnfoRecFirstPage { set; get; }
        public IList<InOutLocation> LstInOutLocation { set; get; }
    }



    public class AccountingWithDelectOuInvoiceDtlAndOuRecipeDtlByDB : BaseModel
    {
        public bool DelteAll { get; set; }
        public UspOuInvoiceDtl selectRowOuInvoiceDtl { get; set; }
        public IList<int> lstRecipeItemIdByXdRpId { get; set; }
        public string funtionId { get; set; }
        
        public string menuId { get; set; }
        public string title { get; set; }
    }



    public class OutLocationWithGetInOutLocation : BaseModel
    {
        public HisInPatientQry infoPatientQry { get; set; }
        public string ValueId { get; set; }
        public string ValuePatientName { get; set; }
        public string ValueInPatNo { get; set; }
        
    }



    public class PatientWithCheckInfoOuHos : BaseModel
    {
        public OuHosInfo InfoOuHos { get; set; }
        public BsPatient BsPatient { get; set; }
        public bool IsPatientNeedMobileInput { get; set; }
        public bool IsDoctor { get; set; }
        public int AgesWriteLinkmanName { get; set; }
    }


    public class ReadWithReadUnbindData : BaseModel
    {
        public ToolbarStatus toolbarStatus { get; set; }
        public BsBed InfoBedByBaby { get; set; }
        public RdNewBirth InfoRdNewBirth { get; set; }
        public DateTime calBirthdayBirthday { get; set; }
        public BsPatient InfoBsPatientByBaby { get; set; }

        public BsPatient InfoBsPatientByMom { get; set; }
        public InHosInfo InfoInHosInfoByBaBy { get; set; }
        public InHosInfo InfoInHosInfoByMom { get; set; }
        
    }



    public class AccountingWithLastId : BaseModel
    {
        public string InvoLastId { get; set; }
        public string MzRegLastId { get; set; }
        public OuInvoice InfoOuInvoice { get; set; }
    }



    public class PatientWithOpenProgressNoteInfo : BaseModel
    {
        public string PatientId { get; set; }
        public InEMR InfoInEMR { get; set; }

        public InEMR InfoInEmrOfFirst { get; set; }
        public string NodeName { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        
        public int IP { get; set; }
    }



    public class BodyHeatWithInOuLocation : BaseModel
    {
        public bool IsInOuLocation { get; set; }
        public string BedName { get; set; }
        public string LocationName { get; set; }
        public string BedId { get; set; }

    }


    public class LocationWithGetListBy : BaseModel
    {
        public IList<InOutLocation> LstInOuLocation { get; set; }
        public IList<InAdviceLong> LstLog { get; set; }
        public BsPatient InfoBsPatient { get; set; }
        public IList<BsLocation> LstBsLocation { get; set; }
        public IList<BsItem> LstBsItem { get; set; }


    }


    public class LocationWithGetid : BaseModel
    {
        public string PatID { get; set; }
        public string HospId { get; set; }
        public IList<string> LstInExecuteIds { set; get; }
    }


    public class PatientWithInHosEditStringInPatNo : BaseModel
    {
        public InHosInfo inHosInfo { get; set; }
        public string toInPatNo { get; set; }
        public IList<InHosInfo> lstSameInPatNoInHosInfo { get; set; }
        public IList<BsPatient> lstPatient { get; set; }
        public UspInHosInfo uspInHosInfo { get; set; }
        public string initPatId { get; set; }
    }



    public class InAdviceDrugWithGetNTime : BaseModel
    {
        public IList<BsPatient> LstBsPatient { get; set; }
        public List<InHosInfo> LstInHosInfo { get; set; }
        public InHosInfo InHosInfo { get; set; }
        public string ToInPatNo { get; set; }
    }



    public class AccountingWithSetTxtRoomMemo : BaseModel
    {
        public bool IsRePrintOuInvoice { get; set; }
        public List<BsRoomWindow> LstBsRoomWindow { get; set; }
        public string MemoString { get; set; }
        public string AllOuRoomId { get; set; }
        public string YFTarcerId { get; set; }
        public string TarcerId { get; set; }
        public string RecordId { get; set; }
        public string UserId { get; set; }
        public int IP { get; set; }
        public OuInvoice OuInvoice { get; set; }
    }



    public class PacsServiceWithSaveModifyTrace : BaseModel
    {
        public string Name { get; set; }
        public BsPatient InfoBsPatient { get; set; }
        public IdentityInformation Birthday { get; set; }
        public OuHosInfo InfoOuHos { get; set; }
        
    }



    public class BsPatientWithCheckBsPatient : BaseModel
    {
        public OuHosInfo InfoOuHos { get; set; }
        public BsPatient InfoBsPatient { get; set; }
    }



    public class LocationWithInOutLocation : BaseModel
    {
        public string ValueId { get; set; }
        public string PatientName { get; set; }
        public string InPatNo { get; set; }
        
        public string menuId { get; set; }
        public string title { get; set; }
        public string userId { get; set; }
        public byte debugMode { get; set; }
    }



    public class OuDocSpanSubWithLoadDocRegTypeInfo : BaseModel
    {
        public bool InNo { get; set; }
        public IList<OuDocSpanSub> LstOuDocSpanSub { get; set; }
    }





    public class BsPatientWithCheckPatId : BaseModel
    {
        public OuHosInfo InfoOuHos { get; set; }
        public BsPatient InfoBsPatient { get; set; }
    }

    public class BsPatientWhitGetInitData : BaseModel
    {
        public bool IsClinical { get; set; }
        public BsPatient infoBsPatient { get; set; }
    }


    public class AccountingWithCalcuateAmountTally : BaseModel
    {
        public IList<UspOuInvoiceDtlPatientToday> LstUspOuInvoiceDtlPatientToday { get; set; }
        public OuInvoice InfoOuInvoice { get; set; }
        public IList<UspOuInvoiceDtl> LstUspOuInvoiceDtl { get; set; }
        public string TallyNo { get; set; }
        public string TallyGroupId { get; set; }
        public int LimitTop { get; set; }
        public string PatTypeId { get; set; }
        public bool IsYb { get; set; }
        public bool IsUpYb { get; set; }
        public int InTintNumber { get; set; }
        public bool IsInTintType { get; set; }
        public bool IsGf { get; set; }
    }

    public class InHosInfoWithHosInfoAndBsItem : BaseModel
    {
        public InHosInfo InHosInfo { get; set; }
        public BsItem InfoBsItem { get; set; }
    }





    public class AccountingWithSendCLToRoom : BaseModel
    {
        public string CurrentBalanceNo { get; set; }
        public string Printer { get; set; }
        public string RoomId { get; set; }
        public string RecipeId { get; set; }
        public string RecipePrinter { get; set; }
        
        public UspHisOuPatient InfoOuPatient { get; set; }
        public string RecipeDtlId { get; set; }
        public OuRecipeTemp InfoOuRecipeTemp { get; set; }
    }




    public class OutpatientRecipeReportWithGetPrintTestFomReport : BaseModel
    {
        public IList<UspOuRecipeDtl> LstCheckOuRecipeDtlQry { get; set; }
        public bool IsPrintAuto { get; set; }
        public string DrugType { get; set; }
        public UspHisOuPatient UotpPatientInfo { get; set; }
        public Hashtable HtContinueAmount { get; set; }
        
        public IList<OuClincDiag> LstOuClincDiag { get; set; }
        public IList<UspOuRecipePrint> LstUspPrintSh { get; set; }
        public IList<UspOuRecipeDtl> LstTestUspOuRecipeDtlQry { get; set; }
    }



    public class OutpatientRecipeReportWithGetExecuteBillDtl : BaseModel
    {
        public IList<UspOuRecipePrint> LstRecipePrint { get; set; }
        public IList<UspOuExecutePrint> LstvOuExecute { get; set; }
        public string Printer { get; set; }
        public string RptType { get; set; }
        public UspHisOuPatient InfoPatient { get; set; }
        public bool FirstPrint { get; set; }
    }

    public class AccountingWithAddPrint : BaseModel
    {
        public bool IsMzCure { get; set; }
        public bool IsMzDrop { get; set; }
        public bool IsMzReject { get; set; }
        public DateTime InvoTime { get; set; }
        public UspHisOuPatient InfoOuPatient { get; set; }
        public IList<UspOuInvoiceDtl> LstUspOuInvoiceDtl { get; set; }
    }




    public class PatientServiceWithGetRecipePrintList : BaseModel
    {
        public IList<UspOuDrugIssueDtl> lstOuDrugIssueDtl { get; set; }
        public bool Visible { get; set; }
        public UspOuDrugIssue InfoCurrOuDrugIssue { get; set; }

        public bool isAutoPrint { get; set; }

    }




    public class AccountingWithGetOuRecipeDtlById : BaseModel
    {
        public IList<OuRecipeDtl> LstOuRecipeDtl { get; set; }
        public IList<OuRecipeDtl> LstWestRecipeDtl { get; set; }
    }





    public class AccountingWithInsertWestOuRecipeTemp : BaseModel
    {
        public string RoomId { get; set; }
        public string CurrentBalanceNo { get; set; }
        public string YFTarcerId { get; set; }
        public string RecipeId { get; set; }
        public UspHisOuPatient InfoOuPatient { get; set; }
        public OuInvoice OuInvoice { get; set; }
        
        public Trace Trace { get; set; }
        public List<BsRoomWindow> LstBsRoomWindow { get; set; }
    }


    public class OutpatientRecipeWithGetOuRecipeDisposalData : BaseModel
    {
        public string WestRecipId { get; set; }
        public int GroupTemp { get; set; }
        public int HospitalId { get; set; }
        public bool IsCharge { get; set; }
        public UspHisOuPatient hisOuHosInfo { get; set; }
        public Hashtable htContinueAmount { get; set; }
    }



    public class RecipewithSetIsPrint : BaseModel
    {
        public List<UspInExecuteBillPrint> lstInExecuteBillPrint { get; set; }
        public bool isPrint { get; set; }
        public string rptName { get; set; }
        public DateTime printTime { get; set; }
        public int PrintStatus { get; set; }
        public string UserID { get; set; }
    }



    public class ExecuteWithGetInExecuteBillForTest : BaseModel
    {
        public bool IsPrintAll { get; set; }

        public List<UspInExecuteBillPrint> lstInExecuteBillPrintTemp { get; set; }
        public string GUID { get; set; }
        public bool isCanCel { get; set; }

        public string lsMarkType { get; set; }

    }


    public class PrintWithPrint : BaseModel
    {
        public CkLab infoCkLab { get; set; }
        public IList<CkLabDtl> lstCkLabDtl { get; set; }

    }

    public class PatientServiceWithSetReicpePrint : BaseModel
    {
        public UspOuDrugIssueDtl infoUspOuDrugIssueDtl { get; set; }
        public BsPatient infoBsPatient { get; set; }
        public OuHosInfo infoOuHos { get; set; }
        public BsCertificate infoBsCertificate { get; set; }
        public UspOuDrugIssue InfoCurrOuDrugIssue { get; set; }

    }



    public class InAdiceDrugWithCheakSendDrug : BaseModel
    {
        public InChinRicipe inChinRicipe { get; set; }
        public IList<BsLocation> lstoLocation { get; set; }
    }



    public class AdviceWithGetCurrenAdvice : BaseModel
    {
        public string HospId { get; set; }
        public List<AdviceAuthDtl> LstOtherFeeQry { get; set; }
        public bool ShowOldAdvice { get; set; }
        public bool Unfinished { get; set; }
        public HisInPatientQry InfoCurrHosInfo { get; set; }
        public UspInAdviceLongList InAdviceLongList { get; set; }
        public string LocationID { get; set; }
        public List<AdviceAuthDtl> LstCurrenAdvice { get; set; }
        public DateTime BeginTime { get; set; }
    }





    public class UrgentWithSetUrgentState : BaseModel
    {

        public string MenuId { get; set; }
        
        public string HospidHost { get; set; }
        public HisInPatientQry InfoCurrHosInfo { get; set; }
        public int RowIndex { get; set; }
        public IList<AdviceAuthDtl> LstCurrenAdvice { get; set; }

    }



    public class ColumnEditWithUpdateColumnEdit : BaseModel
    {

        public string MenuId { get; set; }
        
        public string AddCustMemo { get; set; }
        public string HospidHost { get; set; }
        public HisInPatientQry InfoCurrHosInfo { get; set; }
        public bool IsTestMode { get; set; }

        public string FieldName { get; set; }
        public IList<AdviceAuthDtl> LstCurrenAdvice { get; set; }
        public int RowIndex { get; set; }

    }



    public class OutpatientRecipeReportServiceWithGetRecipeSpecielList : BaseModel
    {
        //麻、精一
        public List<UspOuRecipePrint> LstMentalDrugPrint { get; set; }//需返回
                                                                      //艾滋
        public List<UspOuRecipePrint> LstHIVPrint { get; set; }//需返回
                                                               //精二
        public List<UspOuRecipePrint> LstSecMentalPrint { get; set; }//需返回
                                                                     //普通
        public List<UspOuRecipePrint> LstMaterial { get; set; }//需返回
                                                               //儿科
        public List<UspOuRecipePrint> LstBaby { get; set; }//需返回
                                                           //普通2
        public List<UspOuRecipePrint> LstNormal { get; set; }//需返回
    }

    public class RecipeServiceWithChinRecipPrintRemove : BaseModel
    {
        public int IsInt { get; set; }
        public IList<UspOuChinRecipePrint> lstOuDrugIssueDtl { get; set; }
    }

    public class HuRmCommonServiceWithFindOuDrugIssueInfo : BaseModel
    {
        public BsRoom infoRoom { get; set; }
        public string mzRegId { get; set; }
        
        public bool IsInjectRoomSendDrug { get; set; }
        public string Text { get; set; }
        public bool IsOuSendAndDosageSameMan { get; set; }
        public bool ShowAllWindow { get; set; }
        public bool IsOuDrugIssueByInvoice { get; set; }
        public DateTime dtBeginTime { get; set; }
        public DateTime dtEndTime { get; set; }
        public string issueStatusId { get; set; }
        public string dispensing { get; set; }
    }



    public class PatientServiceWithGetCellValueChanging : BaseModel
    {
        public int ResultType { set; get; }
        public string LastDemoFunctionIds { set; get; }
        public bool IsModify { get; set; }
    }



    public class PatientServiceWithCellValueChanging : BaseModel
    {
        public string FieldName { set; get; }
        public string MenuId { set; get; }
        public string HospId { get; set; }
        public bool IsModify { get; set; }
        public string RowHandleValue { set; get; }
        public bool Cancel { get; set; }
        
    }


    public class HuRmCommonServiceWithGetLstOuDrugIssue : BaseModel
    {
        public BsRoomWindow infoRoomWindow { set; get; }
        public IList<UspOuDrugIssue> lstOuDrugIssue { set; get; }
        public DateTime dtBeginTime { set; get; }
        public DateTime dtEndTime { set; get; }
        public string issueStatusId { set; get; }
        public bool IsInjectRoomSendDrug { set; get; }
        public BsRoom infoRoom { set; get; }
        
        public string dispensing { set; get; }

    }



    public class PatientServiceWithLocationId : BaseModel
    {
        public string DefaultLocationId { set; get; }
        public string PatientName { set; get; }
        public string LocationId { set; get; }
        public bool IsNurseManageAreaPatient { set; get; }
        public string SpecialityID { set; get; }
        public string InputString { set; get; }
    }


    public class RmCommonServiceWithGetSelected : BaseModel
    {
        public bool IsAst { set; get; }
        public int PrintStatus { set; get; }
        public DateTime RePrintTime { set; get; }
        public List<InExecutePrint> LstPrintGetSelectedAll { set; get; }
        public List<UspInExecuteBillPrint> LstExecuteBill { set; get; }
        public bool IsuseInExecutePrint { set; get; }
        public bool TodayAdvice { set; get; }
        public string RptName { set; get; }


    }


    public class PatientServiceWithGetPatientByCardNo : BaseModel
    {
        public BsPatient bsPatient { set; get; }
        public List<BsPatient> lstBsPatient { set; get; }
    }

    public class PatientWithSaveShieldingPatient : BaseModel
    {
        public IList<InHosInfo> LstInHosInfoPatient { set; get; }
        public IList<TrInHosInfo> LstTrInHosInfo { set; get; }

    }


    public class PrintWithPrintSendLabList : BaseModel
    {
        public InHosInfo InfoInHos { set; get; }
        public IList<CkLabDtl> LstCkLabDtl { set; get; }
        public string InfoBsBed { set; get; }
        public string InfoCkTestType { set; get; }
        public string InfoBsLabSource { set; get; }
        public string InPatNo { set; get; }
        public string OuHosInfo { set; get; }


    }





    public class BsDoctorServiceWithCheckLocationIdCellValueChanging : BaseModel
    {
        public IList<BsDoctor> LstBsDoctor { set; get; }
        public string BsDoctorId { set; get; }
    }



    public class PrintWithPrintData : BaseModel
    {
        public CkLab InfoCkLab { set; get; }
        public IList<CkLabDtl> LstCkLabDtl { set; get; }
    }



    public class BandWithBandedGridViewMain : BaseModel
    {
        public double TotalPrice { set; get; }
        public double TotalRetail { set; get; }

    }


    public class BandWithBandedGrid : BaseModel
    {

        public string Value { set; get; }
        public string FieldName { set; get; }
        public double StockPrice { set; get; }
        public double RetailPrice { set; get; }
        public double DrugNum { set; get; }
    }



    public class OutpatientRecipeReportServiceWithPrintWestReportReturn : BaseModel
    {
        public IList<UspOuRecipePrint> LstRecipePrint { set; get; }
        public IList<UspOuRecipePrint> LstRecipePrintCharged { set; get; }
        public IList<UspOuRecipePrint> LstRecipePrintNotCharged { set; get; }

        public bool IsReSet { set; get; }
    }



    public class OutpatientRecipeReportServiceWithPrintWestReport : BaseModel
    {
        public bool IsForInject { set; get; }
        public string intRecipeID { set; get; }
        public bool isPrintAuto { set; get; }
        public int listNum { set; get; }
        
        public Hashtable HtContinueAmount { set; get; }

    }



    public class InventoryServiceWithFindInRmRecipeMainReturn : BaseModel
    {
        public IList<UspInDrugIssue> LstInRmRecipeMain { set; get; }
        public IList<UspInSendDrugClassPrint> LstInSendDrugOut { set; get; }
        public IList<UspInSendDrugClassPrint> LstvInRmRecipeDtl { set; get; }
        public bool IsConfirm { set; get; }

    }



    public class InventoryServiceWithFindInRmRecipeMain : BaseModel
    {
        public int AdviceType { set; get; }
        public string LocationId { set; get; }
        public int IssueStatus { set; get; }
        public bool IsInIssueSendLongAlone { set; get; }
        public DateTime OpenLongAdviceTowDate { set; get; }
        public DateTime BeginTime { set; get; }
        public int EmergencyAll { set; get; }
        public DateTime EndTime { set; get; }
        
        public Action<int> FindDrugReqdtl { set; get; }
        public IList<UspInSendDrugClassPrint> LstvInRmRecipeDtl { set; get; }
        public string InPatValueID { set; get; }

    }



    public class BsItemDrugServiceWithShowInfoByItemId : BaseModel
    {
        public string ManuId { set; get; }
        public string CompId { set; get; }
        public string FormId { set; get; }
        public string Spec { set; get; }
        public string Name { set; get; }
        public string LongDesc { set; get; }
        public string EngDesc { set; get; }
        public BsItemDrug InfoBsItemDrug { set; get; }
        public BsItemEquipment InfoBsItemEquipment { set; get; }

    }


    public class BsItemServiceWithShowInfoByItemId : BaseModel
    {
        public string ManuId { set; get; }
        public string CompId { set; get; }
        public string FormId { set; get; }
        public string Spec { set; get; }
        public string EngDesc { set; get; }
        public string LongDesc { set; get; }
        public string Name { set; get; }
        public string PacsId { set; get; }
        public short XType { get; set; }
        public string Equipment { get; set; }
        public string CheckBody { get; set; }
        public string InitCode { get; set; }
        public BsItemDrug InfoBsItemDrug { get; set; }
        public BsItemPacs InfoBsItemPacs { get; set; }
    }




    public class ItemServiceWithGetBsItemMini : BaseModel
    {
        public string Code { set; get; }
        public List<string> LsRpType { set; get; }
        public bool IsUserInputF1 { set; get; }
        public bool IsAdvice { set; get; }
        public string HouseId { set; get; }
        
        public short LsInOut { set; get; }
        /// <summary>
        /// 0--非毒麻药品 1--毒麻药品 2--全部
        /// </summary>
        public int LsPoison { get; set; }
    }


    public class AccountingServiceWithOulInvoiceRegDtail : BaseModel
    {
        
        public OuHosInfo OnfoOuHos { set; get; }
        public string InvoLastId { set; get; }
        public string MenuId { set; get; }
        public bool Check { set; get; }
        public BsPatient BsPatientInfo { set; get; }
        public bool ChkCallOrderChecked { set; get; }
    }



    public class IAccountingServiceWithGetInPayAndPayWay : BaseModel
    {
        public IList<BsPayWay> InfoBsPayWay { set; get; }
        public IList<InPay> InfoInPay { set; get; }
    }


    public class DrugWithCheckDrug : BaseModel
    {
        public IList<BsUsage> LstBsUsage { set; get; }
        public IList<BsItem> lstBsItem { set; get; }

    }


    public class OuHosInfoServiceWithInitInfoByIsMz : BaseModel
    {
        public OuHosInfo InfoOuHosInfo { set; get; }
        public BsPatient InfoBsPatient { set; get; }
        public InHosInfo InfoInHosInfo { set; get; }
    }

    public class PhysicalExaminationServiceWithGetComputeSummary : BaseModel
    {
        public IList<UspPsApplyReport> LstPsApplyReport { set; get; }
        public IList<ComputeSummary> LstComputeSummary { set; get; }

    }




    public class BloodTransfusionWithGetBloodSendById : BaseModel
    {
        public CkLab InfoCkLab { set; get; }
        public BsPatient InfoBsPatient { set; get; }
    }



    public class BloodTransfusionWithSaveModifyCkBloodBack : BaseModel
    {
        public string SeriaNo { set; get; }
        public DateTime BackTime { set; get; }
        public string BackOperId { set; get; }
        public string BackReason { set; get; }
        public string Memo { set; get; }
    }



    public class BloodTransfusionWithAddCkBloodBack : BaseModel
    {
        public string BackReason { set; get; }
        public DateTime BackTime { set; get; }
        public string Memo { set; get; }
        public DateTime OperTime { set; get; }
        public string BackOperId { set; get; }
        public string OperId { set; get; }
        public CkBloodSend InfoCkBloodSend { set; get; }
    }



    public class OuHosInfoServiceWithShowRdInfectiousTwo : BaseModel
    {
        public OuHosInfo InfoOuHosInfo { set; get; }
        public BsPatient InfoBsPatient { set; get; }
        public InHosInfo InfoInHosInfo { set; get; }
        public RdInfectious InfoRdInfectious { set; get; }
    }


    public class OuHosInfoServiceWithShowRdInfectiousThere : BaseModel
    {
        public OuHosInfo InfoOuHosInfo { set; get; }
        public BsPatient InfoBsPatient { set; get; }
        public RdInfectious InfoRdInfectious { set; get; }
    }



    public class OuHosInfoServiceWithShowRdInfectiousNew : BaseModel
    {
        public OuHosInfo InfoOuHosInfo { set; get; }
        public BsPatient InfoBsPatient { set; get; }
    }



    public class OuHosInfoServiceWithRdInfectStd : BaseModel
    {
        public OuHosInfo InfoOuHosInfo { set; get; }
        public BsPatient InfoBsPatient { set; get; }
    }



    public class CkBldApplyServiceWithGetCkBldApply : BaseModel
    {
        public CkBldApply InfoCkBldApply { set; get; }
        public List<CkBdBank> lstCkBdBank { set; get; }

    }


    public class CkBdBankServiceWithGetBloodCode : BaseModel
    {
        public List<CkBdBank> LstCkBdBank { set; get; }
        public CkBdBank CkBdBankInfo { set; get; }
        public CkBloodType BloodTypeInfo { set; get; }

    }



    public class AdviceWithCheckInfoAdviceTime : BaseModel
    {
        public IList<UspInAdviceLongList> LstUspInAdviceLongQry { get; set; }
        public string LocationID { get; set; }
        public string NoteAdviceItemId { get; set; }
        public DateTime BeginTime { get; set; }
        public string AdvBandedGridViewMain { get; set; }
        public string GetCurrentRowIndex { get; set; }

    }



    public class AdviceWithCheckUspInAdvice : BaseModel
    {
        public int LsInStatus { set; get; }
        public DateTime BeginTime { set; get; }
        public List<UspInAdviceTempList> LstUspInAdviceTempQry { set; get; }
        public string LocationID { set; get; }

    }




    public class RecipeExecuteWithStopSelectedAdvice : BaseModel
    {
        public List<UspInAdviceLongList> LstUspInAdviceLongList { set; get; }
        public List<int> ListRowIndex { set; get; }
        
        public string MenuId { set; get; }
        public string DoctorId { set; get; }
        public bool IsEnabled { set; get; }

    }

    public class CkLabResultServiceWithAddPartFinsh : BaseModel
    {
        public IList<UspCkLabByOpertimeAndLsStatus2> LstLab { set; get; }
        public IList<UspCkLabByOpertimeAndLsStatus2> LstUnfinish { set; get; }

    }



    public class DgRoadServiceWithGetDayGroupRoadPat : BaseModel
    {
        public DgRoad InfoDgRoad { set; get; }
        public bool IsExDgRoad { set; get; }
        public IList<UspDgRoadPageDtl> LstUspDgRoadPageDtl { set; get; }
        public IList<UspDgRoadGroupPat> LstDgRoadGroupPat { set; get; }
    }



    public class PhysicalExaminationWithUpdateCkLab : BaseModel
    {
        public string LabId { set; get; }
        public bool IsPreview { set; get; }
        public string WhereOperatorCode { set; get; }
        public string UserId { set; get; }
        public string UserRoleIDs { set; get; }
        public IList<UspCkResultDtl> LstUspCkResultDtl { set; get; }
    }



    public class DgRoadPatServiceWithSaveRoadPat : BaseModel
    {
        public Action Locks { set; get; }
        public List<UspDgRoadPageDtl> LstUspDgRoadPageDtl { set; get; }
        public IList<DgDayGroupPat> LstReturnDgDayGroupPat { set; get; }
        public string PatId { set; get; }
        public string DgRoadId { set; get; }
        
    }


    public class InAdviceTempServiceWithGetInAdviceTempReturn : BaseModel
    {
        public InAdviceTemp InfoAdviceTemp { set; get; }

        public DgRoadPatDtl DgRoadPatDtl { set; get; }
    }



    public class InAdviceLongServiceWithGetInAdviceLong : BaseModel
    {
        public DgRoadPatDtl DgRoadPatDtl { set; get; }
        
        public bool IsDemo { set; get; }
        public bool IsNo { set; get; }
        public string NoteAdviceItemId { set; get; }
        public string SelfPatTypeId { set; get; }
        public string PatId { set; get; }
        public int LongSN { set; get; }
        public int LongGroupNum { set; get; }
        public int NumLong { set; get; }


    }



    public class DgRoadLocWithGetDgRoadLocByRoadIdCommon : BaseModel
    {
        public IList<DgRoadLoc> LstDgRoadLoc { set; get; }
        public IList<DgRoadIll> LstDgRoadIll { set; get; }
        public IList<DgRoadVariation> LstDgRoadVariation { set; get; }
        public IList<DgRoadVariation> LstDgRoadVariationReason { set; get; }
    }



    public class BsIllnessServiceWithCheckBsIlByIdandByName : BaseModel
    {
        public string FileName { set; get; }
        public int RowHandle { set; get; }
        public string ValueID { set; get; }
        public string ValueName { set; get; }
        public IList<DgRoadIll> LstDgRoadIll { set; get; }
    }


    public class DgRoadServiceWithSaveModify : BaseModel
    {
        public DgRoad InfoDgRoad { set; get; }
        public List<DgRoadIll> LstDgRoadIll { set; get; }
        public List<DgRoadGroup> LstDgRoadGroupAll { set; get; }
        public List<DgRoadLoc> LstDgRoadLoc { set; get; }
        public List<DgRoadDtl> LstDgRoadDtlAll { set; get; }
        public List<DgDayGroup> LstDgDayGroup { set; get; }
        public List<DgRoadVariation> LstDgRoadVariation { set; get; }
        public int CausesVariation { set; get; }
        public List<DgRoadVariation> LstDgRoadVariationReason { set; get; }
        public int CausesVariationReason { set; get; }
        public List<DgRoadGroup> LstDgRoadGroupDel { set; get; }
        public List<DgRoadLoc> LstDgRoadLocDel { set; get; }
        public List<DgRoadDtl> LstDgRoadDtlDel { set; get; }
        public List<DgDayGroup> LstDgDayGroupDel { set; get; }
        public List<DgRoadIll> LstDgRoadIllDel { set; get; }
    }



    public class DgDayGroupServiceWithGetDgDayGroupByDgRoadIdandById : BaseModel
    {
        public IList<DgDayGroup> LstDgDayGroup { set; get; }
        public DgRoad InfoDgRoad { set; get; }
    }




    public class InAdviceLongServiceWithSaveAdvice : BaseModel
    {
        public List<UspDgRoadPageDtl> LstUspDgRoadPageDtl { set; get; }
        public List<DgDayGroupPat> LstReturnDgDayGroupPat { set; get; }
        public string DgDayId { set; get; }
        public string PatId { set; get; }
        public bool IsDemo { set; get; }
        public string NoteAdviceItemId { set; get; }
        public string SelfPatTypeId { set; get; }
        

    }



    public class InAdviceTempServiceWithGetInAdviceTemp : BaseModel
    {
        public DgRoadPatDtl DgRoadPatDtl { set; get; }
        
        public bool IsDemo { set; get; }
        public bool IsNo2 { set; get; }
        public string NoteAdviceItemId { set; get; }
        public string SelfPatTypeId { set; get; }
        public string PatId { set; get; }
        public string TempSN { set; get; }
        public int TempGroupNum { set; get; }
        public int NumTemp { set; get; }

    }



    public class RecipeHospitalizationServiceWithGetInAdviceTempReturn : BaseModel
    {
        public InAdviceTemp InAdviceTemp { set; get; }
        public DgRoadPatDtl DgRoadPatDtl { set; get; }

    }


    public class RefreshGridWithRefreshGridViewByHost : BaseModel
    {
        public IList<AdviceAuthDtl> LstCurrenAdvice { get; set; }
        public IList<InAdviceGroup> LstInAdviceGroup { get; set; }
        public double ArrearAmount { get; set; }
    }






    public class PatientWithGetInfoUspInHos : BaseModel
    {
        public List<InHosInfo> lstSameInPatNoInHosInfo { get; set; }
        public BsLocation infoLocation { get; set; }
    }





    public class PatientWithSaveTracePatInfoChange : BaseModel
    {
        public InHosInfo infoInHos { get; set; }
        public UspInHosInfo InfoUspInHos { get; set; }
        
        public string GUID { get; set; }
        public BsPatient InfoBsPatient { get; set; }
    }



    public class PatientWithGetFreshLsInStatus : BaseModel
    {
        public UspInHosInfo uspInHosInfo { get; set; }
        public BsPatient bsPatient { get; set; }
    }



    public class PatientWithGetGetInHosCancelIn : BaseModel
    {
        public IList<InDeposit> LstDeposit { get; set; }
        public InHosInfo InfoInHosInfo { get; set; }
    }



    public class BsPatientWithGetInitData : BaseModel
    {
        public bool IsClinical { get; set; }
        public BsPatient infoBsPatient { get; set; }
    }

    public class CalBirthdaySome : BaseModel
    {
        public UspInHosInfo uspInHosInfo { get; set; }
        public IdentityInformation IdentityInformation { get; set; }
    }

    public class DgRoadPatDtlWithUspInAdviceLongList : BaseModel
    {
        public DgRoadPatDtl road { get; set; }
        public UspInAdviceLongList advice { get; set; }
    }


    public class PatientWhitGetInfoUspInHos : BaseModel
    {
        public List<InHosInfo> lstSameInPatNoInHosInfo { get; set; }
        public BsLocation infoLocation { get; set; }
    }

    public class PatientWhitGetFreshLsInStatus : BaseModel
    {
        public UspInHosInfo uspInHosInfo { get; set; }
        public BsPatient bsPatient { get; set; }
    }

    public class PatientWhitGetGetInHosCancelIn : BaseModel
    {
        public List<InDeposit> LstDeposit { get; set; }
        public InHosInfo InfoInHosInfo { get; set; }
    }

    public class PatientWhitSaveTracePatInfoChange : BaseModel
    {
        public InHosInfo infoInHos { get; set; }
        public UspInHosInfo InfoUspInHos { get; set; }
        
        public string GUID { get; set; }
        public BsPatient InfoBsPatient { get; set; }
    }

    public class TestSystemWithCkMachineSample : BaseModel
    {
        public string labNum { set; get; }
        public string machineId { set; get; }
        public string sampleNum { set; get; }
        public string operId { set; get; }
        public bool isDoubleMachineSample { set; get; }
    }

    public class AccountingWithGetLocation : BaseModel
    {
        public string DiagnDept { get; set; }
        public string ExecLocId { get; set; }
        public string Totality { get; set; }
        public string ItemId { get; set; }
        public UspBsItemSelect InfoUspBsItem { get; set; }
        public UspOuInvoiceDtl UspOuInvoiceDtl { get; set; }
        
    }

    public class AccountingWithAddPrintList : BaseModel
    {
        public List<UspInExecuteBillPrintDoctor> LstMzCurePrint { get; set; }
        public List<UspInExecuteBillPrintDoctor> LstMzDropPrint { get; set; }
        public List<UspInExecuteBillPrintDoctor> LstMzRejectPrint { get; set; }
    }
    //public class ReportCardWithGoHistroryOut
    //{
    //    public OuHosInfo OuHosInfo { set; get; }
    //    public BsPatient BsPatient { set; get; }
    //    public RdBrainDead RdBrainDead { set; get; }
    //    public RdCancer RdCancer { set; get; }
    //    public RdInfectious RdInfectious { set; get; }
    //    public RdInfectStd RdInfectStd { set; get; }

    //}

    //public class InAdviceDrugWithSendDrug
    //{

    //    public double Remain { get; set; }
    //    public double Insurance { get; set; }
    //    public double NotPay { get; set; }
    //    public double DrugAmount { get; set; }
    //    public double Beprice { get; set; }
    //    public double Amount { get; set; }
    //    public double reserveAmount { get; set; }
    //    public InPatFeesList infoInPatFeesList { get; set; }
    //    public double Deposit { get; set; }
    //    public double Text { get; set; }
    //    public double Underline { get; set; }
    //    public IList<InPatFeesList> lstTemp { get; set; }
    //    public IList<UspininvoicedtlUmp> lstUspInInvoiceDtl { get; set; }
    //    public IList<AdviceAuthDtl> lstAdviceAuthDtl { get; set; }
    //    public InInvoiceDtl infoInvoiceDtl { get; set; }
    //    public BsFrequency infoBsFrequency { get; set; }

    //}




    //public class InAdviceDrugWithSendDrug
    //{

    //    public IList<UspininvoicedtlUmp> lstUspInInvoiceDtl { get; set; }
    //    public string hospId { get; set; }
    //    public string patTypeId { get; set; }
    //    
    //    public string hisInPatientId { get; set; }
    //    public bool IsLockPatConl { get; set; }

    //    public IList<ComputeSummary> lstHospId { get; set; }

    //}


    //public class AccountingWithAddPrintList
    //{
    //    public IList<UspInExecuteBillPrintDoctor> LstMzCurePrint { get; set; }
    //    public IList<UspInExecuteBillPrintDoctor> LstMzDropPrint { get; set; }
    //    public IList<UspInExecuteBillPrintDoctor> LstMzRejectPrint { get; set; }
    //}


    //public class HuRmCommonServiceWithSetRmOutDtl
    //{
    //    public IList<UspOuDrugIssueDtl> lstOuDrugIssueDtl { get; set; }
    //    
    //    public DateTime dateTime { get; set; }
    //    public IList<OuRecipeDtl> lstOuRecipeDtl { get; set; }
    //    public string roomId { get; set; }
    //    public UspOuDrugIssue InfoCurrOuDrugIssue { get; set; }
    //    public IList<Rmstore> lstRmStoreUpdate { get; set; }
    //    public IList<RmOutDtl> lstRmOutDtl { get; set; }
    //}




    //public class HuRmCommonServiceWithSetRmOutDtlReturn
    //{
    //    public ServiceResponse serviceResponse { get; set; }
    //    public OuRecipeDtl ouRecipeDtl { get; set; }

    //    public IList<OuRecipeDtl> lstOuRecipeDtl { get; set; }
    //    public IList<RmOutDtl> lstRmOutDtl { get; set; }

    //}

    //public class AccountingWithGetLocation
    //{
    //    public int DiagnDept { get; set; }
    //    public string ExecLocId { get; set; }
    //    public string Totality { get; set; }
    //    public string ItemId { get; set; }
    //    public UspBsItemSelect InfoUspBsItem { get; set; }
    //    public UspOuInvoiceDtl UspOuInvoiceDtl { get; set; }
    //    
    //}


    //public class OuHosInfoServiceWithCheckMzRegIdPat
    //{
    //    public bool IsLoadLastOuHos { set; get; }
    //    public string LastInvoNo { set; get; }
    //    public string CurrentInvoiceId { set; get; }
    //    public OuHosInfo InfoOuHos { set; get; }
    //    public BsPatient InfoBsPatient { set; get; }

    //    /// <summary>
    //    /// 记录当前病人与挂号类别对应的挂号费对象
    //    /// </summary>
    //    public UspBsRegPatAmount UspBsRegPatAmount { set; get; }
    //    public double LastFactGet { set; get; }

    //}


    //public class PhysicalExaminationWithGetCkResultDtl
    //{
    //    public IList<UspCkLabSearchDtl> LstUspCkLabSearchDtl { set; get; }
    //    public IList<UspCkResultDtl> LstUspCkResultDtl { set; get; }
    //}


    //public class PhysicalExaminationWithAddPatient
    //{
    //    public string Patientname { set; get; }
    //    public string UddSex { set; get; }
    //    public string RefLocation { set; get; }
    //    public string Diagnose { set; get; }
    //    public short LsSource { set; get; }
    //    public string LocationId { set; get; }
    //    public string DoctorId { set; get; }
    //    public string UserID { set; get; }
    //    public int TestType { set; get; }
    //    public UspCkLabByOpertimeAndLsStatus.ResultSetModel1 InfoCrrentLab { set; get; }
    //}


    //public class PhysicalExaminationWithGetByLabNum
    //{
    //    public IList<UspCkLabRecieve> LstFinished { set; get; }
    //    public IList<UspCkLabRecieve> LstCkLab { set; get; }
    //    public IList<UspCkLabRecieve> LstNotFinished { set; get; }

    //}





    //public class TestSystemServiceWithGetCkLabCollectRecord
    //{
    //    public IList<UspCkLabRecieve> LstFinished { set; get; }
    //    public IList<UspCkLabRecieve> LstNotFinished { set; get; }

    //}


    //public class CkLabBankServiceWithCheckPatientno
    //{
    //    public Action<int> InitBankData { set; get; }
    //    public IList<UspCkLabByOpertimeAndLsStatus4> LstUnfinishW { set; get; }

    //}

    //public class CkItemServiceWithCheckValidate
    //{
    //    public IList<CkItem> LstCkItem { set; get; }

    //    public ServiceResponse serviceResponse { set; get; }

    //}
    //public class PatientWithTipResultUnNormal
    //{
    //    public string Message { set; get; }
    //    public string RoleId { set; get; }
    //    public string LocationId { set; get; }
    //    public string UserId { set; get; }
    //    
    //    public UspCkLabByOpertimeAndLsStatus.ResultSetModel1 InfoCrrentLab { set; get; }
    //    public IList<UspCkResultDtl> LstUspCkResultDtl { set; get; }
    //}

    public class RoomMedicineWithRmKsOutLocation : BaseModel
    {
        
        public EnumHuRmBillTypeCode BillTypeCode { get; set; }
        public EnumBillSpecialType BillSpecicalType { get; set; }
        public EnumBillFiledName FieldName { get; set; }
        public string HouseRoomId { get; set; }
        public string BillId { get; set; }
        public RmKsOut RmKsOut { get; set; }
        public IList<RmKOutDtl> LstRmKOutDtl { get; set; }
        public bool IsOut { get; set; }
        public IList<UspInInvoiceDtlToRmKOutDtl> LstInInvoiceDtlToRmKOutDtl { get; set; }
    }

    public class InventoryWithHuRmSearchWhere : BaseModel
    {

        public EnumStoresType LsStoresType { set; get; }


        public string HuRmId { get; set; }


        public string ItemId { get; set; }

        public string ItemName { get; set; }


        public string ManuId { get; set; }


        public string FormId { get; set; }


        public bool IsProduceDate { get; set; }


        public DateTime ProduceDateStart { get; set; }


        public DateTime ProduceDateEnd { get; set; }


        public bool IsLimitDate { get; set; }


        public DateTime LimitDateStart { get; set; }


        public DateTime LimitDateEnd { get; set; }


        public bool IsUnderLineDown { get; set; }


        public bool IsUnderLineUp { get; set; }


        public int LsImport { get; set; }


        public bool IsInject { get; set; }


        public bool IsWzHouse { get; set; }
    }

    public class UspReadInPatient : BaseModel
    {
        #region Public Properties
        public string GUID
        {
            get;
            set;
        }
        public string JYDJH
        {
            get;
            set;
        }

        public string YYBH
        {
            get;
            set;
        }

        public string GMSFHM
        {
            get;
            set;
        }

        public string XM
        {
            get;
            set;
        }

        public string DWMC
        {
            get;
            set;
        }

        public string XB
        {
            get;
            set;
        }

        public DateTime CSRQ
        {
            get;
            set;
        }

        public string RYLB
        {
            get;
            set;
        }

        public string GWYJB
        {
            get;
            set;
        }

        public string ZYH
        {
            get;
            set;
        }

        public string JZLB
        {
            get;
            set;
        }

        public DateTime RYRQ
        {
            get;
            set;
        }

        public string RYZD
        {
            get;
            set;
        }

        public string RYZDGJDM
        {
            get;
            set;
        }

        public string BQDM
        {
            get;
            set;
        }

        public string CWDH
        {
            get;
            set;
        }

        public double TZDXSPH
        {
            get;
            set;
        }

        public string BZ1
        {
            get;
            set;
        }

        public string BZ2
        {
            get;
            set;
        }

        public string BZ3
        {
            get;
            set;
        }

        public int DRBZ
        {
            get;
            set;
        }
        #endregion
    }

    public class BloodTransfusionWithCkLabByOperTimeAndLsStatus : BaseModel
    {
        public IList<UspCkLabByOpertimeAndLsStatus2> LstUnfinishW { get; set; }
        public IList<UspCkLabByOpertimeAndLsStatus2> LstUnfinishY { get; set; }
    }

    public class BloodTransfusionWithCkLabByOperTimeAndLsStatusWhere : BaseModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string SearchLocationId { get; set; }
        public HisInPatientQry SearchInPatNo { get; set; }
        public string SearchPatientName { get; set; }
        public int LsStatus { get; set; }
        public string TestType { get; set; }
    }

    public class BloodTransfusionWithBsPatientInHosInfoNTime : BaseModel
    {
        public string PatientId { get; set; }
        public string PatientNTime { get; set; }
    }

    public class BsitemPatTypeWithReturn : BaseModel
    {
        public IList<BsItemPatType> lstBsItemPatType { get; set; }
        public IList<UspInInvoiceDtlChkByHospId> lstInInvoiceDtlChkByHospId { get; set; }
    }

    public class BsitemPatTypeWithBsitemPatType : BaseModel
    {
        public OuInvoice infoOuInvoice { get; set; }

        public IList<OuInvoiceDtl> lstOuInvoiceDtl { get; set; }

        public IList<BsItemPatType> lstBsItemPatType { get; set; }

        public IList<InInvoiceDtl> lstInInvoiceDtl { get; set; }

        public string IntegralItemId { get; set; }

        public bool IsOuToFeeIninoiceDtl { get; set; }

        public IList<UspInInvoiceDtlChkByHospId> lstInInvoiceDtlChkByHospIdQry { get; set; }

        public string PatTypeId { get; set; }

        public string hospidID { get; set; }

    }

    public class PatientServiceWithGetPatientDtoByCardNo : BaseModel
    {
        public BsPatient bsPatient { set; get; }
        public List<BsPatient> lstBsPatient { set; get; }
    }

    public class PatientWithTipResultUnNormal : BaseModel
    {
        public string Message { set; get; }
        public string RoleId { set; get; }
        public string LocationId { set; get; }
        public string UserId { set; get; }
        
        public ResultSetModel1 InfoCrrentLab { set; get; }
        public IList<UspCkResultDtl> LstUspCkResultDtl { set; get; }
    }

    public class ItemWithItemUnitRetailStockPrice : BaseModel
    {
        public double RetailPrice { get; set; }

        public string UnitId { get; set; }

        public double StockPrice { get; set; }
    }
    public class InInvoiceDtlDumWithAdvice : BaseModel
    {
        #region Public Properties

        public string AdviceId { get; set; }

        public string HospId { get; set; }

        public EnumLsMarkType EquipMentInfo { get; set; }

        #endregion
    }
}
