using Domain.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts.QuestionnaireSubmitDto
{
    public class UpdateQuestionnaireSubmitDto
    {
        public User User { get; set; }
        public User Author { get; set; }
        public QuestionnaireRun QuestionnaireRun { get; set; }
        public DateTime SubmitDate { get; set; }
        public string Answers { get; set; }
    }
}
