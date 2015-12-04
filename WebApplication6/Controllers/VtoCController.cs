using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

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

        public ActionResult DemoFormCollection(FormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Age = form["age"];
            return View();
        }

        public ActionResult PersonModelBinding(Person person)
        {
            return View(person);
        }

        public ActionResult MultiPersonModelBinding(Person man, Person woman)
        {
            ViewBag.ManName = man.Name;
            ViewBag.ManAge = man.Age;
            ViewBag.WomanName = woman.Name;
            ViewBag.WomanAge = woman.Age;
            return View();
        }
    }
}