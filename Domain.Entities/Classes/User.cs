using Domain.Entities.Interfaces;

namespace Domain.Entities.Classes
{
    public class User : IEntityPostgresDB<string>
    {
        //public string UserId { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Department { get; set; }
        public List<UserGroup> UserGroups { get; set; }
        public bool Deleted { get; set; }
    }
}
