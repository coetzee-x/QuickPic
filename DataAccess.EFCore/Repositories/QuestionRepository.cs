using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.EFCore.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ApplicationContext _applicationContext;

        public QuestionRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public Question GetById(int id)
        {
            return _applicationContext.Questions.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Question> GetAll()
        {
            return _applicationContext.Questions.ToList();
        }
    }
}
