using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 辐射环评表
    /// </summary>
    public class EqRadEnvironment : BaseModel
    {
        /// <summary>
        /// 辐射环评表
        /// </summary>
        public EqRadEnvironment() { }
        public virtual string EquipmentId { get; set; }

        public virtual string Performance { get; set; }

        public virtual string Protect { get; set; }

        public virtual string EqRadEnvirCon { get; set; }

        public virtual string BenefitLocId { get; set; }

        public virtual DateTime RecordDate { get; set; }

        public virtual string Memo { get; set; }


    }
}
