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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Respondent>().HasData(
                new Respondent { Id = 1, Username = "u1", Firstname = "John", Lastname = "Smith", Password = "password" },
                new Respondent { Id = 2, Username = "u2", Firstname = "Susan", Lastname = "Birnam", Password = "password" },
                new Respondent { Id = 3, Username = "u3", Firstname = "Carter", Lastname = "Flamings", Password = "password" },
                new Respondent { Id = 4, Username = "u4", Firstname = "Elrond", Lastname = "Raven", Password = "password" },
                new Respondent { Id = 5, Username = "u5", Firstname = "Frodo", Lastname = "Smitherns", Password = "password" }
            );

            modelBuilder.Entity<Question>().HasData(
                new Question { Id = 1, Text = "Internal Meetings" },
                new Question { Id = 2, Text = "Client Meetings" },
                new Question { Id = 3, Text = "Emails & Phone / Skype calls" },
                new Question { Id = 4, Text = "Research" },
                new Question { Id = 5, Text = "DB Design" },
                new Question { Id = 6, Text = "Architecture Design and Planning" },
                new Question { Id = 7, Text = "Back-end Development" },
                new Question { Id = 8, Text = "Front-end Development" },
                new Question { Id = 9, Text = "Integration" },
                new Question { Id = 10, Text = "Testing" }
                );
        }

        public DbSet<Respondent> Respondents { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<RespondentResult> RespondentResults { get; set; }
    }
}
