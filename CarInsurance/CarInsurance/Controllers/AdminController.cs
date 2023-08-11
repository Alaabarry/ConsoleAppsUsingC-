using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModel;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var UserQuoteList = db.Insurees;
                var quoteList = new List<ViewQuotes>();
                foreach (var signup in UserQuoteList)
                {
                    var quote = new ViewQuotes();
                    
                    quote.FirstName = signup.FirstName;
                    quote.LastName = signup.LastName; 
                    quote.EmailAddress = signup.EmailAddress;
                    quote.Quote = signup.Quote;
                    quoteList.Add(quote);

                }
                return View(quoteList);

            }


        }
    }
}

