using System;
using System.ComponentModel.DataAnnotations;

namespace QuickPic.Web.Models
{
    public class QuestionViewModel
    {
        public Guid Random { get; set; }
        public int QuestionId { get; set; }

        public string QuestionText { get; set; }

        [Range(1, 100, ErrorMessage = "The value entered is not correct. The minimum value is 1 and maximum value 100.")]
        public int Answer { get; set; }
    }
}
