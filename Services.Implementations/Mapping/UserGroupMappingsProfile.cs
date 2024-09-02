using AutoMapper;
using Domain.Entities.Classes;
using Services.Contracts.UserGroupDto;

namespace Services.Implementations.Mapping
{
    public class UserGroupMappingsProfile : Profile
    {
        public UserGroupMappingsProfile() 
        {
            CreateMap<CreateUserGroupDto, UserGroup>()
                .ForMember(x => x.Id, map => map.Ignore())
                .ForMember(x => x.GroupId, map => map.Ignore())
                .ForMember(x => x.Name, map => map.MapFrom(src => src.  Name))
                //.ForMember(x => x.UserGroups, map => map.Ignore())
                .ForMember(d => d.Deleted, map => map.Ignore());

            CreateMap<UpdateUserGroupDto, UserGroup>()
                .ForMember(x => x.Id, map => map.Ignore())
                .ForMember(x => x.GroupId, map => map.Ignore())
                .ForMember(x => x.Name, map => map.MapFrom(src => src.Name))
                //.ForMember(x => x.UserGroups, map => map.Ignore())
                .ForMember(d => d.Deleted, map => map.Ignore());
        }
    }
}
