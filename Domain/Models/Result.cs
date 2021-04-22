namespace Domain.Models
{
    public class Result
    {
        public string Question { get; set; }
        public decimal RespondentsWeight { get; set; }
        public decimal ExpectationGap { get; set; }
        public decimal Accuracy { get; set; }
        public decimal ManagersWeight { get; set; }
    }
}
