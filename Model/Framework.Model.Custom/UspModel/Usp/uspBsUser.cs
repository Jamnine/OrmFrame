using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    [Serializable]
    public class uspBsUser
    {
        /// <summary>
        /// 医生ID
        /// </summary>
        public string GuId { get; set; }

        /// <summary>
        /// 用户编码.
        /// </summary>
        public string Code { get ; set; }

        /// <summary>
        /// 用户名称.
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
        /// 职衔ID
        /// </summary>
        public string TitleID { get; set; }

        /// <summary>
        /// 职衔
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// 个人简介
        /// </summary>
        public string Introduce { get; set; }

        /// <summary>
        /// 擅长
        /// </summary>
        public string Specialty { get; set; }

        /// <summary>
        /// 门诊类型ID
        /// </summary>
        public string RegTypeID { get; set; }

        /// <summary>
        /// 所属总店ID
        /// </summary>
        public string LocationID { get; set; }

        /// <summary>
        /// 科室ID
        /// </summary>
        public string DepartmentID { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public byte[] Picture { get; set; }

        /// <summary>
        /// 是否可用.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
