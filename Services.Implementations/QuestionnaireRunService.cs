using AutoMapper;
using Domain.Entities.Classes;
using Services.Abstractions;
using Services.Contracts.QuestionnaireRunDto;
using Services.Repositories.Abstractions;


namespace Services.Implementations
{
    public class QuestionnaireRunService : IQuestionnaireRunService
    {

        private readonly IMapper _mapper;
        private readonly IQuestionnaireRunRepository _questionnaireRunRepository;

        public QuestionnaireRunService(IMapper mapper, IQuestionnaireRunRepository questionnaireRunRepository)
        {
            _mapper = mapper;
            _questionnaireRunRepository = questionnaireRunRepository;
        }


        public async Task<string> CreateAsync(CreateQuestionnaireRunDto createQuestionnaireRunDto)
        {
            var questionnaireRun = _mapper.Map<CreateQuestionnaireRunDto, QuestionnaireRun>(createQuestionnaireRunDto);
            await _questionnaireRunRepository.AddAsync(questionnaireRun, CancellationToken.None);
            return questionnaireRun.Id;

        }

        public Task<bool> DeleteByIdAsync(string id)
        {
            return _questionnaireRunRepository.DeleteAsync(id, CancellationToken.None);
        }

        public Task<List<QuestionnaireRun>> GetAllAsync()
        {
            return _questionnaireRunRepository.GetAllAsync(CancellationToken.None);
        }

        public Task<QuestionnaireRun> GetByIdAsync(string id)
        {
            return _questionnaireRunRepository.GetAsync(id, CancellationToken.None);
        }

        public Task<bool> UpdateAsync(QuestionnaireRun questionnaireRun)
        {
            return _questionnaireRunRepository.UpdateAsync(questionnaireRun, CancellationToken.None);
        }
    }
}
