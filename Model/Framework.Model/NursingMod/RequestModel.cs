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
    public class RequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string[] GroupName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string[] GroupOrderBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string[] GroupCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string[] OrderBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string[] TitleGroupCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string[] TitleType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string[] TitleName { get; set; }

        //---------------------
        /// <summary>
        /// 
        /// </summary>
        public List<string[]> GroupScoreRule = new List<string[]>();
        /// <summary>
        /// 
        /// </summary>
        public List<string[]> GroupScore = new List<string[]>();
        /// <summary>
        /// 
        /// </summary>
        public List<string> RestsGroupValid = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public List<string> IsRestsSelectScore = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public List<string> titleScore = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public List<string> Required = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public List<string[]> ItemName = new List<string[]>();
        /// <summary>
        /// 
        /// </summary>
        public List<string[]> ItemScore = new List<string[]>();
        /// <summary>
        /// 
        /// </summary>
        public List<List<string>> AddTexts = new List<List<string>>();

        #region His
        /// <summary>
        /// 请求url
        /// </summary>
        public String ApiUrl { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary> 
        public String IServiceName { get; set; }

        /// <summary>
        /// 接口名称
        /// </summary>
        public String MethodName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<object> ParameterList { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public String[] Types { get; set; }
        #endregion

    }
}
