using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }
        public DbSet<Respondent> Respondents { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<RespondentResult> RespondentResults { get; set; }
    }
}
