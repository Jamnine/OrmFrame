using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    [Serializable]
    public class uspDoctorRule
    {
        /// <summary>
        /// 职称
        /// </summary>
        public virtual String LevName { get; set; }
        /// <summary>
        /// 员工名称
        /// </summary>
        public virtual String UserName { get; set; }

        /// <summary>
        /// 项目类别
        /// </summary>
        public virtual String Feettype { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public virtual decimal AMOUNT { get; set; }
        /// <summary>
        /// 治疗费完成任务量
        /// </summary>
        public virtual decimal Btt { get; set; }

        /// <summary>
        /// 治疗费目标任务量
        /// </summary>
        public virtual decimal Stt { get; set; }

        /// <summary>
        /// 治疗费提成任务量
        /// </summary>
        public virtual decimal ROYALTY { get; set; }

        /// <summary>
        /// 治疗费提成任务量
        /// </summary>
        public virtual decimal RAmount { get; set; }
     

    }
}
