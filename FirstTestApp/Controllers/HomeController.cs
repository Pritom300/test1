using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstTestApp.Models;
using Stripe;

namespace FirstTestApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

           return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }






        public IActionResult Charge(string stripeEmail, string stringToken)
        {
            //var customer = new CustomerService();
            //var charge = new ChargeService();

            //var createOptions = new CustomerCreateOptions
            //{
            //    Email = "example@example.com",
            //    SourceToken = stringToken,
            //};



            //var ch = new ChargeCreateOptions
            //{
            //    Amount = 500,
            //    Description = "Test Project",
            //    Currency = "USD",


            //};

            //if (ch.Status == "succeed")
            //{
            //    string BalanceTransactionId = ch.BalanceTransactionId;
            //    return View();
            //}


            //return View();


            var chargeotions = new StripeChargeCreateOptions()
            {
                Amount=500,
                Currency="stirptoken",


            };



            var service = new StripeChargeService();
            var charge = service.Create(chargeotions);

            if(charge.Status=="succeeded")
            {
                return View();
            }

            return View("failure");
          

            

            
        }








        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
