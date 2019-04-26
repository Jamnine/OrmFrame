using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 病人预约信息
    /// </summary>
    [Serializable]
  
    public class UspPatBookDtlQry : BaseModel  
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string PatName { get; set; }
       
        /// <summary>
        /// 手机号
        /// </summary>
        public string PatMobile { get; set; }

        /// <summary>
        /// 预约时间
        /// </summary>
        public DateTime PreRegTime { get; set; }

        /// <summary>
        /// 预约时段
        /// </summary>
        public string PreRegTimeSpan { get; set; }
        /// <summary>
        /// 就诊目的 BOOKINGPURPOSE
        /// </summary>
        public string BookingPurpose { get; set; }
        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// 登记时间
        /// </summary>
        public DateTime OperTime { get; set; }
        /// <summary>
        /// 登记人
        /// </summary>
        public string OperName { get; set; }
        /// <summary>
        /// 状态   已就诊，未就诊，过期
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 就诊目的（中文）  
        /// </summary>
        public string CnBookingPurpose { get; set; }

        /// <summary>
        /// 预约挂号时间名称
        /// </summary>
        public string PreRegTimeName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

     
    }
}
