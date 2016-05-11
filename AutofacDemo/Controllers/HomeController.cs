using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.IService;
using Autofac.Lib;

namespace AutofacDemo.Controllers
{
    public class HomeController : Controller
    {
        private ICacheProvider _CacheProvider = Ioc.GetService<ICacheProvider>();

        private ITestService _TestService = Ioc.GetService<ITestService>();

        public ActionResult Index()
        {
            ViewData["cache"] = _CacheProvider.ShowName();

            ViewData["testdata"] = _TestService.GetId();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}