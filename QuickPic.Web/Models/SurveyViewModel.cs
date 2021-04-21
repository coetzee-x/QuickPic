using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickPic.Web.Models
{
    public class SurveyViewModel
    {
        public int QuestionId { get; set; }

        public string QuestionText { get; set; }

        public int Answer { get; set; }
    }
}
