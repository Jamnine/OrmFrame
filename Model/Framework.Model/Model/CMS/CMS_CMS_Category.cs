using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class CMS_CMS_Category : BaseModel
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ColumnId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int OrderBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RoomName { get; set; }
    }
}
