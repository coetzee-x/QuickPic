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

            modelBuilder.Entity<Objective>().HasData(
                new Objective { Id = 1, QuestionId = 1, Expectation = 8 },
                new Objective { Id = 2, QuestionId = 2, Expectation = 8 },
                new Objective { Id = 3, QuestionId = 3, Expectation = 5 },
                new Objective { Id = 4, QuestionId = 4, Expectation = 5 },
                new Objective { Id = 5, QuestionId = 5, Expectation = 2 },
                new Objective { Id = 6, QuestionId = 6, Expectation = 5 },
                new Objective { Id = 7, QuestionId = 7, Expectation = 30 },
                new Objective { Id = 8, QuestionId = 8, Expectation = 22 },
                new Objective { Id = 9, QuestionId = 9, Expectation = 5 },
                new Objective { Id = 10, QuestionId = 10, Expectation = 10 }
           );

        }

        public DbSet<Respondent> Respondents { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<RespondentResult> RespondentResults { get; set; }
        public DbSet<Objective> Objectives { get; set; }
    }
}
