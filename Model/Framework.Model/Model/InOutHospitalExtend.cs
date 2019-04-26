
namespace Orm.Model
{
    /// <summary>
    /// 病人转诊表 - 实体拓展类
    /// </summary>
    public partial class InOutHospital:BaseModel
    {
        /// <summary>
        /// 病人名称
        /// </summary>
        public string PatName
        {
            get; set;
        }
        /// <summary>
        /// 转诊医院
        /// </summary>
        public string InHospName
        {
            get; set;
        }
        /// <summary>
        /// 转诊科室
        /// </summary>
        public string InlocationName
        {
            get; set;
        }
        /// <summary>
        /// 转诊医生
        /// </summary>
        public string OutDocName
        {
            get; set;
        }
        /// <summary>
        /// 紧急程度
        /// </summary>
        public string LsemergencyName
        {
            get; set;
        }

        /// <summary>
        /// 接诊医生
        /// </summary>
        public string InDocName { get; set; }

    }
}
