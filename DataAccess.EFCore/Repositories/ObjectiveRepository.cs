using Domain.Interfaces;
using Domain.Models;
using System.Linq;

namespace DataAccess.EFCore.Repositories
{
    public class ObjectiveRepository : IObjectiveRepository
    {
        private readonly ApplicationContext _applicationContext;

        public ObjectiveRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public Objective GetByQuestionId(int id)
        {
            return _applicationContext.Objectives.FirstOrDefault(x => x.QuestionId == id);
        }
    }
}
