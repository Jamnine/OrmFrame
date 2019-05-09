using Orm.Framework.Services;
using Orm.Model;
using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OrmFrameServiceWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //每天早晨执行第一次请求
            if (System.DateTime.Now.Hour > 0 && System.DateTime.Now.Hour < 24)
            {
                InitServer();
            }
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        private void InitServer()
        {
            try
            {
                DBClientBase db = new DBClientBase();
                var user = db.GetAllList<BsUser>();
                AppLogger.Log("首次请求完成：" + System.DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
