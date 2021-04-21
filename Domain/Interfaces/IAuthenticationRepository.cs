using Domain.Models;

namespace Domain.Interfaces
{
    public interface IAuthenticationRepository
    {
        Respondent Get(string username, string password);
    }
}
