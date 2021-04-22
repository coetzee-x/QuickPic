using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QuickPic.Web.Models;
using System;

namespace QuickPic.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        private const string ADMIN_USERNAME = "Administrator";
        private const string ADMIN_PASSWORD = "Password123";

        private readonly IRespondentRepository _authenticationRepository;
        public AuthenticationController(IRespondentRepository authenticationRepository)
        {
            _authenticationRepository = authenticationRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(AuthenticationViewModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            if (ModelState.IsValid)
            {
                if (model.Username == ADMIN_USERNAME
                    && model.Password == ADMIN_PASSWORD)
                    return RedirectToAction("Index", "Result");

                var respondent = _authenticationRepository.GetByUsernameAndPassword(model.Username, model.Password);

                if (respondent == null)
                    return View("Index");

                return RedirectToAction("Index", "Survey");
            }

            return View("Index");
        }
    }
}
