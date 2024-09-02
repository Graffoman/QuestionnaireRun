using AutoMapper;
using Domain.Entities.Classes;
using Services.Abstractions;
using Services.Contracts.UserDto;
using Services.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(
            IMapper mapper,
            IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserDto> GetByIdAsync(string id)
        {
            var user = await _userRepository.GetAsync(id, CancellationToken.None);

            UserDto userDto = _mapper.Map<User, UserDto>(user);

            return userDto;
        }

        public async Task<string> CreateAsync(CreateUserDto createUserDto)
        {
            var user = _mapper.Map<CreateUserDto, User>(createUserDto);
            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync(); // Сохраняем изменения, чтобы получить сгенерированный Id
            return user.Id.ToString(); // Возвращаем Id в виде строки
        }

        public async Task UpdateAsync(string id, UpdateUserDto updatingUserDto)
        {
            var user = await _userRepository.GetAsync(id, CancellationToken.None);
            if (user == null)
            {
                throw new Exception($"Пользователь с идентификатором {id} не найден");
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
                throw new Exception($"Пользователь с идентификатором {id} не найден");
            }
            user.Deleted = true;
            await _userRepository.SaveChangesAsync();
        }

        public async Task<ICollection<UserDto>> GetListAsync()
        {
            ICollection<User> entities = await _userRepository.GetListAsync();
            return _mapper.Map<ICollection<User>, ICollection<UserDto>>(entities);
        }
    }
}