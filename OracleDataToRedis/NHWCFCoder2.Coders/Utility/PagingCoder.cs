using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.Utility
{
    public class PagingCoder
    {
        public static void Write()
        {
            string path = Path.Combine(BaseParams.SolutionPath, BaseParams.UtilityPath);
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建Paging类
            string filepath = Path.Combine(path, "Paging.cs");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments("系统分页类", sw);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.UtilityNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    [Serializable]");
            sw.WriteLine("    public class Paging");
            sw.WriteLine("    {");
            sw.WriteLine("        private long _pageSize = 20;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 页面大小");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public long PageSize");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._pageSize; }");
            sw.WriteLine("            set { this._pageSize = value; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private bool _isPaging = true;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 是否需要分页");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public bool IsPaging");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._isPaging; }");
            sw.WriteLine("            set");
            sw.WriteLine("            {");
            sw.WriteLine("                if (value == false)");
            sw.WriteLine("                    this.PageSize = 0;");
            sw.WriteLine("                else if (this.PageSize == 0)");
            sw.WriteLine("                    throw new ApplicationException(\"请先设置分页大小!\");");
            sw.WriteLine("");
            sw.WriteLine("                this._isPaging = value;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        ///  是否需要获取查询结果总量");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public bool IsCount");
            sw.WriteLine("        {");
            sw.WriteLine("            get");
            sw.WriteLine("            {");
            sw.WriteLine("                return (this.PageSize > 0 && (this.CurrentPage == this.TotalPage || this.CurrentPage == 1));");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private long _currentPage = 1;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 当前页面");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public long CurrentPage");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._currentPage; }");
            sw.WriteLine("            set");
            sw.WriteLine("            {");
            sw.WriteLine("                value = (value > 0) ? value : 1;");
            sw.WriteLine("                value = (value <= this.TotalPage) ? value : this.TotalPage;");
            sw.WriteLine("                this._currentPage = value;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private long _totalPage = 1;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 总页数");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public long TotalPage");
            sw.WriteLine("        {");
            sw.WriteLine("            get");
            sw.WriteLine("            {");
            sw.WriteLine("                return this._totalPage;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private long _rowCount = 0;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 查询结果总量");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public long RowCount");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._rowCount; }");
            sw.WriteLine("            set");
            sw.WriteLine("            {");
            sw.WriteLine("                if (value < 0) value = 0;");
            sw.WriteLine("                this._rowCount = value;");
            sw.WriteLine("                double remainder = this.RowCount % this.PageSize;");
            sw.WriteLine("                if (remainder == 0)");
            sw.WriteLine("                {");
            sw.WriteLine("                    this._totalPage = this.RowCount / this.PageSize;");
            sw.WriteLine("                }");
            sw.WriteLine("                else");
            sw.WriteLine("                {");
            sw.WriteLine("                    this._totalPage = (this.RowCount - (int)remainder) / this.PageSize + 1;");
            sw.WriteLine("                }");
            sw.WriteLine("                this.CurrentPage = (this.CurrentPage <= this.TotalPage) ? this.CurrentPage : this.TotalPage;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 查询开始行");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public long StartRowIndex");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return ((this.CurrentPage - 1) * this.PageSize); }");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();
            #endregion
        }
    }
}
