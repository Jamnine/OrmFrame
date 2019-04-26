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
    public class CMS_Column : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int LsImg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ImgW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ImgH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsHied { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int OrderBy { get; set; }
    }
}
