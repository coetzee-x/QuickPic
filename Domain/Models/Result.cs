namespace Domain.Models
{
    public class Result
    {
        public string Question { get; set; }
        public int RespondentsWeight { get; set; }
        public int ExpectationGap { get; set; }
        public int Accuracy { get; set; }
        public int ManagersWeight { get; set; }
    }
}
