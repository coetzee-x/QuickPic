using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QuickPic.Web.Models;
using System.Collections.Generic;

namespace QuickPic.Web.Controllers
{
    public class SurveyController : Controller
    {
        private readonly IQuestionRepository _questionRepository;

        public SurveyController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        public ActionResult Index()
        {
            var questions = _questionRepository.GetAll();

            List<SurveyViewModel> model = new List<SurveyViewModel>();

            foreach (var question in questions)
            {
                model.Add(new SurveyViewModel
                {
                    QuestionId = question.Id,
                    QuestionText = question.Text,
                    Answer = 0
                });
            }

            return View(model);
        }
    }
}
