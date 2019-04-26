using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom.UspModel
{
    [Serializable]
    public class UspGblEmailEvent : BaseModel
    { 

        public virtual string Title { get; set; }

        public virtual string Content { get; set; }

        public virtual string FileName { get; set; }

        public virtual DateTime? OperTime { get; set; }

        public virtual string OperId { get; set; }

        public virtual bool IsSign { get; set; }

        public virtual bool IsPriority { get; set; }

        public virtual bool IsFeedback { get; set; }

        public virtual string UserName { get; set; }
    }
}
