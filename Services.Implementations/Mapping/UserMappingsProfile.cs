using AutoMapper;
using Domain.Entities.Classes;
using Services.Contracts.UserDto;

namespace Services.Implementations.Mapping
{
    public class UserMappingsProfile : Profile
    {
        public UserMappingsProfile() 
        {
            CreateMap<CreateUserDto, User>()
                .ForMember(x => x.Id, map => map.Ignore())
                .ForMember(x => x.UserId, map => map.MapFrom(src => src.UserId))
                .ForMember(x => x.Email, map => map.MapFrom(src => src.Email))
                .ForMember(x => x.FirstName, map => map.MapFrom(src => src.FirstName))
                .ForMember(x => x.LastName, map => map.MapFrom(src => src.LastName));
        }
    }
}
