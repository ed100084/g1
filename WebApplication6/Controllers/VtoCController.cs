using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class VtoCController : Controller
    {
        // GET: VtoC
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DemoQueryString()
        {
            ViewBag.id = int.Parse(Request.QueryString["id"]);
            return View();
        }

        public ActionResult DemoRouteData(int id)
        {
            ViewBag.id = id;
            return View();
        }

        public ActionResult BasicModelBinding(string name)
        {
            ViewBag.Name = name;
            return View();
        }

        public ActionResult BasicModelBingingByModel(string name)
        {
            ViewBag.Model = name;
            return View(); 
        }
    }
}