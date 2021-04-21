using System.Collections.Generic;

namespace Domain.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ICollection<RespondentResult> RespondentResults { get; set; }
        public ICollection<Objective> Questions { get; set; }
    }
}
