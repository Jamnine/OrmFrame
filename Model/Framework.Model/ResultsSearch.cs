using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class ResultsSearch : Results
    {
        /// <summary>
        /// 初始化参数
        /// </summary>
        public ResultsSearch()
        {
            Success = true;
            Code = "00";
            Message = "成功";
            PageRow = 10;
        }

        /// <summary>
        /// 分页参数
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="currentPage">当前页</param>
        /// <param name="pageRow">每页显示多少行</param>
        /// <param name="countPage">总页数</param>
        /// <param name="countRow">总行数</param>
        public ResultsSearch(object data, int currentPage, int pageRow, int countRow)
        {
            Data = data;
            Success = true;
            Code = "00";
            Message = "成功";
            CurrentPage = currentPage;
            PageRow = pageRow == 0 ? 10 : pageRow;
            CountRow = countRow;
        }

        /// <summary>
        /// 失败返回结果
        /// </summary>
        /// <param name="code">错误代码</param>
        /// <param name="message">错误消息</param>
        public ResultsSearch(string code, string message)
        {
            Code = code;
            Message = message;
            Success = false;
            PageRow = 10;
        }


        /// <summary>
        /// 当前页
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// 每页显示多少条
        /// </summary>
        public int PageRow { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        public int CountRow { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int CountPage
        {
            get { return (int)Math.Ceiling(this.CountRow / Convert.ToDouble(this.PageRow)); }
        }
    }
}
