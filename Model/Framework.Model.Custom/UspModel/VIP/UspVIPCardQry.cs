using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 会员卡信息组合类
    /// </summary>
    [Serializable]
    public class UspVIPCardQry : BaseModel
    {
        /// <summary>
        /// 会员姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 会员卡ID
        /// </summary>
        public string VIPCardID { get; set; }

        /// <summary>
        /// 充值总额
        /// </summary>
        public double RechargeAmount { get; set; }

        /// <summary>
        /// 总支出
        /// </summary>
        public double AE { get; set; }

        /// <summary>
        /// 总余额
        /// </summary>
        public double TotalBalance { get; set; }

        /// <summary>
        /// 总积分
        /// </summary>
        public double TotalIntegral { get; set; }

        /// <summary>
        /// 总消费积分
        /// </summary>
        public double AEIntegral { get; set; }

        /// <summary>
        /// 推荐奖励
        /// </summary>
        public double IntroducerReward { get; set; }

        /// <summary>
        /// 会员卡名称
        /// </summary>
        public string VIPCardName { get; set; }

        /// <summary>
        /// 会员卡号
        /// </summary>
        public string VIPCardNo { get; set; }

        /// <summary>
        /// 开卡时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 是否持卡人
        /// </summary>
        public bool IsCardHolder { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        public double Discount { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string OperName { get; set; }

        /// <summary>
        /// 卡状态（1正常 2挂失 3停用）
        /// </summary>
        public int CardStatus { get; set; }

        /// <summary>
        /// 有效截止日期
        /// </summary>
        public string InvalidDate { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string ModifiedOperName { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public string ModifiedOperTime { get; set; }

        /// <summary>
        /// 推荐人ID
        /// </summary>
        public string IntroducerID { get; set; }

        /// <summary>
        /// 推荐人名字
        /// </summary>
        public string IntroducerName { get; set; }

        /// <summary>
        /// 内部推荐人名字
        /// </summary>
        public string IntroducerOperName { get; set; }
    }
}
