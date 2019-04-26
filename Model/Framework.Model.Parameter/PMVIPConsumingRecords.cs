using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;
using Orm.Model.Custom;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 会员消费记录
    /// </summary>
    [Serializable]
    public class PMVIPConsumingRecords
    {
        private List<OuRecharge> _rechargeDtl = new List<OuRecharge>();
        /// <summary>
        /// 会员充值记录
        /// </summary>
        public List<OuRecharge> RechargeDtl
        {
            get { return _rechargeDtl; }
            set { _rechargeDtl = value; }
        }

        private List<VipReckoningCharge> _vipReckoningChargeDtl = new List<VipReckoningCharge>();
        /// <summary>
        /// 会等级优惠消费明细
        /// </summary>
        public List<VipReckoningCharge> VipReckoningChargeDtl
        {
            get { return _vipReckoningChargeDtl; }
            set { _vipReckoningChargeDtl = value; }
        }

        private List<VipIntegral> _vipIntegralDtl = new List<VipIntegral>();
        /// <summary>
        /// 会员积分记录
        /// </summary>
        public List<VipIntegral> VipIntegralDtl
        {
            get { return _vipIntegralDtl; }
            set { _vipIntegralDtl = value; }
        }

        private List<VipCardLog> _vipCardLogDtl = new List<VipCardLog>();
        /// <summary>
        /// 会员换卡记录
        /// </summary>
        public List<VipCardLog> VIPCardLogDtl
        {
            get { return _vipCardLogDtl; }
            set { _vipCardLogDtl = value; }
        }

        private List<VipBinding> _memberDtl = new List<VipBinding>();
        /// <summary>
        /// 家庭成员
        /// </summary>
        public List<VipBinding> MemberDtl
        {
            get { return _memberDtl; }
            set { _memberDtl = value; }
        }

        
    }
}
