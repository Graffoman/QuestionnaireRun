﻿using AutoMapper;
using Domain.Entities.Classes;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using Services.Contracts.QuestionnaireSubmitDto;
using Services.Contracts.UserGroupDto;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGroupController : ControllerBase
    {
        private readonly IUserGroupService _service;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UserGroupController(IUserGroupService service, ILogger<UserGroupController> logger, IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var userGroup = await _service.GetByIdAsync(id);
            return Ok(userGroup);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var userGroup = await _service.GetAllAsync();
            return Ok(userGroup);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateUserGroupDto createUserGroupDto)
        {
            var id = await _service.CreateAsync(createUserGroupDto);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, UpdateUserGroupDto updateUserGroupDto)
        {
            var userGroupDto = _mapper.Map<UpdateUserGroupDto, UserGroup>(updateUserGroupDto);
            userGroupDto.Id = id;

            await _service.UpdateAsync(id, updateUserGroupDto);
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
