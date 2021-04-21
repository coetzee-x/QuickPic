using Domain.Models;

namespace Domain.Interfaces
{
    public interface IRespondentRepository
    {
        Respondent GetByUsernameAndPassword(string username, string password);
        Respondent GetById(int id);
    }
}
