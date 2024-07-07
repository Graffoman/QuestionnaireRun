using AutoMapper;
using Domain.Entities.Classes;
using MassTransit;
using Services.Abstractions;
using Services.Contracts.Group;
using Services.Contracts.UserDto;
using Services.Repositories.Abstractions;
using System.Data;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IBusControl _busControl;

        public UserService(
            IMapper mapper,
            IUserRepository userRepository,
            IBusControl busControl)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _busControl = busControl;
        }

        public async Task<UserDto> GetByIdAsync(string id)
        {
            var user = await _userRepository.GetAsync(id, CancellationToken.None);

            UserDto userdto = _mapper.Map<User, UserDto>(user);

            //ICollection<UserGroup> groupentities = await _userRepository.GetGroupListAsync(id);
            //userdto.Groups = _mapper.Map<ICollection<UserGroup>, ICollection<GroupDto>>(groupentities).ToList();

            return userdto;
        }


        public async Task<string> CreateAsync(CreateUserDto createUserDto)
        {
            var user = _mapper.Map<CreateUserDto, User>(createUserDto);
            await _userRepository.AddAsync(user);
            return user.Id;
        }

        public async Task UpdateAsync(string id, UpdateUserDto updatingUserDto)
        {
            var user = await _userRepository.GetAsync(id, CancellationToken.None);
            if (user == null)
            {
                throw new Exception($"Пользователь с идентфикатором {id} не найден");
            }

            user.FirstName = updatingUserDto.FirstName;
            user.LastName = updatingUserDto.LastName;
            user.Department = updatingUserDto.Department;
            user.Email = updatingUserDto.Email;

            _userRepository.Update(user);
            await _userRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var user = await _userRepository.GetAsync(id, CancellationToken.None);
            if (user == null)
            {
                throw new Exception($"Пользователь с идентфикатором {id} не найден");
            }
            user.Deleted = true;
            await _userRepository.SaveChangesAsync();
        }

        //public Task<string> DeleteByIdAsync(string id)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<ICollection<UserDto>> GetListAsync()
        {
            ICollection<User> entities = await _userRepository.GetListAsync();
            return _mapper.Map<ICollection<User>, ICollection<UserDto>>(entities);
        }

        //public async Task<ICollection<GroupDto>> GetGroupListAsync(string id)
        //{
        //    ICollection<UserGroup> entities = await _userRepository.GetGroupListAsync(id);
        //    return _mapper.Map<ICollection<UserGroup>, ICollection<GroupDto>>(entities);
        //}
    }
}
