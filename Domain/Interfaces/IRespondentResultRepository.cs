using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IRespondentResultRepository
    {
        void Add(RespondentResult model);
        IEnumerable<RespondentResult> GetAll();
    }
}
