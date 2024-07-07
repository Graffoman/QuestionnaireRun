using AutoMapper;
using Domain.Entities.Classes;
using Services.Abstractions;
using Services.Contracts.Group;
using Services.Contracts.UserDto;
using Services.Contracts.UserGroupDto;
using Services.Repositories.Abstractions;
using System.Text.RegularExpressions;

namespace Services.Implementations
{
    public class UserGroupService : IUserGroupService
    {
        private readonly IMapper _mapper;
        private readonly IUserGroupRepository _userGroupRepository;

        public UserGroupService(IMapper mapper, IUserGroupRepository userGroupRepository)
        {
            _mapper = mapper;
            _userGroupRepository = userGroupRepository;
        }



        public Task<UserGroupDto> GetByIdAsync(string id)
        {
            return _userGroupRepository.GetAsync(id, CancellationToken.None);
        }

        public async Task<string> CreateAsync(CreateUserGroupDto createUserGroupDto)
        {
            var UserGroup = _mapper.Map<CreateUserGroupDto, UserGroup>(createUserGroupDto);

            await _userGroupRepository.AddAsync(UserGroup);
            
            return UserGroup.Id;
        }

        public Task<bool> UpdateAsync(string id, UpdateUserGroupDto updateUserGroupDto)
        {
            var UserGroup = _mapper.Map<UpdateUserGroupDto, UserGroup>(updateUserGroupDto);

            return _userGroupRepository.UpdateAsync(UserGroup, CancellationToken.None);
        }

        //public Task<string> DeleteAsync(UserGroup userGroup)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<bool> DeleteAsync(string id)
        {
            return _userGroupRepository.Delete(id);
        }

        public Task<List<UserGroup>> GetAllAsync()
        {
            return _userGroupRepository.GetAllAsync(CancellationToken.None);
        }

        public async Task<ICollection<UserGroupDto>> GetListAsync()
        {
            ICollection<UserGroup> entities = await _userGroupRepository.GetListAsync();
            return _mapper.Map<ICollection<UserGroup>, ICollection<UserGroupDto>>(entities);
        }

        public async Task<ICollection<UserDto>> GetUserListAsync(string id)
        {
            ICollection<User> entities = await _userGroupRepository.GetUserListAsync(id);
            return _mapper.Map<ICollection<User>, ICollection<UserDto>>(entities);
        }
    }
}
