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

        //public async Task<string> DeleteAsync(QuestionnaireRun questionnaireRun)
        //{
        //    throw new NotImplementedException();
        //}

        public Task<bool> DeleteByIdAsync(string id)
        {
            return _questionnaireRunRepository.DeleteAsync(id, CancellationToken.None);
        }

        public async Task<ICollection<QuestionnaireRun>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<QuestionnaireRun> GetByIdAsync(string id)
        {
            return _questionnaireRunRepository.GetAsync(id, CancellationToken.None);
        }

        public async Task<string> UpdateAsync(QuestionnaireRun questionnaireRun)
        {
            throw new NotImplementedException();
        }
    }
}
