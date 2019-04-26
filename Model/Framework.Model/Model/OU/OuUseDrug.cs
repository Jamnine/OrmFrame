using System;

namespace Orm.Model
{
    /// <summary>
    /// 主要用药  数据库不存在此表
    /// </summary>
    [Serializable]

    public class OuUseDrug : BaseModel
    {
        private string healthCheckUseId;
        private string drugName;
        private string usage;
        private string consumption;
        private DateTime usageTime = DateTime.Now;
        private int usageType;

        /// <summary>
        /// 省ID
        /// </summary>
        public string HealthCheckUseId
        {
            get
            {
                return healthCheckUseId;
            }

            set
            {
                healthCheckUseId = value;
            }
        }

        /// <summary>
        /// 药品名称
        /// </summary>
        public string DrugName
        {
            get
            {
                return drugName;
            }

            set
            {
                drugName = value;
            }
        }

        /// <summary>
        /// 用法
        /// </summary>
        public string Usage
        {
            get
            {
                return usage;
            }

            set
            {
                usage = value;
            }
        }

        /// <summary>
        /// 用量
        /// </summary>
        public string Consumption
        {
            get
            {
                return consumption;
            }

            set
            {
                consumption = value;
            }
        }

        /// <summary>
        /// 用药时间
        /// </summary>
        public DateTime UsageTime
        {
            get
            {
                return usageTime;
            }

            set
            {
                usageTime = value;
            }
        }

        /// <summary>
        /// 服药依从性
        /// </summary>
        public int UsageType
        {
            get
            {
                return usageType;
            }

            set
            {
                usageType = value;
            }
        }
    }
}
