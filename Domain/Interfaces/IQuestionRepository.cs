using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IQuestionRepository
    {
        Question Get(int id);
        IEnumerable<Question> GetAll();
    }
}
