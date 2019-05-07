using Orm.Client.Common;
using Orm.Framework.Common;
using Orm.Model;
using Orm.Model.Parameter;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace OrmFrameServiceWeb.Controllers
{
    public class BaseApiController : ApiController
    {
        private Results _result;
        /// <summary>
        /// 返回参数(增删改通用)
        /// </summary>
        protected Results result
        {
            get
            {
                if (_result == null) { _result = new Orm.Model.Results(); }
                return _result;
            }
            set
            {
                _result = value;
            }
        }

        private ReturnValue _returnValue;
        /// <summary>
        /// 返回结果
        /// </summary>
        protected ReturnValue returnValue
        {
            get
            {
                if (_returnValue == null) { _returnValue = new ReturnValue(); }
                return _returnValue;
            }
            set
            {
                _returnValue = value;
            }
        }

        private ResultsSearch _resultSearch;
        /// <summary>
        /// 返回参数（查询专用）
        /// </summary>
        protected ResultsSearch resultSearch
        {
            get
            {
                if (_resultSearch == null) { _resultSearch = new ResultsSearch(); }
                return _resultSearch;
            }
            set
            {
                _resultSearch = value;
            }
        }

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            //获取token
            string uname = QueryStringHelper.GetString("tokencode");
            //判断对比
            if (string.IsNullOrEmpty(uname) || ConfigHelper.GetSettings("TokenCode") != uname)
            {
                //返回没有权限消息
                ReturnValue result = new ReturnValue();
                result.ErrorMsg = "tokencode令牌无效";
                result.ErrorCode = 100;

                HttpContext.Current.Response.Write(JsonHelper.ObjectToJSON(result));
                //var response= controllerContext.Request.CreateResponse(HttpStatusCode.OK);
                //response.Content = new StringContent(JsonHelper.ObjectToJSON(result), Encoding.UTF8, "application/json");
                HttpContext.Current.Response.End();
            }
            else
            {
                base.Initialize(controllerContext);
            }

        }

        public override Task<HttpResponseMessage> ExecuteAsync(HttpControllerContext controllerContext, CancellationToken cancellationToken)
        {

            return base.ExecuteAsync(controllerContext, cancellationToken);
        }
    }
}
