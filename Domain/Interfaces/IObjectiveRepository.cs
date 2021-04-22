using Domain.Models;

namespace Domain.Interfaces
{
    public interface IObjectiveRepository
    {
        Objective GetByQuestionId(int id);
    }
}
