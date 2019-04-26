using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 查询护士执行单类
    /// </summary>
    [Serializable]
    public class UspOuExecute : BaseModel
    {
        /// <summary>
        /// OuExecute.GUID(护士执行单ID)
        /// </summary>
        public string GuId { get; set; }

        /// <summary>
        /// OuRecipeDtl.GUID（处方明细ID）
        /// </summary>
        public string RecipeDtlId { get; set; }

        /// <summary>
        /// BsItem.GUID(项目ID)
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 组号
        /// </summary>
        public int  GroupNum { get; set; }

        /// <summary>
        /// 是否皮试
        /// </summary>
        public bool IsSkinTest { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// 第几天
        /// </summary>
        public int NDay { get; set; }

        /// <summary>
        /// 第几次
        /// </summary>
        public int NTime { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public string Spec { get; set; }

        /// <summary>
        /// 剂型
        /// </summary>
        public string DrugFormName { get; set; }

        /// <summary>
        /// 次用量
        /// </summary>
        public double Dosage { get; set; }

        /// <summary>
        /// 用量单位
        /// </summary>
        public string UnitTakeName { get; set; }
        /// <summary>
        /// 是否执行
        /// </summary>
        private bool _isExecuted;
        public bool IsExecuted
        {
            get { return this._isExecuted; }
            set { this._isExecuted = value; }
        }
        /// <summary>
        /// 用法
        /// </summary>
        public string UsageName { get; set; }

        /// <summary>
        /// 频率
        /// </summary>
        public string FrequencyName { get; set; }

        /// <summary>
        /// 滴速
        /// </summary>
        public string DripRates { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 备注或皮试情况
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 状态 0 未发药 1 已发药 2 退药 3 已执行
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public string OperId { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime { get; set; }


    }
}
