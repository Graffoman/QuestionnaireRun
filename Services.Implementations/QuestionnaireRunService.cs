using Domain.Entities.Classes;
using Services.Abstractions;
using Services.Contracts.QuestionnaireRunDto;


namespace Services.Implementations
{
    public class QuestionnaireRunService : IQuestionnaireRunService
    {
        public Task<string> CreateAsync(CreateQuestionnaireRunDto createQuestionnaireRunDto)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(QuestionnaireRun questionnaireRun)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<QuestionnaireRun>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<QuestionnaireRun> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(QuestionnaireRun questionnaireRun)
        {
            throw new NotImplementedException();
        }
    }
}
