using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 课程信息
    /// </summary>
    [Serializable]
    public class RtCourseQry : BaseModel
    {  
        /// <summary>  
        /// 课程名称  
        /// </summary>  
        public string CourseName
        {
            get;
            set;
        }

        /// <summary>  
        /// 课程介绍  
        /// </summary>  
        public string CourseIntroduce
        {
            get;
            set;
        }

        /// <summary>  
        /// 主讲人ID  
        /// </summary>  
        public string TeacherID
        {
            get;
            set;
        }

        /// <summary>  
        /// 主讲人姓名 
        /// </summary>  
        public string TeacherName
        {
            get;
            set;
        }

        /// <summary>  
        /// 主讲人性别
        /// </summary>  
        public string TeacherSex
        {
            get;
            set;
        }

        /// <summary>  
        /// 主讲人手机号码
        /// </summary>  
        public string TeacherPhone
        {
            get;
            set;
        }

        /// <summary>  
        /// 主讲人机构ID
        /// </summary>  
        public string TeacherDeptID
        {
            get;
            set;
        }

        /// <summary>  
        /// 主讲人机构
        /// </summary>  
        public string TeacherDept
        {
            get;
            set;
        }

        /// <summary>  
        /// 主讲人照片
        /// </summary>  
        public byte[] TeacherPhoto
        {
            get;
            set;
        }

        /// <summary>  
        /// 主讲人职称
        /// </summary>  
        public string TeacherJobTitle
        {
            get;
            set;
        }

        /// <summary>  
        /// 主讲人介绍
        /// </summary>  
        public string TeacherIntroduce
        {
            get;
            set;
        }

        /// <summary>  
        ///   开始时间
        /// </summary>  
        public string BeginTime
        {
            get;
            set;
        }

        /// <summary>  
        ///   结束时间
        /// </summary>  
        public string EndTime
        {
            get;
            set;
        }

        /// <summary>  
        /// 课程创建时间
        /// </summary>  
        public DateTime CreateTime
        {
            get;
            set;
        }

        /// <summary>  
        /// 课程启动时间  
        /// </summary>  
        public DateTime CourseTime
        {
            get;
            set;
        }

        /// <summary>  
        /// 报名限制人数  
        /// </summary>  
        public int PersonNum
        {
            get;
            set;
        }

        /// <summary>  
        /// 已报名人数  
        /// </summary>  
        public int ApplyNum
        {
            get;
            set;
        }

        /// <summary>  
        /// 报名截止时间  
        /// </summary>  
        public DateTime ApplyEndTime
        {
            get;
            set;
        } 

        
        /// <summary>  
        ///   优先级
        /// </summary>  
        public int Priority
        {
            get;
            set;
        }

        /// <summary>  
        /// 课程类别ID  
        /// </summary>  
        public int CourseType
        {
            get;
            set;
        }

        /// <summary>  
        /// 课程价格  
        /// </summary>  
        public double CoursePrice
        {
            get;
            set;
        }

        /// <summary>  
        /// 课程状态 : 正在进行 还有X天
        /// </summary>  
        public string Status
        {
            get;
            set;
        }

        /// <summary>  
        /// 状态 : 0 未知 1 我要报名 2 我已报名 3我要进入 4报名结束 5课程结束 6开始开课 7我的课程
        /// </summary>  
        public string CourseStatus
        {
            get;
            set;
        }

        /// <summary>  
        /// 状态 : 0 未知 1 我要报名 2 我已报名 3我要进入 4报名结束 5课程结束 6开始开课 7我的课程
        /// </summary>  
        public string CourseStatusID
        {
            get;
            set;
        }  

        /// <summary>
        /// 是否可操作
        /// </summary>
        public bool CanOperate
        {
            get;
            set;
        }

        /// <summary>
        /// 是否可取消报名
        /// </summary>
        public bool CanCancel
        {
            get;
            set;
        }

        /// <summary>
        /// 是否是我的课程
        /// </summary>
        public bool IsMyCourse
        {
            get;
            set;
        }

        /// <summary>
        /// 是否免费
        /// </summary>
        public bool IsFree { get; set; }

        /// <summary>
        /// 课程是否结束
        /// </summary>
        public bool IsOver { get; set; }

        /// <summary>
        /// 课程组号
        /// </summary>
        public string GroupNo { get; set; }

        /// <summary>
        /// 我参与的课程
        /// </summary>
        public bool IsMyJoinCourse { get; set; }
    }
}
