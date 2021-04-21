using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IQuestionRepository
    {
        Question GetById(int id);
        IEnumerable<Question> GetAll();
    }
}
