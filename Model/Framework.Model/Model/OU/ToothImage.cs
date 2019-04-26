using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 牙齿图片
    /// </summary>
    [Serializable]
    public partial class ToothImage : BaseModel
    {
        /// <summary>
        /// 图片路径
        /// </summary>
        public string ImageTypePath { get; set; }
        /// <summary>
        /// 牙齿病例类型ID
        /// </summary>
        public string ToothCaseHistoryId { get; set; }
        /// <summary>
        /// 图片内容
        /// </summary>
        public byte[] BitmapImageSource { get; set; }
        /// <summary>
        /// 图片名称
        /// </summary>
        public string ImgName { get; set; }
        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatId { get; set; }

        /// <summary>
        /// 门诊Id
        /// </summary>
        public string MzRegId { get; set; }
        
        /// <summary>
        /// 文件类型 1:image 2:voice
        /// </summary>
        public int FileType { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime OperTime { get; set; }
        /// <summary>
        /// 图片名称
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// 体检编号
        /// </summary>
        public string TjCode { get; set; }

        /// <summary>
        /// 文件界面类型:回访管理return 档案输入PatInfo 电子病历ElectRecord
        /// </summary>
        public string FileWhere { get; set; }
        /// <summary>
        /// 回访ID
        /// </summary>
        public string FollowId { get; set; }

        /// <summary>
        /// 体检科室ID
        /// </summary>
        public string TjLocationId { get; set; }
        /// <summary>
        /// 图片数据
        /// </summary>
        public DateTime ImageDate { get; set; }

        /// <summary>
        /// 图片类型
        /// </summary>
        public int Type { get; set; }
    }
}
