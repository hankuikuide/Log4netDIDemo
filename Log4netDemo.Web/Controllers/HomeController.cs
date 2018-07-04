using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Log4netDemo.Web.Models;
using log4net;
using Castle.Core.Logging;

namespace Log4netDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        private ILogger _logger;

        public HomeController(ILogger logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
           // throw new Exception("快点来!!!!!!!!!!!!!!!!!!");
            _logger.Info("index view");
            _logger.Debug("出错了！，快点来，看一下，审核，意见书！！");
            _logger.Error("Controller Error");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
