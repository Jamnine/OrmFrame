using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.InterFace
{
    public class IntelFaceAdEmr
    {
        /// <summary>
        /// 主诉
        /// </summary>
        public string MainInform { get; set; }
        /// <summary>
        /// 现病史
        /// </summary>
        public string SickHist { get; set; }
        /// <summary>
        /// 既往史
        /// </summary>
        public string OtherHistory { get; set; }
        /// <summary>
        /// 个人史
        /// </summary>
        public string Menarche { get; set; }
        /// <summary>
        /// 婚育史
        /// </summary>
        public string Abortion { get; set; }
        /// <summary>
        /// 家族史
        /// </summary>
        public string FamilyHistoryOther { get; set; }
        /// <summary>
        /// 过敏史
        /// </summary>
        public string AllErgy { get; set; }
        /// <summary>
        /// T
        /// </summary>
        public string ExamT { get; set; }
        /// <summary>
        /// P
        /// </summary>
        public string ExamP { get; set; }
        /// <summary>
        /// R
        /// </summary>
        public string ExamR { get; set; }
        /// <summary>
        /// Bp
        /// </summary>
        public string ExamBp { get; set; }
        /// <summary>
        /// Bp2
        /// </summary>
        public string ExamBp2 { get; set; }
        /// <summary>
        /// 体格
        /// </summary>
        public string PhysicalCheck { get; set; }
        /// <summary>
        /// 使用其他药物情况
        /// </summary>
        public string UsDrugCase { get; set; }
        /// <summary>
        /// 治疗建议
        /// </summary>
        public string Treatment { get; set; }
    }
}
