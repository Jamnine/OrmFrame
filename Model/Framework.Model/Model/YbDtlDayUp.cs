using System;
namespace Orm.Model
{
	[Serializable]
	public partial class YbDtlDayUp : BaseModel
	{   
        public YbDtlDayUp() { }

        public virtual string DtlId { get; set; }


        public virtual string HospId { get; set; }


        public virtual string Memo { get; set; }


        public virtual string OperId { get; set; }


        public virtual DateTime? OperTime { get; set; }


        public virtual DateTime? UpdateTime { get; set; }

        public virtual string YbNo { get; set; }
    }  
}           


