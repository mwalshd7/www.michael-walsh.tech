using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myApp2.Models;

namespace myApp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

          public IActionResult Cv()
        {
            return View();
        }

//        public IActionResult Contact(){
//
//            return View();
//        }

        public IActionResult SiteInfo()
        {
            return View();
        }

        public IActionResult Examples()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /*Setup and Send Email */
        private readonly EmailAddress FromAndToEmailAddress;
        private IEmailService EmailService;

        public HomeController(EmailAddress _fromAddress,
            IEmailService _emailService)
        {
            FromAndToEmailAddress = _fromAddress;
            EmailService = _emailService;
        }

        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactFormModel model)
        {
            if (! ModelState.IsValid)
            { // re-render the view when validation failed.
                return View("Contact", model);
            }


            else if (ModelState.IsValid)
            {
                EmailMessage msgToSend = new EmailMessage
                {
                    FromAddresses = new List<EmailAddress> { FromAndToEmailAddress },
                    ToAddresses = new List<EmailAddress> { FromAndToEmailAddress },
                    Content = $"Here is your message: Name: {model.Name}, " +
                        $"Email: {model.Email}, Message: {model.Message}, Mobile:{model.Phone}" ,
                    Subject = "Contact Form - michaelwalsh.tech"
                };

                EmailService.Send(msgToSend);
                return RedirectToAction("Success");
            }
            else
            {
                return Index();
            }
        }
    }
}

