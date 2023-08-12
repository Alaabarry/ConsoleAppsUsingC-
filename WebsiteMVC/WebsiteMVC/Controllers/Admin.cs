using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteMVC.Models;
using WebsiteMVC.ViewModels;

namespace WebsiteMVC.Controllers
{
    public class Admin : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (WebsiteEntities db = new WebsiteEntities())
            {
                var SignUps = db.SignUps;
                var signupsVm = new List<SignupVm>();
                foreach (var signup in SignUps)

                {
                    var signupvm = new SignupVm(); 
                    signupvm.Id = signup.Id;
                    signupvm.FirstName = signup.FirstName;
                    signupvm.LastName = signup.LastName;
                    signupvm.EmailAddress = signup.EmailAddress;
                    signupsVm.Add(signupvm);

                }

                return View(signupsVm);

            }


        }
    }
}