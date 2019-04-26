using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 预约信息类
    /// </summary>
    [Serializable]
    public class uspBookedInfoQry
    {
        /// <summary>
        /// 用户Code
        /// </summary>
        public string UserCode { get; set; }

        /// <summary>
        /// 卡号（系统内部唯一号）
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 病人ID（系统内部唯ID）
        /// </summary>
        public string PatID { get; set; }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public string Age { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 预约ID (预约记录唯一ID)
        /// </summary>
        public string RegID { get; set; }

        /// <summary>
        /// 预约唯一流水号（可以用这个流水号来取消）
        /// </summary>
        public string RegNo { get; set; }

        /// <summary>
        /// 预约日期
        /// </summary>
        public string RegTime { get; set; }

        /// <summary>
        /// 医生Code
        /// </summary>
        public string DoctorUserCode { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName { get; set; }

        /// <summary>
        /// 诊所名称
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// 诊室名称
        /// </summary>
        public string DiagRoomName { get; set; }

        /// <summary>
        /// 预约时段名称
        /// </summary>
        public string TimeSpanSubName { get; set; }

        /// <summary>
        /// 就诊目的
        /// </summary>
        public string CnBookingPurpose { get; set; }

        /// <summary>
        /// 预约备注
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 预约操作时间
        /// </summary>
        public string OperTime { get; set; }

        /// <summary>
        /// 是否复诊
        /// </summary>
        public bool IsReturnVisit { get; set; }
        /// <summary>
        /// 是否复诊
        /// </summary>
        public int LsDiagType { get; set; }

        /// <summary>
        /// 复诊内容
        /// </summary>
        public string VisitContent { get; set; }

        /// <summary>
        /// 就诊状态：0 预约 1 取消预约 2 已诊
        /// </summary>
        public int VisitStatus { get; set; }
      
    }
}
