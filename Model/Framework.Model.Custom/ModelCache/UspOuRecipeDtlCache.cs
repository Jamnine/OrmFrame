using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Model.Custom
{
   public class UspOuRecipeDtlCache:BaseModel
    { 
        /// <summary>
        /// 退药时间
        /// </summary>
        public DateTime BackCancelTime
        {
            get;
            set;
        }
        /// <summary>
        /// 退药操作人
        /// </summary>
        public string BackCancelOperId
        {
            get;
            set;
        }

        /// <summary>
        /// 处方ID
        /// </summary>
        public string RecipeId
        {
            get;
            set;
        }

        /// <summary>
        /// 序号
        /// </summary>
        public int ListNum
        {
            get;
            set;
        }

        /// <summary>
        /// 项目
        /// </summary>
        public string ItemID
        {
            get;
            set;
        }

        /// <summary>
        /// 组号  id 
        /// </summary>
        public int GroupNum
        {
            get;
            set;
        }

        /// <summary>
        /// 用量
        /// </summary>
        public double Dosage
        {
            get;
            set;
        }

        /// <summary>
        /// 使用单位
        /// </summary>
        public string UnitTakeId
        {
            get;
            set;
        }

        /// <summary>
        /// 频率
        /// </summary>
        public string FrequencyId
        {
            get;
            set;
        }

        /// <summary>
        /// 用法
        /// </summary>
        public string UsageId
        {
            get;
            set;
        }

        /// <summary>
        /// 天数
        /// </summary>
        public int Days
        {
            get;
            set;
        }

        /// <summary>
        /// 总量
        /// </summary>
        public double Totality
        {
            get;
            set;
        }

        /// <summary>
        /// 门诊单位
        /// </summary>
        public string UnitDiagId
        {
            get;
            set;
        }

        /// <summary>
        /// 是否执行isNoAttach
        /// </summary>
        public bool IsAttach
        {
            get;
            set;
        }

        /// <summary>
        /// 是否附加项目
        /// </summary>
        public bool IsOtherFee
        {
            get;
            set;
        }

        /// <summary>
        /// 协定处方Id,BsXdRp.Id
        /// </summary>
        public string XDRpId
        {
            get;
            set;
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get;
            set;
        }

        /// <summary>
        /// 是否已结帐
        /// </summary>
        public bool IsCharged
        {
            get;
            set;
        }

        /// <summary>
        /// 是否作废
        /// </summary>
        public bool IsCancel
        {
            get;
            set;
        }

        /// <summary>
        /// 取消时间
        /// </summary>
        public DateTime CancelTime
        {
            get;
            set;
        }

        /// <summary>
        /// 取消人ID
        /// </summary>
        public string CancelOperId
        {
            get;
            set;
        }

        /// <summary>
        /// 护士是否已经审核
        /// </summary>
        public bool IsPrint
        {
            get;
            set;
        }

        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime PrintTime
        {
            get;
            set;
        }

        /// <summary>
        /// 审核人
        /// </summary>
        public string PrintOperId
        {
            get;
            set;
        }

        /// <summary>
        /// 是否准备
        /// </summary>
        public bool IsPrepared
        {
            get;
            set;
        }

        /// <summary>
        /// 准备时间
        /// </summary>
        public string PrepareTime
        {
            get;
            set;
        }

        /// <summary>
        /// 准备人ID
        /// </summary>
        public string PrepareOperId
        {
            get;
            set;
        }

        /// <summary>
        /// 是否发药
        /// </summary>
        public bool IsIssue
        {
            get;
            set;
        }

        /// <summary>
        /// 发药时间
        /// </summary>
        public DateTime IssueTime
        {
            get;
            set;
        }

        /// <summary>
        /// 发药人
        /// </summary>
        public string IssueOperId
        {
            get;
            set;
        }

        /// <summary>
        /// 医生是否确认退药
        /// </summary>
        public bool IsToBack
        {
            get;
            set;
        }

        /// <summary>
        /// 是否已退？
        /// </summary>
        public bool IsBack
        {
            get;
            set;
        }

        /// <summary>
        /// 是否已医生录入？
        /// </summary>
        public bool IsDoctorInput
        {
            get;
            set;
        }

        /// <summary>
        /// 处方张号
        /// </summary>
        public int RecNum
        {
            get;
            set;
        }

        /// <summary>
        /// 处方日期
        /// </summary>
        public DateTime RecipeTime
        {
            get;
            set;
        }

        /// <summary>
        /// 煎药类型
        /// </summary>
        public string CookType
        {
            get;
            set;
        }

        /// <summary>
        /// 关联到LOCATION表
        /// </summary>
        public string LocationId
        {
            get;
            set;
        }

        /// <summary>
        /// 关联到DOCTOR表
        /// </summary>
        public string DoctorId
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public int AllPageNo
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public int PageNo
        {
            get;
            set;
        }

        /// <summary>
        /// BP治疗方案明细ID对应表BsBPCureDtl
        /// </summary>
        public string CureDtlId
        {
            get;
            set;
        }

        /// <summary>
        /// 是否BP
        /// </summary>
        public bool IsBP
        {
            get;
            set;
        }

        /// <summary>
        /// BP理由
        /// </summary>
        public string BPReason
        {
            get;
            set;
        }

        /// <summary>
        /// 医保类别
        /// </summary>
        public string YbType
        {
            get;
            set;
        }

        /// <summary>
        /// 收费发票号
        /// </summary>
        public string InvoNo
        {
            get;
            set;
        }

        /// <summary>
        /// 是否自动收
        /// </summary>
        public bool IsAutoCharged
        {
            get;
            set;
        }

        /// <summary>
        /// 是否从门诊收费调用录入
        /// </summary>
        public bool IsForCharge
        {
            get;
            set;
        }

        /// <summary>
        /// 检查申请单Id
        /// </summary>
        public string ApplyId
        {
            get;
            set;
        }

        /// <summary>
        /// 单价
        /// </summary>
        public double Price
        {
            get;
            set;
        }

        /// <summary>
        /// 代码临时使用
        /// </summary>
        public string TempStr
        {
            get;
            set;
        }

        /// <summary>
        /// 儿童价格
        /// </summary>
        public double ChildPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 折扣价格
        /// </summary>
        public double DiscountPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>
        public bool IsAuthed
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:原优惠（%）
        /// </summary>
        public double OldDiscDiag
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:附加费备注
        /// </summary>
        public string AddMemo
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:滴速
        /// </summary>
        public string DripRates
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:皮试情况
        /// </summary>
        public string SkinTestCondition
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:计划执行时间
        /// </summary>
        public DateTime PlanExecuteTime
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:完成时间
        /// </summary>
        public DateTime CompleteTime
        {
            get;
            set;
        }


        /// <summary>
        /// 行心云:优惠（%）
        /// </summary>
        public double DiscDiag
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:病人类别名称
        /// </summary>
        public string PatTypeName
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云: 
        /// </summary>
        public bool SamlingType
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:执行人
        /// </summary>
        public string ExecOperID
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:是否显示套餐
        /// </summary>
        public bool IsShow
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:是否会员消费扣减项目
        /// </summary>
        public bool IsVipDeduction
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:是否用法附加项目
        /// </summary>
        public bool IsUsageItem
        {
            get;
            set;
        }

        /// <summary>
        /// 收费时间
        /// </summary>
        public DateTime ChargeDtime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 检验标本
        /// </summary>
        public string LabId
        {
            get;
            set;
        }

        /// <summary>
        /// 标本类型Name
        /// </summary>
        public string SourceName
        {
            get;
            set;
        }

        public int VipLeftCount { get; set; }
        public string TjPackageID { get; set; }
        public bool IsPage { get; set; }
        public double PagePrice { get; set; }
        public object ItemTypeName { get; set; }
        /// <summary>
        /// 频率数量
        /// </summary>
        public int FrequencyCount
        {
            get;
            set;
        }

        public string OperId
        {
            get;
            set;
        }
      

        /// <summary>
        /// 处方类型
        /// </summary>
        public string FeeMzIdCode
        {
            get;
            set;
        }

        /// <summary>
        /// 处方种类：1-治疗项目；2-理疗项目；3-体检项目；4-中草药处方. 5-西药
        /// </summary>
        public string RecipeNum
        {
            get;
            set;
        }
        /// <summary>
        /// 处方明细ID
        /// </summary>
        public string RecipeDtlId
        {
            get;
            set;
        }

        public string ItemName
        {
            get;
            set;
        }

        /// <summary>
        /// 单价
        /// </summary>
        public Double PriceDiag
        {
            get;
            set;
        }

        /// <summary>
        /// 金额
        /// </summary>
        public Double Amount
        {
            get;
            set;
        }

        public string UnitDiag
        {
            get;
            set;
        }

        /// <summary>
        /// 会员价
        /// </summary>
        public double VipPriceDiag
        {
            get;
            set;
        }

        /// <summary>
        /// 原价
        /// </summary> 
        public double OldPriceDiag
        {
            get;
            set;
        }

        /// <summary>
        /// 是否病人执行
        /// </summary>
        public bool IsPatExecute
        {
            get;
            set;
        }

        /// <summary>
        /// 第几次收费
        /// </summary>
        public int ChargeCount
        {
            get;
            set;
        }

        /// <summary>
        /// 套餐标记
        /// </summary>
        public string TypeTokenCode
        {
            get;

            set;
        }

        /// <summary>
        /// 是否重新保存
        /// </summary>
        public bool IsOper
        {
            get;
            set;
        }

        /// <summary>
        /// 备注人ID
        /// </summary>
        public string MemoOperID
        {
            get;
            set;
        }

        /// <summary>
        /// 项目(处方)类型id,关联BsMzFeeTy
        /// </summary>
        public string FeeMzId { get; set; }

        /// <summary>
        /// 红色显示
        /// </summary>
        public bool IsRed
        {
            get;
            set;
        }
        /// <summary>
        /// 处方种类：1-治疗项目；2-理疗项目；3-体检项目；4-中草药处方. 5-西药
        /// </summary>
        public int LsRepType
        {
            get;
            set;
        }
        /// <summary>
        /// 规格
        /// </summary>
        public string Spec
        {
            get;
            set;
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string UnitTakeName
        {
            get;
            set;
        }

        /// <summary>
        /// 频率名称
        /// </summary>
        public string FrequencyName
        {
            get;
            set;
        }

        /// <summary>
        /// 用法
        /// </summary>
        public string UsageName
        {
            get;
            set;
        }

        /// <summary>  
        ///  体检科室
        /// </summary>  
        public string TjLocationID
        {
            get;
            set;
        }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
        public string P4 { get; set; }

        /// <summary>
        /// 是否清理
        /// </summary>
        public bool IsDisposal { get; set; }

        /// <summary>
        /// 保存BsItem.Code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        ///支付金额
        /// </summary>
        public double AmountPay { get; set; }
        /// <summary>
        ///折扣金额
        /// </summary>
        public double AmountDiscount { get; set; }

        /// <summary>
        /// 减号套餐名称
        /// </summary>
        public string ComboName { get; set; }

        /// <summary>
        /// 体检科室名称
        /// </summary>
        public string TjLocationName { get; set; }
        /// <summary>
        /// 是否可以修改
        /// </summary>
        public bool CanModify
        {
            get;
            set;
        }
        /// <summary>
        /// 是否已收费
        /// </summary>
        public bool IsCharge { get; set; }

        /// <summary>
        /// 处方号
        /// </summary> 
        public DateTime InputTime { get; set; }

        /// <summary>
        /// 病人名称
        /// </summary>
        public string PatName { get; set; }
        /// <summary>
        /// 病人性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 病人性别
        /// </summary>
        public string Age { get; set; }
        /// <summary>
        /// 执行人姓名
        /// </summary>
        public string ExecOpeName { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 药品说明
        /// </summary>
        public string DrugInstruction { get; set; }
        /// <summary>
        /// 药品功效
        /// </summary>
        public string DrugEfficacy { get; set; }
        /// <summary>
        /// 药品禁忌
        /// </summary>
        public string DrugTaboos { get; set; }
        /// <summary>
        /// 收费类别名称
        /// </summary>
        public string FeeMzName { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName { get; set; }

        /// <summary>
        ///标本类型id
        /// </summary>
        public string SourceId { get; set; }
        /// <summary>
        /// 标本编号
        /// </summary>
        public string SpecimenCode { get; set; }
        /// <summary>
        ///标本类型id
        /// </summary>
        public string DrugFormId { get; set; }
        /// <summary>
        ///标本类型id
        /// </summary>
        public int TjStatus { get; set; }
        /// <summary>
        ///接收时间
        /// </summary>
        public DateTime ReceiveTime { get; set; }
        /// <summary>
        ///采集时间
        /// </summary>
        public DateTime AcquisitionTime { get; set; }
        /// <summary>
        ///休息时间
        /// </summary>
        public string RestTime { get; set; }
        /// <summary>
        ///体检项目id
        /// </summary>
        public string TjItemCodeID { get; set; }
        /// <summary>
        ///执行时间
        /// </summary>
        public DateTime OverTime { get; set; }
        /// <summary>
        ///剂型名称
        /// </summary>
        public string DrugFormName { get; set; }
        /// <summary>
        ///门诊id
        /// </summary>
        public string ClinicNo { get; set; }

        /// <summary>
        /// 是否接收
        /// </summary>
        public bool IsReceive { get; set; }

        /// <summary>
        /// 是否采集
        /// </summary>
        public bool IsAcquisition { get; set; }

        public int HowMany { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }

        public DateTime BirthDate { get; set; }
        /// <summary>
        /// 煮前水量
        /// </summary>
        public string BeforeWater { get; set; }
        /// <summary>
        /// 煮后水量
        /// </summary>
        public string AfterWater { get; set; }
        /// <summary>
        /// 是否皮试
        /// </summary>
        public bool IsStart { get; set; }
        /// <summary>
        /// 煎药分钟
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// 是否皮试
        /// </summary>
        public bool IsSkinTest
        {
            get;
            set;
        }
         
        /// <summary>
        /// 医院内部使用的项目
        /// </summary>
        public bool IsOnlyForSys
        {
            get;
            set;
        }
        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegId { set; get; }
    }
}
