using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    [Serializable]
    public class uspChargeSummary
    {
        public uspChargeSummary() { }
        /// <summary>
        /// 物品ID
        /// </summary>
        public string ItemId { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 总用量
        /// </summary>
        public double Totality { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public double Price { get; set; }

        public DateTime Date { get; set; }
        public string LocationId { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        public string LocationName { get; set; }
        public DateTime InputTime { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Spec { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        private bool _isHideIllness;
        /// <summary>
        /// 是否特殊患者
        /// </summary>
        public bool IsHideIllness
        {
            get { return _isHideIllness; }
            set { _isHideIllness = value; }
        }
    }
}
