using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{

    /// <summary>
    /// Excel导出参数配置
    /// </summary>
    public class ExcelExporterParameter
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ExcelExporterParameter()
        {
            string id = System.Guid.NewGuid().ToString().Replace("_", "");
            DocumentFileName = @"ExportFiles\" + DateTime.Now.ToString("yyyyMMdd") + @"\" + id + ".xlsx";
            DocumentFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DocumentFileName);

            //DocumentAuthor = "KadIT";
            //DocumentSubject = "";
            DataTitle = "";
            DataSubTitle = "";
            DisplayGridlines = false;
            //AutoCompression = false;

            GroupHeaders = new List<GroupHeaderConfig>();
            CommonHeaders = new List<CommonHeaderConfig>();
        }


        /// <summary>
        /// 导出文件名(绝对路径)
        /// </summary>
        public string DocumentFileName { get; set; }


        /// <summary>
        /// 导出文件是否显示网格线
        /// </summary>
        public bool DisplayGridlines { get; set; }

        /// <summary>
        /// 导出的文件是否压缩
        /// </summary>
        //public bool AutoCompression { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string DataTitle { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        public string DataSubTitle { get; set; }

        /// <summary>
        /// 分组表头列,内容相同自动合并(DisplayName)
        /// </summary>
        public List<GroupHeaderConfig> GroupHeaders { get; set; }

        /// <summary>
        /// 数据表头列，支持多表头(Id,DisplayName,OrderNo,isLayer,ParentId,Level) 
        /// Id,显示名称，层内排序号，是否是分层（1是0否），父Id，层数（最上层为1）
        /// </summary>
        public List<CommonHeaderConfig> CommonHeaders { get; set; }
      


        /// <summary>
        /// 需要导出的数据, 如果有分组表头，分组列需要放在DataBody最靠前的列
        /// </summary>
        public DataTable DataBody { get; set; }
    }

    /// <summary>
    /// 分组列配置
    /// </summary>
    public class GroupHeaderConfig
    {
        /// <summary>
        /// 显示名称
        /// </summary>
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// 数据列名
        /// </summary>
        public string ColumnName
        {
            get;
            set;
        }

        /// <summary>
        /// 数据列宽度,X个字符宽
        /// </summary>
        public int ColumnWidth
        {
            get;
            set;
        }

        /// <summary>
        /// 表头单元格的标注信息
        /// </summary>
        public string ColumnComment
        {
            get;
            set;
        }

        /// <summary>
        /// 水平对齐方式
        /// </summary>
        public HorizontalAlignment HorizontalAlignment
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 普通列配置
    /// </summary>
    public class CommonHeaderConfig
    {

        public CommonHeaderConfig()
        {
            Children = new List<CommonHeaderConfig>();
            ColumnWidth = 10;
        }

        /// <summary>
        /// 显示名称
        /// </summary>
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// 数据列名称
        /// </summary>
        public string ColumnName
        {
            get;
            set;
        }

        /// <summary>
        /// 数据列宽度,X个字符宽
        /// </summary>
        public int ColumnWidth
        {
            get;
            set;
        }

        /// <summary>
        /// 表头单元格的标注信息
        /// </summary>
        public string ColumnComment
        {
            get;
            set;
        }

        /// <summary>
        /// 数据类型，默认为字符串，如果为图片则设置为IMAGE
        /// </summary>
        public ExcelDataType DataType
        {
            get;
            set;
        }

        /// <summary>
        /// 数据格式
        /// </summary>
        public string DataFormat
        {
            get;
            set;
        }

        /// <summary>
        /// 水平对齐方式
        /// </summary>
        public HorizontalAlignment HorizontalAlignment
        {
            get;
            set;
        }

        public List<CommonHeaderConfig> Children
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 数据导出类型
    /// </summary>
    public enum ExcelDataType
    {
        /// <summary>
        /// 文本
        /// </summary>
        Text = 0,
        /// <summary>
        /// 数字
        /// </summary>
        Numeric = 1,
        /// <summary>
        /// 时间
        /// </summary>
        Datetime = 2,
        /// <summary>
        /// 枚举
        /// </summary>
        Boolean = 3,
        /// <summary>
        /// 图片
        /// </summary>
        Image = 4
    }

    /// <summary>
    /// 水平对齐方式
    /// </summary>
    public enum HorizontalAlignment
    {
        /// <summary>
        /// 普通
        /// </summary>
        General = 0,
        /// <summary>
        /// 左对齐
        /// </summary>
        Left = 1,
        /// <summary>
        /// 居中
        /// </summary>
        Center = 2,
        /// <summary>
        /// 居右
        /// </summary>
        Right = 3,
        /// <summary>
        /// 填充
        /// </summary>
        Fill = 4

    }
}
