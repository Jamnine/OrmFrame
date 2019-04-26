using System;
 
namespace Orm.Model.Parameter
{
    /// <summary>
    /// 微信端返回医生信息参数类
    /// </summary>
    [Serializable]
    public class PMDoctorInfo
    {
        /// <summary>
        /// 排班信息id
        /// </summary>
        public string OuDayScheduleId { get; set; }
        /// <summary>
        /// 医生id
        /// </summary>
        public string DoctorId { get; set; }
        /// <summary>
        /// 科室id
        /// </summary>
        public string DepartmentId { get; set; }
        /// <summary>
        /// 医生等级id
        /// </summary>
        public string DocLevId { get; set; }
        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 医生等级名称
        /// </summary>
        public string DocLevelName { get; set; }
        /// <summary>
        /// 医生图片路径
        /// </summary>
        public string PicturePath { get; set; }
        /// <summary>  
        ///诊所ID
        /// </summary>  
        public string LocationId { get; set; }
        /// <summary>
        /// 诊所名称
        /// </summary>
        public string LocationName { get; set; }
        /// <summary>  
        /// 出诊日期  
        /// </summary>  
        public DateTime ScheduleDate { get; set; }
        /// <summary>
        /// 简介、说明
        /// </summary>
        public string Descr { get; set; }
        /// <summary>
        ///挂号费
        /// </summary>
        public double RegistrationFee { get; set; }
        /// <summary>
        ///剩余挂号数
        /// </summary>
        public int SurplusCount { get; set; }
        /// <summary>
        ///剩余挂号数
        /// </summary>
        public int TotalNumber { get; set; }
        /// <summary>
        ///剩余挂号数
        /// </summary>
        public int RegisteredNumber { get; set; }

        /// <summary>
        /// 排班信息id数组
        /// </summary>
        public string OuDayScheduleIds { get; set; }

    }
}
