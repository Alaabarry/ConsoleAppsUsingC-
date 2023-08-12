using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteMVC.Models;
using WebsiteMVC.ViewModels;


namespace WebsiteMVC.Controllers
{ 
   
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUP(string FirstName,string LastName,string EmailAddress) {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress))
            {

                return View("~/Views/Shared/Error.cshtml");


            }
            else {
                using (WebsiteEntities db = new WebsiteEntities()) { 
                var signup = new SignUp(); 
                signup.FirstName = FirstName; 
                signup.LastName = LastName; 
                signup.EmailAddress = EmailAddress; 

                db.SignUps.Add(signup); 
                db.SaveChanges();
                
                }
                
                
                }
                    return View("~/Views/Success.cshtml");
            
            }
            
    }
}