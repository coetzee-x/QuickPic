using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QuickPic.Web.Models;
using System.Collections.Generic;

namespace QuickPic.Web.Controllers
{
    public class ResultController : Controller
    {
        private readonly IResultRepository _resultRepository;

        public ResultController(IResultRepository resultRepository)
        {
            _resultRepository = resultRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var results = _resultRepository.Get();

            List<ResultViewModel> model = new List<ResultViewModel>();

            foreach (var result in results) 
            {
                model.Add(new ResultViewModel
                {
                    Question = result.Question,
                    RespondentWeight = result.RespondentsWeight,
                    ExpectationGap = result.ExpectationGap,
                    Accuracy = result.Accuracy,
                    ManagersWeight = result.ManagersWeight
                });
            }

            return View(model);
        }
    }
}
