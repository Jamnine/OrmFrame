using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    ///报名人信息
    /// </summary>
    [Serializable]
    public class RtApplyPerson : BaseModel 
    {

        /// <summary>  
        /// 课程ID 
        /// </summary>  
        public string CourseID
        {
            get;
            set;
        }

        /// <summary>  
        /// 报名人ID  
        /// </summary>  
        public string PID
        {
            get;
            set;
        }

        /// <summary>  
        /// 报名人姓名 
        /// </summary>  
        public string Name
        {
            get;
            set;
        }

        /// <summary>  
        /// 主讲人ID  
        /// </summary>  
        public string Sex
        {
            get;
            set;
        }

        /// <summary>  
        /// 报名人手机号码
        /// </summary>  
        public string Phone
        {
            get;
            set;
        }

        /// <summary>  
        /// 报名人机构ID
        /// </summary>  
        public string DeptID
        {
            get;
            set;
        }

        /// <summary>  
        /// 报名人机构
        /// </summary>  
        public string DeptName
        {
            get;
            set;
        }

        /// <summary>  
        /// 主讲人照片
        /// </summary>  
        public byte[] Photo
        {
            get;
            set;
        }

        /// <summary>  
        /// 主讲人职称
        /// </summary>  
        public string JobTitle
        {
            get;
            set;
        }

        /// <summary>  
        /// 主讲人介绍
        /// </summary>  
        public string Introduce
        {
            get;
            set;
        }
    }
}
