﻿using Domain.Entities.Classes;
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
        public DateTime? SendDate { get; set; }
        public List<User>? Users { get; set; }
        public List<UserGroup>? UserGroups { get; set; }
        public User Author { get; set; }
    }
}
