using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Model.Custom
{ 
    public class UspOuInvoiceDtlCache:BaseModel
    {
        /// <summary>
        /// 发票ID
        /// </summary>
        public string InvoId
        {
            get;
            set;
        }

        /// <summary>
        /// 收费项目
        /// </summary>
        public string ItemId
        {
            get;
            set;
        }

        /// <summary>
        /// 总用量
        /// </summary>
        public double Totality
        {
            get;
            set;
        }

        /// <summary>
        /// 门诊单位
        /// </summary>
        public string UnitId
        {
            get;
            set;
        }

        /// <summary>
        /// 单价(原价)
        /// </summary>
        public double Price
        {
            get;
            set;
        }

        /// <summary>
        /// 自付比例
        /// </summary>
        public double DiscDiag
        {
            get;
            set;
        }

        /// <summary>
        /// 是否修改自付比例
        /// </summary>
        public bool IsModiDisc
        {
            get;
            set;
        }

        /// <summary>
        /// 自费部分的打折比例
        /// </summary>
        public double DiscSelf
        {
            get;
            set;
        }

        /// <summary>
        /// 金额
        /// </summary>
        public double Amount
        {
            get;
            set;
        }

        /// <summary>
        /// 自付金额，等于(自负金额+自费金额)
        /// </summary>
        public double AmountFact
        {
            get;
            set;
        }

        /// <summary>
        /// 自负金额
        /// </summary>
        public double AmountSelf
        {
            get;
            set;
        }

        /// <summary>
        /// 可记帐金额
        /// </summary>
        public double AmountTally
        {
            get;
            set;
        }

        /// <summary>
        /// 实际应交金额（乘以DiscSelf后的金额）
        /// </summary>
        public double AmountPay
        {
            get;
            set;
        }

        /// <summary>
        /// 执行类别：1-收费；2-退费
        /// </summary>
        public int LsPerform
        {
            get;
            set;
        }

        /// <summary>
        /// 所属门诊限额
        /// </summary>
        public string LimitGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// 门诊限额
        /// </summary>
        public double LimitFee
        {
            get;
            set;
        }

        /// <summary>
        /// 执行科室
        /// </summary>
        public string ExecLocId
        {
            get;
            set;
        }

        /// <summary>
        /// 项目生成的医生
        /// </summary>
        public string DoctorId
        {
            get;
            set;
        }

        /// <summary>
        /// 门诊发票项目ID
        /// </summary>
        public string InvItemId
        {
            get;
            set;
        }

        /// <summary>
        /// 门诊收费类别，参照Pub_Med_Feety（MZorZY=1）
        /// </summary>
        public string FeeId
        {
            get;
            set;
        }

        /// <summary>
        /// 核算收据类别
        /// </summary>
        public string FeeHsId
        {
            get;
            set;
        }

        /// <summary>
        /// 协定处方ID
        /// </summary>
        public string XDRpId
        {
            get;
            set;
        }

        /// <summary>
        /// 公费报销报表费用类别
        /// </summary>
        public int LsReportType
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
        /// 对应处方明细
        /// </summary>
        public string RecipeItemId
        {
            get;
            set;
        }

        /// <summary>
        /// 对应处方明细套餐项目
        /// </summary>
        public string RecipeGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string DocLocID
        {
            get;
            set;
        }

        /// <summary>
        /// 用法备注
        /// </summary>
        public string Usagememo
        {
            get;
            set;
        }

        /// <summary>
        /// 用法对应BsUsage.Id
        /// </summary>
        public string Usageid
        {
            get;
            set;
        }

        /// <summary>
        /// 剂型对应BsFormDrug.id
        /// </summary>
        public string Formid
        {
            get;
            set;
        }

        /// <summary>
        /// 频率对应BsFrequency.Id
        /// </summary>
        public string Frequencyid
        {
            get;
            set;
        }

        /// <summary>
        /// 自动收
        /// </summary>
        public bool IsAutoCharged
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
        /// 行心云:会员扣减数量
        /// </summary>
        public int VipDeductionCount
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
        /// 行心云:体检套餐ID
        /// </summary>
        public string TjPackageID
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
