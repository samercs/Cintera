using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cintera.DAL;

namespace Cintera.Web.Controllers
{
    public class HomeController : ApplicationController
    {
        private readonly ICerteraContext _context;

        public HomeController(IDatabaseContext context) : base(context)
        {
            _context = context.GetContext();
        }


        public ActionResult Index()
        {
            var model = _context.View1.ToList();
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