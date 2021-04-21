using Microsoft.AspNetCore.Mvc;
using QuickPic.Web.Models;
using System;

namespace QuickPic.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        public AuthenticationController()
        {

        }

        [HttpGet]
        public ActionResult Index() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(AuthenticationViewModel model) 
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            if (ModelState.IsValid) 
            {
                return RedirectToAction("Index", "Survey");
            }

            return View("Index");
        }
    }
}
