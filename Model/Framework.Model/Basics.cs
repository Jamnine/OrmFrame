using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 医联体护理平台基础Model
    /// </summary>
    [Serializable]
    public class Basics: Orm.Model.BaseModel
    {
        public int ID { get; set; }
        public string GUID { get; set; }
        /// <summary>
        /// 

        /// <summary>
        /// 
        /// </summary>
        public string ModioperID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int HisType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime InsertTime { get; set; }

        //
        // 摘要:
        //     是否修改
        public bool IsModify { get; set; }
        /// <summary>
        /// 默认构造方法
        /// </summary>
        public Basics()
        {

        }
        
    }
}
