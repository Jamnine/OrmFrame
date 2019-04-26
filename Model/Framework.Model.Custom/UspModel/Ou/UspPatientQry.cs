using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 病人查询
    /// </summary>
    [Serializable] 
    public class UspPatientQry : BaseModel  
    {
        /// <summary>
        /// 
        /// </summary>
        public bool IsCheck { get; set; }

        /// <summary>
        /// 既往史
        /// </summary>
        public string PersonHistory { get; set; }
        /// <summary>
        /// 过敏史
        /// </summary>
        public string Sensitive { get; set; }
        /// <summary>
        /// 卡号.
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 挂号ID
        /// </summary>
        public string MzRegId { get; set; }

        /// <summary>
        /// 病人姓名.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 病人性别：M，F，O.
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string AgeString { get; set; }
    
        /// <summary>
        /// 病人类型
        /// </summary>
        public string PatTypeName { get; set; }
        /// <summary>
        /// 上次就诊时间
        /// </summary>
        public DateTime LastOuHosInfoTime { get; set; }

        /// <summary>
        /// 就诊目的中文（格式如：洁牙，拔牙，种植）
        /// </summary>
        public string CnBookingPurpose
        {
            get;
            set;
        }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 就诊医生
        /// </summary>
        public string DoctorName { get; set; }

        /// <summary>
        /// 操作者
        /// </summary>
        public string OperName { get; set; }

        /// <summary>
        /// 就诊诊所
        /// </summary>
        public string HospitalName { get; set; }

        /// <summary>
        /// 是否缴费
        /// </summary>
        public bool IsChange { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Comments
        {
            get;
            set;
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get;
            set;
        }
        /// <summary>
        /// 就诊状态（初诊、复诊）
        /// </summary>
        public string VisitStatus { get; set; }
        /// <summary>
        /// 预约状态
        /// </summary>
        public string RegStatus { get; set; }
        /// <summary>
        /// 健康顾问名称
        /// </summary>
        public string AdviserName { get; set; }
        /// <summary>
        /// 是否为预约号（0不是，1是）
        /// </summary>
        public int IsPreReg { get; set; }

        /// <summary>
        /// 病人来源
        /// </summary>
        public string PatientSource { get; set; }
        /// <summary>
        /// 是否为特殊病人(0不是，1是)
        /// </summary>
        public bool IsHideIllness { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCardNo { get; set; }

    }
}
