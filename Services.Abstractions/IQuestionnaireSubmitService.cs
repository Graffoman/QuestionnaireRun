using Services.Contracts.QuestionnaireSubmitDto;
using Domain.Entities.Classes;

namespace Services.Abstractions
{
    public interface IQuestionnaireSubmitService
    {
        Task<ICollection<QuestionnaireSubmit>> GetAllAsync();
        Task<QuestionnaireSubmit> GetByIdAsync(string id);
        Task<string> CreateAsync(CreateQuestionnaireSubmitDto createQuestionnaireSubmitDto);
        Task<string> UpdateAsync(QuestionnaireSubmit questionnaireSubmit);
        Task<string> DeleteByIdAsync(string id);
        Task<string> DeleteAsync(QuestionnaireSubmit questionnaireSubmit);
    }
}
