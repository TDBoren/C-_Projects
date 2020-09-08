using FirstMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.FirstNAme = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;
            //Random rnd = new Random(10);
            //int num = rnd.Next();
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"E:\C#_Projects\FirstMVCApp\log.txt", text);
            return View(user);
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