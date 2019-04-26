using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 预约信息
    /// </summary>
    [Serializable]
  
    public class UspPreRegInfoQry : BaseModel  
    {
        /// <summary>
        /// ID
        /// </summary>
        public string OuHosInfoID { get; set; }
        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID { get; set; }
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName { get; set; }
        /// <summary>
        /// 病人性别
        /// </summary>
        public string PatSex { get; set; }

        /// <summary>
        /// 病人性别
        /// </summary>
        public string AgeString { get; set; }

        /// <summary>  
        /// 病人卡号  
        /// </summary>  
        public string PatCardNo { get; set; }
        /// <summary>
        /// 预约时间
        /// </summary>
        public DateTime PreRegTime { get; set; }
        /// <summary>
        /// 时间段
        /// </summary>
        public string PreRegTimeSpan { get; set; }

        /// <summary>
        /// 时间段开始时间
        /// </summary>
        public string TimeBegin { get; set; }

        /// <summary>
        /// 电话  
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 就诊目的(中文）
        /// </summary>
        public string CnBookingPurpose { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// 主诉
        /// </summary>
        public string MainInform { get; set; }

        /// <summary>
        /// 预约医生
        /// </summary>
        public string DoctorName { get; set; }

        /// <summary>
        /// 门诊类别
        /// </summary>
        public string RegTypeName { get; set; }

        /// <summary>
        /// 预约诊所
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// 是否已挂号
        /// </summary>
        public bool IsReg { get; set; }

        /// <summary>
        /// 是否复诊
        /// </summary>
        public bool IsReturnVisit { get; set; }

        /// <summary>
        /// 复诊内容
        /// </summary>
        public string VisitContent { get; set; }

        /// <summary>
        /// 预约操作时间
        /// </summary>         
        public DateTime OperTime { get; set; }

        /// <summary>
        /// 是否网站预约
        /// </summary>
        public bool IsWebBooked { get; set; }

        /// <summary>
        /// 是否隐藏
        /// </summary>
        public bool IsHide { get; set; }

        /// <summary>
        /// 隐藏操作的时间
        /// </summary>
        public DateTime HideOperTime { get; set; }

        /// <summary>
        /// 是否关注了微信
        /// </summary>
        public bool IsWebBinding { get; set; }
        private bool _isMobile = false;
        public bool u_IsMobile
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Mobile))
                {
                    _isMobile = true;
                }
                else
                {
                    _isMobile = false;
                }
                return _isMobile;
            }
            set { _isMobile = value; }
        }
        private bool _isMobileNull = false;
        public bool u_IsMobileNull
        {
            get
            {
                if (Mobile == null)
                {
                    _isMobileNull = true;
                }
                else
                {
                    _isMobileNull = false;
                }
                return _isMobileNull;
            }
            set { _isMobileNull = value; }
        }
    }
}
