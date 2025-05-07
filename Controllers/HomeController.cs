using MvcProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProducts.Controllers
{
    public class HomeController : Controller
    {
        List<ProductModel> Pro = new List<ProductModel>()
        {
            new ProductModel()
            {
                Id = 1, Name = "Adidas Shoes", Picture = "~/images/Adidas.jpg", Price = 10000.0
            },
            new ProductModel()
            {
                Id = 2, Name = "Champion Shoes", Picture = "~/images/Champion.jpg", Price = 15000.0
            },
            new ProductModel()
            {
                Id = 3, Name = "Nike Shoes", Picture = "~/images/Nike.jpg", Price = 8000.0
            },
            new ProductModel()
            {
                Id = 4, Name = "U.S. Polo Shoes", Picture = "~/images/U.S. Polo.jpg", Price = 20000.0
            }
        };
        public ActionResult Index()
        {
            return View(Pro);
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