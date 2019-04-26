using System;
using System.Collections.Generic;
using System.Windows;

namespace Orm.Model.Framework
{
    /// <summary>
    /// 节点树属性
    /// </summary>
    public class HuPropertyItemNode
    {
        public bool Flag { get; set; }
        public bool IsSelected { get; set; }
        public bool IsExpanded { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ParentId { get; set; }
        public string InBatchId { get; set; }
        public string InBatchNo { get; set; }  
        public double Num { get; set; }
        public string PNo { get; set; }
        public string Spec { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public string ManuName { get; set; }
        public double StockPrice { get; set; }
        public double RetailPrice { get; set; }
        public DateTime LimitDate { get; set; }
        public FontWeight SetFontWeight { get; set; }
        public System.Windows.Media.Color SetForeground { get; set; }
        public List<HuPropertyItemNode> ItemNodeList { get; set; }
        public HuPropertyItemNode()
        {
            ItemNodeList = new List<HuPropertyItemNode>();
        }
    }
}
