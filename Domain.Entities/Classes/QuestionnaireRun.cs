using Domain.Entities.Enums;
using Domain.Entities.Interfaces;

namespace Domain.Entities.Classes
{
    public class QuestionnaireRun : IEntity
    {
        public string Id { get; set; }
        public string QuestionnaireId { get; set; }
        public QuestionnaireRunState State { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<DateTime>? SendDates { get; set; }
        public List<User>? Users { get; set; }
        public List<UserGroup>? UserGroups { get; set; }
        public User Author { get; set; }
    }
}
