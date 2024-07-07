using Domain.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts.UserGroupDto
{
    public class UpdateUserGroupDto
    {
        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
