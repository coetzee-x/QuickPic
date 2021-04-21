using System.Collections.Generic;

namespace QuickPic.Web.Models
{
    public class SurveyViewModel
    {
        public SurveyViewModel()
        {
            Questions = new List<QuestionViewModel>();

        }

        public List<QuestionViewModel> Questions { get; set; }
    }
}
