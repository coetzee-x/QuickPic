namespace Domain.Models
{
    public class RespondentResult
    {
        public int Id { get; set; }
        public int Answer { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int RespondentId { get; set; }
        public Respondent Respondent { get; set; }
    }
}
