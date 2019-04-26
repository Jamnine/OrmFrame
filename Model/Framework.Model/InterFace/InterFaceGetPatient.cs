using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.InterFace
{
    [Serializable]
    public class InterFaceGetPatient
    {
        /// <summary>
        /// 病人GUID
        /// </summary>
        public string GUID { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// 血型
        /// </summary>
        public string BloodGroup { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 邮件
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 病人类别
        /// </summary>
        public string PatTypeId { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string IdCardNo { get; set; }
        /// <summary>
        /// 医保号
        /// </summary>
        public string MedicareNo { get; set; }
        /// <summary>
        /// 医院ID
        /// </summary>
        public int HospitalId { get; set; }
        /// <summary>
        /// 病人类型
        /// </summary>
        public string PatType { get; set; }
        /// <summary>
        /// 医院名称
        /// </summary>
        public string HosPitalName { get; set; }
    }
}