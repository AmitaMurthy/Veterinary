using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veterinary.Models;

namespace Veterinary.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MyRegister register)
        {
            return View("ThankYouForRegistering", register);
        }
    }
}