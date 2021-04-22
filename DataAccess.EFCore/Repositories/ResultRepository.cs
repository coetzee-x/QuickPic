using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.EFCore.Repositories
{
    public class ResultRepository : IResultRepository
    {
        private readonly ApplicationContext _applicationContext;

        private readonly IQuestionRepository _questionRepository;

        public ResultRepository(ApplicationContext applicationContext, IQuestionRepository questionRepository)
        {
            _applicationContext = applicationContext;
            _questionRepository = questionRepository;
        }

        public IEnumerable<Result> Get()
        {
            List<Result> model = new List<Result>();

            var questions = _questionRepository.GetAll();

            var results = _applicationContext.RespondentResults.ToList();

            if (results.Count > 0) 
            {
                foreach (var question in questions)
                {
                    var sum = (from x in results where x.Question.Id == question.Id select x.Answer).Sum();
                    var total = (from x in results where x.Question.Id == question.Id select x).Count();
                    var average = sum / total;

                    Result result = new Result
                    {
                        Question = question.Text,
                        RespondentsWeight = average,
                        ManagersWeight = _applicationContext.Objectives.FirstOrDefault(x => x.Question.Id == question.Id).Expectation,
                    };

                    var gap = result.ManagersWeight - result.RespondentsWeight;

                    result.ExpectationGap = gap;

                    var accuracy = ((result.ManagersWeight - result.RespondentsWeight) / result.RespondentsWeight) * 100;

                    result.Accuracy = accuracy;

                    model.Add(result);
                }
            }

            return model;
        }
    }
}
