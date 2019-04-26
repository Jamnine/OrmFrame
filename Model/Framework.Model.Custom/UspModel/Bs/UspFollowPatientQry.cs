using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 病人回访信息
    /// </summary>
    [Serializable]
   
    public class UspFollowPatientQry : BaseModel  
    {

        /// <summary>
        /// 回访时间
        /// </summary>
        public DateTime FollowTime { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string OperName { get; set; }
        /// <summary>  
        /// 回访内容  
        /// </summary>  
        public string FollowContent { get; set; }
        /// <summary>
        /// 回访类型
        /// </summary>
        public int FollowType { get; set; }
        /// <summary>
        /// 服务质量
        /// </summary>
        public int AppraiseType { get; set; }
        /// <summary>
        /// 意见
        /// </summary>
        public string FeedBackContent { get; set; }
        /// <summary>
        /// 回访状态  
        /// </summary>
        public string FollowStatus { get; set; }
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName { get; set; }
        /// <summary>
        /// 医生
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime OperTime { get; set; }

        /// <summary>
        /// 回访时间段
        /// </summary>
        public string TimeQuantum { get; set; }

       
        /// <summary>
        /// 回访类型名称
        /// </summary>
        public string FollowTypeName { get; set; }

        /// <summary>
        /// 营养师回访内容
        /// </summary>
        public string DietitianContent { get; set; }
                /// <summary>  
        /// 运动师回访内容  
        /// </summary>  
        public string SportsDocContent{ get; set; }
                /// <summary>  
        /// 中医师回访内容  
        /// </summary>  
        public string TCMDocContent { get; set; }
                /// <summary>  
        /// 心理医生回访内容  
        /// </summary>  
        public string PsyDocContent { get; set; }
                /// <summary>  
        /// 营养师回访结果  
        /// </summary>  
        public string DietitianResult{ get; set; }

                /// <summary>  
        /// 运动师回访结果  
        /// </summary>  
        public string SportsDocResult{ get; set; }
                /// <summary>  
        /// 中医师回访结果  
        /// </summary>  
        public string TCMDocResult{ get; set; }
                /// <summary>  
        /// 心理医生回访结果  
        /// </summary>  
        public string PsyDocResult{ get; set; }
    }
}
