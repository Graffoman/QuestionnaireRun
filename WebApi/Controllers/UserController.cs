using AutoMapper;
using Domain.Entities.Classes;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using Services.Contracts.UserDto;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UserController(IUserService service, ILogger<UserController> logger, IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var user = await _service.GetByIdAsync(id);
            return Ok(user);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAllAsync()
        //{
        //    var user = await _service.GetAllAsync();
        //    return Ok(user);
        //}

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateUserDto createUserDto)
        {
            var id = await _service.CreateAsync(createUserDto);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, UpdateUserDto updateUserDto)
        {
            var user = _mapper.Map<UpdateUserDto, User>(updateUserDto);
            user.Id = id;

            await _service.UpdateAsync(id, updateUserDto);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}
