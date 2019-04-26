using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 保存电子病历相关参数信息
    /// </summary>
    [Serializable]
    public class PMSaveRecordInfo
    {
          /// <summary>
        /// 随访信息
        /// </summary>
        public FollowPatient FollowPlan { get; set; }
        /// <summary>
        /// 是否回访计划
        /// </summary>
        public bool IsFollowPlan { get; set; }
        /// <summary>
        /// 预约、复诊信息
        /// </summary>
        public OuHosInfo OrderOuHosInfo { get; set; }
      
        /// <summary>
        /// 要删除的集合
        /// </summary>
        public List<KeyValuePair<string, string>> LstDelete { get; set; }
        public PMMedicalRecord RecordInfo { get; set; }
        public List<ToothImage> LstToothImage { get; set; }
        public bool IsTag { get; set; }
    }
}
