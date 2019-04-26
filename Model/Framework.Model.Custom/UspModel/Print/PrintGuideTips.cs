using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 打印指导提示
    /// </summary>
    [Serializable]
    public class PrintGuideTips
    {
        public PrintGuideTips() { }

        /// <summary>
        /// 科室名称
        /// </summary>
        public string TJLocationName { get; set; }

        /// <summary>
        /// 体检项目名称
        /// </summary>
        public string TJItemName { get; set; }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int OrderBy { get; set; }

        /// <summary>
        /// 指引提示
        /// </summary>
        public string GuideTips { get; set; }
        /// <summary>
        /// 是否已收费
        /// </summary>
        public string isCharge { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string patName { get; set; }

         /// <summary>
        /// 操作人id
        /// </summary>
        public int operateid { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime operateTime { get; set; }


        /// <summary>
        /// 操作医生
        /// </summary>
        public string docName { get; set; }

        /// <summary>
        /// 就诊时间
        /// </summary>
        public DateTime hosTime { get; set; }



    }
}
