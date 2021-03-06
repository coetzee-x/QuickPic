using System.Collections.Generic;

namespace Domain.Models
{
    public class Respondent
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<RespondentResult> RespondentResults { get; set; }
    }
}
