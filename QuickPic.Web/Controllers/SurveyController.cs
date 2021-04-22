using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using QuickPic.Web.Models;
using System;
using System.Linq;

namespace QuickPic.Web.Controllers
{
    public class SurveyController : Controller
    {
        private readonly IQuestionRepository _questionRepository;

        private readonly IRespondentResultRepository _respondentResultRepository;

        private readonly IRespondentRepository _respondentRepository;

        public SurveyController(IQuestionRepository questionRepository, IRespondentResultRepository respondentResultRepository, IRespondentRepository respondentRepository)
        {
            _questionRepository = questionRepository;
            _respondentResultRepository = respondentResultRepository;
            _respondentRepository = respondentRepository;
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
                    Random = Guid.NewGuid(),
                    QuestionId = question.Id,
                    QuestionText = question.Text,
                    Answer = 0
                });
            }

            model.Questions = model.Questions.OrderBy(x => x.Random).ToList();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Submit(SurveyViewModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            var total = (from x in model.Questions select x.Answer).Sum();

            if (total > 100 || total < 100)
            {
                ModelState.AddModelError("TotalModelError", $"The total entered values cannot be less than or exceed 100. Your current total is {total}.");
                return View("Index", model);
            }

            if (ModelState.IsValid)
            {
                foreach (var item in model.Questions) 
                {
                    var question = _questionRepository.GetById(item.QuestionId);

                    var respondent = _respondentRepository.GetById(1);

                    _respondentResultRepository.Add(new RespondentResult
                    {
                        Question = question,
                        Respondent = respondent,
                        Answer = item.Answer
                    });
                }

                return RedirectToAction("Confirmation", "Survey");
            }

            return View("Index", model);
        }

        [HttpGet]
        public ActionResult Confirmation() 
        {
            return View();
        }
    }
}
