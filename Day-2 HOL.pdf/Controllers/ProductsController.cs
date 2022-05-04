using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_Day2.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            Models.Product p = new Models.Product();
            //pass a list of products to the view return View(p.GetProducts());
            return View(p.GetProducts());
        }

    }
}