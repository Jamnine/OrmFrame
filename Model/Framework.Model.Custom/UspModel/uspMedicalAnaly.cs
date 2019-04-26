using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 西药统计信息
    /// </summary>
    [Serializable]
    public class uspMedicalAnaly : BaseModel
    {       
        public uspMedicalAnaly() { }

        /// <summary>
        /// 项目ID
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 诊所名
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// 诊所地址
        /// </summary>
        public string LocationAddress { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 负责人电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 药品名
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// 药品规格
        /// </summary>
        public string ItemSpec { get; set; }

        /// <summary>
        /// 生产厂商
        /// </summary>
        public string ManuName { get; set; }

        /// <summary>
        /// 销售单位
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// 销售量
        /// </summary>
        public string SaleCount { get; set; }

        /// <summary>
        /// 总用量
        /// </summary>
        public double Totality { get; set; }
    }
}
