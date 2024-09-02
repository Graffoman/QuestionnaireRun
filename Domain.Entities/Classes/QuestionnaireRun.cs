using Domain.Entities.Enums;
using Domain.Entities.Interfaces;

namespace Domain.Entities.Classes
{
    public class QuestionnaireRun : IEntityMongoDB
    {
        public string Id { get; set; }
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
