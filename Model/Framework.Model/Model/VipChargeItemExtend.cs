

using System;
namespace Orm.Model
{
	/// <summary>
	/// 会员金额对应项目表 - 实体类
	/// </summary>
	public partial class VipChargeItem :BaseModel
	{
        /// <summary>
        /// 价格
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// 会员单价
        /// </summary>
        public double VIPPrice { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName { get; set; }
    }
}           


