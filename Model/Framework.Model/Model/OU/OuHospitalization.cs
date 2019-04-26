using System;

namespace Orm.Model
{
    /// <summary>
    /// 住院治疗情况 数据库不存在此表
    /// </summary>
    [Serializable]
    public class OuHospitalization : BaseModel
    {
        private string healthCheckHitId;
        private DateTime enterlDate = DateTime.Now;
        private DateTime leaveDate = DateTime.Now;
        private string remarks;
        private string locationId;
        private string mzRegId;
        private int hospitalizationType;

        /// <summary>
        /// 中医ID
        /// </summary>
        public string HealthCheckHitId
        {
            get
            {
                return healthCheckHitId;
            }

            set
            {
                healthCheckHitId = value;
            }
        }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime EnterlDate
        {
            get
            {
                return enterlDate;
            }

            set
            {
                enterlDate = value;
            }
        }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime LeaveDate
        {
            get
            {
                return leaveDate;
            }

            set
            {
                leaveDate = value;
            }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks
        {
            get
            {
                return remarks;
            }

            set
            {
                remarks = value;
            }
        }

        /// <summary>
        /// 门诊ID
        /// </summary>
        public string MzRegId
        {
            get
            {
                return mzRegId;
            }

            set
            {
                mzRegId = value;
            }
        }

        /// <summary>
        /// 类型
        /// </summary>
        public int HospitalizationType
        {
            get
            {
                return hospitalizationType;
            }

            set
            {
                hospitalizationType = value;
            }
        }

        /// <summary>
        /// 机构名称
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegNo { get; set; }
    }
}
