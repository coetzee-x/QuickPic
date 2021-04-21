using Domain.Interfaces;
using Domain.Models;
using System;

namespace DataAccess.EFCore.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        public Respondent Get(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
