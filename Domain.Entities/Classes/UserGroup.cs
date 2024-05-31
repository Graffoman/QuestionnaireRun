using Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Classes
{
    public class UserGroup : IEntity
    {
        public string Id { get; set; }
    }
}
