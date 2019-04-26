using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 项目列表
    /// </summary>
    [Serializable]
    public class uspBsItemDtlStockQry:BaseModel
    {
        /// <summary>
        /// 通用名Id
        /// </summary>
        public string CommonNameId { get; set; }

        /// <summary>
        /// 项目编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 费用类别
        /// </summary>
        public string FeeMzID { get; set; }

        /// <summary>
        /// 物品类别
        /// </summary>
        public string GroupMainId { get; set; }

        /// <summary>
        /// 指示项目是否启用
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// 拼音码
        /// </summary>
        public string PYCode { get; set; }

        /// <summary>
        /// 五笔码
        /// </summary>
        public string WBCode { get; set; }

        /// <summary>
        /// 是否库存项目
        /// </summary>
        public bool IsForSys { get; set; }

        /// <summary>
        /// 自定义码
        /// </summary>
        public string ZdyCode{ get; set; }

        /// <summary>
        /// 英文名
        /// </summary>
        public string EngDesc { get; set; }

        /// <summary>
        /// 是否打折
        /// </summary>
        public bool isDiscount { get; set; }

        /// <summary>
        /// 医保编号
        /// </summary>
        public string MedicalCode { get; set; }
         
        public string ModiOperName { get; set; }
    }
}
