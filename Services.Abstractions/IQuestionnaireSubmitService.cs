using Services.Contracts.QuestionnaireSubmitDto;
using Domain.Entities.Classes;

namespace Services.Abstractions
{
    public interface IQuestionnaireSubmitService
    {
        Task<List<QuestionnaireSubmit>> GetAllAsync();
        Task<QuestionnaireSubmit> GetByIdAsync(string id);
        Task<string> CreateAsync(CreateQuestionnaireSubmitDto createQuestionnaireSubmitDto);
        Task<bool> UpdateAsync(QuestionnaireSubmit questionnaireSubmit);
        Task<bool> DeleteByIdAsync(string id);
        //Task<string> DeleteAsync(QuestionnaireSubmit questionnaireSubmit);
    }
}
