using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom 
{
    /// <summary>
    /// 用户明细信息
    /// </summary>
    [Serializable]
    public class RtUserDetailInfo
    {
        /// <summary>
        /// 是否是主讲人
        /// </summary>
        public bool IsTeacher { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        public string DepartID { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// 用户ID（通讯的ID），唯一码
        /// </summary>
        public string MemberID { get; set; }

        /// <summary>
        /// 用户公共ID
        /// </summary>
        public string PID { get; set; }

        /// <summary>
        /// 用户机构内部ID
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 职称
        /// </summary>
        public string JobTitile { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Introduce { get; set; }

        /// <summary>
        /// 医生照片
        /// </summary>
        public byte[] Photo { get; set; }
    }
}
