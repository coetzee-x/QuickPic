using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IResultRepository
    {
        IEnumerable<Result> Get();
    }
}
