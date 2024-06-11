using Domain.Entities.Classes;
using Services.Abstractions;
using Services.Contracts.QuestionnaireSubmitDto;

namespace Services.Implementations
{
    public class QuestionnaireSubmitService : IQuestionnaireSubmitService
    {
        public Task<string> CreateAsync(CreateQuestionnaireSubmitDto createQuestionnaireSubmitDto)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(QuestionnaireSubmit questionnaireSubmit)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<QuestionnaireSubmit>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<QuestionnaireSubmit> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(QuestionnaireSubmit questionnaireSubmit)
        {
            throw new NotImplementedException();
        }
    }
}
