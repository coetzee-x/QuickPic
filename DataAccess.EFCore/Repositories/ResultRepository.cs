using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.EFCore.Repositories
{
    public class ResultRepository : IResultRepository
    {
        private readonly ApplicationContext _applicationContext;

        public ResultRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public IEnumerable<Result> Get()
        {
            List<Result> model = new List<Result>();

            var questions = _applicationContext.Questions.ToList();

            var results = _applicationContext.RespondentResults.ToList();

            foreach (var question in questions) 
            {
                Result result = new Result
                {
                    RespondentsWeight = (from x in results where x.Question.Id == question.Id select x.Answer).Sum() / results.Where(x => x.Question.Id == question.Id).Count(),
                    ManagersWeight = _applicationContext.Objectives.FirstOrDefault(x => x.Question.Id == question.Id).Expectation,
                };

                result.ExpectationGap = result.ManagersWeight = result.RespondentsWeight;
                result.Accuracy = 10;

                model.Add(result);
            }

            return model;
        }
    }
}
