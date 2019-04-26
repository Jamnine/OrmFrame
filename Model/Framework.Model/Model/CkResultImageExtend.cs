using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 体检结果影像 - 实体扩展类
    /// </summary>
    public partial class CkResultImage : BaseModel
    {
        /// <summary>
        /// 图片名称
        /// </summary>
        public string ImgName { get; set; }
    }
}
