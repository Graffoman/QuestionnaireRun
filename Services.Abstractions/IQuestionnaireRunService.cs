using Services.Contracts.QuestionnaireRunDto;
using Domain.Entities.Classes;

namespace Services.Abstractions
{
    /// <summary>
    /// Интерфейс сервиса работы с запуском опроса.
    /// </summary>
    public interface IQuestionnaireRunService
    {
        Task<List<QuestionnaireRun>> GetAllAsync();
        Task<QuestionnaireRun> GetByIdAsync(string id);
        Task<string> CreateAsync(CreateQuestionnaireRunDto createQuestionnaireRunDto);
        Task<bool> UpdateAsync(QuestionnaireRun questionnaireRun);
        Task<bool> DeleteByIdAsync(string id);
        //Task<string> DeleteAsync(QuestionnaireRun questionnaireRun);
    }
}
