using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel.VIP
{
    [Serializable]
    public class UspVipBinding : BaseModel
    {
        public virtual string PatId { get; set; }

        public virtual string VipCardId { get; set; }

        public virtual Boolean? IsCardHolder { get; set; }

        public virtual Boolean IsActive { get; set; }

        public virtual string OperId { get; set; }

        public virtual DateTime OperTime { get; set; }

        public virtual string ModifiedOperId { get; set; }

        public virtual DateTime ModifiedOperTime { get; set; }

        public virtual Boolean IsAuthed { get; set; }

        public virtual String CardNo { get; set; }

        public virtual String PatientName { get; set; }

        public virtual String Sex { get; set; }

        public virtual String Age { get; set; }

        public virtual String VipCardNo { get; set; }

        public virtual string IntroducerOperId { get; set; }

        public virtual String IntroducerName { get; set; }

        public virtual DateTime InvalidDate { get; set; }

        public virtual DateTime CreateTime { get; set; }

        public virtual string VipLevelId { get; set; }
    }
}
