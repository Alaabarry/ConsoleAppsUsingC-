using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User(); 
            user.Id = 1;

            user.Firstname = "Alaa";
            user.Lastname = "Barry";
            user.Age = "25";


            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Alaa barry web developer";

            return View();
        }
    }
}