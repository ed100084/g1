using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
using System.Data.Entity;

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

        public ActionResult DemoStronglytyped()
        {
            return View(db.Products.ToList());
        }

        public ActionResult DemoInput()
        {
            return View();
        }

        public ActionResult CheckInput(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                TempData["Error"] = "no blank!";
                return RedirectToAction("DemoInput");
            }
            ViewBag.Name = name;
            return View();        
        }


        public ActionResult DemoInclude()
        {
            var products = db.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier);
            return View(products.ToList());      
                            
        }

        public ActionResult DemoSelectList()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            return View();
        }

        public ActionResult DemoMultiModelObject()
        {
            ViewBag.Author = "B12";
            ViewBag.Book = "MVC 5 book";
            ViewBag.Product = (from p in db.Products select p).Take(10).ToList();
            ViewBag.Category = (from c in db.Categories select c).Take(10).ToList();
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