using AutoMapper;
using Domain.Entities.Classes;
using Services.Contracts.UserGroupDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations.Mapping
{
    public class UserGroupMappingsProfile : Profile
    {
        public UserGroupMappingsProfile() 
        {
            CreateMap<CreateUserGroupDto, UserGroup>()
                .ForMember(x => x.Id, map => map.Ignore());
        }
    }
}
