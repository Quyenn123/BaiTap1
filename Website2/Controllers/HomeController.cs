using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // Mỗi controller sẽ tạo ra nhiều action
        // Mỗi action sẽ tạo ra nhiều view
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HienThi()
        {
            return View();
        }
    }
}