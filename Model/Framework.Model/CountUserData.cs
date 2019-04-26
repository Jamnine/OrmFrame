using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 服务端访问统计表
    /// </summary>
    public class CountUserData:BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        public CountUserData() { }

        /// <summary>
		/// 诊所名称
		/// </summary>
		public string LocationName
        {
            get;
            set;
        }

        /// <summary>
        /// 客户电脑ip
        /// </summary>
        public string ClientComputerIP
        {
            get;
            set;
        }

        /// <summary>
        /// 操作人
        /// </summary>
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get;
            set;
        }

        /// <summary>
        /// 接口域
        /// </summary>
        public string ApiInterfaceName
        {
            get;
            set;
        }

        /// <summary>
        /// 服务方法
        /// </summary>
        public string MethodName
        {
            get;
            set;
        }

        /// <summary>
        /// 请求响应时间
        /// </summary>
        public long CounterTime
        {
            get;
            set;
        }


        /// <summary>
        /// 请求数据大小
        /// </summary>
        public string ResponseData
        {
            get;
            set;
        }

        /// <summary>
        /// 请求参数内容
        /// </summary>
        public string ParameterContents
        {
            get;
            set;
        }
    }
}
