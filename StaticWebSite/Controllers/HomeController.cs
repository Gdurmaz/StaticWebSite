using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaticWebSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [Route("Hakkimizda")]
        public ActionResult About()
        {
            return View();
        }
        [Route("Magaza")]
        public ActionResult Store()
        {
            return View();
        }
        [Route("Urunler")]
        public ActionResult Product()
        {
            return View();
        }
    }
}