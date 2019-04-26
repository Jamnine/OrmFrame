using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 文件系统模板
    /// </summary>
    [Serializable]
    public class FileSystemTempate
    {
        public FileSystemTempate() { }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 最后写入时间
        /// </summary>
        public DateTime LastWriteTime { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        public long Length { get; set; }

        private bool _isFolder = false;
        /// <summary>
        /// 文件状态 0未下载 1已下载 2正在下载
        /// </summary>
        public bool IsFolder
        {
            get { return _isFolder; }
            set { _isFolder=value; }
        }

        /// <summary>
        /// 文件地址
        /// </summary>
        public string FilePath { get; set; }
    }
}
