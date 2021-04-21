using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.EFCore.Repositories
{
    public class RespondentResultRepository : IRespondentResultRepository
    {
        private readonly ApplicationContext _applicationContext;

        public RespondentResultRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void Add(RespondentResult model)
        {
            _applicationContext.RespondentResults.Add(model);

            _applicationContext.SaveChanges();
        }
    }
}
