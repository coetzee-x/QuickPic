using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.EFCore.Repositories
{
    public class QuestionReptory : IQuestionRepository
    {
        private readonly ApplicationContext _applicationContext;

        public QuestionReptory(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public IEnumerable<Question> GetAll()
        {
            return _applicationContext.Questions.ToList();
        }
    }
}
