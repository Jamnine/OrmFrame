using Orm.Framework.Common;
using Orm.Model.Parameter;
using Orm.Services.TestSercive;
using System;
using System.Web.Http;

namespace OrmFrameServiceWeb.Controllers
{
    public class TestDemoController : BaseApiController
    {
        TestDemoServices testDemoServices = new TestDemoServices();
        [HttpGet, HttpPost]
        public ReturnValue UpdateItemByCode()
        {
            try
            {
                string model = QueryStringHelper.GetString("model", "");
                if (string.IsNullOrEmpty(model))
                {
                    returnValue.ErrorCode = 1;
                    returnValue.ErrorMsg = "model不能为空";
                    return returnValue;
                }
                string feemz = QueryStringHelper.GetString("feemz", "");
                returnValue.ShowMsg = testDemoServices.GetLocHouseRoomName("feemz").GUID;
                return returnValue;
            }
            catch (Exception ex)
            {
                returnValue.ErrorCode = 1;
                returnValue.ErrorMsg = ex.Message;
                return returnValue;
            }
        }
    }
}
