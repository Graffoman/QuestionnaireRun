using Domain.Entities.Classes;

namespace Services.Contracts.UserDto
{
    public class UpdateUserDto
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Department { get; set; }
    }
}
