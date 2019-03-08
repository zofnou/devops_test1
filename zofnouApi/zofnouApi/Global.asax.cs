using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using zofnouCommon;

namespace zofnouApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            LogHelper.Info("程序启动开始");
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            stopwatch.Stop();
            LogHelper.Info("程序启动结束，用时：" + stopwatch.ElapsedMilliseconds.ToString());
        }
        public void Application_End()
        {
            //LogHelper.Info("程序已停止");
        }
    }
}
