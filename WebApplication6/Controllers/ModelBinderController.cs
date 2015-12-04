using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class ModelBinderController : Controller
    {
        // GET: ModelBinder
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test(decimal amount)
        {
            return View(amount);
        }
    }
}