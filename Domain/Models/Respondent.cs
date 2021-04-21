using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Respondent
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
