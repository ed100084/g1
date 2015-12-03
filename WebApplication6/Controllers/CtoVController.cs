using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class CtoVController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();

        // GET: CtoV
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DemoViewData()
        {
            ViewData["Name"] = "Bruce";
            return View();
        }

        public ActionResult DemoViewBag()
        {
            ViewBag.Name = "Bruce2";
            return View();
        }

        public ActionResult DemoVDModel()
        {
            //ViewData["products"] = db.Products.ToList();
            ViewBag.products = db.Products.ToList();
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}