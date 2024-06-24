using AutoMapper;
using Domain.Entities.Classes;
using Services.Abstractions;
using Services.Contracts.QuestionnaireSubmitDto;
using Services.Repositories.Abstractions;

namespace Services.Implementations
{
    public class QuestionnaireSubmitService : IQuestionnaireSubmitService
    {
        private readonly IMapper _mapper;
        private readonly IQuestionnaireSubmitRepository _questionnaireSubmitRepository;

        public QuestionnaireSubmitService(IMapper mapper, IQuestionnaireSubmitRepository questionnaireSubmitRepository)
        {
            _mapper = mapper;
            _questionnaireSubmitRepository = questionnaireSubmitRepository;
        }


        public async Task<string> CreateAsync(CreateQuestionnaireSubmitDto createQuestionnaireSubmitDto)
        {
            var QuestionnaireSubmit = _mapper.Map<CreateQuestionnaireSubmitDto, QuestionnaireSubmit>(createQuestionnaireSubmitDto);
            await _questionnaireSubmitRepository.AddAsync(QuestionnaireSubmit, CancellationToken.None);
            return QuestionnaireSubmit.Id;

        }

        public Task<bool> DeleteByIdAsync(string id)
        {
            return _questionnaireSubmitRepository.DeleteAsync(id, CancellationToken.None);
        }

        public Task<List<QuestionnaireSubmit>> GetAllAsync()
        {
            return _questionnaireSubmitRepository.GetAllAsync(CancellationToken.None);
        }

        public Task<QuestionnaireSubmit> GetByIdAsync(string id)
        {
            return _questionnaireSubmitRepository.GetAsync(id, CancellationToken.None);
        }

        public Task<bool> UpdateAsync(QuestionnaireSubmit QuestionnaireSubmit)
        {
            return _questionnaireSubmitRepository.UpdateAsync(QuestionnaireSubmit, CancellationToken.None);
        }
    }
}
