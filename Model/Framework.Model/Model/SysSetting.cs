using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Orm.Model.EnumDefine;
using Orm.Utilities;

namespace Orm.Model
{
    /// <summary>
    /// 系统参数
    /// </summary>
    public static class SysSetting
    {
        #region 系统参数的声明

        public static bool IsWzShowStockNum { get; set; }
        public static string keyNum { get; set; }
        public static bool IsGetAdviceWithUsageItem { get; set; }
        public static bool IsdiscDiag { get; set; }
        public static bool IsDropUsageIdOneDrug { get; set; }
        public static string diagnDept { get; set; }
        public static string ybBirthSingleBalance { get; set; }
        public static bool IsBodyHeatFreeChart { get; set; }
        public static int StartHour { get; set; }
        /// <summary>
        /// 行心分院
        /// </summary>
        public static string EmrHospitalName { get; set; }

        public static DateTime DoctorAdviceBeginTime { get; set; }
        /// <summary>
        /// 煎药费
        /// </summary>
        public static string CoctByHospitalFeeId { get; set; }
        //“自费”的PatTypeId
        public static string SelfPatTypeId { get; set; }
        //“凑整费”的ItemId
        public static string IntegralItemId { get; set; }
        //默认的项目一级分组
        public static string GroupMainId { get; set; }
        //默认核算分类
        public static string HsFeetyId { get; set; }
        //医院编码
        public static string HospitalCode { get; set; }
        //手术室领药地点（在科室领药时强制）
        public static string OPSDrugRoom { get; set; }
        //默认省份
        public static string DefaltProvinceId { get; set; }
        //默认地区
        public static string DefaltRegionId { get; set; }
        //透支多少则不能录入处方
        public static int ArrearAmountLine { get; set; }
        //身份证的证件类别Id
        public static string IDCardId { get; set; }
        //门诊凑整费舍入位数
        public static int InTintNumber { get; set; }
        //诊金费用Id
        public static string DiagFeeItemId { get; set; }
        //现金支付方式的Id
        public static string CashPayWayId { get; set; }
        //医保卡支付方式的Id
        public static string YbCardPayWayId { get; set; }
        //普通门诊类别的Id
        public static string RegTypeId { get; set; }
        //住院新生婴儿床位费ID
        public static string BabyBedFeeItemId { get; set; }
        //套餐选择列表的宽度
        public static int XdRpSplitterPosition { get; set; }
        //库存发出的顺序：0-StoreDate；1-ProduceDate；2-LimitDate
        public static int DrugSendSequence { get; set; }
        //加密起源
        public static int EncryptSeed { get; set; }
        //计数器下限
        public static int TallyUnderline { get; set; }
        //医嘱限制录入的项目，例如：诊查费，床位费
        public static string AdviceForbidItemId { get; set; }
        //诊疗卡第一个数字
        public static int MiniCardNoFirstChar { get; set; }
        //诊疗卡数字位数，0表示不限制
        public static int MiniCardNoCharNum { get; set; }
        //没有医生职称的BsDocLevel的ID
        public static string DocLevelNoneId { get; set; }
        //没有门诊类别的RegType的ID
        public static string RegTypeNoneId { get; set; }
        //农村合作医疗的病人类别TallyType的Id
        public static string TallyTypePeasantId { get; set; }
        //门诊病历的水平分隔位置（不同显示分辨率决定）
        public static int MzRecordSplitterPosition { get; set; }
        //门诊诊断的垂直分隔位置（不同显示分辨率决定）
        public static int MzIllSplitterPosition { get; set; }
        //门诊中药房的RoomId
        public static string OuChinRoomId { get; set; }
        //门诊西药房的RoomId
        public static string OuWestRoomId { get; set; }
        //早上上班开始时间
        public static int WorkBeginMorning { get; set; }
        //早上上班结束时间
        public static int WorkEndMorning { get; set; }
        //下午上班开始时间
        public static double WorkBeginAfternoon { get; set; }
        //下午上班结束时间
        public static double WorkEndAfternoon { get; set; }
        //在药房集中打印处方的模式下，哪些病人类别不需要药房打印（由医生打印或手写）
        public static string PatTypeIdNeedDoctorRecipePrint { get; set; }
        //VIP诊疗卡的起始数字
        public static int VIPCardKeyNoFrom { get; set; }
        //VIP诊疗卡的结束数字
        public static int VIPCardKeyNoTo { get; set; }
        //“本院”对应的HospitalId
        public static int CenterHospitalId { get; set; }
        //每晚插帐的系统收费员的BsUser的ID
        public static string SystemFeeOperId { get; set; }
        //住院号的最大长度
        public static int LenthInPatNo { get; set; }
        //检验科的LocationId
        public static string LabLocationId { get; set; }
        //LIS系统门诊科室的LocationId
        public static string LabMzLocId { get; set; }
        //门诊注射室的LocationId
        public static string MzNurseLocId { get; set; }
        //挂号费的收费项目
        public static string RegFeeItemId { get; set; }
        //门诊挂号打印空白处方还是通知单
        public static int OuRegBlankRecipeOrSheet { get; set; }
        //特殊要求某些项目单独结算（打发票）病人类别的ID。例如：定点职工生育类的结扎术费用
        public static string YbBirthPatTypeId { get; set; }
        //单独结算（打发票）的项目。例如：定点职工生育类的结扎术费用
        public static int YbBirthSingleBalance { get; set; }
        //阳光微生物的CKMachine的ID
        public static string GramOtherDBMachineId { get; set; }
        //如果门诊药房需要在特定时间由住院药房代发药，设置门诊药房下班，发药转到住院药房的时间（不需要设置0）
        public static int OuRoomChangeDutyTime { get; set; }
        //门诊医生下拉（看诊）的病人截止时间，例如24小时前：-1
        public static double OuDoctorModifyAhedDays { get; set; }
        //药库出入库单据打印纸张大小：1 - 10*5.5；2 - 10*3.5
        public static int HuPrintPageSizeMode { get; set; }
        //门诊就诊取消就诊后的公共科室ID（即所有科室的医生都能够就诊的科室，要求在BsLocation设置F3=1）
        public static string CommenOuDiagLocId { get; set; }
        //门诊医生叫号系统数据交换模式：0-无；1-读文件；2-读数据库
        public static int OuRecipeCallDiagMode { get; set; }
        //记事医嘱的ItemId
        public static string NoteAdviceItemId { get; set; }
        //手术室的LocationId
        public static string OpsLocationId { get; set; }
        //“次”的UnitId
        public static string CommonUnitId { get; set; }
        //一天只能收一次的项目
        public static string OneDayOnceItemId { get; set; }
        //默认为VIP的挂号科室
        public static string RegVipLocationIds { get; set; }
        //5ml注射器费用ID
        public static string AddBumpItemId { get; set; }
        //静泵、静滴等用法循环收费的科室
        public static string InjectUsageRollFeeLocationIds { get; set; }
        //50毫升注射器（用量小于100毫升时用）费用ID
        public static string AddBottle50ItemId { get; set; }
        //新生儿科LocationId
        public static string BabyLocationId { get; set; }
        //零价格但要插入到费用明细表的项目ItemId
        public static string ZeroPriceAddInInvoiceDtlItemIds { get; set; }
        //医生进行门诊自挂号时限制的PatTypeId
        public static string DoctorOuRegPatTypeIds { get; set; }
        //接瓶费ID
        public static string AddBottleItemId { get; set; }
        //使用储值优惠卡用途：1-限制记账金额；2-限制支付方式
        public static int PatCardFeeLimitType { get; set; }
        //储值卡限制的支付PayWayId
        public static string PatCardFeePayWayId { get; set; }
        //成本核算中多少门诊人次与住院人次相当
        public static int OuManTimeToIn { get; set; }
        //中草药的加成率
        public static double ChinDrugAddPercent { get; set; }
        //西药中成药的加成率
        public static int WestDrugAddPercent { get; set; }
        //体温单起始小时
        public static int HeatChartStartHour { get; set; }
        //超出加成上限时的加成率
        public static double AddPercentWhenBeyondLimitPriceLine { get; set; }
        //加成上限：例如：
        public static int LimitPriceLine { get; set; }
        //加成上限的最高利润
        public static int LimitTopProfit { get; set; }
        //医院编号
        public static int HospitalNo { get; set; }
        //医院等级
        public static int HospitalLsType { get; set; }
        //与最大住院号的差异超出多少就认为错误的录入
        public static int InPatNoDaltaMistake { get; set; }
        //入库时生效日期的默认年限
        public static int LimitYear { get; set; }
        //项目编码输入从第几位开始
        public static int InPutItemCodeFromNChar { get; set; }
        //医保记账凑整费
        public static int TallyIntegralItemId { get; set; }
        //体检科ID
        public static string TJLocationId { get; set; }
        //门诊收费“体检科医生”ID
        public static string TjDoctorId { get; set; }
        //门诊打印记账单的病人类别
        public static string OuPrintTallySheetPatTypeIds { get; set; }
        //住院结算要提示药物比例的病人类别
        public static string InBanlaceTipDrugPercentPatTypeIds { get; set; }
        //住院结算药物比例低于多少百分比就提示
        public static int InBanlaceTipDrugPercentLine { get; set; }
        //住院结算药物比例达到后转成另外病人类别ID
        public static string DrugPercentChangePatTypeId { get; set; }
        //包床费ID
        public static string BallBedFeeId { get; set; }
        //默认区/县
        public static string DefaltAreaId { get; set; }
        //默认镇
        public static string DefaltPoliceStationId { get; set; }
        //门诊收费可以灵活输入价格的项目（例如：中药费）
        public static string OuChargeInputPriceItemIds { get; set; }
        //用户密码过期天数。（0-永不过期）
        public static int PasswordExpireDays { get; set; }
        //住院凑整费舍入位数
        public static int InTintNumberByIn { get; set; }
        //上系统的住院号起始号
        public static int InitInPatNo { get; set; }
        //哪些病人类别需要把病人类别的名称打印到发票上
        public static string OuInvoicePrintPatTypeNamePatTypeIds { get; set; }
        //物资系统的供应室的ID
        public static string WzGysHouseId { get; set; }
        //物资系统的材料库室的ID
        public static string WzWsclHouseId { get; set; }
        //出院后多少小时不能记账
        public static int TallyForHours { get; set; }
        //住院结算需要固定金额的支付方式
        public static string BZPayWayId { get; set; }
        //住院结算固定支付方式的金额
        public static int BZPayAmount { get; set; }
        //口服用法ID
        public static string OralUsageId { get; set; }
        //当要求指定病人类别打印不同打印而且当前病人不属于指定范围时采用的模式：1-本地；2-按科室设置，如果没有科室设置则按GblSetting的OuChargeWestRecipePrinter
        public static int OuRecipePrintModeWhenNotSpecPatType { get; set; }
        //挂急诊号的RegTypeId
        public static string OutTimeRegTypeId { get; set; }
        //挂急诊号的诊金
        public static int OutTimediagFeeItemId { get; set; }
        //工作站点数
        public static int WorkStations { get; set; }
        //住院价格修改时要求把在院病人未结算费用同步的病人类别PatTypeId
        public static string CommonPriceInPricePatTypeId { get; set; }
        //晚上自动收费的时间
        public static double RunDiaryTime { get; set; }
        //设备仓库的HouseId
        public static string EquipmentHouseId { get; set; }
        //连续输液第二组起静脉输液费ID
        public static string AdultContinueItemId { get; set; }
        //婴儿连续输液第二组起静脉输液费ID
        public static string BabyContinueItemId { get; set; }
        //体温图使用自由时间画点的科室ID
        public static string BodyHeatFreeChartLocationIds { get; set; }
        //系统右下角提示停留时间
        public static int TipTimerInterval { get; set; }
        //“设备”的BsGroup的ID
        public static string EquipmentGroupMainId { get; set; }
        //备份数据库需要的时间
        public static int BackupDatabaseTime { get; set; }
        //哪些科室需要门诊病历主诉默认上次就诊记录
        public static string LastMainInformSameLocationIds { get; set; }
        //农合病人类别的TallyTypeID
        public static string CountryTallyTypeId { get; set; }
        //药物比例超出多少百分百就提示医生
        public static int DrugPercentTipLine { get; set; }
        //皮试的用法ID
        public static string AdviceSkinID { get; set; }
        //皮试默认的频率ID
        public static string AdviceSkinFrequencyID { get; set; }
        //健康档案编号长度
        public static int EhrRecNoLenth { get; set; }
        //个人基本信息表的PatMenuId
        public static string BasePatMenuId { get; set; }
        //输液配置中心对应的药房RoomId
        public static string DropDrugCenterRoomId { get; set; }
        //转移几天前的数据到HIST表
        public static int MoveDayHist { get; set; }
        //转移几个月前的数据到_B表
        public static int MoveMonthHist { get; set; }
        //救护车收费项目
        public static string AmbulanceCarItemIds { get; set; }
        //定义“儿童”的岁数
        public static int ChildAge { get; set; }
        //门诊打印处方多少种药一张处方
        public static int OuRecipePrintHowManyDrug { get; set; }
        //门诊医生看到病人列表对应的科室级别：1-三级科室；2-二级科室
        public static int OuDoctorSeeLocOrSpecialityId { get; set; }
        //紧急医嘱的频率ID
        public static string StFrequencyId { get; set; }
        //哪些科室必须输入儿童体重
        public static string OuRecipeInputChildWightLocs { get; set; }
        //急诊科的LocationId
        public static string EmergencyLocationId { get; set; }
        //条码打印纸张规格大小的宽度
        public static int BarCodePrintPeterSizeX { get; set; }
        //条码打印纸张规格大小的高度
        public static int BarCodePrintPeterSizeY { get; set; }
        //条码打印字体大小
        public static int BarCodePrintFontSize { get; set; }
        //门诊收费自动费用只收一次的项目。例如抽血费
        public static string UsageIdNoForFrequencyDay { get; set; }
        //条码左边距
        public static int BarCodePrintLeftW { get; set; }
        //条码上边距
        public static int BarCodePrintTopW { get; set; }
        //门诊挂号默认的挂号类别RegTypeId
        public static string OuHosInfoDefultRegTypeId { get; set; }
        //条码高度
        public static double BarHeightCM { get; set; }
        //门诊挂号费收取模式：1-挂号处收；2-收费处收；3-不收
        public static int OuRegFeeMode { get; set; }
        //门诊诊金收取模式：1-挂号处收；2-收费处收；3-不收
        public static int OuDiagFeeMode { get; set; }
        //门诊挂号默认的挂号科室LocationId。空-不默认科室
        public static string OuHosInfoDefultRegLocId { get; set; }
        //当参与静滴的项目只有一种药且为备注不包括接瓶时哪个项目不收费
        public static string OneDrugDropNotFeeItemId { get; set; }
        //医务人员修改的时限小时
        public static int EmrModifyHours { get; set; }
        //医务人员审查归档的时限小时
        public static int EmrAuthlizeHours { get; set; }
        //叫号屏左边要显示多少个病人姓名
        public static int CallNameNum { get; set; }
        //接滴用法的ID
        public static string DropContinueUsageId { get; set; }
        //优抚对象的支付方式ID
        public static string YFPayWayId { get; set; }
        //产房的LocationId
        public static string BirthRoomLocationId { get; set; }
        //药袋的ItemId
        public static string DrugBagItemId { get; set; }
        //中药药袋ItemId
        public static string ChinDrugBagItemId { get; set; }
        //住院结算优抚对象的支付方式
        public static string YouFuPayWayId { get; set; }
        //药水瓶ID
        public static string OuChargeBottleFeeItemId { get; set; }
        //其它
        public static int Other { get; set; }
        //检验条码打印的份数
        public static int BarCodePrintCopys { get; set; }
        //评标专家的角色ID
        public static string BidExpertRoleId { get; set; }
        //“会诊”收费项目的ID
        public static string DiagMeetingItemId { get; set; }
        //电子病历的统一字体大小
        public static int EmrFondSize { get; set; }
        //哪些执行科室的医嘱不需要在护士那里执行收费，没有设0
        public static string NotExecuteAssLocationIds { get; set; }
        //住院不生成领药的药品项目的ID
        public static string NotInDrugReqdItemId { get; set; }
        //特殊类别的加成率。与LimitPriceFeeId配合
        public static int OtherAddPercent { get; set; }
        //门诊材料费ID
        public static string OuMaterialFeeId { get; set; }
        //住院材料费ID
        public static string ZyMaterialFeeId { get; set; }
        //病人出院多少天不能书写病历（需要归档权限）
        public static int EmrModifyOutDays { get; set; }
        //类别是医保病人，但不要求上传费用结算的PatTypeId
        public static string IsOuChargeNotLoadYBPatTypeId { get; set; }
        //项目“自备药”的ItemId
        public static string PatientSelfDurgItemId { get; set; }
        //多少点钟新入院的病人开出的医嘱不受按金或透支不足限制（因为收费处下班），设置大于24的数字表示必须限制
        public static int FreeArrearTimeHour { get; set; }
        //启用发药机的时候，小于几岁不用上传到发药机
        public static int AgeNotLoadMachineSystem { get; set; }
        //处方一页可以打印几条记录
        public static int PrintRecipePageCount { get; set; }
        //中心药房的药房ID
        public static string InDrugReqRoomId { get; set; }
        //后台密码
        public static string SharePassword { get; set; }
        //年龄大于几岁的情况下免诊金挂号费
        public static int OldPeopleAgeFreeDiagFee { get; set; }
        //西药处方限制金额
        public static int OneOurecipeSumAmount { get; set; }
        /// <summary>
        /// 门诊或住院算库存时起启用方式:1门诊2住院3全部
        /// </summary>
        public static int OuRecipeInDrugDtlCalStockNumType { get; set; }
        //广铁医保卡支付方式的Id
        public static string GtYbCardPayWayId { get; set; }
        //广铁病人ID
        public static string GTPatTypeId { get; set; }
        //收取配置费的开始时间
        public static int BeginTime { get; set; }
        //收取配置费的结束时间
        public static int EndTime { get; set; }
        //病历提示
        public static int InEMRIntervalTime { get; set; }
        //诊金补收项目ID
        public static string ReGetDiagFeeItemId { get; set; }
        //XXXXXXX
        public static string TallyNumPatTypeId { get; set; }
        //身份证读卡器自动读取时间秒
        public static int IntervalForIdCardReadTime { get; set; }
        //城区范围内收费出车记录统计
        public static string AmbulanceCarItemId { get; set; }
        //多少岁以下打印年月
        public static int PrintBarCodePatientAgeMonth { get; set; }
        //住院号的最大长度门特留观
        public static int LenthInPatMtObserved { get; set; }
        //无证生育的起始住院号
        public static int InitInPatNoObserved { get; set; }
        //门诊导入费用在几天之内有效果
        public static int FeeToInInvoiceDtlBeforeDay { get; set; }
        //必须先经过试算的病人大类TallyTypeId
        public static string InBalanceTallyTypeId { get; set; }
        //交款报表以往报表显示几个月以内的
        public static int invodatelen { get; set; }
        //出院小结的catalogid
        public static string OuHospitalEmrCatalogid { get; set; }
        //基层医疗卫生机构一般诊疗费的项目ID
        public static string BaseCheckFeeItemId { get; set; }
        //告病危的项目ItemId
        public static string BZItemIdForBsItem { get; set; }
        //告病重的项目ItemId
        public static string BWItemIdForBsItem { get; set; }
        //特级护理ItemId
        public static string TJHLForBsItem { get; set; }
        //一级护理ItemId
        public static string YJHLForBsItem { get; set; }
        //二级护理ItemId
        public static string EJHLForBsItem { get; set; }
        //三级护理ItemId
        public static string SJHLForBsItem { get; set; }
        //身份证证件类型的ID
        public static string IdCardNoCertificateId { get; set; }
        //煎服用法的ID
        public static string DecoctionUsageId { get; set; }
        //频率每天一次的Id
        public static string qdFrequencyId { get; set; }
        //InPatient控件能够查到多少天之前的出院病人
        public static int OuTimeAddDaysForInPatNo { get; set; }
        //门诊类型计数
        public static int OuDocRegTypeMorningCount { get; set; }
        //新增默认下午预约号源
        public static int OuDocRegTypeAfternoonCount { get; set; }
        //门诊公共医生的ID
        public static string CommonOuDoctor { get; set; }
        //多少岁一下儿童中药小包装能够拆开卖
        public static int ChildAgeSmallPackage { get; set; }
        //门诊中药处方默认剂数
        public static int OuChinRecipeDecoctNum { get; set; }
        //中心编码
        public static int YbCenterCode { get; set; }
        //医疗机构编码
        public static int YbHosptailCode { get; set; }
        //分院中药房的id
        public static string OuChinRoomIdHospital { get; set; }
        //门诊慢病病人开处方天数超过多少天提示用量原因
        public static int OuRecipeUsageReasonOutDays { get; set; }
        //多少岁以下必须填写联系人
        public static int AgesWriteLinkmanName { get; set; }
        //门诊就诊中药处方默认煎药方式。 1-代煎，2-自煎，3-免煎
        public static int OuRecipeLsCookSelf { get; set; }
        //门诊就诊打印门诊执行单频率大于1时是否重复，值为1时不重复
        public static int isNotFrequencyTimeCount { get; set; }
        //门诊就诊处方界面录入“—”号时可以直接调出套餐查找界面,"="号时可以直接调出组合界面，无需再按回车键，值为1时直接调出套餐
        public static int isFrmOuRecipePackageSearch { get; set; }
        //为1时在HisInPatientText控件中显示身份证号
        public static int isUseIdCardNoInFrmBalance { get; set; }
        //为1时可在转医保入院时读医保就医登记号到农合.NO
        public static int isLoadGMSFHMYBIN { get; set; }
        //天亿LED屏语音:1-只呼叫普通话,2-呼叫普通话和粤语
        public static int TYLedLanguage { get; set; }
        /// <summary>
        /// 护理记录病历ID
        /// </summary>
        public static string HLtCatalogId { get; set; }
        //默认分期付款的期数
        public static int NumForReplyment { get; set; }
        //管理员权限
        public static string RoleID { get; set; }
        //每天晚上由周计划生成日排班的天数
        public static int DayPlanDays { get; set; }
        //体检的挂号类别
        public static string SetTJRegTypeId { get; set; }
        //
        public static string DRDevID { get; set; }
        //中药处方限制金额
        public static int OneOurecipeSumAmount2 { get; set; }
        //优抚对象的病人类别
        public static string YFPatTypeId { get; set; }
        //临床路径一级分组Id
        public static string DgBsGroupId { get; set; }
        //PX项目ID
        public static string DifficultPXItemID { get; set; }
        //门诊就诊诊断输入字的个数开始查找
        public static int InPutItemCodeFromNChar2 { get; set; }
        //设置病人的发烧温度
        public static int SetPatHeatOfFever { get; set; }
        //公费限额类别
        public static string TypeGFXEId { get; set; }
        //库存下限
        public static int UnderLine { get; set; }
        //正常库存维持数
        public static int Normal { get; set; }
        //库存上限
        public static int UperLine { get; set; }
        //体检中心的权限Id
        public static string TAuthorizeRoleId { get; set; }
        //连接Lis的数据库类型
        public static int LisDBType { get; set; }
        //是否启用传染病报告卡:0、启用但录诊断不弹提示 1、启用并录诊断提示 2、不启用
        public static int IsShowRdInfectious { get; set; }
        //默认的挂号支付方式ID
        public static string RegPayWayId { get; set; }
        //门诊就诊调用超卓打印方法是否允许设计报表格式，1表示是
        public static string allowDesignFrmOuHosPrintOuInvoice { get; set; }
        //按金管理调用超卓打印方法是否允许设计报表格式，1表示是
        public static int allowDesignFrmDepositPrint { get; set; }
        //0-关闭医生转诊功能；1-转诊到公共科，所有医生能接诊；2-指定科室、医生进行转诊
        public static int TransferTreatMode { get; set; }
        //门诊病历工本费
        public static int OuZyFee { get; set; }
        //门诊病历工本费收取模式：1-挂号处收；2-收费处收；3-不收
        public static int OuZyFeeMode { get; set; }
        //门诊单个处方限制金额大于300
        public static int OneOuRecipeSumAmount3 { get; set; }
        //离休职工病人类别
        public static string LeavePatTypeId { get; set; }
        //Pacs影像压缩格式
        public static int PacsCompressJPEG { get; set; }
        //Pacs影像存储空间不足预警
        public static int PacsMinImgCap { get; set; }
        //物品项目维护里修改保存给DrugFormId设置默认值
        public static string DrugFormId { get; set; }
        //物品项目维护里修改保存给FeeZyId设置默认值
        public static string FeeZyId { get; set; }
        //医嘱执行界面打印模式:1-不需要打印，2-单个病人打印（即由病人自行到药房取药），3-打印全部病人的出院打印执行单（即由科室护士统一领药发放给别人）
        public static int PrintoutCYDYType { get; set; }
        //记事医嘱的FrequencyId
        public static string NoteAdviceFrequencyId { get; set; }
        //床位一览设置婴儿床位的年龄
        public static int SetAgeOfBabyBed { get; set; }
        //预收月费-医疗备用金项目
        public static string ArrearAmountItemId { get; set; }
        //预收月费-医疗备用金
        public static string MedicalReserveFund { get; set; }
        //预收月费-一次性生活设施费项目
        public static string OneTimeFacilityFeeItemId { get; set; }
        //预收月费-服务费金额
        public static int ServiceChargeAmount { get; set; }
        //预收款押金
        public static int AdvanceDeposit { get; set; }
        //治疗费ID
        public static string CureItemId { get; set; }
        //需理疗执行收费的项目用法ID
        public static string ExecuteUsageID { get; set; }
        //免费电费度数 
        public static int FreehydropowerDegree { get; set; }
        //费用冻结至某年某月(例如201608)
        public static int FrozenYearMonth { get; set; }
        //电费项目ID
        public static string HydropowerItemID { get; set; }
        //机构电话
        public static int InstitutionalTelephone { get; set; }
        //不计库存的HouseId
        public static string NoStoreHouseId { get; set; }
        //自带护理员收费项目ID
        public static string NursingItemId { get; set; }
        //理疗室的LocationId
        public static string PhysioLocationId { get; set; }
        //每个人超出水电度数的部分加收比 
        public static double PowerAddRantio { get; set; }
        //康复理疗费ID
        public static string RehabilitationId { get; set; }
        //预收月费-服务费项目
        public static string ServiceChargeItemId { get; set; }
        //自费病人的病人大类（BsTallyGroup）的ID
        public static string SelfTallyGroupId { get; set; }
        //机构名称 
        public static int HospitalID { get; set; }
        //积分获得率制度
        public static double IntegralRate { get; set; }
        //兑现率制度
        public static double CashRate { get; set; }
        //会员积分默认的支付方式的Id
        public static string IntegraPayWayId { get; set; }
        //会员的支付方式的Id
        public static string VipCardPayWayId { get; set; }
        //养老附加费用类型
        public static string PisFeeZyId { get; set; }
        //VIP挂号折扣比例ID表BsMzFeety
        public static string VIPRegFeeDiscountID { get; set; }
        //血库检验的检验类别ID
        public static string CkBloodTestTypeID { get; set; }
        //输血科科室ID
        public static string BloodLocationID { get; set; }
        //输血类型为红细胞的价格
        public static double RedBloodCellPrice { get; set; }
        //辅助科室指定药房(值添加科室ID)
        public static string CreateDrugFromLocationByInRoomId { get; set; }
        //运输费的ItemId
        public static string ItemIdOfTransformFee { get; set; }

        //是否有远程分院连接的模式 
        public static bool IsCenter { get; set; }
        //出院时是否需要检查地址（为了统计居委会住院人数） 
        public static bool IsCheckAddressComitt { get; set; }
        //是否住院中成药在中药房发 
        public static bool IsChinDrugRoomIssueCPMedicine { get; set; }
        //是否有配剂中心 
        public static bool IsHasBolusMixRoom { get; set; }
        //采购录入药品时是否要求医药公司对应 
        public static bool IsHuBuyInReqDrugForCompany { get; set; }
        //是否本地医保结算（无医保上传） 
        public static bool IsInBalaceLocal { get; set; }
        //住院录入医嘱、中药处方、记账时是否检查按金余额 
        public static bool IsLimitDeposit { get; set; }
        //凑整费是否四舍五入：１－四舍五入；２－直接进位 
        public static bool InTintType { get; set; }
        //结算是是否按自付比例重低到高先算（true：重低到高,fase：重高到底)，说明：用来控制公费的可记帐部分的分摊结算时的优先顺序 
        public static bool OrderByDiscInAscendInBalance { get; set; }
        //判断库存不足时，分门诊药房、住院药房还是所有药房之和 
        public static bool IsMergeRoomWhenStoresCheck { get; set; }
        //允许停床操作 
        public static bool IsAllowLeave { get; set; }
        //住院护士可以管理整个病区的病人（不分科） 
        public static bool IsNurseManageAreaPatient { get; set; }
        //是否需要公费病人录入自费项目提示功能 
        public static bool IsTipGfInputSelfFee { get; set; }
        //是否需要医保病人录入自费项目提示功能 
        public static bool IsTipYbInputSelfFee { get; set; }
        //是否项目维护需要审核才能使用 
        public static bool IsItemSaveDefaultNotAcitve { get; set; }
        //是否显示透支金额在病人控件 
        public static bool IsShowArrearInPatControl { get; set; }
        //是否入库人员可以改变入库价格并作为下次默认入库价格 
        public static bool IsUserChangeStockPrice { get; set; }
        //新项目维护后，是否要有自动打开发信息窗口 
        public static bool IsNewItemSendEmail { get; set; }
        //是否医保床位费每天只能一张（false：按照床位总费/天对比限额来计算） 
        public static bool IsOneTimeYBBedFee { get; set; }
        //是否要与广东省病案系统做数据接口 
        public static bool IsBaInterface { get; set; }
        //是否要与上海百佳医院病案系统做数据接口 
        public static bool IsShbjInterface { get; set; }
        //病人控件是否显示次数，false-不显示次数而显示入院日期 
        public static bool IsPatientShowTimes { get; set; }
        //Diver实时报表打开是否要控制时间段 
        public static bool IsMrkLimitTime { get; set; }
        //入院登记是否要求门诊科室必填 
        public static bool IsFrmInHosInfoNeedOuLocation { get; set; }
        //是否正在处于切换系统期间 
        public static bool IsSystemBeginning { get; set; }
        //是否系统每晚自动收取费用 
        public static bool IsAutoInTally { get; set; }
        //病人登记是否需要录入病人类别 
        public static bool IsAddPatientNeedPatType { get; set; }
        //门诊挂号是否需要打印发票 
        public static bool IsOuRegPrintInvoice { get; set; }
        //门诊挂号是否需要空白处方 
        public static bool IsOuRegPrintBlankRecipe { get; set; }
        //病人在医院就诊是否使用诊疗卡 
        public static bool IsUseMiniCard { get; set; }
        //药品的门诊和住院单位是否要求一致 
        public static bool IsDrugOuAndInUnitSame { get; set; }
        //病人登记要求手机号码 
        public static bool IsPatientNeedMobileInput { get; set; }
        //门诊医生是否需要打印门诊药房处方（防止处方流失到院外） 
        public static bool IsOuDoctorPrintRecipe { get; set; }
        //新项目维护后，是否要求必须发信息提示给相关人员必须选择对象 
        public static bool IsNewItemSendEmailNeedUser { get; set; }
        //门诊处方打印是否需要预览 
        public static bool IsOuRecipeBatchPrint { get; set; }
        //门诊挂号是否输入医生找科室和门诊类别（是否使用排班计划） 
        public static bool IsOuRegInputDoctorFirst { get; set; }
        //门诊药房是否定时检测并自动打印配药单 
        public static bool IsOuRoomAutoPrint { get; set; }
        //住院登记是否自动生成住院号（护士登记入院时需要） 
        public static bool IsAutoGenInPatNo { get; set; }
        //门诊医生处方打印是否逐页放纸 
        public static bool IsPrintManualPage { get; set; }
        //门诊收费是否允许在有医生电子处方情况下补录入其他药品 
        public static bool IsOuChargeAddDortorRecie { get; set; }
        //门诊收费是否允许在删除医生电子处方的项目（部分收费） 
        public static bool IsOuChargeDeleteDoctorRecie { get; set; }
        //门诊收费是否即时打印医生电子处方（到药房） 
        public static bool IsOuChargeSavePrintRecie { get; set; }
        //中药处方是否使用农本方药品 
        public static bool IsChinDrugHasNBF { get; set; }
        //药品维护是否自动根据进货价*加成率*整散比计算零售价格 
        public static bool IsModiPriceSaleWithPriceKc { get; set; }
        //星期六是否上班 
        public static bool IsWorkSaturday { get; set; }
        //是否采用门诊注射室发药的模式 
        public static bool IsInjectRoomSendDrug { get; set; }
        //门诊医生工作站是否提示打印医生处方 
        public static bool IsOuRecipeSavePrintRecie { get; set; }
        //门诊收费后是否打印配药单（不是处方） 
        public static bool IsChargePrintRoomIssueSheet { get; set; }
        //挂号时医保公费是否必须填写证件号 
        public static bool IsYbGfSetMedicardRequired { get; set; }
        //两个字的项目是否要使用每个字的前面两笔作为五笔码 
        public static bool IsTwoCharsItemUseDoubleWb { get; set; }
        //是否维护药品禁忌 
        public static bool IsBsItemItem { get; set; }
        //西药房按金余额不足够时不能发药 
        public static bool IsSendDrugLimitDeposit { get; set; }
        //是否限制护士不能在医嘱中录入执行科室是医技功能科室的项目。（只能功能科室自己审核录入） 
        public static bool IsNurseLcationFee { get; set; }
        //是否录入住院病人标本后即时收费 
        public static bool IsInLabGenFee { get; set; }
        //打印LIS送检验清单前是否要预览 
        public static bool IsPreviewLabSendList { get; set; }
        //是否允许修改门诊病人检验单 
        public static bool IsCanModiOutPatLab { get; set; }
        //是否允许检验室修改住院护士录入的病人检验单 
        public static bool IsCanModiInPatLab { get; set; }
        //是否有连接LIS系统接口 
        public static bool IsHasLIS { get; set; }
        //是否从第3方数据库读取微生物报告的结果 
        public static bool IsCkGramReportFromOtherDB { get; set; }
        //门诊标本登记后是否打印通知单 
        public static bool IsPrintSheetAfterMzLabReg { get; set; }
        //是否在护士打印送检清单时写入收集时间 
        public static bool IsWriteCkCorretTimeWhenNurseSend { get; set; }
        //门诊护士在执行确认后是否打印处方 
        public static bool IsMzNursePrintRecipe { get; set; }
        //住院结算发票是否打印医保记账、起付线等字符串 
        public static bool IsInInvoicePrintYBString { get; set; }
        //自购入库是否一张单据每种药品默认相同发票日期和发票号 
        public static bool IsHuBuyInSameVoucherNo { get; set; }
        //是否使用Diver报表（临时） 
        public static bool IsUseDiver { get; set; }
        //多媒体导诊最后一个（附加）按钮是否显示 
        public static bool IsShowDmtActtachButtun { get; set; }
        //是否允许多人同时操作录入同一个病人的医嘱 
        public static bool IsCheckAdviceModifiedByOthers { get; set; }
        //门诊发票是否打印执行地点提示病人（小医院不用） 
        public static bool IsOunvoicePrintTips { get; set; }
        //是否住院结算后把计入起付线的自付应交金额分摊到明细中（视乎关注日报表的费用分类收入平衡还是关注病人费用清单的明细比例准确） 
        public static bool IsBalaceDivideDisc { get; set; }
        //门诊发票的结算方式是否打印金额，例如：现金:28.00 
        public static bool IsInvoicePayWayMoney { get; set; }
        //门诊交款报表是否包含病人类别收入报表 
        public static bool IsOuDayFeeHasPatTypeReport { get; set; }
        //门诊交款报表是否包含退款发票明细报表 
        public static bool IsOuDayFeeHasRefundReport { get; set; }
        //门诊医生是否需要填写肿瘤病例报告卡、结核病转诊单和传染病报告卡 
        public static bool IsNeedIllnessReportCard { get; set; }
        //按金打印套打还是全部打印：false-套打；true-全部打印 
        public static bool IsDepositPrintTitle { get; set; }
        //医保农合门诊结算是否补充封顶额（最高记账，余下自付） 
        public static bool IsOuLimitTopLocal { get; set; }
        //门诊收费是否允许重新调出并收取今天以前的病人费用 
        public static bool IsAllowOuLastPatientFee { get; set; }
        //门诊收费的病人登记是否检查并弹出重复的病人姓名 
        public static bool IsFrmOuChargeHosInfoCheckPatientName { get; set; }
        //住院发药后是否打印分类单 
        public static bool InDrugIssuePrintClass { get; set; }
        //中药房按金余额不足够时不能发药 
        public static bool IsZyfSendDrugLimitDeposit { get; set; }
        //是否使用屏蔽住院病人信息的功能（临时） 
        public static bool IsHideInhosPatTypeId { get; set; }
        //是否医生录入医嘱 
        public static bool IsDoctorInputAdvice { get; set; }
        //门诊收费是否允许修改门诊挂号登记的病人的医生信息 
        public static bool IsOuChargeAllowEditRegDoctor { get; set; }
        //DI是否使用数据仓库模式 
        public static bool IsHasDbHouse { get; set; }
        //是否住院结算记账和自付打印数字进位到“元” 
        public static bool IsInBalanceInsuranceCeiling { get; set; }
        //是否在开出处方不能超出5组时限制不能录入 
        public static bool IsGroupsLimitForbit { get; set; }
        //每次收费前先弹出发票起始号确认 
        public static bool IsPopupInvoSettingFirst { get; set; }
        //系统是否应用于妇幼儿童保健医院（病人登记时焦点落在出生日期和“是否婴儿”上） 
        public static bool IsUseInWomenBabyHospital { get; set; }
        //医生开具毒麻处方时是否检查毒麻处方权 
        public static bool IsPoisonRecipeDoctorLevelCheck { get; set; }
        //普通医师是否要签半名 
        public static bool IsHalfSignDoctorName { get; set; }
        //门诊挂号是否使用排班计划 
        public static bool IsOuRegPlan { get; set; }
        //门诊护士是否打印注射治疗单 
        public static bool IsOuExecutePrintSheet { get; set; }
        //门诊医生是否打印治疗/检查处方 
        public static bool IsOuPrintCureRecipe { get; set; }
        //项目说明书是显示图片还是备注文字Memo：true-图片；false-文字 
        public static bool IsBsItemMemoPicture { get; set; }
        //门诊退费时是否要自动打印通知药房 
        public static bool IsOuCancelInvoiceAlertRoom { get; set; }
        //门诊医生是否自动打印注射单 
        public static bool IsOuDoctorPrintNurseReject { get; set; }
        //住院发药后是否即时记账 
        public static bool IsInSendDrugGetFee { get; set; }
        //门诊处方是否打印提示病人地点 
        public static bool IsOuRecipePrintLocationTips { get; set; }
        //门诊医生是否要求必须输入诊断 
        public static bool IsOuRecipeNeedDiag { get; set; }
        //门诊收费是否只显示未收费的病人 
        public static bool IsOuChargeListNotInvoice { get; set; }
        //门诊医生是否打印检验检查申请单 
        public static bool IsOuDoctorPrintApplySheet { get; set; }
        //门诊收费退费是否需要输入密码 
        public static bool IsChargeBackPassword { get; set; }
        //瓶签是否打印单张（条码纸） 
        public static bool IsBottleLabelSingle { get; set; }
        //病人没有交诊金不能开处方 
        public static bool IsForbitRecipeWithoutDiagFee { get; set; }
        //是否允许普通（没有权限申请物资）的护士向供应室领用申请 
        public static bool IsAllowNotWzGysHouseApply { get; set; }
        //体检报告是否使用统一的格式 
        public static bool IsCkUseCommonReport { get; set; }
        //体检报告的见检验结果是否从第三方LIS读取 
        public static bool IsCkUseOtherLIS { get; set; }
        //是否由住院护士登记入院（默认当前科室） 
        public static bool IsNurseRegInHosInfo { get; set; }
        //是否套餐明细选择默认全选 
        public static bool IsXdRpSelectAll { get; set; }
        //是否发票打印凑整费 
        public static bool IsInvoicPrintAddFee { get; set; }
        //住院注射卡打印格式是否使用A4宽行（true）；false-旧双列省纸模式 
        public static bool IsInTransfusionBillOnePatTogether { get; set; }
        //是否发票打印使用自由格式（新广东版本） 
        public static bool IsInvoicePrintFree { get; set; }
        //体检前是否需要报到确认的环节 
        public static bool IsCheckNeedRecieveConfirm { get; set; }
        //门诊护士是否打印注射卡(医生打印护士就不需要) 
        public static bool IsMzNursePrintReject { get; set; }
        //医嘱保存后是否保留医嘱信息继续核对？ 
        public static bool IsAdviceSavedReOpen { get; set; }
        //门诊注射卡打印A5 
        public static bool IsOuExecuteBillPrintA5 { get; set; }
        //LIS系统的结果是否查询第三方系统 
        public static bool IsOtherLISInterface { get; set; }
        //是否护士只审核本科室（非大科）的医嘱 
        public static bool IsInAdviceAuthMyLocation { get; set; }
        //是否门诊药房自动打印处方对应窗口分工作时间段限制 
        public static bool IsOuRoomWindowLimitWorkTime { get; set; }
        //项目输入是否需要人群限制 
        public static bool IsItemInputFilterForPeople { get; set; }
        //限制全院用户不能保存上次登录人 
        public static bool IsShowLastUser { get; set; }
        //医嘱时间是否允许修改 
        public static bool IsAllowEditAdviceTime { get; set; }
        //是否母亲出院时与婴儿一起 
        public static bool IsOutHospitalWithMother { get; set; }
        //是否限制每个放射部门只1张检查申请单（没有接口，只要求功能科室查看费用） 
        public static bool IsPsApplyReportOneXTypeOneSheet { get; set; }
        //是否出院带药结算后才由病人去药房领药(true)，还是由科室申请(false) 
        public static bool IsOutHospitalTakeDrugAfterBalance { get; set; }
        //是否出院发药打印前先预览 
        public static bool IsInSendDrugPrintPreview { get; set; }
        //是否住院床位按照名称排序 
        public static bool IsBedOrderByName { get; set; }
        //医生查看住院病人下拉列表时是否按先排列主诊医生 
        public static bool IsPatientSortMainDoctor { get; set; }
        //是否自动合并婴儿与母亲费用 
        public static bool IsMergeFeeWithBabyMother { get; set; }
        //微生物报表用2列打印 
        public static bool IsGramReportTwoColumn { get; set; }
        //体检接收后是否自动打印体检指引单 
        public static bool IsPrintGuideAfterRecieve { get; set; }
        //是否允许在LocalRegitFile文件设置免密码登陆 
        public static bool IsAllowNoPasswordLLogin { get; set; }
        //门诊收费以后是否还可以修改病历 
        public static bool IsAllowOuChargedModifyClinc { get; set; }
        //是否使用病人储值优惠卡 
        public static bool IsUsePatCardFee { get; set; }
        //是否跟踪用户登录 
        public static bool IsTraceLogin { get; set; }
        //是否使用指纹仪辨识病人 
        public static bool IsUseFingterCard { get; set; }
        //病人结果异常是否即时提示医生 
        public static bool IsTipResultUnNormal { get; set; }
        //是否体检报告常规项目与检验结果一起打印 
        public static bool IsCkReportLIS { get; set; }
        //是否体检报告常规项目与影像结果一起打印 
        public static bool IsCkReportPACS { get; set; }
        //体检是否需要接收才能进入体检流程 
        public static bool IsCkDefaultLsStatus { get; set; }
        //其他数据库连接是否只限制给某几个人使用 
        public static bool IsLimitOtherConnection { get; set; }
        //医生要求医嘱皮试，但护士不输入或者非阴性结果时是否拒绝打印和执行？ 
        public static bool IsAdviceSkinResultNeed { get; set; }
        //住院结算是否独立分开不同用户设置比例和收费？ 
        public static bool IsInBanlanceSetDiscIndependently { get; set; }
        //物资仓库只能修改自己库存的物品 
        public static bool IsModiMyHouseItem { get; set; }
        //门诊病人是否一次就诊使用多张发票 
        public static bool IsOuChargeOnePatMutiInvoice { get; set; }
        //住院中药房排在西药房后面？ 
        public static bool IsChinRoomBehindWest { get; set; }
        //一次性补助是补助记账部分还是优惠部分：true-记账部分 
        public static bool IsBanlaceFixDiscIn { get; set; }
        //住院结算保存后是否自动打印明细清单 
        public static bool IsBanlaceAutoPrintFeeItem { get; set; }
        //输项目时是否是否可以显示行号并支持输入行号选择项目 
        public static bool IsOrderNo { get; set; }
        //医嘱保存是否统一一个时间 
        public static bool IsSaveCommonAdviceTime { get; set; }
        //当前系统是否用于DEMO演示 
        public static bool IsDemo { get; set; }
        //备份数据库是否使用系统每晚运行的程序，而不是使用数据库自动备份工具 
        public static bool IsBackupByProgram { get; set; }
        //项目输入必须输入6位，不够前面补0 
        public static bool IsNumber6 { get; set; }
        //药房有尚未确认发出的药品，是否允许出院 
        public static bool IsAllowOutPatientDrugNotSend { get; set; }
        //电子病历保存是否自动写入签名和日期 
        public static bool IsEmrAddSign { get; set; }
        //出院是否默认收取床位费 
        public static bool IsOutGetBedFee { get; set; }
        //门诊发药是否按照发票号来发药 
        public static bool IsOuDrugIssueByInvoice { get; set; }
        //是否限制组不能有不同用法频率 
        public static bool IsLimitGroupUsageIsSame { get; set; }
        //是否允许药库修改药房的申领单数量 
        public static bool IsRmApplyAllowHuEdit { get; set; }
        //是否婴儿收取固定费用，例如诊查费 
        public static bool IsBabyGetInDayAddFee { get; set; }
        //是否要求不同类别的项目不能在同组使用 
        public static bool IsCheckGroupLsRpTypeIsSame { get; set; }
        //是否允许EMR复制和粘贴病历内容 
        public static bool IsEMRCopy { get; set; }
        //是否由药房打印注射卡 
        public static bool IsRoomPrintNurseReject { get; set; }
        //是否门诊和住院发票用同一台打印机 
        public static bool IsInOuSameCurrInvo { get; set; }
        //是否住院护士记帐允许修改待出院病人费用 
        public static bool IsInTallyAllowWaitForLeaveHospital { get; set; }
        //是否应用3级科室库存管理 
        public static bool IsLocationRmstores { get; set; }
        //是否护士取消出院需要出入院处确认 
        public static bool IsNurseCancelOutDoubleCheck { get; set; }
        //住院交款报表是否独立分开按金打印 
        public static bool IsDepositOuDayReport { get; set; }
        //在项目输入时是否所有病人类别都显示医保类别的备注 
        public static bool IsAllShowItemYbMemo { get; set; }
        //门诊发药“已发药”是否默认全部选取 
        public static bool IsOuDrugIssuedDefaultAllSelect { get; set; }
        //辅助科室记账是否按修改清空网格（病人以往费用），即只能录入新费用和作废 
        public static bool IsFunLoctionTallyModiClear { get; set; }
        //病人登记后是否自动打开门诊挂号 
        public static bool IsAddOuHosInfoAfterBsPatientSave { get; set; }
        //处方打印是否一张处方只能打印五种药 
        public static bool IsOuRecipeFiveDrug { get; set; }
        //住院发药是否要提示所有新的申领单 
        public static bool IsInDrugIssueNewAlert { get; set; }
        //住院发药后打印是否临嘱和长嘱分开上下午分别打印 
        public static bool IsInIssueSendLongAlone { get; set; }
        //入院时间是否以护士安排床位的时间为准 
        public static bool IsBedInModifyInTime { get; set; }
        //护士打印瓶签时是否打印今天已经停止的长嘱 
        public static bool IsAllowPrintEndLable { get; set; }
        //门诊发药是否需要电视屏幕叫号 
        public static bool IsOuDrugIssueCallMonitor { get; set; }
        //发票应交金额为零时是否打印发票 
        public static bool IsPrintInvoiceNoAmountPay { get; set; }
        //门诊注射卡是否打印规格 
        public static bool IsOuExecutePrintSpec { get; set; }
        //在已经打过发票的情况下，是否允许在门诊收费的登记病人窗口处修改病人信息：姓名、年龄 
        public static bool IsAllowOuChargeModifyPatientName { get; set; }
        //打开主界面时是否自动打开帮助文档 
        public static bool IsAutoShowHelpDoc { get; set; }
        //使用弹出式对话框而不是用ToolTips 
        public static bool IsShowMsgBoxNotToolTips { get; set; }
        //门诊收费如果不输入最高记账就是自费病人 
        public static bool IsOuChargeNoTallyNoAsSelfPatType { get; set; }
        //医保比例和限额是否取结算时的当时设置还是发生费用时的当时设置：true-以病人住院结算时的设置为准 
        public static bool IsReSetDiscInWhenBanlace { get; set; }
        //门诊医生自己挂号时是否启用按上下班时间挂不同的号 
        public static bool IsOutTimeRegType { get; set; }
        //病人卡号（在病历本上写号码时用到）是否自动产生 
        public static bool IsAutoCreateCardNo { get; set; }
        //住院执行单和输液卡是否一起打印？ 
        public static bool IsPrintExecuteWithTransfusion { get; set; }
        //毒麻药品是否不能在医嘱中开出 
        public static bool InAdviceForbitPoisonDrug { get; set; }
        //入院登记后是否弹出已登记信息给用户确认？ 
        public static bool IsConfirmAfterInSave { get; set; }
        //医嘱删除时是否再自动按SN顺序/最好不要排 
        public static bool IsAdviceReCalcSN { get; set; }
        //长期医嘱第二天如果没有静滴的话是否强制改变备注 
        public static bool IsModifyInAdviceLongMemo { get; set; }
        //病人识别是否有读身份证 
        public static bool IsIdCardRead { get; set; }
        //是否由门诊挂号处确认挂号类别和费用？否：挂普通号，医生就诊后确定挂号类别，实际挂号费在收费处计算和补收 
        public static bool IsOuRegConfirmRegFee { get; set; }
        //是否药库采购计划统计库从上次入库到目前为止的销售量作为计划默认采购数量 
        public static bool IsDrugApplyBySaleNum { get; set; }
        //是否标本登记后打印条码 
        public static bool IsTestSamplePrintBarcode { get; set; }
        //是否检验报告保存后自动下一步 
        public static bool IsTestResultAutoAuthorize { get; set; }
        //住院费用是否允许合并其他病人类别 
        public static bool IsAllowMergeOtherPatType { get; set; }
        //住院护士工作站是否打印检验条码 
        public static bool IsNursePrintLabel { get; set; }
        //打印医嘱时用法是否换行 
        public static bool PrintAdviceUsageNewLine { get; set; }
        //住院病人的信息是否从其他HIS系统读取 
        public static bool IsInPatientReadOtherHIS { get; set; }
        //打印检验报告时是否需要输入审核人和密码 
        public static bool IsPrintLISReportConfirmPassword { get; set; }
        //医生输入项目是查找本地还是服务器（基于网络和服务器负载考虑） 
        public static bool IsDoctorInputLocalSearch { get; set; }
        //体检结果不采用医生工作站，单机录入所有类别的结果 
        public static bool IsTjNoDoctorInput { get; set; }
        //昨天以前的费用在取消执行时能不能删除。false-不删除，产生退费 
        public static bool IsAbleDeleteLastFee { get; set; }
        //是否服务器运行复杂运算 
        public static bool IsHasApplationServer { get; set; }
        //上传医保费用是否需要做医保登记 
        public static bool IsUpYBhasReg { get; set; }
        //门诊药房打印处方是否分精神、麻醉、毒性、儿童等分开纸张打印 
        public static bool IsOuIssueRecipePrintClass { get; set; }
        //门诊医生是否需要输入儿科体重 
        public static bool IsOuRecipeInputChildWight { get; set; }
        //库存不足够时是否允许医生开医嘱 
        public static bool IsStockNumNotEnoughForbidRecipe { get; set; }
        //库存计算是否连药库一起计算？ 
        public static bool IsStockNumCalculateWithHouse { get; set; }
        //住院长嘱是否减去临嘱皮试的药品：临嘱皮试过后的药用于长嘱静滴 
        public static bool IsSkinAddInLongAdvice { get; set; }
        //住院发药是否打印药袋标签 
        public static bool IsInDrugIssuePrintLabel { get; set; }
        //住院输液瓶签是否长临嘱同组号一起打印 
        public static bool IsLabelPrintMergeLongTemp { get; set; }
        //是否有合理用药系统 
        public static bool IsNewPassConnection { get; set; }
        //是否医嘱打印医生名字（false-不打印，自己签字） 
        public static bool IsAdvicePrintDoctorName { get; set; }
        //是否病程记录要增加一行空白行 
        public static bool IsEmrDayRecordInsertEmptyLine { get; set; }
        //是否医嘱备注需要选择科室 
        public static bool IsAdviceDemoAddLocationName { get; set; }
        //体检报告是否需要打印封面 
        public static bool IsCkResultPrintFirstPage { get; set; }
        //门诊医生是否需要显示上一次的诊断 
        public static bool IsShowLastClincDiag { get; set; }
        //护士床位管理是否允许用户修改入院时间 
        public static bool IsAllowEditInTimeInBed { get; set; }
        //系统加载时是否自动打开导向图 
        public static bool IsShowRoadChart { get; set; }
        //门诊病人的信息是否从其他HIS系统读取 
        public static bool IsOuPatientReadOtherHIS { get; set; }
        //门诊注射室是否只打印一天的瓶签？ 
        public static bool IsOuExecutePrintOneDay { get; set; }
        //门诊收费手工登记病人是否要自动生成挂号费和诊金？ 
        public static bool IsManalOuHosInfoGetRegFee { get; set; }
        //医生登记完申请单以后是否要打印？ 
        public static bool IsPsApplyReportSavePrint { get; set; }
        //输入体检单后是否打印指引单？ 
        public static bool IsPrintInspectionGuide { get; set; }
        //输入体检单后是否按分组打印分组检查的条码？ 
        public static bool IsPrintOtherLabNumOn { get; set; }
        //体温单的入院时间是否以医嘱开始时间为准？ 
        public static bool IsHeatChartInTimeForAdviceTime { get; set; }
        //能不能删除已经使用过的套餐？ 
        public static bool IsXdRpCanNotDeletedUsed { get; set; }
        //标本必须经过接收后才能进入检验室流程 
        public static bool IsLabNeedRecieveConfirm { get; set; }
        //门诊收费是否获取个人体检单费用 
        public static bool IsOuChergeGetPersonCheck { get; set; }
        //检验报告回退需要输入密码 
        public static bool IsTestRsultGoBackPassword { get; set; }
        /// <summary>
        /// 内服袋子只收一次得ID --2-20
        /// </summary>
        public static int  PackUsageIdOneDrugItemId { get; set; }
        //门诊挂号发票是否分人走？false-跟机器走 
        public static bool IsRegInvoiceForPerson { get; set; }
        //是否启用密码复杂规则 
        public static bool IsPasswordRule { get; set; }
        //未完成的标本打印是否提示用户确认 
        public static bool IsUnFinishLabTips { get; set; }
        //病人登记后是否打印条码 
        public static bool IsBsPatientSavePrintBarCode { get; set; }
        //门诊收费后是否打印试管条码 
        public static bool IsOuChargeSavePrintTestLabel { get; set; }
        //检验结果回退是否直接回退到未完成？ 
        public static bool IsLabResultBackToOutStanding { get; set; }
        //护士执行单一天多次时药品名是否打印多行 
        public static bool IsPrintMultiItemName { get; set; }
        //住院药房退药后自动打印退药单 
        public static bool IsBackAutoPrint { get; set; }
        //医保农合住院结算是否补充封顶额 
        public static bool IsInLimitTopLocal { get; set; }
        //门诊瓶签是否打印单张（条码纸） 
        public static bool IsOuBottleLabelSingle { get; set; }
        //住院药房打印汇总单是否连口服药一起汇总。false-只汇总针剂 
        public static bool IsPrintInDrugAll { get; set; }
        //长期医嘱的执行单是否提早一天打印 
        public static bool IsLongAdvicePrintPreDay { get; set; }
        //门诊收费是否两次回车就弹出开始收费 
        public static bool IsOuChargeEnterBeginBalance { get; set; }
        //企业调价是否对药库明细入库价和零售价进行调价 
        public static bool IsAdjustEntUpdateHuOutDtl { get; set; }
        //长期医嘱提前一天打印（日期打印为明天） 
        public static bool IsLongTransfusionBillPrintLastDay { get; set; }
        //门诊收费是否采用本地结算（非医保上传）？ 
        public static bool IsOuBalaceLocal { get; set; }
        //住院按金发票号码是否前两位以字母开头 
        public static bool IsInDespitBeginWithCahr { get; set; }
        //门诊收费处是否没有维护自付比例而是按最高记帐去结算，最高金额多少就记帐多少 
        public static bool IsOuChargeDiscDiagNotZeroForYB { get; set; }
        //门诊注射单是否按天数打印多张 
        public static bool IsOuMzDropPrintForDays { get; set; }
        //门诊收费处是否打印肌注单 
        public static bool IsOuChargePrintMzReject { get; set; }
        //门诊收费处是否打印静滴单 
        public static bool IsOuChargePrintMzDrop { get; set; }
        //门诊收费处是否打印治疗单 
        public static bool IsOuChargePrintMZCure { get; set; }
        //门诊挂号是否要弹出发票预览（全院统一） 
        public static bool IsOuRegPreview { get; set; }
        //住院凑整费是否四舍五入：true－四舍五入；false－直接进位 
        public static bool InTintTypeByIn { get; set; }
        //住院结算时是否提示费用跟婴儿费用合并 
        public static bool IsTipsMergeFeeWithBabyMotherInBalance { get; set; }
        //护士执行单的瓶签是否用英文的单位名 
        public static bool IsPrintLabelEnglishUnitName { get; set; }
        //门诊收费和住院记账按Ctrl+S出来明细而不是大项。false-出大项 
        public static bool IsCtrlSToDetailFee { get; set; }
        //住院发票是否打印医保结算表的计算方法 
        public static bool IsPrintYbStringInInvoice { get; set; }
        //检查报告是否显示PACS系统的图像（前提是有PACS接口） 
        public static bool IsFrmPsApplyReportWithPacsBmp { get; set; }
        //是否限制非公共权限人员物品维护 
        public static bool IsModiMaterialLimit { get; set; }
        //是否在项目下拉控件显示有附加收费的项目 
        public static bool IsItemListTipAttachItem { get; set; }
        //体温单时间是否根据医嘱时间 
        public static bool IsInBodyHeatForAdviceTime { get; set; }
        //出院天数是否算最后一天 
        public static bool IsChargeDaysUnIncludeLastDay { get; set; }
        //药袋是否在门诊收费 
        public static bool IsOuChargeDrugBag { get; set; }
        //门诊发票己生成交款报表能不能退费 
        public static bool IsOuChargeTallyBack { get; set; }
        //Ctrl+S弹出选择了CtrlF的项目后是否还要弹出明细项目选择 
        public static bool IsBsItemAttachConfirmDetail { get; set; }
        //BsUsageItem所含的皮试药的ItemId，例如5%氯化钠 
        public static bool SkinDrugItemId { get; set; }
        //是否强制要求手术费用与临时医嘱同时存在才能出院 
        public static bool IsOpsFeeMustHasDoctorAdvice { get; set; }
        //是否应用临床路径 
        public static bool IsUseDgRoad { get; set; }
        //是否允许用户在修改病历的状态复制（危险！） 
        public static bool IsEMRAllowEditCopy { get; set; }
        //病程记录是否需要加每行低格横虚线 
        public static bool IsEMRAddLine { get; set; }
        //是否直接连接影像系统的数据库读取结果 
        public static bool IsOtherPACSInterface { get; set; }
        //是否运行医生在自挂号时免诊金免挂号费 
        public static bool IsDoctorCanFreeRegDiagFee { get; set; }
        //是否使用数字认证模块 
        public static bool EmrIsVerify { get; set; }
        //门诊医生是全科医生的界面 
        public static bool IsWholeLocationOuRecipeTitle { get; set; }
        //门诊诊断是否只能录入ICD 10 诊断 或待检等 
        public static bool IsOuIllDescMustInput { get; set; }
        //出院结算通知单 
        public static bool IsWaitForLeavePrint { get; set; }
        //门诊挂号时是否同步修改病人基础资料 
        public static bool IsOuRegToUpdatePatInfo { get; set; }
        //出院时检查是否项目执行 
        public static bool IsCheckNoExecute { get; set; }
        //抗生素医嘱是否单独有药剂科审核才能执行，即医嘱保存时不是审核状态 
        public static bool IsAntiBacterialAdviceAuthAlone { get; set; }
        //门诊收费是否自动分配药房窗口 
        public static bool IsAutoSetRoomWindowName { get; set; }
        //住院医生医嘱是否运行录入材料 
        public static bool IsDocotrInputAdviceAllowMaterial { get; set; }
        //是否使用双通道，即接滴通道1，接滴通道2等用法 
        public static bool IsDropdiffUsageIddiffFee { get; set; }
        //输液是否按最大频率收费 
        public static bool IsDropMaxFrequencyTimesFee { get; set; }
        //补执行确认的费用时间是否今天，即插入到今天的费用记账 
        public static bool IsExecuteNoTodayFeeToToday { get; set; }
        //辅助科室记账是否需要录入新费用和作废 
        public static bool IsFunLoctionAddFee { get; set; }
        //住院护士查对时是否对欠费检查并控制 
        public static bool IsInAuthCheckDeposit { get; set; }
        //是否住院药房对要求皮试但没有结果或阳性的药不发出 
        public static bool IsInDrugIssueNotSendPositive { get; set; }
        //住院护士是否需要每日打印明细清单给病人 
        public static bool IsInPrintFeeEveryDay { get; set; }
        //病人挂号后是否打印条码 
        public static bool IsOuHosInfoSavePrintBarCode { get; set; }
        //在需要统计配药工作量，必须点击配药确认的情况下，门诊发药和配药操作人是否一样？ 
        public static bool IsOuSendAndDosageSameMan { get; set; }
        //出院病人是否必须录入病人的身份证号 
        public static bool IsOutHospitalInputIdCardNo { get; set; }
        //门诊预约挂号是否打印发票 
        public static bool IsPreRegOuHosInfoPrintInvoice { get; set; }
        //长期医嘱打印是否打印首末日次数 
        public static bool IsPrintLongAdviceFirstLastDay { get; set; }
        //系统是否处于正式运行状态 
        public static bool IsSystemOnline { get; set; }
        //系统是否处于练习操作阶段 
        public static bool IsSystemOnPractise { get; set; }
        //系统是否跟踪所有人的操作痕迹 
        public static bool IsTraceAllOperate { get; set; }
        //是否应用独立配置中心药房模式 
        public static bool IsUseDropDrugCenterRoom { get; set; }
        //门诊发药是否需要电视屏幕叫号 
        public static bool ToFeeFromMemoItemIds { get; set; }
        //不退片剂时费用是否由病人承担 
        public static bool InNotBackDrugFormIdsGetFee { get; set; }
        //出院是否删除婴儿床位 
        public static bool IsBabyOutHospitalWithMotherClearBed { get; set; }
        //是否删除其它费用 
        public static bool IsDeleteOterFee { get; set; }
        //电子病历是否允许复制 
        public static bool IsEMRCOPYToDoctor { get; set; }
        //住院病人是否需要插凑整费 
        public static bool IsInBalanceInsertTintFee { get; set; }
        //临时医嘱没输皮试结果的时候是否允许继续查对长嘱 
        public static bool IsLongAdviceMustWriteSkinResult { get; set; }
        //门诊收费处是否打印诊疗通知单 
        public static bool IsOuChargeSavePrintExecLocation { get; set; }
        //是否可调出别的分院病人进行收费 
        public static bool IsOuChargeWithOtherHospital { get; set; }
        //收费交款报表是否需要把发票分类统计也打印出来 
        public static bool IsOuDayFeeBsInvInItemReport { get; set; }
        //住院是否打印按金单 
        public static bool IsPrintDeposit { get; set; }
        //当材料当成药品处理时是否分开处方打印 
        public static bool IsPrintOuRecipeForMaterial { get; set; }
        //门诊电子病历是否要医生和助手分开录入保存 
        public static bool IsSaveOuEmrAlone { get; set; }
        //是否门诊收款处自动根据看诊医生的挂号类别的应收挂号费用减去在挂号处已收取的挂号费自动调整？ 
        public static bool IsRegFeeAdjustInOucharge { get; set; }
        //处方打印是否一张处方只能打印五组药 
        public static bool IsOuRecipeFiveGroup { get; set; }
        //无用 
        public static bool SubsequentUsageId { get; set; }
        //项目维护时改变进货价是否自动根据加成率算零售价 
        public static bool IsAdjustForAddPercent { get; set; }
        //门诊发药是否允许选择打印？ 
        public static bool IsOuRoomSelectPrint { get; set; }
        //入院登记是否必须填写诊断？ 
        public static bool IsInHosInfoNeedDiag { get; set; }
        //领药申请发送全区是否自动申请还没领的药 
        public static bool IsSendLocationCreateDrugReq { get; set; }
        //是否从旧系统取电子病历 
        public static bool IsReadOldSystemEmr { get; set; }
        //医生开医嘱时是否要弹出检查申请单 
        public static bool IsViewInPacs { get; set; }
        //医嘱管理是否启用右键快捷菜单功能 
        public static bool IsAddRightFunction { get; set; }
        //导病案是否自动归档病历 
        public static bool IsImportBAAutoAuth { get; set; }
        //处方打印是否按处方号来打印 
        public static bool IsOuRecipeFiveListNum { get; set; }
        //门诊就诊是开启高级别才能给低级别开处方 
        public static bool IsCheckCanRecipeDiffRegType { get; set; }
        //门诊收费是否双屏显示 
        public static bool IsOuChargeShowScrean { get; set; }
        //是否启用发药机 
        public static bool IsUseSendMachineSystem { get; set; }
        //检查项目是否由辅助科室执行收费 
        public static bool IsInPsExecuteGenFee { get; set; }
        //是否启用紧急数据库 
        public static bool IsEnabledUrgen { get; set; }
        //是否加载护士菜单 
        public static bool IsLoadMouseMemu { get; set; }
        //挂号费为0是否打印发票 
        public static bool IsOuRegPrintInvoiceZero { get; set; }
        //门诊挂号是否需要多种支付方式结算 
        public static bool IsOuInvoiceRegMutiPayWay { get; set; }
        //是否使用Lis系统 
        public static bool IsUseLisSystem { get; set; }
        //门诊发票是否用动态的（非动态发票分类定了位置） 
        public static bool IsPrintOuInvoiceNoAllInvMzItem { get; set; }
        //自动生成卡号是否不按日期生成 
        public static bool IsAutoCreateNotDateCarNo { get; set; }
        //门诊导入费用是否导到住院实际发生的费用false另外一张表,true导到ininvoicedtl 
        public static bool IsOuToFeeIninoiceDtl { get; set; }
        //住院医保病人是否通过医保办审核 
        public static bool IsYBCheckOtherWindows { get; set; }
        //是否系统自动根据当前的时间填上频率？ 
        public static bool IsAutoFrequency { get; set; }
        //住院发药是否拆分两条记录,把长嘱首日当临时来发 
        public static bool IsInIssueSendByTwoDate { get; set; }
        //医嘱执行打印单据的时候不过滤记事医嘱,根据用法去打对应的单据 
        public static bool IsNoteAdviceFilter { get; set; }
        //门诊西药房是否有多个（每个药房不同的药品设置） 
        public static bool IsOuSendMutiWestRoom { get; set; }
        //作废医嘱时是否自动生产退药单 
        public static bool IsAutoCreateBackDrug { get; set; }
        //是否门诊医生打印就诊记录 
        public static bool IsMzDoctorPrintClinic { get; set; }
        //门诊发药是否打印药袋标签 
        public static bool IsConfirmDosagePrintLabel { get; set; }
        //门诊中药处方是否在总院发 
        public static bool IsOuChinDrugSentByCenterHospital { get; set; }
        //门诊医生保存后是否默认打印中药处方 
        public static bool IsOuDoctorPrintChinDefault { get; set; }
        //门诊配药是否打印处方 
        public static bool IsConfirmPrintRecipe { get; set; }
        //药房 
        public static bool IsOuChargeHaveDiffRoom { get; set; }
        //是否只打印服药单 
        public static bool isonlyprintdrup { get; set; }
        //检查项目是否只执行不收费由功能科在辅助科室记账那里记账 
        public static bool IsInPsExecuteGenExec { get; set; }
        //您是否现在要把本此入库的药品转出到药房 
        public static bool IsAddDrugToPharmacy { get; set; }
        //是否由药房分天来打印注射卡 
        public static bool IsRoomPrintA5WithDays { get; set; }
        //门诊首诊 
        public static bool IsFirstCheck { get; set; }
        //导诊 
        public static bool IsModifyCardNo { get; set; }
        //门诊发票是否把凑整费加到药费上打印 
        public static bool OuInvoicePrintAddFeeToDrugFee { get; set; }
        //电子病历填写出院小结时是否插入inemrxml中 
        public static bool IsSaveInsertEmrXml { get; set; }
        //门诊收费是否检查医保系统同一病人挂号不用病人类别 
        public static bool IsCheckYbPatientDoubleGH { get; set; }
        //门诊就诊是否五组药分方,true:五组药分方,false:五个药分方 
        public static bool IsOuRecipeFiveGroupNum { get; set; }
        //体温单上面文字是否显示在前后两小时 
        public static bool IsBeforeAfterTwo { get; set; }
        //是否门诊医生默认打印就诊记录 
        public static bool IsMzDoctorDefaultPrintClinic { get; set; }
        //采购入库的零售价是否根据所填：买入价*数量*加成率计算 
        public static bool IsModfiyHuBuyInRetailPrice { get; set; }
        //门诊收费应交金额和自负金额是否四舍五入 
        public static bool IsAmountPayAndAmountSeltCZ { get; set; }
        //召回病人并注销出院结算时是否恢复作废的按金 
        public static bool IsCallBackCancelInDeposit { get; set; }
        //检验申请单是否分组打印 
        public static bool IsPrintTestApplySheetByGroupNum { get; set; }
        //同一组打印验单 
        public static bool IsPrintTestApplySheet { get; set; }
        //药房有尚未确认退的药品，是否允许出院 
        public static bool IsAllowOutPatientDrugNotBack { get; set; }
        //是否审核调整价格 
        public static bool IsPriceAdjustNeedAuthrize { get; set; }
        //是否门诊收费后立刻发药 
        public static bool IsSaveOuBalanceToSendDrug { get; set; }
        //是否横向打印处方 
        public static bool IsLandscapeOuRecipe { get; set; }
        //项目维护是否可以修改处方项目 
        public static bool LsRpTypeEnabled { get; set; }
        //医保病人支付方式为现金时，是否插入凑整费 
        public static bool IsOuTallyIntegral { get; set; }
        //标本登记保存之后是否默认打印条码 
        public static bool IsPrintTestRecipePrint { get; set; }
        //门诊就诊只有一条套餐是否弹出选择套餐窗体 
        public static bool IsShowAloneXdRp { get; set; }
        //是否每天限额 
        public static bool IsLimitGroupToday { get; set; }
        //门诊就诊是否需要填写病人血压值 
        public static bool IsOuRecipeWriteExamBp { get; set; }
        //药房盘点单是否打印空白盘点单 
        public static bool IsRmPKPrintBlank { get; set; }
        //门诊交款报表日期是否按日期段显示 
        public static bool IsDateTimeRangeForOuDayReport { get; set; }
        //是否住院天数超过N天警告提示 
        public static bool IsWarningInPatDays { get; set; }
        //门诊收费是否需要LED显示屏 
        public static bool IsChargeShowLED { get; set; }
        //是否发票打印使用自由格式（收据） 
        public static bool IsInvoicePrintFreeOld { get; set; }
        //创智医保是否使用上传码上传 
        public static bool IsUpLoadCode { get; set; }
        //检查申请单是否分组打印 
        public static bool IsPrintCheckApplySheetByGroupNum { get; set; }
        //治疗单是否分组打印 
        public static bool IsPrintCureApplySheetByGroupNum { get; set; }
        //住院和门诊使用的医保类文件是否一致 
        public static bool IsChargeUseYbFileIsEqcual { get; set; }
        //门诊就诊界面是否显示优先、免诊金、免挂号费、急诊、首诊 
        public static bool IsOuRecipeShowPriorityAndFreeDiagSoso { get; set; }
        //是否使用门诊公共医生 
        public static bool IsOuRecipeCommonDoctor { get; set; }
        //公费病人是否插入凑整费 
        public static bool IsGfInvoicAddFee { get; set; }
        //门诊就诊首诊大于35岁病人是否需要填写血糖值 
        public static bool IsOuRecipeWriteExamSugar { get; set; }
        //是否打印健教处方号到门诊处方上 
        public static bool IsPrintGoodRecipeOuRecipe { get; set; }
        //门诊就诊是否需要输入标准的Icd诊断 
        public static bool IsOuRecipeNeedDiagIcd { get; set; }
        //门诊就诊首诊大于35岁是否需要填写健教处方 
        public static bool IsOuRecipeWriteGoodRecipe { get; set; }
        //是否打印精二处方到普通西药处方上 
        public static bool IsPrintSecMentalToWestRecipe { get; set; }
        //不同药房是否分处方收费 
        public static bool IsDiffRoomBranchOuRecipeBalance { get; set; }
        //门诊收费是否打印凑整费 
        public static bool IsPrintOuInvoiceAddFee { get; set; }
        //用户、医生控件前是否显示工号 
        public static bool IsUserShowCodeBeforeName { get; set; }
        //是否使用个人电脑号来上传医保（在医疗证号不为空的前提下） 
        public static bool IsUseUploadCzYbByIndi { get; set; }
        //门诊收费是否先加载诊断 
        public static bool IsOuChargeLoadIllness { get; set; }
        //是否把门诊病历诊断放到一起另起一页-门诊就诊界面 
        public static bool IsOuRecipeMedicalRecordToGether { get; set; }
        //是否把必填项放到一起-病人管理与导诊界面 
        public static bool IsTogetherMandatoryOuPatient { get; set; }
        //是否需要填写病人的职业-病人管理与导诊界面 
        public static bool IsWorktypeId { get; set; }
        //门诊挂号是否需要填写挂号类型 
        public static bool IsWriteRegType { get; set; }
        //领药出库是否可以修改（在当前领药出库的项目的批次的零售价与仓库药物品维护界面的零售价不等的情况下）当前仓库药物品维护界面的零售价、门诊价格和住院价格 
        public static bool IsUserChangeRetailPriceAndBsItemPrice { get; set; }
        //是否可以退中药 
        public static bool IsBackDrugChinRecipeDtl { get; set; }
        //住院打印输液单是否按Qd频率 
        public static bool IsPrintTransfusionByQd { get; set; }
        //设置为不可用的项目是否能出现在盘点 
        public static bool IsItemNotActive { get; set; }
        //病案首页、死亡记录等出院时间是否读取病人死亡时间 
        public static bool IsWriteDeadTimeToCYDATE { get; set; }
        //入院登记是否能够直接输入其它医院名称 
        public static bool IsWriteFromHospitalNameOnInHos { get; set; }
        //是否门诊处方按空格换组:false为空格换组，true为回车换组 
        public static bool IsOuRecipeSpaceOrEnter { get; set; }
        //是否默认病人上一次看病的所有诊断 
        public static bool IsDefaultAllLastOuClincDiag { get; set; }
        //住院药房发药是否打印针剂单（与打印片剂口服药单据格式一样） 
        public static bool IsInjectSendDrugTotal { get; set; }
        //空调降温费 
        public static bool IsKongtiaoJWFee { get; set; }
        //空调升温费 
        public static bool IsKongtiaoSWFee { get; set; }
        //公费限额是否根据医生职称来区分 
        public static bool IsDocLevIdLimitGroup { get; set; }
        //公医门诊是否使用公医证号上传医保 
        public static bool IsUseInsr_codeUploadYb { get; set; }
        //是否需要下拉跟随（门诊就诊界面录入中医诊断） 
        public static bool IsChinIllPopup { get; set; }
        //是否显示超限金额(区公费病人) 
        public static bool IsShowLimitGroupStr { get; set; }
        //门诊收费是否获取单位体检单费用 
        public static bool IsOuChergeGetCompanyCheck { get; set; }
        //是否保存查询条件(报表) 
        public static bool IsSaveSelectRPT { get; set; }
        //门诊处方查询是否可以选择医生和项目 
        public static bool IsShowItemAndDoctorForOuRecipeSearch { get; set; }
        //是否有健教处方 
        public static bool IsShowOuRecipeGoodRecipe { get; set; }
        //BsItem控件是否显示执行科室 
        public static bool IsShowPopuBsItemControl { get; set; }
        //自费项目是否上传医保(创智医保) 
        public static bool IsUploadSelfFeeItemCzYb { get; set; }
        //中药处方保存时是否提示打印处方 
        public static bool IsInChinRecipeSave { get; set; }
        //附加项目的执行科室是否与所开医嘱的执行科室一致 
        public static bool IsSelectExecLocIdForAdvice { get; set; }
        //出院是否默认收取诊查费 
        public static bool IsOutGetInCheckFee { get; set; }
        //是否根据诊断填写健教处方 
        public static bool IsOuRecipeWriteGoodRecipeForIllNess { get; set; }
        //是否接收门诊就诊转诊数据 
        public static bool IsOuTransferPatient { get; set; }
        //未匹配的项目是否需要限制上传到医保（广州医保） 
        public static bool IsNotMatchUpLoadForGzYb { get; set; }
        //是否根据诊断自动选择健教处方号 
        public static bool IsAutoGoodRecipe { get; set; }
        //南州花园社区站 
        public static bool ISNanZhouHuaYuan { get; set; }
        //是否能够删除其他医生的套餐 
        public static bool IsNotUserIdCanDelete { get; set; }
        //是否药房LED队列显示屏 
        public static bool IsLEDDrupRoom { get; set; }
        //住院发药是否打印针剂明细(新格式) 
        public static bool IsInDrugIssueUseNewPrintClass { get; set; }
        //门诊是否默认焦点在卡号，否-默认在流水号 
        public static bool IsOuFousCard { get; set; }
        //送检 
        public static bool IsUserPacsInterface { get; set; }
        //体检是否默认正常结果 
        public static bool IsCkMainDefaultOK { get; set; }
        //过敏史提示 
        public static bool GetSensitive { get; set; }
        //是否启用BP功能 
        public static bool IsUseBP { get; set; }
        //门诊收费是否使用分期功能 
        public static bool IsUseOuPaymentMoney { get; set; }
        //redis数据库是否有数据 
        public static bool IsReadFromRedis { get; set; }
        //是否启用BP功能演示数据 
        public static bool IsUseBPData { get; set; }
        //是否门诊收费后发送材料到药房 
        public static bool IsSendCLToRoom { get; set; }
        //门诊医保病人结算是否使用记账本的剩余记帐金额 
        public static bool isCheckTallyNoForGfPatient { get; set; }
        //处方分方号打印5个药分页 
        public static bool IsOuRecipeFiveDruglist_Num { get; set; }
        // 
        public static bool IsOuDrugSendPrintChinNb { get; set; }
        //辅助科室记账药品自动申请 
        public static bool IsSaveDtlCreateDrug { get; set; }
        //血库病人结果信息 
        public static string CkBldApplyLocGreen { get; set; }
        //门诊预约是否短信通知 
        public static bool IsOuhosInfoYYSendMessage { get; set; }
        //门诊收费是否提示有已就诊但未结算的项目 
        public static bool IsChargedShowPayed { get; set; }
        //是否配药 
        public static bool IsDosage { get; set; }
        //HIS挂号是否与区域医联体的转诊平台对接 
        public static bool IsOuHosInfoFromCombination { get; set; }
        //仓库是否开启检测科室的申请单 
        public static bool IsWarningLocationApply { get; set; }
        //是否根据一级分组来盘点仓库盘点 
        public static bool IsHuWzCheckGroupMainId { get; set; }
        //描述连接集成平台 
        public static bool IsCdssAlone { get; set; }
        //护士工号入院登记保存后是否自动弹出按金管理界面 
        public static bool IsNurseRegDmInHosInfo { get; set; }
        //体检报告的见检验结果是否从第三方PACS读取 
        public static bool IsCkUseOtherPACS { get; set; }
        //是否显示【门诊挂号】界面【读市民卡】按钮 
        public static bool IsShowBarFrmOuHosInforeadybcard { get; set; }
        //是否显示【门诊挂号】界面【读健康卡】按钮 
        public static bool IsShowBarFrmOuHosInforeadjkcard { get; set; }
        //是否显示【门诊挂号】界面【读卡】按钮 
        public static bool IsShowBarFrmOuHosInfoYYReadCard { get; set; }
        //是否启用门诊收费的分期付款 
        public static bool IsShowBarFrmOuChargeReplyment { get; set; }
        //是否启用门诊收费的手术申请通知单 
        public static bool IsShowFrmOuRecipeOpsApply { get; set; }
        //是否启用门诊就诊的复制全部门诊记录 
        public static bool IsShowFrmOuRecipeCopyAll { get; set; }
        //是否启用门诊就诊的粘贴全部门诊记录 
        public static bool IsShowFrmOuRecipePasteAll { get; set; }
        //是否启用门诊就诊的查找病人进行会诊 
        public static bool IsShowFrmOuRecipePatientAll { get; set; }
        //是否启用门诊就诊的电子病历 
        public static bool IsShowFrmOuRecipeOuEmr { get; set; }
        //是否显示西药网格的剂型、处方类别、公费类别 
        public static bool IsShowFrmOuRecipeDataGridColumns { get; set; }
        //打印发票是否套打格式 1.true - 套打 ，false -全打 
        public static bool IsChromatoGraphyInvoice { get; set; }
        //是否显示【门诊收费】界面【读市民卡】按钮 
        public static bool IsShowBarFrmOuChargereadybcard { get; set; }
        //是否显示【门诊收费】界面【读健康卡】按钮 
        public static bool IsShowBarFrmOuChargereadjkcard { get; set; }
        //是否显示【门诊就诊】界面【读市民卡】按钮 
        public static bool IsShowBarFrmOuRecipereadybcard { get; set; }
        //是否显示【病人管理与导诊】界面【读市民卡】按钮 
        public static bool IsShowBarFrmBsPatientreadybcard { get; set; }
        //个人体检登记时是否自动报到 
        public static bool IsTJAutoRecieve { get; set; }
        //按金管理界面是否显示按金挂起和取消挂起按钮 
        public static bool IsShowDepositHang { get; set; }
        //使用超卓打印方式 
        public static bool IsUseCZPrint { get; set; }
        //是否显示叫号系统(门诊护士界面) 
        public static bool IsShowBarFrmOuExecuteCall { get; set; }
        //是否显示清屏 
        public static bool IsShowBarFrmOuExecuteClearCall { get; set; }
        //是否启用门诊收费的基础分类选项卡 
        public static bool IsShowBarFrmOuChargeXtpBaseType { get; set; }
        //是否显示叫号系统(门诊医生就诊界面) 
        public static bool IsShowBarFrmOuRecipeCall1 { get; set; }
        //是否开启查对医嘱界面的声音提示功能 
        public static bool IsOpenSoundSetting { get; set; }
        //是否开启设置保密等级 
        public static bool IsSecretLevel { get; set; }
        //是否隐藏医嘱执行界面关于执行单类别的勾选框 
        public static bool IsHideTop { get; set; }
        //是否启用门诊就诊的toolbar删除 
        public static bool IsShowBarFrmOuRecipeDelete { get; set; }
        //是否在收费后自动打印检查申请单 
        public static bool IsPrintCheckApplyAfterBalance { get; set; }
        //是否在收费后自动打印检验申请单 
        public static bool IsPrintTestApplyAfterBalance { get; set; }
        //是否在收费后自动打印治疗单 
        public static bool IsPrintCureAfterBalance { get; set; }
        //是否在收费后自动打印输液单 
        public static bool IsPrintDropAfterBalance { get; set; }
        //是否在收费后自动打印注射单 
        public static bool IsPrintRejectAfterBalance { get; set; }
        //是否能看其它挂号类别的病人 
        public static bool IsLocationSee { get; set; }
        //住院发药是否打印针剂明细 
        public static bool IsPrintInjectDetailed { get; set; }
        //是否使用病历质控 
        public static bool IsUseQualityControl { get; set; }
        //门诊收费后是否自动打印发票 
        public static bool IsOuChargePrintOuIvoice { get; set; }
        //医嘱执行是否显示打印出院带药true为打印，false不显示 
        public static bool IsPrintoutCYDY { get; set; }
        //是否一起修改住院记录 
        public static bool IsTogetherModifyInhosInfo { get; set; }
        // 是否所有病人都必须填写联系人信息 
        public static bool IsDisplayContactInformation { get; set; }
        //是否在门诊收费打印发票时打印明细 
        public static bool IsInvoicePrintDtl { get; set; }
        // 是否显示检验累积报告 
        public static bool IsShowCkResultCumulateRecord { get; set; }
        //是否启用脚踏开关抓图 
        public static bool IsUsePedalCapture { get; set; }
        //门诊就诊超出药品限额是否允许保存 
        public static bool IsLimitOuRecipeSumAmountForSave { get; set; }
        //门诊收费是否从发药机获取中药 
        public static bool IsOuSendChineseMachine { get; set; }
        //药房药库是否合二为一 
        public static bool IsHuRmInOne { get; set; }
        //阳春民福医院设置门诊就诊界面的lblImpression控件显示为精神检查印象（原为望诊印象） 
        public static bool IsOuRecipeIllEmrForMinFu { get; set; }
        //出院结算时是否需要设置起始发票号（是否打印发票） 
        public static bool IsSetStartInvoWhenBalance { get; set; }
        //电子病历新增保存时是否需要输入密码 
        public static bool IsAddNewEMRHasPassWord { get; set; }
        //门诊就诊检验项目是否需要填写标本类型 
        public static bool IsFrmOuRecipeTestNeedInputSourceId { get; set; }
        //医嘱管理是否开启影像报告 
        public static bool IsOpenPsApplyReportNew { get; set; }
        //是否开启三元诊金减免功能 
        public static bool IsOpenYbFreeThreeYuan { get; set; }
        //【住院】医嘱管理：医生开检查医嘱时是否要弹出检查申请单界面 
        public static bool IsShowFrmPsApplyReport { get; set; }
        //【住院打印】医嘱执行：是否打印瓶签（A4纸） 
        public static bool IsInBottleLabelSingle { get; set; }
        //【住院打印】医嘱执行：打印全部只打印输液卡和总单（高州）true-打印全部 ，false-只打印输液卡和总单） 
        public static bool IsPrintTransfusionAndExecuteBillForGZ { get; set; }
        //是否一张申请单必须全选退药 
        public static bool IsDrugBackAll { get; set; }
        //门诊病人是否需要插凑整费 
        public static bool IsOuChargeInsertTintFee { get; set; }
        //网格控件是否自动调整列宽 
        public static bool IsDataGridBestFitColumns { get; set; }
        //发票号是否用流水收据号代替 
        public static bool IsReplaceInvoiceNo { get; set; }
        //是否需要医嘱护嘱显示 
        public static bool LsAdvice { get; set; }
        //是否需要填写预约情况 
        public static bool LsIntention { get; set; }
        //是否需要一次性设施费 
        public static bool LsStartCalcOneTimeFee { get; set; }
        //true短信为测试模式 
        public static bool sendTextMode { get; set; }
        //是否在门诊收费后自动打印处方单 
        public static bool IsOuChargeSaveAutoPrintRecie { get; set; }
        //住院是否按一天发药给病区(不分口服针剂) 
        public static bool IsInRoomSendLocationByOneDay { get; set; }
        //是否住院医嘱发送材料到药房 
        public static bool IsInSendCLToRoom { get; set; }
        //门诊收费是否开启按折后金额收 
        public static bool IsOuChargeUseDiscountAoumt { get; set; }
        //门诊发票上显示医生姓名或工号)(true-姓名,false-工号) 
        public static bool IsOuChargeInvoPrintDocName { get; set; }
        //药库出库是否打印无菌条码)(true-打印,false-不打印) 
        public static bool PrintHuOutBarCode { get; set; }
        //【住院】退费注销时是否验证医保结算 true - 验证 fasle - 不验证 
        public static bool IsCancelInInvoiceCheckYb { get; set; }
        //是否在门诊就诊显示远程会诊的选项卡 
        public static bool IsShowHisTalk { get; set; }
        //是否启用VIP制度 
        public static bool IsEnabledVIP { get; set; }
        //是否使用积分抵消 
        public static bool IsIntegralOffset { get; set; }
        //【住院】住院欠费病人是否弹出欠费提示框 
        public static bool IsArrearPatientShowMsgBox { get; set; }
        //【药房】药房查询界面是否显示导出按钮 
        public static bool IsFormSearchBaseRmShowExport { get; set; }
        //普通医生是否可以申请用血 
        public static bool IsDoctorApplyBlood { get; set; }
        //是否医嘱管理界面默认选中主治医生 
        public static bool IsAdviceSelDoc { get; set; }
        //除外的时间收取诊金为急诊诊金 
        public static bool IsOpenWorkDayOutDiagnoFee { get; set; }
        //上线跟踪痕迹功能：False为部分跟踪，True为全部都跟踪 
        public static bool IsOpenTraceAll { get; set; }
        //【门诊、住院】项目没有维护医保编码是否需要限制上传 true-限制，false -不限制 
        public static bool IsCheckYbCodeWhenUpLoadForHZ { get; set; }
        //【住院】医嘱执行：7小时内的检验是否归一起打印 
        public static bool IsTogotherPrintLisWithinSevenHours { get; set; }
        //门诊收费发票设置是否记录日志 
        public static bool IsLog { get; set; }
        //取消结算时是否删除该病人医保信息表的数据（YbPatSeq表） 
        public static bool IsDeleteYbPatSeqWhenCancelYbUpCB { get; set; }
        //脉搏是否与心率同步 
        public static bool IsHeartSynchPulse { get; set; }
        //医嘱执行是否开启打印执行单按钮 
        public static bool IsOpenExecute { get; set; }
        //是否允许护士在记账管理跨科室录入费用 
        public static bool IsAllowInsertFeeInDiffLocation { get; set; }

        //凑整费打印在发票上哪一项 
        public static string AddFeeInvoPrintFeety { get; set; }
        //挂号后增加门诊费用的科室ID 
        public static string AddOuChargeAfterOuHosInfoSaveLocationId { get; set; }
        //原“工作单位”的标题含义 
        public static string AddressWorkTitle { get; set; }
        //护士提示新医嘱的音乐mp3。空表示不提示 
        public static string AdviceAuthAlterNewMp3 { get; set; }
        //护士提示“立即”医嘱的音乐mp3。空表示不提示 
        public static string AdviceAuthAlterStMp3 { get; set; }
        //即使项目维护了执行科室，但仍然要在医嘱备注选择执行科室项目的ID 
        public static string AdviceDemoAddLocationNameExceptItemId { get; set; }
        //哪些频率当天开嘱时间在十点之后的要显示成16点 
        public static string AdviceTimeAfterTenShowSixteen { get; set; }
        //打印医嘱不打印的用法 
        public static string AdviceUsageNotPrintUsageIds { get; set; }
        //哪些新单据要求自动音乐提示用户审核 
        public static string AlertHuRmSheetType { get; set; }
        //采购入库调用超卓打印方法是否允许设计报表格式，1表示是 
        public static string allowDesignFrmHuBuyInPrint { get; set; }
        //门诊收费调用超卓打印方法是否允许设计报表格式，1表示是 
        public static string allowDesignFrmOuChargePrintOuInvoice { get; set; }
        //记账管理允许录入药品的科室ID 
        public static string AllowInputTallySystemDrugLocationIds { get; set; }
        //每组都需要单独执行加收附加费用，不受上一组相同用法影响的用法：例如肌注 
        public static string AloneExecUsageId { get; set; }
        //门诊收费哪些处方项目ItemId根据每次量去收材料费 
        public static string AloneTotalityItemId { get; set; }
        //哪些科室的费用不需要进行透支限额检查 
        public static string ArrearAmountFreeLocationIds { get; set; }
        //哪些病人类别不受按金不足的限制 
        public static string ArrearAmountFreePatTypeId { get; set; }
        //哪些病人类别不受按金或透支不足限制 
        public static string ArrearAmountFreePatTypeIds { get; set; }
        //门诊收费调用超卓打印方法是否自动打印预览，1表示是 
        public static string autoPrePrintViewFrmDepositPrint { get; set; }
        //门诊就诊调用超卓打印方法是否自动打印预览，1表示是 
        public static string autoPrePrintViewFrmHuBuyInPrint { get; set; }
        //采购入库调用超卓打印方法是否自动打印预览，1表示是 
        public static string autoPrePrintViewFrmOuChargePrintOuInvoice { get; set; }
        //按金管理调用超卓打印方法是否自动打印预览，1表示是 
        public static string autoPrePrintViewFrmOuHosPrintOuInvoice { get; set; }
        //自助挂号的PatTypeId 
        public static string AutoRegOuHosInfoPatTypeId { get; set; }
        //用系统每晚运行的程序备份数据库的目标文件夹 
        public static string BackupFolder { get; set; }
        //广东药监系统的上一次上传时间 
        public static string BeforeUploadTime { get; set; }
        //广东省病案系统的出生地（籍贯）的默认值 
        public static string BIRTHPL { get; set; }
        //BMJ最佳临床实践指导服务地址 
        public static string BPUrl { get; set; }
        //BP服务地址 
        public static string BPWebServiceAddress { get; set; }
        //项目控件排序的字段 
        public static string BsItemControlOrderBy { get; set; }
        //二级价格的标题名称 
        public static string BsItemSubPriceTitle { get; set; }
        //允许修改基本资料的工作站 
        public static string BsUpdateInsert { get; set; }
        //财务作废取消操作员取收款人ID 
        public static string CaiWuCancelOperId { get; set; }
        //门诊病历格式 
        public static string CaseHisToryStringFormat { get; set; }
        //门诊病历格式中哪些值为零时不显示 
        public static string CaseHisToryZero { get; set; }
        //中心药房退药时间 
        public static string CenterRoomBackDrugTime { get; set; }
        //收费显示字幕的LED屏幕产品品牌关键字：空-不显示；ZhongKeJuLong-中科巨龙 
        public static string ChargeShowLEDBrand { get; set; }
        //门诊收费需要LED屏的计算机名称 
        public static string ChargeShowLEDHostName { get; set; }
        //标本登记的“外院备注”的标题名称（如果此备注用于其它特定统计用途） 
        public static string CkLabRefMemoName { get; set; }
        //登陆公司名称 
        public static string CompanyTitle { get; set; }
        //药监系统企业ID号 
        public static string CoporationID { get; set; }
        //农合病人类别的ID 
        public static string CountryPatTypeId { get; set; }
        //超卓打印数据包的存放位置 
        public static string CZPrintUrl { get; set; }
        //按金管理调用超卓打印方法子类名，例如打印的内容属于健康档的签约医生这个报告单。（必填） 
        public static string dataSourceIdFrmDepositPrint { get; set; }
        //采购入库调用超卓打印方法子类名，例如打印的内容属于健康档的签约医生这个报告单。（必填） 
        public static string dataSourceIdFrmHuBuyInPrint { get; set; }
        //门诊收费调用超卓打印方法子类名，例如打印的内容属于健康档的签约医生这个报告单。（必填） 
        public static string dataSourceIdFrmOuChargePrintOuInvoice { get; set; }
        //门诊就诊调用超卓打印方法子类名，例如打印的内容属于健康档的签约医生这个报告单。（必填） 
        public static string dataSourceIdFrmOuHosPrintOuInvoice { get; set; }
        //初始化显示双屏的信息 
        public static string DefaultAmountBack { get; set; }
        //初始化显示双屏的信息 
        public static string DefaultAmountPay { get; set; }
        //双屏默认显示 
        public static string DefaultlblName { get; set; }
        //服务器的Port 
        public static string DivePortHost { get; set; }
        //DI数据库名 
        public static string DiverDatabaseName { get; set; }
        //DI数据源 
        public static string DiverODBC { get; set; }
        //DIODBC服务器 
        public static string DiverODBCServer { get; set; }
        //DI用户名 
        public static string DiverUser { get; set; }
        //结算时哪些病人类别需要按照项目汇总后四舍五入再分摊到每日 
        public static string DivideItemAmountRoundPatTypeIds { get; set; }
        //医生医嘱起始时间 
        //public static string DoctorAdviceBeginTime { get; set; }
        //入院登记不默认科室当前科室的医生ID 
        public static string DoctorRegInHosInfo { get; set; }
        //配置中心静脉药物配置费ItemId 
        public static string DropDrugCenterRoomFeeItemId { get; set; }
        //发送到配置中心的药品医嘱用法 
        public static string DropDrugCenterRoomUsageId { get; set; }
        //配置中心抗肿瘤化学药物配置费ItemId 
        public static string DropDrugCenterZLFeeItemId { get; set; }
        //可能有接滴的用法ID 
        public static string DropUsageId { get; set; }
        //静滴用法只收一次的项目ID 
        public static string DropUsageIdOneDrugItemId { get; set; }
        //角色权限设置界面下载电子病历模块的读取文件路径 
        public static string EmrFilePath { get; set; }
        //电子病历的统一字体名称 
        public static string EmrFondName { get; set; }
        //角色权限设置界面下载电子病历模块的读取图片路径 
        public static string EmrImgPath { get; set; }
        //角色权限设置界面下载电子病历模块加载界面获取数据地址 
        public static string EmrLoadPath { get; set; }
        //病历打印时机：1-提交打印；2-主任审核后打印；3-归档后打印 
        public static string EmrPrintStatus { get; set; }
        //电子病历保存位置 
        public static string EmrSavePath { get; set; }
        //电子病历模板保存路径 
        public static string EmrTemplateFloder { get; set; }
        //电子病历网站URL 
        public static string EMRUrl { get; set; }
        //角色权限设置界面下载模块的读取文件路径 
        public static string FilePath { get; set; }
        //使用指纹仪的电脑HostName（“,”分割，空表示所有电脑都使用） 
        public static string FingterCardHostNames { get; set; }
        //没有交诊金不能开处方是例外的病人类别 
        public static string ForbitRecipeWithoutDiagFeeExcepPatTypeIds { get; set; }
        //限制开出处方不能超出5组的用法ID 
        public static string GroupsLimitUsageIds { get; set; }
        //系统OEM商标名称 
        public static string HISCompanyLogoName { get; set; }
        //用户在登录时现在数据库下拉中看到的第一个数据源的名称 
        public static string HISDataSourceName { get; set; }
        //合理用药服务地址 
        public static string HLYYAddr { get; set; }
        //医院名字 
        public static string HospitalName { get; set; }
        //外退需要回填发票的仓库ID 
        public static string HuVoHuBackHouseId { get; set; }
        //身份证读卡器类别 
        public static string IdCardType { get; set; }
        //角色权限设置界面下载模块的读取图片路径 
        public static string ImgPath { get; set; }
        //按金管理调用超卓打印方法是否立即打印，1表示是 
        public static string immePrintFrmDepositPrint { get; set; }
        //采购入库调用超卓打印方法是否立即打印，1表示是 
        public static string immePrintFrmHuBuyInPrint { get; set; }
        //门诊收费调用超卓打印方法是否立即打印，1表示是 
        public static string immePrintFrmOuChargePrintOuInvoice { get; set; }
        //门诊就诊调用超卓打印方法是否立即打印，1表示是 
        public static string immePrintFrmOuHosPrintOuInvoice { get; set; }
        //住院记账退费不能超过多少元？ 
        public static string InBackFeeLimitAmount { get; set; }
        //床位管理的“停床”的名称（有时候叫请假） 
        public static string InBedLeaveName { get; set; }
        //不按科室过滤中药处方病人 
        public static string InChinRecipeCanSeeAllLocationId { get; set; }
        //住院发药打印的备注 
        public static string InDrugIssuePrintMemo { get; set; }
        //入院诊断（EMR元素） 
        public static string InHosIllness { get; set; }
        //静泵、静滴等循环收费的用法 
        public static string InjectUsageRollFee { get; set; }
        //住院医嘱作废后不自动退药的剂型ID 
        public static string InNotBackDrugFormIds { get; set; }
        //住院发药的时间点 
        public static string InRoomSendDrugTime { get; set; }
        //住院允许部分材料飞到药房的ItemId 
        public static string InSendCLToRoomItemId { get; set; }
        //哪些科室录入的费用在打印在临嘱里 
        public static string InvoicedtlManualPrintTempAdvice { get; set; }
        //插入临嘱是否审核 
        public static string IsAuthAdvInsrtTemp { get; set; }
        //生成项目编码的规则：FormGroup-{主组}{子组}{剂型}{序号}；RpType-按照RpType分类取最大的号码加1 
        public static string IsAutoGenItemCode { get; set; }
        //可以回退收费员的结账 
        public static string IsCanReturnFeeUserCode { get; set; }
        //有权限修改套餐的工号 
        public static string IsHasRole { get; set; }
        //不打印发票的病人类别id 
        public static string IsNotPrintInvoicePatTypeId { get; set; }
        //个人缴费金额不打印到发票上的病人类别id 
        public static string IsNotPrintInvoicePayAmountPatTypeId { get; set; }
        //出院结算是否允许多张发票？即允许用户在出院结算勾选项目结算 
        public static string IsOutBalanceMitiInvoice { get; set; }
        //有库存记录的药房ID,排查没有库存的临床科室也当做药房 
        public static string IsStockRoom { get; set; }
        //项目下拉控件排序字段 
        public static string ItemControlOrderBy { get; set; }
        //加成率有上限限制的费用：费用类别（“,”分割，空没有） 
        public static string LimitPriceFeeId { get; set; }
        //LIS系统的结果查询的门诊病人参数定义 
        public static string LISWebOutParName { get; set; }
        //LIS系统的结果查询URL 
        public static string LISWebURL { get; set; }
        //两对半结果默认值 
        public static string LiverFunctionResult { get; set; }
        //角色权限设置界面下载模块加载界面获取数据地址 
        public static string LoadPath { get; set; }
        //可以开临时会诊的科室ID 
        public static string LocationIdWithAdviceTemp { get; set; }
        //可以写其他科室电子病历的科室ID 
        public static string LocationIdWithEMR { get; set; }
        //长期医嘱每日审核时间（旧长嘱下午统一申领） 
        public static string LongAdviceAuthTime { get; set; }
        //医嘱执行地点附加哪些科室，如果护士选择其他科则晚上收费记账的执行科室为它科。例如：神经功能康复区，它为各科服务，但不属于辅助功能科 
        public static string LongAdviceExecLocAttach { get; set; }
        //停止医嘱后不需要打印输液卡的用法id 
        public static string LongAdvicePrintEndNotUsage { get; set; }
        //长期医嘱开大单位需要提示的剂型ID 
        public static string LongAdviceTipFormIds { get; set; }
        //药品说明书的存放路径 
        public static string MemoPictureLocation { get; set; }
        //茂名农村合作医疗导入参数 
        public static string MMNCHZYLPatTypeId { get; set; }
        //按金管理调用超卓打印方法类型名，表示打印的属于哪一个大类的，例如打印的内容属于健康档这类的。（必填） 
        public static string moduleNameFrmDepositPrint { get; set; }
        //采购入库调用超卓打印方法类型名，表示打印的属于哪一个大类的，例如打印的内容属于健康档这类的。（必填） 
        public static string moduleNameFrmHuBuyInPrint { get; set; }
        //门诊收费调用超卓打印方法类型名，表示打印的属于哪一个大类的，例如打印的内容属于健康档这类的。（必填） 
        public static string moduleNameFrmOuChargePrintOuInvoice { get; set; }
        //门诊就诊调用超卓打印方法类型名，表示打印的属于哪一个大类的，例如打印的内容属于健康档这类的。（必填） 
        public static string moduleNameFrmOuHosPrintOuInvoice { get; set; }
        //门诊西药处方自动填写“不执行”，可以修改总量。例如胰岛素、诺和灵 
        public static string MzRejectEditDosageItemId { get; set; }
        //哪些病人类别在入院登记需要录入居委会/镇 
        public static string NeedCommitteePatType { get; set; }
        //哪些表要跟踪新增痕迹 
        public static string NeedTraceTableInsert { get; set; }
        //哪些表要跟踪修改痕迹 
        public static string NeedTraceTableUpdate { get; set; }
        //新入院书写病程记录的音乐mp3。空表示不提示 
        public static string NewInEmrAlterStMp3 { get; set; }
        //新医保系统切换期间需要确认旧病人是否需要上传的病人类别 
        public static string NewYBSystemOperatingYbTypeId { get; set; }
        //结算时不需要凑整病人类别的PatTypeId 
        public static string NoAddFeePatTypeIds { get; set; }
        //免输密码登录的工作站 
        public static string NoPassWordHostName { get; set; }
        //不打印住院药袋的用法 
        public static string NoPrintLabUsage { get; set; }
        //哪些科室不允许护士退费 
        public static string NotAllowBackFeeByNurseLocationIds { get; set; }
        //哪些病人类别不需要生成床位费 
        public static string NotBedFeePatTypeIds { get; set; }
        //记事医嘱的UsageId 
        public static string NoteAdviceUsageId { get; set; }
        //标本登记后不打印条码的科室LocationId 
        public static string NotPrintLabLabelLocationIds { get; set; }
        //标本登记后不打印条码的检验类别TestTypeId 
        public static string NotPrintLabLabelTestTypeIds { get; set; }
        //不打印执行单的用法UsageID 
        public static string NotPrintUsageIDs { get; set; }
        //床位管理需要显示出来护理等级的ItemId 
        public static string NurseClassItemIds { get; set; }
        //打印护理单的记事医嘱 
        public static string NurseNoteAdvice { get; set; }
        //OA系统的文档内部模板的放置文件夹（路径） 
        public static string OaDocTemplateFolder { get; set; }
        //OA医院名称 
        public static string OAHospitalName { get; set; }
        //一次医嘱只能收一次的附加项目 
        public static string OneAdviceOnceItemId { get; set; }
        //哪些申请类别多个部位只申请一次 
        public static string OneApplySheetXTypeIds { get; set; }
        //门诊收费自动费用只收一次的项目。例如抽血费 
        public static string OneChargeOnceItemId { get; set; }
        //什么时候启用长嘱拆分两条记录 
        public static DateTime OpenLongAdviceTowDate { get; set; }
        //机构住址 
        public static string OrganizationAddress { get; set; }
        //使用其他数据库连接的电脑HostName（“,”分割，空表示所有电脑都使用） 
        public static string OtherConnectHostNames { get; set; }
        //其他数据库连接（“,”分割，空表示所没有其他连接） 
        public static string OtherConnection { get; set; }
        //门诊收费后打印中药处方目标打印机 
        public static string OuChargeChinRecipePrinter { get; set; }
        //需要带出药水瓶的收费项目ID 
        public static string OuChargeHasBottleItemId { get; set; }
        //门诊发票提示的抽血地点 
        public static string OuChargePrintLisRegPoint { get; set; }
        //门诊收费后打印西药处方默认目标打印机 
        public static string OuChargeWestRecipePrinter { get; set; }
        //门诊收费后打印西药处方默认目标窗口 
        public static string OuChargeWestRecipeRoomWindowName { get; set; }
        //门诊记录打印格式类别号 
        public static string OuClinicPrintType { get; set; }
        //门诊发药要自动打印的客户端名称 
        public static string OuDrugIssueAutoPrintHostName { get; set; }
        //哪些科室需要门诊挂号默认挂号科室 
        public static string OuHosInfoDefultForLocIds { get; set; }
        //哪种权限挂号不需要输入门诊发票 
        public static string OuHosInfoNoInvoiceRoleIds { get; set; }
        //门诊发票需要打印执行地点的科室ID 
        public static string OuInvoiceTipExceLocId { get; set; }
        //门诊哪个科室走住院流程但是领药要到西药房 
        public static string OuLocatonIdIsNotInHospitalRomm { get; set; }
        //特殊病人类别的要求门诊处方固定打印机的打印机名 
        public static string OuRecipePrintOnePrinter { get; set; }
        //哪些病人类别的门诊处方要求固定打印到某一台打印机 
        public static string OuRecipePrintOnePrinterPatTypeIds { get; set; }
        //门诊药房摆药前自动打印配药单还是标签（空：都不打印） 
        public static string OuRoomPrintRecipeOrLable { get; set; }
        //哪些病人类别的门诊发票要求记账凑整 
        public static string OuTallyIntegralPatTypeIds { get; set; }
        //科室病人出院时哪些固定费用出院时不收 
        public static string OutHospitalInDayAddItemId { get; set; }
        //假期排急诊号的开始日期，例如春节从除夕开始到初四都是挂急诊号 
        public static string OutTimeRegTypeBeginDateTime { get; set; }
        //假期排急诊号的结束日期，例如春节从除夕开始到初四都是挂急诊号 
        public static string OutTimeRegTypeEndDateTime { get; set; }
        //那些用法要收袋费用 
        public static string PackgeChargeUsageId { get; set; }
        //要收取药水瓶费的用法ID 
        public static string PackgeUsageId { get; set; }
        //非片剂（BsDrugForm.F1 = "1"）但需要收取药袋费的项目ID 
        public static string PackItemIds { get; set; }
        //PACS中间件服务器IP和端口 
        public static string PACSServerIP { get; set; }
        //Pacs影像存储类型 
        public static string PacsStoreType { get; set; }
        //PACS系统的结果查询的申请单号参数定义 
        public static string PACSWebApplyIdParName { get; set; }
        //PACS系统的结果查询的住院病人参数定义 
        public static string PACSWebInParName { get; set; }
        //PACS系统的结果查询的门诊病人参数定义 
        public static string PACSWebOutParName { get; set; }
        //PACS系统的结果查询URL 
        public static string PACSWebURL { get; set; }
        //DI默认密码 
        public static string Password { get; set; }
        //图片路径 
        public static string PatientPhotoFolder { get; set; }
        //病人照片放置位置 
        public static string PatImageFileAddress { get; set; }
        //哪种付款方式不用打印发票 
        public static string PayWayIdNoPrintOuInvoice { get; set; }
        //按金管理调用超卓打印方法打印份数 
        public static string printCopiesFrmDepositPrint { get; set; }
        //采购入库调用超卓打印方法打印份数 
        public static string printCopiesFrmHuBuyInPrint { get; set; }
        //门诊收费调用超卓打印方法打印份数 
        public static string printCopiesFrmOuChargePrintOuInvoice { get; set; }
        //门诊就诊调用超卓打印方法打印份数 
        public static string printCopiesFrmOuHosPrintOuInvoice { get; set; }
        //按金管理调用超卓打印方法打印机名。如果是立即打印的话，即immeprint="1"，就是必填项） 
        public static string printerNameFrmDepositPrint { get; set; }
        //采购入库调用超卓打印方法打印机名。如果是立即打印的话，即immeprint="1"，就是必填项 
        public static string printerNameFrmHuBuyInPrint { get; set; }
        //门诊收费调用超卓打印方法打印机名。如果是立即打印的话，即immeprint="1"，就是必填项 
        public static string printerNameFrmOuChargePrintOuInvoice { get; set; }
        //门诊就诊调用超卓打印方法打印机名。如果是立即打印的话，即immeprint="1"，就是必填项 
        public static string printerNameFrmOuHosPrintOuInvoice { get; set; }
        //住院每种药品打印一个药袋的对应剂型 
        public static string PrintLabelDrugForm { get; set; }
        //住院每种药品打印一个药袋的对应频率 
        public static string PrintLabelFrequency { get; set; }
        //住院每种药品打印一个药袋的对应药品 
        public static string PrintLabelitem { get; set; }
        //不用门诊收费也可以体检报到 
        public static string RecieveIsNotCheckInvoice { get; set; }
        //门诊处方单独一张处方打印的项目，例如接种疫苗 
        public static string RecipePrintAloneItemIds { get; set; }
        //一般打印机的名字 
        public static string RecipePrinterName { get; set; }
        //默认为VIP的病人类别 
        public static string RegVipPatTypeIds { get; set; }
        //报卡地址 
        public static string ReportUnit { get; set; }
        //设置单独打印A3纸的报表 
        public static string RptSetA3 { get; set; }
        //哪些工作站用来自助挂号 
        public static string SelfOuRegHostName { get; set; }
        //药监系统网址 
        public static string ServicesUrl { get; set; }
        //服务器IP 
        public static string SeverIP { get; set; }
        //上海百佳医院病案系统的Dbf文件位置 
        public static string ShbjDbfFolder { get; set; }
        //门诊发药连接电视屏幕叫号屏的客户端名称 
        public static string ShowCallMonitorHostName { get; set; }
        //Pacs影像SOPInstanceUID 
        public static string SOPInstanceUID { get; set; }
        //住院结算需要打印在发票的支付方式 
        public static string SpecielPrintPayWayId { get; set; }
        //语音叫号的候诊名单txt文件 
        public static string SpeechFolderLocation { get; set; }
        //哪些套餐需要统计？ 
        public static string SumXdRpIds { get; set; }
        //用户在登录时现在数据库下拉中看到的第二个数据源的名称 
        public static string TestDataSourceName { get; set; }
        //哪些病人类别在出院结算时需要提示退费记录 
        public static string TipCancelBalancePatTypes { get; set; }
        //按金管理调用超卓打印方法报表子标题 
        public static string titleAddFrmDepositPrint { get; set; }
        //采购入库调用超卓打印方法报表子标题 
        public static string titleAddFrmHuBuyInPrint { get; set; }
        //门诊收费调用超卓打印方法报表子标题 
        public static string titleAddFrmOuChargePrintOuInvoice { get; set; }
        //门诊就诊调用超卓打印方法报表子标题 
        public static string titleAddFrmOuHosPrintOuInvoice { get; set; }
        //按金管理调用超卓打印方法报表标题 
        public static string titleFrmDepositPrint { get; set; }
        //采购入库调用超卓打印方法报表标题 
        public static string titleFrmHuBuyInPrint { get; set; }
        //门诊收费调用超卓打印方法报表标题 
        public static string titleFrmOuChargePrintOuInvoice { get; set; }
        //门诊就诊调用超卓打印方法报表标题 
        public static string titleFrmOuHosPrintOuInvoice { get; set; }
        //第三方体检系统（通过接口传送检验数据）的名称 
        public static string TjCheckOtherSystemName { get; set; }
        //处方数量大约1，但检验条码打印一个的检验费用ID（“,”分割，空表示所有） 
        public static string TotalityGreaterOneTestItemIds { get; set; }
        //跟踪哪些角色的用户登录痕迹（“,”分割，空表示所有角色） 
        public static string TraceLoginRoleIds { get; set; }
        //双列报告强制打印的项目 
        public static string TwoColumnReportCkItemId { get; set; }
        //体检报告要求打印双列结果的TestGroupId 
        public static string TwoColumnTestGroupIds { get; set; }
        //检验单查询界面首要是查看结果的角色ID 
        public static string ViewLabResultRoles { get; set; }
        //临时结算的收费员的UserId 
        public static string VirtualInBanlaceOperId { get; set; }
        //网页病历地址 
        public static string WebEmrAddress { get; set; }
        //中心服务地址 
        public static string Ybhospitalserver { get; set; }
        //医保门特病人类别ID 
        public static string YBMTPatTypeId { get; set; }
        //优惠费的ItemId 
        public static string YHFItemId { get; set; }
        //病案管理与上传默认查询多少天前的病人 
        public static string DefaultUploadSelectDays { get; set; }
        public static string BdBankApplyMessage { get; set; }

        public static bool IsNurseModifyUsage { get; set; }
        public static string YBUser { get; set; }
        public static string YBPassword { get; set; }

        /// <summary>
        /// 病案管理是否自动打开下一个未审核病人
        /// </summary>
        public static bool AutomaticNext { get; set; }

        //毒麻是否分开处方
        //public static bool IsSeparateDMprescription { get; set; }

        //数据库暂无
        //public static string RmAppDrugIsShowPNo { get; set; }
        #endregion

        /// <summary>
        /// 参数settingValue是否包含参数item
        /// </summary>
        /// <param name="settingValue">用','或'，'或'|'拼接起来的字符串</param>
        /// <param name="item"></param>
        /// <param name="EmptyIsTrue"></param>
        /// <returns></returns>
        public static bool CheckSettingContain(string settingValue, object item, bool EmptyIsTrue = true)
        {
            if (string.IsNullOrEmpty(settingValue) || item == null) return EmptyIsTrue;
            string[] itemIds = settingValue.Split(',', '，', '|');
            string itemStr = item.ToString().Trim().ToUpper();
            for (int i = 0; i < itemIds.Length; i++)
            {
                if (itemIds[i].Trim().ToUpper() == itemStr)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 根据keyName设置SysSetting中的静态系统参数值
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="value"></param>
        public static void SetValueForGblSysSetting(string keyName, object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(keyName)) return;
            Type type = typeof(SysSetting);
            var properties = type.GetProperties();
            try
            {
                foreach (PropertyInfo propertyInfo in properties)
                {
                    if (keyName != propertyInfo.Name) continue;

                    object o = Convert.ChangeType(value, propertyInfo.PropertyType);
                    propertyInfo.SetValue(null, o);
                    break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据setting设置SysSetting中的静态系统参数值
        /// </summary>
        /// <param name="setting"></param>
        public static void SetValueForGblSysSetting(GblSetting setting)
        {
            string keyName = setting.KeyNum;
            string value = setting.SetValue;
            SetValueForGblSysSetting(keyName, value);
        }
        public static T[] GetArrayByDelimiter<T>(string paramValue, ParamDelimiter delimiter)
        {
            var separator = new char[] { };

            switch (delimiter)
            {
                case ParamDelimiter.Bracket:
                    separator = new char[] { Utilities.Constant.LeftSquareBracket, Utilities.Constant.RightSquareBracket };
                    break;

                case ParamDelimiter.Comma:
                    separator = new char[] { Utilities.Constant.Comma };
                    break;

                case ParamDelimiter.VerticalLine:
                    separator = new char[] { Utilities.Constant.VerticalLine };
                    break;

                default:
                    separator = new char[] { Utilities.Constant.LeftSquareBracket, Utilities.Constant.RightSquareBracket };
                    break;
            }

            var paramArray = paramValue.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            return Array.ConvertAll(paramArray, new Converter<string, T>(Converter<T>));
        }
        private static T Converter<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }
    }
}
