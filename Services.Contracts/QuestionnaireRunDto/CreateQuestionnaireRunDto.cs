using Domain.Entities.Classes;
using Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts.QuestionnaireRunDto
{
    /// <summary>
    /// ДТО запуска опроса
    /// </summary>
    public class CreateQuestionnaireRunDto
    {
        public string QuestionnaireId { get; set; }
        public QuestionnaireRunState State { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<DateTime> SendDate { get; set; }
        public List<User> User { get; set; }
        public List<UserGroup> UserGroup { get; set; }
        public User Author { get; set; }
    }
}
