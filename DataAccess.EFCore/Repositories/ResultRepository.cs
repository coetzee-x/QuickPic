using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.EFCore.Repositories
{
    public class ResultRepository : IResultRepository
    {
        private readonly ApplicationContext _applicationContext;

        private readonly IQuestionRepository _questionRepository;

        private readonly IObjectiveRepository _objectiveRepository;

        public ResultRepository(ApplicationContext applicationContext, IQuestionRepository questionRepository, IObjectiveRepository objectiveRepository)
        {
            _applicationContext = applicationContext;
            _questionRepository = questionRepository;
            _objectiveRepository = objectiveRepository;
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
                    var mWeight = _objectiveRepository.GetByQuestionId(question.Id).Expectation;

                    var rSum = (from x in results where x.Question.Id == question.Id select x.Answer).Sum();
                    var rTotal = (from x in results where x.Question.Id == question.Id select x).Count();
                    var rWeight = rSum / rTotal;

                    Result result = new Result
                    {
                        Question = question.Text,
                        RespondentsWeight = rWeight,
                        ManagersWeight = mWeight,
                        ExpectationGap = mWeight - rWeight
                    };

                    if (mWeight > rWeight)
                        result.Accuracy = 100 - Math.Abs((Math.Round(((result.RespondentsWeight - result.ManagersWeight) / result.ManagersWeight) * 100, 2)));
                    else
                        result.Accuracy = Math.Round(((result.ManagersWeight - result.RespondentsWeight) / result.RespondentsWeight) * 100, 2);

                    model.Add(result);
                }
            }

            return model;
        }
    }
}
