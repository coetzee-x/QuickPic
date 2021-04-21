using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using QuickPic.Web.Models;
using System;
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

        [HttpGet]
        public ActionResult Index()
        {
            var questions = _questionRepository.GetAll();

            SurveyViewModel model = new SurveyViewModel();

            foreach (var question in questions)
            {
                model.Questions.Add(new QuestionViewModel
                {
                    QuestionId = question.Id,
                    QuestionText = question.Text,
                    Answer = 0
                });
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Submit(SurveyViewModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            if (ModelState.IsValid) 
            {
                
            }

            return View("Index", model);
        }
    }
}
