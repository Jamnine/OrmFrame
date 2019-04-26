using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.HealthRecordsMod
{
    /// <summary>
    /// 
    /// </summary>
    public class UspGetPatientMenu
    {
        /// <summary>
        /// 
        /// </summary>
        public string ID
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string ParentID
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get; set;
        }


        /// <summary>
        /// 排序
        /// </summary>
        public int OrderBy
        {
            get; set;
        }


        /// <summary>
        /// 
        /// </summary>
        public int Type
        {
            get; set;
        }
    }
}
