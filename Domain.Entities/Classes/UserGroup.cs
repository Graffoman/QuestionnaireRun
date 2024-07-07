using Domain.Entities.Interfaces;

namespace Domain.Entities.Classes
{
    public class UserGroup : IEntityPostgresDB<string>
    {
        public string Id { get; set; }
        public string GroupId { get; set; }
        public string Name { get; set; }
        public virtual List<UserGroup> UserGroups { get; set; }
        public bool Deleted { get; set; }
    }
}
