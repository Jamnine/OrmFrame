using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 病人基本信息组合类
    /// </summary>
    [Serializable]
   
    public class UspRecycleItem : BaseModel
    {
        public UspRecycleItem()  
        {  
        }

        /// <summary>
        /// 1.病人基本信息  2.病人就诊信息  3.病人收费信息
        /// </summary>
        public string TableType
        {
            get;
            set;
        }
        /// <summary>
        /// 卡号
        /// </summary>

        public string CardNo
        {
            get;
            set;
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 年龄
        /// </summary>
        public string Age
        {
            get;
            set;
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get;
            set;
        }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string Phone
        {
            get;
            set;
        }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID
        {
            get;
            set;
        }

        /// <summary>
        /// 日期时间
        /// </summary>
        public DateTime DateTime
        {
            get;
            set;
        }
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime DelectTime
        {
            get;
            set;
        }
        /// <summary>
        ///删除操作员id
        /// </summary>
        public string DelectOperId
        {
            get;
            set;
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Comments
        {
            get;
            set;
        }
    }
}
