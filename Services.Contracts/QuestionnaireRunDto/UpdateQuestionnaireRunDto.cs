using Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts.QuestionnaireRunDto
{
    internal class UpdateQuestionnaireRunDto
    {
        public QuestionnaireRunState State { get; set; }
        public List<DateTime>? SendDates { get; set; }
    }
}
