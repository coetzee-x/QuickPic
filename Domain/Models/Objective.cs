using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Objective
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int Expectation { get; set; }
    }
}
