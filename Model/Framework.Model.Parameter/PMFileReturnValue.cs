using System;
using System.Collections.Generic;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 文件返回值
    /// </summary>
    [Serializable]
    public class PMFileReturnValue
    {
        public PMFileReturnValue()
        {
            FileList = new List<FileInfoEx>();
            ErrorMessage = new List<KeyValuePair<int, string>>();
        }
        /// <summary>
        /// 文件列表
        /// </summary>
        public List<FileInfoEx> FileList { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public List<KeyValuePair<int, string>> ErrorMessage { get; set; }
    }
    /// <summary>
    /// 文件信息
    /// </summary>
    [Serializable]
    public class FileInfoEx
    {
        public FileInfoEx()
        {

        }
        /// <summary>
        /// 是否可删除
        /// </summary>
        public bool CanDelete { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 目录名称
        /// </summary>
        public string DirectoryName { get; set; }
        /// <summary>
        /// 是否下载安装
        /// </summary>
        public bool IsDownLoaded { get; set; }
        /// <summary>
        /// 最后写入时间
        /// </summary>
        public DateTime LastWriteTime { get; set; }
        /// <summary>
        /// 长度
        /// </summary>
        public long Length { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
    }
}
