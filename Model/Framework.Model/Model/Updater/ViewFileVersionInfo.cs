using System;

namespace Orm.Model
{
    /// <summary>
    /// 查看文件的版本信息
    /// </summary>
    [Serializable]
   public  class ViewFileVersionInfo
    {
        /// <summary>
        /// 文件名
        /// </summary>
         public string FileName { get; set; }

        /// <summary>
        /// 文件版本号
        /// </summary>
         public int FileVersionNum { get; set; }
    }
}
