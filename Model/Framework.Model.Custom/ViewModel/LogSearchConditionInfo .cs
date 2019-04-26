using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 日志查询条件对象
    /// </summary>
    [Serializable]
    public class LogSearchConditionInfo 
    {
        /// <summary>
        /// 仓库ID
        /// </summary>
        public string HouseId {get;set;}
        /// <summary>
        /// 科室ID
        /// </summary>
        public string RoomId { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        public string PNo { get; set; }
        /// <summary>
        /// 物品编号
        /// </summary>
        public string  ItemCode {get;set;}
        /// <summary>
        /// 查询的开始时间
        /// </summary>
        public DateTime HappenTimeBegin { get; set; }
        /// <summary>
        /// 查询的结束时间
        /// </summary>
        public DateTime HappenTimeEnd { get; set; }
        /// <summary>
        /// 出入库类别
        /// </summary>
        public int ActType { get; set; }
        /// <summary>
        /// 医院ID
        /// </summary>
        public int HospitalID { get; set; }
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

        public string DimItem { get; set; }
    }
}
