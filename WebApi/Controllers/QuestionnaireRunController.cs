using AutoMapper;
using Domain.Entities;
using Domain.Entities.Classes;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using Services.Contracts.QuestionnaireRunDto;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionnaireRunController : ControllerBase
    {
        private readonly IQuestionnaireRunService _service;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public QuestionnaireRunController(IQuestionnaireRunService service, ILogger<QuestionnaireRunController> logger, IMapper mapper)
        {
            _service = service;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var questionnaireRun = await _service.GetByIdAsync(id);
            return Ok(questionnaireRun);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var questionnaireRuns = await _service.GetAllAsync();
            return Ok(questionnaireRuns);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateQuestionnaireRunDto createQuestionnaireRunDto)
        {
            var id = await _service.CreateAsync(createQuestionnaireRunDto);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, UpdateQuestionnaireRunDto updateQuestionnaireRunDto)
        {
            var questionnaireRun = _mapper.Map<UpdateQuestionnaireRunDto, QuestionnaireRun>(updateQuestionnaireRunDto);
            questionnaireRun.Id = id;

            await _service.UpdateAsync(questionnaireRun);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteByIdAsync(string id)
        {
            await _service.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
