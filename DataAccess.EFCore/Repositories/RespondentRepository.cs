using Domain.Interfaces;
using Domain.Models;
using System.Linq;

namespace DataAccess.EFCore.Repositories
{
    public class RespondentRepository : IRespondentRepository
    {
        private readonly ApplicationContext _applicationContext;

        public RespondentRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public Respondent GetById(int id)
        {
            return _applicationContext.Respondents.FirstOrDefault(x => x.Id == id);
        }

        public Respondent GetByUsernameAndPassword(string username, string password)
        {
            return _applicationContext.Respondents.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
