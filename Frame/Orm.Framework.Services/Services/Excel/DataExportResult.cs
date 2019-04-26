using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    /// <summary>
    /// Excel导出结果
    /// </summary>
    public class ExcelExportResult
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ExcelExportResult()
        {
            ExportStatus = ExportStatus.Success;
        }

        /// <summary>
        /// 导出文件的文件名(含路径)
        /// </summary>
        public string ExportFileName { get; set; }

        /// <summary>
        /// 导出结果状态
        /// </summary>
        public ExportStatus ExportStatus { get; set; }

        /// <summary>
        /// 错误异常信息（成功时为NULL）
        /// </summary>
        public Exception Exception { get; set; }
    }

    /// <summary>
    /// 导出结果状态
    /// </summary>
    public enum ExportStatus
    {
        /// <summary>
        /// 导出成功
        /// </summary>
        Success = 0,

        /// <summary>
        /// 导出失败
        /// </summary>
        Fail = 1
    }
}
