using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Model.Custom
{
   public class UspOuInvoiceCache:BaseModel
    {
        /// <summary>
        /// 是否审核
        /// </summary>
        public bool IsVerify
        {
            get;
            set;
        }

        /// <summary>
        /// 发票号码
        /// </summary>
        public string InvoNo
        {
            get;
            set;
        }

        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegId
        {
            get;
            set;
        }

        /// <summary>
        /// 病人ID，对应于Patient的Pat_Id
        /// </summary>
        public string PatId
        {
            get;
            set;
        }

        /// <summary>
        /// 发票时间
        /// </summary>
        public DateTime InvoTime
        {
            get;
            set;
        }

        /// <summary>
        /// 应结算金额（总金额）
        /// </summary>
        public double Beprice
        {
            get;
            set;
        }

        /// <summary>
        /// 自付金额（乘以DiscSelf前的金额）
        /// </summary>
        public double FactGet
        {
            get;
            set;
        }

        /// <summary>
        /// 医保/公医记帐金额
        /// </summary>
        public double Insurance
        {
            get;
            set;
        }

        /// <summary>
        /// 个人缴费金额
        /// </summary>
        public double PaySelf
        {
            get;
            set;
        }

        /// <summary>
        /// 应交金额（乘以DiscSelf后的金额）
        /// </summary>
        public double AmountPay
        {
            get;
            set;
        }

        /// <summary>
        /// 凑整费
        /// </summary>
        public double AddFee
        {
            get;
            set;
        }

        /// <summary>
        /// 起伏线
        /// </summary>
        public string TallyNo
        {
            get;
            set;
        }

        /// <summary>
        /// 退款备注
        /// </summary>
        public string Remark
        {
            get;
            set;
        }

        /// <summary>
        /// 登记时间
        /// </summary>
        public DateTime OperTime
        {
            get;
            set;
        }

        /// <summary>
        /// 登记人
        /// </summary>
        public string OperId
        {
            get;
            set;
        }

        /// <summary>
        /// 是否注销
        /// </summary>
        public bool IsCancel
        {
            get;
            set;
        }

        /// <summary>
        /// 注销日期
        /// </summary>
        public DateTime CancelOperTime
        {
            get;
            set;
        }

        /// <summary>
        /// 收费操作员
        /// </summary>
        public string CancelOperId
        {
            get;
            set;
        }

        /// <summary>
        /// 退款备注
        /// </summary>
        public string CancelMemo
        {
            get;
            set;
        }

        /// <summary>
        /// 退费的原发票
        /// </summary>
        public string InvoLastId
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime TallyTime
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CancelTallyTime
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double ReAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ReAmountDate
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string ReAmountMemo
        {
            get;
            set;
        }

        /// <summary>
        /// 病人类别
        /// </summary>
        public string PatTypeId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 科室ID,BsLocation.Id
        /// </summary>
        public string LocationId
        {
            get;
            set;
        }

        /// <summary>
        /// 医生Id,BsDoctor.Id
        /// </summary>
        public string DoctorId
        {
            get;
            set;
        }

        /// <summary>
        /// 交款时间
        /// </summary>
        public DateTime CheckTime
        {
            get;
            set;
        }

        /// <summary>
        /// 作废交款时间
        /// </summary>
        public DateTime CancelCheckTime
        {
            get;
            set;
        }

        /// <summary>
        /// 医生所嘱科室(BsDoctor.Locationid)
        /// </summary>
        public string DocLocId
        {
            get;
            set;
        }

        /// <summary>
        /// 作废发票的分院名称
        /// </summary>
        public int CancelHospital
        {
            get;
            set;
        }

        /// <summary>
        /// 医保流水号
        /// </summary>
        public string YbSeqNo
        {
            get;
            set;
        }

        /// <summary>
        /// 重打发票操作员
        /// </summary>
        public string ReReprintOperId
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
        /// 套餐优惠
        /// </summary>
        public double PackaDiscount
        {
            get;
            set;
        }

        /// <summary>
        /// 固定优惠
        /// </summary>
        public double FixedDiscount
        {
            get;
            set;
        }

        /// <summary>
        /// 固定补助
        /// </summary>
        public double FixedSubsidy
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:会员ID
        /// </summary>
        public string VipCardID
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:欠费类别 关联BsInvMzItem
        /// </summary>
        public string ArrearsTypeId
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:隐藏操作时间
        /// </summary>
        public DateTime HideOperTime
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:隐藏操作人ID
        /// </summary>
        public string HideOperID
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:是否隐藏
        /// </summary>
        public bool IsHide
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:上次欠款
        /// </summary>
        public double PreviousArrears
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:本次费用
        /// </summary>
        public double CurrentPay
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:本次欠款
        /// </summary>
        public double CurrentArrears
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:取消记账人
        /// </summary>
        public string TallyCancelOperId
        {
            get;
            set;
        }

        /// <summary>
        /// 行心云:1-治疗项目；2-理疗项目；3-体检项目；4-中草药处方. 5-西药；6-附加项目；7-材料；8-营养素 9其他（挂号费）10退费
        /// </summary>
        public bool LsRepType
        {
            get;
            set;
        }

        public double DiscountNum
        {
            get;
            set;
        }
    

        /// <summary>
        /// 记账金额
        /// </summary>
        public double AccountAmount
        {
            get;
            set;
        }
        /// <summary>
        /// 是否记账
        /// </summary>
        public bool IsTally
        {
            get;
            set;
        }
    }
}
