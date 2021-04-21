using Domain.Interfaces;
using Domain.Models;
using System.Linq;

namespace DataAccess.EFCore.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly ApplicationContext _applicationContext;

        public AuthenticationRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public Respondent Get(string username, string password)
        {
            return _applicationContext.Respondents.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
