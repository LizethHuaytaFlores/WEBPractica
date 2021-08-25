using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBPractica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Lizeth Huayta Flores";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "hfl2022986@est.univalle.edu";

            return View();
        }
    }
}