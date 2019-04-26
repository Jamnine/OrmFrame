using System;

namespace Orm.Model
{
    [Serializable]
    public class ToothCaseContent : BaseModel
    {
        public string Name { get; set; }

        public string PyCode { get; set; }

        public string WbCode { get; set; }
        /// <summary>
        /// 疾病类别，外键ToothCaseHistoryType
        /// </summary>
        public string ParentId { get; set; }

        public int OrderBy { get; set; }
        /// <summary>
        /// 小类类别，外键
        /// </summary>
        public string TypeID { get; set; }
    }
}
