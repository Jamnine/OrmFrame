using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 库存查询条件对象
    /// </summary>
    [Serializable]
    public class StockSearchConditionInfo 
    {     
        /// <summary>
        /// 医院ID
        /// </summary>
        public int HospitalID { get; set; }
        /// <summary>
        /// 仓库ID
        /// </summary>
        public string HouseId {get;set;}
        /// <summary>
        /// 科室ID
        /// </summary>
        public string RoomId { get; set; }
        /// <summary>
        /// 物品编码
        /// </summary>
        public string  ItemCode {get;set;}
        /// <summary>
        /// 物品名称
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// 公司ID
        /// </summary>
        public string CompId { get;set;}
        /// <summary>
        /// 查询的开始事件
        /// </summary>
        public DateTime StoreDateBegin {get;set;}
        /// <summary>
        /// 查询的结束事件
        /// </summary>
        public DateTime StoreDateEnd { get; set; }
        /// <summary>
        /// 期限的开始时间
        /// </summary>
        public DateTime LimitDateBegin { get; set; }
        /// <summary>
        /// 期限的结束时间
        /// </summary>
        public DateTime LimitDateEnd { get; set; }
        /// <summary>
        /// 是否搜索库存时间
        /// </summary>
        public bool IsSearchStoreDate { get; set; }
        /// <summary>
        /// 是否搜索期限时间
        /// </summary>
        public bool IsSearchLimitDate { get; set; }
        /// <summary>
        /// 是否线下搜索
        /// </summary>
        public bool IsSearchUnderLineKc { get; set; }
        /// <summary>
        /// 是否线上搜索
        /// </summary>
        public bool IsSearchUperLineKc { get; set; }
        /// <summary>
        /// 项目组合大类ID
        /// </summary>
        public string GroupMainID { get; set; }
        /// <summary>
        /// 组合查询 条件 
        /// </summary>
        public string DimItem { get; set; }
        /// <summary>
        /// 是否分页
        /// </summary>
        public bool isPaging { get; set; }
        /// <summary>
        /// 显示行数
        /// </summary>
        public int PageNumber { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        public int PageSize { get; set; }

   
    }
}
