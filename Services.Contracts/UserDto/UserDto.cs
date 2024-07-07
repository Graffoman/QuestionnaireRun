using Services.Contracts.Group;

namespace Services.Contracts.UserDto
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<GroupDto> Groups { get; set; }
    }
}
