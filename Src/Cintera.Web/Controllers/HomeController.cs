using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cintera.DAL;

namespace Cintera.Web.Controllers
{
    public class HomeController : Controller
    {
        private CenteraContext _centera;

        public HomeController()
        {
            _centera = new CenteraContext();
        }


        public ActionResult Index()
        {
            var model = _centera.View1.ToList();
            return View(model);
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