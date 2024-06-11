using Domain.Entities.Classes;
using Infrastructure.DataAcess;
using Services.Repositories.Abstractions;

namespace Infrastructure.Repositories.Implementations
{
    public class QuestionnaireSubmitRepository : RepositoryMongoDB<QuestionnaireSubmit>, IQuestionnaireSubmitRepository
    {
        public QuestionnaireSubmitRepository(MongoDB<QuestionnaireSubmit> db) : base(db)
        {

        }
    }
}