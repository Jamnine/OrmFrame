using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using Orm.Model.EnumDefine;
using System.Collections.Specialized;
using Orm.Model.Custom.UspModel;

namespace Orm.Model.Custom
{
    [Serializable]
    public class CustomTree : BaseModel
    {
        /// <summary>
        /// 标识
        /// </summary>
        //////[Description("标识")]
        public string GUID { set; get; }
        /// <summary>
        /// 父级标识
        /// </summary>

        //////[Description("父级标识")]
        public string ParentID { set; get; }
        /// <summary>
        /// 名称
        /// </summary>

        //////[Description("名称")]
        public string Name { set; get; }
        /// <summary>
        /// 扩展属性
        /// </summary>

        //////[Description("扩展属性")]
        public object TempTag { set; get; }

        //////[Description("IsChecked")]
        public bool IsChecked { set; get; }
    }
    [Serializable]
    public class RptRmInventoriesDeatil : BaseModel
    {
        public virtual string GUID { get; set; }

        public virtual string CheckId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual double? StockNum { get; set; }

        public virtual double? InstoreNum { get; set; }

        public virtual double? CheckNum { get; set; }

        public virtual double? StockPrice { get; set; }

        public virtual double? RetailPrice { get; set; }

        public virtual String compare { get; set; }

        public virtual String PNo { get; set; }

        public virtual String Code { get; set; }

        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual double? RetailPricePk { get; set; }

        public virtual double? PkNum { get; set; }

        public virtual double? BalanceNum { get; set; }

        public virtual String UnitName { get; set; }

        public virtual String OperName { get; set; }

        public virtual DateTime? LimitDate { get; set; }

        public virtual DateTime? CheckTime { get; set; }

        public virtual DateTime? opertime { get; set; }

        public string PackageSpec { get; set; }

    }

    [Serializable]
    public class ParamSystem : BaseModel
    {

        public virtual string Name { get; set; }

        public virtual string Value { get; set; }
    }
    [Serializable]
    public class UspRmStoreUnderLine : BaseModel
    {
        public virtual String Code { get; set; }

        public virtual string GUID { get; set; }

        public virtual String RoomName { get; set; }

        public virtual String ItemName { get; set; }

        public virtual String CompanyName { get; set; }

        public virtual String UnitName { get; set; }

        public virtual double UnderLine { get; set; }

        public virtual double UperLine { get; set; }


        public virtual String AreaName { get; set; }

        public virtual double Normal { get; set; }

        public virtual Boolean? IsActive { get; set; }

        public virtual int? OrderBy { get; set; }

        public virtual string RoomId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual string CompId { get; set; }

        public virtual String Spec { get; set; }

        public virtual double? Price { get; set; }



        public virtual Boolean? IsStop { get; set; }

        public virtual string GroupMainId { get; set; }

        public virtual string GroupSubId { get; set; }
    }


    [Serializable]
    public class RptTkBillInfo : BaseModel
    {
        public virtual string GUID { get; set; }

        public virtual string InBatchId { get; set; }

        public virtual double? DrugNum { get; set; }

        public virtual double? StockPrice { get; set; }

        public virtual double? RetailPrice { get; set; }

        public virtual String Memo { get; set; }

        public virtual string BillId { get; set; }

        public virtual String BillNo { get; set; }

        public virtual DateTime? OperTime { get; set; }

        public virtual string SignOperId { get; set; }

        public virtual String UnitName { get; set; }

        public virtual String ItemCode { get; set; }

        public virtual String ItemName { get; set; }

        public virtual String Spec { get; set; }

        public virtual double? TotalPrice { get; set; }

        public virtual double? TotalRetail { get; set; }

        public virtual String PNo { get; set; }

        public virtual String OperName { get; set; }

        public virtual String SignName { get; set; }

        public virtual String HouseName { get; set; }

        public virtual String RoomName { get; set; }
    }

    [Serializable]
    public class UspRmInventoriesDeatil : BaseModel
    {
        public virtual string GUID { get; set; }

        public virtual string CheckId { get; set; }

        public virtual string InBatchId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual string CompId { get; set; }

        public virtual string UnitId { get; set; }

        public virtual double BalanceNum { get; set; }

        public virtual double StockNum { get; set; }

        public virtual double InstoreNum { get; set; }

        public virtual double CheckNum { get; set; }

        public virtual string OperId { get; set; }

        public virtual double StockPrice { get; set; }

        public virtual double RetailPrice { get; set; }

        public virtual double compare { get; set; }

        public virtual Boolean balance { get; set; }

        public virtual Boolean isAdjust { get; set; }

        public virtual double ApplyIn { get; set; }

        public virtual double MzBackIn { get; set; }

        public virtual double ZyBackIn { get; set; }

        public virtual double MoveIn { get; set; }

        public virtual double OtherIn { get; set; }

        public virtual double MoveOut { get; set; }

        public virtual double MzOut { get; set; }

        public virtual double ZyOut { get; set; }

        public virtual double LoseOut { get; set; }
        public virtual double BackOut { get; set; }
        public virtual double OtherOut { get; set; }

        public virtual double AdjustAmouUp { get; set; }

        public virtual double AdjustAmouDn { get; set; }

        public virtual double RecipeOut { get; set; }

        public virtual double KsBackIn { get; set; }

        public virtual double KsOut { get; set; }

        public virtual String PNo { get; set; }

        public virtual String Code { get; set; }

        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual string FormId { get; set; }

        public virtual String ItemKcUnit { get; set; }

        public virtual double? RetailPricePk { get; set; }

        public virtual double? StockPricePk { get; set; }

        public virtual double? RetailPriceCheck { get; set; }

        public virtual double? StockPriceCheck { get; set; }

        public virtual double? RetailPriceStock { get; set; }

        public virtual double? StockPriceStock { get; set; }

        public virtual double PkNum { get; set; }

        public virtual String State { get; set; }

        public virtual String IsGSJ { get; set; }

        public virtual String PackageSpec { get; set; }

        public virtual double? HuStockNum { get; set; }

        public virtual Int32? UnitKc { get; set; }

        public virtual double? HuCheckNum { get; set; }

        public virtual String UnitKcName { get; set; }

        public virtual String CompanyName { get; set; }
    }


    [Serializable]
    public class UspOuCkeckItemCompany : BaseModel
    {
        public string GUID { get; set; }

        public String ItemName { get; set; }

        public string ItemId { get; set; }

        public string TestId { get; set; }

        public double PriceDiag { get; set; }

        public Int32 Totality { get; set; }

        public string CkMainID { get; set; }
    }

    // Socket请求类


    [Serializable]
    public class UspInExecuteBillPrint : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = false)]
        public string HospId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = false)]
        public string ItemId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = false)]
        public DateTime AdviceTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public string AdviceId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public int LsMarkType { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
        public string UnitTakeId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = false)]
        public int GroupNum { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public string LocationId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public Boolean IsPrint { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = false)]
        public string FrequencyId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public int LsExecLoc { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = false)]
        public string ExecLocId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public String HospNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public String PatientName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 16, IsRequired = false)]
        public Int32 LocIn { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public String SexName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 18, IsRequired = false)]
        public Int32 Age { get; set; }

        public string PatId { get; set; }

        public string DoctorId { get; set; }

        public String Code { get; set; }

        public int OrderBy { get; set; }

        public String ItemName { get; set; }

        public String Spec { get; set; }

        public double PriceIn { get; set; }

        public String LoactionName { get; set; }

        public String BedName { get; set; }

        public String UnitTakeName { get; set; }

        public String UsageName { get; set; }

        public String FrequencyName { get; set; }

        public Boolean IsPoison { get; set; }

        public double Times { get; set; }

        public DateTime OperTime { get; set; }

        public string DetailId { get; set; }

        public double Dosage { get; set; }

        public double Totality { get; set; }

        public String Memo { get; set; }

        public string BedId { get; set; }

        public Boolean IsPrintLabel { get; set; }

        public Boolean IsPrintReject { get; set; }

        public Boolean IsPrintDrug { get; set; }

        public Boolean IsPrintAst { get; set; }

        public Boolean IsPrintCure { get; set; }

        public Boolean IsPrintNurse { get; set; }

        public Boolean IsPrintExternal { get; set; }

        public Boolean IsPrintPush { get; set; }

        public Boolean IsPrintRejSkin { get; set; }

        public Boolean IsPrintDietetic { get; set; }

        public Boolean IsLastLong { get; set; }

        public String UnitInName { get; set; }

        public Boolean IsPrintBlood { get; set; }

        public Boolean IsSelected { get; set; }

        public string UnitInId { get; set; }

        public string UsageId { get; set; }

        public Boolean IsPrintAtomization { get; set; }

        public Boolean IsExecuted { get; set; }

        public DateTime ExecutedTime { get; set; }

        public string ExecutedOperId { get; set; }

        public String YBType { get; set; }

        public String NurseMemo { get; set; }

        public Boolean IsUrgent { get; set; }

        public String JYJCDH { get; set; }

        public Boolean IsApply { get; set; }

        public DateTime ApplyTime { get; set; }

        public String ApplyOper { get; set; }

        public int LastDay { get; set; }

        public int FirstDay { get; set; }

        public Boolean IsAst { get; set; }

        public Boolean IsAttach { get; set; }

        public String tempstr1 { get; set; }

        public String tempstr2 { get; set; }
        public String AgeString { get; set; }

        public int Lsrptype { get; set; }

        public Boolean IsPriority { get; set; }
    }

    [Serializable]
    public class UspOuCkeckItem : BaseModel
    {
        public string GUID { get; set; }

        public String ItemName { get; set; }

        public string ItemId { get; set; }

        public string TestId { get; set; }

        public double PriceDiag { get; set; }

        public Int32 Totality { get; set; }

        public string CkMainID { get; set; }
    }

    [Serializable]
    public class UspInPatientNotEnough : BaseModel
    {
        ////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public String InPatNo { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String HospNo { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public string HospId { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public string PatID { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String CardNo { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public String BedName { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String PatientName { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public String Sex { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public Int32 NTime { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public DateTime InTime { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public DateTime OutTime { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public Boolean IsBaby { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = false)]
        public double YbLimitRemain { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = false)]
        public double YbLimit { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 16, IsRequired = false)]
        public string BedId { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 17, IsRequired = false)]
        public Int32 CaptionIcon { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 18, IsRequired = false)]
        public string LocationId { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 19, IsRequired = false)]
        public Int32 Age { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public String SexName { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 21, IsRequired = false)]
        public string DoctorId { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public int LsInStatus { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public Boolean IsYbMt { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public string PatTypeId { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 25, IsRequired = false)]
        public double Amount { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 26, IsRequired = false)]
        public double NotPay { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 27, IsRequired = false)]
        public double Remain { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 28, IsRequired = false)]
        public double Forepay { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 29, IsRequired = false)]
        public double ArrearAmount { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public String PatTypeName { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public String DoctorName { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public double DrugAmount { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public double DrugPercent { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public double AmountPay { get; set; }

        ////////////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public double Insurance { get; set; }
    }


    #region 病案手术表 HISBA4
    /// <summary>
    /// 病案手术表
    /// </summary>
    /// <author>LiJiaXiong 2018.08.06</author>
    [Serializable]
    public class HISBA4 : BaseModel
    {
        #region 构造函数
        /// <summary>
        /// 病案手术表 构造函数
        /// </summary>
        public HISBA4()
        {
        }
        #endregion

        #region 字段  FDOCBH-手术医生编号, FDOCNAME-手术医生, FIFFSOP-是否附加手术, FMAZUI-麻醉方式, FMAZUIBH-麻醉方式编号, FMZDOCT-麻醉医生, FMZDOCTBH-麻醉医生编号, FNAME-病人姓名, FOP-手术码对应名称, FOPCODE-手术码, FOPDATE-手术日期, FOPDOCT1-I助姓名, FOPDOCT1BH-I助编号, FOPDOCT2-II助姓名, FOPDOCT2BH-II助编号, FOPKSNAME-手术所在科室名称, FOPTIMES-手术次数, FOPTYKH-手术所在科室统一科号, FPRN, FQIEKOU-切口, FQIEKOUBH-切口编号, FSSJB-手术级别, FSSJBBH-手术级别编号, FTIMES-次数, FYUHE-愈合, FYUHEBH-愈合编号, FZQSS-择期手术, FZQSSBH-择期手术编号

        //////////////////////////////////////[DataMemberr(Order = 9)]
        public string GUID { get; set; }

        /// <summary>
        /// 手术医生编号
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 10)]
        public string FDOCBH { get; set; }

        /// <summary>
        /// 手术医生
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 11)]
        public string FDOCNAME { get; set; }

        /// <summary>
        /// 是否附加手术
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 12)]
        public Boolean FIFFSOP { get; set; }

        /// <summary>
        /// 麻醉方式
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 13)]
        public string FMAZUI { get; set; }

        /// <summary>
        /// 麻醉方式编号
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 14)]
        public string FMAZUIBH { get; set; }

        /// <summary>
        /// 麻醉医生
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 15)]
        public string FMZDOCT { get; set; }

        /// <summary>
        /// 麻醉医生编号
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 16)]
        public string FMZDOCTBH { get; set; }

        /// <summary>
        /// 病人姓名
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 17)]
        public string FNAME { get; set; }

        /// <summary>
        /// 手术码对应名称
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 18)]
        public string FOP { get; set; }

        /// <summary>
        /// 手术码
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 19)]
        public string FOPCODE { get; set; }

        /// <summary>
        /// 手术日期
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 20)]
        public DateTime FOPDATE { get; set; }

        /// <summary>
        /// I助姓名
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 21)]
        public string FOPDOCT1 { get; set; }

        /// <summary>
        /// I助编号
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 22)]
        public string FOPDOCT1BH { get; set; }

        /// <summary>
        /// II助姓名
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 23)]
        public string FOPDOCT2 { get; set; }

        /// <summary>
        /// II助编号
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 24)]
        public string FOPDOCT2BH { get; set; }

        /// <summary>
        /// 手术所在科室名称
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 25)]
        public string FOPKSNAME { get; set; }

        /// <summary>
        /// 手术次数
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 26)]
        public int FOPTIMES { get; set; }

        /// <summary>
        /// 手术所在科室统一科号
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 27)]
        public string FOPTYKH { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 28)]
        public string FPRN { get; set; }

        /// <summary>
        /// 切口
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 29)]
        public string FQIEKOU { get; set; }

        /// <summary>
        /// 切口编号
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 30)]
        public string FQIEKOUBH { get; set; }

        /// <summary>
        /// 手术级别
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 31)]
        public string FSSJB { get; set; }

        /// <summary>
        /// 手术级别编号
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 32)]
        public string FSSJBBH { get; set; }

        /// <summary>
        /// 次数
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 33)]
        public int FTIMES { get; set; }

        /// <summary>
        /// 愈合
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 34)]
        public string FYUHE { get; set; }

        /// <summary>
        /// 愈合编号
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 35)]
        public string FYUHEBH { get; set; }

        /// <summary>
        /// 择期手术
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 36)]
        public string FZQSS { get; set; }

        /// <summary>
        /// 择期手术编号
        /// </summary>	
        //////////////////////////////////////[DataMemberr(Order = 37)]
        public string FZQSSBH { get; set; }

        #endregion
    }
    #endregion

    [Serializable]
    public class UspCheckCall : BaseModel
    {
        public string GUID { get; set; }
        public bool IsSelect { get; set; }
        public string ItemType { get; set; }
        public string NumberStr { get; set; }
        public string PatName { get; set; }
        public string Sex { get; set; }
    }



    [Serializable]
    public class UspOuDrugIssue : BaseModel
    {
        ////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 2, IsRequired = false)]
        public string TempId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public string MzRegId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String MzRegNo { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public DateTime RegTime { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String Sex { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
        public int Age { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 8, IsRequired = false)]
        public int BabyMonth { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public String AddressHome { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public String IllDesc { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public String Name { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public int LsRepType { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public String RecipeNum { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public DateTime RecipeTime { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public string LocationId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public string DoctorId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 17, IsRequired = false)]
        public int HowMany { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public Boolean IsPriority { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public String Memo { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 20, IsRequired = false)]
        public Boolean IsPend { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public Boolean IsExecuted { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public String CardNo { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public String ContactPhone { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public String PyCode1 { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public String WbCode1 { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public String PyCode2 { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public String WbCode2 { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public String PyCode3 { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public String WbCode3 { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 30, IsRequired = false)]
        public double Amount { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public int LocationHospitalId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 32, IsRequired = false)]
        public int RecipeHospitalId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 33, IsRequired = false)]
        public Boolean IsPrinted { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 34, IsRequired = false)]
        public Boolean IsPutDrug { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public String DoctorName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public String LocationName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 37, IsRequired = true)]
        public string PatId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public String PatTypeName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
        public String RoomWindowName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public Int32 LsReportType { get; set; }
    }

    [Serializable]
    public class UspOuChinRecipePrint : BaseModel
    {
        ////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string RecipeId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public string MzRegId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String recipe_Num { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String Spec { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String Unit_Take { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public String Unit_Diag { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String usagename { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 9, IsRequired = false)]
        public double Hz { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public double Dosage { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public double Totality { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public String Memo { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public String PrepareTime { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public Int32 List_Num { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public Boolean IsCancel { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public String Item_Desc { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 17, IsRequired = false)]
        public double Price_In { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 18, IsRequired = false)]
        public double Amount { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public String PatientName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public String DoctorName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public String PatTypeName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public String LocationName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public String SequenceNum { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public String Sex { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 25, IsRequired = false)]
        public Byte Age { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 26, IsRequired = false)]
        public Int32 BabyMonth { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public String AddressHome { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public String IllDesc { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public String IllDescZy { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public DateTime RecipeTime { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public String PhoneHome { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 32, IsRequired = false)]
        public int HowMany { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public String AccountNo { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public Boolean IsCharge { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public String RecipeMemo { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public Boolean IsPrint { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 37, IsRequired = true)]
        public string DoctorId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public String XdRpName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 39, IsRequired = false)]
        public int DecoctNum { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public String PrintName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public String CertificateName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
        public String IdCardNo { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 43, IsRequired = true)]
        public String MedicareNo { get; set; }
    }

    [Serializable]
    public partial class UspInDrugIssue : BaseModel
    {
        //////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        //////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public String RequestNo { get; set; }

        //////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String LocationName { get; set; }

        //////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String RequestMan { get; set; }

        //////////////////////////////////[DataMemberr(Order = 5, IsRequired = false)]
        public DateTime ConfirmDate { get; set; }

        //////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public string OperID { get; set; }

        //////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public string RoomId { get; set; }

        //////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public string LocationId { get; set; }

        //////////////////////////////////[DataMemberr(Order = 9, IsRequired = false)]
        public DateTime OperTime { get; set; }

        //////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public int LsSendStatus { get; set; }

        //////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public Boolean IsPrint { get; set; }

        //////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public string ConfirmOperID { get; set; }
    }


    #region 住院领药申请单明细 InDrugReqdtl
    /// <summary>
    /// 住院领药申请单明细
    /// </summary>
    /// <author>LiJiaXiong 2018.08.06</author>
    [Serializable]
    public class InDrugReqdtl : BaseModel
    {
        #region 构造函数
        /// <summary>
        /// 住院领药申请单明细 构造函数
        /// </summary>
        public InDrugReqdtl()
        {
        }
        #endregion

        #region 字段  AdviceId-医嘱号，对应医嘱表, BedName, ChildPrice-儿童价格, ConfirmOperId-确认人, ConfirmOperTime-确认时间, DetailId-记帐表的费用GUID, DiscountAoumt-折扣金额, DiscountPrice-折扣价格, DoctorID, DoctorName-开单医生名称, Dosage-用量, ExecuteId-执行单GUID, ForDate-需要的时间, FrequencyId-服用频率, GroupNum-组号, HospId-住院号（相当于门诊的流水号）,用户不可见, IsArrearage, IsAuthed-已经封存，不可改删, IsConfirm-是否确认, IsIssued-是否已发？, IsOutDrug-是在院用药：1：在院用药.0:出院带药, IsPrint-是否已打印, ItemId-药品GUID, ListNum-序号, LocationId-科室, LsArrearage, LsMarkType-医嘱类别：1-长期；2-临时；3-其他, LsSecMarkType, OperId, PriceIn, Refusal, RegDate, RequestId-申请单, RoomId-药房GUID, Totality-总量, UnitReq-申请单位, UnitTake-服用单位, UsageId-服用方法, UsageMemo-用法备注, UseTime-用药时间, UseTimeEnd-用药结束时间

        ////////////////////////////////[DataMemberr(Order = 9)]
        public string GUID { get; set; }

        /// <summary>
        /// 医嘱号，对应医嘱表
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 10)]
        public string AdviceId { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 11)]
        public string BedName { get; set; }

        /// <summary>
        /// 儿童价格
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 12)]
        public double ChildPrice { get; set; }

        /// <summary>
        /// 确认人
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 13)]
        public string ConfirmOperId { get; set; }

        /// <summary>
        /// 确认时间
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 14)]
        public DateTime ConfirmOperTime { get; set; }

        /// <summary>
        /// 记帐表的费用GUID
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 15)]
        public string DetailId { get; set; }

        /// <summary>
        /// 折扣金额
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 16)]
        public double DiscountAoumt { get; set; }

        /// <summary>
        /// 折扣价格
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 17)]
        public double DiscountPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 18)]
        public string DoctorID { get; set; }

        /// <summary>
        /// 开单医生名称
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 19)]
        public string DoctorName { get; set; }

        /// <summary>
        /// 用量
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 20)]
        public double Dosage { get; set; }

        /// <summary>
        /// 执行单GUID
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 21)]
        public string ExecuteId { get; set; }

        /// <summary>
        /// 需要的时间 (已初始化值)
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 22)]
        public DateTime ForDate { get; set; }

        /// <summary>
        /// 服用频率
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 23)]
        public string FrequencyId { get; set; }

        /// <summary>
        /// 组号
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 24)]
        public int GroupNum { get; set; }

        /// <summary>
        /// 住院号（相当于门诊的流水号）,用户不可见
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 25)]
        public string HospId { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 26)]
        public Boolean IsArrearage { get; set; }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 27)]
        public Boolean IsAuthed { get; set; }

        /// <summary>
        /// 是否确认
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 28)]
        public Boolean IsConfirm { get; set; }

        /// <summary>
        /// 是否已发？
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 29)]
        public Boolean IsIssued { get; set; }

        /// <summary>
        /// 是在院用药：1：在院用药.0:出院带药
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 30)]
        public Boolean IsOutDrug { get; set; }

        /// <summary>
        /// 是否已打印
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 31)]
        public Boolean IsPrint { get; set; }

        /// <summary>
        /// 药品GUID
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 32)]
        public string ItemId { get; set; }

        /// <summary>
        /// 序号
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 33)]
        public int ListNum { get; set; }

        /// <summary>
        /// 科室
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 34)]
        public string LocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 35)]
        public Boolean LsArrearage { get; set; }

        /// <summary>
        /// 医嘱类别：1-长期；2-临时；3-其他
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 36)]
        public int LsMarkType { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 37)]
        public int LsSecMarkType { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 38)]
        public string OperId { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 39)]
        public double PriceIn { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 40)]
        public Boolean Refusal { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 41)]
        public string RegDate { get; set; }

        /// <summary>
        /// 申请单
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 42)]
        public string RequestId { get; set; }

        /// <summary>
        /// 药房GUID
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 43)]
        public string RoomId { get; set; }

        /// <summary>
        /// 总量
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 44)]
        public double Totality { get; set; }

        /// <summary>
        /// 申请单位
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 45)]
        public string UnitReq { get; set; }

        /// <summary>
        /// 服用单位
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 46)]
        public string UnitTake { get; set; }

        /// <summary>
        /// 服用方法
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 47)]
        public string UsageId { get; set; }

        /// <summary>
        /// 用法备注
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 48)]
        public string UsageMemo { get; set; }

        /// <summary>
        /// 用药时间
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 49)]
        public DateTime UseTime { get; set; }

        /// <summary>
        /// 用药结束时间
        /// </summary>	
        ////////////////////////////////[DataMemberr(Order = 50)]
        public DateTime UseTimeEnd { get; set; }

        #endregion
    }
    #endregion



    [Serializable]
    public class UspRmInDrugBack : BaseModel
    {
        public string GUID { get; set; }

        public String LocationName { get; set; }

        public String RequestNo { get; set; }

        public string LocationId { get; set; }

        public string RoomId { get; set; }

        public String ReqOperName { get; set; }

        public string ReqOperId { get; set; }

        public DateTime ConfirmDate { get; set; }
    }


    [Serializable]
    public class UspRmInDrugBackDtl : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public String RoomName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = false)]
        public string DoctorId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String DoctorName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String PatientName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String InPatNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public String BedName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public string AdviceId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public int GroupNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public int LsMarkType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public string ReqLocationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public String ReqLocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public String RequestNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public string ReqOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public String ItemCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public String Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = false)]
        public double PriceIn { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = false)]
        public double Amount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public String FrequencyName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public String UsageName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = false)]
        public double Dosage { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public double Totality { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public String UnitInName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = false)]
        public Boolean IsSelectd { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public String LocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = false)]
        public string ReqBackId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public string RoomId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public string UnitReq { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = false)]
        public double ReqBackTotality { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = false)]
        public Boolean IsBackReq { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public string HospId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public string LocationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = false)]
        public string DetailId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = false)]
        public DateTime ConfirmOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public Boolean IsBack { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = false)]
        public DateTime BackTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = true)]
        public String ConfirmOperName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public String ReqBackOperName { get; set; }

        public String BackMemo { get; set; }

        public String ReqMemo { get; set; }

        public string ExecuteId { get; set; }

        public string ConfirmBackOperName { get; set; }
    }



    [Serializable]
    public class UspInInvoiceDtlToRmKOutDtl : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public double Totality { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public string UnitId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public string HospId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String InPatNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public string LocationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public string DoctorId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public String Code { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public String ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public String Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = false)]
        public double PriceIn { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = false)]
        public Boolean IsSelected { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public String BedName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public DateTime RegOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public Boolean IsCancel { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public int LsPerform { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = false)]
        public string CancelId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = false)]//////////////////////////////[DataMemberr(Order
        public Boolean IsDelete { get; set; }
    }



    [Serializable]
    public class UspInSendDrugClassPrintAll : BaseModel
    {
        //////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public virtual string PatID { get; set; }

        //////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public virtual String HospNo { get; set; }

        //////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public virtual String PatientName { get; set; }

        //////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public virtual String IdCardNo { get; set; }

        //////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public virtual String ItemName { get; set; }

        //////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public virtual String Spec { get; set; }

        //////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public virtual double Totality { get; set; }

        //////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public virtual string UnitReq { get; set; }

        //////////////////////////////[DataMemberr(Order = 11, IsRequired = false)]
        public virtual double Dosage { get; set; }

        //////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public virtual string BedId { get; set; }

        //////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public virtual Boolean IsPrint { get; set; }

        //////////////////////////////[DataMemberr(Order = 14, IsRequired = false)]
        public virtual double PriceIn { get; set; }

        //////////////////////////////[DataMemberr(Order = 15, IsRequired = false)]
        public virtual double Amount { get; set; }

        //////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public virtual int LsMarkType { get; set; }

        //////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public virtual string LocationId { get; set; }

        //////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public virtual String ItemCode { get; set; }

        //////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public virtual DateTime ForDate { get; set; }

        //////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public virtual String RequestNo { get; set; }

        //////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public virtual string RoomId { get; set; }

        //////////////////////////////[DataMemberr(Order = 22, IsRequired = false)]
        public virtual double Times { get; set; }

        //////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public virtual string HospId { get; set; }

        //////////////////////////////[DataMemberr(Order = 24, IsRequired = false)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public virtual String UnitReqName { get; set; }

        //////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public virtual string RequestId { get; set; }

        //////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public virtual Boolean IsIssued { get; set; }

        //////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public virtual Int32 ListNum { get; set; }

        //////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public virtual string AdviceId { get; set; }

        //////////////////////////////[DataMemberr(Order = 31, IsRequired = false)]
        public virtual string UnitTake { get; set; }

        //////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public virtual Boolean IsConfirm { get; set; }

        //////////////////////////////[DataMemberr(Order = 33, IsRequired = false)]
        public virtual string ConfirmOperId { get; set; }

        //////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public virtual String ConfirmOperTime { get; set; }

        //////////////////////////////[DataMemberr(Order = 35, IsRequired = false)]
        public virtual string DetailId { get; set; }

        //////////////////////////////[DataMemberr(Order = 36, IsRequired = false)]
        public virtual string UsageId { get; set; }

        //////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public virtual string FrequencyId { get; set; }

        //////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public virtual int GroupNum { get; set; }

        //////////////////////////////[DataMemberr(Order = 39, IsRequired = false)]
        public virtual string ExecuteId { get; set; }

        //////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public virtual String FrequencyName { get; set; }

        //////////////////////////////[DataMemberr(Order = 41, IsRequired = false)]
        public virtual Boolean GroupId { get; set; }

        //////////////////////////////[DataMemberr(Order = 42, IsRequired = false)]
        public virtual Boolean IsPoison { get; set; }

        //////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public virtual Boolean IsExpen { get; set; }

        //////////////////////////////[DataMemberr(Order = 44, IsRequired = false)]
        public virtual Boolean IsMental { get; set; }

        //////////////////////////////[DataMemberr(Order = 45, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        //////////////////////////////[DataMemberr(Order = 46, IsRequired = true)]
        public virtual String UnitTakeName { get; set; }

        //////////////////////////////[DataMemberr(Order = 47, IsRequired = false)]
        public virtual Boolean IsAttach { get; set; }

        //////////////////////////////[DataMemberr(Order = 48, IsRequired = true)]
        public virtual String UsageName { get; set; }

        //////////////////////////////[DataMemberr(Order = 49, IsRequired = false)]
        public virtual string OperID { get; set; }

        //////////////////////////////[DataMemberr(Order = 50, IsRequired = false)]
        public virtual Int32 age { get; set; }

        //////////////////////////////[DataMemberr(Order = 51, IsRequired = true)]
        public virtual String AgeString { get; set; }

        //////////////////////////////[DataMemberr(Order = 52, IsRequired = true)]
        public virtual String BedName { get; set; }

        //////////////////////////////[DataMemberr(Order = 53, IsRequired = true)]
        public virtual string PatTypeId { get; set; }

        //////////////////////////////[DataMemberr(Order = 54, IsRequired = true)]
        public virtual String Sex { get; set; }

        //////////////////////////////[DataMemberr(Order = 55, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        //////////////////////////////[DataMemberr(Order = 56, IsRequired = true)]
        public virtual String GroupName { get; set; }

        //////////////////////////////[DataMemberr(Order = 57, IsRequired = false)]
        public virtual DateTime Memo { get; set; }

        //////////////////////////////[DataMemberr(Order = 58, IsRequired = true)]
        public virtual String GroupTitle { get; set; }

        //////////////////////////////[DataMemberr(Order = 59, IsRequired = false)]
        public virtual int OrderBy { get; set; }

        //////////////////////////////[DataMemberr(Order = 60, IsRequired = false)]
        public virtual Int32 FirstDay { get; set; }
    }


    [Serializable]
    public class UspHuPkDtl : BaseModel
    {
        public string GUID { get; set; }
        public string InBatchId { get; set; }
        public string ItemId { get; set; }
        public string UnitId { get; set; }
        public double DrugNum { get; set; }
        public double StockPrice { get; set; }
        public double RetailPrice { get; set; }
        public string BillId { get; set; }
        public string BillNo { get; set; }
        public string HouseId { get; set; }
        public DateTime OperTime { get; set; }
        public string OperId { get; set; }
        public bool IsSign { get; set; }
        public DateTime SignTime { get; set; }
        public string SignOperId { get; set; }
        public string PNo { get; set; }
        public string UnitName { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public string ManufactureryName { get; set; }
        public double TotalPrice { get; set; }
        public double TotalRetail { get; set; }
    }


    [Serializable]
    public class UspHuPydtl : BaseModel
    {
        public string GUID { get; set; }
        public string InBatchId { get; set; }
        public string ItemId { get; set; }
        public string UnitId { get; set; }
        public double DrugNum { get; set; }
        public double StockPrice { get; set; }
        public double RetailPrice { get; set; }
        public string BillId { get; set; }
        public string BillNo { get; set; }
        public string HouseId { get; set; }
        public DateTime OperTime { get; set; }
        public string OperId { get; set; }
        public DateTime SignTime { get; set; }
        public string SignOperId { get; set; }
        public bool IsSign { get; set; }
        public string PNo { get; set; }
        public string UnitName { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public double TotalPrice { get; set; }
        public double TotalRetail { get; set; }
        public string ManufactureryName { get; set; }
    }


    [Serializable]
    public class UspRmPkDtl : BaseModel
    {
        public string GUID { get; set; }
        public string InBatchId { get; set; }
        public string ItemId { get; set; }
        public string UnitId { get; set; }
        public double DrugNum { get; set; }
        public double StockPrice { get; set; }
        public double RetailPrice { get; set; }
        public string BillId { get; set; }
        public string BillNo { get; set; }
        public string RoomId { get; set; }
        public DateTime OperTime { get; set; }
        public string OperId { get; set; }
        public bool IsSign { get; set; }
        public DateTime SignTime { get; set; }
        public string SignOperId { get; set; }
        public string UnitName { get; set; }
        public string PNo { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public string ManufactureryName { get; set; }
        public double TotalPrice { get; set; }
        public double TotalRetail { get; set; }
    }

    [Serializable]
    public class UspRmPyDtl : BaseModel
    {
        public string GUID { get; set; }
        public string InBatchId { get; set; }
        public string ItemId { get; set; }
        public string UnitId { get; set; }
        public double DrugNum { get; set; }
        public double StockPrice { get; set; }
        public double RetailPrice { get; set; }
        public string BillId { get; set; }
        public string BillNo { get; set; }
        public string RoomId { get; set; }
        public DateTime OperTime { get; set; }
        public string OperId { get; set; }
        public bool IsSign { get; set; }
        public DateTime SignTime { get; set; }
        public string SignOperId { get; set; }
        public string UnitName { get; set; }
        public string PNo { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public string ManufactureryName { get; set; }
        public double TotalPrice { get; set; }
        public double TotalRetail { get; set; }
    }


    [Serializable]
    public class UspNotCreateDgRoad : BaseModel
    {
        public string GUID { get; set; }
        public string RoadId { get; set; }
        public string RoadPatId { get; set; }
        public string AdviceId { get; set; }
        public int GroupNum { get; set; }
        public string ItemId { get; set; }
        public bool IsNeed { get; set; }
        public int MutexNum { get; set; }
        public string Reason { get; set; }
        public string RoadPatDtlId { get; set; }
    }

    [Serializable]
    public class UspIntoDgroadGroupPat : BaseModel
    {
        public string RoadId { get; set; }
        public string DayGroupId { get; set; }
        public string DgBsGroupId { get; set; }
        public string DgRoadGroupId { get; set; }
        public string Name { get; set; }
        public int LsAdvType { get; set; }
        public int LsCureType { get; set; }
        public string CataLogId { get; set; }
        public int Days { get; set; }
        public bool IsNeed { get; set; }
        public bool IsReason { get; set; }
        public string Memo { get; set; }
        public int GroupNum { get; set; }
        public string HospId { get; set; }
    }

    [Serializable]
    public class UspRminAndOutForItem : BaseModel
    {
        public string GUID { get; set; }
        public string BillNo { get; set; }
        public string RoomId { get; set; }
        public string LocationName { get; set; }
        public DateTime OperTime { get; set; }
        public string OperId { get; set; }
        public double RetailTotle { get; set; }
        public double StockTotle { get; set; }
        public string Type { get; set; }
        public bool IsSign { get; set; }
        public int LsActType { get; set; }
        public DateTime SignTime { get; set; }
        public DateTime YFOperTime { get; set; }
        public string HouseId { get; set; }
        public string SignoperId { get; set; }
        public int PageNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemId { get; set; }
        public string RmBillNo { get; set; }
        public int LsrpType { get; set; }
    }

    [Serializable]
    public class VwRminAndOutinfoForItem : BaseModel
    {
        public string GUID { get; set; }
        public string BillNo { get; set; }
        public string RoomId { get; set; }
        public string LocationName { get; set; }
        public DateTime OperTime { get; set; }
        public string OperId { get; set; }
        public double RetailTotle { get; set; }
        public double StockTotle { get; set; }
        public string Type { get; set; }
        public bool IsSign { get; set; }
        public int LsActType { get; set; }
        public DateTime SignTime { get; set; }
        public DateTime YFOperTime { get; set; }
        public string HouseId { get; set; }
        public string SignoperId { get; set; }
        public int PageNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemId { get; set; }
        public string RmBillNo { get; set; }
        public int LsrpType { get; set; }
    }


    [Serializable]
    public class UspRmInAndOutWz : BaseModel
    {
        public string GUID { get; set; }
        public string BillNo { get; set; }
        public string RoomId { get; set; }
        public string LocationName { get; set; }
        public DateTime OperTime { get; set; }
        public string OperId { get; set; }
        public string HouseId { get; set; }
        public double RetailTotle { get; set; }
        public double StockTotle { get; set; }
        public string Type { get; set; }
        public bool IsSign { get; set; }
        public int LsActType { get; set; }
        public DateTime SignTime { get; set; }
        public int pageNumber { get; set; }
    }

    [Serializable]
    public class VwRmInAndOutWzInfo : BaseModel
    {
        public string GUID { get; set; }
        public string BillNo { get; set; }
        public string RoomId { get; set; }
        public string LocationName { get; set; }
        public DateTime OperTime { get; set; }
        public string OperId { get; set; }
        public string HouseId { get; set; }
        public double RetailTotle { get; set; }
        public double StockTotle { get; set; }
        public string Type { get; set; }
        public bool IsSign { get; set; }
        public int LsActType { get; set; }
        public DateTime SignTime { get; set; }
        public int pageNumber { get; set; }
    }

    [Serializable]
    public class UspHuOUTStoresInfo : BaseModel
    {
        public string GUID { get; set; }
        public string InBatchNo { get; set; }
        public string HouseId { get; set; }
        public string ItemId { get; set; }
        public string PNo { get; set; }
        public string UnitId { get; set; }
        public string CompId { get; set; }
        public double StockNum { get; set; }
        public double InstoreNum { get; set; }
        public double StockPrice { get; set; }
        public double RetailPrice { get; set; }
        public DateTime StoreDate { get; set; }
        public DateTime ProduceDate { get; set; }
        public DateTime LimitDate { get; set; }
        public bool IsBalance { get; set; }
        public bool IsNewin { get; set; }
        public bool IsBid { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public string ManufactureryName { get; set; }
        public string UnitName { get; set; }
        public double TotalPrice { get; set; }
        public double TotalRetail { get; set; }
        public string Memo { get; set; }
    }

    [Serializable]
    public class UspHuDrugOutByBillNo : BaseModel
    {
        public string GUID { get; set; }
        public string BillNo { get; set; }
        public string HouseId { get; set; }
        public string RoomId { get; set; }
        public bool IsAffirm { get; set; }
        public string BillId { get; set; }
        public string ItemId { get; set; }
        public double DrugNum { get; set; }
        public string UnitId { get; set; }
        public string ApplyId { get; set; }
        public string Memo { get; set; }
    }

    [Serializable]
    public class UspHuBackDtl : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 10)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11)]
        public string InBatchId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13)]
        public string UnitId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14)]
        public double DrugNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15)]
        public double RetailPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16)]
        public double StockPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17)]
        public string Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18)]
        public string VoucherNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19)]
        public bool IsMargin { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20)]
        public string BillId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21)]
        public string BillNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22)]
        public string HouseId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23)]
        public string CompId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25)]
        public string OperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26)]
        public bool IsSign { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27)]
        public DateTime SignTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28)]
        public string SignOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29)]
        public string UnitName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30)]
        public string ItemCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31)]
        public string ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32)]
        public string Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33)]
        public string ManufactureryName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34)]
        public double TotalPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35)]
        public double TotalRetail { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36)]
        public string PNo { get; set; }
    }


    [Serializable]
    public class UspHuStockDtl : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 10)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11)]
        public string VoucherNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12)]
        public string PNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13)]
        public string ItemCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14)]
        public string ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15)]
        public string Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16)]
        public string ManufactureryName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17)]
        public double DrugNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18)]
        public string UnitName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19)]
        public double StockPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20)]
        public double TotalPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21)]
        public double RetailPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22)]
        public double TotalRetail { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23)]
        public double DeltaAmount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24)]
        public DateTime ProduceDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25)]
        public DateTime LimitDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26)]
        public string BillNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28)]
        public DateTime SignTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29)]
        public bool IsSign { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30)]
        public string InBatchNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31)]
        public string BillId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33)]
        public string UnitId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34)]
        public string HouseId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35)]
        public string CompId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36)]
        public string OperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37)]
        public string SignOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38)]
        public double AddPercent { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39)]
        public string PassNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40)]
        public string ProAreaName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41)]
        public string ProAreaId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42)]
        public string ManuId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 43)]
        public double PriceHighLine { get; set; }

        ////////////////////////////////[DataMemberr(Order = 44)]
        public string QcMemo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 45)]
        public double Amount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 46)]
        public string TempStr { get; set; }

        ////////////////////////////////[DataMemberr(Order = 47)]
        public string EID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 48)]
        public string ECompId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 49)]
        public string RepairBy { get; set; }

        ////////////////////////////////[DataMemberr(Order = 50)]
        public DateTime BuyDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 51)]
        public DateTime StartDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 52)]
        public int LimitYears { get; set; }

        ////////////////////////////////[DataMemberr(Order = 53)]
        public int LsQuaClass { get; set; }

        ////////////////////////////////[DataMemberr(Order = 54)]
        public int LsEqClass { get; set; }

        ////////////////////////////////[DataMemberr(Order = 55)]
        public string LotNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 56)]
        public int LsEqStatus { get; set; }

        ////////////////////////////////[DataMemberr(Order = 57)]
        public double MonthDisc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 58)]
        public string EInBatchNo { get; set; }
    }

    [Serializable]
    public class UspDgRoadPatDtlDayGroup : BaseModel
    {
        public string GUID { get; set; }
        public string RoAdpatId { get; set; }
        public string RoAdDtlId { get; set; }
        public string DayGroupId { get; set; }
        public string CureId { get; set; }
        public string DrugId { get; set; }
        public string CheckId { get; set; }
        public string NurseId { get; set; }
        public int LsAdvType { get; set; }
        public int LsCureType { get; set; }
        public string CataLogId { get; set; }
        public Int32 GroupNum { get; set; }
        public double DosAge { get; set; }
        public string UnittakeId { get; set; }
        public string FrequencyId { get; set; }
        public string UsAgeId { get; set; }
        public Int32 Days { get; set; }
        public double FeeToTality { get; set; }
        public string UnitId { get; set; }
        public Boolean IsDelete { get; set; }
        public Boolean IsChange { get; set; }
        public String Reason { get; set; }
        public string AdviceId { get; set; }
        public int LsMarkType { get; set; }
        public String Memo { get; set; }
        public string OperId { get; set; }
        public DateTime RoadTime { get; set; }
        public String AddAdviceMemo { get; set; }
        public String UpAdviceMemo { get; set; }
        public String UnAdviceMemo { get; set; }
        public String LisSource { get; set; }
        public String LisBody { get; set; }
        public Boolean IsAuthed { get; set; }
        public string Itemid { get; set; }
        public DateTime AdviceTime { get; set; }
        public Boolean IsAddAdvice { get; set; }
    }


    [Serializable]
    public class UspDgDayGroupByRoadIsExDgRoad : BaseModel
    {
        public string GUID { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public Int32 Days { get; set; }
        public string DgRoadId { get; set; }
        public Int32 PageNum { get; set; }
        public Int32 ColumnNum { get; set; }
        public string RoadPatId { get; set; }
        public string DayGroupId { get; set; }
        public int LsChangeType { get; set; }
        public String ChangeReason { get; set; }
        public String ChangeContent { get; set; }
        public string SignNurseUsertId { get; set; }
        public string SignDoctorId { get; set; }
        public DateTime SignOperTime { get; set; }
        public int LsTimeType { get; set; }
    }


    [Serializable]
    public class UspDgRoadPageDtl : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string HospId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public string RoadId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public string OperId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public DateTime OperTime { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public Boolean IsChk { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public DateTime ChkOperTime { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public string ChkOperID { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public Boolean IsExit { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public string ExitDoctorId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public DateTime ExitOperTime { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public DateTime SignNurseUsertTime { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public string RoadPatId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public string RoadDtlId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public string DayGroupId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public string CureId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public string DrugId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public string CheckId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public string NurseId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public int LsAdvType { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public int LsCureType { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public string CataLogId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public double DosAge { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public string UnitTakeId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public string FrequencyId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public string UsageId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public Int32 Days { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public double FeeTotality { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public string UnitId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public Boolean IsDelete { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public Boolean IsChange { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public String Reason { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public string AdviceId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public int LsMarkType { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public String RoadTime { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public String AddAdviceMemo { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 37, IsRequired = true)]
        public String UpAdviceMemo { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public String UnAdviceMemo { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 39, IsRequired = true)]
        public Int32 GroupNum { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public String Memo { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public string ItemId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
        public String LisSource { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 43, IsRequired = true)]
        public String LisBody { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 44, IsRequired = true)]
        public int LsTimeType { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 45, IsRequired = true)]
        public String Name { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 46, IsRequired = true)]
        public String Spec { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 47, IsRequired = true)]
        public Boolean IsNeed { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 48, IsRequired = true)]
        public Boolean IsReason { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 49, IsRequired = true)]
        public Int32 PageNum { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 50, IsRequired = true)]
        public Int32 OrderBy { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 51, IsRequired = true)]
        public Boolean IsExist { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 52, IsRequired = true)]
        public string RoadGroupId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 53, IsRequired = true)]
        public Boolean IsStop { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 54, IsRequired = true)]
        public Boolean IsCheck { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 55, IsRequired = true)]
        public Int32 MutexNum { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 56, IsRequired = true)]
        public String GroupName { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 57, IsRequired = true)]
        public String F1 { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 58, IsRequired = true)]
        public String F2 { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 59, IsRequired = true)]
        public String F3 { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 60, IsRequired = true)]
        public String F4 { get; set; }
    }


    [Serializable]
    public class UspDgRoadGroupPat : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string RoadId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public string DayGroupId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public string DgBsGroupId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public string DGroadGroupId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String Name { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public int LsAdvType { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String RoadDtlName { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public Boolean IsAuthed { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public int LsCureType { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public string CataLogId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public Int32 Days { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public Boolean IsNeed { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public Boolean IsReason { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public String Memo { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public Int32 GroupNum { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public string HospId { get; set; }
    }


    [Serializable]
    public class UspouregYYynamic : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string PatientID { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public String PatientName { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = false)]
        public string DoctorId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String DoctorName { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public string LocationID { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String LocationName { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public String MzRegNo { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public DateTime RegTime { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public string RegDept { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public String Sex { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public String Age { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public String SexName { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public String CardNo { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public DateTime BirthDate { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public Boolean IsBaby { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public string RegTypeId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public String RoomNo { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public String RegTypeName { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public Boolean IsPriority { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 20, IsRequired = false)]
        public Boolean IsCancel { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public Boolean IsElder { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public Boolean IsFreeReg { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public Boolean IsFreeDiag { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public Boolean IsInPatient { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public String MedicareNo { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 26, IsRequired = false)]
        public string WorktypeId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public String WorkTypeName { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public string PatTypeId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public String PatTypeName { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public double DiscDiag { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public double DiscIn { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 32, IsRequired = false)]
        public int LsGFPatType { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public String LsGFPatTypeName { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public string TallyTypeId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public String TallyTypeName { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 36, IsRequired = false)]
        public string TallyGroupId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 37, IsRequired = true)]
        public String TallyGroupName { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public Boolean IsGf { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 39, IsRequired = true)]
        public Boolean IsYb { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 40, IsRequired = false)]
        public string FamilyId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 41, IsRequired = false)]
        public string CommitteeId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
        public string OperId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 43, IsRequired = true)]
        public Int32 LineOrder { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 44, IsRequired = true)]
        public DateTime CancelTime { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 45, IsRequired = false)]
        public Boolean IsRegistration { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 46, IsRequired = true)]
        public String Diagnose { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 47, IsRequired = true)]
        public String PreRegRegWay { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 48, IsRequired = true)]
        public int HospitalId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 49, IsRequired = true)]
        public DateTime OperTime { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 50, IsRequired = false)]
        public string DiagnDept { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 51, IsRequired = false)]
        public Boolean IsTransfer { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 52, IsRequired = false)]
        public Boolean IsRegister { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 53, IsRequired = false)]
        public string TimeSpanSubId { get; set; }
    }


    [Serializable]
    public class UspInHosInfo : BaseModel
    {
        public string GUID { get; set; }
        public String HospNo { get; set; }
        public String InPatNo { get; set; }
        public String CardNo { get; set; }
        public String Name { get; set; }
        public String Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public Int32 LsMarriage { get; set; }
        public String BloodGroup { get; set; }
        public DateTime InTime { get; set; }
        public Int32 NTime { get; set; }
        public String XNo { get; set; }
        public string CountryId { get; set; }
        public String Residence { get; set; }
        public String City { get; set; }
        public String Province { get; set; }
        public Boolean IsOversea { get; set; }
        public DateTime PassTime { get; set; }
        public String IdCardNo { get; set; }
        public String Company { get; set; }
        public String Occupation { get; set; }
        public string WorktypeId { get; set; }
        public string PatTypeId { get; set; }
        public string CertificateId { get; set; }
        public Int32 LsInType { get; set; }
        public String OutBedName { get; set; }
        public Int32 LsYbDiff { get; set; }

        public Int32 LsInWay { get; set; }
        public Boolean IsIllegal { get; set; }
        public Int32 LsInIllness { get; set; }
        public Int32 DocMz { get; set; }
        public string DoctorId { get; set; }
        public string LocIn { get; set; }
        public string LocationId { get; set; }
        public string BedId { get; set; }
        public Boolean IsYbMt { get; set; }
        public String YbRegNo { get; set; }
        public double ArrearAmount { get; set; }
        public Boolean IsBaby { get; set; }
        public Int32 AgeDay { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public String PhoneHome { get; set; }
        public String AddressHome { get; set; }
        public String PostCodeHome { get; set; }
        public String AreaCodeHome { get; set; }
        public String PhoneWork { get; set; }
        public String AddressWork { get; set; }
        public String PostCodeWork { get; set; }
        public String AreaCodeWork { get; set; }
        public String LinkmanName { get; set; }
        public string RelationId { get; set; }
        public String LinkmanPhone { get; set; }
        public String LinkmanAddress { get; set; }
        public String LinkmanPost { get; set; }
        public String LinkmanArea { get; set; }
        public Int32 LsInStatus { get; set; }
        public String Status { get; set; }
        public DateTime OperTime { get; set; }
        public string OperID { get; set; }
        public String MedicareNo { get; set; }
        public String AccountNo { get; set; }
        public string RegionId { get; set; }
        public string AreaId { get; set; }
        public String Native { get; set; }
        public String Mobile { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public Int32 Circumference { get; set; }
        public Int32 Waistline { get; set; }
        public Int32 Sternline { get; set; }
        public string PatID { get; set; }
        public DateTime OutTime { get; set; }
        public Boolean IsEndChg { get; set; }
        public string EndChgOperID { get; set; }
        public DateTime EndchgoperTime { get; set; }
        public String AgeStr { get; set; }
        public String Age { get; set; }
        public String IllDesc { get; set; }
        public String Memo { get; set; }
        public String YbPatType { get; set; }
        public string NationId { get; set; }
        public string ProvinceId { get; set; }
        public String Sensitive { get; set; }
        public string FamilyId { get; set; }
        public Boolean IsHouseMaster { get; set; }
        public string RelaMasterId { get; set; }
        public Int32 LsCensus { get; set; }
        public string CommitteeId { get; set; }
        public string PoliceStationId { get; set; }
        public string LevelId { get; set; }
        public Int32 LsSport { get; set; }
        public Int32 LsSportTime { get; set; }
        public Int32 LsSportType { get; set; }
        public Int32 LsBitHabit { get; set; }
        public Int32 SleepHour { get; set; }
        public Int32 LsSleepTrouble { get; set; }
        public String SmokeHistory { get; set; }
        public String DrinkHistory { get; set; }
        public String OtherHabit { get; set; }
        public Boolean IsActive { get; set; }
        public String InActiveReason { get; set; }
        public DateTime InActiveTime { get; set; }
        public string InActiveOperID { get; set; }
        public Int32 IconIndex { get; set; }
        public string FromHospitalId { get; set; }
        public string MzRegId { get; set; }
        public String FromHospital { get; set; }
        public Int32 ISPRICESTATE { get; set; }
        public Int32 NUMBER1 { get; set; }
        public Int32 NUMBER2 { get; set; }
        public Int32 NUMBER3 { get; set; }
        public Int32 NUMBER4 { get; set; }
    }


    [Serializable]
    public class UspCkXdRpDtlPrice : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string AppId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string ItemIdArray { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public double Price { get; set; }
    }



    [Serializable]
    public class VwInHosInfoSelectDynamic : BaseModel
    {
        public string GUID { get; set; }
        public string PatID { get; set; }
        public string PatTypeId { get; set; }
        public string BedId { get; set; }
        public string DoctorId { get; set; }
        public string LocationId { get; set; }
        public String Name { get; set; }
        public String PatientName { get; set; }
        public String DoctorName { get; set; }
        public String PatTypeName { get; set; }
        public String BedName { get; set; }
        public String LocationName { get; set; }
        public String HospNo { get; set; }
        public Int32 NTime { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public Boolean FirtDay { get; set; }
        public String Sex { get; set; }
        public Int32 LsInStatus { get; set; }
        public String CardNo { get; set; }
        public String InPatNo { get; set; }
        public Boolean BedIsAdd { get; set; }
        public Int32 BedOrderBy { get; set; }
        public string TallyTypeId { get; set; }
        public String TallyTypeName { get; set; }
        public string TallyGroupId { get; set; }
        public String TallyGroupName { get; set; }
        public DateTime BirthDate { get; set; }
        public String GetTallyType { get; set; }
        public Boolean IsGf { get; set; }
        public Boolean IsYb { get; set; }
        public String GetTallyTypeName { get; set; }
        public Int32 Age { get; set; }
        public String Native { get; set; }
        public String Residence { get; set; }
        public String Company { get; set; }
        public String Occupation { get; set; }
        public String Mobile { get; set; }
        public String Phone { get; set; }
        public String Sensitive { get; set; }
        public String IdCardNo { get; set; }
        public String MedicareNo { get; set; }
        public String LinkmanName { get; set; }
        public double ArrearAmount { get; set; }
        public String AgeString { get; set; }
        public string MotherHospId { get; set; }
        public String WorkTypeName { get; set; }
        public String MarriageName { get; set; }
        public String NationName { get; set; }

    }


    [Serializable]
    public class UspAdviceAuthCheck : BaseModel
    {
        public AdviceAuthDtl adviceAuthDtl { get; set; }
        public String PatientName { get; set; }
    }

    [Serializable]
    public class HtBsItemAttach : BaseModel
    {
        public IList<BsItemAttach> lstBsItemAttach { get; set; }
        public string itemId { get; set; }
    }



    [Serializable]
    public class InDrugBacked : BaseModel
    {
        public string GUID { get; set; }
        public string ReqDtlId { get; set; }
        public object Totality { get; set; }
        public Boolean IsBack { get; set; }
        public string OperId { get; set; }

    }




    [Serializable]
    public class InDrugReqBackSum : BaseModel
    {
        public string ReqDtlId { get; set; }
        public Int32 ReqTotality { get; set; }


    }




    [Serializable]
    public class NewBusinessList : BaseModel
    {

        public string GUID { get; set; }
        public string ReqBackId { get; set; }
        public string RoomId { get; set; }
        public string LocationId { get; set; }
        public string OperId { get; set; }
        public string ReqDtlId { get; set; }
        public string DoctorId { get; set; }

        public String PatientName { get; set; }
        public String HospNo { get; set; }
        public String BedName { get; set; }
        public String DoctorName { get; set; }
        public String ReqLocationName { get; set; }
        public String RoomName { get; set; }
        public String ReqOperName { get; set; }
        public String memo { get; set; }
        public String InPatNo { get; set; }
        public Boolean IsBackReq { get; set; }
        public Boolean isprint { get; set; }
        public Boolean IsBack { get; set; }
        public double BackTotality { get; set; }
        public double ReqBackTotality { get; set; }
        public double Totality { get; set; }

    }

    [Serializable]
    public class InAdviceDrugWithSendDrug : BaseModel
    {

        public double Remain { get; set; }
        public double Insurance { get; set; }
        public double NotPay { get; set; }
        public double DrugAmount { get; set; }
        public double Beprice { get; set; }
        public double Amount { get; set; }
        public double reserveAmount { get; set; }
        public InPatFeesList infoInPatFeesList { get; set; }
        public double Deposit { get; set; }
        public double Text { get; set; }
        public double Underline { get; set; }
        public IList<InPatFeesList> lstTemp { get; set; }
        public IList<UspininvoicedtlUmp> lstUspInInvoiceDtl { get; set; }
        public IList<AdviceAuthDtl> lstAdviceAuthDtl { get; set; }
        public InInvoiceDtl infoInvoiceDtl { get; set; }
        public BsFrequency infoBsFrequency { get; set; }

    }




    //////[Description("视图VwInLongDrugApply")]
    [Serializable]
    public class VwInLongDrugApply : BaseModel
    {
        public String InPatNo { get; set; }
        public String HospNo { get; set; }
        public DateTime AdviceTime { get; set; }
        public String DoctorName { get; set; }
        public string HospId { get; set; }
        public int GroupNum { get; set; }
        public String ItemName { get; set; }
        public String Spec { get; set; }
        public string ItemID { get; set; }
        public double Dosage { get; set; }
        public String UnitName { get; set; }
        public string AdviceID { get; set; }
        public string UnitTakeId { get; set; }
        public string FrequencyId { get; set; }
        public string UsageId { get; set; }
        public Boolean IsAttach { get; set; }
        public double TOTALRoom { get; set; }
        public double Amount { get; set; }
        public string DoctorId { get; set; }
        public String Memo { get; set; }
        public String PatientName { get; set; }
        public string LocationId { get; set; }
        public String ItemCode { get; set; }
        public string UnitKC { get; set; }
        public String UnitRoomName { get; set; }
        public String BedName { get; set; }
        public String FrequencyPrintName { get; set; }
        public Boolean IsIssued { get; set; }
        public string RequestId { get; set; }
        public Boolean ForToday { get; set; }
        public string RoomID { get; set; }
        public double StoreNum { get; set; }
        public double BackNum { get; set; }
        public double BackedNum { get; set; }
        public Boolean IsBack { get; set; }
        public Boolean IsBackReq { get; set; }
        public String UsagePrintName { get; set; }
        public int LsExecLoc { get; set; }
        public Boolean IsMinus { get; set; }
        public int FirstDay { get; set; }
        public int LastDay { get; set; }
        public Boolean IsEnd { get; set; }
        public string Expr1 { get; set; }
        public string LocIn { get; set; }
        public int OrderBy { get; set; }
        public String Sex { get; set; }
        public string PatID { get; set; }
        public string UnitInId { get; set; }
        public double PriceIn { get; set; }
        public double Times { get; set; }
        public string BedId { get; set; }
        public int Age { get; set; }
        public string MainDoctorId { get; set; }
        public DateTime UseTime { get; set; }
        public int LsMarkType { get; set; }
        public int Lsrptype { get; set; }
    }



    //////[Description("视图VwInLongDrugApply")]
    [Serializable]
    public class VwPatientIn : BaseModel
    {
        public string GUID { get; set; }
        public String InPatNo { get; set; }
        public String HospNo { get; set; }
        public string PatID { get; set; }
        public string HospId { get; set; }
        public String CardNo { get; set; }
        public String PatientName { get; set; }
        public String Sex { get; set; }
        public int LsInIllness { get; set; }
        public Int32 NTime { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public Boolean IsBaby { get; set; }
        public string BedId { get; set; }
        public string MainBedId { get; set; }
        public Int32 CaptionIcon { get; set; }
        public double Weight { get; set; }
        public string LocationId { get; set; }
        public int Age { get; set; }
        public String AgeString { get; set; }
        public String SexName { get; set; }
        public string DoctorId { get; set; }
        public int LsInStatus { get; set; }
        public Boolean IsYbMt { get; set; }
        public string PatTypeId { get; set; }
        public Boolean IsUrgen { get; set; }
        public Boolean IsNewIn { get; set; }
    }



    //////[Description("视图VwEquipment")]
    [Serializable]
    public class VwEquipment : BaseModel
    {
        public string EID { get; set; }
        public string ECompId { get; set; }
        public String RepairBy { get; set; }
        public DateTime BuyDate { get; set; }
        public DateTime StartDate { get; set; }
        public Int32 LimitYears { get; set; }
        public int LsQuaClass { get; set; }
        public int LsEqClass { get; set; }
        public String LotNo { get; set; }
        public int LsEqStatus { get; set; }
        public double MonthDisc { get; set; }
        public String EInBatchNo { get; set; }
    }



    //////[Description("视图VWHuStores")]
    [Serializable]
    public class VWHuStores : BaseModel
    {
        public string GUID { get; set; }
        public String InBatchNo { get; set; }
        public string HouseId { get; set; }
        public string ItemId { get; set; }
        public String PNo { get; set; }
        public string UnitId { get; set; }
        public string CompId { get; set; }
        public double StockNum { get; set; }
        public double InstoreNum { get; set; }
        public double StockPrice { get; set; }
        public double RetailPrice { get; set; }
        public DateTime StoreDate { get; set; }
        public DateTime ProduceDate { get; set; }
        public DateTime LimitDate { get; set; }
        public Boolean IsBalance { get; set; }
        public Boolean IsNewin { get; set; }
        public Boolean IsBid { get; set; }
        public String ItemName { get; set; }
        public string FormId { get; set; }
        public string ManuId { get; set; }
        public string ProAreaId { get; set; }
        public double UnderLineKc { get; set; }
        public double UperLineKc { get; set; }
        public double NormalLineKc { get; set; }
        public int LsImport { get; set; }
        public Boolean IsInject { get; set; }
        public double RetailTotal { get; set; }
        public double PriceTotal { get; set; }
        public String ItemCode { get; set; }
        public String Spec { get; set; }
        public String AreaKc { get; set; }
        public String UnitName { get; set; }
    }




    //////[Description("VwHuInAndOutInfo")]
    [Serializable]
    public class VwHuInAndOutInfo : BaseModel
    {
        public string GUID { get; set; }
        public String BillNo { get; set; }
        public string HouseId { get; set; }
        public string ItemId { get; set; }
        public string OperId { get; set; }
        public DateTime OperTime { get; set; }
        public Int32 HashInvo { get; set; }
        public bool IsSign { get; set; }
        public double RetailTotle { get; set; }
        public double StockTotle { get; set; }
        public String Type { get; set; }
        public Int32 LsActType { get; set; }
        public DateTime SignTime { get; set; }
        public String Name { get; set; }
        public Int32 PageNumber { get; set; }
        public String LocName { get; set; }
    }




    //////[Description("视图VWRmStoresAll")]
    [Serializable]
    public class VWRmStoresAll : BaseModel
    {
        public string GUID { get; set; }
        public String InBatchNo { get; set; }
        public string RoomId { get; set; }
        public string ItemId { get; set; }
        public String PNo { get; set; }
        public string UnitId { get; set; }
        public string CompId { get; set; }
        public double StockPrice { get; set; }
        public double RetailPrice { get; set; }
        public double StockNum { get; set; }
        public double InstoreNum { get; set; }
        public DateTime StoreDate { get; set; }
        public DateTime ProduceDate { get; set; }
        public DateTime LimitDate { get; set; }
        public Boolean IsBalance { get; set; }
        public String ItemCode { get; set; }
        public String ItemName { get; set; }
        public String Spec { get; set; }
        public double UnderLineKc { get; set; }
        public double UperLineKc { get; set; }
        public double NormalLineKc { get; set; }
        public int ProAreaId { get; set; }
        public string FormId { get; set; }
        public string ManuId { get; set; }
        public int LsImport { get; set; }
        public Boolean IsInject { get; set; }
        public string HouseId { get; set; }
        public String Manufacturername { get; set; }
        public double RetailTotal { get; set; }
        public double PriceTotal { get; set; }
        public String Unitname { get; set; }
        public Boolean IsPoison { get; set; }
        public Boolean IsAntiBacterial { get; set; }
        public Boolean IsAnaes { get; set; }
        public Boolean IsMental { get; set; }
        public Boolean IsSecMental { get; set; }
        public Boolean OptionPrice { get; set; }
        public Boolean IsSpecSum { get; set; }
        public Boolean IsCitySum { get; set; }
    }



    //////[Description("视图VwInHospitalPatient")]
    [Serializable]
    public class VwInHospitalPatient : BaseModel
    {
        public string GUID { get; set; }
        public String HospNo { get; set; }
        public String InPatNo { get; set; }
        public String CardNo { get; set; }
        public String Name { get; set; }
        public String Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public Int32 Age { get; set; }
        public Int32 NTime { get; set; }
        public Boolean IsBaby { get; set; }
        public int LsMarriage { get; set; }
        public String BloodGroup { get; set; }
        public String XNo { get; set; }
        public string CountryId { get; set; }
        public String Residence { get; set; }
        public String City { get; set; }
        public String Province { get; set; }
        public Boolean IsOversea { get; set; }
        public DateTime PassTime { get; set; }
        public String IdCardNo { get; set; }
        public String Company { get; set; }
        public String Occupation { get; set; }
        public string WorktypeId { get; set; }
        public string TallyGroupId { get; set; }
        public String BsTallyGroupName { get; set; }
        public string TallyTypeId { get; set; }
        public String TallyTypeName { get; set; }
        public string PatTypeId { get; set; }
        public String PatTypeName { get; set; }
        public double DiscIn { get; set; }
        public Boolean IsYbMt { get; set; }
        public String YbRegNo { get; set; }
        public string CertificateId { get; set; }
        public double ArrearAmount { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public String PhoneHome { get; set; }
        public String AddressHome { get; set; }
        public String PostCodeHome { get; set; }
        public String AreaCodeHome { get; set; }
        public String PhoneWork { get; set; }
        public String AddressWork { get; set; }
        public String PostCodeWork { get; set; }
        public String AreaCodeWork { get; set; }
        public String LinkmanName { get; set; }
        public string RelationId { get; set; }
        public String LinkmanPhone { get; set; }
        public String LinkmanAddress { get; set; }
        public String LinkmanArea { get; set; }
        public String LinkmanPost { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public int LsInType { get; set; }
        public string LsInWay { get; set; }
        public int LsInIllness { get; set; }
        public string DocMz { get; set; }
        public string DoctorId { get; set; }
        public String DoctorName { get; set; }
        public string LocIn { get; set; }
        public string LocationId { get; set; }
        public String LocationName { get; set; }
        public String BedNo { get; set; }
        public string BedId { get; set; }
        public String RoomNo { get; set; }
        public int LsInStatus { get; set; }
        public String Status { get; set; }
        public DateTime OperTime { get; set; }
        public string OperID { get; set; }
        public int HospitalId { get; set; }
        public String MedicareNo { get; set; }
    }

    [Serializable]
    public class ItemNewRelationCure : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 10)]
        public BsItem BsItem { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 11)]
        public BsItemDrug BsItemDrug { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 12)]
        public IList<BsItemAttach> LstBsItemAttach { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 13)]
        public IList<BsItemFrequency> LstBsItemFrequency { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 14)]
        public IList<BsItemLocation> LstBsItemLocation { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 15)]
        public IList<BsItemPatType> LstBsItemPatType { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 16)]
        public IList<BsItemTally> LstBsItemTally { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 17)]
        public IList<BsItemUnit> LstBsItemUnit { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 18)]
        public IList<BsItemUsage> LstBsItemUsage { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 19)]
        public IList<BsUnitRatio> LstBsUnitRatioInfo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 20)]
        public IList<BsItemYb> LstBsItemYb { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 21)]
        public IList<BsItemIllType> LstBsItemIllType { get; set; }
        public BsItemPacs BsItemPacs { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 23)]
        public bool isPacs { get; set; }
    }

    // UspInsertINPATFEESLIST


    //////[Description("UspInsertINPATFEESLIST")]
    [Serializable]
    public class UspInsertInPatFeesListTemp : BaseModel
    {
        public string GUID { get; set; }
        public String Name { get; set; }
        public string BedId { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public String InPatNo { get; set; }
        public string PatTypeId { get; set; }
        public string LocationId { get; set; }
        public string LocIn { get; set; }
        public string DoctorId { get; set; }
        public double Amount { get; set; }
        public double AmountPay { get; set; }
        public double Deposit { get; set; }
        public double Haspay { get; set; }
        public double Amount_nopay { get; set; }
        public double Amountpay_nopay { get; set; }
        public double Deposit_mz { get; set; }
        public double Deposit_nopay { get; set; }
        public double ArrearAmount { get; set; }
        public double Arrearfei { get; set; }
        public double DiscIn { get; set; }
        public double AllFactget { get; set; }
        public double FactGet { get; set; }
        public Int32 Limitin { get; set; }
        public double YPAmount { get; set; }

    }


    //////[Description("包括了视图VwOuHosInfoSim")]
    //public class VisitOuHosInfo
    //{
    //    //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
    //    public string GUID { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
    //    public String MzRegNo { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
    //    public String PatientName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
    //    public string PatId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
    //    public String CardNo { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
    //    public String Sex { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
    //    public DateTime BirthDate { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = false)]
    //    public Byte Age { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = false)]
    //    public Int32 BabyMonth { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
    //    public String AgeString { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
    //    public DateTime RegTime { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
    //    public Boolean RegLocation { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
    //    public Boolean IsPriority { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
    //    public string RegTypeId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
    //    public String RegTypeName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 16, IsRequired = false)]
    //    public string DoctorId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
    //    public Int32 RegDept { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
    //    public String LocationName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 19, IsRequired = false)]
    //    public Int32 DiagnDept { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 20, IsRequired = false)]
    //    public Boolean IsCancel { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
    //    public String DoctorName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
    //    public string PatTypeId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
    //    public String PatTypeName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
    //    public string TallyTypeId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
    //    public String TallyTypeName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
    //    public string TallyGroupId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
    //    public String TallyGroupName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
    //    public Boolean IsGf { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
    //    public Boolean IsYb { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
    //    public String GetTallyType { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
    //    public String GetTallyTypeName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
    //    public double ArrearAmount { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
    //    public Boolean IsInPatient { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 34, IsRequired = false)]
    //    public Boolean IsRegistration { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
    //    public String Diagnose { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
    //    public String YbSeqNo { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
    //    public Boolean IsOuChargeInput { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 38, IsRequired = false)]
    //    public Boolean IsLocationSee { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 39, IsRequired = false)]
    //    public Boolean IsLocationDiagSee { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 40, IsRequired = false)]
    //    public Boolean IsDiagnosed { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
    //    public String DiagStatus { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
    //    public String Mobile { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
    //    public int HospitalId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 44, IsRequired = false)]
    //    public string TimeSpanId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 45, IsRequired = true)]
    //    public Int32 LineOrder { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 46, IsRequired = false)]
    //    public double Height { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 47, IsRequired = false)]
    //    public double Weight { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 48, IsRequired = false)]
    //    public string WorktypeId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 49, IsRequired = true)]
    //    public String MedicareNo { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 50, IsRequired = false)]
    //    public string SpecialityId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 51, IsRequired = true)]
    //    public Boolean IsPreReg { get; set; }
    //}




    //public class UspOuHosVisitRecord
    //{
    //    //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
    //    public string GUID { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
    //    public DateTime VisitTime { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
    //    public string OperID { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
    //    public DateTime OperTime { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
    //    public int VisitType { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
    //    public string VisitContent { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
    //    public string PatID { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
    //    public string MzRegID { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
    //    public string BackContent { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
    //    public int VisitStatus { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
    //    public int AppraiseType { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
    //    public bool IsAuthed { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
    //    public String PatientName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
    //    public String Mobile { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
    //    public String Sex { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
    //    public String MzRegNo { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
    //    public String AgeString { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
    //    public String CardNo { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 19, IsRequired = false)]
    //    public string DoctorId { get; set; }
    //}



    //public class UspVisitRecordPatient
    //{
    //    //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
    //    public string GUID { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
    //    public DateTime VisitTime { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
    //    public string OperId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
    //    public string OperName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
    //    public DateTime OperTime { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
    //    public int VisitType { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
    //    public string VisitTypeName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
    //    public string VisitContent { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
    //    public string PatId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
    //    public string CardNo { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
    //    public string PatName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
    //    public string SexName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
    //    public string MzRegId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
    //    public string BackContent { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
    //    public int VisitStatus { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
    //    public string VisitStatusName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
    //    public int AppraiseType { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
    //    public string AppraiseTypeName { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
    //    public string DoctorId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
    //    public string DoctorName { get; set; }
    //}



    //public class UspVisitRecordUserByUserId
    //{
    //    //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = false)]
    //    public string GUID { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
    //    public bool IsSelected { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
    //    public string Code { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
    //    public string Name { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
    //    public string Mobile { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
    //    public string UserId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
    //    public string DoctorId { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = false)]
    //    public int LsUserRole { get; set; }
    //}

    [Serializable]
    public class UspOuInvoiceDtlAndItemDrugAndItem : BaseModel
    {
        public UspOuInvoiceDtl uspOuInvoiceDtl { get; set; }

        // //////////////////////////////////////////[DataMemberr(Order = 59, IsRequired = false)]
        public int UnitKc { get; set; }

        // //////////////////////////////////////////[DataMemberr(Order = 60, IsRequired = false)]
        public int MzUnitTotal { get; set; }

        ////////////////////////////////////////////[DataMemberr(Order = 61, IsRequired = false)]
        public int LsRpType { get; set; }

        ////////////////////////////////////////////[DataMemberr(Order = 62, IsRequired = false)]
        public bool IsActive { get; set; }

        //  //////////////////////////////////////////[DataMemberr(Order = 63, IsRequired = true)]
        public bool IsRpForbid { get; set; }
    }

    [Serializable]
    public class GetInLongDrugApply : BaseModel
    {
        public InAdviceLong InAdviceLong { get; set; }
        public InHosInfo InHosInfo { get; set; }
        public BsItem BsItem { get; set; }
        public BsUnit BsUnit { get; set; }
        public BsBed BsBed { get; set; }
        public BsDoctor BsDoctor { get; set; }
        public BsUnit Pub_unit_1 { get; set; }
        public BsFrequency BsFrequency { get; set; }
        public BsUsage BsUsage { get; set; }
    }





    [Serializable]
    public class UspOuRecipe : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 1)]
        public string AgeString { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 2)]
        public string CardNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 3)]
        public string DoctorId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 4)]
        public string DoctorName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 5)]
        public int HowMany { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 6)]
        public bool IsExecuted { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 7)]
        public bool IsPend { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 8)]
        public bool IsPriority { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 9)]
        public string LocationId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 10)]
        public string LocationName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 11)]
        public int LsRepType { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 12)]
        public string Memo { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 13)]
        public string MzRegId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 14)]
        public string MzRegNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 15)]
        public string PatientName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 16)]
        public string PatTypeName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 17)]
        public string RecipeId { get; set; }
        //////////////////////////////////////////[DataMemberr(Order = 18)]
        public string RecipeNum { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 19)]
        public DateTime RecipeTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 20)]
        public string SexName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 21)]
        public string GUID { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 22)]
        public bool IsDoctorInput { get; set; }

    }


    [Serializable]
    public class BloodTransfusionReturnSendBack : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 10)]
        public CkBloodSend CkBloodSend { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 11)]
        public CkLab CkLab { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 12)]
        public BsPatient BsPatient { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 13)]
        public BsLocation BsLocation { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 14)]
        public CkBdBank CkBdBank { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 15)]
        public CkBloodType CkBloodType { get; set; }

    }

    [Serializable]
    public class CustomUspCkLabByOpertimeAndLsStatus : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public String LabNum { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public string PatId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public int LsStatus { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = false)]
        public DateTime OperTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String PatientName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
        public Boolean IsPass { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public Boolean IsCancel { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public Boolean IsPriority { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public string LocationId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public int LsSource { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public string DoctorId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = false)]
        public string HospId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = false)]
        public string MzRegId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public String Sex { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 16, IsRequired = false)]
        public string MachineID { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public String SexName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 18, IsRequired = false)]
        public string ReportOperId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 19, IsRequired = false)]
        public DateTime BirthDate { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 20, IsRequired = false)]
        public Int32 Age { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 21, IsRequired = false)]
        public Int32 AgeMonth { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public String PatientNameModi { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 23, IsRequired = false)]
        public Int32 SampleNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public String TestName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 25, IsRequired = false)]
        public Boolean IsPrint { get; set; }
    }




    //public class CKMachineSample
    //{
    //    //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
    //    public   string Barcode { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
    //    public   string GUID { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
    //    public   bool IsAuthed { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
    //    public   bool IsMic { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = false)]
    //    public   string Labdeptid { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
    //    public   string LabID { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
    //    public   string MachineID { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
    //    public   string MatchBy { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
    //    public   DateTime MatchDate { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
    //    public   string PreSeq { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
    //    public   string SampleNum { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
    //    public   bool SendStatus { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = false)]
    //    public   string SpecimenHeadID { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = false)]
    //    public   int Status { get; set; }

    //    //////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
    //    public   string UserID { get; set; }


    //}



    [Serializable]
    public class SelectHisItem : BaseModel
    {
        public string Code { get; set; }
        public string GUID { get; set; }
        public bool IsSelect { get; set; }
        public double LimitFee { get; set; }
        public string Name { get; set; }
        public string TempStr { get; set; }
        public string TempStr10 { get; set; }
        public string TempStr2 { get; set; }
        public string TempStr3 { get; set; }
        public string TempStr4 { get; set; }
        public string TempStr5 { get; set; }
        public string TempStr6 { get; set; }
        public string TempStr7 { get; set; }
        public string TempStr8 { get; set; }
        public string TempStr9 { get; set; }

    }


    [Serializable]
    public class UspOuInvoiceDtlPatientToday : BaseModel
    {
        public double AmountTally { get; set; }

        public string DocLevId { get; set; }

        public string GUID { get; set; }

        public string LimitGroupId { get; set; }

        public string ItemId { get; set; }
    }

    [Serializable]
    public class UspLimitGroup : BaseModel
    {
        public double AmountTotal { get; set; }
        public string DocLevId { get; set; }
        public string GUID { get; set; }
        public double LimitFeeMz { get; set; }
        public double LimitFeeZy { get; set; }
        public string LimitGroupId { get; set; }

    }

    [Serializable]
    public class UspOuInvoiceFeetyGoupSum : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public string FeeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public double Amount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public double AmountFact { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public double AmountSelf { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public double AmountTally { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public double AmountPay { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = false)]
        public double AmountJZ { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public double AmountZF { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public string InvItemId { get; set; }

    }

    [Serializable]
    public class UspOuInvoiceFeetyGoupSumOuInvoice : BaseModel
    {
        public IList<UspOuInvoiceFeetyGoupSum> lstUspOuInvoiceFeetyGoupSum { get; set; }

        public OuInvoice ouInvoice { get; set; }

        public int limitTop { get; set; }

        public List<UspOuInvoiceDtl> lstUspOuInvoiceDtl { get; set; }

        public IList<UspOuInvoiceDtl> lstHasAttach { get; set; }
    }

    [Serializable]
    public class UspOuRecipeDtlAndOuRecipe : BaseModel
    {
        public IList<UspOuRecipeDtl> lstUspChineseRecipeDtl { get; set; }

        public IList<OuRecipe> lstOuRecipe { get; set; }

        public UspOuInvoiceDtlWithCheckLab uspOuInvoiceDtl { get; set; }

        public List<UspOuInvoiceDtl> lstUspOuInvoiceDtl { get; set; }
    }


    [Serializable]
    public class SendBankFee : BaseModel
    {
        public string GUID { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public String Spec { get; set; }
        public string UnitInId { get; set; }
        public string ItemId { get; set; }
        public double PriceIn { get; set; }
        public double Totality { get; set; }
        public double Amount { get; set; }
        public string Memo { get; set; }
        public string DoctorId { get; set; }
        public string ReqOperId { get; set; }
        public int OrderBy { get; set; }
        public string LocationId { get; set; }
        public string ExecLocationId { get; set; }
        public string BloodTypeId { get; set; }
        public bool IsSelect { get; set; }

    }

    [Serializable]
    public class UspCkBdBank : BaseModel
    {
        public string GUID { get; set; }
        public string PatId { get; set; }
        public string HospId { get; set; }
        public string MzRegId { get; set; }
        public DateTime opertime { get; set; }
        public string InPatNo { get; set; }
        public string PatientName { get; set; }
        public string LocationName { get; set; }
        public string BedName { get; set; }
        public string PatNo { get; set; }
        public string SexName { get; set; }
        public string AgeString { get; set; }
        public string CkItemName { get; set; }
        public string Result { get; set; }
        public string LabId { get; set; }
        public string UserName { get; set; }
        public string BloodTypeId { get; set; }
        public string BloodGroup { get; set; }
        public double Vollume { get; set; }
        public string Account { get; set; }
        public DateTime CollectDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string OfferMan { get; set; }
        public string SerialNo { get; set; }
    }



    [Serializable]
    public class UspInBalanceDtlQry : BaseModel
    {
        public string AdviceId { get; set; }
        public double Amount { get; set; }
        public double AmountFact { get; set; }
        public double AmountInsurance { get; set; }
        public double AmountPay { get; set; }
        public double AmountSelf { get; set; }
        public double AmountTally { get; set; }
        public string BsInvInItemName { get; set; }
        public string BsZyFeetyName { get; set; }
        public string CancelId { get; set; }
        public double ChildPrice { get; set; }
        public string Code { get; set; }
        public double DiscIn { get; set; }
        public double DiscountAoumt { get; set; }
        public double DiscountPrice { get; set; }
        public double DiscSelf { get; set; }
        public string DoctorId { get; set; }
        public string ExecDoctorId { get; set; }
        public string ExecLocId { get; set; }
        public string ExecOperId { get; set; }
        public string FeeHsId { get; set; }
        public string FeeId { get; set; }
        public string HospId { get; set; }
        public string GUID { get; set; }
        public string InvItemId { get; set; }
        public string InvoId { get; set; }
        public bool IsBedFee { get; set; }
        public bool IsCancel { get; set; }
        public bool IsManual { get; set; }
        public bool IsModiDisc { get; set; }
        public bool IsPay { get; set; }
        public bool IsYbCharged { get; set; }
        public bool IsYbxj { get; set; }
        public string ItemId { get; set; }
        public double LimitFee { get; set; }
        public string LimitGroupId { get; set; }
        public string LocationId { get; set; }
        public int LsGfType { get; set; }
        public int LsMarkType { get; set; }
        public int LsPerform { get; set; }
        public int LsReportType { get; set; }
        public string MainDoctorId { get; set; }
        public string Memo { get; set; }
        public string Name { get; set; }
        public string NotAuthMemo { get; set; }
        public string OperId { get; set; }
        public DateTime OperTime { get; set; }
        public double PriceIn { get; set; }
        public string RegDate { get; set; }
        public DateTime RegOperDate { get; set; }
        public string RegOperId { get; set; }
        public DateTime RegOperTime { get; set; }
        public string Spec { get; set; }
        public bool TempBool { get; set; }
        public string TempStr { get; set; }
        public string TempStr2 { get; set; }
        public double Totality { get; set; }
        public string UnitId { get; set; }

    }




    [Serializable]
    public class UspNewInCheckRecipeDtl : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = false)]
        public Boolean IsDoctorInput { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String IssueTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = false)]
        public string PrintOperId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = false)]
        public DateTime PrintTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public Boolean IsPrint { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
        public string CancelOperId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public DateTime CancelTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = false)]
        public Boolean IsCancel { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public Boolean IsCharged { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = false)]
        public int Expr1 { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public String XDRpId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = false)]
        public Boolean IsOtherFee { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = false)]
        public Boolean IsAttach { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = false)]
        public string UnitDiagId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 16, IsRequired = false)]
        public double Totality { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 17, IsRequired = false)]
        public int Days { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 18, IsRequired = false)]
        public string UsageId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 19, IsRequired = false)]
        public string FrequencyId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 20, IsRequired = false)]
        public double Dosage { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 21, IsRequired = false)]
        public int GroupNum { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 22, IsRequired = false)]
        public string ItemId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public string RecipeId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public int ListNum { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public String UnitDiagName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public String ItemCode { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public String ItemName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public String Spec { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 29, IsRequired = false)]
        public double PriceDiag { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 30, IsRequired = false)]
        public double Amount { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public String XdRpName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public String Memo { get; set; }

    }






    [Serializable]
    public class VwBsPatType : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string Name { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public double DiscDiag { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public double DiscIn { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public int LsGFPatType { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public string LsGFPatTypeName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public string TallyTypeId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public string TallyTypeName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public string TallyGroupId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public string TallyGroupName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public bool IsGf { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public bool IsYb { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public double ArrearAmount { get; set; }
    }


    [Serializable]
    public class VwOuInvoice : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string InvoNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public DateTime InvoTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public string InvoId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public double Beprice { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public double FactGet { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public double Insurance { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public double PaySelf { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public double AmountPay { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public double AddFee { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public string TallyNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public string MzRegId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public string PatId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public string CardNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public string MedicareNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public string PatientName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public string DoctorId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public string DoctorName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public string RegDept { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 20, IsRequired = false)]
        public string LocationID { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public string LocationName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public string MzRegNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public DateTime RegTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public string Sex { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public string SexName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public string Age { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public string PatTypeId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public string PatTypeName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 29, IsRequired = false)]
        public double DiscDiag { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 30, IsRequired = false)]
        public double DiscIn { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 31, IsRequired = false)]
        public int LsGFPatType { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public string LsGFPatTypeName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 33, IsRequired = false)]
        public string TallyTypeId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public string TallyTypeName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 35, IsRequired = false)]
        public string TallyGroupId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public string TallyGroupName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public bool IsGf { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 38, IsRequired = false)]
        public bool IsYb { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 39, IsRequired = false)]
        public string WorktypeId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public string WorkTypeName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public string RegTypeId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
        public string RegTypeName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public DateTime OperTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 44, IsRequired = true)]
        public string OperId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 45, IsRequired = true)]
        public string OperName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 46, IsRequired = true)]
        public bool IsCancel { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 47, IsRequired = false)]
        public DateTime CancelOperTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 48, IsRequired = false)]
        public string CancelOperId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 49, IsRequired = true)]
        public string CancelMemo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 50, IsRequired = true)]
        public string CancelOperName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 51, IsRequired = false)]
        public string InvoLastId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 52, IsRequired = false)]
        public int CancelHospital { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 53, IsRequired = true)]
        public bool IsTransfer { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 54, IsRequired = false)]
        public int HospitalId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 55, IsRequired = true)]
        public string InvoLastNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 56, IsRequired = true)]
        public string Remark { get; set; }
    }

    [Serializable]
    public class UspOuInvoiceDynamic : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string MzRegId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public double Insurance { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public string MedicareNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public string MzRegNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = false)]
        public string PatientName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public string InvoLastNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public double Beprice { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public string InvoNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public double AmountPay { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public double PaySelf { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public string InvoTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public string DoctorName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public string OperName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public string CardNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public bool IsCancel { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public string CancelOperName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public string CancelOperTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public string SexName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public string Age { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public string CancelMemo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public string Remark { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public double PayA { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public double PayB { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public double PayC { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public double PayD { get; set; }
    }


    [Serializable]
    public class VwHisOutPatient : BaseModel
    {
        //////////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string PatientID { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string PatientName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 3, IsRequired = false)]
        public string DoctorId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public string DoctorName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public string LocationID { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public string LocationName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public string MzRegNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public DateTime RegTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public string RegDept { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public string Sex { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public string Age { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public string SexName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public string CardNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 14, IsRequired = false)]
        public DateTime BirthDate { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public bool IsBaby { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public string RegTypeId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public string RoomNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public string RegTypeName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public bool IsPriority { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 20, IsRequired = false)]
        public bool IsCancel { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public bool IsElder { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public bool IsFreeReg { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public bool IsFreeDiag { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public bool IsInPatient { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public bool IsPreReg { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public string PatId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public string MedicareNo { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 28, IsRequired = false)]
        public string WorktypeId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public string WorkTypeName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public string PatTypeId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public string PatTypeName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public double DiscDiag { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public double DiscIn { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 34, IsRequired = false)]
        public int LsGFPatType { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public string LsGFPatTypeName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public string TallyTypeId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 37, IsRequired = true)]
        public string TallyTypeName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 38, IsRequired = false)]
        public string TallyGroupId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 39, IsRequired = true)]
        public string TallyGroupName { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public bool IsGf { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public bool IsYb { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 42, IsRequired = false)]
        public string FamilyId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public string CommitteeId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 44, IsRequired = true)]
        public string OperId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 45, IsRequired = true)]
        public int LineOrder { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 46, IsRequired = false)]
        public DateTime CancelTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 47, IsRequired = false)]
        public bool IsRegistration { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 48, IsRequired = true)]
        public string Diagnose { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 49, IsRequired = true)]
        public string PreRegRegWay { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 50, IsRequired = true)]
        public int HospitalId { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 51, IsRequired = true)]
        public DateTime OperTime { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 52, IsRequired = false)]
        public string DiagnDept { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 53, IsRequired = true)]
        public bool IsTransfer { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 54, IsRequired = false)]
        public bool IsRegister { get; set; }

        //////////////////////////////////////////[DataMemberr(Order = 55, IsRequired = true)]
        public string TimeSpanSubId { get; set; }

    }


    [Serializable]
    public class InEmrAndGblEmrCatalog : BaseModel
    {
        public IList<InEMR> infoInEMR { get; set; }


        public GblEMRCatalog infoGblEMRCatalog { get; set; }

    }


    [Serializable]
    public class UspGetValueSql : BaseModel
    {
        public double SORCE { get; set; }

    }


    [Serializable]
    public class UspEmrScoreQry : BaseModel
    {
        public String GroupCode { get; set; }
        public string GroupID { get; set; }
        public String GroupName { get; set; }
        public string GUID { get; set; }
        public Boolean IsActive { get; set; }
        public Boolean IsLock { get; set; }
        public String ItemCode { get; set; }
        public string ItemId { get; set; }
        public String ItemName { get; set; }
        public String Memo { get; set; }
        public String MethodName { get; set; }
        public Int32 OrderBy { get; set; }
        public Int32 Point { get; set; }
        public String Score { get; set; }
        public String SQL { get; set; }
        public String Standard { get; set; }
        public String TipInfo { get; set; }
    }

    [Serializable]
    public class UspOuInInvoiceQry : BaseModel
    {
        public double AddFee { get; set; }
        public double AmountPay { get; set; }
        public double Arrearage { get; set; }
        public double Beprice { get; set; }
        public Int32 CancelHospital { get; set; }
        public String CancelMemo { get; set; }
        public string CancelOperID { get; set; }
        public DateTime CancelOperTime { get; set; }
        public String CardNo { get; set; }
        public String Company { get; set; }
        public double Complement { get; set; }
        public double Deposit { get; set; }
        public double FactGet { get; set; }
        public string GUID { get; set; }
        public String InPatNo { get; set; }
        public double Insurance { get; set; }
        public string InvoLastId { get; set; }
        public String InvoNo { get; set; }
        public DateTime InvoTime { get; set; }
        public Boolean IsCancel { get; set; }
        public string LocationId { get; set; }
        public string OperId { get; set; }
        public String PatientName { get; set; }
        public string PatTypeId { get; set; }
        public double PaySelf { get; set; }
        public string PaywayId { get; set; }
        public double ReAmount { get; set; }
        public DateTime ReAmountDate { get; set; }
        public String ReAmountMemo { get; set; }
        public String Remark { get; set; }
        public String Soruce { get; set; }
        public String TallyNo { get; set; }
    }


    [Serializable]
    public class InEmrAndInHosInfo : BaseModel
    {
        public InEMR infoInEMR { get; set; }

        public InHosInfo hostinfo { get; set; }

        public string currentId { get; set; }
    }


    [Serializable]
    public class BsDocRegTypeDtl : BaseModel
    {
        public string GUID { get; set; }
        public string DocRegTypeId { get; set; }
        public int LineOrder { get; set; }
        public string PatId { get; set; }
        public string MzRegId { get; set; }
        public string RegSpanSubId { get; set; }
        public string SignalSourceId { get; set; }
        public string ActualSignalSourceId { get; set; }
        public bool IsDrtStatus { get; set; }
        public bool IsAppointment { get; set; }
        public string OperId { get; set; }
        public DateTime OperTime { get; set; }
        public bool IsActive { get; set; }
        public bool IsLockSignal { get; set; }
        public DateTime LockSignalTime { get; set; }
        public string TimeBucket { get; set; }
        public string F1 { get; set; }
        public string RegNo { get; set; }
    }


    [Serializable]
    public class BsSignalSource : BaseModel
    {
        public string GUID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }



    [Serializable]
    public class ProcParams : BaseModel
    {
        public string GUID { get; set; }
        public string paramName { get; set; }
        public string symbol { get; set; }
        public string val { get; set; }
    }


    [Serializable]
    public class VisitOuHosInfoReg : BaseModel
    {
        public string RegTime { get; set; }
        public string WeekDay { get; set; }
        public int Days { get; set; }
        public string OperTime { get; set; }
        public string MzRegNo { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string AgeString { get; set; }
        public string LocName { get; set; }
        public string DocName { get; set; }
        public string IsPreReg { get; set; }
        public string IdCardNo { get; set; }
        public string MedicareNo { get; set; }
        public string Phone { get; set; }
        public string SignalSourceName { get; set; }
        public string MzRegId { get; set; }
        public string PatId { get; set; }
        public string SignalSourceId { get; set; }
    }

    [Serializable]
    public class UspBsBPItem : BsBPItem
    {
        public bool IsSelect { get; set; }
    }



    [Serializable]
    public class UspBsBpItemLsRpType : BsItem
    {
        public bool IsSelect { get; set; }

    }


    [Serializable]
    public class UspBpPatientGroupHisIllRelation : BaseModel
    {
        public string GUID { get; set; }
        public string PatientGroup { get; set; }
        public int OrderBy { get; set; }

    }



    [Serializable]
    public class PatEmrRecord : BaseModel
    {
        public string GUID { get; set; }
        public string CardNo { get; set; }
        public string DocType { get; set; }
        public string LocationName { get; set; }
        public string Memo { get; set; }
        public string OperName { get; set; }
        public DateTime OperTime { get; set; }
        public string PatId { get; set; }
        public string PatientName { get; set; }
    }

    [Serializable]
    public class TepEmrInfo : BaseModel
    {
        public string DoctorName { get; set; }
        public string EmrLevel { get; set; }
        public string EMRName { get; set; }
        public string HospId { get; set; }
        public string HospNo { get; set; }
        public string GUID { get; set; }
        public string InpatNo { get; set; }
        public DateTime InTime { get; set; }
        public string ItemName { get; set; }
        public string LocationName { get; set; }
        public DateTime OperTime { get; set; }
        public DateTime OutTime { get; set; }
        public string PartScore { get; set; }
        public string PatName { get; set; }
        public string Remarks { get; set; }
    }



    [Serializable]
    public class VwOuHosInfoSim : BaseModel
    {
        public string GUID { get; set; }
        public String MzRegNo { get; set; }
        public String PatientName { get; set; }
        public string PatId { get; set; }
        public String CardNo { get; set; }
        public DateTime BirthDate { get; set; }
        public String Sex { get; set; }
        public int Age { get; set; }
        public int BabyMonth { get; set; }
        public String AgeString { get; set; }
        public DateTime RegTime { get; set; }
        public Boolean RegLocation { get; set; }
        public Boolean IsPriority { get; set; }
        public string RegTypeId { get; set; }
        public String RegTypeName { get; set; }
        public string DoctorId { get; set; }
        public string RegDept { get; set; }
        public String LocationName { get; set; }
        public string DiagnDept { get; set; }
        public Boolean IsCancel { get; set; }
        public String DoctorName { get; set; }
        public string PatTypeId { get; set; }
        public String PatTypeName { get; set; }
        public string TallyTypeId { get; set; }
        public String TallyTypeName { get; set; }
        public string TallyGroupId { get; set; }
        public String TallyGroupName { get; set; }
        public Boolean IsGf { get; set; }
        public Boolean IsYb { get; set; }
        public String GetTallyType { get; set; }
        public String GetTallyTypeName { get; set; }
        public Boolean IsInPatient { get; set; }
        public Boolean IsRegistration { get; set; }
        public String Diagnose { get; set; }
        public String YbSeqNo { get; set; }
        public Boolean IsOuChargeInput { get; set; }
        public Boolean IsLocationSee { get; set; }
        public Boolean IsLocationDiagSee { get; set; }
        public Boolean IsDiagnosed { get; set; }
        public String DiagStatus { get; set; }
        public String Mobile { get; set; }
        public int HospitalId { get; set; }
        public string TimeSpanId { get; set; }
        public int LineOrder { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string WorktypeId { get; set; }
        public String MedicareNo { get; set; }
        public string SpecialityId { get; set; }
        public double ArrearAmount { get; set; }

    }

    [Serializable]
    public class uspPsApplyReportSelectDynamic : BaseModel
    {
        public string GUID { get; set; }

        public string ApplyNo { get; set; }

        public DateTime OperTime { get; set; }

        public string ApplyOperName { get; set; }

        public string LocationId { get; set; }

        public string LocationName { get; set; }

        public string DoctorId { get; set; }

        public string DoctorName { get; set; }

        public string ItemId { get; set; }

        public string ItemName { get; set; }

        public string InPatNo { get; set; }

        public string MzRegNo { get; set; }

        public string CardNo { get; set; }

        public int XType { get; set; }

        public string Equipment { get; set; }

        public DateTime CheckTime { get; set; }

        public string CheckOperName { get; set; }

        public string CheckBody { get; set; }

        public bool IsAbNormal { get; set; }

        public int LsStatus { get; set; }

        public string PatientName { get; set; }

        public string ReportOperName { get; set; }


    }



    [Serializable]
    public class UspGetRdChronicInfo : BaseModel
    {
        public string GUID { get; set; }
        public string PatId { get; set; }
        public string HospNo { get; set; }
        public string CardNo { get; set; }
        public string PatientName { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string AgeString { get; set; }
        public DateTime OperTime { get; set; }
        public string OpenName { get; set; }
        public string OpenId { get; set; }
        public int DiseaseType { get; set; }
        public string LoactionName { get; set; }
        public string LocationId { get; set; }
        public string LocationPhone { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string MzRegId { get; set; }
        public string LsIllBaseName { get; set; }
        public string LsCardTypeName { get; set; }
        public string LsCensusName { get; set; }
        public string IllnessName { get; set; }
        public int FormerlyIllness { get; set; }
        public DateTime YDiagDate { get; set; }
        public string DeadCause { get; set; }
        public string PathologyType { get; set; }
        public string NativeName { get; set; }
        public string LevelName { get; set; }
        public string ICD { get; set; }
        public string NationName { get; set; }
        public string Mobile { get; set; }
        public string IdCardNo { get; set; }
        public string Company { get; set; }
        public string AddressHome { get; set; }
        public string WorkTypeName { get; set; }
        public DateTime DiagDate { get; set; }
        public DateTime DeadDate { get; set; }
        public string ReciOperName { get; set; }
        public string ReportUnit { get; set; }
        public string ReportDate { get; set; }

    }



    [Serializable]
    public class UspRdFollowWarning : BaseModel
    {
        public string GUID { get; set; }
        public string PatId { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string SexName { get; set; }
        public int Age { get; set; }
        public string CommitteeId { get; set; }
        public string FamilyId { get; set; }
        public string Residence { get; set; }
        public DateTime OperTime { get; set; }
        public string OperID { get; set; }
        public string Code { get; set; }
        public DateTime PlanTime { get; set; }
        public string VisitMan { get; set; }
        public string Purpose { get; set; }
        public short LsVisitType { get; set; }
        public bool IsVisited { get; set; }

    }


    [Serializable]
    public class VwBsPatient : BaseModel
    {
        public string GUID { get; set; }
        public string InPatNo { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string SexName { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public bool isBaby { get; set; }
        public string NationId { get; set; }
        public string CountryId { get; set; }
        public string ProvinceId { get; set; }
        public string RegionId { get; set; }
        public string AreaId { get; set; }
        public string CommitteeId { get; set; }
        public string CommitteeName { get; set; }
        public string PoliceStationId { get; set; }
        public string PoliceStationName { get; set; }
        public string FamilyId { get; set; }
        public string FamilyName { get; set; }
        public string Native { get; set; }
        public bool IsSign { get; set; }
        public string SignGroupId { get; set; }
        public DateTime FamilyOpertime { get; set; }
        public string Residence { get; set; }
        public string PhoneWork { get; set; }
        public string AddressWork { get; set; }
        public string PostCodeWork { get; set; }
        public string AreaCodeWork { get; set; }
        public string PhoneHome { get; set; }
        public string AddressHome { get; set; }
        public string PostCodeHome { get; set; }
        public string AreaCodeHome { get; set; }
        public string MedicareNo { get; set; }
        public string AccountNo { get; set; }
        public bool IsOversea { get; set; }
        public DateTime PassTime { get; set; }
        public string Company { get; set; }
        public string Occupation { get; set; }
        public int LsMarriage { get; set; }
        public string MarriageName { get; set; }
        public string IdCardNo { get; set; }
        public string CertificateId { get; set; }
        public string CertificateName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string WorktypeId { get; set; }
        public string PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public string TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public string TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public bool IsGf { get; set; }
        public bool IsYb { get; set; }
        public string BloodGroup { get; set; }
        public string XNo { get; set; }
        public string Sensitive { get; set; }
        public string RelaMasterId { get; set; }
        public string RelationName { get; set; }
        public string MotherPatId { get; set; }
        public string LinkmanName { get; set; }
        public string RelationId { get; set; }
        public string LinkmanPost { get; set; }
        public string LinkmanArea { get; set; }
        public string LinkmanAddress { get; set; }
        public string LinkmanPhone { get; set; }
        public bool IsHouseMaster { get; set; }
        public int LsCensus { get; set; }
        public string Census { get; set; }
        public string EduLevelName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Circumference { get; set; }
        public int Waistline { get; set; }
        public int Sternline { get; set; }
        public int LsSport { get; set; }
        public string Sport { get; set; }
        public int LsSportTime { get; set; }
        public int LsSportType { get; set; }
        public int LsBitHabit { get; set; }
        public int SleepHour { get; set; }
        public string LsSleepTrouble { get; set; }
        public string SleepTrouble { get; set; }
        public string SmokeHistory { get; set; }
        public string DrinkHistory { get; set; }
        public string OtherHabit { get; set; }
        public bool IsActive { get; set; }
        public string InActiveReason { get; set; }
        public DateTime InActiveTime { get; set; }
        public string InActiveOperID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int IconIndex { get; set; }
        public DateTime OperTime { get; set; }
        public string OperID { get; set; }
        public string RoadName { get; set; }
        public string LevelId { get; set; }
    }


    [Serializable]

    public class UspGetSelectRdHurtInfo : BaseModel
    {
        public string GUID { get; set; }
        public string PatId { get; set; }
        public string PatName { get; set; }
        public string PatSex { get; set; }
        public string AgeString { get; set; }
        public string PatMobile { get; set; }
        public string PatAddressHome { get; set; }
        public string PatIdCardNo { get; set; }
        public string PatLevel { get; set; }
        public string PatWorkType { get; set; }
        public DateTime OperTime { get; set; }
        public string OperID { get; set; }
        public string Code { get; set; }
        public string MzRegId { get; set; }
        public string HospitalCode { get; set; }
        public DateTime HurtTime { get; set; }
        public DateTime DiagDate { get; set; }
        public string LsHurtReason { get; set; }
        public string LsHurtCensus { get; set; }
        public string LsHurtPlace { get; set; }

        public string LsHurtActivity { get; set; }
        public string LsIsDeliberately { get; set; }
        public string LsHurtNature { get; set; }
        public string LsHurtPosition { get; set; }
        public string LsHurtDegree { get; set; }
        public string LsHurtEnding { get; set; }
        public string LsHurtProduct { get; set; }
        public string LsHurtProducts { get; set; }
        public string ProductName { get; set; }
        public string ProductNames { get; set; }
        public string ProductType { get; set; }
        public string ProductTypes { get; set; }
        public string Typical { get; set; }
        public string LocName { get; set; }
        public string LocationId { get; set; }
        public string HurtClinical { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }

    }






    [Serializable]
    public class UspGetRdReportPatInfo : BaseModel
    {
        public string GUID { get; set; }
        public string PatId { get; set; }
        public string CardNo { get; set; }
        public string PatientName { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string AgeString { get; set; }
        public DateTime OperTime { get; set; }
        public string OpenName { get; set; }
        public string OperId { get; set; }
        public int DiseaseType { get; set; }
        public string LoactionName { get; set; }
        public string LocationId { get; set; }
        public string LocationPhone { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string MzRegId { get; set; }
        public string CarType { get; set; }
        public string JName { get; set; }
        public string Mobile { get; set; }
        public string IdCardNo { get; set; }
        public string Company { get; set; }
        public string AddressHome { get; set; }
        public string LsZoneName { get; set; }
        public string WorkTypeName { get; set; }
        public DateTime IllDate { get; set; }
        public DateTime DiagDate { get; set; }
        public DateTime DeadDate { get; set; }
        public string LsCancelTypeName { get; set; }
        public string IllnessName { get; set; }
        public string LsIllSourceName { get; set; }
        public string LsClinicTypeName { get; set; }
        public string IllIdCor { get; set; }
        public string Memo { get; set; }

    }




    [Serializable]
    public class UspBsPatient : BaseModel
    {
        public string GUID { get; set; }
        public string InPatNo { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string SexName { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public bool isBaby { get; set; }
        public string NationId { get; set; }
        public string CountryId { get; set; }
        public string ProvinceId { get; set; }
        public string RegionId { get; set; }
        public string AreaId { get; set; }
        public string CommitteeId { get; set; }
        public string CommitteeName { get; set; }
        public string PoliceStationId { get; set; }
        public string PoliceStationName { get; set; }
        public string FamilyId { get; set; }
        public string FamilyName { get; set; }
        public string Native { get; set; }
        public bool IsSign { get; set; }
        public string SignGroupId { get; set; }
        public DateTime FamilyOpertime { get; set; }
        public string Residence { get; set; }
        public string PhoneWork { get; set; }
        public string AddressWork { get; set; }
        public string PostCodeWork { get; set; }
        public string AreaCodeWork { get; set; }
        public string PhoneHome { get; set; }
        public string AddressHome { get; set; }
        public string PostCodeHome { get; set; }
        public string AreaCodeHome { get; set; }
        public string MedicareNo { get; set; }
        public string AccountNo { get; set; }
        public bool IsOversea { get; set; }
        public DateTime PassTime { get; set; }
        public string Company { get; set; }
        public string Occupation { get; set; }
        public short LsMarriage { get; set; }
        public string MarriageName { get; set; }
        public string IdCardNo { get; set; }
        public string CertificateId { get; set; }
        public string CertificateName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string WorktypeId { get; set; }
        public string PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public string TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public string TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public bool IsGf { get; set; }
        public bool IsYb { get; set; }
        public string BloodGroup { get; set; }
        public string XNo { get; set; }
        public string Sensitive { get; set; }
        public string RelaMasterId { get; set; }
        public string RelationName { get; set; }
        public string MotherPatId { get; set; }
        public string LinkmanName { get; set; }
        public string RelationId { get; set; }
        public string LinkmanPost { get; set; }
        public string LinkmanArea { get; set; }
        public string LinkmanAddress { get; set; }
        public string LinkmanPhone { get; set; }
        public bool IsHouseMaster { get; set; }
        public short LsCensus { get; set; }
        public string Census { get; set; }
        public string EduLevelName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public short Circumference { get; set; }
        public short Waistline { get; set; }
        public short Sternline { get; set; }
        public short LsSport { get; set; }
        public string Sport { get; set; }
        public short LsSportTime { get; set; }
        public short LsSportType { get; set; }
        public short LsBitHabit { get; set; }
        public short SleepHour { get; set; }
        public string LsSleepTrouble { get; set; }
        public string SleepTrouble { get; set; }
        public string SmokeHistory { get; set; }
        public string DrinkHistory { get; set; }
        public string OtherHabit { get; set; }
        public bool IsActive { get; set; }
        public string InActiveReason { get; set; }
        public DateTime InActiveTime { get; set; }
        public string InActiveOperID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public DateTime OperTime { get; set; }
        public string OperID { get; set; }
        public string RoadName { get; set; }
        public string LevelId { get; set; }
        public string PatId { get; set; }
    }


    [Serializable]
    public class UspVwOuHosInfoDynamic : BaseModel
    {
        public string GUID { get; set; }
        public string MzRegNo { get; set; }
        public string PatientName { get; set; }
        public string PatId { get; set; }
        public string CardNo { get; set; }
        public DateTime BirthDate { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public int BabyMonth { get; set; }
        public DateTime RegTime { get; set; }
        public bool RegLocation { get; set; }
        public bool IsPriority { get; set; }
        public string RegTypeId { get; set; }
        public string RegTypeName { get; set; }
        public string DoctorId { get; set; }
        public string LocationName { get; set; }
        public string DiagnDept { get; set; }
        public bool IsCancel { get; set; }
        public string DoctorName { get; set; }
        public string PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public string TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public string TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public bool IsGf { get; set; }
        public bool IsYb { get; set; }
        public string GetTallyType { get; set; }
        public string GetTallyTypeName { get; set; }
        public double ArrearAmount { get; set; }
        public bool IsInPatient { get; set; }
        public bool IsRegistration { get; set; }
        public string Mobile { get; set; }
        public int HospitalId { get; set; }
        public string TimeSpanId { get; set; }
        public int LineOrder { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string WorktypeId { get; set; }
        public string MedicareNo { get; set; }
        public string AgeString { get; set; }
        public string Diagnose { get; set; }
        public string DoctorCode { get; set; }
        public string LocationCode { get; set; }
        public string YbSeqNo { get; set; }
        public bool IsOuChargeInput { get; set; }
        public string MzRegNoOri { get; set; }
    }




    [Serializable]
    public class UspGblFunDemoName : BaseModel
    {
        public string GUID { get; set; }
        public string Name { get; set; }
    }



    [Serializable]
    public class UspBsUserMenuCommon : BaseModel
    {
        public string GUID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ReportType { get; set; }
        public short IconIndex { get; set; }
    }

    [Serializable]
    public class CalBirthdayInfo : BaseModel
    {
        public int Age { get; set; }
        public string AgeString { get; set; }
        public DateTime Birthday { get; set; }
        public int Days { get; set; }
        public int Hour { get; set; }
        public bool IsYounger { get; set; }
        public int Minute { get; set; }
        public int Months { get; set; }
        public DateTime NowDate { get; set; }
        public int Second { get; set; }
    }


    [Serializable]
    public class UspInInvoiceByZyFeeTyp : BaseModel
    {
        public string GUID { get; set; }
        public string ItemName { get; set; }
        public string FeeId { get; set; }
        public double Amount { get; set; }
        public double AmountFact { get; set; }
        public double AmountSelf { get; set; }
        public double AmountTally { get; set; }
        public double AmountPay { get; set; }
        public double AmountJZ { get; set; }
        public double AmountZF { get; set; }
        public double AmountYH { get; set; }
        public double MzAmount { get; set; }
        public string Name { get; set; }
        public DateTime OperTime { get; set; }
        public string InPatNo { get; set; }


    }


    [Serializable]
    public class BsBedSelectOnlyFloorNum : BaseModel
    {
        public int FloorNum { get; set; }
        public string GUID { get; set; }
        public string Name { get; set; }
        public int OrderBy { get; set; }
        public string PrintName { get; set; }
        public string LocationId { get; set; }
    }



    [Serializable]
    public class UspBsItemAttachXdDtl : BaseModel
    {
        public string BsitemUnit { get; set; }
        public string Code { get; set; }
        public string GUID { get; set; }
        public string Name { get; set; }
        public double PriceDiag { get; set; }
        public double PriceIn { get; set; }
        public string PyCode { get; set; }
        public string Spec { get; set; }
        public double Totality { get; set; }
        public string WbCode { get; set; }
        public string XdID { get; set; }
        public string XDName { get; set; }
        public string XdPrice { get; set; }
        public string XdUnit { get; set; }
    }


    [Serializable]
    public class ExecInsertAccountItem : BaseModel
    {
        public string HospId { get; set; }
        public string AdviceId { get; set; }
        public string ItemId { get; set; }
        public double Totality { get; set; }
        public int LsPerform { get; set; }
        public string CancelId { get; set; }
        public string DoctorId { get; set; }
        public string LocationId { get; set; }
        public string ExecLocationId { get; set; }
        public double PriceIn { get; set; }
        public string ReqOperId { get; set; }
        public string OperId { get; set; }
        public int LsMarkType { get; set; }
        public string ExecOperId { get; set; }
        public DateTime RegOperTime { get; set; }
        public string RegDate { get; set; }
        public string Memo { get; set; }
    }

    [Serializable]
    public class UspBsXdRpDtail : BaseModel
    {
        public double Amount { get; set; }
        public string Code { get; set; }
        public int Days { get; set; }
        public double DiscountAoumt { get; set; }
        public double Dosage { get; set; }
        public string ExecLocId { get; set; }
        public double FeeTotality { get; set; }
        public string FormId { get; set; }
        public string FrequencyId { get; set; }
        public int GroupNum { get; set; }
        public string GUID { get; set; }
        public bool IsActive { get; set; }
        public bool IsRpForbid { get; set; }
        public string ItemId { get; set; }
        public double LimitTotalZy { get; set; }
        public int LsRpType { get; set; }
        public string Memo { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string RecipeId { get; set; }
        public string Spec { get; set; }
        public string TempStr { get; set; }
        public double Totality { get; set; }
        public string UnitDiagId { get; set; }
        public string UnitId { get; set; }
        public string UnitTakeId { get; set; }
        public string UsageId { get; set; }
        public string XdRpId { get; set; }
    }




    [Serializable]
    public class InsertAccount : BaseModel
    {
        public DateTime Date { get; set; }
        public string OperId { get; set; }
        public string ParamHospID { get; set; }
        public string ParamLocationID { get; set; }
        public string Exceptionstring { get; set; }
    }



    [Serializable]
    public class BsBphisIllRelationAndBsBPIllList : BaseModel
    {
        public string GUID { get; set; }
        public string HISIllId { get; set; }
        public string BPIllId { get; set; }
        public string BPIllName { get; set; }
        public string XmlName { get; set; }
    }



    [Serializable]
    public class WestItem : BaseModel
    {
        public bool IsSelect { get; set; }
        public string CureDtlId { get; set; }
        public bool IsBP { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemName2 { get; set; }
        public string Spec { get; set; }
        public double Price { get; set; }
        public string Reason { get; set; }
        public string Company { get; set; }
        public string ItemId { get; set; }
        public string EngDesc { get; set; }
        public string LongDesc { get; set; }
        public double YBAvgPrice { get; set; }
        public int LsRpType { get; set; }
    }

    [Serializable]
    public class UspBsBpCureDtl : BaseModel
    {
        public string GUID { get; set; }
        public bool IsSelect { get; set; }
        public string CureId { get; set; }
        public string TypeCode { get; set; }
        public string TypeCodeName { get; set; }
        public string ItemId { get; set; }
        public string TYItemName { get; set; }
        public string RelationCode { get; set; }
        public string RelationCodeName { get; set; }
        public string WayCode { get; set; }
        public string WayCodeName { get; set; }
        public string Remark { get; set; }

    }


    [Serializable]
    public class UspBsBPCure : BaseModel
    {
        public string GUID { get; set; }
        public string CureRuleName { get; set; }
        public string CureRuleDesc { get; set; }
        public int OrderBy { get; set; }
        public string Waycode { get; set; }
        public string WayCodeName { get; set; }

    }




    [Serializable]
    public class UspGetInpatNoMtObserved : BaseModel
    {
        public string InPatNo { get; set; }
    }



    [Serializable]
    public class GlobalResult : BaseModel
    {
        public string InvoLastId { get; set; }
        public string MasterId { get; set; }
        public IList<InPay> LstInPay { get; set; }

    }

    [Serializable]
    public class GroupNumAndSN : BaseModel
    {
        public int LongGroupNum { get; set; }
        public string LongSN { get; set; }
        public int TempGroupNum { get; set; }
        public string TempSN { get; set; }

    }





    [Serializable]
    public class AddDayFeeGetReport : BaseModel
    {
        public int Bills { get; set; }
        public int BillCancel { get; set; }
        public double AmountSum { get; set; }
        public double Amount { get; set; }
        public double AmountCancel { get; set; }
        public double Insurance { get; set; }
        public double AmountPay { get; set; }
        public double AmountYF { get; set; }
    }




    [Serializable]
    public class MBpBsBPHISIllRelation : BaseModel
    {
        public string GUID { set; get; }
        public string HISIllId { set; get; }
        public string BPIllId { set; get; }
        public string BPIllName { set; get; }
        public string HosMzIllID { set; get; }
        public string IcdId { set; get; }
        public string IllDesc { set; get; }
        public bool IsBP { set; get; }
        public string xmlname { set; get; }
    }


    [Serializable]
    public class ReturnGetBsItemPatTypeAndInInvoiceDtlChkByHospId : BaseModel
    {
        public IList<UspInInvoiceDtlChkByHospId> LstInInvoiceDtlChkByHospId { set; get; }
        public IList<BsItemPatType> LstBsItemPatType { set; get; }
    }

    [Serializable]
    public class UspBsItemMiniDynamic : BaseModel
    {
        public string GUID { set; get; }
        public int StockNum { set; get; }
        public string HouseId { set; get; }
        public double StockPriceKc { set; get; }
        public double PriceIn { set; get; }
        public double PriceDiag { set; get; }
        public int LsRpType { set; get; }
        public int LsGfType { set; get; }
        public bool IsActive { set; get; }
        public bool IsRpForbid { set; get; }
        public bool OptionPrice { set; get; }
        public bool IsSpecial { set; get; }
        public bool IsSpecSum { set; get; }
        public string Name { set; get; }
        public string UnitInName { set; get; }
        public string Code { set; get; }
        public string WbCode { set; get; }
        public string PyCode { set; get; }
        public string StrokeCode { set; get; }
        public string Memo { set; get; }
        public string OtherCode { set; get; }
        public string EngDesc { set; get; }
        public string Spec { set; get; }
        public string UnitDiagName { set; get; }
        public string LongDesc { set; get; }
        public string MultiName { set; get; }
        public string MultiPy { set; get; }
        public string MultiWb { set; get; }
        public string style { set; get; }
        public string OrderNo { set; get; }
        public int OrderBy { set; get; }
        public string ExecLocation { set; get; }
        public string BasalDrugType { set; get; }
        public string YblimitCue { set; get; }
    }




    [Serializable]
    public class SetYbChkDiscInResult : BaseModel
    {
        public string HospId { get; set; }
        public bool IsPay { get; set; }
        public IList<UspInBalanceDtlQry> LstUspInBalanceDtl { get; set; }
        public IList<InInvoiceDtlChk> LstOuToFee { get; set; }
    }

    [Serializable]
    public class UserInputMethod : BaseModel
    {
        /// <summary>
        /// 五笔码查找
        /// </summary>
        public bool IsUserInputWB { get; set; }
        /// <summary>
        /// 拼音码查找
        /// </summary>
        public bool IsUserInputPY { get; set; }
        /// <summary>
        /// 项目编码查找
        /// </summary>
        public bool IsUserInputCode { get; set; }
        /// <summary>
        /// 中文名称查找
        /// </summary>
        public bool IsUserInputName { get; set; }
        /// <summary>
        /// 笔画码查找
        /// </summary>
        public bool IsUserInputStrokeCode { get; set; }
        /// <summary>
        /// 别名查找
        /// </summary>
        public bool IsUserInputEngDesc { get; set; }
        /// <summary>
        /// 下拉跟随输入
        /// </summary>
        public bool IsUserInputList { get; set; }
        /// <summary>
        /// 写字板
        /// </summary>
        ///  
        public bool IsUserWordPad { get; set; }
        /// <summary>
        /// 省统一码
        /// </summary>
        public bool IsUserInputF1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsUserSelectOnly { get; set; }

    }



    [Serializable]
    public class DrawString : BaseModel
    {
        public String LocationName { get; set; }

        public String LocationOut { get; set; }

        public String BedName { get; set; }

    }



    [Serializable]
    public class DoResult : BaseModel
    {
        public RmZyOutDtl InfoRmZyOutDtl { get; set; }
        public IList<Rmstores> LstRmStore { get; set; }
        public Rmstores InfoRmStore { get; set; }
        public double DblDrugNum { get; set; }
    }



    [Serializable]
    public class LastIllDesc : BaseModel
    {
        public string LastWestIllDesc { get; set; }
        public string lastChinIllDesc { get; set; }
        public string lastIllDescMzRegId { get; set; }
        public string lastChinIllDescMzRegId { get; set; }
        public BsLocation InfoBsLocation { get; set; }

    }


    [Serializable]
    public class PacsRowColCount : BaseModel
    {
        public int RowCount { get; set; }
        public int ColCount { get; set; }
    }





    [Serializable]
    public class ItemsAmount : BaseModel
    {
        public Hashtable HtContinueAmount { get; set; }
        public double OtherAmount { get; set; }
        public double TestAmount { set; get; }
    }



    [Serializable]
    public class OuHosInfoAndBsLocation
    {
        public OuHosInfo ouHosInfo { get; set; }
        public BsLocation bsLocation { get; set; }
    }

    [Serializable]
    public class MedicalInsuranceSettlementContent : BaseModel
    {
        public HisInPatientQry InPatientInfo { get; set; }
        public InInvoice InfoInInvoice { get; set; }
        public InInvoYB InfoInInvoYB { get; set; }
        public InHosInfo InfoInHos { get; set; }
        public double UnderLine { get; set; }

        public double OtherFee { get; set; }

        public double CheckFee { get; set; }
        public double CurerFee { get; set; }

        public double SelfFee { get; set; }

        public double SelfRatio { get; set; }

        public string Tips { get; set; }

        public string Days { get; set; }
        public IList<UspInBalanceDtlQry> LstUspInBalanceDtl { get; set; }
        public IList<UspInInvoiceInvItemGoupSum> LstuspInInvoiceInvItemGoupSumQry { get; set; }

    }


    [Serializable]
    public class UspOuNotReChargeExecuted : BaseModel
    {
        public string GUID { get; set; }
        public DateTime CancelOperTime { get; set; }
        public string MzRegNo { get; set; }
        public string CancelOperId { get; set; }
    }



    [Serializable]
    public class ComputeSummaryModle : BaseModel
    {
        public string GUID { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public string GroupBy { get; set; }
        public double Result { get; set; }
    }

    [Serializable]
    public class UspOuRecipePrint : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string RecipeID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String SequenceNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String Recipe_Num { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = false)]
        public string UsageId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public String RecipeMemo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = false)]
        public double PubSpec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public String PubUnit_Take { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public String Unit_Take { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public String Unit_Diag { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public String UsageName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public String Hz { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public String Frequency { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public double Dosage { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public double Totality { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public String PrepareTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public string MzRegId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public String Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public String Form_Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public Int32 List_Num { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public string Int_Code { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public Boolean IsCancel { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public String Item_Desc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = false)]
        public Int32 Group_Num { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public String Drug_Type { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = false)]
        public int days { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public String Item_Code { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public Boolean IsCharge { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = false)]
        public Int32 Rp_Type { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = false)]
        public double Price_In { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = false)]
        public double Amount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public String PatientName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public String DoctorName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public String PatTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public String LocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public int Age { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = false)]
        public Int32 BabyMonth { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = true)]
        public String Sex { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public DateTime RecipeTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public String PhoneHome { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
        public String AddressHome { get; set; }

        ////////////////////////////////[DataMemberr(Order = 43, IsRequired = true)]
        public String IllDesc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 44, IsRequired = true)]
        public String AccountNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 45, IsRequired = false)]
        public string XDRpId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 46, IsRequired = false)]
        public Boolean IsNurseExecute { get; set; }

        ////////////////////////////////[DataMemberr(Order = 47, IsRequired = false)]
        public string UnitDiagId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 48, IsRequired = false)]
        public string UnitTakeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 49, IsRequired = false)]
        public string FormId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 50, IsRequired = true)]
        public Boolean IsAttach { get; set; }

        ////////////////////////////////[DataMemberr(Order = 51, IsRequired = false)]
        public string FrequencyId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 52, IsRequired = true)]
        public String InvoNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 53, IsRequired = false)]
        public string doctorID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 54, IsRequired = true)]
        public String CertificateName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 55, IsRequired = true)]
        public String IdCardNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 56, IsRequired = true)]
        public String MedicareNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 57, IsRequired = false)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 58, IsRequired = true)]
        public String IllDescZy { get; set; }
    }


    [Serializable]
    public class UsageItemOutResult : BaseModel
    {
        public string LastGroupUsageId { get; set; }
        public int GroupTemp { get; set; }
        public IList<UspOuRecipePrint> LstSortedAdvice { get; set; }
        public string Special { get; set; }
        public ItemsAmount ItemsAmount { get; set; }

    }

    [Serializable]
    public class PatientReferralJK : BaseModel
    {
        public OuHosInfo InfoOuHos { get; set; }
        public BsPatient InfoBsPatient { get; set; }
        public OuClincDiag InfoOuClincDiag { get; set; }
        public OuClinicFirst InfoOuClinicFirst { get; set; }
    }



    [Serializable]
    public class TemplateRecord : BaseModel
    {
        public string CurrentId { get; set; }
        public InEMR InEmrInfo { get; set; }
        public GblEMRCatalog GblEmrCatalog { get; set; }
    }


    [Serializable]
    public class MyPatInfo : BaseModel
    {
        public string Illness { get; set; }
        public string PatId { get; set; }
    }


    [Serializable]
    public class UspOuNotOtherLISExecuted : BaseModel
    {
        public string GUID { get; set; }
        public DateTime CancelOperTime { get; set; }
        public string MzRegNo { get; set; }
        public string CancelOperId { get; set; }
    }


    [Serializable]
    public class Code : BaseModel
    {
        public string WbCode { get; set; }
        public string PyCode { get; set; }
    }


    [Serializable]
    public class ChineseRecipe : BaseModel
    {
        public IList<OuRecipeDtl> LstChinese { get; set; }

        public OuRecipe OuRecipe { get; set; }

    }

    [Serializable]
    public class UspOutFromLocationNotRecieve : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string HospId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public string BedId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public string OutLocId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = false)]
        public DateTime OutOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = false)]
        public string OutOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
        public Boolean isReceived { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = false)]
        public string InLocId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = false)]
        public DateTime InOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public string InOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public String InPatNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public String PatientName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public String BedName { get; set; }
    }


    [Serializable]
    public class UspHuAdjustPlanDtl : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 10)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11)]
        public string BillId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12)]
        public string BillNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13)]
        public string HouseId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14)]
        public string HouseName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15)]
        public string Code { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17)]
        public string ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18)]
        public string Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19)]
        public double OldPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20)]
        public double NewPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21)]
        public DateTime NotifyDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22)]
        public string UnitId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23)]
        public string UnitName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25)]
        public string OperName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26)]
        public string Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27)]
        public string jy { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28)]
        public bool IsExcute { get; set; }
    }

    [Serializable]
    public class RptOfBillInfo : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public String PNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public double DrugNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public double StockPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public double RetailPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = false)]
        public DateTime StoreDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
        public DateTime ProduceDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = false)]
        public DateTime LimitDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public string BillId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public String BillNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public String Reason { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public String ItemCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public String ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public String Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public String UnitName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = false)]
        public double TotalRetail { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public String OperName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public String CompanyName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public String RoomName { get; set; }
    }

    [Serializable]
    public class CommonDetail : BaseModel
    {
        public HuAdjustPlan InfoHuAdjustPlan { get; set; }
        public IList<UspHuAdjustPlanDtl> LstHuAdjustPlanDtl { get; set; }
        public RmApplback InfoRmApplback { get; set; }
        public IList<RmApplbackDtl> LstRmApplbackDtl { get; set; }
        public RmMove InfoRmMove { get; set; }
        public IList<RmMoveDtl> LstRmMove { get; set; }
        public RmOtherIn InfoRmOtherIn { get; set; }
        public IList<RptOfBillInfo> LstOFBill { get; set; }
        public RmOutOth InfoRmOutOth { get; set; }

    }

    [Serializable]
    public class UspOuHosInfoSelectConfirmOtherFee : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = false)]
        public Boolean IsConfirm { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String MzRegNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String CardNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String Sex { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public String RegLocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String RegDoctorName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public string RegDept { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public string DoctorId { get; set; }
    }

    [Serializable]
    public class UspOuHosInfoSelectNoConfirmOtherFee : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = false)]
        public Boolean IsConfirm { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String MzRegNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String CardNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String Sex { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public String RegLocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String RegDoctorName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public string RegDept { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public string DoctorId { get; set; }
    }


    [Serializable]
    public class ConfirmOtherFeeQry : BaseModel
    {
        public IList<UspOuHosInfoSelectConfirmOtherFee> LstOuHosInfoNoConfirmOtherFee { get; set; }
        public IList<UspOuHosInfoSelectNoConfirmOtherFee> LstOuHosInfoConfirmOtherFee { get; set; }

    }


    [Serializable]
    public class RecipePrintSource : BaseModel
    {
        public BsLocation BsLocation { get; set; }
        public BsDoctor BsDoctor { get; set; }
        public BsPatient BsPatient { get; set; }

    }




    [Serializable]
    public class WorkersBorrowMedicineInfo : BaseModel
    {
        public BsUser BsUser { get; set; }
        public string LocationName { get; set; }
    }



    [Serializable]
    public class PrintTestFomReportResult : BaseModel
    {
        public IList<UspOuRecipePrint> LstUspPrintSh { get; set; }
        public IList<UspOuRecipeDtl> LstTestUspOuRecipeDtlQry { get; set; }
    }



    [Serializable]
    public class GetExecuteBillDtlResult : BaseModel
    {
        public IList<SelectHisItem> LstSelectRecipe { get; set; }
        public IList<UspOuRecipeDtl> LstChineOuRecipeDtlQry { get; set; }

    }


    [Serializable]
    public class OuRecipeDtlPrintResult : BaseModel
    {
        public IList<BsLabSourceItem> LstSourceItem { get; set; }
        public IList<UspOuRecipeDtl> LstChineOuRecipeDtlQry { get; set; }
    }


    [Serializable]
    public class PrintChinRecipeData : BaseModel
    {
        public IList<OuRecipe> LstOuRecipe { get; set; }
        public List<UspOuChinRecipePrint> LstChinRecipePrint { get; set; }
    }



    [Serializable]
    public class PrintOuRecipeDisposalData : BaseModel
    {
        public IList<UspOuRecipePrint> lstRecipePrint { get; set; }
        public IList<OuClincDiag> lstOuClincDiag { get; set; }
        public UsageItemOutResult UsageItemOutResult { get; set; }
        public BsPatient InfoBsPatient { get; set; }
        public double WestAmount { get; set; }
        public double WestAmountTotal { get; set; }
        public double ChinesePatentAmountTotal { get; set; }

    }

    [Serializable]
    public partial class UspOuDrugIssueDtl : BaseModel
    {
        public UspOuDrugIssueDtl()
        { }

        ////////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 2, IsRequired = false)]
        public Boolean IsSelected { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 3, IsRequired = false)]
        public Boolean IsDoctorInput { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public Boolean IsToBack { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 5, IsRequired = false)]
        public string IssueOperId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String IssueTime { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public Boolean IsIssue { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 8, IsRequired = false)]
        public string PrepareOperId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public String PrepareTime { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public Boolean IsPrepared { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 11, IsRequired = false)]
        public string PrintOperId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public DateTime PrintTime { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public Boolean IsPrint { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 14, IsRequired = false)]
        public string CancelOperId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 15, IsRequired = false)]
        public DateTime CancelTime { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public Boolean IsCharged { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 17, IsRequired = false)]
        public Boolean Isprintlabel { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public Boolean IsCancel { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 19, IsRequired = false)]
        public string XDRpId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public String Memo { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public Boolean IsOtherFee { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public Boolean IsAttach { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public string UnitDiagId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 24, IsRequired = false)]
        public double Totality { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 25, IsRequired = false)]
        public int Days { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 26, IsRequired = false)]
        public string UsageId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 27, IsRequired = false)]
        public string FrequencyId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 28, IsRequired = false)]
        public string UnitTakeId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public double Dosage { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public int GroupNum { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public string ItemId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public Int32 ListNum { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public string RecipeId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public String UsageName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public Boolean IsBack { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public String UnitTakeName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 37, IsRequired = true)]
        public String UnitDiagName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public String ItemCode { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 39, IsRequired = true)]
        public String ItemName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public String Spec { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 41, IsRequired = false)]
        public double PriceDiag { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 42, IsRequired = false)]
        public double Amount { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public string FormId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 44, IsRequired = true)]
        public String FormName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 45, IsRequired = true)]
        public String FrequencyName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 46, IsRequired = false)]
        public string ApplyId { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 47, IsRequired = true)]
        public String YbType { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 48, IsRequired = false)]
        public double ReqBackNum { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 49, IsRequired = false)]
        public double HasBackNum { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 50, IsRequired = false)]
        public double HasSendNum { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 51, IsRequired = true)]
        public String InvoNo { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 52, IsRequired = true)]
        public String ChemName { get; set; }

        ////////////////////////////////////[DataMemberr(Order = 53, IsRequired = true)]
        public String IssueOperName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private bool _isReqBackNum = false;
        /// <summary>
        /// 
        /// </summary>
        public bool u_IsReqBackNum
        {
            get
            {
                if (ReqBackNum == 0)
                {
                    _isReqBackNum = true;
                }
                return _isReqBackNum;
            }
            set { _isReqBackNum = value; }
        }
        private bool _isNotReqBackNumn = false;
        /// <summary>
        /// 
        /// </summary>
        public bool u_IsNotReqBackNumn
        {
            get
            {
                if (ReqBackNum != 0)
                {
                    _isNotReqBackNumn = true;
                }
                return _isNotReqBackNumn;
            }
            set { _isNotReqBackNumn = value; }
        }
        // private bool u_IsApplyIdNull = false;
        private bool _isApplyIdNull = false;
        public bool u_IsApplyIdNull
        {
            get
            {
                if (string.IsNullOrWhiteSpace(ApplyId))
                {
                    _isApplyIdNull = true;
                }
                else
                {
                    _isApplyIdNull = false;
                }
                return _isApplyIdNull;
            }
            set { _isApplyIdNull = value; }
        }
    }





    [Serializable]
    public class BsItemInfo : BaseModel
    {
        public IList<UspOuRecipeDtl> LstTestOuRecipeDtl { set; get; }
        public BsItem InfoBsItem { set; get; }

    }





    [Serializable]
    public class PatTypeResult : BaseModel
    {
        public string TallyTypeId { set; get; }
        public string TallyGroupId { set; get; }
        public bool IsYb { set; get; }

    }



    [Serializable]
    public class MaxGroupNumAndMaxSN : BaseModel
    {
        public int MaxGroupNum { set; get; }
        public int MaxSN { set; get; }

    }


    [Serializable]
    public class RecipeExecuteResultStopSelectedAdvice1 : BaseModel
    {
        public IList<UspInAdviceLongList> LstUspInAdviceLongList { set; get; }

        public List<int> ListRow { get; set; }
    }




    [Serializable]
    public class CheckTypeAndCheckStr : BaseModel
    {
        public int CheckType { set; get; }
        public string CheckStr { set; get; }

    }

    [Serializable]
    public class UspOuClinicPrint : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = false)]
        public virtual string GUID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual string MzRegId { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual String MzRegNo { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual String CardNo { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual String Name { get; set; }

        //[DataMember(Order = 6, IsRequired = true)]
        public virtual String Sex { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual String Company { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual String AddressHome { get; set; }

        //[DataMember(Order = 9, IsRequired = true)]
        public virtual String Native { get; set; }

        //[DataMember(Order = 10, IsRequired = true)]
        public virtual String PhoneHome { get; set; }

        //[DataMember(Order = 11, IsRequired = true)]
        public virtual String Sensitive { get; set; }

        //[DataMember(Order = 12, IsRequired = true)]
        public virtual DateTime RegTime { get; set; }

        //[DataMember(Order = 13, IsRequired = true)]
        public virtual String IllDesc { get; set; }

        //[DataMember(Order = 14, IsRequired = false)]
        public virtual double ListNum { get; set; }

        //[DataMember(Order = 15, IsRequired = false)]
        public virtual Int32? GroupNum { get; set; }

        //[DataMember(Order = 16, IsRequired = false)]
        public virtual double Dosage { get; set; }

        //[DataMember(Order = 17, IsRequired = false)]
        public virtual double? Totality { get; set; }

        //[DataMember(Order = 18, IsRequired = false)]
        public virtual Int32 Days { get; set; }

        //[DataMember(Order = 19, IsRequired = true)]
        public virtual String ItemName { get; set; }

        //[DataMember(Order = 20, IsRequired = true)]
        public virtual String DrugFormName { get; set; }

        //[DataMember(Order = 21, IsRequired = true)]
        public virtual String UsageName { get; set; }

        //[DataMember(Order = 22, IsRequired = true)]
        public virtual String UnitTakeName { get; set; }

        //[DataMember(Order = 23, IsRequired = false)]
        public virtual Int32? LsRepType { get; set; }

        //[DataMember(Order = 24, IsRequired = false)]
        public virtual DateTime? BirthDate { get; set; }

        //[DataMember(Order = 25, IsRequired = true)]
        public virtual String Spec { get; set; }

        //[DataMember(Order = 26, IsRequired = true)]
        public virtual String UnitDiagName { get; set; }

        //[DataMember(Order = 27, IsRequired = true)]
        public virtual String Memo { get; set; }

        //[DataMember(Order = 28, IsRequired = true)]
        public virtual String NationName { get; set; }

        //[DataMember(Order = 29, IsRequired = true)]
        public virtual Int32 LsMarriage { get; set; }

        //[DataMember(Order = 30, IsRequired = true)]
        public virtual String Occupation { get; set; }

        //[DataMember(Order = 31, IsRequired = true)]
        public virtual String PatTypeName { get; set; }

        //[DataMember(Order = 32, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        //[DataMember(Order = 33, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //[DataMember(Order = 34, IsRequired = true)]
        public virtual String FrequencyName { get; set; }

        //[DataMember(Order = 35, IsRequired = true)]
        public virtual String MainInform { get; set; }

        //[DataMember(Order = 36, IsRequired = true)]
        public virtual String CheckUp { get; set; }

        //[DataMember(Order = 37, IsRequired = false)]
        public virtual double? ExamT { get; set; }

        //[DataMember(Order = 38, IsRequired = false)]
        public virtual double? ExamP { get; set; }

        //[DataMember(Order = 39, IsRequired = false)]
        public virtual double? ExamR { get; set; }

        //[DataMember(Order = 40, IsRequired = false)]
        public virtual double? ExamBp { get; set; }

        //[DataMember(Order = 41, IsRequired = false)]
        public virtual double? ExamBp2 { get; set; }

        //[DataMember(Order = 42, IsRequired = true)]
        public virtual String CheckCT { get; set; }

        //[DataMember(Order = 43, IsRequired = true)]
        public virtual String Disposal { get; set; }

        //[DataMember(Order = 44, IsRequired = true)]
        public virtual String SickHist { get; set; }

        //[DataMember(Order = 45, IsRequired = true)]
        public virtual String Impression { get; set; }

        //[DataMember(Order = 46, IsRequired = true)]
        public virtual String Analys { get; set; }

        //[DataMember(Order = 47, IsRequired = true)]
        public virtual String Others { get; set; }

        //[DataMember(Order = 48, IsRequired = true)]
        public virtual String RecipeNum { get; set; }

        //[DataMember(Order = 49, IsRequired = true)]
        public virtual String AgeString { get; set; }

        //[DataMember(Order = 50, IsRequired = true)]
        public virtual String Residence { get; set; }

        //[DataMember(Order = 51, IsRequired = true)]
        public virtual String Tongue { get; set; }

        //[DataMember(Order = 52, IsRequired = true)]
        public virtual String Pulse { get; set; }

        //[DataMember(Order = 53, IsRequired = true)]
        public virtual String Moss { get; set; }

        //[DataMember(Order = 54, IsRequired = false)]
        public virtual Boolean? IsDoctorInput { get; set; }
    }

    [Serializable]
    public class UspInAdviceTempList : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = false)]
        public DateTime AdviceTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public string DoctorId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String Code { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public string LocationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public string HospId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public int GroupNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public double Dosage { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public string UnitTakeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = false)]
        public string FrequencyId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public string UsageId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public double PriceIn { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public double Totality { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = false)]
        public double Amount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public string UnitInId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public Boolean IsUrgent { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public Boolean IsAttach { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public Boolean IsSelf { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public int LsSpecialUsage { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public int LsExecLoc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public Boolean IsSkin { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = false)]
        public DateTime SkinTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public String SkinTest { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = false)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public string OperID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public Boolean IsPrinted { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = false)]
        public Boolean IsOtherFee { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public Boolean IsChk { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = false)]
        public DateTime ChkOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = false)]
        public string ChkOperID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public Boolean IsAuth { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = false)]
        public DateTime AuthOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = false)]
        public string AuthOperID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = false)]
        public Boolean IsAuthFee { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = false)]
        public DateTime AuthFeeOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public string AuthFeeOperID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public Boolean IsCancel { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = false)]
        public DateTime CancelOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = false)]
        public string CancelOperID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public String Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
        public String YbType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 43, IsRequired = true)]
        public String AdviceTempMemo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 44, IsRequired = true)]
        public String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 45, IsRequired = true)]
        public String Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 46, IsRequired = false)]
        public string FormId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 47, IsRequired = false)]
        public int LsRpType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 48, IsRequired = false)]
        public Boolean IsInject { get; set; }

        ////////////////////////////////[DataMemberr(Order = 49, IsRequired = false)]
        public string SN { get; set; }

        ////////////////////////////////[DataMemberr(Order = 50, IsRequired = false)]
        public string ApplyId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 51, IsRequired = true)]
        public string ExecLocId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 52, IsRequired = false)]
        public string ExecDoctorId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 53, IsRequired = false)]
        public Boolean IsYbxj { get; set; }

        ////////////////////////////////[DataMemberr(Order = 54, IsRequired = true)]
        public String Colours { get; set; }

        ////////////////////////////////[DataMemberr(Order = 55, IsRequired = true)]
        public String LimitTotalZy { get; set; }

        ////////////////////////////////[DataMemberr(Order = 56, IsRequired = false)]
        public double DiscountAoumt { get; set; }

        ////////////////////////////////[DataMemberr(Order = 57, IsRequired = false)]
        public double DiscountPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 58, IsRequired = false)]
        public double ChildPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 59, IsRequired = false)]
        public string SourceId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 60, IsRequired = false)]
        public string OpsApplyId { get; set; }
    }



    [Serializable]
    public class InAdviceTempListInfo : BaseModel
    {
        public IList<UspInAdviceTempList> LstUspInAdviceTempList { set; get; }
        public MaxGroupNumAndMaxSN MaxGroupNumAndMaxSN { set; get; }
    }



    [Serializable]
    public class CheckInfoAdviceLcExecLocResult : BaseModel
    {
        public IList<UspInAdviceLongList> LstUspInAdviceLongQry { set; get; }
        public string Names { set; get; }
        public string RpForbidMemo { set; get; }
        public string NamesTotality { set; get; }

    }



    [Serializable]
    public class CheckNamesResult : BaseModel
    {
        public IList<UspInAdviceTempList> LstUspInAdviceTempQry { set; get; }
        public string NamesCancel { set; get; }
        public string NamesTotality { set; get; }

    }




    //public class FollowPatient//////wpfTest
    //{
    //    public string PatId { set; get; }  //_patId

    //    public DateTime FollowTime { set; get; }  //随访时间

    //    public string TimeQuantum { set; get; }  //时间段

    //    public string OperId { set; get; }  //操作人

    //    public DateTime OperTime { set; get; }  //操作时间

    //    public int FollowType { set; get; }  //随访类别 3;复诊提醒,4:健康教育,5:诊后关怀,6:病情跟踪,7:满意度调查,8:用药提示

    //    public string FollowContent { set; get; }  //随访内容

    //    public bool IsfeedBack { set; get; }  //是否需要反馈

    //    public string MzRegId { set; get; }  //就诊GUID

    //    public string FeedBackContent { set; get; }  //反馈内容

    //    public string ToothCaseId { set; get; }  //病历GUID

    //    public bool IsAutocreate { set; get; }  //是否自动创建

    //    public int FollowStatus { set; get; }  //回访状态：0 未回访 1 已回访 2待跟进

    //    public int FollowWay { set; get; }  //随访方式：0 手机APP 1短信 2电话 10其他

    //    public string PatientName { set; get; }  //患者姓名

    //    public int AppRaiseType { set; get; }  //满意度

    //    public bool IsDeleted { set; get; }  //标识是否已删除

    //    public string ModifyerOpenId { set; get; }  //回访保存GUID

    //    public string ReturnContent { set; get; }  //回访结果

    //    public int ReturnCycle { set; get; }  //

    //    public string SickTypeId { set; get; }  //病情类型GUID TmpEmr.GUID

    //    public int HospitalId { set; get; }  //

    //}



    [Serializable]
    public class UspHuStoreUnderLineWarningQry : BaseModel
    {
        private string HouseId { get; set; }
        private string ItemId { get; set; }
        private string UnitId { get; set; }
        private string CompId { get; set; }
        private string ItemName { get; set; }
        private string CompanyName { get; set; }
        private string UnitName { get; set; }
        private string Spec { get; set; }
        private double StockPrice { get; set; }
        private double RetailPrice { get; set; }
        private double UnderLineKc { get; set; }
        private double UperLineKc { get; set; }
        private bool Selected { get; set; }
        private double StockNum { get; set; }
        private double NormalLinekc { get; set; }
        private string GroupId { get; set; }
        private string _groupName { get; set; }
        private bool _isOnlyForSys { get; set; }
        private string _memo { get; set; }
        public int Status { get; set; }
    }

    [Serializable]
    public class UspHuStoreUnderLine : BaseModel
    {
        ////[DataMember(Order = 1, IsRequired = false)]
        public virtual string GUID { get; set; }

        ////[DataMember(Order = 2, IsRequired = true)]
        public virtual String ItemName { get; set; }

        ////[DataMember(Order = 3, IsRequired = true)]
        public virtual String CompanyName { get; set; }

        ////[DataMember(Order = 4, IsRequired = true)]
        public virtual String UnitName { get; set; }

        ////[DataMember(Order = 5, IsRequired = true)]
        public virtual String AreaName { get; set; }

        ////[DataMember(Order = 6, IsRequired = false)]
        public virtual string CompId { get; set; }

        ////[DataMember(Order = 7, IsRequired = true)]
        public virtual String Spec { get; set; }

        ////[DataMember(Order = 8, IsRequired = false)]
        public virtual double? UnderLine { get; set; }

        ////[DataMember(Order = 9, IsRequired = false)]
        public virtual double? UperLine { get; set; }

        ////[DataMember(Order = 10, IsRequired = false)]
        public virtual double? StockPriceKc { get; set; }

        ////[DataMember(Order = 11, IsRequired = false)]
        public virtual double? RetailPriceKc { get; set; }

        ////[DataMember(Order = 12, IsRequired = true)]
        public virtual String HouseName { get; set; }

        ////[DataMember(Order = 13, IsRequired = false)]
        public virtual double? NormalLineKc { get; set; }

        ////[DataMember(Order = 14, IsRequired = false)]
        public virtual string ItemId { get; set; }

        ////[DataMember(Order = 15, IsRequired = false)]
        public virtual Int32 OrderBy { get; set; }
    }

    [Serializable]
    public class UspHuStoreLogBatchActtypeSum : BaseModel
    {
        // //[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////[DataMember(Order = 2, IsRequired = false)]
        public virtual double? TotalRetail { get; set; }

        ////[DataMember(Order = 3, IsRequired = true)]
        public virtual Int32 lsacttype { get; set; }
    }

    [Serializable]
    public class UspBsItemMini : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public String Code { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String WbCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String PyCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String StrokeCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String OtherCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String LongDesc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public String EngDesc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public String Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public String UnitInName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public int LsGfType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public Boolean IsRpForbid { get; set; }


        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = false)]
        public Boolean IsSpecial { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = false)]
        public int LsRpType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = false)]
        public Boolean IsActive { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public String UnitDiagName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = false)]
        public double PriceIn { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = false)]
        public double PriceDiag { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public String Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public String style { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public String OrderNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = false)]
        public Int32 stocknum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = false)]
        public double StockPriceKc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = false)]
        public int OrderBy { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = false)]
        public string MultiName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = false)]
        public string MultiPy { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = false)]
        public string MultiWb { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = false)]
        public string ExecLocation { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = false)]
        public string BasalDrugType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = false)]
        public string YblimitCue { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = false)]
        public string IsModify { get; set; }
        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = false)]
        public bool IsSelected { get; set; }
        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = false)]
        public bool StrTemp { get; set; }
        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = false)]
        public string StrTemp1 { get; set; }
        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = false)]
        public string InputTime { get; set; }
        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public string SortOrder { get; set; }
    }

    [Serializable]
    public class GetBsItemMiniResult : BaseModel
    {
        public IList<UspBsItemMini> LstBsItemMini1 { set; get; }
        public IList<UspBsItemMini> LstBsItemMini2 { set; get; }

    }

    [Serializable]
    public class PhysicalExaminationWithImportCompany : BaseModel
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string patientName { set; get; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { set; get; }

        /// <summary>
        /// 年龄
        /// </summary>
        public string Age { set; get; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string phone { set; get; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IdCardNo { set; get; }

        /// <summary>
        /// 体检类型
        /// </summary>
        public string type { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string memo { set; get; }

        /// <summary>
        /// 序号
        /// </summary>
        public string numberCard { set; get; }

        /// <summary>
        /// 诊疗卡号
        /// </summary>
        public string CardNo { set; get; }

        /// <summary>
        /// 分组
        /// </summary>
        public string groupName { set; get; }

        /// <summary>
        /// 部门
        /// </summary>
        public string departmentStr { set; get; }
    }

    [Serializable]
    public class UspCkResultDtl : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string LabId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public string TestId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String LastResult { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String Result { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String Unit { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public int LsRefFlag { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public Boolean IsPanic { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public Boolean IsDalta { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public double DalAbsolute { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public double DalPercent { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public double LowValue { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public double HighValue { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public double PanicLow { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public double PanicHigh { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public Boolean IsPass { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public Boolean IsReport { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public String Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = false)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public string OperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public Boolean IsPrint { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = false)]
        public DateTime PrintTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = false)]
        public string PrintOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public String TextRange { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public String Deviate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public String AuthDocName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = false)]
        public DateTime AuthDocTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public String CheckNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public String ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public Boolean IsAuthed { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public String Code { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public String TestName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = false)]
        public string TestTypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public String HighLow { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public String IsDangerous { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = true)]
        public String Compare { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public String NormalRange { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = true)]
        public int OrderBy { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public String ReMemo { get; set; }
    }

    [Serializable]
    public class UspLabResult : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public String Code { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String Result { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String NormalRange { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String Unit { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public int HighLow { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String TestTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public String ItemDesc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public DateTime ReportTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public int OrderBy { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public string LabId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public String LabNum { get; set; }
    }

    [Serializable]
    public class UspOuRecipeDtlInfo : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string RecipeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public int GroupNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
        public string FormId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = false)]
        public double PriceDiag { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public double Dosage { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public string UnitTakeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = false)]
        public string FrequencyId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public string UsageId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = false)]
        public double TotalDosage { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public double Totality { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = false)]
        public double Amount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = false)]
        public string UnitDiagId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public Boolean IsAttach { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = false)]
        public int LsGfType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = false)]
        public int Days { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public Int32 ListNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = false)]
        public string XDRpId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public String Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = false)]
        public string ApplyId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public String YbType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public Boolean IsOtherFee { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = false)]
        public int LsRpType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public Boolean IsCancel { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = false)]
        public DateTime CancelTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = false)]
        public string CancelOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public Boolean IsPrint { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = false)]
        public DateTime PrintTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = false)]
        public string PrintOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public Boolean IsPrepared { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public String PrepareTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = false)]
        public string PrepareOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public Boolean IsIssue { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public DateTime IssueTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = false)]
        public string IssueOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = true)]
        public Boolean IsCharged { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public Boolean IsToBack { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public Boolean IsBack { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42, IsRequired = false)]
        public Boolean IsDoctorInput { get; set; }

        ////////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 44, IsRequired = false)]
        public Int32 RecNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 45, IsRequired = false)]
        public DateTime RecipeTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 46, IsRequired = false)]
        public string LocationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 47, IsRequired = false)]
        public string DoctorId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 48, IsRequired = true)]
        public String invono { get; set; }

        ////////////////////////////////[DataMemberr(Order = 49, IsRequired = false)]
        public double Price { get; set; }

        ////////////////////////////////[DataMemberr(Order = 50, IsRequired = false)]
        public Boolean IsForCharge { get; set; }

        ////////////////////////////////[DataMemberr(Order = 51, IsRequired = false)]
        public Boolean IsBP { get; set; }

        ////////////////////////////////[DataMemberr(Order = 52, IsRequired = true)]
        public String BPReason { get; set; }

        ////////////////////////////////[DataMemberr(Order = 53, IsRequired = true)]
        public String Code { get; set; }

        ////////////////////////////////[DataMemberr(Order = 54, IsRequired = true)]
        public String DrugsTypes { get; set; }

        ////////////////////////////////[DataMemberr(Order = 55, IsRequired = false)]
        public double AmountRecipe { get; set; }

        ////////////////////////////////[DataMemberr(Order = 56, IsRequired = false)]
        public string CureDtlId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 57, IsRequired = false)]
        public double DiscountAoumt { get; set; }

        ////////////////////////////////[DataMemberr(Order = 58, IsRequired = false)]
        public double ChildPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 59, IsRequired = false)]
        public double DiscountPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 60, IsRequired = false)]
        public int PageNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 61, IsRequired = false)]
        public int AllPageNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 62, IsRequired = false)]
        public string TempStr { get; set; }
    }

    [Serializable]
    public class UspHisOuPatient : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public String MzRegNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String PatientName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public string PatId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String CardNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String Sex { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
        public DateTime BirthDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = false)]
        public int Age { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = false)]
        public Int32 BabyMonth { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public String AgeString { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public DateTime RegTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public Boolean RegLocation { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = false)]
        public bool IsPriority { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public string RegTypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public String RegTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = false)]
        public string DoctorId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public Int32 RegDept { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public String LocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = false)]
        public string DiagnDept { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = false)]
        public Boolean IsCancel { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public String DoctorName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public string PatTypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public String PatTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public string TallyTypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public String TallyTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public string TallyGroupId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public String TallyGroupName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public Boolean IsGf { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public Boolean IsYb { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public String GetTallyType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public String GetTallyTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public double ArrearAmount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public Boolean IsInPatient { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = false)]
        public Boolean IsRegistration { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public String Diagnose { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public String YbSeqNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public Boolean IsOuChargeInput { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = false)]
        public Boolean IsLocationSee { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = false)]
        public Boolean IsLocationDiagSee { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = false)]
        public Boolean IsDiagnosed { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public String DiagStatus { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
        public String Mobile { get; set; }

        ////////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public int HospitalId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 44, IsRequired = false)]
        public string TimeSpanId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 45, IsRequired = true)]
        public Int32 LineOrder { get; set; }

        ////////////////////////////////[DataMemberr(Order = 46, IsRequired = false)]
        public double Height { get; set; }

        ////////////////////////////////[DataMemberr(Order = 47, IsRequired = false)]
        public double Weight { get; set; }

        ////////////////////////////////[DataMemberr(Order = 48, IsRequired = false)]
        public string WorktypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 49, IsRequired = true)]
        public String MedicareNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 50, IsRequired = false)]
        public string SpecialityId { get; set; }
    }

    [Serializable]
    public class UspOuExecutePrint : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string ExecuteId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public string MzRegId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public double Dosage { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public int Days { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public string FrequencyId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String FrequencyName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public String ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public String Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = false)]
        public string RecipeDtlId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public String Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = false)]
        public Boolean IsSkin { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public String UsageName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public int GroupNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public String GroupNumGroup { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public String GroupNumNDay { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public string RecipeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public int LsRepType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = false)]
        public Boolean IsExecuted { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = false)]
        public DateTime ExecutedTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public int NDay { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public int NTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public string UsageId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public String UnitName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = false)]
        public Boolean IsPrintLabel { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = false)]
        public Boolean IsBack { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = false)]
        public Boolean IsSelect { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = false)]
        public Boolean IsBackSelect { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public String STMemo { get; set; }
    }

    [Serializable]
    public class UspInChinDrugIssueDtl : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string RecipeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String ItemCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public double Dosage { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public string UnitTakeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public int LsDecoctWay { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public String Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public string OperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = false)]
        public string DetailId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public String UnitTakeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public string DoctorId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = false)]
        public double PriceIn { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = false)]
        public double Totality { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = false)]
        public double Amount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public String RoomNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public String HospNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = false)]
        public Int32 Age { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public String Sex { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public int DrugNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public int DecoctNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public String RecipeNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public String LocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public String PatTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public String PhoneHome { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public String AddressHome { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public String IllDesc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public String LsCookSelfName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public int LsCookSelf { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = false)]
        public DateTime BackTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public String BedName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public String PatientName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public string HospId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = true)]
        public string LocationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public Boolean IsConfirm { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = true)]
        public Boolean IsBack { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public String RicipeMemo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public String UsageName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
        public String FrequencyName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 43, IsRequired = true)]
        public String MedicareNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 44, IsRequired = true)]
        public String ConfirmOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 45, IsRequired = false)]
        public Boolean IsSelected { get; set; }

        ////////////////////////////////[DataMemberr(Order = 46, IsRequired = true)]
        public String PriorityName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 47, IsRequired = true)]
        public Boolean IsPrint { get; set; }

        ////////////////////////////////[DataMemberr(Order = 48, IsRequired = true)]
        public String DoctorName { get; set; }
    }

    [Serializable]
    public class UspOutToLocationNotRecieve : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string HospId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public string BedId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public string OutLocId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = false)]
        public DateTime OutOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = false)]
        public string OutOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
        public Boolean isReceived { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = false)]
        public string InLocId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = false)]
        public DateTime InOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public string InOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public String InPatNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public String PatientName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public String BedName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = false)]
        public string DoctorId { get; set; }
    }

    [Serializable]
    public class UspOuInvoiceInvItemGoupSum : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public string InvItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public double Amount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public double AmountFact { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public double AmountSelf { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public double AmountTally { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public double AmountPay { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = false)]
        public double AmountJZ { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public double AmountZF { get; set; }
    }

    [Serializable]
    public class UspHuOutDtl : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 10)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11)]
        public string BillNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12)]
        public string HouseId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13)]
        public string RoomId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14)]
        public string ApplyId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15)]
        public string OperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17)]
        public string OutMemo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18)]
        public bool YFSign { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19)]
        public string YFOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20)]
        public DateTime YFOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21)]
        public bool IsSign { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22)]
        public DateTime SignTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23)]
        public string SignOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24)]
        public string ApplyNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25)]
        public string BillId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26)]
        public string InBatchId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28)]
        public string UnitId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29)]
        public double DrugNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30)]
        public double RetailPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31)]
        public double StockPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32)]
        public string ItemCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33)]
        public string ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34)]
        public string Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35)]
        public string ManufactureryName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36)]
        public string UnitName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37)]
        public double TotalPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38)]
        public double TotalRetail { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39)]
        public double DeltaAmount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40)]
        public double DeltaPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41)]
        public string PNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42)]
        public double OutPrice { get; set; }
    }

    [Serializable]
    public class UspRmApplbackDtl : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 10)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11)]
        public string InBatchId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13)]
        public string UnitId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14)]
        public double DrugNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15)]
        public double StockPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16)]
        public double RetailPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17)]
        public string Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18)]
        public string BillId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19)]
        public string BillNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20)]
        public string HouseId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21)]
        public string RoomId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23)]
        public string OperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24)]
        public bool IsAffirm { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25)]
        public DateTime AffirmTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26)]
        public string AffirmOperid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27)]
        public bool IsSign { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28)]
        public DateTime SignTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29)]
        public string SignOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30)]
        public string UnitName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31)]
        public string ItemCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32)]
        public string ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33)]
        public string Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34)]
        public double TotalPrice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35)]
        public double TotalRetail { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36)]
        public string ManufactureryName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37)]
        public string PNo { get; set; }
    }

    [Serializable]
    public class UspInHosInfoDynamic2 : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string PatID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String CardNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String InPatNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String HospNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String PatientName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
        public DateTime BirthDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String Mobile { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public String Sex { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public String SexName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public String AddressHome { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public string DoctorId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public String DoctorName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public String YbRegNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public String LocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = false)]
        public string LocationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = false)]
        public string BedId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public String RoomNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public String BedName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = false)]
        public Boolean IsAdd { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = false)]
        public int OrderBy { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public string LocIn { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public String LocInName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public Int32 NTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public String InDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public DateTime InTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = false)]
        public DateTime OutTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = false)]
        public Int32 InDays { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public int LsInStatus { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public String LsInStatusName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public string PatTypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public String PatTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = false)]
        public double DiscDiag { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = false)]
        public double DiscIn { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = false)]
        public int LsGFPatType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public String LsGFPatTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public string TallyTypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public String TallyTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = false)]
        public string TallyGroupId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public String TallyGroupName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41, IsRequired = false)]
        public Boolean IsGf { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42, IsRequired = false)]
        public Boolean IsYb { get; set; }

        ////////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public string FamilyId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 44, IsRequired = false)]
        public string CommitteeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 45, IsRequired = false)]
        public string WorktypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 46, IsRequired = false)]
        public double ArrearAmount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 47, IsRequired = false)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 48, IsRequired = true)]
        public string OperID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 49, IsRequired = false)]
        public string MotherHospId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 50, IsRequired = false)]
        public string MzRegId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 51, IsRequired = false)]
        public int HospitalId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 52, IsRequired = true)]
        public String Illness { get; set; }

        ////////////////////////////////[DataMemberr(Order = 53, IsRequired = true)]
        public Boolean IsEndChg { get; set; }

        ////////////////////////////////[DataMemberr(Order = 54, IsRequired = true)]
        public String IdCardNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 55, IsRequired = true)]
        public String LinkmanName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 56, IsRequired = true)]
        public String LinkmanPhone { get; set; }

        ////////////////////////////////[DataMemberr(Order = 57, IsRequired = false)]
        public string Age { get; set; }

        ////////////////////////////////[DataMemberr(Order = 58, IsRequired = false)]
        public string SpecialityId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 59, IsRequired = true)]
        public String LocSource { get; set; }

        ////////////////////////////////[DataMemberr(Order = 60, IsRequired = false)]
        public double Weight { get; set; }

        ////////////////////////////////[DataMemberr(Order = 61, IsRequired = true)]
        public String InvoiceStuts { get; set; }

        ////////////////////////////////[DataMemberr(Order = 62, IsRequired = true)]
        public String InvoiceTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 63, IsRequired = false)]
        public Int32 IsBB { get; set; }

        ////////////////////////////////[DataMemberr(Order = 64, IsRequired = false)]
        public Boolean AmountAuth { get; set; }

        ////////////////////////////////[DataMemberr(Order = 65, IsRequired = true)]
        public String Author { get; set; }

        ////////////////////////////////[DataMemberr(Order = 66, IsRequired = true)]
        public String AuthorName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 67, IsRequired = true)]
        public String number2 { get; set; }
    }

    [Serializable]
    public class UspPsApplyReport : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = false)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String ApplyNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String UserName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String Equipment { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public String ApplyMemo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String CheckBody { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public String CheckParm { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public String CheckDesc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public String CheckResult { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public String CheckAdvice { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public String DoctorName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public String LocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public String BedName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public String PatientName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public String CardNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public String SexName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public String Age { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public String MzRegNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public String InPatNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public String Summary { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public String Diagnose { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public int XType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public String InvoNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public double Amount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public String PatTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public String Mobile { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public String Residence { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = false)]
        public string ReportOper { get; set; }
        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = false)]
        public bool Checked { get; set; }
        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = false)]
        public string OperId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = false)]
        public string LocationId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = false)]
        public string DoctorId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = false)]
        public string PatId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public string MzRegId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = false)]
        public string HospId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = false)]
        public bool IsCancel { get; set; }
        ////////////////////////////////[DataMemberr(Order = 41, IsRequired = false)]
        public DateTime CancelTime { get; set; }
        ////////////////////////////////[DataMemberr(Order = 42, IsRequired = false)]
        public string CancelOperId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public bool IsPre { get; set; }
        ////////////////////////////////[DataMemberr(Order = 44, IsRequired = false)]
        public bool IsCharged { get; set; }
        ////////////////////////////////[DataMemberr(Order = 45, IsRequired = false)]
        public bool IsConfirm { get; set; }
        ////////////////////////////////[DataMemberr(Order = 46, IsRequired = false)]
        public DateTime ConfirmTime { get; set; }
        ////////////////////////////////[DataMemberr(Order = 47, IsRequired = false)]
        public string ExecLocId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 48, IsRequired = false)]
        public DateTime CheckTime { get; set; }
        ////////////////////////////////[DataMemberr(Order = 49, IsRequired = false)]
        public string CheckOperId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 50, IsRequired = false)]
        public DateTime ReportTime { get; set; }
        ////////////////////////////////[DataMemberr(Order = 51, IsRequired = false)]
        public string ReportOperId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 52, IsRequired = false)]
        public string AuthOperId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 53, IsRequired = false)]
        public bool IsAbNormal { get; set; }
        ////////////////////////////////[DataMemberr(Order = 54, IsRequired = false)]
        public string CheckId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 55, IsRequired = false)]
        public string ExecuteId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 56, IsRequired = false)]
        public int lsStatus { get; set; }
        ////////////////////////////////[DataMemberr(Order = 57, IsRequired = false)]
        public string CompGroupId { get; set; }
        ////////////////////////////////[DataMemberr(Order = 58, IsRequired = false)]
        public bool IsExecute { get; set; }
        ////////////////////////////////[DataMemberr(Order = 59, IsRequired = false)]
        public string ItemName { get; set; }
        ////////////////////////////////[DataMemberr(Order = 60, IsRequired = false)]
        public DateTime BirthDate { get; set; }
    }
    //public class PSApplyItem:BaseModel
    //{
    //    #region 构造函数
    //    /// <summary>
    //    ///  构造函数
    //    /// </summary>
    //    public PSApplyItem()
    //    {
    //    }
    //    #endregion

    //    #region 字段  CancelOperId, CancelTime, CheckBody-部位, IsCancel, ItemId-检查项目, OperTime-申请时间, PsApplyId-检查报告申请表GUID

    //    ////////////////////////////////[DataMemberr(Order = 9)]
    //    public   string GUID { get; set; }

    //    /// <summary>
    //    /// 
    //    /// </summary>	
    //    ////////////////////////////////[DataMemberr(Order = 10)]
    //    public   string CancelOperId { get; set; }

    //    /// <summary>
    //    /// 
    //    /// </summary>	
    //    ////////////////////////////////[DataMemberr(Order = 11)]
    //    public   DateTime CancelTime { get; set; }

    //    /// <summary>
    //    /// 部位
    //    /// </summary>	
    //    ////////////////////////////////[DataMemberr(Order = 12)]
    //    public   string CheckBody { get; set; }

    //    /// <summary>
    //    /// 
    //    /// </summary>	
    //    ////////////////////////////////[DataMemberr(Order = 13)]
    //    public   Boolean IsCancel { get; set; }

    //    /// <summary>
    //    /// 检查项目
    //    /// </summary>	
    //    ////////////////////////////////[DataMemberr(Order = 14)]
    //    public   string ItemId { get; set; }

    //    /// <summary>
    //    /// 申请时间
    //    /// </summary>	
    //    ////////////////////////////////[DataMemberr(Order = 15)]
    //    public   DateTime OperTime { get; set; }

    //    /// <summary>
    //    /// 检查报告申请表GUID
    //    /// </summary>	
    //    ////////////////////////////////[DataMemberr(Order = 16)]
    //    public   string PsApplyId { get; set; }

    //    #endregion
    //}
    [Serializable]
    public class UspininvoicedtlUmp : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public String code { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String PatName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String InpatNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public String LocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String BedName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public string hospid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public string itemid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public DateTime regopertime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public string regoperid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public string locationid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public string adviceid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public double totality { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public int lsmarktype { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public double pricein { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public string unitid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public Boolean ispay { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public double discself { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public double discin { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public double amount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public double amountfact { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public double amountself { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public double amounttally { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public double amountpay { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = false)]
        public string invoid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public int lsperform { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public Boolean ismodidisc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = false)]
        public string limitgroupid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = false)]
        public double limitfee { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public string doctorid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public string execoperid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public string execlocid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public string invitemid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public string feeid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public string feehsid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public Boolean iscancel { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = true)]
        public Boolean ismanual { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = false)]
        public string cancelid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41, IsRequired = false)]
        public Int32 lsreporttype { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
        public String memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public DateTime opertime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 44, IsRequired = true)]
        public string operid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 45, IsRequired = true)]
        public String advicename { get; set; }

        ////////////////////////////////[DataMemberr(Order = 46, IsRequired = false)]
        public Int32 GroupNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 47, IsRequired = true)]
        public DateTime REGOPERDATE { get; set; }

        ////////////////////////////////[DataMemberr(Order = 48, IsRequired = true)]
        public String hostname { get; set; }

        ////////////////////////////////[DataMemberr(Order = 49, IsRequired = false)]
        public string groupitemid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 50, IsRequired = false)]
        public string xdrpid { get; set; }

        ////////////////////////////////[DataMemberr(Order = 51, IsRequired = true)]
        public String advicename1 { get; set; }

        ////////////////////////////////[DataMemberr(Order = 52, IsRequired = true)]
        public String regdate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 53, IsRequired = true)]
        public String Checkres { get; set; }

        ////////////////////////////////[DataMemberr(Order = 54, IsRequired = true)]
        public String urgent { get; set; }

        ////////////////////////////////[DataMemberr(Order = 55, IsRequired = false)]
        public double Dosage { get; set; }

        ////////////////////////////////[DataMemberr(Order = 56, IsRequired = true)]
        public String UnitName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 57, IsRequired = true)]
        public String UnitInName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 58, IsRequired = true)]
        public String FrequencyName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 59, IsRequired = false)]
        public Int32 IsCheck { get; set; }

        ////////////////////////////////[DataMemberr(Order = 60, IsRequired = false)]
        public DateTime CHECKTIME { get; set; }

        ////////////////////////////////[DataMemberr(Order = 61, IsRequired = false)]
        public string CHECKOPERID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 62, IsRequired = false)]
        public DateTime DELETETIME { get; set; }

        ////////////////////////////////[DataMemberr(Order = 63, IsRequired = false)]
        public string DELETEOPERID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 64, IsRequired = false)]
        public int LSSTATUS { get; set; }

        ////////////////////////////////[DataMemberr(Order = 65, IsRequired = false)]
        public string AUTHDTLID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 66, IsRequired = false)]
        public int lsrptype { get; set; }

        ////////////////////////////////[DataMemberr(Order = 67, IsRequired = false)]
        public double dosage1 { get; set; }

        ////////////////////////////////[DataMemberr(Order = 68, IsRequired = true)]
        public String Inpatno1 { get; set; }

        ////////////////////////////////[DataMemberr(Order = 69, IsRequired = false)]
        public DateTime deletetime1 { get; set; }

        ////////////////////////////////[DataMemberr(Order = 70, IsRequired = false)]
        public string deleteoperid1 { get; set; }

        ////////////////////////////////[DataMemberr(Order = 71, IsRequired = true)]
        public String FeeSource { get; set; }

        ////////////////////////////////[DataMemberr(Order = 72, IsRequired = false)]
        public bool IsAutoCharged { get; set; }
    }
    [Serializable]
    public class OuHosInfoServiceWithCheckMzRegIdPat : BaseModel
    {
        public bool IsLoadLastOuHos { set; get; }
        public string LastInvoNo { set; get; }
        public string CurrentInvoiceId { set; get; }
        public OuHosInfo InfoOuHos { set; get; }
        public BsPatient InfoBsPatient { set; get; }

        /// <summary>
        /// 记录当前病人与挂号类别对应的挂号费对象
        /// </summary>
        public UspBsRegPatAmount UspBsRegPatAmount { set; get; }
        public double LastFactGet { set; get; }

    }

    [Serializable]
    public class UspBsRegPatAmount : BaseModel
    {

        public string GUID { get; set; }

        public string RegTypeID { get; set; }


        public string PatTypeID { get; set; }


        public double RegFee { get; set; }


        public double DiagnoFee { get; set; }


        public double OtherFee1 { get; set; }


        public double OtherFee2 { get; set; }


        public double PaySel { get; set; }


        public double TallyFee { get; set; }


        public String Name { get; set; }

        public int IconIndex { get; set; }


        public Boolean IsActive { get; set; }


        public int OrderBy { get; set; }


        public String Code { get; set; }


        public double TotalDiagnoFee { get; set; }

        public double zyFee { get; set; }
    }

    [Serializable]
    public class UspGetDgRoad : BaseModel
    {
        public string GUID { get; set; }

        public String Code { get; set; }

        public String Name { get; set; }

        public int LsOpenType { get; set; }

        public string OperId { get; set; }

        public DateTime OperTime { get; set; }

        public string LocationId { get; set; }

        public Boolean IsBaby { get; set; }

        public Boolean IsWomen { get; set; }

        public Boolean Ismen { get; set; }

        public Boolean IsOlder { get; set; }

        public String Memo { get; set; }

        public Boolean IsActive { get; set; }

        public String Zdyj { get; set; }

        public String Zlfa { get; set; }

        public String Jrljbz { get; set; }

        public String Zyzhxgc { get; set; }

        public String Ryjcxm { get; set; }

        public String Zlff { get; set; }

        public String Cybz { get; set; }

        public String Bzzyr { get; set; }

        public Int32 Bzljrbegin { get; set; }

        public Int32 Bzljrend { get; set; }
    }

    [Serializable]
    public class UspGetOaBookInfo : BaseModel
    {
        public string GUID { get; set; }

        public String Code { get; set; }

        public int LsDocType { get; set; }

        public String Name { get; set; }

        public int LsOpenType { get; set; }

        public DateTime OperTime { get; set; }

        public DateTime ExpireTime { get; set; }

        public String OperName { get; set; }

        public string AllowOperId { get; set; }
    }

    [Serializable]
    public class UspGetOaBookByIdInfoQry : BaseModel
    {
        public string GUID { get; set; }

        public DateTime OperTime { get; set; }

        public String Code { get; set; }

        public int LsDocType { get; set; }

        public String Name { get; set; }

        public int LsOpenType { get; set; }

        public String OperName { get; set; }

        public Byte[] DocFile { get; set; }

        public DateTime ExpireTime { get; set; }

        public String filename { get; set; }
    }



    #region UspRdInfectiousAuth

    [Serializable]
    public class UspRdInfectiousAuth : BaseModel
    {
        public DateTime OperTime { get; set; }

        public String OperName { get; set; }

        public String Code { get; set; }

        public DateTime InTime { get; set; }

        public String Name { get; set; }

        public String JName { get; set; }

        public String LscardType { get; set; }

        public Int32 Lscensus { get; set; }

        public Int32 Lscanceltype { get; set; }

        public Int32 LscancelType2 { get; set; }

        public DateTime IllDate { get; set; }

        public Int32 IllType { get; set; }
        public String IllName { get; set; }
        public String Illidcor { get; set; }
        public String LocName { get; set; }
        public Int32 LsPreventive { get; set; }
        public String ReportUnit { get; set; }
        public String Phone { get; set; }

        public String CancelOperName { get; set; }

        public String CancelMemo { get; set; }
        public DateTime CancelOperTime { get; set; }

        public String Memo { get; set; }
        public DateTime ReportDate { get; set; }

        public String ChkOperName { get; set; }

        public DateTime ChkOperTime { get; set; }

        public DateTime DiagDate { get; set; }

        public DateTime DeadDate { get; set; }

        public string MzregId { get; set; }

        public String MzregNo { get; set; }

        public string HospId { get; set; }
        public String InpatNo { get; set; }

        public string ChkOperId { get; set; }

        public String WriteState { get; set; }

        public string Operid { get; set; }

        public String DeleteMemo { get; set; }

        public String Sex { get; set; }

        public String Age { get; set; }

        public String Residence { get; set; }

        public bool IsSelect { get; set; }
    }

    [Serializable]
    public class UspPsApplyReportByApplyNo : BaseModel
    {
        public String ApplyNo { get; set; }
        public DateTime OperTime { get; set; }
        public string OperId { get; set; }
        public string LocationId { get; set; }
        public string DoctorId { get; set; }
        public string PatId { get; set; }
        public string MzRegId { get; set; }
        public string HospId { get; set; }
        public Boolean IsCancel { get; set; }
        public DateTime CancelTime { get; set; }
        public string CancelOperId { get; set; }
        public int XType { get; set; }
        public Boolean IsPre { get; set; }
        public string ItemId { get; set; }
        public Boolean IsCharged { get; set; }
        public Boolean IsConfirm { get; set; }
        public DateTime ConfirmTime { get; set; }
        public String Equipment { get; set; }
        public String ApplyMemo { get; set; }
        public string ExecLocId { get; set; }
        public DateTime CheckTime { get; set; }
        public string CheckOperId { get; set; }
        public DateTime ReportTime { get; set; }
        public string ReportOperId { get; set; }
        public string AuthOperId { get; set; }
        public String CheckBody { get; set; }
        public String CheckParm { get; set; }
        public String CheckDesc { get; set; }
        public String CheckResult { get; set; }
        public String CheckAdvice { get; set; }
        public Boolean IsAbNormal { get; set; }
        public String Summary { get; set; }
        public String Diagnose { get; set; }
        public string CheckId { get; set; }
        public string GUID { get; set; }
        public string ExecuteId { get; set; }
        public String CallGroup { get; set; }
        public int lsStatus { get; set; }
        public string CompGroupId { get; set; }
        public Boolean IsAuthed { get; set; }
        public Boolean IsExecute { get; set; }
        public String LocationName { get; set; }
        public String PatientName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public String Sex { get; set; }
        public String Name { get; set; }
        public String UserName { get; set; }
        public String SexName { get; set; }
        public String AgeString { get; set; }
        public String InPatNo { get; set; }
        public String BedName { get; set; }
    }

    [Serializable]
    public class UspOuCheckRecipeByXType : BaseModel
    {
        public Int32 GUID { get; set; }
        public string MzRegId { get; set; }
        public String MzRegNo { get; set; }
        public DateTime RegTime { get; set; }
        public String Name { get; set; }
        public string ItemId { get; set; }
        public DateTime RecipeTime { get; set; }
        public string LocationId { get; set; }
        public string DoctorId { get; set; }
        public Boolean IsPriority { get; set; }
        public String Memo { get; set; }
        public Boolean IsPend { get; set; }
        public Boolean IsExecuted { get; set; }
        public String CardNo { get; set; }
        public String RecipeNum { get; set; }
        public String ContactPhone { get; set; }
        public String PyCode1 { get; set; }
        public String WbCode1 { get; set; }
        public String PyCode2 { get; set; }
        public String WbCode2 { get; set; }
        public String PyCode3 { get; set; }
        public String WbCode3 { get; set; }
        public String LocationName { get; set; }
        public String DoctorName { get; set; }
        public String CheckBody { get; set; }
        public string PsApplyRptID { get; set; }
        public String Source { get; set; }
        public string PatId { get; set; }
        public int XType { get; set; }
        public int lsStatus { get; set; }
    }

    [Serializable]
    public class UspDiagMeetingDoctors : BaseModel
    {
        public virtual string DiagDoctorLocation { get; set; }
        public virtual string DiagMeetingLocation { get; set; }
        public virtual string DoctorId { get; set; }
        public virtual DateTime ConfirmTime { get; set; }
        public virtual Boolean IsConfirm { get; set; }
        public virtual string ApplyId { get; set; }
        public virtual String Answer { get; set; }
        public virtual String ApplyNo { get; set; }
        public virtual DateTime ApplyTime { get; set; }
        public virtual Boolean IsUrgent { get; set; }
        public virtual string OperId { get; set; }
        public virtual DateTime OperTime { get; set; }
        public virtual string GUID { get; set; }

    }

    [Serializable]
    public class UspPsApplyReportIsExecute : BaseModel
    {
        public virtual String ApplyNo { get; set; }
        public virtual DateTime OperTime { get; set; }
        public virtual string OperId { get; set; }
        public virtual string LocationId { get; set; }
        public virtual string DoctorId { get; set; }
        public virtual string PatId { get; set; }
        public virtual string MzRegId { get; set; }
        public virtual string HospId { get; set; }
        public virtual Boolean IsCancel { get; set; }
        public virtual DateTime CancelTime { get; set; }
        public virtual string CancelOperId { get; set; }
        public virtual int XType { get; set; }
        public virtual Boolean IsPre { get; set; }
        public virtual string ItemId { get; set; }
        public virtual Boolean IsCharged { get; set; }
        public virtual Boolean IsConfirm { get; set; }
        public virtual DateTime ConfirmTime { get; set; }
        public virtual String Equipment { get; set; }
        public virtual String ApplyMemo { get; set; }
        public virtual string ExecLocId { get; set; }
        public virtual DateTime CheckTime { get; set; }
        public virtual string CheckOperId { get; set; }
        public virtual DateTime ReportTime { get; set; }
        public virtual string ReportOperId { get; set; }
        public virtual string AuthOperId { get; set; }
        public virtual String CheckBody { get; set; }
        public virtual String CheckParm { get; set; }
        public virtual String CheckDesc { get; set; }
        public virtual String CheckResult { get; set; }
        public virtual String CheckAdvice { get; set; }
        public virtual Boolean IsAbNormal { get; set; }
        public virtual String Summary { get; set; }
        public virtual String Diagnose { get; set; }
        public virtual string CheckId { get; set; }
        public virtual string GUID { get; set; }
        public virtual string ExecuteId { get; set; }
        public virtual String CallGroup { get; set; }
        public virtual int lsStatus { get; set; }
        public virtual string CompGroupId { get; set; }
        public virtual Boolean IsAuthed { get; set; }
        public virtual Boolean IsExecute { get; set; }
        public virtual String DoctorName { get; set; }
        public virtual String LocationName { get; set; }
        public virtual String BedName { get; set; }
        public virtual String PatientName { get; set; }
        public virtual String CardNo { get; set; }
        public virtual String SexName { get; set; }
        public virtual String Sex { get; set; }
        public virtual String Age { get; set; }
        public virtual String BirthDate { get; set; }
        public virtual String MzRegNo { get; set; }
        public virtual String InPatNo { get; set; }
        public virtual String Name { get; set; }
        public virtual String UserName { get; set; }
    }

    [Serializable]
    public class UspPsDrugAction : BaseModel
    {
        public virtual string GUID { get; set; }
        public virtual String ApplyNo { get; set; }
        public virtual DateTime OperTime { get; set; }
        public virtual string OperId { get; set; }
        public virtual string LocationId { get; set; }
        public virtual string DoctorId { get; set; }
        public virtual string PatId { get; set; }
        public virtual string MzRegId { get; set; }
        public virtual string HospId { get; set; }
        public virtual Boolean IsCancel { get; set; }
        public virtual DateTime CancelTime { get; set; }
        public virtual string CancelOperId { get; set; }
        public virtual string ItemId { get; set; }
        public virtual DateTime ReactTime { get; set; }
        public virtual int LsTransType { get; set; }
        public virtual String ClincHandle { get; set; }
        public virtual String Memo { get; set; }
        public virtual String ItemName { get; set; }
        public virtual String PatName { get; set; }
        public virtual String LocationName { get; set; }
        public virtual String LsTransTypeName { get; set; }
    }

    [Serializable]
    public class UspPsApplyItem : BaseModel
    {
        public UspPsApplyItem() { }

        #region Public Properties
        public string GUID
        {
            get;
            set;
        }

        /// <summary>  
        /// 项目编号
        /// </summary>  
        public string ItemCode
        {
            get;
            set;
        }

        /// <summary>  
        /// 项目名称
        /// </summary>  
        public string ItemName
        {
            get;
            set;
        }

        /// <summary>  
        /// 检查部位 
        /// </summary>  
        public string CheckBody
        {
            get;
            set;
        }

        /// <summary>  
        /// 操作时间 
        /// </summary>  
        public DateTime OperTime
        {
            get;
            set;
        }

        /// <summary>  
        /// 申请单GUID 
        /// </summary>  
        public string PsApplyId
        {
            get;
            set;
        }

        /// <summary>  
        /// 项目GUID 
        /// </summary>  
        public string ItemId
        {
            get;
            set;
        }

        #endregion
    }

    [Serializable]
    public class UspPsApplyReportUs : BaseModel
    {
        public UspPsApplyReportUs() { }

        #region Public Properties

        public DateTime OperTime
        {
            get;
            set;
        }
        public double Amount
        {
            get;
            set;
        }

        public string ApplyNo
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }

        public string Equipment
        {
            get;
            set;
        }

        public string ApplyMemo
        {
            get;
            set;
        }

        public string CheckBody
        {
            get;
            set;
        }

        public string CheckParm
        {
            get;
            set;
        }

        public string CheckDesc
        {
            get;
            set;
        }

        public string CheckResult
        {
            get;
            set;
        }

        public string CheckAdvice
        {
            get;
            set;
        }

        public DateTime CheckTime
        {
            get;
            set;
        }
        public DateTime ReportTime
        {
            get;
            set;
        }
        public string DoctorName
        {
            get;
            set;
        }

        public string LocationName
        {
            get;
            set;
        }

        public string BedName
        {
            get;
            set;
        }

        public string PatientName
        {
            get;
            set;
        }

        public string CardNo
        {
            get;
            set;
        }

        public string SexName
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public string AgeString
        {
            get;
            set;
        }

        public string MzRegNo
        {
            get;
            set;
        }

        public string InPatNo
        {
            get;
            set;
        }

        public string Summary
        {
            get;
            set;
        }

        public string Diagnose
        {
            get;
            set;
        }

        public int XType
        {
            get;
            set;
        }

        public string PatId
        {
            get;
            set;
        }

        public bool IsImage
        {
            get;
            set;
        }


        public string PatTypeName
        {
            get;
            set;
        }

        public string Mobile
        {
            get;
            set;
        }

        public string Residence
        {
            get;
            set;
        }


        public string DrugType
        {
            get;
            set;
        }

        /// <summary>  
        ///   
        /// </summary>  
        public byte[] RptImage
        {
            get;
            set;
        }

        /// <summary>  
        /// 文件名  
        /// </summary>  
        public string FileName
        {
            get;
            set;
        }
        #endregion
    }

    [Serializable]
    public class PacsWithPsApplyReportCode : BaseModel
    {
        public DateTime BeginTime { set; get; }
        public DateTime EndTime { set; get; }
        public bool IsCharged { set; get; }
        public int XType { set; get; }
        public Boolean IsExecute { set; get; }
        public string DoctorId { set; get; }
        public int lsStatus { set; get; }
        public string Equipment { set; get; }
        public string ApplyNo { set; get; }
        public string PatientName { set; get; }
        public string ReportOper { set; get; }
        public string CheckResult { set; get; }
        public bool IsAbNormal { set; get; }
        public bool Checked { set; get; }
    }
    #endregion UspRdInfectiousAuth

    #region UspOuRecipeDtail

    [Serializable]
    public class UspOuRecipeDtail : BaseModel
    {

        public virtual String Name { get; set; }

        public virtual int GroupNum { get; set; }

        public virtual string ItemId { get; set; }

        public virtual String Spec { get; set; }

        public virtual string FrequencyId { get; set; }

        public virtual string UsageId { get; set; }

        public virtual double Dosage { get; set; }

        public virtual int Days { get; set; }

        public virtual double Totality { get; set; }

        public virtual string UnitTakeId { get; set; }

        public virtual string FormId { get; set; }

        public virtual double Price { get; set; }

        public virtual string ExecLocId { get; set; }

        public virtual String Memo { get; set; }

        public virtual string XdRpId { get; set; }

        public virtual Boolean IsActive { get; set; }

        public virtual int LsRpType { get; set; }

        public virtual string UnitId { get; set; }

        public virtual double FeeTotality { get; set; }

        public virtual double Amount { get; set; }

        public virtual string ApplyId { get; set; }

        public virtual String YbType { get; set; }

        public virtual String Code { get; set; }

        public virtual string RecipeId { get; set; }

        public virtual String TempStr { get; set; }

        public virtual double LimitTotalZy { get; set; }

        public virtual string UnitDiagId { get; set; }

        public virtual Int32 DiscountAoumt { get; set; }
    }

    #endregion UspOuRecipeDtail

    #region UspBsXdRpDtl
    [Serializable]
    public class UspBsXdRpDtl : BaseModel
    {

        public virtual String Name { get; set; }
        public virtual int GroupNum { get; set; }

        public virtual String ItemId { get; set; }

        public virtual String Spec { get; set; }

        public virtual String FrequencyId { get; set; }

        public virtual String UsageId { get; set; }

        public virtual double Dosage { get; set; }

        public virtual int Days { get; set; }

        public virtual double Totality { get; set; }

        public virtual String UnittakeId { get; set; }

        public virtual String FormId { get; set; }

        public virtual double Price { get; set; }

        public virtual String Execlocid { get; set; }

        public virtual String Memo { get; set; }

        public virtual String XdrpId { get; set; }

        public virtual Boolean IsacTive { get; set; }

        public virtual int LsrpType { get; set; }

        public virtual String UnitId { get; set; }

        public virtual double FeetoTality { get; set; }

        public virtual double Amount { get; set; }

        public virtual String Code { get; set; }

        public virtual string RecipeId { get; set; }

        public virtual String TempStr { get; set; }

        public virtual double LimitTotalZy { get; set; }

        public virtual string UnitDiagId { get; set; }

        public virtual double DiscountAoumt { get; set; }
    }
    #endregion

    #region UspInHosInfoByCardNo

    [Serializable]
    public class UspInHosInfoByCardNo : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public virtual String HospNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public virtual String InPatNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public virtual String CardNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public virtual String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public virtual String Sex { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
        public virtual DateTime BirthDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public virtual int LsMarriage { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public virtual String BloodGroup { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public virtual DateTime InTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public virtual Int32 NTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public virtual String XNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = false)]
        public virtual string CountryId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public virtual String Residence { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public virtual String City { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public virtual String Province { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public virtual Boolean IsOversea { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = false)]
        public virtual DateTime PassTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public virtual String IdCardNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public virtual String Company { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public virtual String Occupation { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = false)]
        public virtual string WorktypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public virtual string PatTypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = false)]
        public virtual string CertificateId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public virtual int LsInType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public virtual Int32 LsInWay { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public virtual Int32 LsInIllness { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = false)]
        public virtual Int32 DocMz { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public virtual Int32 LocIn { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = false)]
        public virtual string LocationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = false)]
        public virtual string BedId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public virtual Boolean IsYbMt { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public virtual String YbRegNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = false)]
        public virtual double ArrearAmount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public virtual Boolean IsBaby { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public virtual Int32 AgeDay { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = false)]
        public virtual double Height { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = false)]
        public virtual double Weight { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public virtual String PhoneHome { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public virtual String AddressHome { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
        public virtual String PostCodeHome { get; set; }

        ////////////////////////////////[DataMemberr(Order = 43, IsRequired = true)]
        public virtual String AreaCodeHome { get; set; }

        ////////////////////////////////[DataMemberr(Order = 44, IsRequired = true)]
        public virtual String PhoneWork { get; set; }

        ////////////////////////////////[DataMemberr(Order = 45, IsRequired = true)]
        public virtual String AddressWork { get; set; }

        ////////////////////////////////[DataMemberr(Order = 46, IsRequired = true)]
        public virtual String PostCodeWork { get; set; }

        ////////////////////////////////[DataMemberr(Order = 47, IsRequired = true)]
        public virtual String AreaCodeWork { get; set; }

        ////////////////////////////////[DataMemberr(Order = 48, IsRequired = true)]
        public virtual String LinkmanName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 49, IsRequired = false)]
        public virtual string RelationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 50, IsRequired = true)]
        public virtual String LinkmanPhone { get; set; }

        ////////////////////////////////[DataMemberr(Order = 51, IsRequired = true)]
        public virtual String LinkmanAddress { get; set; }

        ////////////////////////////////[DataMemberr(Order = 52, IsRequired = true)]
        public virtual String LinkmanPost { get; set; }

        ////////////////////////////////[DataMemberr(Order = 53, IsRequired = true)]
        public virtual String LinkmanArea { get; set; }

        ////////////////////////////////[DataMemberr(Order = 54, IsRequired = true)]
        public virtual Int32 LsInStatus { get; set; }

        ////////////////////////////////[DataMemberr(Order = 55, IsRequired = true)]
        public virtual String Status { get; set; }

        ////////////////////////////////[DataMemberr(Order = 56, IsRequired = false)]
        public virtual DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 57, IsRequired = true)]
        public virtual string OperID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 58, IsRequired = true)]
        public virtual String MedicareNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 59, IsRequired = true)]
        public virtual String AccountNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 60, IsRequired = false)]
        public virtual string RegionId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 61, IsRequired = false)]
        public virtual string AreaId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 62, IsRequired = true)]
        public virtual String Native { get; set; }

        ////////////////////////////////[DataMemberr(Order = 63, IsRequired = true)]
        public virtual String Mobile { get; set; }

        ////////////////////////////////[DataMemberr(Order = 64, IsRequired = true)]
        public virtual String Email { get; set; }

        ////////////////////////////////[DataMemberr(Order = 65, IsRequired = true)]
        public virtual String Phone { get; set; }

        ////////////////////////////////[DataMemberr(Order = 66, IsRequired = true)]
        public virtual Int32 Circumference { get; set; }

        ////////////////////////////////[DataMemberr(Order = 67, IsRequired = true)]
        public virtual Int32 Waistline { get; set; }

        ////////////////////////////////[DataMemberr(Order = 68, IsRequired = true)]
        public virtual Int32 Sternline { get; set; }

        ////////////////////////////////[DataMemberr(Order = 69, IsRequired = true)]
        public virtual string PatID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 70, IsRequired = false)]
        public virtual DateTime OutTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 71, IsRequired = true)]
        public virtual Boolean IsEndChg { get; set; }

        ////////////////////////////////[DataMemberr(Order = 72, IsRequired = false)]
        public virtual string EndChgOperID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 73, IsRequired = false)]
        public virtual DateTime EndchgoperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 74, IsRequired = true)]
        public virtual String AgeStr { get; set; }

        ////////////////////////////////[DataMemberr(Order = 75, IsRequired = false)]
        public virtual Int32 Age { get; set; }

        ////////////////////////////////[DataMemberr(Order = 76, IsRequired = true)]
        public virtual String Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 77, IsRequired = false)]
        public virtual string NationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 78, IsRequired = false)]
        public virtual string ProvinceId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 79, IsRequired = true)]
        public virtual String Sensitive { get; set; }

        ////////////////////////////////[DataMemberr(Order = 80, IsRequired = false)]
        public virtual string FamilyId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 81, IsRequired = true)]
        public virtual Boolean isHouseMaster { get; set; }

        ////////////////////////////////[DataMemberr(Order = 82, IsRequired = false)]
        public virtual string RelaMasterId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 83, IsRequired = true)]
        public virtual Int32 LsCensus { get; set; }

        ////////////////////////////////[DataMemberr(Order = 84, IsRequired = false)]
        public virtual string CommitteeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 85, IsRequired = false)]
        public virtual string PoliceStationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 86, IsRequired = false)]
        public virtual string LevelId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 87, IsRequired = true)]
        public virtual Int32 LsSport { get; set; }

        ////////////////////////////////[DataMemberr(Order = 88, IsRequired = true)]
        public virtual Int32 LsSportTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 89, IsRequired = true)]
        public virtual Int32 LsSportType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 90, IsRequired = true)]
        public virtual Int32 LsBitHabit { get; set; }

        ////////////////////////////////[DataMemberr(Order = 91, IsRequired = true)]
        public virtual Int32 SleepHour { get; set; }

        ////////////////////////////////[DataMemberr(Order = 92, IsRequired = true)]
        public virtual Int32 LsSleepTrouble { get; set; }

        ////////////////////////////////[DataMemberr(Order = 93, IsRequired = true)]
        public virtual String SmokeHistory { get; set; }

        ////////////////////////////////[DataMemberr(Order = 94, IsRequired = true)]
        public virtual String DrinkHistory { get; set; }

        ////////////////////////////////[DataMemberr(Order = 95, IsRequired = true)]
        public virtual String OtherHabit { get; set; }

        ////////////////////////////////[DataMemberr(Order = 96, IsRequired = true)]
        public virtual Boolean IsActive { get; set; }

        ////////////////////////////////[DataMemberr(Order = 97, IsRequired = true)]
        public virtual String InActiveReason { get; set; }

        ////////////////////////////////[DataMemberr(Order = 98, IsRequired = false)]
        public virtual DateTime InActiveTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 99, IsRequired = false)]
        public virtual string InActiveOperID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 100, IsRequired = true)]
        public virtual Int32 IconIndex { get; set; }

        ////////////////////////////////[DataMemberr(Order = 101, IsRequired = false)]
        public virtual string FromHospitalId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 102, IsRequired = false)]
        public virtual string MzRegId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 103, IsRequired = false)]
        public virtual Boolean IsIllegal { get; set; }

        ////////////////////////////////[DataMemberr(Order = 104, IsRequired = true)]
        public virtual String TipsOther { get; set; }

        ////////////////////////////////[DataMemberr(Order = 105, IsRequired = true)]
        public virtual String FromHospital { get; set; }

        ////////////////////////////////[DataMemberr(Order = 106, IsRequired = false)]
        public virtual Int32 NUMBER1 { get; set; }

        ////////////////////////////////[DataMemberr(Order = 107, IsRequired = false)]
        public virtual Int32 NUMBER2 { get; set; }

        ////////////////////////////////[DataMemberr(Order = 108, IsRequired = false)]
        public virtual Int32 NUMBER3 { get; set; }

        ////////////////////////////////[DataMemberr(Order = 109, IsRequired = false)]
        public virtual Int32 NUMBER4 { get; set; }

        ////////////////////////////////[DataMemberr(Order = 110, IsRequired = true)]
        public virtual String YBBZCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 111, IsRequired = true)]
        public virtual String IllDesc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 112, IsRequired = true)]
        public virtual String YbPatType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 113, IsRequired = false)]
        public virtual Int32 LsYbDiff { get; set; }
    }

    #endregion UspInHosInfoByCardNo

    #region UspOuHosInfoDynamic2

    [Serializable]
    public class UspOuHosInfoDynamic2
    {
        //////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public virtual String MzRegNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public virtual String PatientName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public virtual string PatId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public virtual String CardNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public virtual String SexName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = false)]
        public virtual DateTime BirthDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public virtual String Sex { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = false)]
        public virtual Byte Age { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public virtual Int32 BabyMonth { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public virtual DateTime RegTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = true)]
        public virtual string OperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public virtual String RoomNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = false)]
        public virtual Boolean RegLocation { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public virtual Boolean IsPriority { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public virtual string RegTypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public virtual String RegTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public virtual Int32 RegDept { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public virtual String LocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = false)]
        public virtual Int32 DiagnDept { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = false)]
        public virtual Boolean IsCancel { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public virtual string PatTypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public virtual String PatTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = false)]
        public virtual string TallyTypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public virtual String TallyTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = false)]
        public virtual string TallyGroupId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public virtual String TallyGroupName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = false)]
        public virtual Boolean IsGf { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = false)]
        public virtual Boolean IsYb { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public virtual String GetTallyType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public virtual String GetTallyTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = false)]
        public virtual double ArrearAmount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public virtual Boolean IsInPatient { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = false)]
        public virtual Boolean IsRegistration { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public virtual Boolean IsOuChargeInput { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public virtual String Illdesc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = false)]
        public virtual Boolean IsLocationSee { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = false)]
        public virtual Boolean IsDiagnosed { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public virtual String DiagStatus { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
        public virtual String Mobile { get; set; }

        ////////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public virtual int HospitalId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 44, IsRequired = false)]
        public virtual string TimeSpanId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 45, IsRequired = true)]
        public virtual Int32 LineOrder { get; set; }

        ////////////////////////////////[DataMemberr(Order = 46, IsRequired = false)]
        public virtual double Height { get; set; }

        ////////////////////////////////[DataMemberr(Order = 47, IsRequired = false)]
        public virtual double Weight { get; set; }

        ////////////////////////////////[DataMemberr(Order = 48, IsRequired = false)]
        public virtual string WorktypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 49, IsRequired = true)]
        public virtual String MedicareNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 50, IsRequired = true)]
        public virtual String AgeString { get; set; }

        ////////////////////////////////[DataMemberr(Order = 51, IsRequired = true)]
        public virtual String Diagnose { get; set; }
    }

    #endregion UspOuHosInfoDynamic2

    #region UspUserSystem

    [Serializable]
    public class UspUserSystem
    {
        ////////////////////////////////[DataMemberr(Order  = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 2, IsRequired = true)]
        public virtual String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 3, IsRequired = false)]
        public virtual Int32 OrderBy { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 4, IsRequired = false)]
        public virtual Boolean IsActive { get; set; }
    }

    #endregion UspUserSystem
    #region UspUserSystemMenu

    [Serializable]
    public class UspUserSystemMenu
    {
        ////////////////////////////////[DataMemberr(Order  = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 2, IsRequired = true)]
        public virtual string SystemId { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 3, IsRequired = true)]
        public virtual String Code { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 4, IsRequired = true)]
        public virtual String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 5, IsRequired = false)]
        public virtual Int32 IconIndex { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 6, IsRequired = true)]
        public virtual String Hint { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 7, IsRequired = true)]
        public virtual String Shortcut { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 8, IsRequired = false)]
        public virtual string ParentID { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 9, IsRequired = false)]
        public virtual Int32 OrderBy { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 10, IsRequired = false)]
        public virtual Boolean IsMostUsed { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 11, IsRequired = false)]
        public virtual Boolean IsBeginGroup { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 12, IsRequired = false)]
        public virtual Boolean IsActive { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 13, IsRequired = true)]
        public virtual String Url { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 14, IsRequired = true)]
        public virtual String ReportType { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 15, IsRequired = false)]
        public virtual Boolean IsSelect { get; set; }
    }

    #endregion UspUserSystemMenu

    #region UspRoleModule

    [Serializable]
    public class UspRoleModule
    {
        ////////////////////////////////[DataMemberr(Order  = 1, IsRequired = true)]
        public virtual String GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 2, IsRequired = true)]
        public virtual String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 3, IsRequired = true)]
        public virtual String ParentID { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 4, IsRequired = false)]
        public virtual bool IsChecked { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 5, IsRequired = false)]
        public virtual string ModuleId { get; set; }
    }

    #endregion UspRoleModule

    #region UspRoleUser

    [Serializable]
    public class UspRoleUser
    {
        ////////////////////////////////[DataMemberr(Order  = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 2, IsRequired = true)]
        public virtual String Code { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 3, IsRequired = true)]
        public virtual String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 4, IsRequired = true)]
        public virtual String RoleName { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 5, IsRequired = false)]
        public virtual Boolean IsActive { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 6, IsRequired = false)]
        public virtual Boolean IsAuthOper { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 7, IsRequired = true)]
        public virtual string AuthOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 8, IsRequired = true)]
        public virtual String AuthOperName { get; set; }
    }

    #endregion UspRoleUser

    #region UspUserRole

    [Serializable]
    public class UspUserRole
    {
        ////////////////////////////////[DataMemberr(Order  = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 2, IsRequired = true)]
        public virtual String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 3, IsRequired = false)]
        public virtual DateTime LimitDate { get; set; }

        ////////////////////////////////[DataMemberr(Order  = 4, IsRequired = false)]
        public virtual Int32 IsCheck { get; set; }
    }

    #endregion UspUserRole

    [Serializable]
    public class UspCalRmstoreStockNum : BaseModel
    {

        public virtual string GUID { get; set; }


        public virtual double StockNum { get; set; }
    }

    [Serializable]
    public class UspGetUserEmail : BaseModel
    {

        public virtual string GUID { get; set; }


        public virtual String Title { get; set; }


        public virtual String Content { get; set; }


        public virtual String FileName { get; set; }


        public virtual DateTime OperTime { get; set; }


        public virtual string OperId { get; set; }


        public virtual Boolean IsSign { get; set; }


        public virtual Boolean IsPriority { get; set; }


        public virtual Boolean IsAuth { get; set; }


        public virtual Boolean IsFeedback { get; set; }
    }

    [Serializable]
    public class UspInDayAdd : BaseModel
    {
        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public virtual string HospId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public virtual string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = false)]
        public virtual DateTime BeginTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public virtual double Totality { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public virtual string UnitId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public virtual String Name { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public virtual String Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = false)]
        public virtual double PriceIn { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public virtual double Amount { get; set; }



    }

    #region RdCancer

    [Serializable]
    public class RdCancer:BaseModel
    {
        #region Public Properties
        //Order = 10)]
        public virtual string GUID { get; set; }

        //Order = 11)]
        public virtual string PatId { get; set; }

        //Order = 12)]
        public virtual DateTime OperTime { get; set; }

        //Order = 13)]
        public virtual string OperID { get; set; }

        //Order = 14)]
        public virtual string Code { get; set; }

        //Order = 15)]
        public virtual short LsCardType { get; set; }

        //Order = 16)]
        public virtual short LsCensus { get; set; }

        //Order = 17)]
        public virtual string IllId { get; set; }

        //Order = 18)]
        public virtual short LsIllBase { get; set; }

        //Order = 19)]
        public virtual DateTime DiagDate { get; set; }

        //Order = 20)]
        public virtual string PathologyType { get; set; }

        //Order = 21)]
        public virtual int FormerlyIllness { get; set; }

        //Order = 22)]
        public virtual DateTime YDiagDate { get; set; }

        //Order = 23)]
        public virtual DateTime DeadDate { get; set; }

        //Order = 24)]
        public virtual string DeadCause { get; set; }

        //Order = 25)]
        public virtual string ICDId { get; set; }

        //Order = 26)]
        public virtual string LocId { get; set; }

        //Order = 27)]
        public virtual int F1 { get; set; }

        //Order = 28)]
        public virtual int F2 { get; set; }

        //Order = 29)]
        public virtual int F3 { get; set; }

        //Order = 30)]
        public virtual int F4 { get; set; }

        //Order = 31)]
        public virtual string MzRegId { get; set; }

        //Order = 32)]
        public virtual string ReciOperId { get; set; }

        //Order = 33)]
        public virtual string ReportUnit { get; set; }

        //Order = 34)]
        public virtual DateTime ReportDate { get; set; }

        //Order = 35)]
        public virtual bool IsAuthed { get; set; }
        #endregion

    }

    #endregion RdCancer

    #region RdInfectStd

    [Serializable]

    public class RdInfectStd:BaseModel
    {
        #region Public Properties

        //er = 10)]
        public virtual string GUID { get; set; }

        //er = 11)]
        public virtual string PatId { get; set; }

        //er = 12)]
        public virtual DateTime OperTime { get; set; }

        //er = 13)]
        public virtual string OperID { get; set; }

        //er = 14)]
        public virtual string Code { get; set; }

        //er = 15)]
        public virtual short LsCardType { get; set; }

        //er = 16)]
        public virtual int Gestation { get; set; }

        //er = 17)]
        public virtual short LsZone { get; set; }

        //er = 18)]
        public virtual short LsCancelType { get; set; }

        //er = 19)]
        public virtual DateTime IllDate { get; set; }

        //er = 20)]
        public virtual DateTime DiagDate { get; set; }

        //er = 21)]
        public virtual DateTime DeadDate { get; set; }

        //er = 22)]
        public virtual string IllId { get; set; }

        //er = 23)]
        public virtual string LsClincSymptom { get; set; }

        //er = 24)]
        public virtual string ReportUnit { get; set; }

        //er = 25)]
        public virtual string IllIdCor { get; set; }

        //er = 26)]
        public virtual string Memo { get; set; }

        //er = 27)]
        public virtual short LsCTrust { get; set; }
        //er = 28)]
        public virtual short LsCTiter { get; set; }
        //er = 29)]
        public virtual short LsCTPPA { get; set; }

        //er = 30)]
        public virtual short LsCOther { get; set; }
        //er = 31)]
        public virtual short LsETrust { get; set; }
        //er = 32)]
        public virtual short LsETiter { get; set; }
        //er = 33)]
        public virtual short LsETPPA { get; set; }

        //er = 34)]
        public virtual short LsEIgM { get; set; }

        //er = 35)]
        public virtual string F1 { get; set; }
        //er = 36)]
        public virtual string F2 { get; set; }
        //er = 37)]
        public virtual string F3 { get; set; }
        //er = 38)]
        public virtual string F4 { get; set; }

        //er = 39)]
        public virtual string JName { get; set; }

        //er = 40)]
        public virtual string LocId { get; set; }
        //er = 41)]
        public virtual string MzRegId { get; set; }
        //er = 42)]
        public virtual string ReciOperId { get; set; }
        //er = 43)]
        public virtual DateTime ReportDate { get; set; }

        //er = 44)]
        public virtual bool IsAuthed { get; set; }
        #endregion



    }

    #endregion RdInfectStd

    [Serializable]
    public class ReportCardWithGoHistroryOut : BaseModel
    {
        public OuHosInfo OuHosInfo { set; get; }
        public BsPatient BsPatient { set; get; }
        public RdBrainDead RdBrainDead { set; get; }
        public RdCancer RdCancer { set; get; }
        public RdInfectious RdInfectious { set; get; }
        public RdInfectStd RdInfectStd { set; get; }

    }

    #region UspRdInfectiousIsWrite

    [Serializable]
    public class UspRdInfectiousIsWrite : BaseModel
    {
        //er = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //er = 2, IsRequired = true)]
        public virtual String Cardno { get; set; }

        //er = 3, IsRequired = true)]
        public virtual String Name { get; set; }

        //er = 4, IsRequired = true)]
        public virtual String MzRegNo { get; set; }

        //er = 5, IsRequired = true)]
        public virtual string OperID { get; set; }

        //er = 6, IsRequired = true)]
        public virtual String Code { get; set; }

        //er = 7, IsRequired = false)]
        public virtual Int32 Iswrite { get; set; }

        //er = 8, IsRequired = false)]
        public virtual DateTime OperTime { get; set; }

        //er = 9, IsRequired = false)]
        public virtual string MzRegId { get; set; }

        //er = 10, IsRequired = false)]
        public virtual string HospId { get; set; }

        //er = 11, IsRequired = true)]
        public virtual String ReportUnit { get; set; }

        //er = 12, IsRequired = true)]
        public virtual String Sex { get; set; }

        //er = 13, IsRequired = true)]
        public virtual String IswriteStart { get; set; }
    }

    #endregion UspRdInfectiousIsWrite




    #region UspInChinDrugIssue
    [Serializable]
    public class UspInChinDrugIssue : BaseModel
    {
        public virtual DateTime OperTime { get; set; }

        public virtual string OperId { get; set; }

        public virtual String Memo { get; set; }

        public virtual Boolean IsPrint { get; set; }

        public virtual Boolean IsBack { get; set; }

        public virtual DateTime ConfirmOperTime { get; set; }

        public virtual string ConfirmOperID { get; set; }

        public virtual int LsCookSelf { get; set; }
        public virtual Boolean IsConfirm { get; set; }

        public virtual int DecoctNum { get; set; }
        public virtual int DrugNum { get; set; }
        public virtual string DoctorId { get; set; }

        public virtual string HospId { get; set; }

        public virtual String RecipeNo { get; set; }

        public virtual String PatientName { get; set; }

        public virtual String InPatNo { get; set; }

        public virtual String BedName { get; set; }

        public virtual String LocationName { get; set; }

        public virtual Boolean IsAuth { get; set; }

        public virtual string LocationId { get; set; }

        public virtual Boolean IsSelected { get; set; }

        public virtual Boolean IsPriority { get; set; }

        public virtual string UsageId { get; set; }

        public virtual string FrequencyId { get; set; }
        #endregion

    }

    [Serializable]
    public class UspCkLabDtlForSampleTree : BaseModel
    {
        public virtual string GUID { get; set; }
        public virtual bool IsAutoCharged { get; set; }
        public virtual String AsId { get; set; }
        public virtual String Code { get; set; }
        public virtual Int32 LsTestType { get; set; }
        public virtual Int32 LsStatus { get; set; }
        public virtual string XDRpId { get; set; }
        public virtual double Totality { get; set; }
        public virtual string TestTypeId { get; set; }
        public virtual String ShortName { get; set; }
        public virtual String Name { get; set; }
        public virtual String OperMemo { get; set; }
        public virtual Int32 LsGroup { get; set; }
        public virtual double Price { get; set; }
        public virtual String Unit { get; set; }
        public virtual String ItemId { get; set; }
        public virtual Boolean IsActive { get; set; }
        public virtual string TestId { get; set; }
        public virtual Int32 totality1 { get; set; }
        public virtual string SourceId { get; set; }
        public virtual string TubeTypeId { get; set; }
        public virtual String TestTypeName { get; set; }
        public virtual String Sourcename { get; set; }
        public virtual String ParentID { get; set; }
        public virtual string LabId { get; set; }
        public virtual string RecipeDtlId { get; set; }
        public virtual string DetailId { get; set; }
        public virtual Int32 LsSource { get; set; }
        public virtual string UseType { get; set; }
        public virtual String AdviceType { get; set; }
        public virtual Int32 lsStatus { get; set; }
        public virtual bool IsTestType { get; set; }//没有现在增加

    }

    #region UspCkMachineSampleBySendStatus
    [Serializable]
    public class UspCkMachineSampleBySendStatus : BaseModel
    {
        public virtual string GUID { get; set; }
        public virtual String LabNum { get; set; }
        public virtual String SampleNum { get; set; }
        public virtual String SendStatus { get; set; }
        public virtual DateTime MatchDate { get; set; }
        public virtual String CardNo { get; set; }
        public virtual String PatientName { get; set; }
        public virtual String MachineName { get; set; }
        public virtual String UserName { get; set; }
        public virtual string LabID { get; set; }
        public virtual string MachineID { get; set; }
        public virtual string UserID { get; set; }
        public virtual string SampleID { get; set; }
        public virtual DateTime RecieveTime { get; set; }
        public virtual string TestTypeId { get; set; }
        public virtual string MzRegId { get; set; }
        public virtual string HospId { get; set; }
        public virtual String LocationName { get; set; }
        public virtual String TestName { get; set; }
    }
    #endregion UspCkMachineSampleBySendStatus
    #region UspCkSendLabList
    [Serializable]
    public class UspCkSendLabList : BaseModel
    {
        public virtual string GUID { get; set; }
        public virtual String CardNo { get; set; }
        public virtual String PatientName { get; set; }
        public virtual String BedNum { get; set; }
        public virtual String TestDesc { get; set; }
        public virtual String LocationName { get; set; }
        public virtual String Priority { get; set; }
        public virtual String LabNum { get; set; }
        public virtual DateTime CollectTime { get; set; }
        public virtual DateTime RecieveTime { get; set; }
        public virtual DateTime ResultTime { get; set; }
        public virtual DateTime AuthTime { get; set; }
        public virtual DateTime ReportTime { get; set; }
        public virtual String RecieveOperName { get; set; }
        public virtual String AuthOperName { get; set; }
        public virtual String ReportOperName { get; set; }
        public virtual String CollectOperName { get; set; }
    }

    #endregion UspCkSendLabList
    #region UspBsUserMenu
    [Serializable]
    public class UspBsUserMenu : BaseModel
    {
        public virtual String GUID { get; set; }
        public virtual String Name { get; set; }
        public virtual String ParentID { get; set; }
        public virtual Int32 IsChecked { get; set; }
        public virtual string MenuId { get; set; }
    }
    #endregion UspBsUserMenu

    [Serializable]
    public class UspGetTmpEmrGroupTree : BaseModel
    {
        public string GUID { get; set; }
        public string ParentID { get; set; }
        public String Name { get; set; }
    }

    [Serializable]
    public class UspGblSetting : BaseModel
    {
        public virtual string GUID { get; set; }
        public virtual String keynum { get; set; }
        public virtual String Explain { get; set; }
        public virtual String Basetable { get; set; }
        public virtual Boolean IsSelect { get; set; }
    }

    [Serializable]
    public class UspGblEmailSelectPersonMessage : BaseModel
    {
        public virtual string GUID { get; set; }
        public virtual String Title { get; set; }
        public virtual String Content { get; set; }
        public virtual String FileName { get; set; }
        public virtual DateTime OperTime { get; set; }
        public virtual string OperId { get; set; }
        public virtual Boolean IsSign { get; set; }
        public virtual Boolean IsPriority { get; set; }
        public virtual Boolean IsFeedback { get; set; }
        public virtual String UserName { get; set; }
        public virtual string EmailUserId { get; set; }
        public virtual Boolean IsRead { get; set; }
    }

    [Serializable]
    public class UspBsBedOnlyFloorNum : BaseModel
    {
        public string GUID { get; set; }
        public Int32 FloorNum { get; set; }
        public String Name { get; set; }
        public String PrintName { get; set; }
        public string LocationId { get; set; }
        public String LocationName { get; set; }
        public Int32 OrderBy { get; set; }
    }

    [Serializable]
    public class UspInSendDrugOutAlert : BaseModel
    {
        public virtual String LocationName { get; set; }

        ////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public virtual string PatID { get; set; }

        ////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public virtual String HospNo { get; set; }

        ////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public virtual String PatientName { get; set; }

        ////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public virtual String IdCardNo { get; set; }

        ////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public virtual String ItemName { get; set; }

        ////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public virtual String Spec { get; set; }

        ////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public virtual double Totality { get; set; }

        ////////////////////////////[DataMemberr(Order = 10, IsRequired = false)]
        public virtual Boolean Refusal { get; set; }

        ////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public virtual String UnitReq { get; set; }

        ////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public virtual double Dosage { get; set; }

        ////////////////////////////[DataMemberr(Order = 13, IsRequired = false)]
        public virtual string BedId { get; set; }

        ////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public virtual Boolean IsPrint { get; set; }

        ////////////////////////////[DataMemberr(Order = 15, IsRequired = false)]
        public virtual double PriceIn { get; set; }

        ////////////////////////////[DataMemberr(Order = 16, IsRequired = false)]
        public virtual double Amount { get; set; }

        ////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public virtual Int32 LsMarkType { get; set; }

        ////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public virtual string LocationId { get; set; }

        ////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public virtual String ItemCode { get; set; }

        ////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public virtual DateTime ForDate { get; set; }

        ////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public virtual String RequestNo { get; set; }

        ////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public virtual string RoomId { get; set; }

        ////////////////////////////[DataMemberr(Order = 23, IsRequired = false)]
        public virtual double Times { get; set; }

        ////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public virtual string HospId { get; set; }

        ////////////////////////////[DataMemberr(Order = 25, IsRequired = false)]
        public virtual DateTime OperTime { get; set; }

        ////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public virtual String UnitReqName { get; set; }

        ////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public virtual string RequestId { get; set; }

        ////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public virtual string ItemId { get; set; }

        ////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public virtual Boolean IsIssued { get; set; }

        ////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public virtual Int32 ListNum { get; set; }

        ////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public virtual string AdviceId { get; set; }

        ////////////////////////////[DataMemberr(Order = 32, IsRequired = false)]
        public virtual string UnitTake { get; set; }

        ////////////////////////////[DataMemberr(Order = 33, IsRequired = true)]
        public virtual Boolean IsConfirm { get; set; }

        ////////////////////////////[DataMemberr(Order = 34, IsRequired = false)]
        public virtual string ConfirmOperId { get; set; }

        ////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public virtual String ConfirmOperTime { get; set; }

        ////////////////////////////[DataMemberr(Order = 36, IsRequired = false)]
        public virtual string DetailId { get; set; }

        ////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public virtual string UsageId { get; set; }

        ////////////////////////////[DataMemberr(Order = 38, IsRequired = false)]
        public virtual string FrequencyId { get; set; }

        ////////////////////////////[DataMemberr(Order = 39, IsRequired = true)]
        public virtual Int32 GroupNum { get; set; }

        ////////////////////////////[DataMemberr(Order = 40, IsRequired = false)]
        public virtual string ExecuteId { get; set; }

        ////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public virtual String FrequencyName { get; set; }

        ////////////////////////////[DataMemberr(Order = 42, IsRequired = false)]
        public virtual Boolean GroupId { get; set; }

        ////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public virtual Boolean IsPoison { get; set; }

        ////////////////////////////[DataMemberr(Order = 44, IsRequired = false)]
        public virtual Boolean IsMental { get; set; }

        ////////////////////////////[DataMemberr(Order = 45, IsRequired = false)]
        public virtual Boolean IsExpen { get; set; }

        ////////////////////////////[DataMemberr(Order = 46, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        ////////////////////////////[DataMemberr(Order = 47, IsRequired = true)]
        public virtual String UnitTakeName { get; set; }

        ////////////////////////////[DataMemberr(Order = 48, IsRequired = false)]
        public virtual Boolean IsAttach { get; set; }

        ////////////////////////////[DataMemberr(Order = 49, IsRequired = true)]
        public virtual String UsageName { get; set; }

        ////////////////////////////[DataMemberr(Order = 50, IsRequired = false)]
        public virtual string OperID { get; set; }

        ////////////////////////////[DataMemberr(Order = 51, IsRequired = false)]
        public virtual Int32 age { get; set; }

        ////////////////////////////[DataMemberr(Order = 52, IsRequired = true)]
        public virtual String AgeString { get; set; }

        ////////////////////////////[DataMemberr(Order = 53, IsRequired = true)]
        public virtual String BedName { get; set; }

        ////////////////////////////[DataMemberr(Order = 54, IsRequired = true)]
        public virtual string PatTypeId { get; set; }

        ////////////////////////////[DataMemberr(Order = 55, IsRequired = true)]
        public virtual String Sex { get; set; }

        ////////////////////////////[DataMemberr(Order = 56, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        ////////////////////////////[DataMemberr(Order = 57, IsRequired = true)]
        public virtual String GroupName { get; set; }

        ////////////////////////////[DataMemberr(Order = 58, IsRequired = true)]
        public virtual String Memo { get; set; }

        ////////////////////////////[DataMemberr(Order = 59, IsRequired = true)]
        public virtual String GroupTitle { get; set; }

        ////////////////////////////[DataMemberr(Order = 60, IsRequired = false)]
        public virtual Int32 OrderBy { get; set; }

        ////////////////////////////[DataMemberr(Order = 61, IsRequired = false)]
        public virtual Int32 FirstDay { get; set; }

        ////////////////////////////[DataMemberr(Order = 62, IsRequired = true)]
        public virtual String UsageMemo { get; set; }

        ////////////////////////////[DataMemberr(Order = 63, IsRequired = false)]
        public virtual Int32 LsSecMarkType { get; set; }

        ////////////////////////////[DataMemberr(Order = 64, IsRequired = true)]
        public virtual String LocationOrderby { get; set; }

        ////////////////////////////[DataMemberr(Order = 65, IsRequired = true)]
        public virtual String AdviceMemo { get; set; }
    }

    [Serializable]
    public class UspInDrugIssueNotConfirm : BaseModel
    {
        ////////////////////////////////////[DataMember(Order = 1, IsRequired = false)]
        public virtual string GUID { get; set; }

        ////////////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String RequestNo { get; set; }

        ////////////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String LocationName { get; set; }

        ////////////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String RequestMan { get; set; }

        ////////////////////////////////////[DataMember(Order = 5, IsRequired = false)]
        public virtual DateTime ConfirmDate { get; set; }

        ////////////////////////////////////[DataMember(Order = 6, IsRequired = false)]
        public virtual string OperID { get; set; }

        ////////////////////////////////////[DataMember(Order = 7, IsRequired = false)]
        public virtual string RoomId { get; set; }

        ////////////////////////////////////[DataMember(Order = 8, IsRequired = false)]
        public virtual string LocationId { get; set; }

        ////////////////////////////////////[DataMember(Order = 9, IsRequired = false)]
        public virtual DateTime OperTime { get; set; }

        ////////////////////////////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual Int32 LsSendStatus { get; set; }

        ////////////////////////////////////[DataMember(Order = 11, IsRequired = false)]
        public virtual Boolean IsPrint { get; set; }

        ////////////////////////////////////[DataMember(Order = 12, IsRequired = false)]
        public virtual string ConfirmOperID { get; set; }

        ////////////////////////////////////[DataMember(Order = 13, IsRequired = false)]
        public virtual Boolean IsAllLocation { get; set; }

        ////////////////////////////////////[DataMember(Order = 14, IsRequired = false)]
        public virtual Boolean IsUrgent { get; set; }

        ////////////////////////////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual String OutDrug { get; set; }
    }

    [Serializable]
    public class UspInDrugIssueAll : BaseModel
    {
        //////////////////////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String RequestNo { get; set; }

        //////////////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //////////////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String RequestMan { get; set; }

        //////////////////////////////////////[DataMember(Order = 5, IsRequired = false)]
        public virtual DateTime ConfirmDate { get; set; }

        //////////////////////////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual string OperID { get; set; }

        //////////////////////////////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual string RoomId { get; set; }

        //////////////////////////////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual string LocationId { get; set; }

        //////////////////////////////////////[DataMember(Order = 9, IsRequired = false)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////////////[DataMember(Order = 10, IsRequired = true)]
        public virtual Int32 LsSendStatus { get; set; }

        //////////////////////////////////////[DataMember(Order = 11, IsRequired = true)]
        public virtual Boolean IsPrint { get; set; }

        //////////////////////////////////////[DataMember(Order = 12, IsRequired = false)]
        public virtual string ConfirmOperID { get; set; }
    }


    [Serializable]
    public class UspInDrugIssueConfirm : BaseModel
    {
        //////////////////////////////////[DataMember(Order = 1, IsRequired = false)]
        public virtual string GUID { get; set; }

        //////////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String RequestNo { get; set; }

        //////////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //////////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String RequestMan { get; set; }

        //////////////////////////////////[DataMember(Order = 5, IsRequired = false)]
        public virtual DateTime ConfirmDate { get; set; }

        //////////////////////////////////[DataMember(Order = 6, IsRequired = false)]
        public virtual string OperID { get; set; }

        //////////////////////////////////[DataMember(Order = 7, IsRequired = false)]
        public virtual string RoomId { get; set; }

        //////////////////////////////////[DataMember(Order = 8, IsRequired = false)]
        public virtual string LocationId { get; set; }

        //////////////////////////////////[DataMember(Order = 9, IsRequired = false)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual Int32 LsSendStatus { get; set; }

        //////////////////////////////////[DataMember(Order = 11, IsRequired = false)]
        public virtual Boolean IsPrint { get; set; }

        //////////////////////////////////[DataMember(Order = 12, IsRequired = false)]
        public virtual string ConfirmOperID { get; set; }

        //////////////////////////////////[DataMember(Order = 13, IsRequired = false)]
        public virtual Boolean IsAllLocation { get; set; }

        //////////////////////////////////[DataMember(Order = 14, IsRequired = false)]
        public virtual Boolean IsUrgent { get; set; }

        //////////////////////////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual String OutDrug { get; set; }
    }

    [Serializable]
    public class UspRmInDrugBackDtlSum : BaseModel
    {
        ////////////////////////////////[DataMember(Order = 1, IsRequired = false)]
        public virtual string GUID { get; set; }

        ////////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String Name { get; set; }

        ////////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String ItemCode { get; set; }

        ////////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String Spec { get; set; }

        ////////////////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual String UnitReqName { get; set; }

        ////////////////////////////////[DataMember(Order = 6, IsRequired = false)]
        public virtual double PriceIn { get; set; }

        ////////////////////////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual String LocationName { get; set; }

        ////////////////////////////////[DataMember(Order = 8, IsRequired = false)]
        public virtual double Amount { get; set; }

        ////////////////////////////////[DataMember(Order = 9, IsRequired = false)]
        public virtual double Totality { get; set; }
    }

    [Serializable]
    public class UspInSendDrugLocationTotal : BaseModel
    {
        //////////////////////////////[DataMember(Order = 1, IsRequired = false)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //////////////////////////////[DataMember(Order = 3, IsRequired = false)]
        public virtual string PatID { get; set; }

        //////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String HospNo { get; set; }

        //////////////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual String PatientName { get; set; }

        //////////////////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String IdCardNo { get; set; }

        //////////////////////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual String ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual String Spec { get; set; }

        //////////////////////////////[DataMember(Order = 9, IsRequired = false)]
        public virtual double Totality { get; set; }

        //////////////////////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual String UnitReq { get; set; }

        //////////////////////////////[DataMember(Order = 11, IsRequired = false)]
        public virtual double Dosage { get; set; }

        //////////////////////////////[DataMember(Order = 12, IsRequired = false)]
        public virtual string BedId { get; set; }

        //////////////////////////////[DataMember(Order = 13, IsRequired = false)]
        public virtual Boolean IsPrint { get; set; }

        //////////////////////////////[DataMember(Order = 14, IsRequired = false)]
        public virtual double PriceIn { get; set; }

        //////////////////////////////[DataMember(Order = 15, IsRequired = false)]
        public virtual double Amount { get; set; }

        //////////////////////////////[DataMember(Order = 16, IsRequired = false)]
        public virtual Int32 LsMarkType { get; set; }

        //////////////////////////////[DataMember(Order = 17, IsRequired = false)]
        public virtual string LocationId { get; set; }

        //////////////////////////////[DataMember(Order = 18, IsRequired = true)]
        public virtual String ItemCode { get; set; }

        //////////////////////////////[DataMember(Order = 19, IsRequired = false)]
        public virtual DateTime ForDate { get; set; }

        //////////////////////////////[DataMember(Order = 20, IsRequired = true)]
        public virtual String RequestNo { get; set; }

        //////////////////////////////[DataMember(Order = 21, IsRequired = false)]
        public virtual string RoomId { get; set; }

        //////////////////////////////[DataMember(Order = 22, IsRequired = false)]
        public virtual double Times { get; set; }

        //////////////////////////////[DataMember(Order = 23, IsRequired = false)]
        public virtual string HospId { get; set; }

        //////////////////////////////[DataMember(Order = 24, IsRequired = false)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////[DataMember(Order = 25, IsRequired = true)]
        public virtual String UnitReqName { get; set; }

        //////////////////////////////[DataMember(Order = 26, IsRequired = false)]
        public virtual string RequestId { get; set; }

        //////////////////////////////[DataMember(Order = 27, IsRequired = false)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 28, IsRequired = false)]
        public virtual Boolean IsIssued { get; set; }

        //////////////////////////////[DataMember(Order = 29, IsRequired = false)]
        public virtual Int32 ListNum { get; set; }

        //////////////////////////////[DataMember(Order = 30, IsRequired = false)]
        public virtual string AdviceId { get; set; }

        //////////////////////////////[DataMember(Order = 31, IsRequired = false)]
        public virtual string UnitTake { get; set; }

        //////////////////////////////[DataMember(Order = 32, IsRequired = false)]
        public virtual Boolean IsConfirm { get; set; }

        //////////////////////////////[DataMember(Order = 33, IsRequired = false)]
        public virtual string ConfirmOperId { get; set; }

        //////////////////////////////[DataMember(Order = 34, IsRequired = true)]
        public virtual String ConfirmOperTime { get; set; }

        //////////////////////////////[DataMember(Order = 35, IsRequired = false)]
        public virtual string DetailId { get; set; }

        //////////////////////////////[DataMember(Order = 36, IsRequired = false)]
        public virtual string UsageId { get; set; }

        //////////////////////////////[DataMember(Order = 37, IsRequired = false)]
        public virtual string FrequencyId { get; set; }

        //////////////////////////////[DataMember(Order = 38, IsRequired = false)]
        public virtual Int32 GroupNum { get; set; }

        //////////////////////////////[DataMember(Order = 39, IsRequired = false)]
        public virtual string ExecuteId { get; set; }

        //////////////////////////////[DataMember(Order = 40, IsRequired = true)]
        public virtual String FrequencyName { get; set; }

        //////////////////////////////[DataMember(Order = 41, IsRequired = false)]
        public virtual Boolean GroupId { get; set; }

        //////////////////////////////[DataMember(Order = 42, IsRequired = false)]
        public virtual Boolean IsPoison { get; set; }

        //////////////////////////////[DataMember(Order = 43, IsRequired = false)]
        public virtual Boolean IsMental { get; set; }

        //////////////////////////////[DataMember(Order = 44, IsRequired = false)]
        public virtual Boolean IsExpen { get; set; }

        //////////////////////////////[DataMember(Order = 45, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        //////////////////////////////[DataMember(Order = 46, IsRequired = true)]
        public virtual String UnitTakeName { get; set; }

        //////////////////////////////[DataMember(Order = 47, IsRequired = true)]
        public virtual String UsageName { get; set; }

        //////////////////////////////[DataMember(Order = 48, IsRequired = false)]
        public virtual string OperID { get; set; }

        //////////////////////////////[DataMember(Order = 49, IsRequired = false)]
        public virtual Int32 age { get; set; }

        //////////////////////////////[DataMember(Order = 50, IsRequired = false)]
        public virtual Boolean IsAttach { get; set; }

        //////////////////////////////[DataMember(Order = 51, IsRequired = false)]
        public virtual string Expr1 { get; set; }

        //////////////////////////////[DataMember(Order = 52, IsRequired = true)]
        public virtual String BedName { get; set; }

        //////////////////////////////[DataMember(Order = 53, IsRequired = false)]
        public virtual string PatTypeId { get; set; }

        //////////////////////////////[DataMember(Order = 54, IsRequired = false)]
        public virtual Int32 age1 { get; set; }

        //////////////////////////////[DataMember(Order = 55, IsRequired = false)]
        public virtual string BedId1 { get; set; }

        //////////////////////////////[DataMember(Order = 56, IsRequired = true)]
        public virtual String BedName1 { get; set; }

        //////////////////////////////[DataMember(Order = 57, IsRequired = false)]
        public virtual string PatTypeId1 { get; set; }

        //////////////////////////////[DataMember(Order = 58, IsRequired = true)]
        public virtual String Sex { get; set; }

        //////////////////////////////[DataMember(Order = 59, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        //////////////////////////////[DataMember(Order = 60, IsRequired = true)]
        public virtual String AgeString { get; set; }

        //////////////////////////////[DataMember(Order = 61, IsRequired = true)]
        public virtual String GroupName { get; set; }

        //////////////////////////////[DataMember(Order = 62, IsRequired = true)]
        public virtual String Memo { get; set; }

        //////////////////////////////[DataMember(Order = 63, IsRequired = true)]
        public virtual String GroupTitle { get; set; }

        //////////////////////////////[DataMember(Order = 64, IsRequired = false)]
        public virtual Int32 OrderBy { get; set; }

        //////////////////////////////[DataMember(Order = 65, IsRequired = false)]
        public virtual Int32 FirstDay { get; set; }
    }
    [Serializable]
    public class UspGetOuDoctorNumPlan : BaseModel
    {
        //////////////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String MzRegNo { get; set; }

        //////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual DateTime RegTime { get; set; }

        //////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String CardNo { get; set; }

        //////////////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual String Name { get; set; }

        //////////////////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String Sex { get; set; }

        //////////////////////////////[DataMember(Order = 7, IsRequired = false)]
        public virtual string DiagnDept { get; set; }

        //////////////////////////////[DataMember(Order = 8, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        //////////////////////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual String RoomNo { get; set; }

        //////////////////////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual string TimeSpanId { get; set; }

        //////////////////////////////[DataMember(Order = 11, IsRequired = true)]
        public virtual Int32 LineOrder { get; set; }

        //////////////////////////////[DataMember(Order = 12, IsRequired = false)]
        public virtual string timeSpanSubId { get; set; }
    }

    [Serializable]
    public class AccountingWithCreatNewInfo : BaseModel
    {
        public OulInvoiceReg OulInvoiceReg { get; set; }

        public OuHosInfo OuHosInfo { get; set; }
        public string LastMzRegId { get; set; }
    }


    #region UspOuRegInvoNoIsCancel

    [Serializable]
    public class UspOuRegInvoNoIsCancel : BaseModel
    {
        //////////////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String InvoNo { get; set; }

        //////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String Name { get; set; }

        //////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String MzRegNo { get; set; }

        //////////////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //////////////////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        //////////////////////////////[DataMember(Order = 7, IsRequired = false)]
        public virtual double RegFee { get; set; }
        //////////////////////////////[DataMember(Order = 8, IsRequired = false)]
        public virtual double DiagnoFee { get; set; }
        //////////////////////////////[DataMember(Order = 9, IsRequired = false)]
        public virtual double ZyFee { get; set; }
        //////////////////////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual double OtherFee1 { get; set; }
        //////////////////////////////[DataMember(Order = 11, IsRequired = false)]
        public virtual double OtherFee2 { get; set; }
        //////////////////////////////[DataMember(Order = 12, IsRequired = false)]
        public virtual double FactPay { get; set; }
        //////////////////////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual DateTime RegTime { get; set; }

        //////////////////////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual String PatTypeName { get; set; }

        //////////////////////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual String OperCode { get; set; }

        //////////////////////////////[DataMember(Order = 16, IsRequired = true)]
        public virtual String MedicareNo { get; set; }

        //////////////////////////////[DataMember(Order = 17, IsRequired = true)]
        public virtual Int32 LineOrder { get; set; }

        //////////////////////////////[DataMember(Order = 18, IsRequired = true)]
        public virtual String Sex { get; set; }

        //////////////////////////////[DataMember(Order = 19, IsRequired = true)]
        public virtual String RegtypeName { get; set; }
    }

    #endregion UspOuRegInvoNoIsCancel

    [Serializable]
    public class UspOuRecipeInDrugSendNum : BaseModel
    {
        public virtual double StockNum { get; set; }
    }

    #region UspGetGoodRecipeValue

    [Serializable]
    public class UspGetGoodRecipeValue : BaseModel
    {

        public virtual String ColumnName { get; set; }
    }

    #endregion UspGetGoodRecipeValue


    #region UspBsItem

    [Serializable]
    public class UspBsItem : BaseModel
    {
        public Boolean IsAnaes { get; set; }
        //////////////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual int LsGroupType { get; set; }

        //////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String Code { get; set; }

        //////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String Name { get; set; }

        //////////////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual String LongDesc { get; set; }

        //////////////////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String EngDesc { get; set; }

        //////////////////////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual String WbCode { get; set; }

        //////////////////////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual String PyCode { get; set; }

        //////////////////////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual String StrokeCode { get; set; }

        //////////////////////////////[DataMember(Order = 10, IsRequired = true)]
        public virtual String OtherCode { get; set; }

        //////////////////////////////[DataMember(Order = 11, IsRequired = true)]
        public virtual string GroupMainId { get; set; }

        //////////////////////////////[DataMember(Order = 12, IsRequired = true)]
        public virtual String GroupName { get; set; }

        //////////////////////////////[DataMember(Order = 13, IsRequired = false)]
        public virtual string GroupSubId { get; set; }

        //////////////////////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual String GroupSubName { get; set; }

        //////////////////////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual String Spec { get; set; }

        //////////////////////////////[DataMember(Order = 16, IsRequired = false)]
        public virtual string UnitInId { get; set; }

        //////////////////////////////[DataMember(Order = 17, IsRequired = true)]
        public virtual String UnitInName { get; set; }

        //////////////////////////////[DataMember(Order = 18, IsRequired = false)]

        public virtual double PriceIn { get; set; }
        //////////////////////////////[DataMember(Order = 19, IsRequired = false)]
        public virtual string UnitDiagId { get; set; }

        //////////////////////////////[DataMember(Order = 20, IsRequired = true)]
        public virtual String UnitDiagName { get; set; }

        //////////////////////////////[DataMember(Order = 21, IsRequired = false)]
        public virtual double PriceDiag { get; set; }
        //////////////////////////////[DataMember(Order = 22, IsRequired = false)]
        public virtual double AddPercent { get; set; }
        //////////////////////////////[DataMember(Order = 23, IsRequired = false)]
        public virtual int LsRpType { get; set; }

        //////////////////////////////[DataMember(Order = 24, IsRequired = false)]
        public virtual double Dosage { get; set; }
        //////////////////////////////[DataMember(Order = 25, IsRequired = false)]
        public virtual string UnitTakeId { get; set; }

        //////////////////////////////[DataMember(Order = 26, IsRequired = true)]
        public virtual String UnitTakeName { get; set; }

        //////////////////////////////[DataMember(Order = 27, IsRequired = false)]
        public virtual string FrequencyId { get; set; }

        //////////////////////////////[DataMember(Order = 28, IsRequired = true)]
        public virtual String FrequencyName { get; set; }

        //////////////////////////////[DataMember(Order = 29, IsRequired = false)]
        public virtual string UsageId { get; set; }

        //////////////////////////////[DataMember(Order = 30, IsRequired = true)]
        public virtual string FeeMzId { get; set; }

        //////////////////////////////[DataMember(Order = 31, IsRequired = true)]
        public virtual String FeeMzName { get; set; }

        //////////////////////////////[DataMember(Order = 32, IsRequired = true)]
        public virtual string FeeZyId { get; set; }

        //////////////////////////////[DataMember(Order = 33, IsRequired = false)]
        public virtual int MzUnitTotal { get; set; }

        //////////////////////////////[DataMember(Order = 34, IsRequired = true)]
        public virtual String FeeZyName { get; set; }

        //////////////////////////////[DataMember(Order = 35, IsRequired = false)]
        public virtual int LsGfType { get; set; }

        //////////////////////////////[DataMember(Order = 36, IsRequired = false)]
        public virtual double GfFixDisc { get; set; }
        //////////////////////////////[DataMember(Order = 37, IsRequired = false)]
        public virtual Boolean? OptionPrice { get; set; }

        //////////////////////////////[DataMember(Order = 38, IsRequired = false)]
        public virtual double LimitTotalMz { get; set; }
        //////////////////////////////[DataMember(Order = 39, IsRequired = false)]
        public virtual double? LimitTotalZy { get; set; }

        //////////////////////////////[DataMember(Order = 40, IsRequired = false)]
        public virtual string TypeGFXEId { get; set; }

        //////////////////////////////[DataMember(Order = 41, IsRequired = true)]
        public virtual String TypeGFXEName { get; set; }

        //////////////////////////////[DataMember(Order = 42, IsRequired = true)]
        public virtual Boolean IsSpecSum { get; set; }

        //////////////////////////////[DataMember(Order = 43, IsRequired = true)]
        public virtual Boolean IsNew { get; set; }

        //////////////////////////////[DataMember(Order = 44, IsRequired = true)]
        public virtual Boolean IsOnlyForSys { get; set; }

        //////////////////////////////[DataMember(Order = 45, IsRequired = true)]
        public virtual Boolean IsRpForbid { get; set; }

        //////////////////////////////[DataMember(Order = 46, IsRequired = true)]
        public virtual Boolean IsChildAdd { get; set; }

        //////////////////////////////[DataMember(Order = 47, IsRequired = true)]
        public virtual Boolean IsBedFee { get; set; }

        //////////////////////////////[DataMember(Order = 48, IsRequired = true)]
        public virtual Boolean IsOpsAdd { get; set; }

        //////////////////////////////[DataMember(Order = 49, IsRequired = false)]
        public virtual int LsfeeTurn { get; set; }

        //////////////////////////////[DataMember(Order = 50, IsRequired = false)]
        public virtual int LsAdviceType { get; set; }

        //////////////////////////////[DataMember(Order = 51, IsRequired = false)]
        public virtual string ExecLocId { get; set; }

        //////////////////////////////[DataMember(Order = 52, IsRequired = true)]
        public virtual String ExecLocName { get; set; }

        //////////////////////////////[DataMember(Order = 53, IsRequired = false)]
        public virtual string LISCode { get; set; }

        //////////////////////////////[DataMember(Order = 54, IsRequired = true)]
        public virtual String Memo { get; set; }

        //////////////////////////////[DataMember(Order = 55, IsRequired = false)]
        public virtual Boolean IsActive { get; set; }

        //////////////////////////////[DataMember(Order = 56, IsRequired = true)]
        public virtual String ChemName { get; set; }

        //////////////////////////////[DataMember(Order = 57, IsRequired = false)]
        public virtual Boolean IsRecipe { get; set; }

        //////////////////////////////[DataMember(Order = 58, IsRequired = false)]
        public virtual Boolean IsPoison { get; set; }

        //////////////////////////////[DataMember(Order = 59, IsRequired = false)]
        public virtual Boolean IsMental { get; set; }

        //////////////////////////////[DataMember(Order = 60, IsRequired = false)]
        public virtual Boolean IsExpen { get; set; }

        //////////////////////////////[DataMember(Order = 61, IsRequired = false)]
        public virtual Boolean IsSelf { get; set; }

        //////////////////////////////[DataMember(Order = 62, IsRequired = false)]
        public virtual int ProArea { get; set; }

        //////////////////////////////[DataMember(Order = 63, IsRequired = false)]
        public virtual int AheadAlert { get; set; }

        //////////////////////////////[DataMember(Order = 64, IsRequired = false)]
        public virtual double UnderLineKc { get; set; }
        //////////////////////////////[DataMember(Order = 65, IsRequired = false)]
        public virtual double UperLineKc { get; set; }
        //////////////////////////////[DataMember(Order = 66, IsRequired = false)]
        public virtual double NormalLineKc { get; set; }
        //////////////////////////////[DataMember(Order = 67, IsRequired = false)]
        public virtual string FormId { get; set; }

        //////////////////////////////[DataMember(Order = 68, IsRequired = true)]
        public virtual String DrugFormName { get; set; }

        //////////////////////////////[DataMember(Order = 69, IsRequired = false)]
        public virtual string ManuId { get; set; }

        //////////////////////////////[DataMember(Order = 70, IsRequired = true)]
        public virtual String ManufacturerName { get; set; }

        //////////////////////////////[DataMember(Order = 71, IsRequired = true)]
        public virtual String PassNo { get; set; }

        //////////////////////////////[DataMember(Order = 72, IsRequired = true)]
        public virtual String AreaKc { get; set; }

        //////////////////////////////[DataMember(Order = 73, IsRequired = false)]
        public virtual int LsImport { get; set; }

        //////////////////////////////[DataMember(Order = 74, IsRequired = false)]
        public virtual Boolean? IsInject { get; set; }

        //////////////////////////////[DataMember(Order = 75, IsRequired = false)]
        public virtual Boolean? IsSpecial { get; set; }

        //////////////////////////////[DataMember(Order = 76, IsRequired = false)]
        public virtual string HouseId { get; set; }

        //////////////////////////////[DataMember(Order = 77, IsRequired = true)]
        public virtual String HouseName { get; set; }

        //////////////////////////////[DataMember(Order = 78, IsRequired = false)]
        public virtual string RoomIdOut { get; set; }

        //////////////////////////////[DataMember(Order = 79, IsRequired = true)]
        public virtual String RoomNameOut { get; set; }

        //////////////////////////////[DataMember(Order = 80, IsRequired = false)]
        public virtual string RoomIdIn { get; set; }

        //////////////////////////////[DataMember(Order = 81, IsRequired = true)]
        public virtual String RoomInOut { get; set; }

        //////////////////////////////[DataMember(Order = 82, IsRequired = false)]
        public virtual string UnitKc { get; set; }

        //////////////////////////////[DataMember(Order = 83, IsRequired = false)]
        public virtual double RetailPriceKc { get; set; }
        //////////////////////////////[DataMember(Order = 84, IsRequired = false)]
        public virtual double StockPriceKc { get; set; }
        //////////////////////////////[DataMember(Order = 85, IsRequired = false)]
        public virtual Boolean? IsBid { get; set; }

        //////////////////////////////[DataMember(Order = 86, IsRequired = false)]
        public virtual Boolean? IsLocDrug { get; set; }

        //////////////////////////////[DataMember(Order = 87, IsRequired = false)]
        public virtual string CompId { get; set; }

        //////////////////////////////[DataMember(Order = 88, IsRequired = true)]
        public virtual String CompanyName { get; set; }

        //////////////////////////////[DataMember(Order = 89, IsRequired = false)]
        public virtual Boolean? IsBatch { get; set; }

        //////////////////////////////[DataMember(Order = 90, IsRequired = false)]
        public virtual Boolean? IsSave { get; set; }

        //////////////////////////////[DataMember(Order = 91, IsRequired = false)]
        public virtual string PatTypeId { get; set; }

        //////////////////////////////[DataMember(Order = 92, IsRequired = true)]
        public virtual String PatTypeName { get; set; }

        //////////////////////////////[DataMember(Order = 93, IsRequired = false)]
        public virtual double DiscDiag { get; set; }
        //////////////////////////////[DataMember(Order = 94, IsRequired = false)]
        public virtual double DiscIn { get; set; }
        //////////////////////////////[DataMember(Order = 95, IsRequired = false)]
        public virtual string InvInItemId { get; set; }

        //////////////////////////////[DataMember(Order = 96, IsRequired = true)]
        public virtual String InvInItemName { get; set; }

        //////////////////////////////[DataMember(Order = 97, IsRequired = false)]
        public virtual string InvMzItemId { get; set; }

        //////////////////////////////[DataMember(Order = 98, IsRequired = true)]
        public virtual String InvMzItemName { get; set; }

        //////////////////////////////[DataMember(Order = 99, IsRequired = false)]
        public virtual string LimitGroupId { get; set; }

        //////////////////////////////[DataMember(Order = 100, IsRequired = true)]
        public virtual String ZyGroupName { get; set; }

        //////////////////////////////[DataMember(Order = 101, IsRequired = false)]
        public virtual double LimitFeeMz { get; set; }
        //////////////////////////////[DataMember(Order = 102, IsRequired = false)]
        public virtual double LimitFeeZy { get; set; }
        //////////////////////////////[DataMember(Order = 103, IsRequired = false)]
        public virtual string LocationId { get; set; }

        //////////////////////////////[DataMember(Order = 104, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //////////////////////////////[DataMember(Order = 105, IsRequired = false)]
        public virtual string FeeHsMzId { get; set; }

        //////////////////////////////[DataMember(Order = 106, IsRequired = false)]
        public virtual string FeeHsZyId { get; set; }

        //////////////////////////////[DataMember(Order = 107, IsRequired = true)]
        public virtual String FeeHsZyName { get; set; }

        //////////////////////////////[DataMember(Order = 108, IsRequired = true)]
        public virtual String FeeHsMzName { get; set; }

        //////////////////////////////[DataMember(Order = 109, IsRequired = false)]
        public virtual double LocationDosage { get; set; }
        //////////////////////////////[DataMember(Order = 110, IsRequired = false)]
        public virtual string LocationUnitTakeId { get; set; }

        //////////////////////////////[DataMember(Order = 111, IsRequired = true)]
        public virtual String LocationUnitTakeName { get; set; }

        //////////////////////////////[DataMember(Order = 112, IsRequired = false)]
        public virtual string LocationFrequencyId { get; set; }

        //////////////////////////////[DataMember(Order = 113, IsRequired = true)]
        public virtual String LocationFrequencyName { get; set; }

        //////////////////////////////[DataMember(Order = 114, IsRequired = false)]
        public virtual string LocationUsageId { get; set; }

        //////////////////////////////[DataMember(Order = 115, IsRequired = true)]
        public virtual String LocationUsageName { get; set; }

        //////////////////////////////[DataMember(Order = 116, IsRequired = true)]
        public virtual String UsageName { get; set; }

        //////////////////////////////[DataMember(Order = 117, IsRequired = true)]
        public virtual String UnitKcName { get; set; }

        //////////////////////////////[DataMember(Order = 118, IsRequired = true)]
        public virtual String TallyGroupName { get; set; }

        //////////////////////////////[DataMember(Order = 119, IsRequired = false)]
        public virtual Boolean? LocationIsLocDrug { get; set; }

        //////////////////////////////[DataMember(Order = 120, IsRequired = false)]
        public virtual string TallyTypeId { get; set; }

        //////////////////////////////[DataMember(Order = 121, IsRequired = false)]
        public virtual string TallyGroupId { get; set; }

        //////////////////////////////[DataMember(Order = 122, IsRequired = false)]
        public virtual int IconIndex { get; set; }

        //////////////////////////////[DataMember(Order = 123, IsRequired = false)]
        public virtual Boolean? IsInoculate { get; set; }

        //////////////////////////////[DataMember(Order = 124, IsRequired = true)]
        public virtual String ProvinceCode { get; set; }

        //////////////////////////////[DataMember(Order = 125, IsRequired = true)]
        public virtual String OperName { get; set; }

        //////////////////////////////[DataMember(Order = 126, IsRequired = false)]
        public virtual int OrderBy { get; set; }

        //////////////////////////////[DataMember(Order = 127, IsRequired = false)]
        public virtual string DrugID { get; set; }

        //////////////////////////////[DataMember(Order = 128, IsRequired = true)]
        public virtual String style { get; set; }

        //////////////////////////////[DataMember(Order = 129, IsRequired = true)]
        public virtual String BasalDrugType { get; set; }
    }

    #endregion UspBsItem

    [Serializable]
    public class UspCwjzDtl : BaseModel
    {
        public virtual String OperName { get; set; }

        public virtual String LsOutIn { get; set; }

        public virtual Int32 BillNo { get; set; }

        public virtual DateTime Opertime { get; set; }

        public virtual Int32 bills { get; set; }

        public virtual Int32 billcancel { get; set; }

        public virtual double AmountSum { get; set; }

        public virtual double Amount { get; set; }

        public virtual double AmountCancel { get; set; }

        public virtual double Insurance { get; set; }

        public virtual double AmountPay { get; set; }

        public virtual double AmountYF { get; set; }

        public virtual Int32 IsSign { get; set; }

        public virtual String SignName { get; set; }

        public virtual DateTime SignTime { get; set; }

        public virtual string OperId { get; set; }
    }

    [Serializable]
    public class UspInEmrDoctor : BaseModel
    {
        public virtual String InPatNo { get; set; }

        public virtual String Name { get; set; }

        public virtual DateTime InTime { get; set; }

        public virtual string CatalogId { get; set; }

        public virtual String EmrName { get; set; }
        public virtual DateTime? OperTime { get; set; }

        public virtual String RecDoctor { get; set; }

        public virtual String AuthDoctor { get; set; }

        public virtual String BedName { get; set; }

        public virtual string HospId { get; set; }

        public virtual String RecNo { get; set; }

        public virtual String AuthStatus { get; set; }

        public virtual String PatStatus { get; set; }

        public virtual String LocationName { get; set; }
        public virtual DateTime? Outtime { get; set; }
    }

    [Serializable]
    public class UspInEmrSign : BaseModel
    {
        public virtual String InPatNo { get; set; }

        public virtual String Name { get; set; }

        public virtual DateTime InTime { get; set; }

        public virtual string CatalogId { get; set; }

        public virtual String EmrName { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual String RecDoctor { get; set; }

        public virtual String AuthDoctor { get; set; }

        public virtual String BedName { get; set; }

        public virtual string HospId { get; set; }

        public virtual String RecNo { get; set; }

        public virtual String AuthStatus { get; set; }

        public virtual String PatStatus { get; set; }

        public virtual String LocationName { get; set; }

        public virtual DateTime OutTime { get; set; }
    }

    [Serializable]
    public class UspInEmrAuth : BaseModel
    {
        public virtual String InPatNo { get; set; }

        public virtual String Name { get; set; }

        public virtual DateTime InTime { get; set; }

        public virtual string CatalogId { get; set; }

        public virtual String EmrName { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual String RecDoctor { get; set; }

        public virtual String AuthDoctor { get; set; }

        public virtual String BedName { get; set; }

        public virtual string HospId { get; set; }

        public virtual String RecNo { get; set; }

        public virtual String AuthStatus { get; set; }

        public virtual String PatStatus { get; set; }

        public virtual String LocationName { get; set; }

        public virtual DateTime Outtime { get; set; }
    }

    [Serializable]
    public class UspInAdviceLongPrint : BaseModel
    {
        public virtual String Name { get; set; }

        public virtual String InTime { get; set; }

        public virtual String OutTime { get; set; }

        public virtual String InPatNo { get; set; }

        public virtual string LocationId { get; set; }

        public virtual String LocationName { get; set; }

        public virtual String BedName { get; set; }

        public virtual string AdviceLocaionId { get; set; }

        public virtual DateTime AdviceTime { get; set; }

        public virtual Int32 FirstDay { get; set; }

        public virtual Int32 LastDay { get; set; }

        public virtual String DoctorName { get; set; }

        public virtual String ChkName { get; set; }

        public virtual String ItemName { get; set; }

        public virtual Int32 GroupNum { get; set; }

        public virtual String FrequencyName { get; set; }

        public virtual String UsageName { get; set; }

        public virtual DateTime EndOperTime { get; set; }

        public virtual String EndDoctorName { get; set; }

        public virtual String EndName { get; set; }

        public virtual Int32 NTime { get; set; }

        public virtual String Memo { get; set; }

        public virtual String Spec { get; set; }

        public virtual double Dosage { get; set; }

        public virtual String DosageUnit { get; set; }

        public virtual double Totality { get; set; }

        public virtual String TotalityUnit { get; set; }

        public virtual string ItemId { get; set; }

        public virtual Int32 SN { get; set; }
    }

    [Serializable]
    public class UspInAdviceTempPrint : BaseModel
    {
        public virtual String Name { get; set; }

        public virtual String InPatNo { get; set; }

        public virtual String DoctorName { get; set; }

        public virtual String LocationName { get; set; }

        public virtual String BedName { get; set; }

        public virtual String ItemName { get; set; }

        public virtual String FrequencyName { get; set; }

        public virtual String UsageName { get; set; }

        public virtual Int32 NTime { get; set; }

        public virtual Int32 GroupNum { get; set; }

        public virtual DateTime ChkOperTime { get; set; }

        public virtual double Totality { get; set; }

        public virtual String TotalityUnit { get; set; }

        public virtual String ChName { get; set; }

        public virtual DateTime AdviceTime { get; set; }

        public virtual String Spec { get; set; }

        public virtual double Dosage { get; set; }

        public virtual String DosageUnit { get; set; }

        public virtual String Memo { get; set; }

        public virtual string ItemId { get; set; }

        public virtual DateTime CancelOperTime { get; set; }

        public virtual String CancelName { get; set; }

        public virtual Int32 SN { get; set; }
    }

    [Serializable]
    public class UspWindowOperFunction : BaseModel
    {
        public virtual string MenuId { get; set; }

        public virtual string OperId { get; set; }

        public virtual string FunctionID { get; set; }
    }

    [Serializable]
    public class UspPatIllHistory : BaseModel
    {
        public virtual String IllHistory { get; set; }
    }

    [Serializable]
    public class UspOutDrugAdvice : BaseModel
    {
        public virtual String Name { get; set; }

        public virtual String InPatNo { get; set; }

        public virtual String DoctorName { get; set; }

        public virtual Boolean IsCancel { get; set; }

        public virtual String LocationName { get; set; }

        public virtual String ItemName { get; set; }

        public virtual String FrequencyName { get; set; }

        public virtual String UsageName { get; set; }

        public virtual Int32 NTime { get; set; }

        public virtual Int32 GroupNum { get; set; }

        public virtual DateTime ChkOperTime { get; set; }

        public virtual double Totality { get; set; }

        public virtual String TotalityUnit { get; set; }

        public virtual String ChName { get; set; }

        public virtual DateTime AdviceTime { get; set; }

        public virtual String Spec { get; set; }

        public virtual double Dosage { get; set; }

        public virtual String DosageUnit { get; set; }

        public virtual String Memo { get; set; }

        public virtual string ItemId { get; set; }

        public virtual DateTime CancelOperTime { get; set; }

        public virtual String CancelName { get; set; }

        public virtual Int32 SN { get; set; }

        public virtual String BedName { get; set; }
    }

    [Serializable]
    public class UspPatientEmrCatalogForNurse : BaseModel
    {
        public virtual String Name { get; set; }

        public virtual String ParentID { get; set; }

        public virtual Int32 OrderBy { get; set; }
    }

    [Serializable]
    public class UspInEmrXmlKey : BaseModel
    {
        public virtual String XmlField { get; set; }
    }


    [Serializable]
    public class UspInEmrXmlValue : BaseModel
    {
        public virtual String XmlValue { get; set; }
    }

    [Serializable]
    public class UspInEmrSearch : BaseModel
    {
        public virtual String RecNo { get; set; }

        public virtual string HospId { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual string CatalogId { get; set; }

        public virtual string OperID { get; set; }

        public virtual string ModifyOperID { get; set; }

        public virtual string RealeaseOperId { get; set; }

        public virtual Boolean IsAuth { get; set; }

        public virtual String CatalogName { get; set; }

        public virtual String DoctorName { get; set; }

        public virtual String Name { get; set; }

        public virtual String LocationName { get; set; }

        public virtual String AuthMan { get; set; }

        public virtual String InPatNo { get; set; }

        public virtual String PatName { get; set; }

        public virtual String ModiOperName { get; set; }

        public virtual DateTime ModifyOperTime { get; set; }

        public virtual DateTime AuthOperTime { get; set; }

        public virtual DateTime RealeaseTime { get; set; }

        public virtual String OperName { get; set; }

        public virtual String RealeaseName { get; set; }

        public virtual Boolean IsCheck { get; set; }

        public virtual Boolean IsClosed { get; set; }

        public virtual Boolean IsRealease { get; set; }

        public virtual String ClosedName { get; set; }

        public virtual DateTime ClosedTime { get; set; }
    }

    [Serializable]
    public class UspUserSystemWidthSyMenu : UspUserSystem
    {
        public List<UspUserSystemMenu> Menus { get; set; }
    }

    [Serializable]
    public class UspHuLoseDtl : BaseModel
    {
        //////////////////////////////[DataMember(Order = 10)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 11)]
        public virtual string InBatchId { get; set; }

        //////////////////////////////[DataMember(Order = 12)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 13)]
        public virtual string UnitId { get; set; }

        //////////////////////////////[DataMember(Order = 14)]
        public virtual double DrugNum { get; set; }

        //////////////////////////////[DataMember(Order = 15)]
        public virtual double StockPrice { get; set; }

        //////////////////////////////[DataMember(Order = 16)]
        public virtual double RetailPrice { get; set; }

        //////////////////////////////[DataMember(Order = 17)]
        public virtual string Reason { get; set; }

        //////////////////////////////[DataMember(Order = 18)]
        public virtual string BillId { get; set; }

        //////////////////////////////[DataMember(Order = 19)]
        public virtual string BillNo { get; set; }

        //////////////////////////////[DataMember(Order = 20)]
        public virtual string HouseId { get; set; }

        //////////////////////////////[DataMember(Order = 21)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////[DataMember(Order = 22)]
        public virtual string OperId { get; set; }

        //////////////////////////////[DataMember(Order = 23)]
        public virtual string Memo { get; set; }

        //////////////////////////////[DataMember(Order = 24)]
        public virtual bool IsSign { get; set; }

        //////////////////////////////[DataMember(Order = 25)]
        public virtual DateTime SignTime { get; set; }

        //////////////////////////////[DataMember(Order = 26)]
        public virtual string SignOperId { get; set; }

        //////////////////////////////[DataMember(Order = 27)]
        public virtual string UnitName { get; set; }

        //////////////////////////////[DataMember(Order = 28)]
        public virtual string ItemCode { get; set; }

        //////////////////////////////[DataMember(Order = 29)]
        public virtual string ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 30)]
        public virtual string Spec { get; set; }

        //////////////////////////////[DataMember(Order = 31)]
        public virtual string ManufactureryName { get; set; }

        //////////////////////////////[DataMember(Order = 32)]
        public virtual double TotalPrice { get; set; }

        //////////////////////////////[DataMember(Order = 33)]
        public virtual double TotalRetail { get; set; }

        //////////////////////////////[DataMember(Order = 34)]
        public virtual string PNo { get; set; }
    }

    [Serializable]
    public class UspHuOtherInDtl : BaseModel
    {
        //////////////////////////////[DataMember(Order = 10)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 11)]
        public virtual string BillId { get; set; }

        //////////////////////////////[DataMember(Order = 12)]
        public virtual string BillNo { get; set; }

        //////////////////////////////[DataMember(Order = 13)]
        public virtual string HouseId { get; set; }

        //////////////////////////////[DataMember(Order = 14)]
        public virtual string Reason { get; set; }

        //////////////////////////////[DataMember(Order = 15)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////[DataMember(Order = 16)]
        public virtual string OperId { get; set; }

        //////////////////////////////[DataMember(Order = 17)]
        public virtual bool IsSign { get; set; }

        //////////////////////////////[DataMember(Order = 18)]
        public virtual DateTime SignTime { get; set; }

        //////////////////////////////[DataMember(Order = 19)]
        public virtual string SignOperId { get; set; }

        //////////////////////////////[DataMember(Order = 20)]
        public virtual string InBatchNo { get; set; }

        //////////////////////////////[DataMember(Order = 21)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 22)]
        public virtual string PNo { get; set; }

        //////////////////////////////[DataMember(Order = 23)]
        public virtual string UnitId { get; set; }

        //////////////////////////////[DataMember(Order = 24)]
        public virtual string CompId { get; set; }

        //////////////////////////////[DataMember(Order = 25)]
        public virtual double DrugNum { get; set; }

        //////////////////////////////[DataMember(Order = 26)]
        public virtual double StockPrice { get; set; }

        //////////////////////////////[DataMember(Order = 27)]
        public virtual double RetailPrice { get; set; }

        //////////////////////////////[DataMember(Order = 28)]
        public virtual DateTime StoreDate { get; set; }

        //////////////////////////////[DataMember(Order = 29)]
        public virtual DateTime ProduceDate { get; set; }

        //////////////////////////////[DataMember(Order = 30)]
        public virtual DateTime LimitDate { get; set; }

        //////////////////////////////[DataMember(Order = 31)]
        public virtual string ManufactureryName { get; set; }

        //////////////////////////////[DataMember(Order = 32)]
        public virtual string ItemCode { get; set; }

        //////////////////////////////[DataMember(Order = 33)]
        public virtual string ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 34)]
        public virtual string Spec { get; set; }

        //////////////////////////////[DataMember(Order = 35)]
        public virtual string UnitName { get; set; }

        //////////////////////////////[DataMember(Order = 36)]
        public virtual double TotalPrice { get; set; }

        //////////////////////////////[DataMember(Order = 37)]
        public virtual double TotalRetail { get; set; }

        //////////////////////////////[DataMember(Order = 38)]
        public virtual double AddPercent { get; set; }
    }

    [Serializable]
    public class UspHuOtherOutDtl : BaseModel
    {
        //////////////////////////////[DataMember(Order = 10)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 11)]
        public virtual string InBatchId { get; set; }

        //////////////////////////////[DataMember(Order = 12)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 13)]
        public virtual string UnitId { get; set; }

        //////////////////////////////[DataMember(Order = 14)]
        public virtual double DrugNum { get; set; }

        //////////////////////////////[DataMember(Order = 15)]
        public virtual double StockPrice { get; set; }

        //////////////////////////////[DataMember(Order = 16)]
        public virtual double RetailPrice { get; set; }

        //////////////////////////////[DataMember(Order = 17)]
        public virtual string Reason { get; set; }

        //////////////////////////////[DataMember(Order = 18)]
        public virtual string BillId { get; set; }

        //////////////////////////////[DataMember(Order = 19)]
        public virtual string BillNo { get; set; }

        //////////////////////////////[DataMember(Order = 20)]
        public virtual string HouseId { get; set; }

        //////////////////////////////[DataMember(Order = 21)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////[DataMember(Order = 22)]
        public virtual string OperId { get; set; }

        //////////////////////////////[DataMember(Order = 23)]
        public virtual string Memo { get; set; }

        //////////////////////////////[DataMember(Order = 24)]
        public virtual bool IsSign { get; set; }

        //////////////////////////////[DataMember(Order = 25)]
        public virtual DateTime SignTime { get; set; }

        //////////////////////////////[DataMember(Order = 26)]
        public virtual string SignOperId { get; set; }

        //////////////////////////////[DataMember(Order = 27)]
        public virtual string UnitName { get; set; }

        //////////////////////////////[DataMember(Order = 28)]
        public virtual string ItemCode { get; set; }

        //////////////////////////////[DataMember(Order = 29)]
        public virtual string ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 30)]
        public virtual string Spec { get; set; }

        //////////////////////////////[DataMember(Order = 31)]
        public virtual string ManufactureryName { get; set; }

        //////////////////////////////[DataMember(Order = 32)]
        public virtual string PNo { get; set; }

        //////////////////////////////[DataMember(Order = 33)]
        public virtual double TotalPrice { get; set; }

        //////////////////////////////[DataMember(Order = 34)]
        public virtual double TotalRetail { get; set; }

        //////////////////////////////[DataMember(Order = 35)]
        public virtual double DeltaPrice { get; set; }
        //////////////////////////////[DataMember(Order = 36)]
        public virtual bool IsModify { get; set; }

        //////////////////////////////[DataMember(Order = 37)]
        public virtual bool IsSelected { get; set; }

        //////////////////////////////[DataMember(Order = 38)]
        public virtual string StrTemp { get; set; }

        //////////////////////////////[DataMember(Order = 39)]
        public virtual string StrTemp1 { get; set; }

        //////////////////////////////[DataMember(Order = 40)]
        public virtual DateTime InputTime { get; set; }

        //////////////////////////////[DataMember(Order = 41)]
        public virtual double SortOrder { get; set; }




    }

    #region UspRmAdjustWarning

    [Serializable]
    public class UspRmAdjustWarning : BaseModel
    {
        //////////////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String DispUnit { get; set; }

        //////////////////////////////[DataMember(Order = 3, IsRequired = false)]
        public virtual DateTime? OperTime { get; set; }

        //////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual string RoomId { get; set; }

        //////////////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual String Name { get; set; }

        //////////////////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String Spec { get; set; }

        //////////////////////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual double OldPrice { get; set; }

        //////////////////////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual double NewPrice { get; set; }

        //////////////////////////////[DataMember(Order = 9, IsRequired = false)]
        public virtual string FormId { get; set; }

        //////////////////////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual string ManuId { get; set; }
    }

    #endregion UspRmAdjustWarning

    #region UspHuVoucherDtl

    [Serializable]
    public class UspHuVoucherDtl : BaseModel
    {
        public virtual string GUID { get; set; }

        public virtual string VoucherId { get; set; }

        public virtual string BillId { get; set; }

        public virtual double Amount { get; set; }

        public virtual double HasPay { get; set; }

        public virtual DateTime? SignTime { get; set; }

        public virtual String BillNo { get; set; }

        public virtual String Name { get; set; }

        public virtual String Memo { get; set; }
    }

    #endregion UspHuVoucherDtl

    #region UspSelectRmNotAuthorize

    [Serializable]
    public class UspSelectRmNotAuthorize : BaseModel
    {
        public UspSelectRmNotAuthorize() { }
        //////////////////////////////[DataMember(Order = 1, IsRequired = false)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String BillNo { get; set; }

        //////////////////////////////[DataMember(Order = 3, IsRequired = false)]
        public virtual string RoomId { get; set; }

        //////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //////////////////////////////[DataMember(Order = 5, IsRequired = false)]
        public virtual DateTime? OperTime { get; set; }

        //////////////////////////////[DataMember(Order = 6, IsRequired = false)]
        public virtual string Operid { get; set; }

        //////////////////////////////[DataMember(Order = 7, IsRequired = false)]
        public virtual double RetailTotle { get; set; }

        //////////////////////////////[DataMember(Order = 8, IsRequired = false)]
        public virtual double StockTotle { get; set; }

        //////////////////////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual String Type { get; set; }

        //////////////////////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual Boolean? IsSign { get; set; }

        //////////////////////////////[DataMember(Order = 11, IsRequired = false)]
        public virtual Int32? LsActType { get; set; }

        //////////////////////////////[DataMember(Order = 12, IsRequired = false)]
        public virtual DateTime? SignTime { get; set; }
    }

    #endregion UspSelectRmNotAuthorize


  
    
    public partial class UspOuRecipeDtlForOuInvoiceDtl : BaseModel
    {
        public virtual string ItemId { get; set; }

        public virtual Int32 ListNum { get; set; }

        public virtual Int32 LsGroupType { get; set; }

        public virtual String Code { get; set; }

        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual string UnitId { get; set; }

        public virtual double Totality { get; set; }

        public virtual Boolean IsBack { get; set; }

        public virtual Boolean IsToBack { get; set; }

        public virtual double Amount { get; set; }

        public virtual double Price { get; set; }

        public virtual Int32 LsGfType { get; set; }

        public virtual double LimitTotalMz { get; set; }

        public virtual String UnitDiagName { get; set; }

        public virtual string FeeId { get; set; }

        public virtual String FeeName { get; set; }

        public virtual string TypeGFXEId { get; set; }

        public virtual String TypeGFXEName { get; set; }

        public virtual String RoomInOut { get; set; }

        public virtual double DiscDiag { get; set; }

        public virtual string InvItemId { get; set; }

        public virtual String InvMzItemName { get; set; }

        public virtual string LimitGroupId { get; set; }

        public virtual double LimitFee { get; set; }

        public virtual string LocationId { get; set; }

        public virtual String LocationName { get; set; }

        public virtual string FeeHsId { get; set; }

        public virtual String FeeHsMzName { get; set; }

        public virtual string TallyTypeId { get; set; }

        public virtual string TallyGroupId { get; set; }

        public virtual string XDRpId { get; set; }

        public virtual string RecipeId { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual String DoctorName { get; set; }

        public virtual Int32 LsRpType { get; set; }

        public virtual Boolean IsDoctorInput { get; set; }

        public virtual string RecipeItemId { get; set; }

        public virtual Int32 LsAdviceType { get; set; }

        public virtual String Memo { get; set; }

        public virtual string ApplyId { get; set; }

        public virtual String YbType { get; set; }

        public virtual String PrepareTime { get; set; }

        public virtual Int32 GroupNum { get; set; }

        public virtual string UsageId { get; set; }

        public virtual string FrequencyId { get; set; }

        public virtual Int32 Days { get; set; }

        public virtual Int32 LsRepType { get; set; }

        public virtual Boolean IsAttach { get; set; }

        public virtual String RecipeDtlMemo { get; set; }

        public virtual Boolean IsOtherFee { get; set; }

        public virtual Boolean IsCancel { get; set; }

        public virtual string FormId { get; set; }

        public virtual String UsageMemo { get; set; }

        public virtual double DiscountAoumt { get; set; }

        public virtual double ChildPrice { get; set; }

        public virtual double DiscountPrice { get; set; }
    }

    #region UspInInvoiceDtlBillRm

    [Serializable]
    public class UspInInvoiceDtlBillRm : BaseModel
    {
        //////////////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual double Totality { get; set; }

        //////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual string UnitId { get; set; }

        //////////////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual string HospId { get; set; }

        //////////////////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String InPatNo { get; set; }

        //////////////////////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual String Name { get; set; }

        //////////////////////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual string LocationId { get; set; }

        //////////////////////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual string DoctorId { get; set; }

        //////////////////////////////[DataMember(Order = 10, IsRequired = true)]
        public virtual String Code { get; set; }

        //////////////////////////////[DataMember(Order = 11, IsRequired = true)]
        public virtual String ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 12, IsRequired = true)]
        public virtual String Spec { get; set; }

        //////////////////////////////[DataMember(Order = 13, IsRequired = false)]
        public virtual double PriceIn { get; set; }

        //////////////////////////////[DataMember(Order = 14, IsRequired = false)]
        public virtual Boolean? IsSelected { get; set; }

        //////////////////////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual String BedName { get; set; }

        //////////////////////////////[DataMember(Order = 16, IsRequired = true)]
        public virtual DateTime RegOperTime { get; set; }

        //////////////////////////////[DataMember(Order = 17, IsRequired = true)]
        public virtual Boolean IsCancel { get; set; }

        //////////////////////////////[DataMember(Order = 18, IsRequired = true)]
        public virtual int LsPerform { get; set; }

        //////////////////////////////[DataMember(Order = 19, IsRequired = false)]
        public virtual string CancelId { get; set; }

        //////////////////////////////[DataMember(Order = 20, IsRequired = false)]
        public virtual Boolean? IsDelete { get; set; }
    }

    #endregion UspInInvoiceDtlBillRm

    [Serializable]
    public class UspRMOUTStoresInfo : BaseModel
    {
        //////////////////////////////[DataMember(Order = 10)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 11)]
        public virtual string InBatchNo { get; set; }

        //////////////////////////////[DataMember(Order = 12)]
        public virtual string RoomId { get; set; }

        //////////////////////////////[DataMember(Order = 13)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 14)]
        public virtual string PNo { get; set; }

        //////////////////////////////[DataMember(Order = 15)]
        public virtual string UnitId { get; set; }

        //////////////////////////////[DataMember(Order = 16)]
        public virtual string CompId { get; set; }

        //////////////////////////////[DataMember(Order = 17)]
        public virtual double StockPrice { get; set; }

        //////////////////////////////[DataMember(Order = 18)]
        public virtual double RetailPrice { get; set; }

        //////////////////////////////[DataMember(Order = 19)]
        public virtual double StockNum { get; set; }

        //////////////////////////////[DataMember(Order = 20)]
        public virtual double InstoreNum { get; set; }

        //////////////////////////////[DataMember(Order = 21)]
        public virtual DateTime StoreDate { get; set; }

        //////////////////////////////[DataMember(Order = 22)]
        public virtual DateTime LimitDate { get; set; }

        //////////////////////////////[DataMember(Order = 23)]
        public virtual bool IsBalance { get; set; }

        //////////////////////////////[DataMember(Order = 24)]
        public virtual string UnitName { get; set; }

        //////////////////////////////[DataMember(Order = 25)]
        public virtual string ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 26)]
        public virtual string Spec { get; set; }

        //////////////////////////////[DataMember(Order = 27)]
        public virtual string ManufactureryName { get; set; }

        //////////////////////////////[DataMember(Order = 28)]
        public virtual string ItemCode { get; set; }

        //////////////////////////////[DataMember(Order = 29)]
        public virtual double TotalPrice { get; set; }

        //////////////////////////////[DataMember(Order = 30)]
        public virtual double TotalRetail { get; set; }

        //////////////////////////////[DataMember(Order = 31)]
        public virtual DateTime ProduceDate { get; set; }

        //////////////////////////////[DataMember(Order = 32)]
        public virtual string HuStoresId { get; set; }
    }

    [Serializable]
    public class UspKSBillInfo : BaseModel
    {
        //////////////////////////////[DataMember(Order = 10)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 11)]
        public virtual string InBatchId { get; set; }

        //////////////////////////////[DataMember(Order = 12)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 13)]
        public virtual string UnitId { get; set; }

        //////////////////////////////[DataMember(Order = 14)]
        public virtual double DrugNum { get; set; }

        //////////////////////////////[DataMember(Order = 15)]
        public virtual double RetailPrice { get; set; }

        //////////////////////////////[DataMember(Order = 16)]
        public virtual double StockPrice { get; set; }

        //////////////////////////////[DataMember(Order = 17)]
        public virtual string BillId { get; set; }

        //////////////////////////////[DataMember(Order = 18)]
        public virtual string BillNo { get; set; }

        //////////////////////////////[DataMember(Order = 19)]
        public virtual string RoomId { get; set; }

        //////////////////////////////[DataMember(Order = 20)]
        public virtual string LocationId { get; set; }

        //////////////////////////////[DataMember(Order = 21)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////[DataMember(Order = 22)]
        public virtual string Operid { get; set; }

        //////////////////////////////[DataMember(Order = 23)]
        public virtual bool IsSign { get; set; }

        //////////////////////////////[DataMember(Order = 24)]
        public virtual DateTime SignTime { get; set; }

        //////////////////////////////[DataMember(Order = 25)]
        public virtual string SignOperId { get; set; }

        //////////////////////////////[DataMember(Order = 26)]
        public virtual string UnitName { get; set; }

        //////////////////////////////[DataMember(Order = 27)]
        public virtual string ItemCode { get; set; }

        //////////////////////////////[DataMember(Order = 28)]
        public virtual string ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 29)]
        public virtual string Spec { get; set; }

        //////////////////////////////[DataMember(Order = 30)]
        public virtual string ManufactureryName { get; set; }

        //////////////////////////////[DataMember(Order = 31)]
        public virtual string PNo { get; set; }

        //////////////////////////////[DataMember(Order = 32)]
        public virtual double TotalPrice { get; set; }

        //////////////////////////////[DataMember(Order = 33)]
        public virtual double TotalRetail { get; set; }

        //////////////////////////////[DataMember(Order = 34)]
        public virtual double HuStockNum { get; set; }

        //////////////////////////////[DataMember(Order = 35)]
        public virtual int UnitKc { get; set; }

        //////////////////////////////[DataMember(Order = 36)]
        public virtual string Pno { get; set; }

        //////////////////////////////[DataMember(Order = 37)]
        public virtual DateTime LimitDate { get; set; }

        //////////////////////////////[DataMember(Order = 38)]
        public virtual string HouseId { get; set; }

        //////////////////////////////[DataMember(Order = 39)]
        public virtual bool IsAffirm { get; set; }

        //////////////////////////////[DataMember(Order = 40)]
        public virtual DateTime AffirmTime { get; set; }

        //////////////////////////////[DataMember(Order = 41)]
        public virtual string AffirmOperid { get; set; }

        //////////////////////////////[DataMember(Order = 42)]
        public virtual string CkBillNo { get; set; }
    }

    [Serializable]
    public class UspRmOtherInDtl : BaseModel
    {
        //////////////////////////////[DataMember(Order = 10)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 11)]
        public virtual string InBatchNo { get; set; }

        //////////////////////////////[DataMember(Order = 12)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 13)]
        public virtual string PNo { get; set; }

        //////////////////////////////[DataMember(Order = 14)]
        public virtual string UnitId { get; set; }

        //////////////////////////////[DataMember(Order = 15)]
        public virtual double DrugNum { get; set; }

        //////////////////////////////[DataMember(Order = 16)]
        public virtual double StockPrice { get; set; }

        //////////////////////////////[DataMember(Order = 17)]
        public virtual double RetailPrice { get; set; }

        //////////////////////////////[DataMember(Order = 18)]
        public virtual DateTime StoreDate { get; set; }

        //////////////////////////////[DataMember(Order = 19)]
        public virtual DateTime ProduceDate { get; set; }

        //////////////////////////////[DataMember(Order = 20)]
        public virtual DateTime LimitDate { get; set; }

        //////////////////////////////[DataMember(Order = 21)]
        public virtual string CompId { get; set; }

        //////////////////////////////[DataMember(Order = 22)]
        public virtual string BillId { get; set; }

        //////////////////////////////[DataMember(Order = 23)]
        public virtual string BillNo { get; set; }

        //////////////////////////////[DataMember(Order = 24)]
        public virtual string RoomId { get; set; }

        //////////////////////////////[DataMember(Order = 25)]
        public virtual string Reason { get; set; }

        //////////////////////////////[DataMember(Order = 26)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////[DataMember(Order = 27)]
        public virtual string Operid { get; set; }

        //////////////////////////////[DataMember(Order = 28)]
        public virtual bool IsSign { get; set; }

        //////////////////////////////[DataMember(Order = 29)]
        public virtual DateTime SignTime { get; set; }

        //////////////////////////////[DataMember(Order = 30)]
        public virtual string SignOperId { get; set; }

        //////////////////////////////[DataMember(Order = 31)]
        public virtual string ItemCode { get; set; }

        //////////////////////////////[DataMember(Order = 32)]
        public virtual string ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 33)]
        public virtual string Spec { get; set; }

        //////////////////////////////[DataMember(Order = 34)]
        public virtual string ManufactureryName { get; set; }

        //////////////////////////////[DataMember(Order = 35)]
        public virtual string UnitName { get; set; }

        //////////////////////////////[DataMember(Order = 36)]
        public virtual double TotalPrice { get; set; }

        //////////////////////////////[DataMember(Order = 37)]
        public virtual double TotalRetail { get; set; }
    }

    [Serializable]
    public class UspCkMachineItem : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual String GUID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual String Name { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual String ParentID { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual String PassAgeNum { get; set; }

        //[DataMember(Order = 5, IsRequired = false)]
        public virtual string TestID { get; set; }

        //[DataMember(Order = 6, IsRequired = false)]
        public virtual Boolean? IsQc { get; set; }
    }

    [Serializable]
    public class UspRmMoveDtl : BaseModel
    {
        //////////////////////////////[DataMember(Order = 10)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 11)]
        public virtual string InBatchId { get; set; }

        //////////////////////////////[DataMember(Order = 12)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 13)]
        public virtual string UnitId { get; set; }

        //////////////////////////////[DataMember(Order = 14)]
        public virtual double DrugNum { get; set; }

        //////////////////////////////[DataMember(Order = 15)]
        public virtual double RetailPrice { get; set; }

        //////////////////////////////[DataMember(Order = 16)]
        public virtual double StockPrice { get; set; }

        //////////////////////////////[DataMember(Order = 17)]
        public virtual string BillId { get; set; }

        //////////////////////////////[DataMember(Order = 18)]
        public virtual string BillNo { get; set; }

        //////////////////////////////[DataMember(Order = 19)]
        public virtual string RoomId { get; set; }

        //////////////////////////////[DataMember(Order = 20)]
        public virtual string RoomIdO { get; set; }

        //////////////////////////////[DataMember(Order = 21)]
        public virtual string Memo { get; set; }

        //////////////////////////////[DataMember(Order = 22)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////[DataMember(Order = 23)]
        public virtual string Operid { get; set; }

        //////////////////////////////[DataMember(Order = 24)]
        public virtual bool IsSign { get; set; }

        //////////////////////////////[DataMember(Order = 25)]
        public virtual DateTime SignTime { get; set; }

        //////////////////////////////[DataMember(Order = 26)]
        public virtual string SignOperId { get; set; }

        //////////////////////////////[DataMember(Order = 27)]
        public virtual string UnitName { get; set; }

        //////////////////////////////[DataMember(Order = 28)]
        public virtual string ItemCode { get; set; }

        //////////////////////////////[DataMember(Order = 29)]
        public virtual string ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 30)]
        public virtual string Spec { get; set; }

        //////////////////////////////[DataMember(Order = 31)]
        public virtual string ManufactureryName { get; set; }

        //////////////////////////////[DataMember(Order = 32)]
        public virtual string PNo { get; set; }

        //////////////////////////////[DataMember(Order = 33)]
        public virtual double TotalPrice { get; set; }

        //////////////////////////////[DataMember(Order = 34)]
        public virtual double TotalRetail { get; set; }

        //////////////////////////////[DataMember(Order = 35)]
        public virtual double StockNum { get; set; }

        //////////////////////////////[DataMember(Order = 36)]
        public virtual double NowNum { get; set; }
    }

    [Serializable]
    public class UspRmLoseDtl : BaseModel
    {
        //////////////////////////////[DataMember(Orderr = 10)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Orderr = 11)]
        public virtual string InBatchId { get; set; }

        //////////////////////////////[DataMember(Orderr = 12)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Orderr = 13)]
        public virtual string UnitId { get; set; }

        //////////////////////////////[DataMember(Orderr = 14)]
        public virtual double DrugNum { get; set; }

        //////////////////////////////[DataMember(Orderr = 15)]
        public virtual double StockPrice { get; set; }

        //////////////////////////////[DataMember(Orderr = 16)]
        public virtual double RetailPrice { get; set; }

        //////////////////////////////[DataMember(Orderr = 17)]
        public virtual string BillId { get; set; }

        //////////////////////////////[DataMember(Orderr = 18)]
        public virtual string BillNo { get; set; }

        //////////////////////////////[DataMember(Orderr = 19)]
        public virtual string RoomId { get; set; }

        //////////////////////////////[DataMember(Orderr = 20)]
        public virtual string LocationId { get; set; }

        //////////////////////////////[DataMember(Orderr = 21)]
        public virtual string Memo { get; set; }

        //////////////////////////////[DataMember(Orderr = 22)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////[DataMember(Orderr = 23)]
        public virtual string Operid { get; set; }

        //////////////////////////////[DataMember(Orderr = 24)]
        public virtual DateTime SignDate { get; set; }

        //////////////////////////////[DataMember(Orderr = 25)]
        public virtual bool IsSign { get; set; }

        //////////////////////////////[DataMember(Orderr = 26)]
        public virtual string SignOperId { get; set; }

        //////////////////////////////[DataMember(Orderr = 27)]
        public virtual string UnitName { get; set; }

        //////////////////////////////[DataMember(Orderr = 28)]
        public virtual string ItemCode { get; set; }

        //////////////////////////////[DataMember(Orderr = 29)]
        public virtual string ItemName { get; set; }

        //////////////////////////////[DataMember(Orderr = 30)]
        public virtual string Spec { get; set; }

        //////////////////////////////[DataMember(Orderr = 31)]
        public virtual string ManufactureryName { get; set; }

        //////////////////////////////[DataMember(Orderr = 32)]
        public virtual string PNo { get; set; }

        //////////////////////////////[DataMember(Orderr = 33)]
        public virtual double TotalPrice { get; set; }

        //////////////////////////////[DataMember(Orderr = 34)]
        public virtual double TotalRetail { get; set; }
    }

    [Serializable]
    public class UspRmKOutDtl : BaseModel
    {
        //////////////////////////////[DataMember(Order = 10)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 11)]
        public virtual string InBatchId { get; set; }

        //////////////////////////////[DataMember(Order = 12)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 13)]
        public virtual string UnitId { get; set; }

        //////////////////////////////[DataMember(Order = 14)]
        public virtual double DrugNum { get; set; }

        //////////////////////////////[DataMember(Order = 15)]
        public virtual double RetailPrice { get; set; }

        //////////////////////////////[DataMember(Order = 16)]
        public virtual double StockPrice { get; set; }

        //////////////////////////////[DataMember(Order = 17)]
        public virtual string BillId { get; set; }

        //////////////////////////////[DataMember(Order = 18)]
        public virtual string BillNo { get; set; }

        //////////////////////////////[DataMember(Order = 19)]
        public virtual string RoomId { get; set; }

        //////////////////////////////[DataMember(Order = 20)]
        public virtual string LocationId { get; set; }

        //////////////////////////////[DataMember(Order = 21)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////[DataMember(Order = 22)]
        public virtual string Operid { get; set; }

        //////////////////////////////[DataMember(Order = 23)]
        public virtual bool IsSign { get; set; }

        //////////////////////////////[DataMember(Order = 24)]
        public virtual DateTime SignTime { get; set; }

        //////////////////////////////[DataMember(Order = 25)]
        public virtual string SignOperId { get; set; }

        //////////////////////////////[DataMember(Order = 26)]
        public virtual string UnitName { get; set; }

        //////////////////////////////[DataMember(Order = 27)]
        public virtual string ItemCode { get; set; }

        //////////////////////////////[DataMember(Order = 28)]
        public virtual string ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 29)]
        public virtual string Spec { get; set; }

        //////////////////////////////[DataMember(Order = 30)]
        public virtual string ManufactureryName { get; set; }

        //////////////////////////////[DataMember(Order = 31)]
        public virtual string PNo { get; set; }

        //////////////////////////////[DataMember(Order = 32)]
        public virtual double TotalPrice { get; set; }

        //////////////////////////////[DataMember(Order = 33)]
        public virtual double TotalRetail { get; set; }

        //////////////////////////////[DataMember(Order = 34)]
        public virtual bool IsImport { get; set; }
    }


    [Serializable]
    public class UspRmKsBackDtl : BaseModel
    {
        //////////////////////////////[DataMember(Order = 10)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 11)]
        public virtual string InBatchId { get; set; }

        //////////////////////////////[DataMember(Order = 12)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 13)]
        public virtual string UnitId { get; set; }

        //////////////////////////////[DataMember(Order = 14)]
        public virtual double DrugNum { get; set; }

        //////////////////////////////[DataMember(Order = 15)]
        public virtual double RetailPrice { get; set; }

        //////////////////////////////[DataMember(Order = 16)]
        public virtual double StockPrice { get; set; }

        //////////////////////////////[DataMember(Order = 17)]
        public virtual string BillId { get; set; }

        //////////////////////////////[DataMember(Order = 18)]
        public virtual string BillNo { get; set; }

        //////////////////////////////[DataMember(Order = 19)]
        public virtual string RoomId { get; set; }

        //////////////////////////////[DataMember(Order = 20)]
        public virtual string LocationId { get; set; }

        //////////////////////////////[DataMember(Order = 21)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////[DataMember(Order = 22)]
        public virtual string Operid { get; set; }

        //////////////////////////////[DataMember(Order = 23)]
        public virtual bool IsSign { get; set; }

        //////////////////////////////[DataMember(Order = 24)]
        public virtual DateTime SignTime { get; set; }

        //////////////////////////////[DataMember(Order = 25)]
        public virtual string SignOperId { get; set; }

        //////////////////////////////[DataMember(Order = 26)]
        public virtual string UnitName { get; set; }

        //////////////////////////////[DataMember(Order = 27)]
        public virtual string ItemCode { get; set; }

        //////////////////////////////[DataMember(Order = 28)]
        public virtual string ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 29)]
        public virtual string Spec { get; set; }

        //////////////////////////////[DataMember(Order = 30)]
        public virtual string ManufactureryName { get; set; }

        //////////////////////////////[DataMember(Order = 31)]
        public virtual double TotalPrice { get; set; }

        //////////////////////////////[DataMember(Order = 32)]
        public virtual double TotalRetail { get; set; }

        //////////////////////////////[DataMember(Order = 33)]
        public virtual string PNo { get; set; }
    }

    [Serializable]
    public class UspHuStockReqDtl : BaseModel
    {
        //////////////////////////////[DataMember(Order = 10)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 11)]
        public virtual string BillId { get; set; }

        //////////////////////////////[DataMember(Order = 12)]
        public virtual string BillNo { get; set; }

        //////////////////////////////[DataMember(Order = 13)]
        public virtual string HouseId { get; set; }

        //////////////////////////////[DataMember(Order = 14)]
        public virtual DateTime ApplyTime { get; set; }

        //////////////////////////////[DataMember(Order = 15)]
        public virtual DateTime ValideTime { get; set; }

        //////////////////////////////[DataMember(Order = 16)]
        public virtual string ApplyIdea { get; set; }

        //////////////////////////////[DataMember(Order = 17)]
        public virtual string ApplyHander { get; set; }

        //////////////////////////////[DataMember(Order = 18)]
        public virtual string OperId { get; set; }

        //////////////////////////////[DataMember(Order = 19)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////[DataMember(Order = 20)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 21)]
        public virtual string UnitId { get; set; }

        //////////////////////////////[DataMember(Order = 22)]
        public virtual double DrugNum { get; set; }

        //////////////////////////////[DataMember(Order = 23)]
        public virtual double StockPrice { get; set; }

        //////////////////////////////[DataMember(Order = 24)]
        public virtual double RetailPrice { get; set; }

        //////////////////////////////[DataMember(Order = 25)]
        public virtual string UnitName { get; set; }

        //////////////////////////////[DataMember(Order = 26)]
        public virtual string ItemCode { get; set; }

        //////////////////////////////[DataMember(Order = 27)]
        public virtual string ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 28)]
        public virtual string Spec { get; set; }

        //////////////////////////////[DataMember(Order = 29)]
        public virtual string ManufactureryName { get; set; }

        //////////////////////////////[DataMember(Order = 30)]
        public virtual double TotalPrice { get; set; }

        //////////////////////////////[DataMember(Order = 31)]
        public virtual double TotalRetail { get; set; }

        //////////////////////////////[DataMember(Order = 32)]
        public virtual double AddPercent { get; set; }

        //////////////////////////////[DataMember(Order = 33)]
        public virtual double SaleNum { get; set; }

        //////////////////////////////[DataMember(Order = 34)]
        public virtual int ProAreaId { get; set; }

        //////////////////////////////[DataMember(Order = 35)]
        public virtual string ManuId { get; set; }

        //////////////////////////////[DataMember(Order = 36)]
        public virtual string PassNo { get; set; }
    }

    [Serializable]
    public class UspOuExecLocation : BaseModel
    {
        public virtual DateTime RegTime { get; set; }

        public virtual String LocationName { get; set; }

        public virtual String CardNo { get; set; }

        public virtual String MzRegNo { get; set; }

        public virtual String PatientName { get; set; }

        public virtual string PatId { get; set; }

        public virtual String Sex { get; set; }

        public virtual Int32 Age { get; set; }

        public virtual Int32 AgeMonth { get; set; }

        public virtual Int32 AgeDay { get; set; }

        public virtual String PatTypeName { get; set; }

        public virtual String Illness { get; set; }

        public virtual String RecipeNum { get; set; }

        public virtual string MzRegId { get; set; }

        public virtual String Name { get; set; }

        public virtual double Amount { get; set; }

        public virtual string ItemId { get; set; }

        public virtual double Totality { get; set; }

        public virtual Int32 LsRpType { get; set; }

        public virtual String ExecPoint { get; set; }

        public virtual String DoctorName { get; set; }

        public virtual String Memo { get; set; }

        public virtual String InvInItemName { get; set; }

        public virtual String AgeString { get; set; }

        public virtual string LocationId { get; set; }
    }

    [Serializable]
    public class UspInExecuteBillPrintDoctor : BaseModel
    {
        public virtual string HospId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual DateTime AdviceTime { get; set; }

        public virtual string AdviceId { get; set; }

        public virtual Int32 LsMarkType { get; set; }

        public virtual string UnitTakeId { get; set; }

        public virtual Int32 GroupNum { get; set; }

        public virtual string LocationId { get; set; }

        public virtual Boolean IsPrint { get; set; }

        public virtual string FrequencyId { get; set; }

        public virtual Int32 LsExecLoc { get; set; }

        public virtual string ExecLocId { get; set; }

        public virtual String HospNo { get; set; }

        public virtual String PatientName { get; set; }

        public virtual Int32 LocIn { get; set; }

        public virtual String SexName { get; set; }

        public virtual Int32 Age { get; set; }

        public virtual string PatId { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual string MainDoctorId { get; set; }

        public virtual String Code { get; set; }

        public virtual Int32 OrderBy { get; set; }

        public virtual string UnitInId { get; set; }

        public virtual string UsageId { get; set; }

        public virtual String ItemName { get; set; }

        public virtual String Spec { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual String LoactionName { get; set; }

        public virtual String BedName { get; set; }

        public virtual String UnitTakeName { get; set; }

        public virtual String UsageName { get; set; }

        public virtual String FrequencyName { get; set; }

        public virtual Boolean IsPoison { get; set; }

        public virtual double Times { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual string DetailId { get; set; }

        public virtual double Dosage { get; set; }

        public virtual double Totality { get; set; }

        public virtual String Memo { get; set; }

        public virtual string BedId { get; set; }

        public virtual Boolean IsPrintLabel { get; set; }

        public virtual Boolean IsPrintReject { get; set; }

        public virtual Boolean IsPrintDrug { get; set; }

        public virtual Boolean IsPrintAst { get; set; }

        public virtual Boolean IsPrintCure { get; set; }

        public virtual Boolean IsPrintNurse { get; set; }

        public virtual Boolean IsPrintExternal { get; set; }

        public virtual Boolean IsPrintPush { get; set; }

        public virtual Boolean IsPrintRejSkin { get; set; }

        public virtual Boolean IsPrintDietetic { get; set; }

        public virtual Boolean IsPrintBlood { get; set; }

        public virtual Boolean IsSelected { get; set; }

        public virtual Boolean IsLastLong { get; set; }

        public virtual Boolean IsPrintAtomization { get; set; }

        public virtual Boolean IsExecuted { get; set; }

        public virtual DateTime ExecutedTime { get; set; }

        public virtual string ExecutedOperId { get; set; }

        public virtual String UnitInName { get; set; }

        public virtual Boolean IsPriority { get; set; }

        public virtual String NurseMemo { get; set; }

        public virtual Boolean IsUrgent { get; set; }

        public virtual String JYJCDH { get; set; }

        public virtual Boolean IsApply { get; set; }

        public virtual DateTime ApplyTime { get; set; }

        public virtual String ApplyOper { get; set; }

        public virtual Int32 LastDay { get; set; }

        public virtual Int32 FirstDay { get; set; }

        public virtual Boolean IsAst { get; set; }

        public virtual Boolean IsAttach { get; set; }

        public virtual string PatLocationId { get; set; }

        public virtual String AgeString { get; set; }

        public virtual string OperId { get; set; }

        public virtual Int32 LsRpType { get; set; }

        public virtual String rptname { get; set; }

        public virtual String tempstr1 { get; set; }

        public virtual String tempstr2 { get; set; }

        public virtual String BedGroup { get; set; }

        public virtual String DoctorInputTime { get; set; }
    }

    [Serializable]
    public class UspHuRmStoresTotal : BaseModel
    {
        public virtual string GUID { get; set; }

        public virtual string UnitId { get; set; }

        public virtual String ItemCode { get; set; }

        public virtual String Spec { get; set; }

        public virtual string ManuId { get; set; }

        public virtual String Manufacturername { get; set; }

        public virtual String ItemName { get; set; }

        public virtual String UnitName { get; set; }

        public virtual double StockNumSun { get; set; }

        public virtual String Unitname { get; set; }

        public virtual double TotalPrice { get; set; }

        public virtual double TotalRetail { get; set; }
    }

    [Serializable]
    public class UspHuRmStoresDtail : BaseModel
    {
        public virtual string GUID { get; set; }

        public virtual string ItemId { get; set; }

        public virtual String InBatchNo { get; set; }

        public virtual String PNo { get; set; }

        public virtual string UnitId { get; set; }

        public virtual double StockNum { get; set; }

        public virtual double StockPrice { get; set; }

        public virtual double RetailPrice { get; set; }

        public virtual DateTime StoreDate { get; set; }

        public virtual DateTime ProduceDate { get; set; }

        public virtual DateTime LimitDate { get; set; }

        public virtual double RetailTotal { get; set; }

        public virtual double PriceTotal { get; set; }


        public virtual String Spec { get; set; }

        public virtual String ItemCode { get; set; }

        public virtual String ItemName { get; set; }

        public virtual string RoomId { get; set; }

        public virtual string ManuId { get; set; }

        public virtual string HouseId { get; set; }
    }

    [Serializable]
    public class UspRmStoreUnderLineWarning : BaseModel
    {
        public virtual string GUID { get; set; }

        public virtual string RoomId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual String ItemCode { get; set; }

        public virtual String ItemName { get; set; }

        public virtual String Spec { get; set; }

        public virtual String RoomName { get; set; }

        public virtual String UnitName { get; set; }

        public virtual double UnderLine { get; set; }

        public virtual double UperLine { get; set; }

        public virtual double? Normal { get; set; }

        public virtual double? StockNum { get; set; }

        public virtual Boolean? IsActive { get; set; }

        public virtual int? OrderBy { get; set; }

        public virtual String CompanyName { get; set; }

        public virtual Boolean? Selected { get; set; }

        public virtual string UnitKc { get; set; }

        public virtual string UnitId { get; set; }
    }

    [Serializable]
    public class UspHuStoreUnderLineWarningDto : BaseModel
    {
        ////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual string HouseId { get; set; }

        ////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual string ItemId { get; set; }

        ////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String HouseName { get; set; }

        ////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual String ItemName { get; set; }

        ////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String ItemCode { get; set; }

        ////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual String CompanyName { get; set; }

        ////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual String UnitName { get; set; }

        ////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual String Spec { get; set; }

        ////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual double? UnderLineKc { get; set; }

        ////////////[DataMember(Order = 11, IsRequired = false)]
        public virtual double? UperLineKc { get; set; }

        ////////////[DataMember(Order = 12, IsRequired = false)]
        public virtual Boolean? Selected { get; set; }

        ////////////[DataMember(Order = 13, IsRequired = false)]
        public virtual double? StockNum { get; set; }
    }

    [Serializable]
    public class UspHuStoreUnderLineWarning : BaseModel
    {
        //////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////[DataMember(Order = 2, IsRequired = true)]
        public virtual string HouseId { get; set; }

        //////[DataMember(Order = 3, IsRequired = true)]
        public virtual string ItemId { get; set; }

        //////[DataMember(Order = 4, IsRequired = true)]
        public virtual String HouseName { get; set; }

        //////[DataMember(Order = 5, IsRequired = true)]
        public virtual String ItemName { get; set; }

        //////[DataMember(Order = 6, IsRequired = true)]
        public virtual String ItemCode { get; set; }

        //////[DataMember(Order = 7, IsRequired = true)]
        public virtual String CompanyName { get; set; }

        //////[DataMember(Order = 8, IsRequired = true)]
        public virtual String UnitName { get; set; }

        //////[DataMember(Order = 9, IsRequired = true)]
        public virtual String Spec { get; set; }

        //////[DataMember(Order = 10, IsRequired = false)]
        public virtual double? UnderLineKc { get; set; }

        //////[DataMember(Order = 11, IsRequired = false)]
        public virtual double? UperLineKc { get; set; }

        //////[DataMember(Order = 12, IsRequired = false)]
        public virtual Boolean? Selected { get; set; }

        //////[DataMember(Order = 13, IsRequired = false)]
        public virtual double? StockNum { get; set; }
    }

    [Serializable]
    public class UspSelectHuNotAuthorize : BaseModel
    {
        ////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String BillNo { get; set; }

        ////////[DataMember(Order = 3, IsRequired = true)]
        public virtual string HouseId { get; set; }

        ////////[DataMember(Order = 4, IsRequired = false)]
        public virtual string OperId { get; set; }

        ////////[DataMember(Order = 5, IsRequired = false)]
        public virtual DateTime? OperTime { get; set; }

        ////////[DataMember(Order = 6, IsRequired = true)]
        public virtual Int32 HasInvo { get; set; }

        ////////[DataMember(Order = 7, IsRequired = false)]
        public virtual Boolean? IsSign { get; set; }

        ////////[DataMember(Order = 8, IsRequired = false)]
        public virtual double? RetailTotle { get; set; }

        ////////[DataMember(Order = 9, IsRequired = false)]
        public virtual double? StockTotle { get; set; }

        ////////[DataMember(Order = 10, IsRequired = true)]
        public virtual String Type { get; set; }

        ////////[DataMember(Order = 11, IsRequired = true)]
        public virtual Int32 LsActType { get; set; }

        ////////[DataMember(Order = 12, IsRequired = false)]
        public virtual DateTime? SignTime { get; set; }

        ////////[DataMember(Order = 13, IsRequired = true)]
        public virtual String Name { get; set; }

        ////////[DataMember(Order = 14, IsRequired = true)]
        public virtual Int32 PageNumber { get; set; }

        ////////[DataMember(Order = 15, IsRequired = true)]
        public virtual String LocName { get; set; }
    }

    [Serializable]
    public class UspHuInventoriesDeatil : BaseModel
    {
        //////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////[DataMember(Order = 2, IsRequired = true)]
        public virtual string InBatchId { get; set; }

        //////////[DataMember(Order = 3, IsRequired = true)]
        public virtual string ItemId { get; set; }

        //////////[DataMember(Order = 4, IsRequired = false)]
        public virtual string CompId { get; set; }

        //////////[DataMember(Order = 5, IsRequired = true)]
        public virtual string UnitId { get; set; }

        //////////[DataMember(Order = 6, IsRequired = true)]
        public virtual double BalanceNum { get; set; }

        //////////[DataMember(Order = 7, IsRequired = true)]
        public virtual double StcokNum { get; set; }

        //////////[DataMember(Order = 8, IsRequired = true)]
        public virtual double InstoreNum { get; set; }

        //////////[DataMember(Order = 9, IsRequired = true)]
        public virtual double CheckNum { get; set; }

        //////////[DataMember(Order = 10, IsRequired = false)]
        public virtual double? PkNum { get; set; }

        //////////[DataMember(Order = 11, IsRequired = true)]
        public virtual double StockPrice { get; set; }

        //////////[DataMember(Order = 12, IsRequired = true)]
        public virtual double RetailPrice { get; set; }

        //////////[DataMember(Order = 13, IsRequired = true)]
        public virtual String compare { get; set; }

        //////////[DataMember(Order = 14, IsRequired = true)]
        public virtual Boolean IsBalance { get; set; }

        //////////[DataMember(Order = 15, IsRequired = false)]
        public virtual double? RetailPricePk { get; set; }

        //////////[DataMember(Order = 16, IsRequired = false)]
        public virtual double? StockPricePk { get; set; }

        //////////[DataMember(Order = 17, IsRequired = false)]
        public virtual double? RetailPriceCheck { get; set; }

        //////////[DataMember(Order = 18, IsRequired = false)]
        public virtual double? StockPriceCheck { get; set; }

        //////////[DataMember(Order = 19, IsRequired = false)]
        public virtual double? RetailPriceStcok { get; set; }

        //////////[DataMember(Order = 20, IsRequired = false)]
        public virtual double? StockPriceStcok { get; set; }

        //////////[DataMember(Order = 21, IsRequired = true)]
        public virtual String State { get; set; }

        //////////[DataMember(Order = 22, IsRequired = true)]
        public virtual String ItemCode { get; set; }

        //////////[DataMember(Order = 23, IsRequired = true)]
        public virtual String ItemName { get; set; }

        //////////[DataMember(Order = 24, IsRequired = true)]
        public virtual String AreaKc { get; set; }

        //////////[DataMember(Order = 25, IsRequired = true)]
        public virtual String Spec { get; set; }

        //////////[DataMember(Order = 26, IsRequired = true)]
        public virtual String PNo { get; set; }

        //////////[DataMember(Order = 27, IsRequired = false)]
        public virtual string FormId { get; set; }

        //////////[DataMember(Order = 28, IsRequired = true)]
        public virtual string BillId { get; set; }

        //////////[DataMember(Order = 29, IsRequired = true)]
        public virtual Boolean IsAdjust { get; set; }

        //////////[DataMember(Order = 30, IsRequired = true)]
        public virtual double BuyIn { get; set; }

        //////////[DataMember(Order = 31, IsRequired = true)]
        public virtual double BackIn { get; set; }

        //////////[DataMember(Order = 32, IsRequired = true)]
        public virtual double OtherIn { get; set; }

        //////////[DataMember(Order = 33, IsRequired = true)]
        public virtual double DeptOut { get; set; }

        //////////[DataMember(Order = 34, IsRequired = true)]
        public virtual double BackOut { get; set; }

        //////////[DataMember(Order = 35, IsRequired = true)]
        public virtual double SaleOut { get; set; }

        //////////[DataMember(Order = 36, IsRequired = true)]
        public virtual double LoseOut { get; set; }

        //////////[DataMember(Order = 37, IsRequired = true)]
        public virtual double AdjustAmouUp { get; set; }

        //////////[DataMember(Order = 38, IsRequired = true)]
        public virtual double AdjustAmouDn { get; set; }

        //////////[DataMember(Order = 39, IsRequired = false)]
        public virtual DateTime? LimitDate { get; set; }

        //////////[DataMember(Order = 40, IsRequired = true)]
        public virtual String IsGSJ { get; set; }

        //////////[DataMember(Order = 41, IsRequired = true)]
        public virtual String GroupSubname { get; set; }

        //////////[DataMember(Order = 42, IsRequired = false)]
        public virtual DateTime? CheckTime { get; set; }

        //////////[DataMember(Order = 43, IsRequired = false)]
        public virtual Int32 OrderBy { get; set; }

        //////////[DataMember(Order = 44, IsRequired = true)]
        public virtual String Feename { get; set; }

        //////////[DataMember(Order = 45, IsRequired = true)]
        public virtual String PackageSpec { get; set; }

        //////////[DataMember(Order = 46, IsRequired = true)]
        public virtual String CompanyName { get; set; }

        //////////[DataMember(Order = 47, IsRequired = false)]
        public virtual DateTime? OperTime { get; set; }

        //////////[DataMember(Order = 48, IsRequired = true)]
        public virtual String HouseName { get; set; }

        //////////[DataMember(Order = 49, IsRequired = true)]
        public virtual String UnitName { get; set; }
    }

    [Serializable]
    public class UspRmStoreExpireDateWarning : BaseModel
    {
        public virtual string GUID { get; set; }

        public virtual String InBatchNo { get; set; }

        public virtual String Code { get; set; }

        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual String RoomUnitName { get; set; }

        public virtual String CompanyName { get; set; }

        public virtual DateTime? StoreDate { get; set; }

        public virtual DateTime? LimitDate { get; set; }

        public virtual Int32? AheadAlert { get; set; }

        public virtual double StockNum { get; set; }

        public virtual double InStoreNUM { get; set; }

        public virtual double? StockPrice { get; set; }

        public virtual string RoomId { get; set; }

        public virtual String RoomName { get; set; }

        public virtual String PNO { get; set; }

        public virtual string StoresItemID { get; set; }

        public virtual String ManuName { get; set; }

        public virtual string UnitId { get; set; }

        public virtual double? RetailPrice { get; set; }

        public virtual double? DrugRatio { get; set; }

        public virtual Boolean? Selected { get; set; }

        public virtual Int32? LimitDate2 { get; set; }
    }

    [Serializable]
    public class UspRmStoreLogBatchActtypeSum : BaseModel
    {
        public virtual string GUID { get; set; }

        public virtual double? TotalRetail { get; set; }

        public virtual Int32 lsacttype { get; set; }
    }

    [Serializable]
    public class Uspmztobalancedtlnotpay : BaseModel
    {
        public virtual String name { get; set; }

        public virtual String spec { get; set; }

        public virtual String code { get; set; }

        public virtual string hospid { get; set; }

        public virtual string itemid { get; set; }

        public virtual DateTime regopertime { get; set; }

        public virtual string regoperid { get; set; }

        public virtual string locationid { get; set; }

        public virtual string adviceid { get; set; }

        public virtual Int32 lsmarktype { get; set; }

        public virtual double totality { get; set; }

        public virtual double pricein { get; set; }

        public virtual string unitid { get; set; }

        public virtual Boolean ispay { get; set; }

        public virtual double discin { get; set; }

        public virtual double discself { get; set; }

        public virtual double amount { get; set; }

        public virtual double amountfact { get; set; }

        public virtual double amountself { get; set; }

        public virtual double amounttally { get; set; }

        public virtual string invoid { get; set; }

        public virtual Int32 lsperform { get; set; }

        public virtual Boolean ismodidisc { get; set; }

        public virtual string limitgroupid { get; set; }

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

        public virtual String RegOperDate { get; set; }

        public virtual Int32 lsgftype { get; set; }

        public virtual double amountpay { get; set; }

        public virtual String bsinvinitemname { get; set; }

        public virtual String bszyfeetyname { get; set; }

        public virtual Boolean isbedfee { get; set; }

        public virtual String regdate { get; set; }

        public virtual string MainDoctorId { get; set; }

        public virtual double DiscountAoumt { get; set; }

        public virtual double DiscountPrice { get; set; }

        public virtual double ChildPrice { get; set; }
    }

    [Serializable]
    public class LabList : BaseModel
    {
        public virtual string PrintBy { get; set; }

        public virtual string YYName { get; set; }

        public virtual string YYAddress { get; set; }

        public virtual string YYOtherInfo { get; set; }

        public virtual string LabNum { get; set; }

        public virtual string HospNum { get; set; }

        public virtual string ChName { get; set; }

        public virtual string BloodSrc { get; set; }

        public virtual string Sex { get; set; }

        public virtual string Age { get; set; }

        public virtual DateTime DatCol { get; set; }

        public virtual string Priority { get; set; }

        public virtual string TestItems { get; set; }

        public virtual string Container { get; set; }

        public virtual string Location { get; set; }

        public virtual string BedNum { get; set; }

        public virtual string Title { get; set; }

        public virtual string LabRefName { get; set; }

        public virtual string TestDept { get; set; }

        public virtual byte LabNumBarCode { get; set; }

        public virtual string SampleNum { get; set; }

        public virtual string SequenceNum { get; set; }
    }

    [Serializable]
    public class UspCkLabRecieve : BaseModel
    {
        public virtual String LabNum { get; set; }

        public virtual String SendStatus { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual String CardNo { get; set; }

        public virtual String UserName { get; set; }

        public virtual string TestTypeId { get; set; }

        public virtual string MzRegId { get; set; }

        public virtual string HospId { get; set; }

        public virtual String LocationName { get; set; }

        public virtual Boolean IsMatch { get; set; }

        public virtual String ReportColName { get; set; }

        public virtual string PatId { get; set; }

        public virtual String PatientName { get; set; }

        public virtual String Sex { get; set; }

        public virtual String SexName { get; set; }

        public virtual Int32 Age { get; set; }

        public virtual String TestName { get; set; }

        public virtual Int32 AgeMonth { get; set; }

        public virtual String PRIORITY { get; set; }

        public virtual Int32 LsStatus { get; set; }

        public virtual DateTime SJOperTime { get; set; }

        public virtual Boolean IsPrint { get; set; }

        public virtual DateTime Birthday
        {
            get; set;
        }
    }

    [Serializable]
    public class UspBsItemSelect : BaseModel
    {
        public double AddPercent { get; set; }
        public int AheadAlert { get; set; }
        public string AreaKc { get; set; }
        public string BasalDrugType { get; set; }
        public string ChemName { get; set; }
        public string Code { get; set; }
        public string CompanyName { get; set; }
        public string CompId { get; set; }
        public double DiscDiag { get; set; }
        public double DiscIn { get; set; }
        public double Dosage { get; set; }
        public string DrugFormName { get; set; }
        public string DrugID { get; set; }
        public string EngDesc { get; set; }
        public string ExecLocId { get; set; }
        public string ExecLocName { get; set; }
        public string FeeHsMzId { get; set; }
        public string FeeHsMzName { get; set; }
        public string FeeHsZyId { get; set; }
        public string FeeHsZyName { get; set; }
        public string FeeMzId { get; set; }
        public string FeeMzName { get; set; }
        public string FeeZyId { get; set; }
        public string FeeZyName { get; set; }
        public string FormId { get; set; }
        public string FrequencyId { get; set; }
        public string FrequencyName { get; set; }
        public double GfFixDisc { get; set; }
        public string GroupMainId { get; set; }
        public string GroupName { get; set; }
        public string GroupSubId { get; set; }
        public string GroupSubName { get; set; }
        public string HouseId { get; set; }
        public string HouseName { get; set; }
        public int IconIndex { get; set; }
        public string InvInItemId { get; set; }
        public string InvInItemName { get; set; }
        public string InvMzItemId { get; set; }
        public string InvMzItemName { get; set; }
        public bool IsActive { get; set; }
        public bool IsBatch { get; set; }
        public bool IsBedFee { get; set; }
        public bool IsBid { get; set; }
        public bool IsChildAdd { get; set; }
        public bool IsExpen { get; set; }
        public bool IsInject { get; set; }
        public bool IsInoculate { get; set; }
        public bool IsLocDrug { get; set; }
        public bool IsMental { get; set; }
        public bool IsNew { get; set; }
        public bool IsOnlyForSys { get; set; }
        public bool IsOpsAdd { get; set; }
        public bool IsPoison { get; set; }
        public bool IsRecipe { get; set; }
        public bool IsRpForbid { get; set; }
        public bool IsSave { get; set; }
        public bool IsSelf { get; set; }
        public bool IsSpecial { get; set; }
        public double LimitFeeMz { get; set; }
        public double LimitFeeZy { get; set; }
        public string LimitGroupId { get; set; }
        public double LimitTotalMz { get; set; }
        public double LimitTotalZy { get; set; }
        public int LISCode { get; set; }
        public double LocationDosage { get; set; }
        public string LocationFrequencyId { get; set; }
        public string LocationFrequencyName { get; set; }
        public string LocationId { get; set; }
        public bool LocationIsLocDrug { get; set; }
        public string LocationName { get; set; }
        public string LocationUnitTakeId { get; set; }
        public string LocationUnitTakeName { get; set; }
        public string LocationUsageId { get; set; }
        public string LocationUsageName { get; set; }
        public string LongDesc { get; set; }
        public int LsAdviceType { get; set; }
        public int LsfeeTurn { get; set; }
        public int LsGfType { get; set; }
        public int LsGroupType { get; set; }
        public int LsImport { get; set; }
        public int LsRpType { get; set; }
        public string ManufacturerName { get; set; }
        public string ManuId { get; set; }
        public string Memo { get; set; }
        public string Name { get; set; }
        public double NormalLineKc { get; set; }
        public string OperName { get; set; }
        public int OrderBy { get; set; }
        public string OtherCode { get; set; }
        public string PassNo { get; set; }
        public string PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public double PriceDiag { get; set; }
        public double PriceIn { get; set; }
        public int ProArea { get; set; }
        public string ProvinceCode { get; set; }
        public string PyCode { get; set; }
        public double RetailPriceKc { get; set; }
        public string RoomIdIn { get; set; }
        public string RoomIdOut { get; set; }
        public string RoomInOut { get; set; }
        public string RoomNameOut { get; set; }
        public string Spec { get; set; }
        public double StockPriceKc { get; set; }
        public string StrokeCode { get; set; }
        public string Style { get; set; }
        public string TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public string TallyTypeId { get; set; }
        public string TypeGFXEId { get; set; }
        public string TypeGFXEName { get; set; }
        public double UnderLineKc { get; set; }
        public string UnitDiagId { get; set; }
        public string UnitDiagName { get; set; }
        public string UnitInId { get; set; }
        public string UnitInName { get; set; }
        public string UnitKc { get; set; }
        public string UnitKcName { get; set; }
        public string UnitTakeId { get; set; }
        public string UnitTakeName { get; set; }
        public double UperLineKc { get; set; }
        public string UsageId { get; set; }
        public string UsageName { get; set; }
        public string WbCode { get; set; }
        public string ZyGroupName { get; set; }
    }

    [Serializable]
    public partial class UspOuInvoiceDtlWithCheckLab : BaseModel
    {
        public UspOuInvoiceDtl uspOuInvoiceDtl { get; set; }

        public List<UspOuInvoiceDtl> lstUspOuInvoiceDtl { get; set; }

        public IList<UspOuCkeckItem> lstUspOuCkeckItem { get; set; }

        public IList<UspOuCkeckItemCompany> lstUspOuCkeckItemCompanyDto { get; set; }

        public IList<UspOuRecipeDtlForOuInvoiceDtl> lstUspOuRecipeDtlForOuInvoiceDtlDto { get; set; }

        public IList<BsLabSourceItem> lstSourceItem { get; set; }

        public virtual string SameItemId { get; set; }

        public virtual bool isTj { get; set; }
    }

    [Serializable]
    public class UspGetHistoryResult : BaseModel
    {

        public string GUID { get; set; }


        public string PatId { get; set; }


        public string ItemId { get; set; }


        public string LabId { get; set; }


        public DateTime? BirthDate { get; set; }


        public String ItemName { get; set; }


        public String PatName { get; set; }


        public String IdCardNo { get; set; }


        public String Phone { get; set; }


        public String CardNo { get; set; }


        public String Sex { get; set; }


        public String LabNum { get; set; }


        public String Result { get; set; }


        public String TextRange { get; set; }


        public String LastResult { get; set; }


        public double HighValue { get; set; }


        public double LowValue { get; set; }


        public double PanicLow { get; set; }


        public double PanicHigh { get; set; }


        public Boolean IsPanic { get; set; }


        public Boolean IsPass { get; set; }


        public DateTime? ResultTime { get; set; }


        public String ResultOperCode { get; set; }


        public String ResultOperName { get; set; }


        public String Deviate { get; set; }


        public String AuthDocName { get; set; }
    }


    [Serializable]
    public class TestSystemWithModiyLabResult : BaseModel
    {

        public string FromNum { set; get; }


        public string ToNum { set; get; }


        public string MachineID { set; get; }


        public double EditValue { set; get; }


        public double Result { set; get; }


        public string TestId { set; get; }


        public bool Checked { set; get; }


        public string UicItemId { set; get; }


        public string CCKMachinePassageId { set; get; }
    }

    [Serializable]
    public class TestSystemWithByCKMachineResult : BaseModel
    {

        public string labID { set; get; }


        public string testTypeID { set; get; }


        public string machineID { set; get; }


        public string testID { set; get; }

    }

    [Serializable]
    public class temp_DataCheckLog : BaseModel
    {
        #region 构造函数
        /// <summary>
        ///  构造函数
        /// </summary>
        public temp_DataCheckLog()
        {
        }
        #endregion

        #region 字段  ColName, ContentText, ErrorCode, ErrorRows, Id, IsHint, OperTime, ProblemText, TabName


        public string GUID { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public string ColName { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public string ContentText { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public string ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public int? ErrorRows { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public Boolean? IsHint { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public DateTime? OperTime { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public string ProblemText { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public string TabName { get; set; }

        #endregion
    }

    [Serializable]
    public class CUspCkLabByOpertimeAndLsStatus : BaseModel
    {

        public string GUID { get; set; }


        public String LabNum { get; set; }


        public string PatId { get; set; }


        public Int32 LsStatus { get; set; }


        public DateTime? OperTime { get; set; }


        public string LabId { get; set; }


        public String PatientName { get; set; }


        public Boolean? IsPass { get; set; }


        public Boolean IsCancel { get; set; }


        public Boolean IsPriority { get; set; }


        public string LocationId { get; set; }


        public Int32 LsSource { get; set; }


        public string DoctorId { get; set; }


        public string HospId { get; set; }


        public string MzRegId { get; set; }


        public String Sex { get; set; }


        public string MachineID { get; set; }


        public String SexName { get; set; }


        public string ReportOperId { get; set; }


        public DateTime? BirthDate { get; set; }


        public Int32? Age { get; set; }


        public Int32? AgeMonth { get; set; }


        public String PatientNameModi { get; set; }


        public Int32? SampleNo { get; set; }


        public String TestName { get; set; }


        public Boolean? IsPrint { get; set; }


        public string Name { get; set; }
    }

    [Serializable]
    public class UspCkFindLasnntCheckMethod : BaseModel
    {

        public string GUID { get; set; }


        public string LabId { get; set; }


        public String Result { get; set; }


        public Int32 LsRefFlag { get; set; }


        public String Unit { get; set; }


        public Boolean IsPanic { get; set; }


        public Boolean IsDalta { get; set; }


        public double DalAbsolute { get; set; }


        public string TestId { get; set; }


        public double LowValue { get; set; }


        public double HighValue { get; set; }


        public double DalPercent { get; set; }


        public double PanicLow { get; set; }


        public double PanicHigh { get; set; }


        public string PatId { get; set; }


        public String AuthDocName { get; set; }


        public DateTime? AuthDocTime { get; set; }
    }

    [Serializable]
    public class UspCompanyGroup : BaseModel
    {
        public string GUID { get; set; }
        public string CompanyId { get; set; }
        public string GroupId { get; set; }
        public String Name { get; set; }
        public string GroupDepartmentId { get; set; }
        public string PatName { get; set; }
    }


    [Serializable]
    public class UspCheckPatinfo : BaseModel
    {

        public string GUID { get; set; }


        public String InPatNo { get; set; }


        public String CardNo { get; set; }


        public String Name { get; set; }


        public String Sex { get; set; }


        public Int32? Age { get; set; }


        public Int32? LsMarriage { get; set; }


        public String Marriage { get; set; }


        public String Native { get; set; }


        public string PatTypeId { get; set; }


        public String IdCardNo { get; set; }


        public String LinkmanAddress { get; set; }


        public String LinkmanPhone { get; set; }


        public string LevelId { get; set; }


        public DateTime? CheckTime { get; set; }


        public string CompanyCkeckId { get; set; }


        public DateTime? OperTime { get; set; }


        public String CheckNo { get; set; }


        public String PhotoFolder { get; set; }


        public string OperId { get; set; }


        public string WorktypeId { get; set; }


        public String CompanyName { get; set; }


        public String Code { get; set; }


        public String Type { get; set; }
    }

    [Serializable]
    public class UspCkProfile : BaseModel
    {

        public string GUID { get; set; }


        public string TestId { get; set; }


        public String Code { get; set; }


        public Int32 LsTestType { get; set; }


        public string TestTypeId { get; set; }


        public string TubeTypeId { get; set; }


        public String ShortName { get; set; }


        public String Name { get; set; }


        public String OperMemo { get; set; }


        public Boolean IsZero { get; set; }


        public Int32 LsGroup { get; set; }


        public Boolean IsReport { get; set; }


        public String UseRange { get; set; }


        public Int32 LsForSex { get; set; }


        public double Price { get; set; }


        public String Unit { get; set; }


        public String Format { get; set; }


        public double LimitHigh { get; set; }


        public double LimitLow { get; set; }


        public String PrintHigh { get; set; }


        public String PrintLow { get; set; }


        public double DalAbsolute { get; set; }


        public double DalPercent { get; set; }


        public string ItemId { get; set; }


        public Int32 OrderBy { get; set; }


        public Boolean IsDisplay { get; set; }


        public Boolean IsActive { get; set; }


        public string ProfileId { get; set; }


        public String TestTypeName { get; set; }


        public string SourceId { get; set; }


        public String SourceName { get; set; }
    }

    [Serializable]
    public class UspCkCompanyGroupTree : BaseModel
    {

        public Int32? iSelect { get; set; }


        public string GUID { get; set; }


        public string AsId { get; set; }


        public string ParentID { get; set; }


        public String Code { get; set; }


        public Int32 LsGroup { get; set; }


        public String Name { get; set; }


        public string TestId { get; set; }


        public string TestTypeId { get; set; }


        public string CompanyGroupId { get; set; }


        public string SourceId { get; set; }


        public String TestTypeName { get; set; }


        public double Price { get; set; }


        public string GroupItemID { get; set; }


        public String ItemId { get; set; }


        public String AppId { get; set; }
    }

    [Serializable]
    public class UspCkMainNotAuthorized : BaseModel
    {

        public string GUID { get; set; }


        public String CheckNo { get; set; }


        public string PatId { get; set; }


        public Int32? LsStatus { get; set; }


        public DateTime? OperTime { get; set; }


        public String PatientName { get; set; }


        public Boolean IsCancel { get; set; }


        public String PatCard { get; set; }


        public String CompanyName { get; set; }


        public String Marrage { get; set; }


        public string LocationId { get; set; }


        public string DoctorId { get; set; }


        public string CompanyCkeckId { get; set; }


        public String Sex { get; set; }


        public String SexName { get; set; }


        public DateTime? BirthDate { get; set; }


        public Int32? Age { get; set; }


        public Int32? AgeMonth { get; set; }


        public DateTime? CheckTime { get; set; }


        public string OperId { get; set; }


        public DateTime? CancelOperTime { get; set; }


        public string CancelOperId { get; set; }


        public String CancelMemo { get; set; }


        public DateTime? RecieveTime { get; set; }


        public string RecieveOperId { get; set; }


        public DateTime? ReportTime { get; set; }


        public string ReportOperId { get; set; }


        public String ReportMemo { get; set; }


        public String TechMemo { get; set; }


        public String OtherMemo { get; set; }


        public string CompanyId { get; set; }


        public String Type { get; set; }


        public String Code { get; set; }


        public String Residence { get; set; }


        public String RptFileName { get; set; }
    }

    [Serializable]
    public class UspCkMainAuthorized : BaseModel
    {

        public string GUID { get; set; }


        public String CheckNo { get; set; }


        public string PatId { get; set; }


        public Int32? LsStatus { get; set; }


        public DateTime? OperTime { get; set; }


        public String PatientName { get; set; }


        public Boolean IsCancel { get; set; }


        public String PatCard { get; set; }


        public String CompanyName { get; set; }


        public String Marrage { get; set; }


        public string LocationId { get; set; }


        public string DoctorId { get; set; }


        public string CompanyCkeckId { get; set; }


        public String Sex { get; set; }


        public String SexName { get; set; }


        public DateTime? BirthDate { get; set; }


        public Int32? Age { get; set; }


        public Int32? AgeMonth { get; set; }


        public DateTime? CheckTime { get; set; }


        public string OperId { get; set; }


        public DateTime? CancelOperTime { get; set; }


        public string CancelOperId { get; set; }


        public String CancelMemo { get; set; }


        public DateTime? RecieveTime { get; set; }


        public string RecieveOperId { get; set; }


        public DateTime? ReportTime { get; set; }


        public string ReportOperId { get; set; }


        public String ReportMemo { get; set; }


        public String TechMemo { get; set; }


        public String OtherMemo { get; set; }


        public string CompanyId { get; set; }


        public String Type { get; set; }


        public String Code { get; set; }


        public String Residence { get; set; }


        public String RptFileName { get; set; }
    }

    [Serializable]
    public class UspCkMainNotSaver : BaseModel
    {

        public string GUID { get; set; }


        public String CheckNo { get; set; }


        public string PatId { get; set; }


        public Int32? LsStatus { get; set; }


        public DateTime? OperTime { get; set; }


        public String PatientName { get; set; }


        public Boolean IsCancel { get; set; }


        public String PatCard { get; set; }


        public String CompanyName { get; set; }


        public String Marrage { get; set; }


        public string LocationId { get; set; }


        public string DoctorId { get; set; }


        public string CompanyCkeckId { get; set; }


        public String Sex { get; set; }


        public String SexName { get; set; }


        public DateTime? BirthDate { get; set; }


        public Int32? Age { get; set; }


        public Int32? AgeMonth { get; set; }


        public DateTime? CheckTime { get; set; }


        public string OperId { get; set; }


        public DateTime? CancelOperTime { get; set; }


        public string CancelOperId { get; set; }


        public String CancelMemo { get; set; }


        public DateTime? RecieveTime { get; set; }


        public string RecieveOperId { get; set; }


        public DateTime? ReportTime { get; set; }


        public string ReportOperId { get; set; }


        public String ReportMemo { get; set; }


        public String TechMemo { get; set; }


        public String OtherMemo { get; set; }


        public string CompanyId { get; set; }


        public String Type { get; set; }


        public String Code { get; set; }


        public String Residence { get; set; }


        public String RptFileName { get; set; }
    }

    [Serializable]
    public class UspCkMainByOpertimeAndLsStatus : BaseModel
    {

        public string GUID { get; set; }


        public string CheckId { get; set; }


        public String CheckNo { get; set; }


        public string PatId { get; set; }


        public DateTime? OperTime { get; set; }


        public String PatientName { get; set; }


        public Boolean IsCancel { get; set; }


        public String PatCard { get; set; }


        public String CompanyName { get; set; }


        public String Marrage { get; set; }


        public string LocationId { get; set; }


        public string DoctorId { get; set; }


        public string CompanyCkeckId { get; set; }


        public String Sex { get; set; }


        public String SexName { get; set; }


        public String Mobile { get; set; }


        public DateTime? BirthDate { get; set; }


        public Int32? Age { get; set; }


        public Int32? AgeMonth { get; set; }


        public String CheckDesc { get; set; }


        public String DoctorAdvice { get; set; }


        public String Summary { get; set; }


        public DateTime? CheckTime { get; set; }


        public string OperId { get; set; }


        public DateTime? CancelOperTime { get; set; }


        public string CancelOperId { get; set; }


        public String CancelMemo { get; set; }


        public DateTime? RecieveTime { get; set; }


        public string RecieveOperId { get; set; }


        public DateTime? ReportTime { get; set; }


        public string ReportOperId { get; set; }


        public String ReportMemo { get; set; }


        public String TechMemo { get; set; }


        public String OtherMemo { get; set; }


        public string CompanyId { get; set; }


        public string TestGroupId { get; set; }


        public Int32? LsStatus { get; set; }


        public DateTime? ResultTime { get; set; }


        public string ResultOperId { get; set; }


        public DateTime? AuthTime { get; set; }


        public string AuthOperId { get; set; }


        public String Type { get; set; }


        public String Code { get; set; }


        public String TestGroupName { get; set; }


        public String Mobile1 { get; set; }
    }

    [Serializable]
    public class UspCkResultTestGroupId : BaseModel
    {

        public string GUID { get; set; }


        public string CheckId { get; set; }


        public string TestId { get; set; }


        public String LastResult { get; set; }


        public String Result { get; set; }


        public Int32? LsRefFlag { get; set; }


        public Boolean? IsPanic { get; set; }


        public Boolean? IsDalta { get; set; }


        public double? DalAbsolute { get; set; }


        public double? DalPercent { get; set; }


        public double? LowValue { get; set; }


        public double? HighValue { get; set; }


        public double? PanicLow { get; set; }


        public double? PanicHigh { get; set; }


        public Boolean? IsPass { get; set; }


        public DateTime? ReportDate { get; set; }


        public String ReportBy { get; set; }


        public Boolean? IsPrint { get; set; }


        public String Memo { get; set; }


        public string ParentID { get; set; }


        public String TextRange { get; set; }


        public double? Price { get; set; }


        public double? Discount { get; set; }


        public string TestGroupId { get; set; }


        public string ItemId { get; set; }


        public string AppId { get; set; }


        public Boolean IsAuthed { get; set; }


        public String Code { get; set; }


        public String TestName { get; set; }


        public String HighLow { get; set; }


        public String IsDangerous { get; set; }


        public String Compare { get; set; }


        public String NormalRange { get; set; }


        public Int32 OrderBy { get; set; }
    }

    [Serializable]
    public class UspCkFindLastResultOfTestForPatient : BaseModel
    {

        public string GUID { get; set; }


        public string LabId { get; set; }


        public String Result { get; set; }


        public Int32 LsRefFlag { get; set; }


        public String Unit { get; set; }


        public Boolean IsPanic { get; set; }


        public Boolean IsDalta { get; set; }


        public double DalAbsolute { get; set; }


        public string TestId { get; set; }


        public double LowValue { get; set; }


        public double HighValue { get; set; }


        public double DalPercent { get; set; }


        public double PanicLow { get; set; }


        public double PanicHigh { get; set; }


        public string PatId { get; set; }
    }

    [Serializable]
    public class UspCkPersonalItemTree : BaseModel
    {

        public Int32? iSelect { get; set; }


        public string GUID { get; set; }


        public string AsId { get; set; }


        public String Code { get; set; }


        public Int32 LsGroup { get; set; }


        public String Name { get; set; }


        public string ItemId { get; set; }


        public string TestTypeId { get; set; }


        public string SourceId { get; set; }


        public String TestTypeName { get; set; }


        public double? Price { get; set; }


        public string ParentID { get; set; }


        public string TestId { get; set; }


        public string GroupItemID { get; set; }


        public string AppId { get; set; }
    }

    [Serializable]
    public class UspCkLabSearch : BaseModel
    {

        public string GUID { get; set; }


        public String LabNum { get; set; }


        public string PatId { get; set; }


        public string MzRegId { get; set; }


        public string HospId { get; set; }


        public Int32 LsSource { get; set; }


        public string LocationId { get; set; }


        public string DoctorId { get; set; }


        public String Diagnose { get; set; }


        public Boolean IsCancel { get; set; }


        public Int32 LsStatus { get; set; }


        public string TestTypeId { get; set; }


        public DateTime OperTime { get; set; }


        public string OperId { get; set; }


        public DateTime CollectTime { get; set; }


        public string CollectOperId { get; set; }


        public DateTime? RecieveTime { get; set; }


        public string RecieveOperId { get; set; }


        public DateTime ResultTime { get; set; }


        public string ResultOperId { get; set; }


        public DateTime AuthTime { get; set; }


        public string AuthOperId { get; set; }


        public DateTime ReportTime { get; set; }


        public string ReportOperId { get; set; }


        public String RecieveOperName { get; set; }


        public String AuthOperName { get; set; }


        public String ReportOperName { get; set; }


        public Boolean? IsRecieve { get; set; }


        public String BedName { get; set; }


        public String PatientName { get; set; }


        public String CardNo { get; set; }


        public String SexName { get; set; }


        public Int32? Age { get; set; }


        public String MzRegNo { get; set; }


        public String InPatNo { get; set; }


        public String DoctorName { get; set; }


        public String LocationName { get; set; }


        public String TestName { get; set; }
    }

    [Serializable]
    public class PrintWhitPrintSendLabList : BaseModel
    {
        public InHosInfo InfoInHos { set; get; }
        public IList<CkLabDtl> LstCkLabDtl { set; get; }
        public string InfoBsBed { set; get; }
        public string InfoCkTestType { set; get; }
        public string InfoBsLabSource { set; get; }
        public string InPatNo { set; get; }
        public string OuHosInfo { set; get; }


    }

    [Serializable]
    public class UspCkLabSearchDtl : BaseModel
    {

        public string GUID { get; set; }


        public string LabId { get; set; }


        public string TestId { get; set; }


        public string SourceId { get; set; }


        public string TubeTypeId { get; set; }


        public String Code { get; set; }


        public String Name { get; set; }


        public double Price { get; set; }


        public String LabLocation { get; set; }
    }

    [Serializable]
    public class UspCkMachineResult : BaseModel
    {

        public string GUID { get; set; }


        public string MachineID { get; set; }


        public string TestTypeID { get; set; }


        public DateTime TestDate { get; set; }


        public String SampleNum { get; set; }


        public String Name { get; set; }


        public String Unit { get; set; }


        public String Result { get; set; }


        public String Code { get; set; }


        public string TestID { get; set; }
    }




    [Serializable]
    public class UspCkLabDtlForLabResult : BaseModel
    {

        public string GUID { get; set; }


        public String Code { get; set; }


        public Int32 LsTestType { get; set; }


        public string TestTypeId { get; set; }


        public String TestName { get; set; }


        public String Name { get; set; }


        public String OperMemo { get; set; }


        public Boolean IsZero { get; set; }


        public Int32 LsGroup { get; set; }


        public Boolean IsReport { get; set; }


        public String UseRange { get; set; }


        public Int32 LsForSex { get; set; }


        public double Price { get; set; }


        public String Unit { get; set; }


        public String Format { get; set; }


        public double LimitHigh { get; set; }


        public double LimitLow { get; set; }


        public String PrintHigh { get; set; }


        public String PrintLow { get; set; }


        public double DalAbsolute { get; set; }


        public double DalPercent { get; set; }


        public string ItemId { get; set; }


        public Int32 OrderBy { get; set; }


        public Boolean IsDisplay { get; set; }


        public Boolean IsActive { get; set; }


        public string LabId { get; set; }


        public string TestId { get; set; }


        public Int32 LsStatus { get; set; }


        public string SourceId { get; set; }


        public string TubeTypeId { get; set; }


        public string PatId { get; set; }


        public double? LowValue { get; set; }


        public double? HighValue { get; set; }


        public String NormalRange { get; set; }
    }

    [Serializable]
    public class PhysicalExaminationWithGetByLabNum : BaseModel
    {
        public IList<UspCkLabRecieve> LstFinished { set; get; }
        public IList<UspCkLabRecieve> LstCkLab { set; get; }
        public IList<UspCkLabRecieve> LstNotFinished { set; get; }

    }

    [Serializable]
    public class UspCkLabByOpertimeAndLsStatus : BaseModel
    {
       

        public List<ResultSetModel1> ResultSet1;

        public class ResultSetModel2 : BaseModel
        {

            public string GUID { get; set; }


            public String LabNum { get; set; }


            public string PatId { get; set; }


            public Int32 LsStatus { get; set; }


            public DateTime? OperTime { get; set; }


            public string LabId { get; set; }


            public String PatientName { get; set; }


            public Boolean? IsPass { get; set; }


            public Boolean IsCancel { get; set; }


            public Boolean IsPriority { get; set; }


            public string LocationId { get; set; }


            public Int32 LsSource { get; set; }


            public string DoctorId { get; set; }


            public string HospId { get; set; }


            public string MzRegId { get; set; }


            public String Sex { get; set; }


            public string MachineID { get; set; }


            public String SexName { get; set; }


            public string ReportOperId { get; set; }


            public DateTime? BirthDate { get; set; }


            public Int32? Age { get; set; }


            public Int32? AgeMonth { get; set; }


            public String PatientNameModi { get; set; }


            public Int32? SampleNo { get; set; }


            public String TestName { get; set; }


            public Boolean? IsPrint { get; set; }
        }

        public List<ResultSetModel2> ResultSet2;

        public class ResultSetModel3 : BaseModel
        {

            public string GUID { get; set; }


            public String LabNum { get; set; }


            public string PatId { get; set; }


            public Int32 LsStatus { get; set; }


            public DateTime? OperTime { get; set; }


            public String PatientName { get; set; }


            public Boolean? IsPass { get; set; }


            public Boolean IsCancel { get; set; }


            public Boolean IsPriority { get; set; }


            public string LocationId { get; set; }


            public Int32 LsSource { get; set; }


            public string DoctorId { get; set; }


            public string HospId { get; set; }


            public string MzRegId { get; set; }


            public String Sex { get; set; }


            public string MachineID { get; set; }


            public String SexName { get; set; }


            public string ReportOperId { get; set; }


            public DateTime? BirthDate { get; set; }


            public Int32? Age { get; set; }


            public Int32? AgeMonth { get; set; }


            public String PatientNameModi { get; set; }


            public Int32? SampleNo { get; set; }


            public String TestName { get; set; }


            public Boolean? IsPrint { get; set; }
        }

        public List<ResultSetModel3> ResultSet3;

        public class ResultSetModel4 : BaseModel
        {

            public string GUID { get; set; }


            public String LabNum { get; set; }


            public string PatId { get; set; }


            public Int32 LsStatus { get; set; }


            public DateTime? OperTime { get; set; }


            public String PatientName { get; set; }


            public Boolean? IsPass { get; set; }


            public Boolean IsCancel { get; set; }


            public Boolean IsPriority { get; set; }


            public string LocationId { get; set; }


            public Int32 LsSource { get; set; }


            public string DoctorId { get; set; }


            public string HospId { get; set; }


            public string MzRegId { get; set; }


            public String Sex { get; set; }


            public string MachineID { get; set; }


            public String SexName { get; set; }


            public string ReportOperId { get; set; }


            public DateTime? BirthDate { get; set; }


            public Int32? Age { get; set; }


            public Int32? AgeMonth { get; set; }


            public String PatientNameModi { get; set; }


            public Int32? SampleNo { get; set; }


            public String TestName { get; set; }


            public Boolean? IsPrint { get; set; }
        }

        public List<ResultSetModel4> ResultSet4;

        public class ResultSetModel5 : BaseModel
        {

            public string GUID { get; set; }


            public String LabNum { get; set; }


            public string PatId { get; set; }


            public Int32? LsStatus { get; set; }


            public DateTime? OperTime { get; set; }


            public String PatientName { get; set; }


            public Boolean? IsPass { get; set; }


            public Boolean? IsCancel { get; set; }


            public Boolean? IsPriority { get; set; }


            public string LocationId { get; set; }


            public Int32? LsSource { get; set; }


            public string DoctorId { get; set; }


            public string HospId { get; set; }


            public string MzRegId { get; set; }


            public String Sex { get; set; }


            public string MachineID { get; set; }


            public String SexName { get; set; }


            public string ReportOperId { get; set; }


            public DateTime? BirthDate { get; set; }


            public Int32? Age { get; set; }


            public Int32? AgeMonth { get; set; }


            public String PatientNameModi { get; set; }


            public Int32? SampleNo { get; set; }


            public String TestName { get; set; }


            public Boolean? IsPrint { get; set; }
        }

        public List<ResultSetModel5> ResultSet5;
    }

    public class ResultSetModel1 : BaseModel
    {

        public string GUID { get; set; }


        public String LabNum { get; set; }


        public string PatId { get; set; }


        public Int32 LsStatus { get; set; }


        public DateTime? OperTime { get; set; }


        public string LabId { get; set; }


        public String PatientName { get; set; }


        public Boolean? IsPass { get; set; }


        public Boolean IsCancel { get; set; }


        public Boolean IsPriority { get; set; }


        public string LocationId { get; set; }


        public Int32 LsSource { get; set; }


        public string DoctorId { get; set; }


        public string HospId { get; set; }


        public string MzRegId { get; set; }


        public String Sex { get; set; }


        public string MachineID { get; set; }


        public String SexName { get; set; }


        public string ReportOperId { get; set; }


        public DateTime? BirthDate { get; set; }


        public Int32? Age { get; set; }


        public Int32? AgeMonth { get; set; }


        public String PatientNameModi { get; set; }


        public Int32? SampleNo { get; set; }


        public String TestName { get; set; }


        public Boolean? IsPrint { get; set; }
    }

    [Serializable]
    public class PhysicalExaminationWithAddPatient : BaseModel
    {
        public string Patientname { set; get; }
        public string UddSex { set; get; }
        public string RefLocation { set; get; }
        public string Diagnose { set; get; }
        public short LsSource { set; get; }
        public string LocationId { set; get; }
        public string DoctorId { set; get; }
        public string UserID { set; get; }
        public int TestType { set; get; }
        public ResultSetModel1 InfoCrrentLab { set; get; }
    }

    [Serializable]
    public class PhysicalExaminationWithGetCkResultDtl : BaseModel
    {
        public IList<UspCkLabSearchDtl> LstUspCkLabSearchDtl { set; get; }
        public IList<UspCkResultDtl> LstUspCkResultDtl { set; get; }
    }

    [Serializable]
    public class UspCompanyCkeckTreeNew : BaseModel
    {

        public String GUID { get; set; }


        public String Name { get; set; }


        public String ParentID { get; set; }


        public Int32? OrderBy { get; set; }
    }

    [Serializable]
    public class UspCkResultList : BaseModel
    {
        public string GUID { get; set; }
        public String AsId { get; set; }
        public String Code { get; set; }
        public Int32 LsTestType { get; set; }
        public Int32? LsStatus { get; set; }
        public string XDRpId { get; set; }
        public string TestTypeId { get; set; }
        public String ShortName { get; set; }
        public String Name { get; set; }
        public String OperMemo { get; set; }
        public Int32 LsGroup { get; set; }
        public double Price { get; set; }
        public String Unit { get; set; }
        public Boolean IsActive { get; set; }
        public string TestId { get; set; }
        public String TestTypeName { get; set; }
        public string ParentID { get; set; }
        public string CheckId { get; set; }
    }

    [Serializable]
    public class UspCkMainNotRecieve : BaseModel
    {
        public string GUID { get; set; }
        public String CheckNo { get; set; }
        public String SendStatus { get; set; }
        public DateTime? OperTime { get; set; }
        public string PatId { get; set; }
        public String CardNo { get; set; }
        public String PatientName { get; set; }
        public String UserName { get; set; }
        public DateTime? RecieveTime { get; set; }
        public String LocationName { get; set; }
        public Boolean? IsMatch { get; set; }
        public Int32? LsStatus { get; set; }
        public String CompanyName { get; set; }
    }


    // Socket请求类
    [Serializable]
    public class SocketRequest : BaseModel
    {
        public SocketRequest()
        {
            Params = new NameValueCollection();
        }
        /// <summary>
        /// SuperSocket.Protocol 关键字 可选
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 区域
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// 方法
        /// </summary>
        public string Method { get; set; }
        /// <summary>
        /// 输入参数集合
        /// </summary>
        public NameValueCollection Params { get; set; }
    }


    [Serializable]
    public class SocketResponse : BaseModel
    {
        #region 构造函数
        /// <summary>
        /// Socket接收类
        /// </summary>
        public SocketResponse()
        {
            Params = new NameValueCollection();
        }
        #endregion

        /// <summary>
        /// 状态：成功,失败
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public string Result { get; set; }
        /// <summary>
        /// 输出参数集合
        /// </summary>
        public NameValueCollection Params { get; set; }
    }





    [Serializable]
    public class UspInSendDrugClassPrint : IEqualityComparer<UspInSendDrugClassPrint>
    {
        public bool Equals(UspInSendDrugClassPrint m1, UspInSendDrugClassPrint m2)
        {
            return (m1.GUID == m2.GUID);
        }

        public int GetHashCode(UspInSendDrugClassPrint m)
        {
            return m.ToString().GetHashCode();
        }

        ////////////////////////////////[DataMemberr(Order = 1, IsRequired = true)]
        public string GUID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string PatID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String LocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String HospNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String PatientName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String IdCardNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public String ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public double Totality { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public string UnitReq { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = false)]
        public double Dosage { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public string BedId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public Boolean IsPrint { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = false)]
        public double PriceIn { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = false)]
        public double Amount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public int LsMarkType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public string LocationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public String ItemCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public DateTime ForDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public String RequestNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public string RoomId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = false)]
        public double Times { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public string HospId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = false)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public String UnitReqName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public string RequestId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public Boolean IsIssued { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public Int32 ListNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public string AdviceId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = false)]
        public string UnitTake { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public Boolean IsConfirm { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = false)]
        public string ConfirmOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public String ConfirmOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = false)]
        public string DetailId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = false)]
        public string UsageId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public string FrequencyId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public int GroupNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = false)]
        public string ExecuteId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public String FrequencyName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41, IsRequired = false)]
        public Boolean GroupId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42, IsRequired = false)]
        public Boolean IsPoison { get; set; }

        ////////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public Boolean IsExpen { get; set; }

        ////////////////////////////////[DataMemberr(Order = 44, IsRequired = false)]
        public Boolean IsMental { get; set; }

        ////////////////////////////////[DataMemberr(Order = 45, IsRequired = true)]
        public String DoctorName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 46, IsRequired = true)]
        public String UnitTakeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 47, IsRequired = false)]
        public Boolean IsAttach { get; set; }

        ////////////////////////////////[DataMemberr(Order = 48, IsRequired = true)]
        public String UsageName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 49, IsRequired = false)]
        public string OperID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 50, IsRequired = false)]
        public Int32 age { get; set; }

        ////////////////////////////////[DataMemberr(Order = 51, IsRequired = true)]
        public String AgeString { get; set; }

        ////////////////////////////////[DataMemberr(Order = 52, IsRequired = true)]
        public String BedName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 53, IsRequired = true)]
        public string PatTypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 54, IsRequired = true)]
        public String Sex { get; set; }

        ////////////////////////////////[DataMemberr(Order = 55, IsRequired = false)]
        public string DoctorId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 56, IsRequired = true)]
        public String GroupName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 57, IsRequired = true)]
        public String Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 58, IsRequired = true)]
        public String GroupTitle { get; set; }

        ////////////////////////////////[DataMemberr(Order = 59, IsRequired = false)]
        public int OrderBy { get; set; }

        ////////////////////////////////[DataMemberr(Order = 60, IsRequired = false)]
        public int FirstDay { get; set; }

        ////////////////////////////////[DataMemberr(Order = 61, IsRequired = false)]
        public int LsSecMarkType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 62, IsRequired = false)]
        public Boolean Refusal { get; set; }

        ////////////////////////////////[DataMemberr(Order = 63, IsRequired = true)]
        public String AdviceMemo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 64, IsRequired = true)]
        public String LocationOrderby { get; set; }

        ////////////////////////////////[DataMemberr(Order = 65, IsRequired = true)]
        public String UsageMemo { get; set; }
    }

    [Serializable]
    public class UspSelectHuNotAuthorizeQry : BaseModel
    {
        private string _billNo = String.Empty;
        private string _houseId;
        private string _operId;
        private DateTime _operTime;
        private bool _isSign;
        private double _retailTotle;
        private double _stockTotle;
        private string _type = String.Empty;
        private int _lsActType;
        private DateTime _signTime;
        private string _name = String.Empty;



        #region Public Properties
        /// <summary>
        /// 单据编号
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }
        /// <summary>
        /// 仓库GUID
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }
        /// <summary>
        /// 制单人
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string OperName { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }
        /// <summary>
        /// 是否已审核：0:未审核,1:已审核
        /// </summary>
        public bool IsSign
        {
            get { return _isSign; }
            set { _isSign = value; }
        }
        /// <summary>
        /// 零售总金额
        /// </summary>
        public double RetailTotle
        {
            get { return _retailTotle; }
            set { _retailTotle = value; }
        }
        /// <summary>
        /// 买入总金额
        /// </summary>
        public double StockTotle
        {
            get { return _stockTotle; }
            set { _stockTotle = value; }
        }
        /// <summary>
        /// 类型
        /// (比如：领用退库,调拨入库,采购计划..)
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        /// <summary>
        /// 出入库类别
        /// </summary>
        public int LsActType
        {
            get { return _lsActType; }
            set { _lsActType = value; }
        }
        /// <summary>
        /// 出入库时间
        /// </summary>
        public DateTime SignTime
        {
            get { return _signTime; }
            set { _signTime = value; }
        }
        /// <summary>
        /// 出库备注
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion
    }


    #region UspHuLsImport

    [Serializable]
    public class UspHuLsImport : BaseModel
    {
        //////////////////////////////[DataMember(Order = 1, IsRequired = false)]
        public virtual DateTime? BeginTime { get; set; }

        //////////////////////////////[DataMember(Order = 2, IsRequired = false)]
        public virtual DateTime? EndTime { get; set; }

        //////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String OperName { get; set; }

        //////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String HouseName { get; set; }

        //////////////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual String Import { get; set; }

        //////////////////////////////[DataMember(Order = 6, IsRequired = false)]
        public virtual double? InStockAmount { get; set; }

        //////////////////////////////[DataMember(Order = 7, IsRequired = false)]
        public virtual double? OutStockAmount { get; set; }
    }

    #endregion UspHuLsImport

    #region UspHuOutBarCode

    [Serializable]
    public class UspHuOutBarCode : BaseModel
    {
        //////////////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual String BillNo { get; set; }

        //////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual Byte[] Image { get; set; }

        //////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String RoomName { get; set; }

        //////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String Name { get; set; }

        //////////////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual double Num { get; set; }
    }

    #endregion UspHuOutBarCode

    [Serializable]
    public class UspOuRecipeDtlSelectByMzRegId : BaseModel
    {
        public virtual string GUID { get; set; }
        public virtual string RecipeId { get; set; }

        public virtual Int32 GroupNum { get; set; }

        public virtual string ItemId { get; set; }

        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual string FormId { get; set; }

        public virtual double PriceDiag { get; set; }

        public virtual double Dosage { get; set; }

        public virtual string UnitTakeId { get; set; }

        public virtual string FrequencyId { get; set; }

        public virtual double StockNum { get; set; }
        public virtual string UsageId { get; set; }

        public virtual double InStoreNUM { get; set; }
        public virtual double ExeTimes { get; set; }

        public virtual double TotalDosage { get; set; }
        public virtual double? StockPrice { get; set; }

        public virtual double Totality { get; set; }

        public virtual double Amount { get; set; }

        public virtual string UnitDiagId { get; set; }

        public virtual Boolean IsAttach { get; set; }

        public virtual Int32 LsGfType { get; set; }

        public virtual Int32 Days { get; set; }

        public virtual double? RetailPrice { get; set; }
        public virtual Int32 ListNum { get; set; }

        public virtual double? DrugRatio { get; set; }
        public virtual string XDRpId { get; set; }

        public virtual String Memo { get; set; }

        public virtual string ApplyId { get; set; }

        public virtual String YbType { get; set; }

        public virtual Boolean IsOtherFee { get; set; }

        public virtual Int32 LsRpType { get; set; }

        public virtual Boolean IsCancel { get; set; }

        public virtual DateTime CancelTime { get; set; }

        public virtual string CancelOperId { get; set; }

        public virtual Boolean IsPrint { get; set; }

        public virtual DateTime PrintTime { get; set; }

        public virtual string PrintOperId { get; set; }

        public virtual Boolean IsPrepared { get; set; }

        public virtual String PrepareTime { get; set; }

        public virtual string PrepareOperId { get; set; }

        public virtual Boolean IsIssue { get; set; }

        public virtual DateTime IssueTime { get; set; }

        public virtual string IssueOperId { get; set; }

        public virtual Boolean IsCharged { get; set; }

        public virtual Boolean IsToBack { get; set; }

        public virtual Boolean IsBack { get; set; }

        public virtual String GroupNumMod { get; set; }

        public virtual string FeeMzId { get; set; }

        public virtual Int32 LsRepType { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithSetRmOutDtlReturn : BaseModel
    {
        // public Orm.Model.Parameter.ReturnValue returnValue { get; set; }
        public OuRecipeDtl ouRecipeDtl { get; set; }

        public List<OuRecipeDtl> lstOuRecipeDtl { get; set; }
        public List<RmOutDtl> lstRmOutDtl { get; set; }

        public virtual string GUID { get; set; }

        public virtual double? TotalRetail { get; set; }

        public virtual int lsacttype { get; set; }
    }

    [Serializable]
    public class HuRmCommonServiceWithSetRmOutDtl : BaseModel
    {
        public List<UspOuDrugIssueDtl> lstOuDrugIssueDtl { get; set; }

        public DateTime dateTime { get; set; }
        public List<OuRecipeDtl> lstOuRecipeDtl { get; set; }
        public string roomId { get; set; }
        public UspOuDrugIssue InfoCurrOuDrugIssue { get; set; }
        public List<Rmstores> lstRmStoreUpdate { get; set; }
        public List<RmOutDtl> lstRmOutDtl { get; set; }
    }

    #region UspOuExecuteBack

    [Serializable]
    public class UspOuExecuteBack : BaseModel
    {
        //////////////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String MzRegNo { get; set; }

        //////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String PatientName { get; set; }

        //////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual string MzRegId { get; set; }

        //////////////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual int GroupNum { get; set; }

        //////////////////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual int NDay { get; set; }

        //////////////////////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual int NTime { get; set; }

        //////////////////////////////[DataMember(Order = 8, IsRequired = false)]
        public virtual Boolean? IsExecuted { get; set; }

        //////////////////////////////[DataMember(Order = 9, IsRequired = false)]
        public virtual DateTime? ExecutedTime { get; set; }

        //////////////////////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual string OperId { get; set; }

        //////////////////////////////[DataMember(Order = 11, IsRequired = true)]
        public virtual String ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 12, IsRequired = true)]
        public virtual String Spec { get; set; }

        //////////////////////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual double Dosage { get; set; }

        //////////////////////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual String UnitTakeName { get; set; }

        //////////////////////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual String UsageName { get; set; }

        //////////////////////////////[DataMember(Order = 16, IsRequired = true)]
        public virtual String FrequencyName { get; set; }

        //////////////////////////////[DataMember(Order = 17, IsRequired = false)]
        public virtual double Totality { get; set; }

        //////////////////////////////[DataMember(Order = 18, IsRequired = true)]
        public virtual String UnitDiagName { get; set; }

        //////////////////////////////[DataMember(Order = 19, IsRequired = false)]
        public virtual DateTime? IssueTime { get; set; }

        //////////////////////////////[DataMember(Order = 20, IsRequired = false)]
        public virtual DateTime? BackTime { get; set; }

        //////////////////////////////[DataMember(Order = 21, IsRequired = false)]
        public virtual string DiagnDept { get; set; }

        //////////////////////////////[DataMember(Order = 22, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        //////////////////////////////[DataMember(Order = 23, IsRequired = true)]
        public virtual String CardNo { get; set; }

        //////////////////////////////[DataMember(Order = 24, IsRequired = true)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 25, IsRequired = false)]
        public virtual double PriceDiag { get; set; }

        //////////////////////////////[DataMember(Order = 26, IsRequired = false)]
        public virtual double? RecipTotality { get; set; }

        //////////////////////////////[DataMember(Order = 27, IsRequired = false)]
        public virtual double? Amount { get; set; }

        //////////////////////////////[DataMember(Order = 28, IsRequired = true)]
        public virtual int Days { get; set; }

        //////////////////////////////[DataMember(Order = 29, IsRequired = false)]
        public virtual Boolean? IsSend { get; set; }

        //////////////////////////////[DataMember(Order = 30, IsRequired = true)]
        public virtual Boolean IsBack { get; set; }

        //////////////////////////////[DataMember(Order = 31, IsRequired = false)]
        public virtual Boolean? IsPatientBack { get; set; }

        //////////////////////////////[DataMember(Order = 32, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //////////////////////////////[DataMember(Order = 33, IsRequired = true)]
        public virtual String DoctorName { get; set; }
    }

    #endregion UspOuExecuteBack

    #region UspOuRecipeForOuexecuteDto

    [Serializable]
    public class UspOuRecipeForOuexecute : BaseModel
    {
        //////////////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual Int32 ListNum { get; set; }

        //////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual int GroupNum { get; set; }

        //////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual double Dosage { get; set; }

        //////////////////////////////[DataMember(Order = 6, IsRequired = false)]
        public virtual string UnitTakeId { get; set; }

        //////////////////////////////[DataMember(Order = 7, IsRequired = false)]
        public virtual string FrequencyId { get; set; }

        //////////////////////////////[DataMember(Order = 8, IsRequired = false)]
        public virtual string UsageId { get; set; }

        //////////////////////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual String UsageName { get; set; }

        //////////////////////////////[DataMember(Order = 10, IsRequired = true)]
        public virtual String GroupNumGroup { get; set; }

        //////////////////////////////[DataMember(Order = 11, IsRequired = false)]
        public virtual int Days { get; set; }

        //////////////////////////////[DataMember(Order = 12, IsRequired = true)]
        public virtual string UnitDiagId { get; set; }

        //////////////////////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual Boolean IsAttach { get; set; }

        //////////////////////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual Boolean IsOtherFee { get; set; }

        //////////////////////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual Boolean IsMzDrop { get; set; }

        //////////////////////////////[DataMember(Order = 16, IsRequired = true)]
        public virtual Boolean IsMzReject { get; set; }

        //////////////////////////////[DataMember(Order = 17, IsRequired = true)]
        public virtual Boolean IsMzCure { get; set; }

        //////////////////////////////[DataMember(Order = 18, IsRequired = true)]
        public virtual string RecipeId { get; set; }

        //////////////////////////////[DataMember(Order = 19, IsRequired = true)]
        public virtual String PrepareTime { get; set; }

        //////////////////////////////[DataMember(Order = 20, IsRequired = true)]
        public virtual String Memo { get; set; }
    }

    #endregion UspOuRecipeForOuexecute

    #region UspInLablePrint

    [Serializable]
    public class UspInLablePrint : BaseModel
    {
        //////////////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String PatientName { get; set; }

        //////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String BedName { get; set; }

        //////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String UsageName { get; set; }

        //////////////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual DateTime OperTime { get; set; }

        //////////////////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual int LsMarkType { get; set; }

        //////////////////////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual String ItemName { get; set; }

        //////////////////////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual double Dosage { get; set; }

        //////////////////////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual String UnitTakeName { get; set; }

        //////////////////////////////[DataMember(Order = 10, IsRequired = true)]
        public virtual string HospId { get; set; }

        //////////////////////////////[DataMember(Order = 11, IsRequired = true)]
        public virtual String Spec { get; set; }

        //////////////////////////////[DataMember(Order = 12, IsRequired = false)]
        public virtual Int32? Age { get; set; }

        //////////////////////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual String SexName { get; set; }

        //////////////////////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual String GroupNum { get; set; }

        //////////////////////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual String Memo { get; set; }

        //////////////////////////////[DataMember(Order = 16, IsRequired = false)]
        public virtual String SkinResult { get; set; }

        //////////////////////////////[DataMember(Order = 17, IsRequired = true)]
        public virtual String LocaName { get; set; }

        //////////////////////////////[DataMember(Order = 18, IsRequired = true)]
        public virtual String HospNo { get; set; }
    }

    #endregion UspInLablePrint

    [Serializable]
    public class UspAnimalHeatByLocationId : BaseModel
    {
        public virtual string HospId { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual String AnimalHeat { get; set; }

        public virtual string locationId { get; set; }

        public virtual String locationName { get; set; }

        public virtual String bedid { get; set; }

        public virtual String bedName { get; set; }

        public virtual String PatientName { get; set; }

        public virtual String feverStatus { get; set; }
    }

    [Serializable]
    public class UspInBodyAllHealth : BaseModel
    {
        public virtual string HospId { get; set; }

        public virtual String BedName { get; set; }

        public virtual String PatientName { get; set; }

        public virtual DateTime InTime { get; set; }

        public virtual Int32 InData { get; set; }

        public virtual String Pulse { get; set; }

        public virtual String Heart { get; set; }

        public virtual String Breath { get; set; }

        public virtual String Stool { get; set; }

        public virtual String Urine { get; set; }

        public virtual String AnimalHeat { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual String HeatType { get; set; }

        public virtual String Bldpress0 { get; set; }

        public virtual String Bldpress1 { get; set; }

        public virtual String Weight { get; set; }

        public virtual String UrineM { get; set; }

        public virtual String FluidM { get; set; }

        public virtual Boolean IsSpinTest { get; set; }

        public virtual String OtherM { get; set; }

        public virtual String TotalIn { get; set; }

        public virtual String TotalOut { get; set; }

        public virtual Boolean LowerTemp { get; set; }

        public virtual Boolean IsRecheck { get; set; }

        public virtual Boolean IsOutSide { get; set; }

        public virtual Boolean IsMachine { get; set; }

        public virtual String Others { get; set; }

        public virtual String MemoUp { get; set; }

        public virtual String MemoDn { get; set; }

        public virtual String MemoUp1 { get; set; }

        public virtual String MemoDn1 { get; set; }

        public virtual DateTime RecordTime { get; set; }

        public virtual String CwHeight { get; set; }

        public virtual string locationid { get; set; }

        public virtual DateTime birthtime { get; set; }

        public virtual DateTime DeadTime { get; set; }
    }

    [Serializable]
    public class Uspinbodyheatloclasttime3 : BaseModel
    {
        public virtual string hospid { get; set; }

        public virtual String bedname { get; set; }

        public virtual String patientname { get; set; }

        public virtual DateTime intime { get; set; }

        public virtual Int32 INDATA { get; set; }

        public virtual String pulse { get; set; }

        public virtual String heart { get; set; }

        public virtual String breath { get; set; }

        public virtual String stool { get; set; }

        public virtual String urine { get; set; }

        public virtual String animalheat { get; set; }

        public virtual String TimeQuantum { get; set; }

        public virtual DateTime opertime { get; set; }

        public virtual String heattype { get; set; }

        public virtual String bldpress0 { get; set; }

        public virtual String bldpress1 { get; set; }

        public virtual String weight { get; set; }

        public virtual String urinem { get; set; }

        public virtual String fluidm { get; set; }

        public virtual Boolean isspintest { get; set; }

        public virtual String otherm { get; set; }

        public virtual String totalin { get; set; }

        public virtual String totalout { get; set; }

        public virtual Boolean lowertemp { get; set; }

        public virtual Boolean isrecheck { get; set; }

        public virtual Boolean isoutside { get; set; }

        public virtual Boolean ismachine { get; set; }

        public virtual String others { get; set; }

        public virtual String memoup { get; set; }

        public virtual String memodn { get; set; }

        public virtual String memoup1 { get; set; }

        public virtual String memodn1 { get; set; }

        public virtual DateTime RecordTime { get; set; }

        public virtual String CwHeight { get; set; }

        public virtual DateTime birthtime { get; set; }

        public virtual DateTime DeadTime { get; set; }
    }

    [Serializable]
    public class UspInBodyHeatLocLastTime : BaseModel
    {
        public virtual string HospId { get; set; }

        public virtual String BedName { get; set; }

        public virtual String PatientName { get; set; }

        public virtual DateTime InTime { get; set; }

        public virtual Int32 InData { get; set; }

        public virtual String Pulse { get; set; }

        public virtual String Heart { get; set; }

        public virtual String Breath { get; set; }

        public virtual String Stool { get; set; }

        public virtual String Urine { get; set; }

        public virtual String AnimalHeat { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual String HeatType { get; set; }

        public virtual String Bldpress0 { get; set; }

        public virtual String Bldpress1 { get; set; }

        public virtual String Weight { get; set; }

        public virtual String UrineM { get; set; }

        public virtual String FluidM { get; set; }

        public virtual Boolean IsSpinTest { get; set; }

        public virtual String OtherM { get; set; }

        public virtual String TotalIn { get; set; }

        public virtual String TotalOut { get; set; }

        public virtual Boolean LowerTemp { get; set; }

        public virtual Boolean IsRecheck { get; set; }

        public virtual Boolean IsOutSide { get; set; }

        public virtual Boolean IsMachine { get; set; }

        public virtual String Others { get; set; }

        public virtual String MemoUp { get; set; }

        public virtual String MemoDn { get; set; }

        public virtual DateTime RecordTime { get; set; }

        public virtual String CwHeight { get; set; }

        public virtual DateTime birthtime { get; set; }

        public virtual DateTime DeadTime { get; set; }
    }

    [Serializable]
    public class UspInBalanceDtlNotPay : BaseModel
    {
        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual String Code { get; set; }

        public virtual string HospId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual DateTime RegOperTime { get; set; }

        public virtual string RegOperId { get; set; }

        public virtual string LocationId { get; set; }

        public virtual string AdviceId { get; set; }

        public virtual Int32 LsMarkType { get; set; }

        public virtual double Totality { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual string UnitId { get; set; }

        public virtual Boolean IsPay { get; set; }

        public virtual double DiscIn { get; set; }

        public virtual double DiscSelf { get; set; }

        public virtual double Amount { get; set; }

        public virtual double AmountFact { get; set; }

        public virtual double AmountSelf { get; set; }

        public virtual double AmountTally { get; set; }

        public virtual string InvoId { get; set; }

        public virtual Int32 LsPerform { get; set; }

        public virtual Boolean IsModiDisc { get; set; }

        public virtual string LimitGroupId { get; set; }

        public virtual double LimitFee { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual string ExecOperId { get; set; }

        public virtual string ExecLocId { get; set; }

        public virtual string InvItemId { get; set; }

        public virtual string FeeId { get; set; }

        public virtual string FeeHsId { get; set; }

        public virtual Int32 LsReportType { get; set; }

        public virtual String Memo { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual string OperId { get; set; }

        public virtual Boolean IsCancel { get; set; }

        public virtual string CancelId { get; set; }

        public virtual Boolean IsManual { get; set; }

        public virtual String RegOperDate { get; set; }

        public virtual Int32 LsGfType { get; set; }

        public virtual double AmountPay { get; set; }

        public virtual String BsInvInItemName { get; set; }

        public virtual String BsZyFeetyName { get; set; }

        public virtual Boolean IsBedFee { get; set; }

        public virtual string MainDoctorId { get; set; }

        public virtual String RegDate { get; set; }

        public virtual Boolean IsYbCharged { get; set; }

        public virtual String NotAuthMemo { get; set; }

        public virtual double DiscountAoumt { get; set; }

        public virtual double DiscountPrice { get; set; }

        public virtual double ChildPrice { get; set; }
    }

    [Serializable]
    public class UspInInvoicePrint : BaseModel
    {
        public virtual String Hosp_NO { get; set; }

        public virtual String Bill_ID { get; set; }

        public virtual String CHINESE { get; set; }

        public virtual String LOCATION { get; set; }

        public virtual String OutDate { get; set; }

        public virtual String InDate { get; set; }

        public virtual double A1 { get; set; }

        public virtual double A2 { get; set; }

        public virtual double A3 { get; set; }

        public virtual double A4 { get; set; }

        public virtual double A5 { get; set; }

        public virtual double A6 { get; set; }

        public virtual double A7 { get; set; }

        public virtual double A8 { get; set; }

        public virtual double A9 { get; set; }

        public virtual double A10 { get; set; }

        public virtual double A11 { get; set; }

        public virtual double A12 { get; set; }

        public virtual double A13 { get; set; }

        public virtual double A14 { get; set; }

        public virtual double A15 { get; set; }

        public virtual double A16 { get; set; }

        public virtual double A17 { get; set; }

        public virtual double A18 { get; set; }

        public virtual double A19 { get; set; }

        public virtual double A20 { get; set; }

        public virtual DateTime Reg_Time { get; set; }

        public virtual Int32 Invo_Seq { get; set; }

        public virtual double AddFee { get; set; }

        public virtual String Sum_Cap { get; set; }

        public virtual double AddFee1 { get; set; }

        public virtual double Pay_Self { get; set; }

        public virtual double Fact_Get { get; set; }

        public virtual double SumTil { get; set; }

        public virtual double RePay { get; set; }

        public virtual double CancelPay { get; set; }

        public virtual double ForePay { get; set; }

        public virtual double Arrearage { get; set; }

        public virtual Int32 Reg_By { get; set; }

        public virtual String Assessor { get; set; }

        public virtual String Name { get; set; }

        public virtual String BZ { get; set; }

        public virtual String Fen { get; set; }

        public virtual String Jiao { get; set; }

        public virtual String Yuan { get; set; }

        public virtual String Shi { get; set; }

        public virtual String Bai { get; set; }

        public virtual String Qian { get; set; }

        public virtual String Wan { get; set; }

        public virtual String WanShi { get; set; }

        public virtual String Pay_WayDesc { get; set; }

        public virtual Int32 n_ChargeDays { get; set; }

        public virtual double Addfee2 { get; set; }

        public virtual String LocationName { get; set; }

        public double B1 { get; set; }

        public double B2 { get; set; }

        public double B3 { get; set; }

        public virtual double C1 { get; set; }

        public virtual double C2 { get; set; }

        public virtual double C3 { get; set; }

        public virtual string TA1 { get; set; }

        public virtual string TA2 { get; set; }

        public virtual string TA3 { get; set; }

        public virtual string TB1 { get; set; }

        public virtual string TB2 { get; set; }

        public virtual string TB3 { get; set; }

        public virtual string TB4 { get; set; }

        public virtual string TC1 { get; set; }

        public virtual string TC2 { get; set; }

        public virtual string TC3 { get; set; }

        public virtual string TC4 { get; set; }

        public virtual string TD1 { get; set; }

        public virtual string TD2 { get; set; }

        public virtual string TD3 { get; set; }

        public virtual string TD4 { get; set; }

        public virtual double D1 { get; set; }

        public virtual double D2 { get; set; }

        public virtual double D3 { get; set; }
    }

    [Serializable]
    public class InInvoYBInfoWithSetInInvoYBInfo : BaseModel
    {
        public InInvoYB InfoInInvoYB { get; set; }

        public double otherFact { get; set; }

        public double allFactYP { get; set; }

        public double allFactJZ { get; set; }

        public double factYP { get; set; }

        public double factJZ { get; set; }

        public InHosInfo infoInHos { get; set; }

        public double insurance { get; set; }

        public InInvoice infoInInvoice { get; set; }

        public double amountPay { get; set; }

        public double underLine { get; set; }
    }

    [Serializable]
    public class UspInInvoiceDtlPrint : BaseModel
    {
        public virtual String InPatNo { get; set; }

        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual String BsBedName { get; set; }

        public virtual String LocationName { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual String PatTypeName { get; set; }

        public virtual String InvInItemName { get; set; }

        public virtual Int32 OrderBy { get; set; }

        public virtual String Code { get; set; }

        public virtual DateTime FromDate { get; set; }

        public virtual DateTime ToDate { get; set; }

        public virtual String UnitName { get; set; }

        public virtual String ItemName { get; set; }

        public virtual double Totality { get; set; }

        public virtual double AmountPay { get; set; }

        public virtual double Amount { get; set; }

        public virtual double Discount { get; set; }

        public virtual double YBAmount { get; set; }

        public virtual string InvoId { get; set; }

        public virtual String YbType { get; set; }

        public virtual double zInsurance { get; set; }

        public virtual double zAmountPay { get; set; }

        public virtual String AddressHome { get; set; }

        public virtual String Sex { get; set; }

        public virtual String YbCode { get; set; }
    }

    [Serializable]
    public class UspAdviceAndInDtl : BaseModel
    {
        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual String Code { get; set; }

        public virtual string HospId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual DateTime RegOperTime { get; set; }

        public virtual string RegOperId { get; set; }

        public virtual string LocationId { get; set; }

        public virtual string AdviceId { get; set; }

        public virtual double Totality { get; set; }

        public virtual Int32 LsMarkType { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual string UnitId { get; set; }

        public virtual Boolean IsPay { get; set; }

        public virtual double DiscSelf { get; set; }

        public virtual double DiscIn { get; set; }

        public virtual double Amount { get; set; }

        public virtual double AmountFact { get; set; }

        public virtual double AmountSelf { get; set; }

        public virtual double AmountTally { get; set; }

        public virtual double AmountPay { get; set; }

        public virtual string InvoId { get; set; }

        public virtual Int32 LsPerform { get; set; }

        public virtual Boolean IsModiDisc { get; set; }

        public virtual string LimitGroupId { get; set; }

        public virtual double LimitFee { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual string ExecOperId { get; set; }

        public virtual string ExecLocId { get; set; }

        public virtual string InvItemId { get; set; }

        public virtual string FeeId { get; set; }

        public virtual string FeeHsId { get; set; }

        public virtual Boolean IsCancel { get; set; }

        public virtual Boolean IsManual { get; set; }

        public virtual string CancelId { get; set; }

        public virtual Int32 LsReportType { get; set; }

        public virtual String Memo { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual string OperId { get; set; }

        public virtual String RegOperDate { get; set; }

        public virtual String HostName { get; set; }

        public virtual string GroupItemId { get; set; }

        public virtual string XDRpId { get; set; }

        public virtual String AdviceName { get; set; }

        public virtual Int32 LsRpType { get; set; }

        public virtual Int32 GroupNum { get; set; }

        public virtual String RegDate { get; set; }

        public virtual String TempStr { get; set; }

        public virtual Boolean IsAutoCharged { get; set; }

        public virtual Boolean IsYbCharged { get; set; }

        public virtual String NotAuthMemo { get; set; }

        public virtual String ReservedField { get; set; }

        public virtual Boolean isissued { get; set; }

        public virtual double DiscountAoumt { get; set; }

        public virtual double DiscountPrice { get; set; }

        public virtual double ChildPrice { get; set; }
    }

    [Serializable]
    public class UspInInvoiceDtlGroup : BaseModel
    {
        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual string HospId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual double Totality { get; set; }

        public virtual string UnitId { get; set; }

        public virtual double Amount { get; set; }
    }

    [Serializable]
    public class CUspInInvoiceDtlChkByHospId : BaseModel
    {
        public virtual string hospid { get; set; }

        public virtual string itemid { get; set; }

        public virtual DateTime regopertime { get; set; }

        public virtual string regoperid { get; set; }

        public virtual string locationid { get; set; }

        public virtual string adviceid { get; set; }

        public virtual Int32 lsmarktype { get; set; }

        public virtual double totality { get; set; }

        public virtual double pricein { get; set; }

        public virtual string unitid { get; set; }

        public virtual Boolean ispay { get; set; }

        public virtual double discin { get; set; }

        public virtual double discself { get; set; }

        public virtual double amount { get; set; }

        public virtual double amountfact { get; set; }

        public virtual double amountself { get; set; }

        public virtual double amounttally { get; set; }

        public virtual double amountpay { get; set; }

        public virtual string invoid { get; set; }

        public virtual Int32 lsperform { get; set; }

        public virtual Boolean ismodidisc { get; set; }

        public virtual string limitgroupid { get; set; }

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

        public virtual string maindoctorid { get; set; }

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

    [Serializable]
    public class UspOuCheckRecipeDtl : BaseModel
    {
        public virtual Boolean IsDoctorInput { get; set; }

        public virtual String IssueTime { get; set; }

        public virtual string PrintOperId { get; set; }

        public virtual DateTime PrintTime { get; set; }

        public virtual Boolean IsPrint { get; set; }

        public virtual string CancelOperId { get; set; }

        public virtual DateTime CancelTime { get; set; }

        public virtual Boolean IsCancel { get; set; }

        public virtual Boolean IsCharged { get; set; }

        public virtual string XDRpId { get; set; }

        public virtual String Memo { get; set; }

        public virtual Boolean IsOtherFee { get; set; }

        public virtual Boolean IsAttach { get; set; }

        public virtual string UnitDiagId { get; set; }

        public virtual double Totality { get; set; }

        public virtual Int32 Days { get; set; }

        public virtual string UsageId { get; set; }

        public virtual string FrequencyId { get; set; }

        public virtual double Dosage { get; set; }

        public virtual Int32 GroupNum { get; set; }

        public virtual string ItemId { get; set; }

        public virtual Int32 ListNum { get; set; }

        public virtual string RecipeId { get; set; }

        public virtual String UnitDiagName { get; set; }

        public virtual String ItemCode { get; set; }

        public virtual String ItemName { get; set; }

        public virtual String Spec { get; set; }

        public virtual double PriceDiag { get; set; }

        public virtual double Amount { get; set; }

        public virtual String XdRpName { get; set; }
    }

    #region UspTestFromAdvice

    [Serializable]
    public class UspTestFromAdvice : BaseModel
    {
        // #region UspTestFromAdviceDto = 1, IsRequired = false)]
        public virtual string GUID { get; set; }

        // #region UspTestFromAdviceDto = 2, IsRequired = false)]
        public virtual string AsId { get; set; }

        // #region UspTestFromAdviceDto = 3, IsRequired = true)]
        public virtual String Code { get; set; }

        // #region UspTestFromAdviceDto = 4, IsRequired = false)]
        public virtual int LsTestType { get; set; }

        // #region UspTestFromAdviceDto = 5, IsRequired = false)]
        public virtual string TestTypeId { get; set; }

        // #region UspTestFromAdviceDto = 6, IsRequired = true)]
        public virtual String ShortName { get; set; }

        // #region UspTestFromAdviceDto = 7, IsRequired = true)]
        public virtual String Name { get; set; }

        // #region UspTestFromAdviceDto = 8, IsRequired = true)]
        public virtual String OperMemo { get; set; }

        // #region UspTestFromAdviceDto = 9, IsRequired = false)]
        public virtual int LsGroup { get; set; }

        // #region UspTestFromAdviceDto = 10, IsRequired = false)]
        public virtual double Price { get; set; }

        // #region UspTestFromAdviceDto = 11, IsRequired = true)]
        public virtual String Unit { get; set; }

        // #region UspTestFromAdviceDto = 12, IsRequired = false)]
        public virtual string ItemId { get; set; }

        // #region UspTestFromAdviceDto = 13, IsRequired = false)]
        public virtual Boolean? IsActive { get; set; }

        // #region UspTestFromAdviceDto = 14, IsRequired = false)]
        public virtual string TestId { get; set; }

        // #region UspTestFromAdviceDto = 15, IsRequired = false)]
        public virtual Int32? LsStatus { get; set; }

        // #region UspTestFromAdviceDto = 16, IsRequired = false)]
        public virtual string TubeTypeId { get; set; }

        // #region UspTestFromAdviceDto = 17, IsRequired = false)]
        public virtual string SourceId { get; set; }

        // #region UspTestFromAdviceDto = 18, IsRequired = true)]
        public virtual String TestTypeName { get; set; }

        // #region UspTestFromAdviceDto = 19, IsRequired = true)]
        public virtual String SourceName { get; set; }

        // #region UspTestFromAdviceDto = 20, IsRequired = false)]
        public virtual string ParentID { get; set; }

        // #region UspTestFromAdviceDto = 21, IsRequired = false)]
        public virtual string LabId { get; set; }

        // #region UspTestFromAdviceDto = 22, IsRequired = false)]
        public virtual string XDRpId { get; set; }

        // #region UspTestFromAdviceDto = 23, IsRequired = false)]
        public virtual double Totality { get; set; }

        // #region UspTestFromAdviceDto = 24, IsRequired = true)]
        public virtual String UseType { get; set; }

        // #region UspTestFromAdviceDto = 25, IsRequired = true)]
        public virtual String AdviceType { get; set; }

        // #region UspTestFromAdviceDto = 26, IsRequired = true)]
        public virtual Boolean IsAutoCharged { get; set; }
    }

    #endregion UspTestFromAdvice

    [Serializable]
    public class LstBsModel : BaseModel
    {

        public List<BsLocation> LstBsLocation { get; set; }
        public List<BsItem> LstBsItem { get; set; }
        public List<BsRoom> LstBsRoom { get; set; }
        public List<BsItemDrug> LstBsItemDrug { get; set; }
        public List<RmUnderLine> LstRmUnderLine { get; set; }

        public int Status { get; set; }
    }

    [Serializable]
    public class UspGetBedFee : BaseModel
    {
        public virtual string AdviceId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual double Totality { get; set; }

        public virtual Int32 LsPerform { get; set; }

        public virtual string CancelId { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual string LocationId { get; set; }

        public virtual string ExecLocationId { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual Int32 LsMarkType { get; set; }
    }

    [Serializable]
    public class UspGetAdviceLongExecItem : BaseModel
    {
        public virtual string HospId { get; set; }

        public virtual string AdviceId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual double Totality { get; set; }

        public virtual Int32 LsPerform { get; set; }

        public virtual Int32 GroupNum { get; set; }

        public virtual string CancelId { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual string LocationId { get; set; }

        public virtual string ExecLocationId { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual string ReqOperId { get; set; }

        public virtual Int32 LsMarkType { get; set; }

        public virtual string ExecOperId { get; set; }

        public virtual string FrequencyId { get; set; }

        public virtual string UsageId { get; set; }

        public virtual Int32 LsExecLoc { get; set; }

        public virtual String Memo { get; set; }
    }

    [Serializable]
    public class UspGetAdviceTempExecItem : BaseModel
    {
        public virtual string HospId { get; set; }

        public virtual string AdviceId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual double Totality { get; set; }

        public virtual Int32 LsPerform { get; set; }

        public virtual Int32 GroupNum { get; set; }

        public virtual string CancelId { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual string LocationId { get; set; }

        public virtual string ExecLocationId { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual string ReqOperId { get; set; }

        public virtual Int32 LsMarkType { get; set; }

        public virtual string ExecOperId { get; set; }

        public virtual string FrequencyId { get; set; }

        public virtual string UsageId { get; set; }

        public virtual Int32 LsExecLoc { get; set; }

        public virtual String Memo { get; set; }
    }

    [Serializable]
    public class UspGetApplyOuHosInfo
    {
        //////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String MzRegNo { get; set; }

        //////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual DateTime RegTime { get; set; }

        //////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual string PatId { get; set; }

        //////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual String CardNo { get; set; }

        //////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String Name { get; set; }

        //////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual String PatTypeName { get; set; }

        //////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual String MedicareNo { get; set; }

        //////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual String RegTypeName { get; set; }

        //////////////[DataMember(Order = 10, IsRequired = true)]
        public virtual String RegDeptName { get; set; }

        //////////////[DataMember(Order = 11, IsRequired = true)]
        public virtual String DiagnDeptName { get; set; }

        //////////////[DataMember(Order = 12, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        //////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual String OperName { get; set; }

        //////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual Int32 RegDept { get; set; }

        //////////////[DataMember(Order = 15, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        //////////////[DataMember(Order = 16, IsRequired = true)]
        public virtual string RegTypeId { get; set; }
    }

    [Serializable]
    public class UspOuDoctor : BaseModel
    {
        ////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String Code { get; set; }

        ////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String Name { get; set; }

        ////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String Sex { get; set; }

        ////////////////[DataMember(Order = 5, IsRequired = false)]
        public virtual string DocLevId { get; set; }

        ////////////////[DataMember(Order = 6, IsRequired = false)]
        public virtual string RegTypeId { get; set; }

        ////////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual String RegTypeName { get; set; }

        ////////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual String DocLevelName { get; set; }

        ////////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual Int32 IconIndex { get; set; }

        ////////////////[DataMember(Order = 10, IsRequired = true)]
        public virtual Int32 LsInOut { get; set; }

        ////////////////[DataMember(Order = 11, IsRequired = true)]
        public virtual String LocationName { get; set; }

        ////////////////[DataMember(Order = 12, IsRequired = true)]
        public virtual string LocationId { get; set; }

        ////////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual String Address { get; set; }

        ////////////////[DataMember(Order = 14, IsRequired = false)]
        public virtual int LimitNum { get; set; }

        ////////////////[DataMember(Order = 15, IsRequired = false)]
        public virtual Int32 HasDiagnoseNum { get; set; }

        ////////////////[DataMember(Order = 16, IsRequired = false)]
        public virtual string TimeSpanId { get; set; }

        ////////////////[DataMember(Order = 17, IsRequired = true)]
        public virtual String TimeSpanName { get; set; }
    }

    [Serializable]
    public class UspInDayCharge : BaseModel
    {
        public virtual string ItemId { get; set; }

        public virtual DateTime BeginTime { get; set; }

        public virtual double Totality { get; set; }

        public virtual string UnitId { get; set; }

        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual string LocationId { get; set; }
        public virtual string PatTypeId { get; set; }
    }

    [Serializable]
    public class UspOuRegInvoPreRegPrint : BaseModel
    {
        //////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String InvoNo { get; set; }

        //////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String Name { get; set; }

        //////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String MzRegNo { get; set; }

        //////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        //////////////////[DataMember(Order = 7, IsRequired = false)]
        public virtual Int32 RegFee { get; set; }

        //////////////////[DataMember(Order = 8, IsRequired = false)]
        public virtual Int32 DiagnoFee { get; set; }

        //////////////////[DataMember(Order = 9, IsRequired = false)]
        public virtual Int32 ZyFee { get; set; }

        //////////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual Int32 OtherFee1 { get; set; }

        //////////////////[DataMember(Order = 11, IsRequired = false)]
        public virtual Int32 OtherFee2 { get; set; }

        //////////////////[DataMember(Order = 12, IsRequired = false)]
        public virtual Int32 FactPay { get; set; }

        //////////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual String RegDate { get; set; }

        //////////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual String RegTime { get; set; }

        //////////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual String PatTypeName { get; set; }

        //////////////////[DataMember(Order = 16, IsRequired = true)]
        public virtual String OperCode { get; set; }

        //////////////////[DataMember(Order = 17, IsRequired = true)]
        public virtual String MedicareNo { get; set; }

        //////////////////[DataMember(Order = 18, IsRequired = true)]
        public virtual Int32 LineOrder { get; set; }

        //////////////////[DataMember(Order = 19, IsRequired = true)]
        public virtual String RegTypeName { get; set; }
    }

    [Serializable]
    public class UspGetOuDoctorCall : BaseModel
    {
        ////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String MzRegNo { get; set; }

        ////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual DateTime RegTime { get; set; }

        ////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String CardNo { get; set; }

        ////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual String name { get; set; }

        ////////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String Sex { get; set; }

        ////////////////////[DataMember(Order = 7, IsRequired = false)]
        public virtual string DiagnDept { get; set; }

        ////////////////////[DataMember(Order = 8, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        ////////////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual String RoomNo { get; set; }

        ////////////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual string TimeSpanId { get; set; }

        ////////////////////[DataMember(Order = 11, IsRequired = false)]
        public virtual string TimeSpanSubId { get; set; }

        ////////////////////[DataMember(Order = 12, IsRequired = true)]
        public virtual Int32 LineOrder { get; set; }
    }

    [Serializable]
    public class UspYyOuRegInvoNoIsCancel : BaseModel
    {
        //////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String InvoNo { get; set; }

        //////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String Name { get; set; }

        //////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String MzRegNo { get; set; }

        //////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //////////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        //////////////////////[DataMember(Order = 7, IsRequired = false)]
        public virtual double RegFee { get; set; }

        //////////////////////[DataMember(Order = 8, IsRequired = false)]
        public virtual double DiagnoFee { get; set; }

        //////////////////////[DataMember(Order = 9, IsRequired = false)]
        public virtual double ZyFee { get; set; }

        //////////////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual double OtherFee1 { get; set; }

        //////////////////////[DataMember(Order = 11, IsRequired = false)]
        public virtual double OtherFee2 { get; set; }

        //////////////////////[DataMember(Order = 12, IsRequired = false)]
        public virtual double? FactPay { get; set; }

        //////////////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual DateTime RegTime { get; set; }

        //////////////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual String PatTypeName { get; set; }

        //////////////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual String OperCode { get; set; }

        //////////////////////[DataMember(Order = 16, IsRequired = true)]
        public virtual String MedicareNo { get; set; }

        //////////////////////[DataMember(Order = 17, IsRequired = true)]
        public virtual Int32 LineOrder { get; set; }

        //////////////////////[DataMember(Order = 18, IsRequired = true)]
        public virtual String Sex { get; set; }

        //////////////////////[DataMember(Order = 19, IsRequired = true)]
        public virtual String RegtypeName { get; set; }
    }

    [Serializable]
    public class UspAdmissNote : BaseModel
    {
        ////////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String Cardno { get; set; }

        ////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String Name { get; set; }

        ////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String Sex { get; set; }

        ////////////////////////[DataMember(Order = 5, IsRequired = false)]
        public virtual DateTime Birthdate { get; set; }

        ////////////////////////[DataMember(Order = 6, IsRequired = false)]
        public virtual Int32 Lschargetype { get; set; }

        ////////////////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual String Medicareno { get; set; }

        ////////////////////////[DataMember(Order = 8, IsRequired = false)]
        public virtual Int32? NTime { get; set; }

        ////////////////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual String Native { get; set; }

        ////////////////////////[DataMember(Order = 10, IsRequired = true)]
        public virtual Int32 LsMarriage { get; set; }

        ////////////////////////[DataMember(Order = 11, IsRequired = true)]
        public virtual String Occupation { get; set; }

        ////////////////////////[DataMember(Order = 12, IsRequired = true)]
        public virtual String Idcardno { get; set; }

        ////////////////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual String Addresswork { get; set; }

        ////////////////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual String PhoneWork { get; set; }

        ////////////////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual String Postcodework { get; set; }

        ////////////////////////[DataMember(Order = 16, IsRequired = true)]
        public virtual String Residence { get; set; }

        ////////////////////////[DataMember(Order = 17, IsRequired = true)]
        public virtual String Linkmanname { get; set; }

        ////////////////////////[DataMember(Order = 18, IsRequired = true)]
        public virtual String Linkmanphone { get; set; }

        ////////////////////////[DataMember(Order = 19, IsRequired = true)]
        public virtual String Linkmanaddress { get; set; }

        ////////////////////////[DataMember(Order = 20, IsRequired = true)]
        public virtual String AdmiTiem { get; set; }

        ////////////////////////[DataMember(Order = 21, IsRequired = true)]
        public virtual String illdesc { get; set; }

        ////////////////////////[DataMember(Order = 22, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        ////////////////////////[DataMember(Order = 23, IsRequired = true)]
        public virtual String Code { get; set; }
    }

    [Serializable]
    public class UspPrintCertificateInfo : BaseModel
    {
        //////////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String MzRegNo { get; set; }

        //////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String MedicareNo { get; set; }

        //////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual String Name { get; set; }

        //////////////////////////[DataMember(Order = 5, IsRequired = false)]
        public virtual DateTime birthDate { get; set; }

        //////////////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String Sex { get; set; }

        //////////////////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual string PatId { get; set; }

        //////////////////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual String AgeString { get; set; }

        //////////////////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual String Native { get; set; }

        //////////////////////////[DataMember(Order = 10, IsRequired = true)]
        public virtual String Residence { get; set; }

        //////////////////////////[DataMember(Order = 11, IsRequired = true)]
        public virtual String IntoTheMode { get; set; }

        //////////////////////////[DataMember(Order = 12, IsRequired = true)]
        public virtual String IllDesc { get; set; }

        //////////////////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual String LickInLocationName { get; set; }

        //////////////////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual String Memo { get; set; }

        //////////////////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //////////////////////////[DataMember(Order = 16, IsRequired = true)]
        public virtual String DoctorName { get; set; }

        //////////////////////////[DataMember(Order = 17, IsRequired = true)]
        public virtual DateTime InTime { get; set; }

        //////////////////////////[DataMember(Order = 18, IsRequired = false)]
        public virtual double? PreAmount { get; set; }
    }

    [Serializable]
    public class UspGetOuHosInfoNotDiagn : BaseModel
    {
        ////////////////////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        ////////////////////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String MzRegNo { get; set; }

        ////////////////////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual DateTime RegTime { get; set; }

        ////////////////////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual string PatId { get; set; }

        ////////////////////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual String CardNo { get; set; }

        ////////////////////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String Name { get; set; }

        ////////////////////////////[DataMember(Order = 7, IsRequired = true)]
        public virtual String Sex { get; set; }

        ////////////////////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual Boolean IsBaby { get; set; }

        ////////////////////////////[DataMember(Order = 9, IsRequired = false)]
        public virtual Int32? AgeDay { get; set; }

        ////////////////////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual double? Height { get; set; }

        ////////////////////////////[DataMember(Order = 11, IsRequired = false)]
        public virtual double Weight { get; set; }

        ////////////////////////////[DataMember(Order = 12, IsRequired = true)]
        public virtual string PatTypeId { get; set; }

        ////////////////////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual String MedicareNo { get; set; }

        ////////////////////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual string RegTypeId { get; set; }

        ////////////////////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual Boolean IsPriority { get; set; }

        ////////////////////////////[DataMember(Order = 16, IsRequired = true)]
        public virtual Boolean IsElder { get; set; }

        ////////////////////////////[DataMember(Order = 17, IsRequired = true)]
        public virtual Int32 LineOrder { get; set; }

        ////////////////////////////[DataMember(Order = 18, IsRequired = true)]
        public virtual double RegFee { get; set; }

        ////////////////////////////[DataMember(Order = 19, IsRequired = true)]
        public virtual double ZyFee { get; set; }

        ////////////////////////////[DataMember(Order = 20, IsRequired = true)]
        public virtual double DiagnoFee { get; set; }

        ////////////////////////////[DataMember(Order = 21, IsRequired = true)]
        public virtual double OtherFee1 { get; set; }

        ////////////////////////////[DataMember(Order = 22, IsRequired = true)]
        public virtual double OtherFee2 { get; set; }

        ////////////////////////////[DataMember(Order = 23, IsRequired = true)]
        public virtual double PaySel { get; set; }

        ////////////////////////////[DataMember(Order = 24, IsRequired = true)]
        public virtual double TallyDiag { get; set; }

        ////////////////////////////[DataMember(Order = 25, IsRequired = true)]
        public virtual double FactGet { get; set; }

        ////////////////////////////[DataMember(Order = 26, IsRequired = true)]
        public virtual string RegDept { get; set; }

        ////////////////////////////[DataMember(Order = 27, IsRequired = false)]
        public virtual string DiagnDept { get; set; }

        ////////////////////////////[DataMember(Order = 28, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        ////////////////////////////[DataMember(Order = 29, IsRequired = true)]
        public virtual String RoomNo { get; set; }

        ////////////////////////////[DataMember(Order = 30, IsRequired = true)]
        public virtual Boolean IsFreeDiag { get; set; }

        ////////////////////////////[DataMember(Order = 31, IsRequired = true)]
        public virtual Boolean IsFreeReg { get; set; }

        ////////////////////////////[DataMember(Order = 32, IsRequired = true)]
        public virtual Boolean IsInPatient { get; set; }

        ////////////////////////////[DataMember(Order = 33, IsRequired = true)]
        public virtual Boolean IsPreReg { get; set; }

        ////////////////////////////[DataMember(Order = 34, IsRequired = true)]
        public virtual DateTime OperTime { get; set; }

        ////////////////////////////[DataMember(Order = 35, IsRequired = true)]
        public virtual string OperId { get; set; }

        ////////////////////////////[DataMember(Order = 36, IsRequired = false)]
        public virtual Boolean IsCancel { get; set; }

        ////////////////////////////[DataMember(Order = 37, IsRequired = false)]
        public virtual DateTime? CancelTime { get; set; }

        ////////////////////////////[DataMember(Order = 38, IsRequired = false)]
        public virtual string CancelOperId { get; set; }

        ////////////////////////////[DataMember(Order = 39, IsRequired = true)]
        public virtual String CancelMemo { get; set; }

        ////////////////////////////[DataMember(Order = 40, IsRequired = false)]
        public virtual string TimeSpanId { get; set; }

        ////////////////////////////[DataMember(Order = 41, IsRequired = true)]
        public virtual String RegDate { get; set; }

        ////////////////////////////[DataMember(Order = 42, IsRequired = false)]
        public virtual int Age { get; set; }

        ////////////////////////////[DataMember(Order = 43, IsRequired = true)]
        public virtual String AgeString { get; set; }

        ////////////////////////////[DataMember(Order = 44, IsRequired = true)]
        public virtual String ContactPhone { get; set; }

        ////////////////////////////[DataMember(Order = 45, IsRequired = true)]
        public virtual String LinkmanName { get; set; }

        ////////////////////////////[DataMember(Order = 46, IsRequired = false)]
        public virtual DateTime? TallyTime { get; set; }

        ////////////////////////////[DataMember(Order = 47, IsRequired = false)]
        public virtual DateTime? CancelTallyTime { get; set; }

        ////////////////////////////[DataMember(Order = 48, IsRequired = false)]
        public virtual string TimeSpanSubId { get; set; }

        ////////////////////////////[DataMember(Order = 49, IsRequired = false)]
        public virtual string DiagRoomId { get; set; }

        ////////////////////////////[DataMember(Order = 50, IsRequired = false)]
        public virtual string CallDoctorId { get; set; }

        ////////////////////////////[DataMember(Order = 51, IsRequired = false)]
        public virtual string CallOrder { get; set; }

        ////////////////////////////[DataMember(Order = 52, IsRequired = false)]
        public virtual Boolean IsFirstCheck { get; set; }

        ////////////////////////////[DataMember(Order = 53, IsRequired = false)]
        public virtual Boolean IsGoodRecipe { get; set; }

        ////////////////////////////[DataMember(Order = 54, IsRequired = true)]
        public virtual String GoodRecipe { get; set; }

        ////////////////////////////[DataMember(Order = 55, IsRequired = false)]
        public virtual Boolean? IsRegist { get; set; }

        ////////////////////////////[DataMember(Order = 56, IsRequired = true)]
        public virtual String Diagnose { get; set; }

        ////////////////////////////[DataMember(Order = 57, IsRequired = true)]
        public virtual String PreRegRegWay { get; set; }

        ////////////////////////////[DataMember(Order = 58, IsRequired = false)]
        public virtual Boolean? IsRegister { get; set; }

        ////////////////////////////[DataMember(Order = 59, IsRequired = false)]
        public virtual Boolean? IsRegistration { get; set; }

        ////////////////////////////[DataMember(Order = 60, IsRequired = true)]
        public virtual String YbSeqNo { get; set; }

        ////////////////////////////[DataMember(Order = 61, IsRequired = false)]
        public virtual Boolean? IsTransfer { get; set; }

        ////////////////////////////[DataMember(Order = 62, IsRequired = true)]
        public virtual String InterfaceNo { get; set; }

        ////////////////////////////[DataMember(Order = 63, IsRequired = true)]
        public virtual Boolean IsAuthed { get; set; }

        ////////////////////////////[DataMember(Order = 64, IsRequired = false)]
        public virtual Boolean? ISYBFREE3 { get; set; }

        ////////////////////////////[DataMember(Order = 65, IsRequired = true)]
        public virtual Boolean IsUpFee { get; set; }

        ////////////////////////////[DataMember(Order = 66, IsRequired = true)]
        public virtual String LogMMMZYb { get; set; }

        ////////////////////////////[DataMember(Order = 67, IsRequired = true)]
        public virtual String MZYBPatType { get; set; }

        ////////////////////////////[DataMember(Order = 68, IsRequired = true)]
        public virtual Boolean IsYb { get; set; }

        ////////////////////////////[DataMember(Order = 69, IsRequired = false)]
        public virtual double? JmAmount { get; set; }
    }

    [Serializable]
    public class UspGetAdviceHourLast : BaseModel
    {
        public virtual DateTime AdviceTime { get; set; }

        public virtual string HospId { get; set; }

        public virtual string AdviceId { get; set; }

        public virtual string ItemId { get; set; }

        public virtual double Totality { get; set; }

        public virtual Int32 LsPerform { get; set; }

        public virtual Int32 GroupNum { get; set; }

        public virtual string CancelId { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual string LocationId { get; set; }

        public virtual string ExecLocationId { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual Boolean IsInoculate { get; set; }

        public virtual string ReqOperId { get; set; }

        public virtual Int32 LsMarkType { get; set; }

        public virtual string ExecOperId { get; set; }

        public virtual string FrequencyId { get; set; }

        public virtual string UsageId { get; set; }

        public virtual Int32 LsExecLoc { get; set; }

        public virtual DateTime EndOperTime { get; set; }
    }

    [Serializable]
    public class OuRecipeSearchParameter : BaseModel
    {
        //////////////////////////////[DataMember(Order = 1)]
        public virtual DateTime BeginTime { get; set; }
        //////////////////////////////[DataMember(Order = 2)]
        public virtual DateTime EndTime { get; set; }

        //////////////////////////////[DataMember(Order = 3)]
        public virtual string RegTypeId { get; set; }

        //////////////////////////////[DataMember(Order = 4)]
        public virtual string PatTypeId { get; set; }

        //////////////////////////////[DataMember(Order = 5)]
        public virtual int LsRepType { get; set; }
        //////////////////////////////[DataMember(Order = 6)]
        public virtual string LocationId { get; set; }

        //////////////////////////////[DataMember(Order = 7)]
        public virtual bool IsPend { get; set; }
        //////////////////////////////[DataMember(Order = 8)]
        public virtual bool IsCharged { get; set; }

        //////////////////////////////[DataMember(Order = 9)]
        public virtual bool IsDoctorInput { get; set; }
        //////////////////////////////[DataMember(Order = 10)]
        public virtual string DoctorId { get; set; }

        //////////////////////////////[DataMember(Order = 11)]
        public virtual string ItemId { get; set; }

        //////////////////////////////[DataMember(Order = 12)]
        public virtual string PatName { get; set; }
        //////////////////////////////[DataMember(Order = 13)]
        public virtual string CardNo { get; set; }

        //////////////////////////////[DataMember(Order = 14)]
        public virtual string MzRegId { get; set; }

        public OuRecipeSearchParameter() { }

        public OuRecipeSearchParameter(DateTime beginTime, DateTime endTime, string regTypeId, string patTypeId, int lsRepType,
        string locationId, bool isPend, bool isCharged, bool isDoctorInput, string doctorId, string itemId, string patName, string cardNo, string mzRegId)
        {
            this.BeginTime = beginTime;
            this.EndTime = endTime;
            this.RegTypeId = regTypeId;
            this.PatTypeId = patTypeId;
            this.LsRepType = lsRepType;
            this.LocationId = locationId;
            this.IsPend = isPend;
            this.IsCharged = isCharged;
            this.IsDoctorInput = isDoctorInput;
            this.DoctorId = doctorId;
            this.ItemId = itemId;
            this.PatName = patName;
            this.CardNo = cardNo;
            this.MzRegId = mzRegId;
        }

    }

    #region UspOuRecipeDtlNotChargeMzRegId

    [Serializable]
    public class UspOuRecipeDtlNotChargeMzRegId : BaseModel
    {
        //////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual string RecipeId { get; set; }

        //////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual Int32 ListNum { get; set; }

        //////////////[DataMember(Order = 4, IsRequired = true)]
        public virtual string ItemId { get; set; }

        //////////////[DataMember(Order = 5, IsRequired = true)]
        public virtual int GroupNum { get; set; }

        //////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual double Dosage { get; set; }

        //////////////[DataMember(Order = 7, IsRequired = false)]
        public virtual string UnitTakeId { get; set; }

        //////////////[DataMember(Order = 8, IsRequired = false)]
        public virtual string FrequencyId { get; set; }

        //////////////[DataMember(Order = 9, IsRequired = false)]
        public virtual string UsageId { get; set; }

        //////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual int Days { get; set; }

        //////////////[DataMember(Order = 11, IsRequired = true)]
        public virtual double Totality { get; set; }

        //////////////[DataMember(Order = 12, IsRequired = true)]
        public virtual string UnitDiagId { get; set; }

        //////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual Boolean IsAttach { get; set; }

        //////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual Boolean IsOtherFee { get; set; }

        //////////////[DataMember(Order = 15, IsRequired = false)]
        public virtual string XDRpId { get; set; }

        //////////////[DataMember(Order = 16, IsRequired = true)]
        public virtual String Memo { get; set; }

        //////////////[DataMember(Order = 17, IsRequired = true)]
        public virtual Boolean IsCharged { get; set; }

        //////////////[DataMember(Order = 18, IsRequired = true)]
        public virtual Boolean IsCancel { get; set; }

        //////////////[DataMember(Order = 19, IsRequired = false)]
        public virtual DateTime? CancelTime { get; set; }

        //////////////[DataMember(Order = 20, IsRequired = false)]
        public virtual string CancelOperId { get; set; }

        //////////////[DataMember(Order = 21, IsRequired = true)]
        public virtual Boolean IsPrint { get; set; }

        //////////////[DataMember(Order = 22, IsRequired = false)]
        public virtual DateTime? PrintTime { get; set; }

        //////////////[DataMember(Order = 23, IsRequired = false)]
        public virtual string PrintOperId { get; set; }

        //////////////[DataMember(Order = 24, IsRequired = true)]
        public virtual Boolean IsPrepared { get; set; }

        //////////////[DataMember(Order = 25, IsRequired = true)]
        public virtual String PrepareTime { get; set; }

        //////////////[DataMember(Order = 26, IsRequired = false)]
        public virtual string PrepareOperId { get; set; }

        //////////////[DataMember(Order = 27, IsRequired = true)]
        public virtual Boolean IsIssue { get; set; }

        //////////////[DataMember(Order = 28, IsRequired = false)]
        public virtual DateTime? IssueTime { get; set; }

        //////////////[DataMember(Order = 29, IsRequired = false)]
        public virtual string IssueOperId { get; set; }

        //////////////[DataMember(Order = 30, IsRequired = true)]
        public virtual Boolean IsToBack { get; set; }

        //////////////[DataMember(Order = 31, IsRequired = true)]
        public virtual Boolean IsBack { get; set; }

        //////////////[DataMember(Order = 32, IsRequired = false)]
        public virtual Boolean? IsDoctorInput { get; set; }

        //////////////[DataMember(Order = 33, IsRequired = false)]
        public virtual int RecNum { get; set; }

        //////////////[DataMember(Order = 34, IsRequired = false)]
        public virtual DateTime? RecipeTime { get; set; }

        //////////////[DataMember(Order = 35, IsRequired = false)]
        public virtual string LocationId { get; set; }

        //////////////[DataMember(Order = 36, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        //////////////[DataMember(Order = 37, IsRequired = false)]
        public virtual int AllPageNo { get; set; }

        //////////////[DataMember(Order = 38, IsRequired = false)]
        public virtual int PageNo { get; set; }

        //////////////[DataMember(Order = 39, IsRequired = false)]
        public virtual string CureDtlId { get; set; }

        //////////////[DataMember(Order = 40, IsRequired = false)]
        public virtual Boolean? IsBP { get; set; }

        //////////////[DataMember(Order = 41, IsRequired = true)]
        public virtual String BPReason { get; set; }

        //////////////[DataMember(Order = 42, IsRequired = true)]
        public virtual String YbType { get; set; }

        //////////////[DataMember(Order = 43, IsRequired = true)]
        public virtual String InvoNo { get; set; }

        //////////////[DataMember(Order = 44, IsRequired = false)]
        public virtual Boolean? IsAutoCharged { get; set; }

        //////////////[DataMember(Order = 45, IsRequired = false)]
        public virtual Boolean? IsForCharge { get; set; }

        //////////////[DataMember(Order = 46, IsRequired = false)]
        public virtual string ApplyId { get; set; }

        //////////////[DataMember(Order = 47, IsRequired = false)]
        public virtual double Price { get; set; }

        //////////////[DataMember(Order = 48, IsRequired = true)]
        public virtual String TempStr { get; set; }

        //////////////[DataMember(Order = 49, IsRequired = false)]
        public virtual double DiscountAoumt { get; set; }

        //////////////[DataMember(Order = 50, IsRequired = false)]
        public virtual double ChildPrice { get; set; }

        //////////////[DataMember(Order = 51, IsRequired = false)]
        public virtual double DiscountPrice { get; set; }

        //////////////[DataMember(Order = 52, IsRequired = true)]
        public virtual Boolean IsAuthed { get; set; }

        //////////////[DataMember(Order = 53, IsRequired = false)]
        public virtual string SourceId { get; set; }
    }

    #endregion UspOuRecipeDtlNotChargeMzRegId

    [Serializable]
    public class UspOuDrugIssuePatient : BaseModel
    {
        public virtual string TempId { get; set; }

        public virtual string MzRegId { get; set; }

        public virtual String MzRegNo { get; set; }

        public virtual DateTime RegTime { get; set; }

        public virtual String Sex { get; set; }

        public virtual int Age { get; set; }

        public virtual int BabyMonth { get; set; }

        public virtual String AddressHome { get; set; }

        public virtual String IllDesc { get; set; }

        public virtual String Name { get; set; }

        public virtual Int32 LsRepType { get; set; }

        public virtual String RecipeNum { get; set; }

        public virtual DateTime RecipeTime { get; set; }

        public virtual string LocationId { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual Int32 HowMany { get; set; }

        public virtual Boolean IsPriority { get; set; }

        public virtual String Memo { get; set; }

        public virtual Boolean IsPend { get; set; }

        public virtual Boolean IsExecuted { get; set; }

        public virtual String CardNo { get; set; }

        public virtual String ContactPhone { get; set; }

        public virtual String PyCode1 { get; set; }

        public virtual String WbCode1 { get; set; }

        public virtual String PyCode2 { get; set; }

        public virtual String WbCode2 { get; set; }

        public virtual String PyCode3 { get; set; }

        public virtual String WbCode3 { get; set; }

        public virtual double Amount { get; set; }

        public virtual int HospitalId { get; set; }

        public virtual int HospitalId1 { get; set; }

        public virtual Boolean IsPrinted { get; set; }

        public virtual Boolean IsPutDrug { get; set; }

        public virtual String DoctorName { get; set; }

        public virtual String LocationName { get; set; }

        public virtual string PatId { get; set; }

        public virtual int HospitalId2 { get; set; }

        public virtual Boolean IsPrinted1 { get; set; }

        public virtual Boolean IsPutDrug1 { get; set; }

        public virtual String PatTypeName { get; set; }

        public virtual String RoomWindowName { get; set; }

        public virtual Int32 LsReportType { get; set; }

        public virtual String IsCancel { get; set; }
    }

    [Serializable]
    public class UspOuNotReChargeDrugIssued : BaseModel
    {
        public virtual DateTime CancelOperTime { get; set; }
        public virtual String MzRegNo { get; set; }
    }

    [Serializable]
    public class UspOuDrugIssueTemp : BaseModel
    {
        public virtual string TempId { get; set; }

        public virtual string MzRegId { get; set; }

        public virtual String MzRegNo { get; set; }

        public virtual String MzRegNoLong { get; set; }

        public virtual DateTime RegTime { get; set; }

        public virtual String Sex { get; set; }

        public virtual Int32 Age { get; set; }

        public virtual Int32 BabyMonth { get; set; }

        public virtual String AddressHome { get; set; }

        public virtual String IllDesc { get; set; }

        public virtual String Name { get; set; }

        public virtual Int32 LsRepType { get; set; }

        public virtual String RecipeNum { get; set; }

        public virtual DateTime RecipeTime { get; set; }

        public virtual string LocationId { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual Int32 HowMany { get; set; }

        public virtual Boolean IsPriority { get; set; }

        public virtual String Memo { get; set; }

        public virtual Boolean IsPend { get; set; }

        public virtual Boolean IsExecuted { get; set; }

        public virtual String CardNo { get; set; }

        public virtual String ContactPhone { get; set; }

        public virtual String PyCode1 { get; set; }

        public virtual String WbCode1 { get; set; }

        public virtual String PyCode2 { get; set; }

        public virtual String WbCode2 { get; set; }

        public virtual String PyCode3 { get; set; }

        public virtual String WbCode3 { get; set; }

        public virtual double Amount { get; set; }

        public virtual String DoctorName { get; set; }

        public virtual String LocationName { get; set; }

        public virtual int HospitalId { get; set; }

        public virtual Boolean IsOuAddInvo { get; set; }

        public virtual string PatTypeId { get; set; }

        public virtual Boolean IsPrinted { get; set; }

        public virtual string PatId { get; set; }

        public virtual string PatId1 { get; set; }

        public virtual String PatTypeName { get; set; }

        public virtual String RoomWindowName { get; set; }

        public virtual Int32 LsReportType { get; set; }

        public virtual Boolean IsDoctorInput { get; set; }

        public virtual DateTime InvoTime { get; set; }

        public virtual Boolean IsCancel { get; set; }

        public virtual String InvoNo { get; set; }
    }

    [Serializable]
    public class UspPrintCkBldApplyreport : BaseModel
    {
        public virtual String PatName { get; set; }

        public virtual String sex { get; set; }

        public virtual String AgeString { get; set; }

        public virtual String Inpatno { get; set; }

        public virtual String BedName { get; set; }

        public virtual String illness { get; set; }

        public virtual String Purpose { get; set; }

        public virtual String PatBloodGroup { get; set; }

        public virtual String Hstyblood { get; set; }

        public virtual String LocName { get; set; }

        public virtual String TESTRESULT { get; set; }

        public virtual double Vollume { get; set; }

        public virtual DateTime OPERTIME { get; set; }

        public virtual String DocName { get; set; }

        public virtual String DocName1 { get; set; }

        public virtual String DocName2 { get; set; }

        public virtual Boolean IsSection { get; set; }

        public virtual Boolean IsMed { get; set; }

        public virtual Int32 VollumeTwo { get; set; }

        public virtual String UNITTwo { get; set; }

        public virtual String RecNo { get; set; }

        public virtual String HB { get; set; }

        public virtual String PLT { get; set; }

        public virtual String HCT { get; set; }

        public virtual String ALT { get; set; }

        public virtual String HBsAg { get; set; }

        public virtual String AntiHCV { get; set; }

        public virtual String Anti_AIV1_2 { get; set; }

        public virtual String 梅毒 { get; set; }

        public virtual String Name { get; set; }
    }

    [Serializable]
    public class UspOuRecipeDisposalPrint : BaseModel
    {
        public virtual string RecipeID { get; set; }

        public virtual String SequenceNum { get; set; }

        public virtual String Recipe_Num { get; set; }

        public virtual String Spec { get; set; }

        public virtual string UsageId { get; set; }

        public virtual String RecipeMemo { get; set; }

        public virtual double PubSpec { get; set; }

        public virtual String PubUnit_Take { get; set; }

        public virtual String Unit_Take { get; set; }

        public virtual String Unit_Diag { get; set; }

        public virtual String UsageName { get; set; }

        public virtual String Hz { get; set; }

        public virtual String Frequency { get; set; }

        public virtual double Dosage { get; set; }

        public virtual double Totality { get; set; }

        public virtual String PrepareTime { get; set; }

        public virtual string MzRegId { get; set; }

        public virtual String Memo { get; set; }

        public virtual String Form_Name { get; set; }

        public virtual Int32 List_Num { get; set; }

        public virtual Int32 Int_Code { get; set; }

        public virtual Boolean IsCancel { get; set; }

        public virtual String Item_Desc { get; set; }

        public virtual Int32 Group_Num { get; set; }

        public virtual Int32 Drug_Type { get; set; }

        public virtual Int32 days { get; set; }

        public virtual String Item_Code { get; set; }

        public virtual Boolean IsCharge { get; set; }

        public virtual Int32 Rp_Type { get; set; }

        public virtual double Price_In { get; set; }

        public virtual double Amount { get; set; }

        public virtual String PatientName { get; set; }

        public virtual String DoctorName { get; set; }

        public virtual String PatTypeName { get; set; }

        public virtual String LocationName { get; set; }

        public virtual Int32 Age { get; set; }

        public virtual Int32 BabyMonth { get; set; }

        public virtual String Sex { get; set; }

        public virtual DateTime RecipeTime { get; set; }

        public virtual String PhoneHome { get; set; }

        public virtual String AddressHome { get; set; }

        public virtual String IllDesc { get; set; }

        public virtual String AccountNo { get; set; }

        public virtual string XDRpId { get; set; }

        public virtual Boolean IsNurseExecute { get; set; }

        public virtual string UnitDiagId { get; set; }

        public virtual string UnitTakeId { get; set; }

        public virtual string FormId { get; set; }

        public virtual Boolean IsAttach { get; set; }

        public virtual string FrequencyId { get; set; }

        public virtual String InvoNo { get; set; }

        public virtual string DoctorId { get; set; }
    }

    [Serializable]
    public class UspGetRdInfectiousInfo : BaseModel
    {
        public virtual string MzRegId { get; set; }

        public virtual String Code { get; set; }

        public virtual String PatNo { get; set; }

        public virtual String LsCardTypeName { get; set; }

        public virtual String LsCensusName { get; set; }

        public virtual string PatId { get; set; }

        public virtual String PatName { get; set; }

        public virtual String JName { get; set; }

        public virtual String PatIdCardNo { get; set; }

        public virtual String PatSex { get; set; }

        public virtual String AgeString { get; set; }

        public virtual DateTime PatBirthDate { get; set; }

        public virtual String PatCompany { get; set; }

        public virtual String PatMobile { get; set; }

        public virtual String LsZoneName { get; set; }

        public virtual String PatAddressHome { get; set; }

        public virtual String Midwife { get; set; }

        public virtual String LsCancelTypeName { get; set; }

        public virtual DateTime IllDate { get; set; }

        public virtual DateTime InTime { get; set; }

        public virtual DateTime DeadDate { get; set; }

        public virtual DateTime DiagDate { get; set; }

        public virtual String LsPreventiveName { get; set; }

        public virtual String J { get; set; }

        public virtual String y { get; set; }

        public virtual String B { get; set; }

        public virtual String Q { get; set; }

        public virtual String D { get; set; }

        public virtual String CancelMemo { get; set; }

        public virtual String ReportUnit { get; set; }

        public virtual String LocIdName { get; set; }

        public virtual String Phone { get; set; }

        public virtual String OperIDName { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual String Memo { get; set; }

        public virtual DateTime ReportDate { get; set; }

        public virtual String Name { get; set; }

        public virtual String ReciOperName { get; set; }
    }

    [Serializable]
    public class UspDoctorMutiLocation : BaseModel
    {
        public virtual String Code { get; set; }

        public virtual String Name { get; set; }

        public virtual String Sex { get; set; }

        public virtual DateTime BirthDate { get; set; }

        public virtual String Address { get; set; }

        public virtual String City { get; set; }

        public virtual String Mobile { get; set; }

        public virtual String Email { get; set; }

        public virtual string LevelId { get; set; }

        public virtual string DocLevId { get; set; }

        public virtual string LocationId { get; set; }

        public virtual string RegTypeId { get; set; }

        public virtual String PicturePath { get; set; }

        public virtual Int32 LsStatus { get; set; }

        public virtual Int32 OrderBy { get; set; }

        public virtual Boolean IsPoisonMa { get; set; }

        public virtual Boolean IsRecipe { get; set; }

        public virtual Int32 Grade { get; set; }

        public virtual Boolean IsConsult { get; set; }

        public virtual Int32 IconIndex { get; set; }

        public virtual string UserId { get; set; }
    }

    [Serializable]
    public class UspOuDoctorPlan : BaseModel
    {
        public virtual String Code { get; set; }

        public virtual String Name { get; set; }

        public virtual String Sex { get; set; }

        public virtual string DocLevId { get; set; }

        public virtual string RegTypeId { get; set; }

        public virtual String RegTypeName { get; set; }

        public virtual String DocLevelName { get; set; }

        public virtual Int32 IconIndex { get; set; }

        public virtual Int32 LsInOut { get; set; }

        public virtual String LocationName { get; set; }

        public virtual string LocationId { get; set; }

        public virtual String Address { get; set; }

        public virtual Int32 LimitNum { get; set; }

        public virtual Int32 HasDiagnoseNum { get; set; }

        public virtual string TimeSpanId { get; set; }

        public virtual String TimeSpanName { get; set; }

        public virtual Int32 OrderBy { get; set; }

        public virtual Int32 RegNum { get; set; }

        public virtual Int32 ResNum { get; set; }

        public virtual Int32 LastLimitNum { get; set; }
    }

    [Serializable]
    public class UserWithDocRegTypeTimeSpan : BaseModel
    {
        public OuDocRegType OuDocRegType { get; set; }
        public string TimeSpan { get; set; }
    }

    [Serializable]
    public class UspGetOuDocMyPat : BaseModel
    {
        public virtual DateTime OperTime { get; set; }

        public virtual String Memo { get; set; }

        public virtual Boolean IsAlert { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual string PatId { get; set; }

        public virtual String OperName { get; set; }

        public virtual String PatName { get; set; }

        public virtual String DoctorName { get; set; }

        public virtual Int32 days { get; set; }
    }

    [Serializable]
    public class UspOuDoctorPlanPre : BaseModel
    {
        public virtual String Code { get; set; }

        public virtual String Name { get; set; }

        public virtual String Sex { get; set; }

        public virtual string DocLevId { get; set; }

        public virtual string RegTypeId { get; set; }

        public virtual String RegTypeName { get; set; }

        public virtual String DocLevelName { get; set; }

        public virtual Int32 IconIndex { get; set; }

        public virtual Int32 LsInOut { get; set; }

        public virtual String LocationName { get; set; }

        public virtual string LocationId { get; set; }

        public virtual String Address { get; set; }

        public virtual Int32 LimitNum { get; set; }

        public virtual Int32 HasDiagnoseNum { get; set; }

        public virtual string TimeSpanId { get; set; }

        public virtual String TimeSpanName { get; set; }
    }

    [Serializable]
    public class UspOuDocSpanSubPre : BaseModel
    {
        public virtual string WEEKPLANID { get; set; }

        public virtual Int32 SPANLIMITNUM { get; set; }

        public virtual Int32 SUBLIMITNUM { get; set; }

        public virtual string TIMESPANSUBID { get; set; }

        public virtual String name { get; set; }

        public virtual string DayPlanId { get; set; }

        public virtual Boolean IsAuthed { get; set; }
    }

    [Serializable]
    public class UspOuEmrOuClincDiagByMzRegId : BaseModel
    {
        public virtual DateTime RegTime { get; set; }

        public virtual String IllDesc { get; set; }
    }

    [Serializable]
    public class DrugWhitCheckDrug
    {
        public IList<BsUsage> LstBsUsage { set; get; }
        public IList<BsItem> lstBsItem { set; get; }

    }

    #region UspInChinRicipeDtl

    [Serializable]
    public class UspInChinRicipeDtl : BaseModel
    {
        //////////////[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //////////////[DataMember(Order = 2, IsRequired = true)]
        public virtual String Name { get; set; }

        //////////////[DataMember(Order = 3, IsRequired = true)]
        public virtual String Spec { get; set; }

        //////////////[DataMember(Order = 4, IsRequired = false)]
        public virtual string FormId { get; set; }

        //////////////[DataMember(Order = 5, IsRequired = false)]
        public virtual int LsRpType { get; set; }

        //////////////[DataMember(Order = 6, IsRequired = true)]
        public virtual String Code { get; set; }

        //////////////[DataMember(Order = 7, IsRequired = false)]
        public virtual double PriceIn { get; set; }

        //////////////[DataMember(Order = 8, IsRequired = true)]
        public virtual string RecipeId { get; set; }

        //////////////[DataMember(Order = 9, IsRequired = true)]
        public virtual string ItemId { get; set; }

        //////////////[DataMember(Order = 10, IsRequired = false)]
        public virtual double Amount { get; set; }

        //////////////[DataMember(Order = 11, IsRequired = true)]
        public virtual double Dosage { get; set; }

        //////////////[DataMember(Order = 12, IsRequired = true)]
        public virtual string UnitTakeId { get; set; }

        //////////////[DataMember(Order = 13, IsRequired = true)]
        public virtual int LsDecoctWay { get; set; }

        //////////////[DataMember(Order = 14, IsRequired = true)]
        public virtual String Memo { get; set; }

        //////////////[DataMember(Order = 15, IsRequired = true)]
        public virtual string OperId { get; set; }

        //////////////[DataMember(Order = 16, IsRequired = false)]
        public virtual DateTime? OperTime { get; set; }

        //////////////[DataMember(Order = 17, IsRequired = false)]
        public virtual string DetailId { get; set; }

        //////////////[DataMember(Order = 18, IsRequired = false)]
        public virtual double Price { get; set; }
    }

    #endregion UspInChinRicipeDtl

    [Serializable]
    public class RecipeWithSaveInAdviceNurseList : BaseModel
    {

        public List<UspInAdviceNurseList> lstInAdviceNurseList { set; get; }


        public List<UspInAdviceNurseList> lstEndInAdviceNurseList { set; get; }


        public List<UspInAdviceNurseList> lstUnEndInAdviceNurseList { set; get; }


        public List<UspInAdviceNurseList> lstDelInAdviceNurseList { set; get; }


        public List<BsLocation> lstBsLocation { set; get; }


        public int lsPriceState { set; get; }


        public string doctorId { set; get; }


        public string userId { set; get; }


        public string toolsLocationId { set; get; }


        public string userProfilesLocationID { set; get; }
    }

    [Serializable]
    public class RefreshGridWhitRefreshGridViewByHost : BaseModel
    {
        public List<AdviceAuthDtl> LstCurrenAdvice { get; set; }
        public List<InAdviceGroup> LstInAdviceGroup { get; set; }
        public double ArrearAmount { get; set; }
    }

    [Serializable]
    public class UspBsItemAttach : BaseModel
    {
        public virtual Int32 IsNew { get; set; }

        public virtual string ItemId1 { get; set; }

        public virtual string ItemId2 { get; set; }

        public virtual String Code { get; set; }

        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual string UnitInId { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual string UnitDiagId { get; set; }

        public virtual double PriceDiag { get; set; }

        public virtual Boolean IsRpForbid { get; set; }

        public virtual Boolean IsActive { get; set; }

        public virtual string PatinetId { get; set; }

        public virtual Int32 OrderBy { get; set; }

        public virtual double Totality { get; set; }

        public virtual Int32 LsUseArea { get; set; }

        public virtual double Amount { get; set; }

        public virtual Boolean IsSelect { get; set; }

        public virtual String LsMarkType { get; set; }

        public virtual String SN { get; set; }
    }

    [Serializable]
    public class UspItemSesrchDmt2 : BaseModel
    {
        public virtual String Name { get; set; }

        public virtual String Spec { get; set; }

        public virtual String UnitName { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual String FeetyName { get; set; }

        public virtual String ManufacturerName { get; set; }

        public virtual String ProvinceCode { get; set; }
    }

    [Serializable]
    public class UspGetHosptailItems : BaseModel
    {
        public virtual Int32 LsRpType { get; set; }

        public virtual String Code { get; set; }

        public virtual string TallyGroupId { get; set; }

        public virtual String Name { get; set; }

        public virtual String YbCode { get; set; }

        public virtual String YbDesc { get; set; }

        public virtual String PyCode { get; set; }

        public virtual String WbCode { get; set; }

        public virtual String DrugCode { get; set; }

        public virtual String Spec { get; set; }

        public virtual String DrugFormName { get; set; }

        public virtual double ZYPrince { get; set; }

        public virtual double MZPrince { get; set; }

        public virtual String ManuName { get; set; }

        public virtual String LsYbType { get; set; }
    }

    [Serializable]
    public class UspBsItemMiniSelectOnly : BaseModel
    {
        public virtual String Code { get; set; }

        public virtual String WbCode { get; set; }

        public virtual String PyCode { get; set; }

        public virtual String StrokeCode { get; set; }

        public virtual Boolean IsActive { get; set; }

        public virtual String OtherCode { get; set; }

        public virtual String LongDesc { get; set; }

        public virtual String EngDesc { get; set; }

        public virtual String Spec { get; set; }

        public virtual String NAME { get; set; }

        public virtual String UnitInName { get; set; }

        public virtual Int32 LsGfType { get; set; }

        public virtual Boolean IsSpecial { get; set; }

        public virtual Boolean IsSpecSum { get; set; }

        public virtual Boolean IsRpForbid { get; set; }

        public virtual Boolean OptionPrice { get; set; }

        public virtual Int32 LsRpType { get; set; }

        public virtual String UnitDiagName { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual double PriceDiag { get; set; }

        public virtual String Memo { get; set; }

        public virtual Int32 OrderBy { get; set; }

        public virtual double StockPriceKc { get; set; }

        public virtual String MultiPy { get; set; }

        public virtual String MultiWb { get; set; }

        public virtual String MultiName { get; set; }

        public virtual String style { get; set; }

        public virtual String OrderNo { get; set; }

        public virtual String YblimitCue { get; set; }
    }

    [Serializable]
    public class UspGetBsItemGroupTree : BaseModel
    {
        public virtual String Name { get; set; }

        public virtual String ParentID { get; set; }
    }

    [Serializable]
    public class UspGetBsMzFeetyByLsRpType : BaseModel
    {
        public virtual String Code { get; set; }

        public virtual String Name { get; set; }

        public virtual string InvItemId { get; set; }

        public virtual String WbCode { get; set; }

        public virtual String PyCode { get; set; }

        public virtual string LocationId { get; set; }

        public virtual Boolean IsActive { get; set; }

        public virtual Int32 OrderBy { get; set; }

        public virtual Int32 IconIndex { get; set; }

        public virtual String CheckType { get; set; }

        public virtual Int32 CheckOrderby { get; set; }

        public virtual String CheckGroup { get; set; }
    }

    [Serializable]
    public class UspBsItemMiniUnClinicIsActive : BaseModel
    {
        public virtual Int32 Column1 { get; set; }
        public virtual String Code { get; set; }

        public virtual String WbCode { get; set; }

        public virtual String PyCode { get; set; }

        public virtual String StrokeCode { get; set; }

        public virtual Boolean IsActive { get; set; }

        public virtual String OtherCode { get; set; }

        public virtual String LongDesc { get; set; }

        public virtual String EngDesc { get; set; }

        public virtual String Spec { get; set; }

        public virtual String Name { get; set; }

        public virtual String UnitInName { get; set; }

        public virtual Int32 LsGfType { get; set; }

        public virtual Boolean IsSpecial { get; set; }

        public virtual double StockPriceKc { get; set; }

        public virtual Boolean IsRpForbid { get; set; }

        public virtual Int32 LsRpType { get; set; }

        public virtual String UnitDiagName { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual double PriceDiag { get; set; }

        public virtual String Memo { get; set; }

        public virtual Int32 OrderBy { get; set; }

        public virtual String MultiPy { get; set; }

        public virtual String MultiWb { get; set; }

        public virtual String MultiName { get; set; }

        public virtual double StockNum { get; set; }

        public virtual String ExecLocation { get; set; }

        public virtual String style { get; set; }

        public virtual String OrderNo { get; set; }

        public virtual String BasalDrugType { get; set; }

        public virtual String YblimitCue { get; set; }
    }

    [Serializable]
    public class UspBsItemMiniSelectIsActive : BaseModel
    {
        public virtual Int32 Column1 { get; set; }

        public virtual String Code { get; set; }

        public virtual String WbCode { get; set; }

        public virtual String PyCode { get; set; }

        public virtual String StrokeCode { get; set; }

        public virtual Boolean IsActive { get; set; }

        public virtual String OtherCode { get; set; }

        public virtual String LongDesc { get; set; }

        public virtual String EngDesc { get; set; }

        public virtual String Spec { get; set; }

        public virtual String Name { get; set; }

        public virtual String UnitInName { get; set; }

        public virtual Int32 LsGfType { get; set; }

        public virtual Boolean IsSpecial { get; set; }

        public virtual double StockPriceKc { get; set; }

        public virtual Boolean IsRpForbid { get; set; }

        public virtual Int32 LsRpType { get; set; }

        public virtual String UnitDiagName { get; set; }

        public virtual double PriceIn { get; set; }

        public virtual double PriceDiag { get; set; }

        public virtual String Memo { get; set; }

        public virtual Int32 OrderBy { get; set; }

        public virtual String MultiPy { get; set; }

        public virtual String MultiWb { get; set; }

        public virtual String MultiName { get; set; }

        public virtual double StockNum { get; set; }

        public virtual String ExecLocation { get; set; }

        public virtual String style { get; set; }

        public virtual String OrderNo { get; set; }

        public virtual String BasalDrugType { get; set; }

        public virtual String YblimitCue { get; set; }
    }

    [Serializable]
    public class UspVisitRecordMessage : BaseModel
    {
        public virtual bool IsSelected { get; set; }

        public virtual string PatientName { get; set; }

        public virtual string Sex { get; set; }

        public virtual string AgeString { get; set; }

        public virtual string Mobile { get; set; }

        public virtual DateTime VisitTime { get; set; }

        public virtual int VisitType { get; set; }

        public virtual string VisitContent { get; set; }

        public virtual int VisitStatus { get; set; }

        public virtual string OperID { get; set; }
    }

    [Serializable]
    public class UspVisitRecordDynamic : BaseModel
    {
        public virtual DateTime VisitTime { get; set; }

        public virtual string OperId { get; set; }

        public virtual string OperName { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual int VisitType { get; set; }

        public virtual string VisitTypeName { get; set; }

        public virtual string VisitContent { get; set; }

        public virtual string PatID { get; set; }

        public virtual string CardNo { get; set; }

        public virtual string PatName { get; set; }

        public virtual string SexName { get; set; }

        public virtual string MzRegId { get; set; }

        public virtual string BackContent { get; set; }

        public virtual int VisitStatus { get; set; }

        public virtual string VisitStatusName { get; set; }

        public virtual int AppraiseType { get; set; }

        public virtual string AppraiseTypeName { get; set; }

        public virtual string DoctorId { get; set; }

        public virtual string DoctorName { get; set; }

        public virtual bool IsAuthed { get; set; }
    }

    [Serializable]
    public class UspVisitPatientMessage : BaseModel
    {
        public virtual bool IsSelected { get; set; }

        public virtual string CardNo { get; set; }

        public virtual string PatientName { get; set; }

        public virtual string Sex { get; set; }

        public virtual string AgeString { get; set; }

        public virtual string Mobile { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual string VipCardNo { get; set; }

        public virtual string VipLevelId { get; set; }

        public virtual DateTime CreateTime { get; set; }
    }

    [Serializable]
    public class VisitPatientMessage
    {
        public DateTime BeginTime { set; get; }

        public DateTime EndTime { set; get; }

        public string PatientName { set; get; }

        public string CardNo { get; set; }

        public string VipCardNo { get; set; }

        public string VipLevelId { set; get; }

    }

    [Serializable]
    public class UspTestFromOuRecipe : BaseModel
    {
        public virtual string GUID { get; set; }

        public virtual string AsId { get; set; }
        public virtual String Code { get; set; }
        public virtual int LsTestType { get; set; }
        public virtual string TestTypeId { get; set; }
        public virtual String ShortName { get; set; }
        public virtual String Name { get; set; }

        public virtual String OperMemo { get; set; }
        public virtual int LsGroup { get; set; }
        public virtual double Price { get; set; }
        public virtual String Unit { get; set; }
        public virtual string ItemId { get; set; }
        public virtual Boolean IsActive { get; set; }
        public virtual string TestId { get; set; }
        public virtual int LsStatus { get; set; }
        public virtual string TubeTypeId { get; set; }
        public virtual string SourceId { get; set; }

        public virtual String TestTypeName { get; set; }
        public virtual String SourceName { get; set; }

        public virtual string ParentID { get; set; }

        public virtual string LabId { get; set; }

        public virtual string XDRpId { get; set; }

        public virtual double Totality { get; set; }

        public virtual String UseType { get; set; }

        public virtual Boolean IsAutoCharged { get; set; }

        public virtual string ItemIdF5 { get; set; }

    }

    [Serializable]
    public class UspCkMainInfo : BaseModel
    {
        public virtual string GUID { get; set; }

        public virtual DateTime CheckTime { get; set; }

        public virtual String PatientName { get; set; }

        public virtual string PatId { get; set; }

        public virtual String CompanyName { get; set; }

        public virtual DateTime BirthDate { get; set; }

        public virtual String SexName { get; set; }

        public virtual int Age { get; set; }

        public virtual String Memo { get; set; }
    }

    [Serializable]
    public class TestSystemWithLabAndPatient : BaseModel
    {
        public CkLab CkLab { set; get; }

        public InHosInfo InHosInfo { set; get; }

        public OuHosInfo OuHosInfo { set; get; }

        public BsLocation BsLocation { set; get; }

        public BsPatient BsPatient { set; get; }

        /// <summary>
        /// 是否门诊  true  门诊；  false  住院
        /// </summary>       
        public bool IsOu { set; get; }

    }

    [Serializable]
    public class TestSystemServiceWithGetCkLabCollectRecord : BaseModel
    {
        public IList<UspCkLabRecieve> LstFinished { set; get; }
        public IList<UspCkLabRecieve> LstNotFinished { set; get; }

    }

    //public class UspVisitRecordUserByUserId : BaseModel
    //{
    //    public virtual bool IsSelected { get; set; }

    //    public virtual string Code { get; set; }

    //    public virtual string Name { get; set; }

    //    public virtual string Mobile { get; set; }

    //    public virtual string UserId { get; set; }

    //    public virtual string DoctorId { get; set; }

    //    public virtual int LsUserRole { get; set; }
    //}

    [Serializable]
    public class TestSystemWithCkLab : BaseModel
    {
        public string LabNum { set; get; }

        public string OperId { set; get; }

        public int LsStatus { set; get; }
    }

 

    [Serializable]
    public class TestCkWithItemTestRelation : BaseModel
    {
        //[DataMember]
        public CkItem infoCkItem { set; get; }

        //[DataMember]
        public IList<CkItemQc> lstCkItemQc { set; get; }

        //[DataMember]
        public IList<CkItemResult> lstCkItemResult { set; get; }

        //[DataMember]
        public IList<CkItemRange> lstCkItemRange { set; get; }

        //[DataMember]
        public IList<CkMachinePassage> lstCkMachinePassage { set; get; }

        //[DataMember]
        public IList<CkFormula> lstCkFormula { set; get; }

        //[DataMember]
        public IList<CkProfile> lstCkProfile { set; get; }
    }

    [Serializable]
    public class TestCkWithItemPhysicalExaminationRelation : BaseModel
    {
        //[DataMember]
        public CkItem infoCkItem { set; get; }

        //[DataMember]
        public IList<CkProfile> lstCkProfile { set; get; }

        //[DataMember]
        public IList<CkItemQc> lstCkItemQc { set; get; }

        //[DataMember]
        public IList<CkFormula> lstCkFormula { set; get; }

        //[DataMember]
        public IList<CkItemResult> lstCkItemResult { set; get; }

        //[DataMember]
        public IList<CkItemRange> lstCkItemRange { set; get; }

        //[DataMember]
        public IList<CkMachinePassage> lstCkMachinePassage { set; get; }
    }

    [Serializable]
    public class UspyyOuDoctorPlan : BaseModel
    {
        public virtual String Code { get; set; }

        public virtual String Name { get; set; }

        public virtual String Sex { get; set; }

        public virtual string DocLevId { get; set; }

        public virtual string RegTypeId { get; set; }

        public virtual String RegTypeName { get; set; }

        public virtual String DocLevelName { get; set; }

        public virtual Int32 IconIndex { get; set; }

        public virtual Int32 LsInOut { get; set; }

        public virtual String LocationName { get; set; }

        public virtual string LocationId { get; set; }

        public virtual String Address { get; set; }

        public virtual Int32 LimitNum { get; set; }

        public virtual Int32 HasDiagnoseNum { get; set; }

        public virtual string TimeSpanId { get; set; }

        public virtual String TimeSpanName { get; set; }

        public virtual Int32 OrderBy { get; set; }

        public virtual String TimeBegin { get; set; }

        public virtual String TimeEnd { get; set; }

        public virtual Boolean IsSpecial { get; set; }

        public virtual Int32 RegNum { get; set; }

        public virtual Int32 ResNum { get; set; }

        public virtual Int32 LastLimitNum { get; set; }
    }

    [Serializable]
    public class UspCkQcResultShowImage : BaseModel
    {
        public string GUID { get; set; }
        public string QcName { get; set; }
        public string MachineName { get; set; }
        public string ControlName { get; set; }
        public string ControlID { get; set; }
        public string TestId { get; set; }
        public string Code { get; set; }
        public string TestName { get; set; }
        public DateTime ResultDate { get; set; }
        public string Result { get; set; }
        public string ResultComment { get; set; }
        public string QcLotCode { get; set; }
        public string SourceName { get; set; }
        public string UserName { get; set; }
        public string Unit { get; set; }
        public string TestType { get; set; }
        public Int32 Status { get; set; }
        public string TestWay { get; set; }
        public double Dev3 { get; set; }
        public double Dev2 { get; set; }
        public double Dev1 { get; set; }
        public double DevM1 { get; set; }
        public double DevM2 { get; set; }
        public double DevM3 { get; set; }
        public double AvgValue { get; set; }
        public double Stdevs { get; set; }
    }

    [Serializable]
    public class TestSystemWithQcResultIMage : BaseModel
    {
        public DateTime? endTime { set; get; }
        public DateTime? beginTime { set; get; }
        public string testId { set; get; }
        public string machineId { set; get; }
        public string controlId { set; get; }
        public string sampleNum { set; get; }
    }

    [Serializable]
    public class TestSystemWithItemQc : BaseModel
    {
        public string TestId { set; get; }
        public string CtrlId { set; get; }
        public string TestTypeId { set; get; }
        public string MachineId { set; get; }
    }

    [Serializable]
    public class TestSystemWithQcResult : BaseModel
    {
        public DateTime begTime { set; get; }
        public DateTime endTime { set; get; }
        public bool? showQC { set; get; }
        public string ckItem { set; get; }
        public string ctrlId { set; get; }
        public string TestTypeId { set; get; }
    }

    #region UspCkResultById

    [Serializable]
    public class UspCkResultById : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual String PatientNo { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual String PatientName { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual string CheckId { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual string TestId { get; set; }

        //[DataMember(Order = 6, IsRequired = true)]
        public virtual String ShortName { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual String Name { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual String Code { get; set; }

        //[DataMember(Order = 9, IsRequired = false)]
        public virtual int LsTestType { get; set; }

        //[DataMember(Order = 10, IsRequired = false)]
        public virtual string TestTypeId { get; set; }

        //[DataMember(Order = 11, IsRequired = true)]
        public virtual String TestTypeName { get; set; }

        //[DataMember(Order = 12, IsRequired = false)]
        public virtual string TestGroupId { get; set; }

        //[DataMember(Order = 13, IsRequired = true)]
        public virtual String TestGroupName { get; set; }

        //[DataMember(Order = 14, IsRequired = false)]
        public virtual Boolean? IsZero { get; set; }

        //[DataMember(Order = 15, IsRequired = false)]
        public virtual int LsGroup { get; set; }

        //[DataMember(Order = 16, IsRequired = false)]
        public virtual Boolean? IsReport { get; set; }

        //[DataMember(Order = 17, IsRequired = true)]
        public virtual String UseRange { get; set; }

        //[DataMember(Order = 18, IsRequired = true)]
        public virtual String Unit { get; set; }

        //[DataMember(Order = 19, IsRequired = true)]
        public virtual String Format { get; set; }

        //[DataMember(Order = 20, IsRequired = false)]
        public virtual double LimitHigh { get; set; }

        //[DataMember(Order = 21, IsRequired = false)]
        public virtual double LimitLow { get; set; }

        //[DataMember(Order = 22, IsRequired = true)]
        public virtual String PrintHigh { get; set; }

        //[DataMember(Order = 23, IsRequired = true)]
        public virtual String PrintLow { get; set; }

        //[DataMember(Order = 24, IsRequired = false)]
        public virtual double DefaultDalAbsolute { get; set; }

        //[DataMember(Order = 25, IsRequired = false)]
        public virtual double DefaultDalPercent { get; set; }

        //[DataMember(Order = 26, IsRequired = false)]
        public virtual int OrderBy { get; set; }

        //[DataMember(Order = 27, IsRequired = false)]
        public virtual Boolean? IsDisplay { get; set; }

        //[DataMember(Order = 28, IsRequired = false)]
        public virtual Boolean? IsActive { get; set; }

        //[DataMember(Order = 29, IsRequired = false)]
        public virtual int LsStatus { get; set; }

        //[DataMember(Order = 30, IsRequired = true)]
        public virtual String Result { get; set; }

        //[DataMember(Order = 31, IsRequired = true)]
        public virtual String LastResult { get; set; }

        //[DataMember(Order = 32, IsRequired = false)]
        public virtual int LsRefFlag { get; set; }

        //[DataMember(Order = 33, IsRequired = false)]
        public virtual Boolean? IsPanic { get; set; }

        //[DataMember(Order = 34, IsRequired = false)]
        public virtual Boolean? IsDalta { get; set; }

        //[DataMember(Order = 35, IsRequired = false)]
        public virtual double DalAbsolute { get; set; }

        //[DataMember(Order = 36, IsRequired = false)]
        public virtual double DalPercent { get; set; }

        //[DataMember(Order = 37, IsRequired = false)]
        public virtual double LowValue { get; set; }

        //[DataMember(Order = 38, IsRequired = false)]
        public virtual double HighValue { get; set; }

        //[DataMember(Order = 39, IsRequired = false)]
        public virtual double PanicLow { get; set; }

        //[DataMember(Order = 40, IsRequired = false)]
        public virtual double PanicHigh { get; set; }

        //[DataMember(Order = 41, IsRequired = false)]
        public virtual Boolean? IsPass { get; set; }

        //[DataMember(Order = 42, IsRequired = false)]
        public virtual DateTime? ReportDate { get; set; }

        //[DataMember(Order = 43, IsRequired = true)]
        public virtual String ReportBy { get; set; }

        //[DataMember(Order = 44, IsRequired = false)]
        public virtual Boolean? IsPrint { get; set; }

        //[DataMember(Order = 45, IsRequired = true)]
        public virtual String Memo { get; set; }

        //[DataMember(Order = 46, IsRequired = false)]
        public virtual string ParentID { get; set; }

        //[DataMember(Order = 47, IsRequired = true)]
        public virtual String CheckNo { get; set; }

        //[DataMember(Order = 48, IsRequired = false)]
        public virtual string PatId { get; set; }

        //[DataMember(Order = 49, IsRequired = false)]
        public virtual DateTime? CheckTime { get; set; }

        //[DataMember(Order = 50, IsRequired = false)]
        public virtual string CompanyCkeckId { get; set; }

        //[DataMember(Order = 51, IsRequired = false)]
        public virtual string LocationId { get; set; }

        //[DataMember(Order = 52, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        //[DataMember(Order = 53, IsRequired = false)]
        public virtual Boolean? IsCancel { get; set; }

        //[DataMember(Order = 54, IsRequired = false)]
        public virtual DateTime? OperTime { get; set; }

        //[DataMember(Order = 55, IsRequired = false)]
        public virtual string OperId { get; set; }

        //[DataMember(Order = 56, IsRequired = false)]
        public virtual string CompanyId { get; set; }

        //[DataMember(Order = 57, IsRequired = true)]
        public virtual String CompanyName { get; set; }

        //[DataMember(Order = 58, IsRequired = false)]
        public virtual DateTime? CkeckDate { get; set; }

        //[DataMember(Order = 59, IsRequired = true)]
        public virtual String CkeckNo { get; set; }

        //[DataMember(Order = 60, IsRequired = true)]
        public virtual String SexName { get; set; }

        //[DataMember(Order = 61, IsRequired = true)]
        public virtual String HighLow { get; set; }

        //[DataMember(Order = 62, IsRequired = true)]
        public virtual String IsDangerous { get; set; }

        //[DataMember(Order = 63, IsRequired = true)]
        public virtual String Compare { get; set; }

        //[DataMember(Order = 64, IsRequired = true)]
        public virtual String NormalRange { get; set; }

        //[DataMember(Order = 65, IsRequired = false)]
        public virtual Int32? Age { get; set; }

        //[DataMember(Order = 66, IsRequired = true)]
        public virtual String MarriageName { get; set; }

        //[DataMember(Order = 67, IsRequired = true)]
        public virtual String AddressHome { get; set; }

        //[DataMember(Order = 68, IsRequired = true)]
        public virtual String PhotoFolder { get; set; }
    }

    #endregion UspCkResultById
    #region VwInDoctorAdviceDto

    [Serializable]

    public class VwInDoctorAdvice : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = false)]
        public virtual string GUID { get; set; }

        //[DataMember(Order = 2, IsRequired = false)]
        public virtual DateTime AdviceTime { get; set; }

        //[DataMember(Order = 3, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        //[DataMember(Order = 4, IsRequired = false)]
        public virtual string DoctorName { get; set; }

        //[DataMember(Order = 5, IsRequired = false)]
        public virtual string LocationId { get; set; }

        //[DataMember(Order = 6, IsRequired = false)]
        public virtual string LocationName { get; set; }

        //[DataMember(Order = 7, IsRequired = false)]
        public virtual string HospId { get; set; }

        //[DataMember(Order = 8, IsRequired = false)]
        public virtual string PatientName { get; set; }

        //[DataMember(Order = 9, IsRequired = false)]
        public virtual string BedId { get; set; }

        //[DataMember(Order = 10, IsRequired = false)]
        public virtual string BedName { get; set; }

        //[DataMember(Order = 11, IsRequired = false)]
        public virtual string Age { get; set; }

        //[DataMember(Order = 12, IsRequired = false)]
        public virtual int GroupNum { get; set; }

        //[DataMember(Order = 13, IsRequired = false)]
        public virtual string ItemId { get; set; }

        //[DataMember(Order = 14, IsRequired = false)]
        public virtual string Name { get; set; }

        //[DataMember(Order = 15, IsRequired = false)]
        public virtual string Spec { get; set; }
        //[DataMember(Order = 16, IsRequired = false)]
        public virtual string UnitTakeId { get; set; }

        //[DataMember(Order = 17, IsRequired = false)]
        public virtual string UnitTakeName { get; set; }

        //[DataMember(Order = 18, IsRequired = false)]
        public virtual string FrequencyName { get; set; }

        //[DataMember(Order = 19, IsRequired = false)]
        public virtual string UsageId { get; set; }
        //[DataMember(Order = 20, IsRequired = false)]
        public virtual string UsageName { get; set; }
        //[DataMember(Order = 21, IsRequired = false)]
        public virtual double PriceIn { get; set; }
        //[DataMember(Order = 22, IsRequired = false)]
        public virtual double Totality { get; set; }
        //[DataMember(Order = 23, IsRequired = false)]
        public virtual double Amount { get; set; }

        //[DataMember(Order = 24, IsRequired = false)]
        public virtual string UnitInId { get; set; }
        //[DataMember(Order = 25, IsRequired = false)]
        public virtual string UnitInName { get; set; }
        //[DataMember(Order = 26, IsRequired = false)]
        public virtual bool IsAttach { get; set; }
        //[DataMember(Order = 27, IsRequired = false)]
        public virtual bool IsSelf { get; set; }
        //[DataMember(Order = 28, IsRequired = false)]
        public virtual int LsSpecialUsage { get; set; }
        //[DataMember(Order = 29, IsRequired = false)]
        public virtual int LsExecLoc { get; set; }
        //[DataMember(Order = 30, IsRequired = false)]
        public virtual string OperID { get; set; }
        //[DataMember(Order = 31, IsRequired = false)]
        public virtual bool IsEnd { get; set; }
        //[DataMember(Order = 32, IsRequired = false)]
        public virtual bool IsOtherFee { get; set; }
        //[DataMember(Order = 33, IsRequired = false)]
        public virtual int LsRpType { get; set; }
        //[DataMember(Order = 34, IsRequired = false)]
        public virtual string AdviceType { get; set; }
        //[DataMember(Order = 35, IsRequired = false)]
        public virtual string InPatNo { get; set; }
        //[DataMember(Order = 36, IsRequired = false)]
        public virtual int LsMarkType { get; set; }
        //[DataMember(Order = 37, IsRequired = false)]
        public virtual string PatTypeId { get; set; }
        //[DataMember(Order = 38, IsRequired = false)]
        public virtual string Memo { get; set; }
        //[DataMember(Order = 39, IsRequired = false)]
        public virtual DateTime ChkOperTime { get; set; }
        //[DataMember(Order = 40, IsRequired = false)]
        public virtual DateTime AuthOperTime { get; set; }
        //[DataMember(Order = 41, IsRequired = false)]
        public virtual string ChkOperName { get; set; }

        //[DataMember(Order = 42, IsRequired = false)]
        public virtual string AuthOperName { get; set; }
        //[DataMember(Order = 43, IsRequired = false)]
        public virtual string ExecLocId { get; set; }
        //[DataMember(Order = 44, IsRequired = false)]
        public virtual bool IsAuth { get; set; }

        //[DataMember(Order = 45, IsRequired = false)]
        public virtual string SexName { get; set; }

        //[DataMember(Order = 46, IsRequired = false)]
        public virtual double Dosage { get; set; }

        //[DataMember(Order = 47, IsRequired = false)]
        public virtual string FrequencyId { get; set; }

        //[DataMember(Order = 48, IsRequired = false)]
        public virtual string FeeZyId { get; set; }

        //[DataMember(Order = 49, IsRequired = false)]
        public virtual DateTime OperTime { get; set; }


    }

    #endregion VwInDoctorAdvice
    #region VWHisInPatient

    [Serializable]
    public class VWHisInPatient : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = false)]
        public virtual string GUID { get; set; }

        //[DataMember(Order = 2, IsRequired = false)]
        public virtual string PatID { get; set; }

        //[DataMember(Order = 3, IsRequired = false)]
        public virtual string CardNo { get; set; }

        //[DataMember(Order = 4, IsRequired = false)]
        public virtual string InPatNo { get; set; }

        //[DataMember(Order = 5, IsRequired = false)]
        public virtual string HospNo { get; set; }

        //[DataMember(Order = 6, IsRequired = false)]
        public virtual string PatientName { get; set; }

        //[DataMember(Order = 7, IsRequired = false)]
        public virtual DateTime BirthDate { get; set; }

        //[DataMember(Order = 8, IsRequired = false)]
        public virtual string Mobile { get; set; }

        //[DataMember(Order = 9, IsRequired = false)]
        public virtual string Sex { get; set; }

        //[DataMember(Order = 10, IsRequired = false)]
        public virtual string SexName { get; set; }

        //[DataMember(Order = 11, IsRequired = false)]
        public virtual string AddressHome { get; set; }

        //[DataMember(Order = 12, IsRequired = false)]
        public virtual string DoctorId { get; set; }

        //[DataMember(Order = 13, IsRequired = false)]
        public virtual string DoctorName { get; set; }

        //[DataMember(Order = 14, IsRequired = false)]
        public virtual string YbRegNo { get; set; }

        //[DataMember(Order = 15, IsRequired = false)]
        public virtual string LocationName { get; set; }
        //[DataMember(Order = 16, IsRequired = false)]
        public virtual string LocationId { get; set; }
        //[DataMember(Order = 17, IsRequired = false)]
        public virtual string BedId { get; set; }

        //[DataMember(Order = 18, IsRequired = false)]
        public virtual string RoomNo { get; set; }

        //[DataMember(Order = 19, IsRequired = false)]
        public virtual string BedName { get; set; }

        //[DataMember(Order = 20, IsRequired = false)]
        public virtual bool IsAdd { get; set; }
        //[DataMember(Order = 21, IsRequired = false)]
        public virtual int OrderBy { get; set; }
        //[DataMember(Order = 22, IsRequired = false)]
        public virtual string LocIn { get; set; }
        //[DataMember(Order = 23, IsRequired = false)]
        public virtual string LocInName { get; set; }
        //[DataMember(Order = 24, IsRequired = false)]
        public virtual int NTime { get; set; }

        //[DataMember(Order = 25, IsRequired = false)]
        public virtual DateTime InDate { get; set; }
        //[DataMember(Order = 26, IsRequired = false)]
        public virtual DateTime InTime { get; set; }
        //[DataMember(Order = 27, IsRequired = false)]
        public virtual DateTime OutTime { get; set; }
        //[DataMember(Order = 28, IsRequired = false)]
        public virtual int InDays { get; set; }
        //[DataMember(Order = 29, IsRequired = false)]
        public virtual int LsInStatus { get; set; }

        //[DataMember(Order = 30, IsRequired = false)]
        public virtual string LsInStatusName { get; set; }

        //[DataMember(Order = 31, IsRequired = false)]
        public virtual string PatTypeId { get; set; }
        //[DataMember(Order = 32, IsRequired = false)]
        public virtual string PatTypeName { get; set; }
        //[DataMember(Order = 33, IsRequired = false)]
        public virtual double DiscDiag { get; set; }

        //[DataMember(Order = 34, IsRequired = false)]
        public virtual double DiscIn { get; set; }
        //[DataMember(Order = 35, IsRequired = false)]
        public virtual int LsGFPatType { get; set; }
        //[DataMember(Order = 36, IsRequired = false)]
        public virtual string LsGFPatTypeName { get; set; }
        //[DataMember(Order = 37, IsRequired = false)]
        public virtual string TallyTypeId { get; set; }
        //[DataMember(Order = 38, IsRequired = false)]
        public virtual string TallyTypeName { get; set; }
        //[DataMember(Order = 39, IsRequired = false)]
        public virtual string TallyGroupId { get; set; }
        //[DataMember(Order = 40, IsRequired = false)]
        public virtual string TallyGroupName { get; set; }

        //[DataMember(Order = 41, IsRequired = false)]
        public virtual bool IsGf { get; set; }
        //[DataMember(Order = 42, IsRequired = false)]
        public virtual bool IsYb { get; set; }
        //[DataMember(Order = 43, IsRequired = false)]
        public virtual string FamilyId { get; set; }
        //[DataMember(Order = 44, IsRequired = false)]
        public virtual string CommitteeId { get; set; }
        //[DataMember(Order = 45, IsRequired = false)]
        public virtual string WorktypeId { get; set; }

        //[DataMember(Order = 46, IsRequired = false)]
        public virtual double ArrearAmount { get; set; }
        //[DataMember(Order = 47, IsRequired = false)]
        public virtual DateTime OperTime { get; set; }
        //[DataMember(Order = 48, IsRequired = false)]
        public virtual string OperID { get; set; }

        //[DataMember(Order = 49, IsRequired = false)]
        public virtual string MotherHospId { get; set; }

        //[DataMember(Order = 50, IsRequired = false)]
        public virtual string MzRegId { get; set; }
        //[DataMember(Order = 51, IsRequired = false)]
        public virtual int HospitalId { get; set; }
        //[DataMember(Order = 52, IsRequired = false)]
        public virtual string Illness { get; set; }

        //[DataMember(Order = 53, IsRequired = false)]
        public virtual bool IsEndChg { get; set; }
        //[DataMember(Order = 54, IsRequired = false)]
        public virtual string IdCardNo { get; set; }
        //[DataMember(Order = 55, IsRequired = false)]
        public virtual string LinkmanName { get; set; }
        //[DataMember(Order = 56, IsRequired = false)]
        public virtual string LinkmanPhone { get; set; }
        //[DataMember(Order = 57, IsRequired = false)]
        public virtual string Age { get; set; }

        //[DataMember(Order = 58, IsRequired = false)]
        public virtual string SpecialityId { get; set; }

        //[DataMember(Order = 59, IsRequired = false)]
        public virtual string LocSource { get; set; }

        //[DataMember(Order = 60, IsRequired = false)]
        public virtual double Weight { get; set; }

        //[DataMember(Order = 61, IsRequired = false)]
        public virtual string InvoiceStuts { get; set; }

        //[DataMember(Order = 62, IsRequired = false)]
        public virtual DateTime? InvoiceTime { get; set; }

        //[DataMember(Order = 63, IsRequired = false)]
        public virtual bool IsBB { get; set; }
        //[DataMember(Order = 64, IsRequired = false)]
        public virtual bool AmountAuth { get; set; }
        //[DataMember(Order = 65, IsRequired = false)]
        public virtual string Author { get; set; }

        //[DataMember(Order = 66, IsRequired = false)]
        public virtual string Number2 { get; set; }

    }

    #endregion VWHisInPatient

    #region UspPrintOpsNoticeInfo

    [Serializable]
    public class UspPrintOpsNoticeInfo : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //[DataMember(Order = 2, IsRequired = true)]
        public virtual String ApplyNo { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual String RoomName { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual String LocationName { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual DateTime OpsTime { get; set; }

        //[DataMember(Order = 6, IsRequired = true)]
        public virtual String SexString { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual String PatinetName { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual String AgeString { get; set; }

        //[DataMember(Order = 9, IsRequired = true)]
        public virtual String BedName { get; set; }

        //[DataMember(Order = 10, IsRequired = true)]
        public virtual String InPatNo { get; set; }

        //[DataMember(Order = 11, IsRequired = true)]
        public virtual String Diagnose { get; set; }

        //[DataMember(Order = 12, IsRequired = true)]
        public virtual String OpsName { get; set; }

        //[DataMember(Order = 13, IsRequired = true)]
        public virtual String DoctorName1 { get; set; }

        //[DataMember(Order = 14, IsRequired = true)]
        public virtual String DoctorName2 { get; set; }

        //[DataMember(Order = 15, IsRequired = true)]
        public virtual String DoctorName3 { get; set; }

        //[DataMember(Order = 16, IsRequired = true)]
        public virtual String DoctorName4 { get; set; }

        //[DataMember(Order = 17, IsRequired = true)]
        public virtual String DoctorName5 { get; set; }

        //[DataMember(Order = 18, IsRequired = true)]
        public virtual String DoctorName6 { get; set; }

        //[DataMember(Order = 19, IsRequired = true)]
        public virtual String AnaeName1 { get; set; }

        //[DataMember(Order = 20, IsRequired = true)]
        public virtual String AnaeName2 { get; set; }

        //[DataMember(Order = 21, IsRequired = true)]
        public virtual String AnaeName3 { get; set; }

        //[DataMember(Order = 22, IsRequired = true)]
        public virtual String HostName { get; set; }

        //[DataMember(Order = 23, IsRequired = true)]
        public virtual String AnaesName { get; set; }

        //[DataMember(Order = 24, IsRequired = true)]
        public virtual String Memo { get; set; }

        //[DataMember(Order = 25, IsRequired = true)]
        public virtual String OpenName { get; set; }
    }

    #endregion UspPrintOpsNoticeInfo

    [Serializable]

    public class OpsWithRelation : BaseModel
    {

        public OpsApply OpsApply { get; set; }


        public OuHosInfo OuHosInfo { get; set; }


        public InHosInfo InHosInfo { get; set; }


        public List<OpsCharge> LstOpsCharge { get; set; }


        public List<OpsMan> LstOpsMan { get; set; }

    }

    #region UspGetOpsApplyInfo

    [Serializable]
    public class UspGetOpsApplyInfo : BaseModel
    {
        //[DataMember(Order = 1, IsRequired = true)]
        public virtual string GUID { get; set; }

        //[DataMember(Order = 2, IsRequired = false)]
        public virtual Boolean? IsFinish { get; set; }

        //[DataMember(Order = 3, IsRequired = true)]
        public virtual Boolean IsUrgent { get; set; }

        //[DataMember(Order = 4, IsRequired = true)]
        public virtual String PatientName { get; set; }

        //[DataMember(Order = 5, IsRequired = true)]
        public virtual String BsOpsName { get; set; }

        //[DataMember(Order = 6, IsRequired = true)]
        public virtual string LocationId { get; set; }

        //[DataMember(Order = 7, IsRequired = true)]
        public virtual DateTime ApplyTime { get; set; }

        //[DataMember(Order = 8, IsRequired = true)]
        public virtual String ApplyNo { get; set; }
    }

    #endregion UspGetOpsApplyInfo

    [Serializable]
    public class GetCkResultGroupByMainIdResult : BaseModel
    {
        public List<CkResultGroup> LstCkResultGroup { get; set; }
        public CkMain InfoCkMain { get; set; }
        public string MemTechMemoStr { get; set; }
        public List<CkMainIll> LstCkMainIll { get; set; }
    }

    #region UspCkResult

    [Serializable]
    public class UspCkResult : BaseModel
    {
        public String PatientNo { get; set; }

        public String PatientName { get; set; }

        public string CheckId { get; set; }

        public string TestId { get; set; }

        public String ShortName { get; set; }

        public String Name { get; set; }

        public String Code { get; set; }

        public int LsTestType { get; set; }

        public string TestTypeId { get; set; }

        public String TestTypeName { get; set; }

        public string TestGroupId { get; set; }

        public String TestGroupName { get; set; }

        public Boolean IsZero { get; set; }

        public int LsGroup { get; set; }

        public Boolean IsReport { get; set; }

        public String UseRange { get; set; }

        public String Unit { get; set; }

        public String Format { get; set; }

        public double LimitHigh { get; set; }

        public double LimitLow { get; set; }

        public String PrintHigh { get; set; }

        public String PrintLow { get; set; }

        public double DefaultDalAbsolute { get; set; }

        public double DefaultDalPercent { get; set; }

        public int OrderBy { get; set; }

        public Boolean IsDisplay { get; set; }

        public Boolean IsActive { get; set; }

        public int LsStatus { get; set; }

        public String Result { get; set; }

        public String LastResult { get; set; }

        public int LsRefFlag { get; set; }

        public Boolean IsPanic { get; set; }

        public Boolean IsDalta { get; set; }

        public double DalAbsolute { get; set; }

        public double DalPercent { get; set; }

        public double LowValue { get; set; }

        public double HighValue { get; set; }

        public double PanicLow { get; set; }

        public double PanicHigh { get; set; }

        public Boolean IsPass { get; set; }

        public DateTime ReportDate { get; set; }

        public String ReportBy { get; set; }

        public Boolean IsPrint { get; set; }

        public String Memo { get; set; }

        public string ParentID { get; set; }

        public String CheckNo { get; set; }

        public string PatId { get; set; }

        public DateTime CheckTime { get; set; }

        public string CompanyCkeckId { get; set; }

        public string LocationId { get; set; }

        public string DoctorId { get; set; }

        public Boolean IsCancel { get; set; }

        public DateTime OperTime { get; set; }

        public string OperId { get; set; }

        public string CompanyId { get; set; }

        public String CompanyName { get; set; }

        public DateTime CkeckDate { get; set; }

        public String CkeckNo { get; set; }

        public String SexName { get; set; }

        public String HighLow { get; set; }

        public String IsDangerous { get; set; }

        public String Compare { get; set; }

        public String NormalRange { get; set; }

        public int Age { get; set; }

        public String MarriageName { get; set; }

        public String AddressHome { get; set; }

        public String PhotoFolder { get; set; }
    }

    #endregion UspCkResult

    #region UspCkItem

    [Serializable]
    public class UspCkItem : BaseModel
    {
        public String Code { get; set; }

        public int LsTestType { get; set; }

        public string TestTypeId { get; set; }

        public string TubeTypeId { get; set; }

        public String ShortName { get; set; }

        public String Name { get; set; }

        public String OperMemo { get; set; }

        public Boolean IsZero { get; set; }

        public int LsGroup { get; set; }

        public Boolean IsReport { get; set; }

        public String UseRange { get; set; }

        public int LsForSex { get; set; }

        public string SourceId { get; set; }

        public double Price { get; set; }

        public String Unit { get; set; }

        public String Format { get; set; }

        public double LimitHigh { get; set; }

        public double LimitLow { get; set; }

        public String PrintHigh { get; set; }

        public String PrintLow { get; set; }

        public double DalAbsolute { get; set; }

        public double DalPercent { get; set; }

        public string ItemId { get; set; }

        public int OrderBy { get; set; }

        public Boolean IsDisplay { get; set; }

        public Boolean IsActive { get; set; }

        public string FluidId { get; set; }

        public String TestWay { get; set; }

        public double Dev3 { get; set; }

        public double Dev2 { get; set; }

        public double Dev1 { get; set; }

        public double DevM1 { get; set; }

        public double DevM2 { get; set; }

        public double DevM3 { get; set; }

        public double AvgValue { get; set; }

        public String DefultValue { get; set; }

        public string TestId { get; set; }
    }

    #endregion UspCkItem
    
    [Serializable]
    public class UspPacsRequestExamNo : BaseModel
    {
        public String ApplyNo { get; set; }
        public string hospital_indicator { get; set; }//医院代码
        public string hospital_name { get; set; }//医院名称
        public string patient_id { get; set; }//病人统一标识号
        public string inpatient_id { get; set; }//病历号(住院号):住院、门诊和体检独立编号
        public int admiss_times { get; set; }//就诊次数(对门诊病人为0)
        public string patient_type { get; set; }//病人类别
        public string patient_name { get; set; }//病人姓名
        public string patient_sex { get; set; }//性别
        public string patient_age { get; set; }//年龄
        public DateTime Birthdate { get; set; }//出生日期
        public string patient_mobil { get; set; }//联系电话
        public string charge_type { get; set; }//费用类别
        public string bed_no { get; set; }//床号
        public string patient_height { get; set; }//身高
        public string patient_weight { get; set; }//体重
        public string patient_occupation { get; set; }//职业
        public string patient_workplace { get; set; }//工作单位
        public string patient_nationality { get; set; }//民族
        public string patient_address { get; set; }//地址
        public string patient_mail { get; set; }//邮箱
        public string exam_serial { get; set; }//申请号
        public string apply_unit { get; set; }//申请科室编码
        public string apply_unit_name { get; set; }//申请科室名称
        public DateTime apply_date { get; set; }//申请日期
        public string apply_doctor { get; set; }//申请医生
        public string apply_doctor_name { get; set; }//申请医生姓名
        public string exam_type { get; set; }//检查类别编码 
        //(case when PsApplyReport.Xtype=1 then 'CT'
        //when PsApplyReport.Xtype= 2 then 'DR'
        //when PsApplyReport.Xtype= 3 then 'MR'
        //when PsApplyReport.Xtype= 4 then 'CR'
        //when PsApplyReport.Xtype= 5 then 'RF'
        //when PsApplyReport.Xtype= 6 then 'US'
        //when PsApplyReport.Xtype= 7 then '脑电图'
        //when PsApplyReport.Xtype= 8 then '心电图'
        //when PsApplyReport.Xtype= 9 then '镜检查'
        //when PsApplyReport.Xtype= 10 then 'MG'
        //when PsApplyReport.Xtype= 11 then 'DSA'
        //when PsApplyReport.Xtype= 12 then '普放'
        //when PsApplyReport.Xtype= 13 then '病理'
        //when PsApplyReport.Xtype= 14 then '其它'
        public string exam_type_name { get; set; }//检查类别名称
        public string exam_sub_type { get; set; }//检查部位编码
        public string exam_sub_type_name { get; set; }//检查部位名称
        public string exam_objective { get; set; }//检查目的
        public decimal exam_fee { get; set; }//检查费用
        public decimal exam_charge { get; set; }//实收费用
        public string exam_add_info { get; set; }//病史
        public string clinic_diag { get; set; }//临床诊断
        public string exec_unit { get; set; }//执行科室id
        public string exec_unit_name { get; set; }//执行科室名
        public string ward_sn { get; set; }//申请病区编码
        public string ward_name { get; set; }//申请病区名称

    }
    [Serializable]
    public class UspInSendDrugCache : BaseModel, IEqualityComparer<UspInSendDrugCache>
    {
        public bool Equals(UspInSendDrugCache m1, UspInSendDrugCache m2)
        {
            return (m1.GUID == m2.GUID);
        }

        public int GetHashCode(UspInSendDrugCache m)
        {
            return m.ToString().GetHashCode();
        }


        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string PatID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public String LocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public String HospNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public String PatientName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public String IdCardNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public String ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public String Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public double Totality { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public string UnitReq { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = false)]
        public double Dosage { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public string BedId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = true)]
        public Boolean IsPrint { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = false)]
        public double PriceIn { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = false)]
        public double Amount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = true)]
        public int LsMarkType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = true)]
        public string LocationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = true)]
        public String ItemCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public DateTime ForDate { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public String RequestNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = true)]
        public string RoomId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = false)]
        public double Times { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public string HospId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = false)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public String UnitReqName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public string RequestId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public Boolean IsIssued { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public Int32 ListNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public string AdviceId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = false)]
        public string UnitTake { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public Boolean IsConfirm { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = false)]
        public string ConfirmOperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public String ConfirmOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = false)]
        public string DetailId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = false)]
        public string UsageId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = false)]
        public string FrequencyId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public int GroupNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = false)]
        public string ExecuteId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public String FrequencyName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41, IsRequired = false)]
        public Boolean GroupId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42, IsRequired = false)]
        public Boolean IsPoison { get; set; }

        ////////////////////////////////[DataMemberr(Order = 43, IsRequired = false)]
        public Boolean IsExpen { get; set; }

        ////////////////////////////////[DataMemberr(Order = 44, IsRequired = false)]
        public Boolean IsMental { get; set; }

        ////////////////////////////////[DataMemberr(Order = 45, IsRequired = true)]
        public String DoctorName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 46, IsRequired = true)]
        public String UnitTakeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 47, IsRequired = false)]
        public Boolean IsAttach { get; set; }

        ////////////////////////////////[DataMemberr(Order = 48, IsRequired = true)]
        public String UsageName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 49, IsRequired = false)]
        public string OperID { get; set; }

        ////////////////////////////////[DataMemberr(Order = 50, IsRequired = false)]
        public Int32 age { get; set; }

        ////////////////////////////////[DataMemberr(Order = 51, IsRequired = true)]
        public String AgeString { get; set; }

        ////////////////////////////////[DataMemberr(Order = 52, IsRequired = true)]
        public String BedName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 53, IsRequired = true)]
        public string PatTypeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 54, IsRequired = true)]
        public String Sex { get; set; }

        ////////////////////////////////[DataMemberr(Order = 55, IsRequired = false)]
        public string DoctorId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 56, IsRequired = true)]
        public String GroupName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 57, IsRequired = true)]
        public String Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 58, IsRequired = true)]
        public String GroupTitle { get; set; }

        ////////////////////////////////[DataMemberr(Order = 59, IsRequired = false)]
        public int OrderBy { get; set; }

        ////////////////////////////////[DataMemberr(Order = 60, IsRequired = false)]
        public int FirstDay { get; set; }

        ////////////////////////////////[DataMemberr(Order = 61, IsRequired = false)]
        public int LsSecMarkType { get; set; }

        ////////////////////////////////[DataMemberr(Order = 62, IsRequired = false)]
        public Boolean Refusal { get; set; }

        ////////////////////////////////[DataMemberr(Order = 63, IsRequired = true)]
        public String AdviceMemo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 64, IsRequired = true)]
        public String LocationOrderby { get; set; }

        ////////////////////////////////[DataMemberr(Order = 65, IsRequired = true)]
        public String UsageMemo { get; set; }

        public bool IsUrgent { get; set; }

        public bool IsAllLocation { get; set; }

        public string RequestMan { get; set; }

        public int LsSendStatus { get; set; }
        public bool u_IsLongAdvice { get; set; }
        public bool u_IsTemporaryAdvice { get; set; }
    }
    [Serializable]
    public class UspInChinDrugCache : BaseModel
    {
        #region Main
        public string ConfirmOperId { get; set; }
        public bool IsAuth { get; set; }
        public bool IsPriority { get; set; }
        public string UsageId { get; set; }
        public string FrequencyId { get; set; }
        #endregion

        ////////////////////////////////[DataMemberr(Order = 2, IsRequired = true)]
        public string RecipeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 3, IsRequired = true)]
        public string ItemCode { get; set; }

        ////////////////////////////////[DataMemberr(Order = 4, IsRequired = true)]
        public string ItemName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 5, IsRequired = true)]
        public string Spec { get; set; }

        ////////////////////////////////[DataMemberr(Order = 6, IsRequired = true)]
        public double Dosage { get; set; }

        ////////////////////////////////[DataMemberr(Order = 7, IsRequired = true)]
        public string UnitTakeId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 8, IsRequired = true)]
        public string ItemId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 9, IsRequired = true)]
        public int LsDecoctWay { get; set; }

        ////////////////////////////////[DataMemberr(Order = 10, IsRequired = true)]
        public string Memo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 11, IsRequired = true)]
        public string OperId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 12, IsRequired = false)]
        public DateTime OperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 13, IsRequired = false)]
        public string DetailId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 14, IsRequired = true)]
        public string UnitTakeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 15, IsRequired = true)]
        public string DoctorId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 16, IsRequired = false)]
        public double PriceIn { get; set; }

        ////////////////////////////////[DataMemberr(Order = 17, IsRequired = false)]
        public double Totality { get; set; }

        ////////////////////////////////[DataMemberr(Order = 18, IsRequired = false)]
        public double Amount { get; set; }

        ////////////////////////////////[DataMemberr(Order = 19, IsRequired = true)]
        public string RoomNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 20, IsRequired = true)]
        public string HospNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 21, IsRequired = false)]
        public int Age { get; set; }

        ////////////////////////////////[DataMemberr(Order = 22, IsRequired = true)]
        public string Sex { get; set; }

        ////////////////////////////////[DataMemberr(Order = 23, IsRequired = true)]
        public int DrugNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 24, IsRequired = true)]
        public int DecoctNum { get; set; }

        ////////////////////////////////[DataMemberr(Order = 25, IsRequired = true)]
        public string RecipeNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 26, IsRequired = true)]
        public string LocationName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 27, IsRequired = true)]
        public string PatTypeName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 28, IsRequired = true)]
        public string PhoneHome { get; set; }

        ////////////////////////////////[DataMemberr(Order = 29, IsRequired = true)]
        public string AddressHome { get; set; }

        ////////////////////////////////[DataMemberr(Order = 30, IsRequired = true)]
        public string IllDesc { get; set; }

        ////////////////////////////////[DataMemberr(Order = 31, IsRequired = true)]
        public string LsCookSelfName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 32, IsRequired = true)]
        public int LsCookSelf { get; set; }

        ////////////////////////////////[DataMemberr(Order = 33, IsRequired = false)]
        public DateTime BackTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 34, IsRequired = true)]
        public string BedName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 35, IsRequired = true)]
        public string PatientName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 36, IsRequired = true)]
        public string HospId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 37, IsRequired = true)]
        public string LocationId { get; set; }

        ////////////////////////////////[DataMemberr(Order = 38, IsRequired = true)]
        public Boolean IsConfirm { get; set; }

        ////////////////////////////////[DataMemberr(Order = 39, IsRequired = true)]
        public Boolean IsBack { get; set; }

        ////////////////////////////////[DataMemberr(Order = 40, IsRequired = true)]
        public string RicipeMemo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 41, IsRequired = true)]
        public string UsageName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 42, IsRequired = true)]
        public string FrequencyName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 43, IsRequired = true)]
        public string MedicareNo { get; set; }

        ////////////////////////////////[DataMemberr(Order = 44, IsRequired = true)]
        public DateTime ConfirmOperTime { get; set; }

        ////////////////////////////////[DataMemberr(Order = 45, IsRequired = false)]
        public Boolean IsSelected { get; set; }

        ////////////////////////////////[DataMemberr(Order = 46, IsRequired = true)]
        public string PriorityName { get; set; }

        ////////////////////////////////[DataMemberr(Order = 47, IsRequired = true)]
        public Boolean IsPrint { get; set; }

        ////////////////////////////////[DataMemberr(Order = 48, IsRequired = true)]
        public string DoctorName { get; set; }

        public string InPatNo { get; set; }

        public string CardNo { get; set; }

        public string Name { get; set; }


        public DateTime BirthDate { get; set; }


        public int NTime { get; set; }

        public Boolean IsBaby { get; set; }

        public int LsMarriage { get; set; }

        public string BloodGroup { get; set; }

        public string XNo { get; set; }

        public string CountryId { get; set; }

        public string Residence { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public Boolean IsOversea { get; set; }

        public DateTime? PassTime { get; set; }

        public string IdCardNo { get; set; }

        public string Company { get; set; }

        public string Occupation { get; set; }

        public string WorktypeId { get; set; }

        public string TallyGroupId { get; set; }

        public string BsTallyGroupName { get; set; }

        public string TallyTypeId { get; set; }

        public string TallyTypeName { get; set; }
        public string PatTypeId { get; set; }

        public double DiscIn { get; set; }

        public Boolean IsYbMt { get; set; }

        public string YbRegNo { get; set; }

        public string CertificateId { get; set; }

        public double ArrearAmount { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public string PostCodeHome { get; set; }

        public string AreaCodeHome { get; set; }

        public string PhoneWork { get; set; }

        public string AddressWork { get; set; }

        public string PostCodeWork { get; set; }

        public string AreaCodeWork { get; set; }

        public string LinkmanName { get; set; }

        public string RelationId { get; set; }

        public string LinkmanPhone { get; set; }

        public string LinkmanAddress { get; set; }

        public string LinkmanArea { get; set; }

        public string LinkmanPost { get; set; }

        public DateTime InTime { get; set; }

        public DateTime OutTime { get; set; }

        public int LsInType { get; set; }

        public string LsInWay { get; set; }

        public int LsInIllness { get; set; }

        public string DocMz { get; set; }

        public string LocIn { get; set; }

        public string BedNo { get; set; }

        public string BedId { get; set; }

        public int LsInStatus { get; set; }

        public string Status { get; set; }
    }
    #region 取单个病人检验医嘱
    [Serializable]
    public class UspTwoOneDatTestMasterData : BaseModel
    {
        public String hospital_indicator { get; set; }
        public String hospital_name { get; set; }
        public String patient_id { get; set; }
        public String inpatient_id { get; set; }
        public String outpatient_id { get; set; }
        public int visit_id { get; set; }
        public String patient_type { get; set; }
        public int patient_firstcure { get; set; }
        public String patient_mobil { get; set; }
        public String charge_type { get; set; }
        public String patient_name { get; set; }
        public String patient_sex { get; set; }
        public String patient_age { get; set; }
        public DateTime Brithdate { get; set; }
        public String bed_no { get; set; }
        public String patient_height { get; set; }
        public String patient_weight { get; set; }
        public String patient_pregnant_weeks { get; set; }
        public String patient_lmp { get; set; }
        public String patient_pregnant_times { get; set; }
        public String patient_occupation { get; set; }
        public String patient_workplace { get; set; }
        public String patient_nationality { get; set; }
        public String patient_address { get; set; }
        public String patient_mail { get; set; }
        public String patient_ultrasonic_date { get; set; }
        public String patient_diabetes { get; set; }
        public String patient_smoking { get; set; }
        public String test_no { get; set; }
        public int item_no { get; set; }
        public String his_order_item_code { get; set; }
        public String his_order_item_name { get; set; }
        public String order_sheet_name { get; set; }
        public int priority_indicator { get; set; }
        public String test_cause { get; set; }
        public String clinic_diage { get; set; }
        public String clinic_diage_code { get; set; }
        public String Specmen { get; set; }
        public String spcm_sample_position { get; set; }
        public String spcm_sample_place { get; set; }
        public String spcm_sample_notes { get; set; }
        public int spcm_sample_place_flag { get; set; }
        public String spcm_status_notes { get; set; }
        public DateTime requested_date_time { get; set; }
        public String ordering_doctor { get; set; }
        public String ordering_doctor_code { get; set; }
        public DateTime spcm_sampled_date_time { get; set; }
        public String spcm_sampled_by { get; set; }
        public String ordering_dept { get; set; }
        public String ordering_dept_code { get; set; }
        public String ordering_ward { get; set; }
        public String ordering_ward_code { get; set; }
        public int performed_status { get; set; }
        public int special_flag { get; set; }
        public String performed_dept { get; set; }
        public String performed_dept_code { get; set; }
        public String inspection_notes { get; set; }
        public String inspection_table_no { get; set; }


    }
    #endregion
    #region 取多个病人检验医嘱
    [Serializable]
    public class UspMutilDatTestMasterData : BaseModel
    {
        public String hospital_indicator { get; set; }

        public String hospital_name { get; set; }
        public String patient_id { get; set; }

        public String inpatient_id { get; set; }

        public String outpatient_id { get; set; }

        public int visit_id { get; set; }

        public String patient_type { get; set; }
        public int patient_firstcure { get; set; }

        public String patient_mobil { get; set; }

        public String charge_type { get; set; }

        public String patient_name { get; set; }

        public String patient_sex { get; set; }
        public String patient_age { get; set; }

        public DateTime Brithdate { get; set; }

        public String bed_no { get; set; }

        public String patient_height { get; set; }

        public String patient_weight { get; set; }

        public String patient_pregnant_weeks { get; set; }
        public String patient_lmp { get; set; }

        public String patient_pregnant_times { get; set; }

        public String patient_occupation { get; set; }
        public String patient_workplace { get; set; }

        public String patient_nationality { get; set; }

        public String patient_address { get; set; }
        public String patient_mail { get; set; }

        public String patient_ultrasonic_date { get; set; }

        public String patient_diabetes { get; set; }
        public String patient_smoking { get; set; }

        public String test_no { get; set; }

        public int item_no { get; set; }
        public String his_order_item_code { get; set; }

        public String his_order_item_name { get; set; }

        public String order_sheet_name { get; set; }
        public int priority_indicator { get; set; }

        public String test_cause { get; set; }

        public String clinic_diage { get; set; }
        public String clinic_diage_code { get; set; }

        public String Specmen { get; set; }

        public String spcm_sample_position { get; set; }
        public String spcm_sample_place { get; set; }

        public String spcm_sample_notes { get; set; }

        public int spcm_sample_place_flag { get; set; }
        public String spcm_status_notes { get; set; }
        public DateTime requested_date_time { get; set; }
        public String ordering_doctor { get; set; }
        public String ordering_doctor_code { get; set; }
        public DateTime spcm_sampled_date_time { get; set; }
        public String spcm_sampled_by { get; set; }
        public String ordering_dept { get; set; }
        public String ordering_dept_code { get; set; }
        public String ordering_ward { get; set; }
        public String ordering_ward_code { get; set; }
        public int performed_status { get; set; }
        public int special_flag { get; set; }
        public String performed_dept { get; set; }
        public String performed_dept_code { get; set; }
        public String inspection_notes { get; set; }

    }
    #endregion
    #region 取得科室信息

    [Serializable]
    public class UspDeptInfo : BaseModel
    {
        public String unit_sn { get; set; }
        public String code { get; set; }
        public String name { get; set; }
        public String abbname { get; set; }
        public String py_code { get; set; }
        public String d_code { get; set; }
        public String class_code { get; set; }
        public String deleted_flag { get; set; }
        public String mz_flag { get; set; }
        public String pc_flag { get; set; }
        public String address { get; set; }
        public String inner_phone { get; set; }
        public String yy_commnet { get; set; }
        public String yy_flag { get; set; }
        public String yy_type { get; set; }
        public String extend_code { get; set; }
        public String comment { get; set; }
        public String comment1 { get; set; }



    }

    #endregion
    #region 取得科室病区信息

    [Serializable]
    public class UspWardInfo : BaseModel
    {
        public String ward_code { get; set; }
        public String dept_code { get; set; }
        public Int16 openbed_num { get; set; }
        public String ward_name { get; set; }
        public String dept_name { get; set; }
        public String ward_py_code { get; set; }
        public String ward_d_code { get; set; }
        public String dept_py_code { get; set; }
        public String dept_d_code { get; set; }
        public String start_day_time_kf { get; set; }
        public String ward_only { get; set; }
        public String detail_print_time { get; set; }
        public String adt_dept_no { get; set; }
        public String nurs_unit_flag { get; set; }
        public int plan_bed_count { get; set; }
        public int seq_no { get; set; }
        public String inser_yz_code { get; set; }
        public String ward_self { get; set; }
        public String yp_print_repreview { get; set; }
        public int save_bed_tip1 { get; set; }
        public int save_bed_tip2 { get; set; }
        public String deleted_flag { get; set; }
        public String yz_yp_print_repreview { get; set; }



    }

    #endregion 
    #region 取得病区病床信息

    [Serializable]
    public class UspBedInfo : BaseModel
    {
        public String ward_sn { get; set; }
        public String bed_no { get; set; }
        public String Dept_sn { get; set; }
        public String room_no { get; set; }
        public String bed_status { get; set; }
        public String Charge_code { get; set; }
        public String Enable_flag { get; set; }
        public int Hold_sn { get; set; }
        public String Patient_id { get; set; }
        public Int16 Admiss_times { get; set; }
        public DateTime Hold_date { get; set; }
        public String Hold_op { get; set; }
        public DateTime Stop_date { get; set; }
        public String Stop_op { get; set; }
        public String Sex { get; set; }
        public String Type { get; set; }
        public String Comment { get; set; }




    }

    #endregion 
    #region 取得人员信息
    [Serializable]
    public class UspEmployeeInfo : BaseModel
    {
        public String emp_sn { get; set; }
        public String code { get; set; }
        public String name { get; set; }
        public String py_code { get; set; }
        public String d_code { get; set; }
        public String sex { get; set; }
        public String dept_sn { get; set; }
        public String dept_sn_2 { get; set; }
        public String emp_tit_code { get; set; }
        public String prof_type { get; set; }
        public String ifcadre { get; set; }
        public String mark { get; set; }
        public String deleted_flag { get; set; }
        public String dept_sn_3 { get; set; }
        public String clinic_type { get; set; }
        public String order_flag { get; set; }
        public String social_no { get; set; }
        public String comment { get; set; }
        public String yb_code { get; set; }
        public string image { get; set; }
        public String part_flag { get; set; }
        public String mz_response_type { get; set; }
        public String phone { get; set; }


    }
    #endregion
    #region 取得病患信息
    [Serializable]
    public class UspInpatientInfo : BaseModel
    {
        public String patient_id { get; set; }
        public String inpatient_no { get; set; }
        public String Outpatient_no { get; set; }
        public String name { get; set; }
        public DateTime birth_date { get; set; }
        public String sex { get; set; }
        public String marry_code { get; set; }
        public String nation_code { get; set; }
        public String occupation_code { get; set; }
        public String vip_code { get; set; }
        public String social_no { get; set; }
        public String home_tel { get; set; }
        public String home_street { get; set; }
        public String home_district { get; set; }
        public String home_zipcode { get; set; }
        public String temp_street { get; set; }
        public String temp_zipcode { get; set; }
        public String employer_name { get; set; }
        public String employer_street { get; set; }
        public String employer_district { get; set; }
        public String employer_tel { get; set; }
        public String employer_zipcode { get; set; }
        public String relation_name { get; set; }
        public String relation_code { get; set; }
        public String relation_street { get; set; }
        public String relation_district { get; set; }
        public String relation_tel { get; set; }
        public String temp_tel { get; set; }
        public String contract_code { get; set; }
        public DateTime lastvisit_date { get; set; }
        public int lastadmiss_times { get; set; }
        public String birth_place { get; set; }
        public String country { get; set; }
        public String temp_district { get; set; }
        public String hic_no { get; set; }
        public String py_code { get; set; }
        public String cpy { get; set; }
        public String blood_type { get; set; }
        public String RH_blood { get; set; }
        public String modi_op_id { get; set; }
        public DateTime modi_date { get; set; }
        public String now_district { get; set; }
        public String now_street { get; set; }
        public String social_no2 { get; set; }
        public String health_ID { get; set; }
        public String native { get; set; }
        public String patient_email { get; set; }
        public String qq { get; set; }


    }
    #endregion
    #region 取得住院病患列表
    [Serializable]
    public class UspInpatientList : BaseModel
    {
        public String patient_id { get; set; }
        public String inpatient_no { get; set; }
        public Int16 admiss_times { get; set; }
        public String outpatient_no { get; set; }
        public String name { get; set; }
        public String charge_type { get; set; }
        public String visit_type { get; set; }
        public DateTime admiss_date { get; set; }
        public String admiss_status { get; set; }
        public String clinic_diag { get; set; }
        public String admiss_diag { get; set; }
        public String admiss_diag_str { get; set; }
        public String admiss_physician { get; set; }
        public String refer_physician { get; set; }
        public String consult_physician { get; set; }
        public String dept_director { get; set; }
        public String admiss_dept { get; set; }
        public String admiss_ward { get; set; }
        public DateTime dis_date { get; set; }
        public String dis_dept { get; set; }
        public String dis_status { get; set; }
        public String dis_ward { get; set; }
        public String insur_code { get; set; }
        public String dis_diag { get; set; }
        public String contract_code { get; set; }
        public String responce_type { get; set; }
        public String ward { get; set; }
        public String dept { get; set; }
        public String bed_no { get; set; }
        public DateTime birth_date { get; set; }
        public String sex { get; set; }
        public Int16 max_depo_times { get; set; }
        public DateTime bed_charge_date { get; set; }
        public float owe_limit { get; set; }
        public String lock_order_fee { get; set; }
        public String extend_inpatient_no { get; set; }
        public String yb_in_type { get; set; }
        public String yb_out_type { get; set; }
        public String admiss_type { get; set; }
        public String clinic_diag_str { get; set; }
        public String nurse_level { get; set; }
        public String administer_nurse { get; set; }
        public String admiss_dept_flag { get; set; }
        public String admiss_dept_opera { get; set; }


    }
    #endregion
    #region 取得病患医嘱信息
    [Serializable]
    public class UspOrderInfo : BaseModel
    {
        public float act_order_no { get; set; }
        public String patient_id { get; set; }
        public Int16 admiss_times { get; set; }
        public String order_code { get; set; }
        public String Serial { get; set; }
        public String order_name { get; set; }
        public DateTime order_time { get; set; }
        public DateTime enter_time { get; set; }
        public DateTime confirm_time { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public DateTime end_time_2 { get; set; }
        public DateTime performance_time { get; set; }
        public String order_doctor { get; set; }
        public String stop_doctor { get; set; }
        public String enter_oper { get; set; }
        public String modifier { get; set; }
        public String confirm_opera { get; set; }
        public String stop_opera { get; set; }
        public String stop_confirm_opera { get; set; }
        public String frequ_code { get; set; }
        public String order_type { get; set; }
        public String status_flag { get; set; }
        public String supply_code { get; set; }
        public String drug_specification { get; set; }
        public String doseage { get; set; }
        public String doseage_unit { get; set; }
        public float charge_amount { get; set; }
        public float drug_occ { get; set; }
        public String mini_unit { get; set; }
        public String print_order_change { get; set; }
        public float parent_no { get; set; }
        public String print_order { get; set; }
        public String exclusive_type { get; set; }
        public DateTime exclu_back_time { get; set; }
        public float exclu_act_order_no { get; set; }
        public String pay_self { get; set; }
        public String group_no { get; set; }
        public String infant_flag { get; set; }

        public String emergency_flag { get; set; }
        public String ope_flag { get; set; }
        public String self_buy { get; set; }
        public String instruction { get; set; }

        public String discription { get; set; }
        public String deleted_flag { get; set; }
        public String back_flag { get; set; }
        public float alter_print_order { get; set; }

        public String exec_unit { get; set; }
        public String long_once_flag { get; set; }
        public String fit_flag { get; set; }
        public String preventive_flag { get; set; }

        public String therapeutic_flag { get; set; }
        public String sb_equip_id { get; set; }
        public String sb_loan_docu_no { get; set; }
        public String ward_sn { get; set; }

        public String dept_sn { get; set; }
        public String skin_test_flag { get; set; }
        public DateTime modify_time { get; set; }
        public String confirm_opera_doctor { get; set; }

        public DateTime confirm_time_doctor { get; set; }
        public String skin_test_result { get; set; }
        public String parentchild_tag { get; set; }
        public String apply_sn { get; set; }

        public String sr_flag { get; set; }
        public String sr_zh_sn { get; set; }
        public Int32 pathway_t_sn { get; set; }
        public Int32 pathway_schedule_sn { get; set; }

        public String apply_item_code { get; set; }
        public Int32 pattern_detail_sn { get; set; }
        public String occ_opera { get; set; }
        public DateTime occ_time_confirm { get; set; }

        public String occ_time_confirm_opera { get; set; }
        public String stop_confirm { get; set; }
        public DateTime stop_confirm_time { get; set; }
        public String cancel_confirm { get; set; }

        public DateTime cancel_confirm_time { get; set; }
        public Int32 firstdayocctimes { get; set; }
        public String yz_comment { get; set; }
        public String confirm_opera_study { get; set; }

        public String stop_doctor_study { get; set; }
        public String modifier_study { get; set; }
        public Int32 input_group_sn { get; set; }



    }
    #endregion
    #region 取得医嘱频率字典
    [Serializable]
    public class UspZdOrderFrequency : BaseModel
    {
        public String code { get; set; }
        public String name { get; set; }
        public String py_code { get; set; }
        public String d_code { get; set; }
        public String print_name { get; set; }
        public String week_day { get; set; }
        public String donot_modify { get; set; }
        public String deleted_flag { get; set; }
        public Int32 sort_code { get; set; }
        public String yb_code { get; set; }

    }
    #endregion
    #region 取得手术排程信息
    [Serializable]
    public class UspOpRecord : BaseModel
    {
        public int op_record_ID { get; set; }
        public String patient_id { get; set; }
        public String admit_times { get; set; }
        public DateTime apply_date { get; set; }
        public String apply_user { get; set; }
        public DateTime schedule_date { get; set; }
        public String schedule_user { get; set; }
        public DateTime confirm_date { get; set; }
        public String confirm_user { get; set; }
        public String dept_code { get; set; }
        public String ward_code { get; set; }
        public String op_code { get; set; }
        public String Op_name { get; set; }
        public String anesthesia_method_ID { get; set; }
        public String op_record_status { get; set; }
        public String patient_type { get; set; }
        public DateTime op_datetime { get; set; }
        public String diag_before_op { get; set; }
        public String diag_after_op { get; set; }
        public float ref_no { get; set; }
        public String urgent_clinic_flag { get; set; }
        public decimal blood_amount { get; set; }  //不知
        public String blood_unit { get; set; }
        public String op_stastics_ID { get; set; }
        public Int32 op_room_ID { get; set; }
        public String schedule_flag { get; set; }
        public String op_scale { get; set; }
        public String op_group_no { get; set; }
        public DateTime op_endtime { get; set; }
        public String diag_before_code { get; set; }
        public String diag_after_code { get; set; }
        public String exec_code { get; set; }
        public String HbsAg { get; set; }
        public String hepatitis { get; set; }
        public String hepatitis_c { get; set; }
        public String syphilis { get; set; }
        public String AIDS { get; set; }
        public String aspesis_scale { get; set; }
        public String remark { get; set; }
        public String check_opera { get; set; }
        public String comment { get; set; }
        public String op_room_type { get; set; }
        public String op_describe { get; set; }
        public Int32 expected_minute { get; set; }
        public Int32 expected_hour { get; set; }
        public String incision_flag { get; set; }
        public String allergic { get; set; }
        public String direction { get; set; }
        public String practice { get; set; }
        public String other_op_code { get; set; }
        public String other_op_name { get; set; }

    }
    #endregion
    #region 取得检查申请信息
    [Serializable]
    public class UspJcApply : BaseModel
    {
        public int exam_serial { get; set; }
        public String exam_type { get; set; }
        public String exam_sub_type { get; set; }
        public String exam_no { get; set; }
        public String exam_group { get; set; }
        public String patient_id { get; set; }
        public Int16 admiss_times { get; set; }
        public String zy_mz_flag { get; set; }
        public String exec_unit { get; set; }
        public DateTime apply_date { get; set; }
        public String apply_doctor { get; set; }
        public DateTime scheduled_date { get; set; }
        public DateTime exam_date { get; set; }
        public DateTime report_date { get; set; }
        public String operId { get; set; }
        public String reporter { get; set; }
        public String device { get; set; }
        public Int32 self_no { get; set; }
        public String exam_objective { get; set; }
        public String exam_location { get; set; }
        public String exam_status { get; set; }
        public String exam_add_info { get; set; }
        public Int16 sort_no { get; set; }
        public String apply_hospital { get; set; }
        public String inpatient_no { get; set; }
        public String out_patient_no { get; set; }
        public String record_no { get; set; }
        public String apply_unit { get; set; }
        public String exam_add_infos { get; set; }
        public float yz_act_order_no { get; set; }
        public String comment { get; set; }
        public String assessor_code { get; set; }
        public String emergency_flag { get; set; }
        public String ward_sn { get; set; }
        public String dept_sn { get; set; }
        public String exam_region { get; set; }
        public String notice_flag { get; set; }
        public String clinic_diag { get; set; }
        public String clinlcal_symptom { get; set; }
        public int apply_serial { get; set; }
        public DateTime input_date { get; set; }
        public String sr_flag { get; set; }
        public String sr_zh_sn { get; set; }
        public decimal item_charge { get; set; }
        public String charge_flag { get; set; }
        public String compare_code { get; set; }
        public String print_flag { get; set; }
        public String group_sn { get; set; }
        public Int32 interface_no { get; set; }

    }
    #endregion
    #region 取得药品字典信息
    [Serializable]
    public class UspZdDrugInfo : BaseModel
    {
        public String charge_code { get; set; }
        public String serial { get; set; }
        public String drug_id { get; set; }
        public String drug_standard_id { get; set; }
        public String drugname { get; set; }
        public String dosage { get; set; }
        public String concentration { get; set; }
        public float weight { get; set; }
        public String weight_unit { get; set; }
        public float volum { get; set; }
        public String vol_unit { get; set; }
        public String mini_unit { get; set; }
        public float pack_size { get; set; }
        public String pack_unit { get; set; }
        public String specification { get; set; }
        public String spe_comment { get; set; }
        public float fix_price { get; set; }
        public float retprice { get; set; }
        public String manufactory { get; set; }
        public String self_flag { get; set; }
        public String separate_flag { get; set; }
        public String suprice_flag { get; set; }
        public String drug_flag { get; set; }
        public String py_code { get; set; }
        public String d_code { get; set; }
        public String infusion_flag { get; set; }
        public String country_flag { get; set; }
        public String divide_flag { get; set; }
        public String deleted_flag { get; set; }
        public String drug_kind { get; set; }
        public String zy_bill_item { get; set; }
        public String mz_bill_item { get; set; }
        public String zy_charge_group { get; set; }
        public String mz_charge_group { get; set; }
        public String class_code { get; set; }
        public String extend_code { get; set; }
        public String supply_code { get; set; }
        public String frequ_code { get; set; }
        public float order_dosage { get; set; }
        public String dosage_unit { get; set; }
        public float buy_price { get; set; }
        public String lowdosage_flag { get; set; }
        public String audit_code { get; set; }
        public String print_name { get; set; }
        public String license_no { get; set; }
        public Int32 eff_month { get; set; }
        public String trad_mark { get; set; }
        public String fu_flag { get; set; }
        public String zy_supply_code { get; set; }
        public String zy_frequ_code { get; set; }
        public String extend_code2 { get; set; }
        public String comment { get; set; }
        public String part_flag { get; set; }
        public String ba_bill_item { get; set; }

    }
    #endregion
    #region 回传病患医嘱信息
    [Serializable]
    public class UspSetOrderInfo : BaseModel
    {
        public int flag { get; set; }


    }
    #endregion
    #region 根据病患信息取得病床信息
    [Serializable]
    public class UspPatientBedInfo : BaseModel
    {
        public int patient_id { get; set; }
        public Int16 admiss_times { get; set; }
        public int ward_sn { get; set; }
        public int bed_no { get; set; }
        public int bed_status { get; set; }
        public DateTime admiss_date { get; set; }
        public DateTime dis_date { get; set; }


    }
    #endregion
    #region 取得医嘱字典信息
    [Serializable]
    public class UspZdOrderInfo : BaseModel
    {
        public String order_code { get; set; }
        public String order_name { get; set; }
        public String py_code { get; set; }
        public String d_code { get; set; }
        public String exclu_group_type { get; set; }
        public String order_type { get; set; }
        public String deleted_flag { get; set; }
        public String discription { get; set; }
        public String print_name { get; set; }
        public String rent_flag { get; set; }

        public String frequency_code { get; set; }
        public String apply_flag { get; set; }

    }
    #endregion
    #region 取得用法字典信息
    [Serializable]
    public class UspZdSupplyInfo : BaseModel
    {
        public String supply_code { get; set; }
        public String supply_name { get; set; }
        public String py_code { get; set; }
        public String d_code { get; set; }
        public String class_code { get; set; }
        public Int16 sort_code { get; set; }
        public String print_name { get; set; }
        public String deleted_flag { get; set; }
        public String order_print { get; set; }
        public String frequency_code { get; set; }

        public String yb_code { get; set; }
        public String mz_zy_flag { get; set; }

    }
    #endregion

}
