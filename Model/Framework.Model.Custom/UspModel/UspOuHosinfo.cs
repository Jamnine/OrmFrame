using System;

namespace Orm.Model.Custom.UspModel
{

    /// <summary>
    /// 预约到诊报表查询类
    /// </summary>
    [Serializable]
    public class UspOuHosinfo : BaseModel
    {
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName { get; set; }

        /// <summary>
        /// 档案号
        /// </summary>
        public string PatNumber { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public string Age { get; set; }

        /// <summary>
        /// 登记状态
        /// </summary>
        public string RegisterState { get; set; }


        /// <summary>
        /// 就诊状态
        /// </summary>
        public string VisitState { get; set; }

        /// <summary>
        /// 挂号时间
        /// </summary>
        public string RegTime { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// 预约时间
        /// </summary>
        public string PRERegTime { get; set; }
    }
}
