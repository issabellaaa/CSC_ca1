using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult addProduct()
        {
            ViewBag.Title = "Add a Product";

            return View();
        }

        public ActionResult updateProduct()
        {
            ViewBag.Title = "Update a Product";

            return View();
        }
    }
}
