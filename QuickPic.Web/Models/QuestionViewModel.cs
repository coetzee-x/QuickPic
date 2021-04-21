using System.ComponentModel.DataAnnotations;

namespace QuickPic.Web.Models
{
    public class QuestionViewModel
    {
        public int QuestionId { get; set; }

        public string QuestionText { get; set; }

        [Range(0, 100, ErrorMessage = "The value entered is not correct and should be between 0 and 100.")]
        public int Answer { get; set; }
    }
}
