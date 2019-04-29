using System;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 预约医生排班
    /// </summary>
    [Serializable]
    public class PMOuDocRegType
    {
        /// <summary>
        ///  门诊ID
        /// </summary>
        public string LocationID { get; set; }

        /// <summary>
        /// 医生ID
        /// </summary>
        public string DoctorID { get; set; }

        /// <summary>
        /// 医生ID
        /// </summary>
        public string doctorId { get; set; }

        /// <summary>
        /// 门诊ID
        /// </summary>
        public string locationId { get; set; }

        /// <summary>
        /// 星期几
        /// </summary>
        public DateTime week { get; set; }

        /// <summary>
        /// 是否宣传
        /// </summary>
        public bool Funpublic { get; set; }

        /// <summary>
        /// 是否有用诊所
        /// </summary>
        public bool Funlocation { get; set; }

        /// <summary>
        /// 医生排班(诊所ID)
        /// </summary>
        public string UserLocaID { get; set; }

        /// <summary>
        /// 医生排班(用户ID)
        /// </summary>
        public string UserDocID { get; set; }

        /// <summary>
        /// 星期几的日期
        /// </summary>
        public DateTime regdate { get; set; }

        /// <summary>
        /// 班次ID 
        /// </summary>
        public string TimeSpanID { get; set; }

    }
}
