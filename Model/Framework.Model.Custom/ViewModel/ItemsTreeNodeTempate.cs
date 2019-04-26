using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model;

namespace Orm.Model.Custom
{
    [Serializable]
    public class ItemsTreeNodeTempate
    {
        public ItemsTreeNodeTempate()
        {
            ItemsTreeNodeDtl = new List<ItemsTreeNodeTempate>();
        }

        /// <summary>
        /// 节点登记
        /// </summary>
        public int NodeLv { get; set; }

        /// <summary>
        /// 数据自身ID
        /// </summary>
        //public int ID { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        //public string Name { get; set; }

        /// <summary>
        /// 自定义字段 1级 套餐数 2级 3级 总金额
        /// </summary>
        public string Custom { get; set; }

        /// <summary>
        /// 节点选择
        /// </summary>
        public bool IsSelected { get; set; }

        public BsItem BsItemInfo { get; set; }

        public List<ItemsTreeNodeTempate> ItemsTreeNodeDtl { get; set; }

        #region 爱宝贝
        public double PagePrice { get; set; }

        public int ItemNumber { get; set; }

        public int FeeMzId { get; set; } 
        #endregion
    }
}
